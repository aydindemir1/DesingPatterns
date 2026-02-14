using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern2
{
    public class CloudStorageFactory : IStorageFactory
    {
        public IFileUploader CreateUploader() => new CloudFileUploader();
        public IFileDownloader CreateDownloader() => new CloudFileDownloader();
        public IFileUrlGenerator CreateUrlGenerator() => new CloudUrlGenerator();
    }

}
