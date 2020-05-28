using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace HexPiles
{
  class HexGridRenderer
  {
    const float Root3Over2 = 0.866025403f;

    int imageWidth;
    int imageHeight;

    float cellRadius;

    float originX;
    float originY;

    public HexGridRenderer(int imageWidth, int imageHeight, float cellRadius)
    {
      originX = 0.5f * (imageWidth + 1);
      originY = 0.5f * (imageHeight + 1);
      this.imageWidth = imageWidth;
      this.imageHeight = imageHeight;
      this.cellRadius = cellRadius;
    }

    public Bitmap RenderHexGrid(Palette P, Dictionary<HexCoordinate, ulong> GridState)
    {
      Bitmap image = new Bitmap(imageWidth, imageHeight);
      using (Graphics gfx = Graphics.FromImage(image))
      {
        gfx.FillRectangle(Brushes.Black, 0, 0, imageWidth, imageHeight);

        gfx.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
        //gfx.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;

        foreach (KeyValuePair<HexCoordinate, ulong> cell in GridState)
        {
          using (Brush B = new SolidBrush(P.GetColor((int)cell.Value)))
          {
            gfx.FillPolygon(B, BoundaryPoints(cell.Key));
            //gfx.DrawPolygon(Pens.Black, BoundaryPoints(cell.Key));
          }
        }
      }

      return image;
    }

    PointF[] BoundaryPoints(HexCoordinate coordinate)
    {
      float centerX = originX + cellRadius * coordinate.X * 1.5f;
      float centerY = originY + cellRadius * (-coordinate.X * Root3Over2 - coordinate.Y * 2 * Root3Over2);

      PointF[] boundary = new PointF[6];
      boundary[0] = new PointF(centerX + cellRadius * 1, centerY + cellRadius * 0);
      boundary[1] = new PointF(centerX + cellRadius * 0.5f, centerY + cellRadius * Root3Over2);
      boundary[2] = new PointF(centerX - cellRadius * 0.5f, centerY + cellRadius * Root3Over2);
      boundary[3] = new PointF(centerX - cellRadius * 1, centerY + cellRadius * 0);
      boundary[4] = new PointF(centerX - cellRadius * 0.5f, centerY - cellRadius * Root3Over2);
      boundary[5] = new PointF(centerX + cellRadius * 0.5f, centerY - cellRadius * Root3Over2);

      return boundary;
    }
  }
}
