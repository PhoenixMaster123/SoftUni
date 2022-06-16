namespace LineNumbers
{
    using System.IO;
    public class LineNumbers
    {
        static void Main()
        {
            string inputPath = @"..\..\..\input.txt";
            string outputPath = @"..\..\..\output.txt";

            RewriteFileWithLineNumbers(inputPath, outputPath);
        }

        public static void RewriteFileWithLineNumbers(string inputFilePath, string outputFilePath)
        {
            StreamReader reader = new StreamReader(inputFilePath);
            using (reader)
            {

                StreamWriter writer = new StreamWriter(outputFilePath);
                using (writer)
                {
                    int lineNum = 1;
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                      
                        writer.WriteLine(lineNum + ". " + line);
                        lineNum++;
                    }
                }
            }
        }
    }
}
