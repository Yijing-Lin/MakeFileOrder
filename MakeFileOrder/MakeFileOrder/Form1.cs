using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using IniFileExtension;

namespace MakeFileOrder
{
    public partial class Form1 : Form
    {
        public bool Busy = false;
        public string workFolder;
        public string appName;
        public string appVar;
        public long diskFree = 0;
        //public List<FileList> files = new List<FileList>();
        public int sortColumn = -1;
        public bool sortASC = false;
        public string sortField = "Default";
        public string sortType = "Default";
        private BackgroundWorker bw;

        IniFile iniFile;

        public Form1()
        {
            InitializeComponent();
            iniFile = new IniFile();
            appName = System.Reflection.Assembly.GetExecutingAssembly().GetName().Name;
            appVar = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString();
            this.Text = appName + " " + appVar;
            //workFolder = Environment.SpecialFolder.MyComputer.ToString();
            folderBrowserDialog1.RootFolder = Environment.SpecialFolder.MyComputer;
            this.Resize += new EventHandler(Form1_Resize);
            this.Load += new EventHandler(Form_Load);
            startButton1.Click += new EventHandler(StartOrStop);
            startButton2.Click += new EventHandler(StartOrStop);
            ExitButton1.Click += new EventHandler(ExitToClose);
            OpenButton1.Click += new EventHandler(OpenFolder);
            OpenButton2.Click += new EventHandler(OpenFolder);
            fileNameASC.Click += new EventHandler(MenuSort);
            fileNameDESC.Click += new EventHandler(MenuSort);
            createTimeASC.Click += new EventHandler(MenuSort);
            createTimeDESC.Click += new EventHandler(MenuSort);
            modifiedTimeASC.Click += new EventHandler(MenuSort);
            modifiedTimeDESC.Click += new EventHandler(MenuSort);
            accessTimeASC.Click += new EventHandler(MenuSort);
            accessTimeDESC.Click += new EventHandler(MenuSort);
            sizeASC.Click += new EventHandler(MenuSort);
            sizeDESC.Click += new EventHandler(MenuSort);
            listView1.ColumnClick += lvw_ColumnClick;
            RowUpButton.Click += new EventHandler(ItemsMoveUp);
            RowDownButton.Click += new EventHandler(ItemsMoveDown);
            RowToTopButton.Click += new EventHandler(ItemsMoveTop);
            RowToBottomButton.Click += new EventHandler(ItemsMoveBottom);

            ProgressBar1.Step = 1;
            ProgressBar1.Minimum = 0;
            ProgressBar1.Maximum = 100;
            ProgressBar2.Step = 1;
            ProgressBar2.Minimum = 0;
            ProgressBar2.Maximum = 100;

            bw = new BackgroundWorker();
            bw.WorkerReportsProgress = true;
            bw.WorkerSupportsCancellation = true;
            bw.DoWork += new DoWorkEventHandler(ProcessGo);
            bw.ProgressChanged += new ProgressChangedEventHandler(Bw_ProgressChanged);
            bw.RunWorkerCompleted += new RunWorkerCompletedEventHandler(Bw_RunWorkerCompleted);

            InitListView();
        }
        public void ItemsMoveTop(object sender, EventArgs e)
        {
            if (bw.IsBusy)
            {
                MessageBox.Show("Operation rejected , program in processing ! ");
                return;
            }
            if (listView1.SelectedItems.Count > 0 && listView1.SelectedItems[0].Index != 0)
            {
                int setIndex = 0;
                listView1.BeginUpdate();
                foreach (ListViewItem lvi in listView1.SelectedItems)
                {
                    ListViewItem item = lvi;
                    int index = lvi.Index;
                    listView1.Items.RemoveAt(index);
                    listView1.Items.Insert(setIndex, item);
                    setIndex++;
                }
                listView1.EndUpdate();
            }
            listView1.Focus();
        }
        public void ItemsMoveBottom(object sender, EventArgs e)
        {
            if (bw.IsBusy)
            {
                MessageBox.Show("Operation rejected , program in processing ! ");
                return;
            }
            if (listView1.SelectedItems.Count > 0 && listView1.SelectedItems[listView1.SelectedItems.Count - 1].Index < (listView1.Items.Count - 1))
            {
                listView1.BeginUpdate();
                int setIndex = listView1.Items.Count - 1;
                foreach (ListViewItem lvi in listView1.SelectedItems)
                {
                    ListViewItem item = lvi;
                    int index = lvi.Index;
                    listView1.Items.RemoveAt(index);
                    listView1.Items.Insert(setIndex , item);
                }
                listView1.EndUpdate();
            }
            listView1.Focus();
        }
        public void ItemsMoveUp(object sender , EventArgs e)
        {
            if (bw.IsBusy)
            {
                MessageBox.Show("Operation rejected , program in processing ! ");
                return;
            }
            if (listView1.SelectedItems.Count > 0 && listView1.SelectedItems[0].Index != 0)
            {
                listView1.BeginUpdate();
                foreach(ListViewItem lvi in listView1.SelectedItems)
                {
                    ListViewItem item = lvi;
                    int index = lvi.Index;
                    listView1.Items.RemoveAt(index);
                    listView1.Items.Insert(index - 1, item);
                }
                listView1.EndUpdate();
            }
            listView1.Focus();
        }
        public void ItemsMoveDown(object sender,EventArgs e)
        {
            if (bw.IsBusy)
            {
                MessageBox.Show("Operation rejected , program in processing ! ");
                return;
            }
            if (listView1.SelectedItems.Count > 0 && listView1.SelectedItems[listView1.SelectedItems.Count - 1].Index < (listView1.Items.Count - 1))
            {
                listView1.BeginUpdate();
                int count = listView1.SelectedItems.Count;
                List<ListViewItem> items = new List<ListViewItem>();
                foreach(ListViewItem lvi in listView1.SelectedItems)
                {
                    items.Add(lvi);
                }
                items.Reverse();
                foreach(ListViewItem lvi in items)
                {
                    int index = lvi.Index;
                    listView1.Items.RemoveAt(index);
                    listView1.Items.Insert(index + 1, lvi);
                }

                listView1.EndUpdate();
            }
            listView1.Focus();
        }
        // When ListView's Column Header be Click
        public void lvw_ColumnClick(object sender , ColumnClickEventArgs e)
        {
            if (bw.IsBusy)
            {
                MessageBox.Show("Operation rejected , program in processing ! ");
                return;
            }
            DoSort(e.Column);
        }
        // these is menu button Click
        public void MenuSort(object sender, EventArgs e)
        {
            if (bw.IsBusy)
            {
                MessageBox.Show("Operation rejected , program in processing ! ");
                return;
            }
            ToolStripMenuItem menuItem = (ToolStripMenuItem)sender;
            //MessageBox.Show(menuItem.Name);
            switch (menuItem.Name)
            {
                case "fileNameASC":
                    sortASC = false;
                    DoSort(0);
                    break;
                case "fileNameDESC":
                    sortASC = true;
                    DoSort(0);
                    break;
                case "createTimeASC":
                    sortASC = false;
                    DoSort(1);
                    break;
                case "createTimeDESC":
                    sortASC = true;
                    DoSort(1);
                    break;
                case "modifiedTimeASC":
                    sortASC = false;
                    DoSort(2);
                    break;
                case "modifiedTimeDESC":
                    sortASC = true;
                    DoSort(2);
                    break;
                case "accessTimeASC":
                    sortASC = false;
                    DoSort(3);
                    break;
                case "accessTimeDESC":
                    sortASC = true;
                    DoSort(3);
                    break;
                case "sizeASC":
                    sortASC = false;
                    DoSort(4);
                    break;
                case "sizeDESC":
                    sortASC = true;
                    DoSort(4);
                    break;
            }
        }
        // make ListView to Sort by specfied column No.
        public void DoSort(int column)
        {
            //files.Sort((x, y) => { return x.FileName.CompareTo(y.FileName); });
            //files.Sort((x, y) => { return -x.FileName.CompareTo(y.FileName); });

            if (sortColumn != column)
            {
                //different column,first sort fixed sort type is ascendant
                sortASC = true;
                sortColumn = column;
            }
            else
            {
                //reverse last sort direction
                sortASC = !sortASC;
            }
            if (sortColumn == 4)
            {
                listView1.ListViewItemSorter = new ListViewItemComparerNum(sortColumn, sortASC);
            }
            else
            {
                listView1.ListViewItemSorter = new ListViewItemComparer(sortColumn, sortASC);
            }
            
            switch (sortColumn)
            {
                case 0:
                    sortField = "File Name";
                    break;
                case 1:
                    sortField = "Crrate Time";
                    break;
                case 2:
                    sortField = "Modified Time";
                    break;
                case 3:
                    sortField = "Access Time";
                    break;
                case 4:
                    sortField = "File Size";
                    break;
            }
            if (sortASC)
            {
                sortType = "Ascendant";
            }
            else
            {
                sortType = "Descendant";
            }
            SortLabel.Text = sortField + "-" + sortType;
        }
        public void Form_Load(object sender, EventArgs e)
        {
            WinLoadPropertices();
        }
        //Form Resize
        public void Form1_Resize(object sender, EventArgs e)
        {
            //prevent WinFrom too small
        }
        //Load WinForm Propertices
        public void WinLoadPropertices()
        {
            int dx = int.Parse(iniFile.Read("window", "x", "0"));
            int dy = int.Parse(iniFile.Read("window", "y", "0"));
            int dw = int.Parse(iniFile.Read("window", "width", "0"));
            int dh = int.Parse(iniFile.Read("window", "height", "0"));
            if (dw > 500 || dh > 400)
            {
                this.Size = new Size(dw, dh);
            }
            //determine multi screen 
            //determine WinForm position in show screen
            if (dx < 0 || dx > Screen.PrimaryScreen.Bounds.Width || dy < 0 || dy > Screen.PrimaryScreen.Bounds.Height)
            {
                if (Screen.AllScreens.Length > 1)
                    this.Location = new Point(dx, dy);
            }
            else
            {
                this.Location = new Point(dx, dy);
            }
                
            
        }
        //Write Winform Propertices
        public void WinSavePropertices()
        {
            iniFile.Write("window", "x", this.Location.X.ToString());
            iniFile.Write("window", "y", this.Location.Y.ToString());
            iniFile.Write("window", "width", this.Width.ToString());
            iniFile.Write("window", "height", this.Height.ToString());
        }
        // User press Exit button
        public void ExitToClose(object sender, EventArgs e)
        {
            // do not work if background worker is busy 
            if (bw.IsBusy)
            {
                MessageBox.Show("Operation rejected , program in processing ! ");
                return;
            }
            this.Close();
        }
        // Check busy status,refuse if is busy 
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // do not work if background worker is busy 
            if (bw.IsBusy)
            {
                MessageBox.Show("Operation rejected , program in processing ! ");
                e.Cancel = true;
                return;
            }
            
