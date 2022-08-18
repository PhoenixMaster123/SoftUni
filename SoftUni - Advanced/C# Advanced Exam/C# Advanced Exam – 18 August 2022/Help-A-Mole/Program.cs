using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace HelpAMole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int fieldSize = int.Parse(Console.ReadLine());
            char[,] fieldMatrix = new char[fieldSize, fieldSize];           
            int MoleRowCordinates = 0;
            int MoleColCordinates = 0;

            int rowMoleSpecialPosition1 = 0;
            int colMoleSpecialPosition1 = 0;
            int rowMoleSpecialPosition2 = 0;
            int colMoleSpecialPosition2 = 0;

            int tokens = 0;
            for (int row = 0; row < fieldSize; row++)
            {
                string rowData = Console.ReadLine();
                for (int col = 0; col < fieldSize; col++)
                {
                    fieldMatrix[row, col] = rowData[col];
                    if (fieldMatrix[row, col] == 'M')
                    {
                        MoleRowCordinates = row;
                        MoleColCordinates = col;
                    }
                    else if (fieldMatrix[row, col] == 'S')
                    {
                        if (rowMoleSpecialPosition1 == 0 && colMoleSpecialPosition1 == 0)
                        {
                            rowMoleSpecialPosition1 = row;
                            colMoleSpecialPosition1 = col;
                        }
                        else
                        {
                            rowMoleSpecialPosition2 = row;
                            colMoleSpecialPosition2 = col;
                        }
                    }                  
                }
            }
            string command;
            while ((command = Console.ReadLine()) != "End")
            {
                fieldMatrix[MoleRowCordinates, MoleColCordinates] = '-';
                switch (command)
                {
                    case "up":
                        {
                            if (MoleRowCordinates - 1 < 0)
                            {
                                Console.WriteLine("Don't try to escape the playing field!");
                                break;
                            }

                            MoleRowCordinates--;
                            if (fieldMatrix[MoleRowCordinates, MoleColCordinates] == 'S')
                            {
                                if (MoleRowCordinates == rowMoleSpecialPosition1 && MoleColCordinates == colMoleSpecialPosition1)
                                {
                                    fieldMatrix[MoleRowCordinates, MoleColCordinates] = '-';
                                    fieldMatrix[rowMoleSpecialPosition2, colMoleSpecialPosition2] = 'M';

                                    MoleRowCordinates = rowMoleSpecialPosition2;
                                    MoleColCordinates = colMoleSpecialPosition2;
                                }
                                else
                                {
                                    fieldMatrix[MoleRowCordinates, MoleColCordinates] = '-';
                                    fieldMatrix[rowMoleSpecialPosition2, colMoleSpecialPosition2] = 'M';

                                    MoleRowCordinates = rowMoleSpecialPosition1;
                                    MoleColCordinates = colMoleSpecialPosition1;
                                }
                                tokens -= 3;
                                break;
                            }
                            if (char.IsDigit(fieldMatrix[MoleRowCordinates, MoleColCordinates]))
                            {                              
                                tokens += int.Parse(fieldMatrix[MoleRowCordinates, MoleColCordinates].ToString());
                                fieldMatrix[MoleRowCordinates, MoleColCordinates] = 'M';
                                break;
                            }
                            fieldMatrix[MoleRowCordinates, MoleColCordinates] = 'M';
                        };
                         break;

                    case "down":
                        {
                            if (MoleRowCordinates + 1 == fieldSize)
                            {
                                Console.WriteLine("Don't try to escape the playing field!");
                                break;
                            }
                            MoleRowCordinates++;
                            if (fieldMatrix[MoleRowCordinates, MoleColCordinates] == 'S')
                            {
                                if (MoleRowCordinates == rowMoleSpecialPosition1 && MoleColCordinates == colMoleSpecialPosition1)
                                {
                                    fieldMatrix[MoleRowCordinates, MoleColCordinates] = '-';
                                    fieldMatrix[rowMoleSpecialPosition2, colMoleSpecialPosition2] = 'M';

                                    MoleRowCordinates = rowMoleSpecialPosition2;
                                    MoleColCordinates = colMoleSpecialPosition2;
                                }
                                else
                                {
                                    fieldMatrix[MoleRowCordinates, MoleColCordinates] = '-';
                                    fieldMatrix[rowMoleSpecialPosition2, colMoleSpecialPosition2] = 'M';

                                    MoleRowCordinates = rowMoleSpecialPosition1;
                                    MoleColCordinates = colMoleSpecialPosition1;
                                }
                                tokens -= 3;
                                break;
                            }
                            if (char.IsDigit(fieldMatrix[MoleRowCordinates, MoleColCordinates]))
                            {
                                tokens += int.Parse(fieldMatrix[MoleRowCordinates, MoleColCordinates].ToString());
                                fieldMatrix[MoleRowCordinates, MoleColCordinates] = 'M';
                                break;
                            }
                            fieldMatrix[MoleRowCordinates, MoleColCordinates] = 'M';
                        }; 
                        break;

                    case "right":
                        {
                            if (MoleColCordinates + 1 == fieldSize)
                            {
                                Console.WriteLine("Don't try to escape the playing field!");
                                break;
                            }
                            MoleColCordinates++;
                            if (fieldMatrix[MoleRowCordinates, MoleColCordinates] == 'S')
                            {
                                if (MoleRowCordinates == rowMoleSpecialPosition1 && MoleColCordinates == colMoleSpecialPosition1)
                                {
                                    fieldMatrix[MoleRowCordinates, MoleColCordinates] = '-';
                                    fieldMatrix[rowMoleSpecialPosition2, colMoleSpecialPosition2] = 'M';

                                    MoleRowCordinates = rowMoleSpecialPosition2;
                                    MoleColCordinates = colMoleSpecialPosition2;
                                }
                                else
                                {
                                    fieldMatrix[MoleRowCordinates, MoleColCordinates] = '-';
                                    fieldMatrix[rowMoleSpecialPosition2, colMoleSpecialPosition2] = 'M';

                                    MoleRowCordinates = rowMoleSpecialPosition1;
                                    MoleColCordinates = colMoleSpecialPosition1;
                                }
                                tokens -= 3;
                                break;
                            }
                            if (Char.IsDigit(fieldMatrix[MoleRowCordinates, MoleColCordinates]))
                            {
                                tokens += int.Parse(fieldMatrix[MoleRowCordinates, MoleColCordinates].ToString());
                                fieldMatrix[MoleRowCordinates, MoleColCordinates] = 'M';
                                break;
                            }
                            fieldMatrix[MoleRowCordinates, MoleColCordinates] = 'M';
                        }; 
                        break;

                    case "left":
                        {
                            if (MoleColCordinates - 1 < 0)
                            {
                                Console.WriteLine("Don't try to escape the playing field!");
                                break;
                            }
                            MoleColCordinates--;
                            if (fieldMatrix[MoleRowCordinates, MoleColCordinates] == 'S')
                            {
                                if (MoleRowCordinates == rowMoleSpecialPosition1 && MoleColCordinates == colMoleSpecialPosition1)
                                {
                                    fieldMatrix[MoleRowCordinates, MoleColCordinates] = '-';
                                    fieldMatrix[rowMoleSpecialPosition2, colMoleSpecialPosition2] = 'M';
                                    
                                    MoleRowCordinates = rowMoleSpecialPosition2;
                                    MoleColCordinates = colMoleSpecialPosition2;
                                }
                                else
                                {
                                    fieldMatrix[MoleRowCordinates, MoleColCordinates] = '-';
                                    fieldMatrix[rowMoleSpecialPosition2, colMoleSpecialPosition2] = 'M';
                                    MoleRowCordinates = rowMoleSpecialPosition1;
                                    MoleColCordinates = colMoleSpecialPosition1;
                                }
                                tokens -= 3;
                                break;
                            }
                            if (char.IsDigit(fieldMatrix[MoleRowCordinates, MoleColCordinates]))
                            {
                                tokens += int.Parse(fieldMatrix[MoleRowCordinates, MoleColCordinates].ToString());
                                fieldMatrix[MoleRowCordinates, MoleColCordinates] = 'M';
                                break;
                            }
                            fieldMatrix[MoleRowCordinates, MoleColCordinates] = 'M';
                        }; break;
                }
                if (tokens >= 25)
                {
                    break;
                }
                
            }
            if (tokens >= 25)
            {
                Console.WriteLine("Yay! The Mole survived another game!");
                Console.WriteLine($"The Mole managed to survive with a total of {tokens} points.");
            }
            else
            {
                Console.WriteLine("Too bad! The Mole lost this battle!");
                Console.WriteLine($"The Mole lost the game with a total of {tokens} points.");
            }
            for (int row = 0; row < fieldSize; row++)
            {
                for (int col = 0; col < fieldSize; col++)
                {
                    Console.Write(fieldMatrix[row, col]);
                }
                Console.WriteLine();
            }
        }             
    }
}

