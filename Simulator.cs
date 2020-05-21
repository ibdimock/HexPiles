using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HexPiles
{
  static class Simulator
  {
    const int OverFlowLevel = 5;

    public static bool DoIteration(Dictionary<HexCoordinate, ulong> CurrentState, Dictionary<HexCoordinate, ulong> NextState)
    {
      bool HasOverflows = false;
      foreach (KeyValuePair<HexCoordinate, ulong> cell in CurrentState)
      {
        if (cell.Value > OverFlowLevel)
        {
          ulong keep_amount = cell.Value % 6;
          ulong overflow_amount = cell.Value / 6;

          AddSand(NextState, cell.Key, keep_amount);
          foreach (HexCoordinate neighbour in cell.Key.GetNeighbours())
          {
            AddSand(NextState, neighbour, overflow_amount);
          }
          HasOverflows = true;
        } else
        {
          AddSand(NextState, cell.Key, cell.Value);
        }
      }

      return HasOverflows;
    }

    static void AddSand(Dictionary<HexCoordinate, ulong> NextState, HexCoordinate coordinate, ulong sand)
    {
      if (!NextState.ContainsKey(coordinate))
      {
        NextState.Add(coordinate, sand);
      } else
      {
        NextState[coordinate] += sand;
      }
    }
  }
}