            WinSavePropertices();
        }
        // User Press process button
        public void StartOrStop(object sender,EventArgs e)
        {
            ProgressBar1.Value = 0;
            if (bw.IsBusy != true)
            {
                //start processing
                //Busy = true;
                
                messageLabel1.Text = "Starting...";
                if (listView1.Items.Count <= 0)
                {
                    MessageBox.Show("No files can be processed!!");
                    messageLabel1.Text = "No files!";
                    return;
                }
                else if (listView1.Items.Count == 1)
                {
                    MessageBox.Show("It is not necessary to process files when there is only one file!!");
                    messageLabel1.Text = "1 file!";
                    return;
                }
                else
                {
                    //summary size and compare to free space
                    long totalSize = 0;
                    long maxSize = 0;
                    foreach (ListViewItem lvi in listView1.Items)
                    {
                        long size = long.Parse(lvi.SubItems[4].Text);
                        if (size > maxSize)
                            maxSize = size;

                        totalSize += size;
                    }
                    if (totalSize > diskFree)
                    {
                        MessageBox.Show(string.Format("Not enought free space , you need total free space large then {0}", totalSize));
                        messageLabel1.Text = "space not enought!";
                        return;
                    }
                }

                startButton1.Image = MakeFileOrder.Properties.Resources.stop_241;
                startButton2.Image = MakeFileOrder.Properties.Resources.stop_241;

                List<FileList> fileLists = new List<FileList>();
                foreach(ListViewItem lvi in listView1.Items)
                {
                    FileList fl = new FileList();
                    fl.FileName = lvi.SubItems[0].Text;
                    fileLists.Add(fl);
                }
                PassArguments pa = new PassArguments();
                pa.Files = fileLists;
                pa.SourceFolder = workFolder;
                pa.DestinationFolder = driveLabel1.Text + "tempF";

                bw.RunWorkerAsync(pa);

                // TESTING CASE
                //if (!Directory.Exists(pa.DestinationFolder))
                //{
                //    Directory.CreateDirectory(pa.DestinationFolder);
                //}
                //int fcount = 0;
                //foreach (FileList file in pa.Files)
                //{
                //    fcount++;
                //    string file1 = pa.SourceFolder + "\\" + file.FileName;
                //    string file2 = pa.DestinationFolder + "\\" + file.FileName;
                //    messageLabel1.Text = ">>" + file.FileName;
                //    //bw.ReportProgress((fcount / pa.Files.Count) * 100, "file.FileName");
                //    using (FileStream fs1 = File.Open(file1, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                //    {
                //        using (BufferedStream bs1 = new BufferedStream(fs1))
                //        {
                //            using (BinaryReader br = new BinaryReader(bs1))
                //            {
                //                FileStream fs2 = File.Open(file2, FileMode.Create, FileAccess.Write, FileShare.ReadWrite);
                //                BufferedStream bs2 = new BufferedStream(fs2);
                //                BinaryWriter bw = new BinaryWriter(bs2);
                //                byte[] data;
                //                while (br.BaseStream.Position != br.BaseStream.Length)
                //                {
                //                    data = br.ReadBytes(4096);
                //                    bw.Write(data);
                //                }
                //                bw.Close();
                //                bw.Dispose();
                //                bs2.Close();
                //                bs2.Dispose();
                //                fs2.Close();
                //                fs2.Dispose();
                //            }
                //        }
                //    }
                //}
            }
            else
            {
                //break processing
                //Busy = false;
                
                if (bw.CancellationPending == true)
                {
                    bw.CancelAsync();
                    messageLabel1.Text = "User Cancalling.....";
                }
            }
        }
        //User Select Folder
        public void OpenFolder(object sender, EventArgs e)
        {
            // do not work if background worker is busy 
            if (bw.IsBusy)
            {
                MessageBox.Show("Operation rejected , program in processing ! ");
                return;
            }
            if (workFolder != "")
            {
                folderBrowserDialog1.SelectedPath = workFolder;
            }
            folderBrowserDialog1.ShowDialog();
            workFolder = folderBrowserDialog1.SelectedPath;
            // set path with form title
            this.Text = appName + " " + appVar + " - " + workFolder;
            // retrieve drive free space
            driveLabel1.Text = Path.GetPathRoot(workFolder);
            diskFree = GetTotalFreeSpace(driveLabel1.Text);
            spaceLabel.Text = diskFree.ToString();

            ListFolder();
        }
        public void ListFolder()
        {
            // Clear Screen on ListView
            if (listView1.Items.Count > 0)
            {
                listView1.Items.Clear();
            }
            //if (files.Count > 0)
            //{
            //    files.Clear();
            //}
            sortField = "Default";
            sortType = "Default";
            SortLabel.Text = sortField + "-" + sortType;
            // retrieve file list & propertices from folder
            try
            {
                DirectoryInfo directorys = new DirectoryInfo(workFolder);
                foreach (var fi in directorys.EnumerateFiles())
                {
                    try
                    {
                        //FileList file = new FileList();
                        //file.FileName = fi.Name;
                        //file.Size = fi.Length;
                        //file.CreatTime = fi.CreationTime;
                        //file.AccessTime = fi.LastAccessTime;
                        //file.ModifiedTime = fi.LastWriteTime;
                        //files.Add(file);

                        ListViewItem item = new ListViewItem();
                        item.SubItems[0].Text = fi.Name;
                        item.SubItems.Add(fi.CreationTime.ToString("yyyy/MM/dd HH:mm:ss"));
                        item.SubItems.Add(fi.LastWriteTime.ToString("yyyy/MM/dd HH:mm:ss"));
                        item.SubItems.Add(fi.LastAccessTime.ToString("yyyy/MM/dd HH:mm:ss"));
                        item.SubItems.Add(fi.Length.ToString());
                        listView1.Items.Add(item);

                    }
                    catch (UnauthorizedAccessException unAccess)
                    {
                        MessageBox.Show(unAccess.Message, "Get File List", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
            catch (DirectoryNotFoundException dirNotFond)
            {
                MessageBox.Show(dirNotFond.Message, "Retrieve File List", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (UnauthorizedAccessException unAuthDir)
            {
                MessageBox.Show(unAuthDir.Message, "Retrieve File List", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (PathTooLongException longPath)
            {
                MessageBox.Show(longPath.Message, "Retrieve File List", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        // Retrieve free disk space size
        private long GetTotalFreeSpace(string driveName)
        {
            foreach(DriveInfo drive in DriveInfo.GetDrives())
            {
                if (drive.IsReady && drive.Name == driveName)
                    return drive.TotalFreeSpace;
            }
            return -1;
        }
        // Initial ListView
        private void InitListView()
        {
            ColumnHeader col1 = new ColumnHeader(1);
            col1.Name = "File Name";
            col1.Width = 250;
            col1.TextAlign = HorizontalAlignment.Left;
            this.listView1.Columns.Add(col1);

            this.listView1.Columns.Add("Create Time", 120, HorizontalAlignment.Left);
            this.listView1.Columns.Add("Modified Time", 120, HorizontalAlignment.Left);
            this.listView1.Columns.Add("Access Time", 120, HorizontalAlignment.Left);
            this.listView1.Columns.Add("File Size", 100, HorizontalAlignment.Right);
            this.listView1.Columns.Add("Mp3 Title", 150, HorizontalAlignment.Center);

            this.listView1.Scrollable = true;
            this.listView1.GridLines = true;
            this.listView1.FullRowSelect = true;
            this.listView1.MultiSelect = true;
            this.listView1.View = View.Details;
        }
        
        private void ProcessGo(object sender , DoWorkEventArgs e)
        {
            PassArguments pa = (PassArguments)e.Argument;
            if (!Directory.Exists(pa.DestinationFolder))
            {
                Directory.CreateDirectory(pa.DestinationFolder);
            }
            int fcount = 0;
            foreach(FileList file in pa.Files)
            {
                ReturnArguments ra = new ReturnArguments();
                ra.FileName = file.FileName;
                ra.Code = 1;
                fcount++;
                string file1 = pa.SourceFolder + "\\" + file.FileName;
                string file2 = pa.DestinationFolder + "\\" + file.FileName;
                bw.ReportProgress((int)(((float)fcount / (float)pa.Files.Count) * 50.0), ra);
                //Thread.Sleep(10000);
                //File.Copy(file1, file2);
                using (FileStream fs1 = File.Open(file1, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                {
                    using (BufferedStream bs1 = new BufferedStream(fs1))
                    {
                        using (BinaryReader br = new BinaryReader(bs1))
                        {
                            ReturnArguments ra2 = new ReturnArguments();
                            ra2.Code = 2;
                            FileStream fs2 = File.Open(file2, FileMode.Create, FileAccess.Write, FileShare.ReadWrite);
                            BufferedStream bs2 = new BufferedStream(fs2);
                            BinaryWriter binwr = new BinaryWriter(bs2);
                            byte[] data;
                            while (br.BaseStream.Position != br.BaseStream.Length)
                            {
                                data = br.ReadBytes(4096);
                                binwr.Write(data);
                                bw.ReportProgress((int)(((float)br.BaseStream.Position / (float)br.BaseStream.Length) * 100.0), ra2);

                                if (e.Cancel == true)
                                    break;
                            }
                            binwr.Close();
                            binwr.Dispose();
                            bs2.Close();
                            bs2.Dispose();
                            fs2.Close();
                            fs2.Dispose();
                        }
                    }
                }
                if (e.Cancel == true)
                    break;
            }

            // if cancel ,delete all temp files & temp directory
            if (e.Cancel == true)
            {
                foreach (string file in Directory.GetFiles(pa.DestinationFolder))
                {
                    File.Delete(file);
                }
                Directory.Delete(pa.DestinationFolder);
            }
            else
            {
                // otherwise delete source directory files and move all temp files to source directory
                // in this step will not allow cacel command
                string[] files = Directory.GetFiles(pa.DestinationFolder);
                int count1 = 0;
                int count2 = files.Length;
                foreach (string file in files)
                {
                    count1++;
                    ReturnArguments ra = new ReturnArguments();
                    ra.Code = 1;
                    ra.FileName = file;
                    string fileName = Path.GetFileName(file);
                    string destFileName = pa.SourceFolder + "\\" + fileName;
                    File.Delete(destFileName);
                    File.Move(file, destFileName);
                    bw.ReportProgress((int)(((float)count1 / (float)count2) * 50.0) + 50, ra);
                }
                Directory.Delete(pa.DestinationFolder);
            }

        }
        private void Bw_ProgressChanged(object sender ,ProgressChangedEventArgs e)
        {
            ReturnArguments ri = (ReturnArguments)e.UserState;
            if (ri.Code == 1)
            {
                ProgressBar1.Value = e.ProgressPercentage;
                messageLabel1.Text = ri.FileName + " to Processing..";
                ProgressBar2.Value = 0;
            }
            else if(ri.Code == 2)
            {
                ProgressBar2.Value = e.ProgressPercentage;
            }
            
            
        }
        private void Bw_RunWorkerCompleted(object sender,RunWorkerCompletedEventArgs e)
        {
            if(e.Cancelled == true)
            {
                messageLabel1.Text = "Cancalled!!";
            }
            else if(!(e.Error == null))
            {
                messageLabel1.Text = e.Error.Message;
                MessageBox.Show(e.Error.Message);
            }
            else
            {
                messageLabel1.Text = "Completed!";
                ListFolder();
                //StartOrStop(sender, new EventArgs());
            }
            startButton1.Image = Properties.Resources.play_24;
            startButton2.Image = Properties.Resources.play_24;
        }
    }
}
