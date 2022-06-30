namespace SetCover
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class StartUp
    {
        static void Main(string[] args)
        {
          int[] universe = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
          int numberOfSets = int.Parse(Console.ReadLine());
          int[][] jaggedSets = new int[numberOfSets][];

            for (int row = 0; row < jaggedSets.Length; row++)
            {
                int[] rowsValue = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
                jaggedSets[row] = new int[rowsValue.Length];
                for (int col = 0; col < jaggedSets[row].Length; col++)
                {
                    jaggedSets[row][col] = rowsValue[col];
                }
            }
            List<int[]> selectedSets = ChooseSets(jaggedSets.ToList(), universe.ToList());
            Console.WriteLine($"Sets to take ({selectedSets.Count}):");
            foreach(int[] set in selectedSets)
            {
                Console.WriteLine($"{{ {string.Join(", ",set )} }} ");
               
            }
        }

        public static List<int[]> ChooseSets(List<int[]> sets, IList<int> universe)
        {
            List<int[]> selectedSets = new List<int[]>();

            while(universe.Count > 0)
            {
                int[] current = sets.OrderByDescending(set => set.Count(universe.Contains)).First();
                selectedSets.Add(current);
                sets.Remove(current);
                foreach (int i in current) 
                {
                    universe.Remove(i);
                }
            }
            return selectedSets;
        }
    }
}
