using System;
using System.Collections;
using System.Collections.Generic;

namespace FindClusterSizes
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[,] test = new int[,]
            {
                { 1, 1, 0, 0, 0, 1 },
                { 1, 1, 1, 0, 0, 1 },
                { 0, 1, 0, 0, 0, 0 },
                { 1, 1, 0, 1, 1, 0 },
                { 0, 0, 1, 1, 0, 0 }
            };
            IEnumerable<int> returned = FindClusterSizes(test);
            foreach (int i in returned)
            {
                Console.Write($"{i} ");
            }
        }

        // Take in a rectangular array of 1s and 0s. Within this grid, identify the size of each "cluster",
        //  i.e. contiguous "island" of 1s, and return an array of the size of each cluster."
        public static IEnumerable<int> FindClusterSizes(int[,] grid)
        {
            List<int> clusterSizes = new List<int>();
            Queue<int[]> q = new Queue<int[]>();
            int height = grid.GetLength(0);
            int width = grid.GetLength(1);
            for(int i = 0; i < height; i++)
            {
                for(int j = 0; j < width; j++)
                {
                    if(grid[i, j] == 1)
                    {
                        grid[i, j] = 2;
                        int sizeCounter = 0;
                        q.Enqueue(new int[] { i, j });
                        while(q.Count > 0)
                        {
                            int[] xy = q.Dequeue();
                            sizeCounter++;

                            if(xy[0] < height - 1 && grid[xy[0] + 1, xy[1]] == 1)
                            {
                                grid[xy[0] + 1, xy[1]] = 2;
                                q.Enqueue(new int[] { xy[0] + 1, xy[1] });

                            }
                            if(xy[0] > 0 && grid[xy[0] - 1, xy[1]] == 1)
                            {
                                grid[xy[0] - 1, xy[1]] = 2;
                                q.Enqueue(new int[] { xy[0] - 1, xy[1] });
                            }
                            if(xy[1] < width - 1 && grid[xy[0], xy[1] + 1] == 1)
                            {
                                grid[xy[0], xy[1] + 1] = 2;
                                q.Enqueue(new int[] { xy[0], xy[1] + 1});
                            }
                            if(xy[1] > 0 && grid[xy[0], xy[1] - 1] == 1)
                            {
                                grid[xy[0], xy[1] - 1] = 2;
                                q.Enqueue(new int[] { xy[0], xy[1] - 1 });
                            }
                        }
                        clusterSizes.Add(sizeCounter);
                    }
                }
            }
            return clusterSizes;
        }
    }
}
