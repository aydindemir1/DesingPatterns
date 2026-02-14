using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern2
{
    public interface IStorageFactory
    {
        IFileUploader CreateUploader();
        IFileDownloader CreateDownloader();
        IFileUrlGenerator CreateUrlGenerator();
    }

}
