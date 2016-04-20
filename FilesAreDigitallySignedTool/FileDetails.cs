﻿
namespace FilesAreDigitallySignedTool
{
    public class FileDetails
    {
        public string Filename { get; set; }
        public bool FileExists { get; set; }
        public bool IsSigned { get; set; }
        public string SignatureVersion { get; set; }
        public string SignatureDate { get; set; }

        public FileDetails()
        {
            Filename = "null";
            FileExists = false;
            IsSigned = false;
            SignatureDate = "null";
            SignatureVersion = "null";
        }
    }
}
