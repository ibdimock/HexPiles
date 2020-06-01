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
    PictureBox[] palettePictureBoxes;
    Palette P;

    public DisplayForm()
    {
      InitializeComponent();

      P = new Palette(6);
      P.SetColor(0, Color.FromArgb(0, 0, 0));
      P.SetColor(1, Color.FromArgb(42, 43, 42));
      P.SetColor(2, Color.FromArgb(94, 73, 85));
      P.SetColor(3, Color.FromArgb(153, 104, 136));
      P.SetColor(4, Color.FromArgb(201, 157, 163));
      P.SetColor(5, Color.FromArgb(198, 221, 240));

      palettePictureBoxes = new PictureBox[6]
      {
        palette0PictureBox,
        palette1PictureBox,
        palette2PictureBox,
        palette3PictureBox,
        palette4PictureBox,
        palette5PictureBox
      };

      for (int i = 0; i < 6; i++)
      {
        RenderPaletteHex(P, i, palettePictureBoxes[i]);
      }
    }

    void RenderPaletteHex(Palette P, int i, PictureBox pictureBox)
    {
      HexGridRenderer HGR = new HexGridRenderer(pictureBox.Width, pictureBox.Height, 0.5f * pictureBox.Width);
      Dictionary<HexCoordinate, ulong> Cell = new Dictionary<HexCoordinate, ulong>();
      Cell.Add(new HexCoordinate(0, 0), (ulong)i);
      Bitmap B = HGR.RenderHexGrid(P, Cell);
      pictureBox.Image = B;
    }

    int iterations = 0;
    private void simulationBackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
    {
      ulong StartingSand = (ulong)e.Argument;

      Dictionary<HexCoordinate, ulong> CurrentState = new Dictionary<HexCoordinate, ulong>();
      Dictionary<HexCoordinate, ulong> NextState = new Dictionary<HexCoordinate, ulong>();
      ulong estimatedCellCount = StartingSand / 3;


      CurrentState.Add(new HexCoordinate(0, 0), StartingSand);

      iterations = 0;

      while (Simulator.DoIteration(CurrentState, NextState))
      {
        iterations++;
        CurrentState = NextState;

        int currentProgress = (int)(100 * Math.Pow((double)CurrentState.Count() / estimatedCellCount, 2));
        if (currentProgress > 100) currentProgress = 100;
        simulationBackgroundWorker.ReportProgress(currentProgress, CurrentState.Count);

        NextState = new Dictionary<HexCoordinate, ulong>(CurrentState.Count);
        //foreach (HexCoordinate hexCoordinate in CurrentState.Keys)
        //{
        //  NextState.Add(hexCoordinate, 0);
        //}
      }

      simulationBackgroundWorker.ReportProgress(100, NextState.Count);

      e.Result = NextState;
    }

    private void simulationBackgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
    {
      simulationProgressBar.Value = e.ProgressPercentage;
      iterationsLabel.Text = String.Format("Iterations: {0}", iterations);
      timeLabel.Text = String.Format("Time: {0:0.00}s", (DateTime.Now - SimStart).TotalSeconds);
      cellsLabel.Text = String.Format("Hex Cells: {0:0}", e.UserState);
    }

    DateTime SimStart;
    private void startButton_Click(object sender, EventArgs e)
    {
      ulong StartingSand = 1UL << ((int)powerNumericUpDown.Value);
      SimStart = DateTime.Now;
      simulationBackgroundWorker.RunWorkerAsync(StartingSand);
    }

    Dictionary<HexCoordinate, ulong> LastSimulationResult;

    private void simulationBackgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
    {

      LastSimulationResult = e.Result as Dictionary<HexCoordinate, ulong>;

      Render();

    }

    private void renderButton_Click(object sender, EventArgs e)
    {
      Render();
    }

    private void Render()
    {
      HexGridRenderer HGR = new HexGridRenderer(pictureBox1.Width, pictureBox1.Height, (float)scaleNumericUpDown.Value);
    

      Bitmap B = HGR.RenderHexGrid(P, LastSimulationResult as Dictionary<HexCoordinate, ulong>);

      pictureBox1.Image = B;
    }

        private void palette0PictureBox_Click(object sender, EventArgs e)
        {
          if (palettePickerDialog.ShowDialog() == DialogResult.OK)
      {
        Color C = palettePickerDialog.Color;
        P.SetColor(0, C);
        RenderPaletteHex(P, 0, palettePictureBoxes[0]);
        //Render();
      }
        }

    private void palette1PictureBox_Click(object sender, EventArgs e)
    {
      if (palettePickerDialog.ShowDialog() == DialogResult.OK)
      {
        Color C = palettePickerDialog.Color;
        P.SetColor(1, C);
        RenderPaletteHex(P, 1, palettePictureBoxes[1]);
        //Render();
      }
    }

    private void palette2PictureBox_Click(object sender, EventArgs e)
    {
      if (palettePickerDialog.ShowDialog() == DialogResult.OK)
      {
        Color C = palettePickerDialog.Color;
        P.SetColor(2, C);
        RenderPaletteHex(P, 2, palettePictureBoxes[2]);
        //Render();
      }
    }

    private void palette3PictureBox_Click(object sender, EventArgs e)
    {
      if (palettePickerDialog.ShowDialog() == DialogResult.OK)
      {
        Color C = palettePickerDialog.Color;
        P.SetColor(3, C);
        RenderPaletteHex(P, 3, palettePictureBoxes[3]);
        //Render();
      }
    }

    private void palette4PictureBox_Click(object sender, EventArgs e)
    {
      if (palettePickerDialog.ShowDialog() == DialogResult.OK)
      {
        Color C = palettePickerDialog.Color;
        P.SetColor(4, C);
        RenderPaletteHex(P, 4, palettePictureBoxes[4]);
        //Render();
      }
    }

    private void palette5PictureBox_Click(object sender, EventArgs e)
    {
      if (palettePickerDialog.ShowDialog() == DialogResult.OK)
      {
        Color C = palettePickerDialog.Color;
        P.SetColor(5, C);
        RenderPaletteHex(P, 5, palettePictureBoxes[5]);
        //Render();
      }
    }
  }
}
