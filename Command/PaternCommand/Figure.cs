﻿namespace PaternCommand;

public class Figure
{

   public readonly int Size;
   public bool IsFilled = false;
   public string color { get; set; }
   
   
   public Figure(int size)
   {
      Size = size;
   }

   public void SetFilled()
   {
      IsFilled = true;
   }

   public void SetUnFilled()
   {
      IsFilled = false;
   }
}