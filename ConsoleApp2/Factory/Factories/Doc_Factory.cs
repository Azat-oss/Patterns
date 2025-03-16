
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Home_Work.Factory.Interface;

namespace Home_Work.Factory.Factories;

public abstract class Doc_Factory
{
    public abstract IDocument CreateDocument();

}
