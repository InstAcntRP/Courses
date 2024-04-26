namespace DataMover.Batch
{
    public class FileManager
    {
        public void ParseFileAndGetData(string fileName)
        {
            Console.WriteLine($"Parsing the file -{fileName}");
            using (StreamReader streamReader = new StreamReader(fileName))
            {
                while(streamReader.Peek()>-1)
                {
                    string? line = streamReader.ReadLine();
                    if(!string.IsNullOrEmpty(line))
                    {
                        Console.WriteLine($"Content from the file - {line}");
                    }
                }
            }
        }
    }
}