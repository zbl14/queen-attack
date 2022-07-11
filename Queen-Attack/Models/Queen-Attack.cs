using System;

namespace QueenAttack.Models
{
  public class Queen
  {
    public int X { get; set; } 
    public int Y { get; set; } 

    public Queen(int x, int y)
    {
      X = x;
      Y = y;
    }
    public bool CanAttack(int xo, int yo)
    {
      if (X == xo || Y == yo) return true;

      if (Math.Abs(X - xo) == Math.Abs(Y - yo)) return true;

      return false;
    }
  }
}