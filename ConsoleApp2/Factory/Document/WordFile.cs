using Home_Work.Factory.Interface;

namespace Home_Work.Factory.Document;



public class WordFile:IDocument
{
    public void Print()
    {
        Console.WriteLine("Печать Word документа");
    }

}