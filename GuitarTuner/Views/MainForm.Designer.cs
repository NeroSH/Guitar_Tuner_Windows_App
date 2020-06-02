namespace GuitarTuner
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.closeButton = new System.Windows.Forms.Button();
            this.listenButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.frequencyTextBox = new System.Windows.Forms.TextBox();
            this.hzLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.closeFrequencyTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.noteNameTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.frequenciesScale2 = new GuitarTuner.FrequenciesScale(this.components);
            this.frequenciesScale1 = new GuitarTuner.FrequenciesScale(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(107, 328);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 5;
            this.closeButton.Text = "Закрыть";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // listenButton
            // 
            this.listenButton.Location = new System.Drawing.Point(107, 32);
            this.listenButton.Name = "listenButton";
            this.listenButton.Size = new System.Drawing.Size(75, 23);
            this.listenButton.TabIndex = 1;
            this.listenButton.Text = "Старт";
            this.listenButton.UseVisualStyleBackColor = true;
            this.listenButton.Click += new System.EventHandler(this.listenButton_Click);
            // 
            // stopButton
            // 
            this.stopButton.Enabled = false;
            this.stopButton.Location = new System.Drawing.Point(107, 62);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(75, 23);
            this.stopButton.TabIndex = 2;
            this.stopButton.Text = "Стоп";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // frequencyTextBox
            // 
            this.frequencyTextBox.Location = new System.Drawing.Point(107, 157);
            this.frequencyTextBox.Name = "frequencyTextBox";
            this.frequencyTextBox.ReadOnly = true;
            this.frequencyTextBox.Size = new System.Drawing.Size(54, 20);
            this.frequencyTextBox.TabIndex = 3;
            this.frequencyTextBox.TabStop = false;
            this.frequencyTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // hzLabel
            // 
            this.hzLabel.AutoSize = true;
            this.hzLabel.Location = new System.Drawing.Point(167, 160);
            this.hzLabel.Name = "hzLabel";
            this.hzLabel.Size = new System.Drawing.Size(18, 13);
            this.hzLabel.TabIndex = 4;
            this.hzLabel.Text = "гц";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(102, 182);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "ближайшая нота";
            // 
            // closeFrequencyTextBox
            // 
            this.closeFrequencyTextBox.Location = new System.Drawing.Point(107, 200);
            this.closeFrequencyTextBox.Name = "closeFrequencyTextBox";
            this.closeFrequencyTextBox.ReadOnly = true;
            this.closeFrequencyTextBox.Size = new System.Drawing.Size(54, 20);
            this.closeFrequencyTextBox.TabIndex = 3;
            this.closeFrequencyTextBox.TabStop = false;
            this.closeFrequencyTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(167, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "гц";
            // 
            // noteNameTextBox
            // 
            this.noteNameTextBox.Location = new System.Drawing.Point(128, 226);
            this.noteNameTextBox.Name = "noteNameTextBox";
            this.noteNameTextBox.ReadOnly = true;
            this.noteNameTextBox.Size = new System.Drawing.Size(33, 20);
            this.noteNameTextBox.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(100, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Текущая частота";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.справкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(201, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.справкаToolStripMenuItem.Text = "Справка";
            this.справкаToolStripMenuItem.Click += new System.EventHandler(this.справкаToolStripMenuItem_Click);
            // 
            // frequenciesScale2
            // 
            this.frequenciesScale2.BackColor = System.Drawing.Color.White;
            this.frequenciesScale2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.frequenciesScale2.Location = new System.Drawing.Point(201, 132);
            this.frequenciesScale2.Name = "frequenciesScale2";
            this.frequenciesScale2.Size = new System.Drawing.Size(148, 148);
            this.frequenciesScale2.TabIndex = 10;
            // 
            // frequenciesScale1
            // 
            this.frequenciesScale1.BackColor = System.Drawing.Color.White;
            this.frequenciesScale1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.frequenciesScale1.Location = new System.Drawing.Point(12, 32);
            this.frequenciesScale1.Name = "frequenciesScale1";
            this.frequenciesScale1.Size = new System.Drawing.Size(67, 319);
            this.frequenciesScale1.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(201, 365);
            this.Controls.Add(this.frequenciesScale2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.noteNameTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.frequenciesScale1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.hzLabel);
            this.Controls.Add(this.closeFrequencyTextBox);
            this.Controls.Add(this.frequencyTextBox);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.listenButton);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Гитарный тюнер";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button listenButton;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.TextBox frequencyTextBox;
        private System.Windows.Forms.Label hzLabel;
        private FrequenciesScale frequenciesScale1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox closeFrequencyTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox noteNameTextBox;
        private System.Windows.Forms.Label label3;
        private FrequenciesScale frequenciesScale2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
    }
}

