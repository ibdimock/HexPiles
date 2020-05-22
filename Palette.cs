using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HexPiles
{
  class Palette
  {
    Color[] PaletteColors;

    public Palette(int colorCount)
    {
      PaletteColors = new Color[colorCount];
    }

    public Color GetColor(int colorIndex)
    {
      return PaletteColors[colorIndex];
    }

    public void SetColor(int colorIndex, Color newColor)
    {
      PaletteColors[colorIndex] = newColor;
    }
  }
}
