using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern2
{
    public class LocalStorageFactory : IStorageFactory
    {
        public IFileUploader CreateUploader() => new LocalFileUploader();
        public IFileDownloader CreateDownloader() => new LocalFileDownloader();
        public IFileUrlGenerator CreateUrlGenerator() => new LocalUrlGenerator();
    }

}
