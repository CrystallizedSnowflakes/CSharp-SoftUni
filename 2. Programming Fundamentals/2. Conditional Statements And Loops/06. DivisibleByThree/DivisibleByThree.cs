﻿using System;



class DivisibleByThree
{
    static void Main()
    {
        /*for (int i = 1; i <= 100; i++)
        {
            if (i % 3 == 0)
            {
                Console.WriteLine(i);
            }
        }*/
        for (int i = 3; i <= 100; i+=3)
        {
            Console.WriteLine(i);
        }
    }
}

