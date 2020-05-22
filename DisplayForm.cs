using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HexPiles
{
  public partial class DisplayForm : Form
  {
    public DisplayForm()
    {
      InitializeComponent();
    }

    private void simulationBackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
    {
      ulong StartingSand = (ulong)e.Argument;

      Dictionary<HexCoordinate, ulong> CurrentState = new Dictionary<HexCoordinate, ulong>();
      Dictionary<HexCoordinate, ulong> NextState = new Dictionary<HexCoordinate, ulong>();
      ulong estimatedCellCount = StartingSand / 3;


      CurrentState.Add(new HexCoordinate(0, 0), StartingSand);

      while (Simulator.DoIteration(CurrentState, NextState))
      {
        CurrentState = NextState;

        int currentProgress = (int)(100 * ((ulong)CurrentState.Count()) / estimatedCellCount);
        if (currentProgress > 100) currentProgress = 100;
        simulationBackgroundWorker.ReportProgress(currentProgress);

        NextState = new Dictionary<HexCoordinate, ulong>();
      }

      simulationBackgroundWorker.ReportProgress(100);

      e.Result = NextState;
    }

    private void simulationBackgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
    {
      simulationProgressBar.Value = e.ProgressPercentage;
    }

    private void startButton_Click(object sender, EventArgs e)
    {
      ulong StartingSand = 1UL << ((int)powerNumericUpDown.Value);
      simulationBackgroundWorker.RunWorkerAsync(StartingSand);
    }

    private void simulationBackgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
    {
      HexGridRenderer HGR = new HexGridRenderer(pictureBox1.Width, pictureBox1.Height, 4);
      Palette P = new Palette(6);
      P.SetColor(0, Color.FromArgb(255,0,0));
      P.SetColor(1, Color.FromArgb(255, 255, 0));
      P.SetColor(2, Color.FromArgb(0, 255, 0));
      P.SetColor(3, Color.FromArgb(0, 255, 255));
      P.SetColor(4, Color.FromArgb(0, 0, 255));
      P.SetColor(5, Color.FromArgb(255, 0, 255));

      Bitmap B = HGR.RenderHexGrid(P, e.Result as Dictionary<HexCoordinate, ulong>);

      pictureBox1.Image = B;
    }
  }
}
