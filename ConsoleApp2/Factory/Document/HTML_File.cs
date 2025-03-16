using Home_Work.Factory.Interface;

namespace Home_Work.Factory.Document;

public class HTML_File : IDocument
{
    public void Print()
    {
        Console.WriteLine("Печать HTML документа");
    }
}
