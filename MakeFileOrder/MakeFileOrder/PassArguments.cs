using System.Collections.Generic;

namespace MakeFileOrder
{
    public class PassArguments
    {
        private List<FileList> _files;
        private string _sourceFolder;
        private string _destinationFolder;

        public List<FileList> Files
        {
            get { return _files; }
            set { _files = value; }
        }

        public string SourceFolder
        {
            get { return _sourceFolder; }
            set { _sourceFolder = value; }
        }

        public string DestinationFolder
        {
            get { return _destinationFolder; }
            set { _destinationFolder = value; }
        }
    }
}
