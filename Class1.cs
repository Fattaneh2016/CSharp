using System;

public class Class1
{
	
	    
        static void Main(String[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int m = Convert.ToInt32(Console.ReadLine());
            for (int a0 = 0; a0 < m; a0++)
            {
                string[] tokens_x = Console.ReadLine().Split(' ');
                int x = Convert.ToInt32(tokens_x[0]);
                int y = Convert.ToInt32(tokens_x[1]);
                int w = Convert.ToInt32(tokens_x[2]);
                // Write Your Code Here
                if ((n >= 5 || n <= 300) && (m >= 1 || m <= 300) && (x >= 0 || y <= n - 1) && (w >= 1 || w <= 100))
                {
                    w = y + 1;
                }
                Console.WriteLine(w);

            }
        }
    }
	    

   
