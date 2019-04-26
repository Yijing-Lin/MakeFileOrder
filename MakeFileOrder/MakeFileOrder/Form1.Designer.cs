namespace MakeFileOrder
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenButton1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ExitButton1 = new System.Windows.Forms.ToolStripMenuItem();
            this.sortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.byNameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileNameASC = new System.Windows.Forms.ToolStripMenuItem();
            this.fileNameDESC = new System.Windows.Forms.ToolStripMenuItem();
            this.byCreateDateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createTimeASC = new System.Windows.Forms.ToolStripMenuItem();
            this.createTimeDESC = new System.Windows.Forms.ToolStripMenuItem();
            this.byModifiedDateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifiedTimeASC = new System.Windows.Forms.ToolStripMenuItem();
            this.modifiedTimeDESC = new System.Windows.Forms.ToolStripMenuItem();
            this.byAccessDateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accessTimeASC = new System.Windows.Forms.ToolStripMenuItem();
            this.accessTimeDESC = new System.Windows.Forms.ToolStripMenuItem();
            this.bySizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sizeASC = new System.Windows.Forms.ToolStripMenuItem();
            this.sizeDESC = new System.Windows.Forms.ToolStripMenuItem();
            this.processToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startButton1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.OpenButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.RowToTopButton = new System.Windows.Forms.ToolStripButton();
            this.RowToBottomButton = new System.Windows.Forms.ToolStripButton();
            this.RowUpButton = new System.Windows.Forms.ToolStripButton();
            this.RowDownButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.startButton2 = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.StatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.driveLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.StatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.spaceLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.StatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.SortLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.listView1 = new System.Windows.Forms.ListView();
            this.statusStrip2 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.ProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.ProgressBar2 = new System.Windows.Forms.ToolStripProgressBar();
            this.messageLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.statusStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.sortToolStripMenuItem,
            this.processToolStripMenuItem});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenButton1,
            this.toolStripSeparator1,
            this.ExitButton1});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            resources.ApplyResources(this.fileToolStripMenuItem, "fileToolStripMenuItem");
            // 
            // OpenButton1
            // 
            resources.ApplyResources(this.OpenButton1, "OpenButton1");
            this.OpenButton1.MergeIndex = 10;
            this.OpenButton1.Name = "OpenButton1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
            // 
            // ExitButton1
            // 
            resources.ApplyResources(this.ExitButton1, "ExitButton1");
            this.ExitButton1.Name = "ExitButton1";
            // 
            // sortToolStripMenuItem
            // 
            this.sortToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.byNameToolStripMenuItem,
            this.byCreateDateToolStripMenuItem,
            this.byModifiedDateToolStripMenuItem,
            this.byAccessDateToolStripMenuItem,
            this.bySizeToolStripMenuItem});
            this.sortToolStripMenuItem.Name = "sortToolStripMenuItem";
            resources.ApplyResources(this.sortToolStripMenuItem, "sortToolStripMenuItem");
            // 
            // byNameToolStripMenuItem
            // 
            this.byNameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileNameASC,
            this.fileNameDESC});
            this.byNameToolStripMenuItem.Name = "byNameToolStripMenuItem";
            resources.ApplyResources(this.byNameToolStripMenuItem, "byNameToolStripMenuItem");
            // 
            // fileNameASC
            // 
            resources.ApplyResources(this.fileNameASC, "fileNameASC");
            this.fileNameASC.Name = "fileNameASC";
            // 
            // fileNameDESC
            // 
            resources.ApplyResources(this.fileNameDESC, "fileNameDESC");
            this.fileNameDESC.Name = "fileNameDESC";
            // 
            // byCreateDateToolStripMenuItem
            // 
            this.byCreateDateToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createTimeASC,
            this.createTimeDESC});
            this.byCreateDateToolStripMenuItem.Name = "byCreateDateToolStripMenuItem";
            resources.ApplyResources(this.byCreateDateToolStripMenuItem, "byCreateDateToolStripMenuItem");
            // 
            // createTimeASC
            // 
            resources.ApplyResources(this.createTimeASC, "createTimeASC");
            this.createTimeASC.Name = "createTimeASC";
            // 
            // createTimeDESC
            // 
            resources.ApplyResources(this.createTimeDESC, "createTimeDESC");
            this.createTimeDESC.Name = "createTimeDESC";
            // 
            // byModifiedDateToolStripMenuItem
            // 
            this.byModifiedDateToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modifiedTimeASC,
            this.modifiedTimeDESC});
            this.byModifiedDateToolStripMenuItem.Name = "byModifiedDateToolStripMenuItem";
            resources.ApplyResources(this.byModifiedDateToolStripMenuItem, "byModifiedDateToolStripMenuItem");
            // 
            // modifiedTimeASC
            // 
            resources.ApplyResources(this.modifiedTimeASC, "modifiedTimeASC");
            this.modifiedTimeASC.Name = "modifiedTimeASC";
            // 
            // modifiedTimeDESC
            // 
            resources.ApplyResources(this.modifiedTimeDESC, "modifiedTimeDESC");
            this.modifiedTimeDESC.Name = "modifiedTimeDESC";
            // 
            // byAccessDateToolStripMenuItem
            // 
            this.byAccessDateToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.accessTimeASC,
            this.accessTimeDESC});
            this.byAccessDateToolStripMenuItem.Name = "byAccessDateToolStripMenuItem";
            resources.ApplyResources(this.byAccessDateToolStripMenuItem, "byAccessDateToolStripMenuItem");
            // 
            // accessTimeASC
            // 
            this.accessTimeASC.Image = global::MakeFileOrder.Properties.Resources.up_24;
            this.accessTimeASC.Name = "accessTimeASC";
            resources.ApplyResources(this.accessTimeASC, "accessTimeASC");
            // 
            // accessTimeDESC
            // 
            this.accessTimeDESC.Image = global::MakeFileOrder.Properties.Resources.down_24;
            this.accessTimeDESC.Name = "accessTimeDESC";
            resources.ApplyResources(this.accessTimeDESC, "accessTimeDESC");
            // 
            // bySizeToolStripMenuItem
            // 
            this.bySizeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sizeASC,
            this.sizeDESC});
            this.bySizeToolStripMenuItem.Name = "bySizeToolStripMenuItem";
            resources.ApplyResources(this.bySizeToolStripMenuItem, "bySizeToolStripMenuItem");
            // 
            // sizeASC
            // 
            this.sizeASC.Image = global::MakeFileOrder.Properties.Resources.up_24;
            this.sizeASC.Name = "sizeASC";
            resources.ApplyResources(this.sizeASC, "sizeASC");
            // 
            // sizeDESC
            // 
            this.sizeDESC.Image = global::MakeFileOrder.Properties.Resources.down_24;
            this.sizeDESC.Name = "sizeDESC";
            resources.ApplyResources(this.sizeDESC, "sizeDESC");
            // 
            // processToolStripMenuItem
            // 
            this.processToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startButton1});
            this.processToolStripMenuItem.Name = "processToolStripMenuItem";
            resources.ApplyResources(this.processToolStripMenuItem, "processToolStripMenuItem");
            // 
            // startButton1
            // 
            resources.ApplyResources(this.startButton1, "startButton1");
            this.startButton1.Name = "startButton1";
            // 
            // toolStrip1
            // 
            resources.ApplyResources(this.toolStrip1, "toolStrip1");
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenButton2,
            this.toolStripSeparator2,
            this.RowToTopButton,
            this.RowToBottomButton,
            this.RowUpButton,
            this.RowDownButton,
            this.toolStripSeparator3,
            this.toolStripSeparator4,
            this.startButton2});
            this.toolStrip1.Name = "toolStrip1";
            // 
            // OpenButton2
            // 
            this.OpenButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(this.OpenButton2, "OpenButton2");
            this.OpenButton2.Name = "OpenButton2";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            resources.ApplyResources(this.toolStripSeparator2, "toolStripSeparator2");
            // 
            // RowToTopButton
            // 
            this.RowToTopButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(this.RowToTopButton, "RowToTopButton");
            this.RowToTopButton.Name = "RowToTopButton";
            // 
            // RowToBottomButton
            // 
            this.RowToBottomButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(this.RowToBottomButton, "RowToBottomButton");
            this.RowToBottomButton.Name = "RowToBottomButton";
            // 
            // RowUpButton
            // 
            this.RowUpButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(this.RowUpButton, "RowUpButton");
            this.RowUpButton.Name = "RowUpButton";
            // 
            // RowDownButton
            // 
            this.RowDownButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(this.RowDownButton, "RowDownButton");
            this.RowDownButton.Name = "RowDownButton";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            resources.ApplyResources(this.toolStripSeparator3, "toolStripSeparator3");
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            resources.ApplyResources(this.toolStripSeparator4, "toolStripSeparator4");
            // 
            // startButton2
            // 
            this.startButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(this.startButton2, "startButton2");
            this.startButton2.Name = "startButton2";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusLabel3,
            this.driveLabel1,
            this.StatusLabel2,
            this.spaceLabel,
            this.StatusLabel4,
            this.SortLabel});
            resources.ApplyResources(this.statusStrip1, "statusStrip1");
            this.statusStrip1.Name = "statusStrip1";
            // 
            // StatusLabel3
            // 
            this.StatusLabel3.Name = "StatusLabel3";
            resources.ApplyResources(this.StatusLabel3, "StatusLabel3");
            // 
            // driveLabel1
            // 
            this.driveLabel1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.driveLabel1.Name = "driveLabel1";
            resources.ApplyResources(this.driveLabel1, "driveLabel1");
            // 
            // StatusLabel2
            // 
            this.StatusLabel2.Name = "StatusLabel2";
            resources.ApplyResources(this.StatusLabel2, "StatusLabel2");
            // 
            // spaceLabel
            // 
            this.spaceLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.spaceLabel.Name = "spaceLabel";
            resources.ApplyResources(this.spaceLabel, "spaceLabel");
            // 
            // StatusLabel4
            // 
            this.StatusLabel4.Name = "StatusLabel4";
            resources.ApplyResources(this.StatusLabel4, "StatusLabel4");
            // 
            // SortLabel
            // 
            this.SortLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.SortLabel.Name = "SortLabel";
            resources.ApplyResources(this.SortLabel, "SortLabel");
            // 
            // listView1
            // 
            resources.ApplyResources(this.listView1, "listView1");
            this.listView1.Name = "listView1";
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // statusStrip2
            // 
            this.statusStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.ProgressBar1,
            this.toolStripStatusLabel2,
            this.ProgressBar2,
            this.messageLabel1});
            resources.ApplyResources(this.statusStrip2, "statusStrip2");
            this.statusStrip2.Name = "statusStrip2";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            resources.ApplyResources(this.toolStripStatusLabel1, "toolStripStatusLabel1");
            // 
            // ProgressBar1
            // 
            this.ProgressBar1.Name = "ProgressBar1";
            resources.ApplyResources(this.ProgressBar1, "ProgressBar1");
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            resources.ApplyResources(this.toolStripStatusLabel2, "toolStripStatusLabel2");
            // 
            // ProgressBar2
            // 
            this.ProgressBar2.Name = "ProgressBar2";
            resources.ApplyResources(this.ProgressBar2, "ProgressBar2");
            // 
            // messageLabel1
            // 
            this.messageLabel1.Name = "messageLabel1";
            resources.ApplyResources(this.messageLabel1, "messageLabel1");
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.statusStrip2);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.statusStrip2.ResumeLayout(false);
            this.statusStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sortToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem byNameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileNameASC;
        private System.Windows.Forms.ToolStripMenuItem fileNameDESC;
        private System.Windows.Forms.ToolStripMenuItem byCreateDateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createTimeASC;
        private System.Windows.Forms.ToolStripMenuItem createTimeDESC;
        private System.Windows.Forms.ToolStripMenuItem byModifiedDateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifiedTimeASC;
        private System.Windows.Forms.ToolStripMenuItem modifiedTimeDESC;
        private System.Windows.Forms.ToolStripMenuItem processToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startButton1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem ExitButton1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton OpenButton2;
        private System.Windows.Forms.ToolStripButton startButton2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripStatusLabel StatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel spaceLabel;
        private System.Windows.Forms.ToolStripStatusLabel StatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel driveLabel1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ToolStripStatusLabel StatusLabel4;
        private System.Windows.Forms.ToolStripStatusLabel SortLabel;
        private System.Windows.Forms.ToolStripMenuItem byAccessDateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accessTimeASC;
        private System.Windows.Forms.ToolStripMenuItem accessTimeDESC;
        private System.Windows.Forms.ToolStripMenuItem bySizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sizeASC;
        private System.Windows.Forms.ToolStripMenuItem sizeDESC;
        private System.Windows.Forms.ToolStripButton RowToTopButton;
        private System.Windows.Forms.ToolStripButton RowToBottomButton;
        private System.Windows.Forms.ToolStripButton RowUpButton;
        private System.Windows.Forms.ToolStripButton RowDownButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.StatusStrip statusStrip2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripProgressBar ProgressBar1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripProgressBar ProgressBar2;
        private System.Windows.Forms.ToolStripStatusLabel messageLabel1;
    }
}

