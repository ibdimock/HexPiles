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

    }
  }
}
