namespace HexPiles
{
  partial class DisplayForm
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
      this.startButton = new System.Windows.Forms.Button();
      this.simulationBackgroundWorker = new System.ComponentModel.BackgroundWorker();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.powerNumericUpDown = new System.Windows.Forms.NumericUpDown();
      this.simulationProgressBar = new System.Windows.Forms.ProgressBar();
      this.pictureBox1 = new System.Windows.Forms.PictureBox();
      this.iterationsLabel = new System.Windows.Forms.Label();
      this.renderButton = new System.Windows.Forms.Button();
      this.palette0PictureBox = new System.Windows.Forms.PictureBox();
      this.palette1PictureBox = new System.Windows.Forms.PictureBox();
      this.palette2PictureBox = new System.Windows.Forms.PictureBox();
      this.palette3PictureBox = new System.Windows.Forms.PictureBox();
      this.palette4PictureBox = new System.Windows.Forms.PictureBox();
      this.palette5PictureBox = new System.Windows.Forms.PictureBox();
      this.scaleNumericUpDown = new System.Windows.Forms.NumericUpDown();
      this.label3 = new System.Windows.Forms.Label();
      this.palettePickerDialog = new System.Windows.Forms.ColorDialog();
      ((System.ComponentModel.ISupportInitialize)(this.powerNumericUpDown)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.palette0PictureBox)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.palette1PictureBox)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.palette2PictureBox)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.palette3PictureBox)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.palette4PictureBox)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.palette5PictureBox)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.scaleNumericUpDown)).BeginInit();
      this.SuspendLayout();
      // 
      // startButton
      // 
      this.startButton.Location = new System.Drawing.Point(135, 12);
      this.startButton.Name = "startButton";
      this.startButton.Size = new System.Drawing.Size(117, 27);
      this.startButton.TabIndex = 0;
      this.startButton.Text = "Start Simulation";
      this.startButton.UseVisualStyleBackColor = true;
      this.startButton.Click += new System.EventHandler(this.startButton_Click);
      // 
      // simulationBackgroundWorker
      // 
      this.simulationBackgroundWorker.WorkerReportsProgress = true;
      this.simulationBackgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.simulationBackgroundWorker_DoWork);
      this.simulationBackgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.simulationBackgroundWorker_ProgressChanged);
      this.simulationBackgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.simulationBackgroundWorker_RunWorkerCompleted);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(29, 51);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(20, 24);
      this.label1.TabIndex = 1;
      this.label1.Text = "2";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(16, 9);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(84, 15);
      this.label2.TabIndex = 2;
      this.label2.Text = "Starting Sand:";
      // 
      // powerNumericUpDown
      // 
      this.powerNumericUpDown.Location = new System.Drawing.Point(53, 38);
      this.powerNumericUpDown.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
      this.powerNumericUpDown.Name = "powerNumericUpDown";
      this.powerNumericUpDown.Size = new System.Drawing.Size(33, 21);
      this.powerNumericUpDown.TabIndex = 3;
      // 
      // simulationProgressBar
      // 
      this.simulationProgressBar.Location = new System.Drawing.Point(135, 51);
      this.simulationProgressBar.Name = "simulationProgressBar";
      this.simulationProgressBar.Size = new System.Drawing.Size(301, 23);
      this.simulationProgressBar.TabIndex = 4;
      // 
      // pictureBox1
      // 
      this.pictureBox1.Location = new System.Drawing.Point(13, 101);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new System.Drawing.Size(698, 521);
      this.pictureBox1.TabIndex = 5;
      this.pictureBox1.TabStop = false;
      // 
      // iterationsLabel
      // 
      this.iterationsLabel.AutoSize = true;
      this.iterationsLabel.Location = new System.Drawing.Point(272, 18);
      this.iterationsLabel.Name = "iterationsLabel";
      this.iterationsLabel.Size = new System.Drawing.Size(70, 15);
      this.iterationsLabel.TabIndex = 6;
      this.iterationsLabel.Text = "Iterations: 0";
      // 
      // renderButton
      // 
      this.renderButton.Location = new System.Drawing.Point(553, 53);
      this.renderButton.Name = "renderButton";
      this.renderButton.Size = new System.Drawing.Size(80, 23);
      this.renderButton.TabIndex = 7;
      this.renderButton.Text = "Render";
      this.renderButton.UseVisualStyleBackColor = true;
      this.renderButton.Click += new System.EventHandler(this.renderButton_Click);
      // 
      // palette0PictureBox
      // 
      this.palette0PictureBox.Location = new System.Drawing.Point(452, 9);
      this.palette0PictureBox.Name = "palette0PictureBox";
      this.palette0PictureBox.Size = new System.Drawing.Size(40, 34);
      this.palette0PictureBox.TabIndex = 8;
      this.palette0PictureBox.TabStop = false;
      this.palette0PictureBox.Click += new System.EventHandler(this.palette0PictureBox_Click);
      // 
      // palette1PictureBox
      // 
      this.palette1PictureBox.Location = new System.Drawing.Point(498, 9);
      this.palette1PictureBox.Name = "palette1PictureBox";
      this.palette1PictureBox.Size = new System.Drawing.Size(40, 34);
      this.palette1PictureBox.TabIndex = 9;
      this.palette1PictureBox.TabStop = false;
      this.palette1PictureBox.Click += new System.EventHandler(this.palette1PictureBox_Click);
      // 
      // palette2PictureBox
      // 
      this.palette2PictureBox.Location = new System.Drawing.Point(544, 9);
      this.palette2PictureBox.Name = "palette2PictureBox";
      this.palette2PictureBox.Size = new System.Drawing.Size(40, 34);
      this.palette2PictureBox.TabIndex = 10;
      this.palette2PictureBox.TabStop = false;
      this.palette2PictureBox.Click += new System.EventHandler(this.palette2PictureBox_Click);
      // 
      // palette3PictureBox
      // 
      this.palette3PictureBox.Location = new System.Drawing.Point(590, 9);
      this.palette3PictureBox.Name = "palette3PictureBox";
      this.palette3PictureBox.Size = new System.Drawing.Size(40, 34);
      this.palette3PictureBox.TabIndex = 11;
      this.palette3PictureBox.TabStop = false;
      this.palette3PictureBox.Click += new System.EventHandler(this.palette3PictureBox_Click);
      // 
      // palette4PictureBox
      // 
      this.palette4PictureBox.Location = new System.Drawing.Point(636, 9);
      this.palette4PictureBox.Name = "palette4PictureBox";
      this.palette4PictureBox.Size = new System.Drawing.Size(40, 34);
      this.palette4PictureBox.TabIndex = 12;
      this.palette4PictureBox.TabStop = false;
      this.palette4PictureBox.Click += new System.EventHandler(this.palette4PictureBox_Click);
      // 
      // palette5PictureBox
      // 
      this.palette5PictureBox.Location = new System.Drawing.Point(682, 9);
      this.palette5PictureBox.Name = "palette5PictureBox";
      this.palette5PictureBox.Size = new System.Drawing.Size(40, 34);
      this.palette5PictureBox.TabIndex = 13;
      this.palette5PictureBox.TabStop = false;
      this.palette5PictureBox.Click += new System.EventHandler(this.palette5PictureBox_Click);
      // 
      // scaleNumericUpDown
      // 
      this.scaleNumericUpDown.DecimalPlaces = 1;
      this.scaleNumericUpDown.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
      this.scaleNumericUpDown.Location = new System.Drawing.Point(498, 55);
      this.scaleNumericUpDown.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
      this.scaleNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
      this.scaleNumericUpDown.Name = "scaleNumericUpDown";
      this.scaleNumericUpDown.Size = new System.Drawing.Size(49, 21);
      this.scaleNumericUpDown.TabIndex = 14;
      this.scaleNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(451, 57);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(41, 15);
      this.label3.TabIndex = 15;
      this.label3.Text = "Scale:";
      // 
      // DisplayForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(737, 634);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.scaleNumericUpDown);
      this.Controls.Add(this.palette5PictureBox);
      this.Controls.Add(this.palette4PictureBox);
      this.Controls.Add(this.palette3PictureBox);
      this.Controls.Add(this.palette2PictureBox);
      this.Controls.Add(this.palette1PictureBox);
      this.Controls.Add(this.palette0PictureBox);
      this.Controls.Add(this.renderButton);
      this.Controls.Add(this.iterationsLabel);
      this.Controls.Add(this.pictureBox1);
      this.Controls.Add(this.simulationProgressBar);
      this.Controls.Add(this.powerNumericUpDown);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.startButton);
      this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Name = "DisplayForm";
      this.Text = "Form1";
      ((System.ComponentModel.ISupportInitialize)(this.powerNumericUpDown)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.palette0PictureBox)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.palette1PictureBox)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.palette2PictureBox)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.palette3PictureBox)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.palette4PictureBox)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.palette5PictureBox)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.scaleNumericUpDown)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

        #endregion

        private System.Windows.Forms.Button startButton;
        private System.ComponentModel.BackgroundWorker simulationBackgroundWorker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown powerNumericUpDown;
        private System.Windows.Forms.ProgressBar simulationProgressBar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label iterationsLabel;
        private System.Windows.Forms.Button renderButton;
        private System.Windows.Forms.PictureBox palette0PictureBox;
        private System.Windows.Forms.PictureBox palette1PictureBox;
        private System.Windows.Forms.PictureBox palette2PictureBox;
        private System.Windows.Forms.PictureBox palette3PictureBox;
        private System.Windows.Forms.PictureBox palette4PictureBox;
        private System.Windows.Forms.PictureBox palette5PictureBox;
        private System.Windows.Forms.NumericUpDown scaleNumericUpDown;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ColorDialog palettePickerDialog;
    }
}

