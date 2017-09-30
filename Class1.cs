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




static void Main(String[] args)
{
int n = Convert.ToInt32(Console.ReadLine());

//char d = Convert.ToChar(Console.ReadLine());
string[] tokensX = Console.ReadLine().Split(' ');

int x = Convert.ToInt32(tokensX[0]);

int y = Convert.ToInt32(tokensX[1]);

// Write Your Code Here
//Console.WriteLine(d);
var myArray = new int[n, n];

int N = n * n;
int i;

int j;

    for (i = 0; i<n;
i++)
{
    //Console.Write("{0}", i + 1);
    for (j = 0; j < n; j++)
    {
        if (x == 1 && y == 0)
        {
            //myArray[i, j] = N;
            myArray[i, j] = i * j;
            Console.WriteLine("{0}", myArray[i, j]);
        }
        N = N - 1;
    }
    Console.WriteLine("\n");
    Console.ReadLine();
}

}