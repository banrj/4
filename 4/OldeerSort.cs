using System;
using System.Collections;
using System.Collections.Generic;
namespace _4
{
	public class OldeerSort<T> : IComparer
	{

		public OldeerSort()
		{   

		}

		public int Compare(object? x, object? y)
		{

            if (x is Note<T> FirstNote && y is Note<T> SecondNote)
            {
                
                DateTime firstDate = new DateTime(FirstNote.Birthday[2],
                    FirstNote.Birthday[1], FirstNote.Birthday[0]);
                DateTime secondDate = new DateTime(SecondNote.Birthday[2],
                    SecondNote.Birthday[1], SecondNote.Birthday[0]);
                if (firstDate > secondDate) return 1;
                else if (firstDate  < secondDate) return -1;
                return 0;
            }
            throw new Exception("Невозможно сравнить");
        }
    }
}

