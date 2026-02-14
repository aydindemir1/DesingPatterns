using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern2
{
    public interface IFileDownloader
    {
        void Download(string fileName);
    }
}
