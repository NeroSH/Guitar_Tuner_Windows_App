﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SoundCapture;
using System.Diagnostics;
using System.IO;

namespace GuitarTuner
{
    public partial class MainForm : Form
    {
        bool isListenning = false;

        public bool IsListenning
        {
            get { return isListenning; }
        }

        public MainForm()
        {
            InitializeComponent();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("log.txt", FileMode.Append);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine(DateTime.Now + " Закрытие программы кнопкой \"Закрыть\" внизу окна");
            sw.Close();
            fs.Close();

            Close();
        }

        FrequencyInfoSource frequencyInfoSource;

        private void StopListenning()
        {
            isListenning = false;
            frequencyInfoSource.Stop();
            frequencyInfoSource.FrequencyDetected -= new EventHandler<FrequencyDetectedEventArgs>(frequencyInfoSource_FrequencyDetected);
            frequencyInfoSource = null;
        }

        private void StartListenning(SoundCaptureDevice device)
        {
            isListenning = true;
            frequencyInfoSource = new SoundFrequencyInfoSource(device);
            frequencyInfoSource.FrequencyDetected += new EventHandler<FrequencyDetectedEventArgs>(frequencyInfoSource_FrequencyDetected);
            frequencyInfoSource.Listen();
        }

        void frequencyInfoSource_FrequencyDetected(object sender, FrequencyDetectedEventArgs e)
        {
            if (InvokeRequired)
            {
                BeginInvoke(new EventHandler<FrequencyDetectedEventArgs>(frequencyInfoSource_FrequencyDetected), sender, e);
            }
            else
            {
                UpdateFrequecyDisplays(e.Frequency);
            }
        }

        //обновление шкалы
        private void UpdateFrequecyDisplays(double frequency)
        {
            if (frequency > 0)
            {
                frequenciesScale1.SignalDetected = true;
                frequenciesScale1.CurrentFrequency = frequency;

                frequencyTextBox.Enabled = true;
                frequencyTextBox.Text = frequency.ToString("f3");

                double closestFrequency;
                string noteName;
                FindClosestNote(frequency, out closestFrequency, out noteName);
                closeFrequencyTextBox.Enabled = true;
                closeFrequencyTextBox.Text = closestFrequency.ToString("f3");
                noteNameTextBox.Enabled = true;
                noteNameTextBox.Text = noteName;
            }
            else
            {
                frequenciesScale1.SignalDetected = false;

                frequencyTextBox.Enabled = false;
                closeFrequencyTextBox.Enabled = false;
                noteNameTextBox.Enabled = false;
            }

        }

        static string[] NoteNames = {"A", "A#", "B/H", "C", "C#", "D", "D#", "E", "F", "F#",  "G",  "G#" };
        static double ToneStep = Math.Pow(2, 1.0 / 12);

        //поиск ближайшей ноты
        private void FindClosestNote(double frequency, out double closestFrequency, out string noteName)
        {
            const double AFrequency = 440.0;
            const int ToneIndexOffsetToPositives = 120;

            int toneIndex = (int)Math.Round(Math.Log(frequency / AFrequency, ToneStep));
            noteName = NoteNames[(ToneIndexOffsetToPositives + toneIndex) % NoteNames.Length];
            closestFrequency = Math.Pow(ToneStep, toneIndex) * AFrequency;
        }

        private void listenButton_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("log.txt", FileMode.Append);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine(DateTime.Now + " Начало записи");
            sw.Close();
            fs.Close();

            SoundCaptureDevice device = null;
            using (SelectDeviceForm form = new SelectDeviceForm())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    device = form.SelectedDevice;
                }
            }

            if (device != null)
            {
                StartListenning(device);
                UpdateListenStopButtons();
            }
        }

        private void UpdateListenStopButtons()
        {
            listenButton.Enabled = !isListenning;
            stopButton.Enabled = isListenning;
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("log.txt", FileMode.Append);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine(DateTime.Now + " Конец записи");
            sw.Close();
            fs.Close();

            StopListenning();
            UpdateListenStopButtons();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (IsListenning)
            {
                StopListenning();
            }
        }

        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("help.rtf");
        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
