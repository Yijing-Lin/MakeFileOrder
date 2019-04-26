
namespace MakeFileOrder
{
    public class ReturnArguments
    {
        private string _filename;
        private int _fileprogress;
        private string _message;
        private int _code;

        public int Code
        {
            get { return _code; }
            set { _code = value; }
        }

        public string Message
        {
            get { return _message; }
            set { _message = value; }
        }

        public string FileName
        {
            get { return _filename; }
            set { _filename = value; }
        }

        public int FileProgress
        {
            get { return _fileprogress; }
            set { _fileprogress = value; }
        }
    }
}
