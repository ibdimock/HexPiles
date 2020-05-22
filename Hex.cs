using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HexPiles
{

  /*  Indexes a hex grid on 3 axis, always preseving Z + X + Y = 0
   *  
           ______
          /      \
         /        \
  ,-----<  0,1,-1  >-----.
 /       \        /       \
/         \___ __/         \
\  -1,1,0 / Y    \  1,0,-1 /
 \       /   \    \       /
  >-----<     . -X >-----<
 /       \   /    /       \
/  -1,0,1 \_Z____/  1,-1,0 \
\         /      \         /
 \       /        \       /
  `-----<  0,-1,1  >--=--'
         \        /
          \______/

*/

  [DebuggerDisplay("(<{X},{Y},{Z}>")]
  public struct HexCoordinate
  {
    internal int X;
    internal int Y;
    internal int Z;

    internal HexCoordinate(int X, int Y)
    {
      this.X = X;
      this.Y = Y;
      this.Z = -(X + Y);
    }

    public HexCoordinate[] GetNeighbours()
    {
      return new HexCoordinate[6]
      {
        new HexCoordinate(this.X - 1, this.Y),
        new HexCoordinate(this.X - 1, this.Y + 1),
        new HexCoordinate(this.X, this.Y + 1),
        new HexCoordinate(this.X + 1, this.Y),
        new HexCoordinate(this.X + 1, this.Y - 1),
        new HexCoordinate(this.X, this.Y - 1)
      };     
    }
  }

}
