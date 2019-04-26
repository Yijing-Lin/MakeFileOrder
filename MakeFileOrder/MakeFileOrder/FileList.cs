using System;
namespace MakeFileOrder
{
    public class FileList
    {
        private string _filename;
        private DateTime _createtime;
        private DateTime _modifiedtime;
        private DateTime _accesstime;
        private long _size;
        private string _title;

        public string FileName
        {
            get
            {
                return _filename;
            }
            set
            {
                _filename = value;
            }
        }
        public DateTime CreatTime
        {
            get
            {
                return _createtime;
            }
            set
            {
                _createtime = value;
            }
        }
        public DateTime ModifiedTime
        {
            get
            {
                return _modifiedtime;
            }
            set
            {
                _modifiedtime = value;
            }
        }
        public DateTime AccessTime
        {
            get
            {
                return _accesstime;
            }
            set
            {
                _accesstime = value;
            }
        }
        public long Size
        {
            get
            {
                return _size;
            }
            set
            {
                _size = value;
            }
        } 
        public string Title
        {
            get
            {
                return _title;
            }
            set
            {
                _title = value;
            }
        }
    }
}
