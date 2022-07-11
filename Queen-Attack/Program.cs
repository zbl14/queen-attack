using System;
using QueenAttack.Models;

namespace QueenAttack
{
 public class Program
 {
  public static void Main()
  {
    Console.WriteLine("Enter your queen X coordinate.");
    string xQueen = Console.ReadLine();
    int xq = int.Parse(xQueen);

    Console.WriteLine("Enter your queen Y coordinate.");
    string yQueen = Console.ReadLine();
    int yq = int.Parse(yQueen);

    Queen newQueen = new Queen(xq, yq);
//    newQueen.X = xq;
    // newQueen.Y = yq;

    Console.WriteLine("Enter your target's X coordinate.");
    string xOther = Console.ReadLine();
    int xo = int.Parse(xOther);

    Console.WriteLine("Enter your target's Y coordinate.");
    string yOther = Console.ReadLine();
    int yo = int.Parse(yOther);

    bool attackCheck = newQueen.CanAttack(xo, yo);

    if (attackCheck == true)
    {
      Console.WriteLine("You can attack this piece!");
    }
    else
    {
      Console.WriteLine("You can not attack this!");
    }
  }
 } 
}