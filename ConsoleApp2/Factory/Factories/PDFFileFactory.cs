using Home_Work.Factory.Document;
using Home_Work.Factory.Interface;

namespace Home_Work.Factory.Factories;

public class PDFFileFactory : Doc_Factory
{
    public override IDocument CreateDocument()
    {
        return new WordFile();
    }

}
