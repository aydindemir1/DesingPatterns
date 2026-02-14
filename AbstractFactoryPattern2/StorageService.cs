using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern2
{
    public class StorageService
    {
        private readonly IFileUploader _uploader;
        private readonly IFileDownloader _downloader;
        private readonly IFileUrlGenerator _urlGenerator;

        public StorageService(IStorageFactory factory)
        {
            _uploader = factory.CreateUploader();
            _downloader = factory.CreateDownloader();
            _urlGenerator = factory.CreateUrlGenerator();
        }

        public void ProcessFile(string fileName)
        {
            _uploader.Upload(fileName);
            _downloader.Download(fileName);
            Console.WriteLine(_urlGenerator.GenerateUrl(fileName));
        }
    }

}
