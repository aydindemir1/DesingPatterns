using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern2
{
    public interface IFileUploader
    {
        void Upload(string fileName);
    }
}
