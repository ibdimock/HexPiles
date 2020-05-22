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
      ((System.ComponentModel.ISupportInitialize)(this.powerNumericUpDown)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
      // DisplayForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(723, 634);
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
    }
}

