using Home_Work.Factory.Interface;

namespace Home_Work.Factory.Document;

public class PDF_Document : IDocument
{
    public void Print()
    {
        Console.WriteLine("Печать PDF документа");
    }
}
