
namespace Password_Manager_Program
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.GrpManagement = new System.Windows.Forms.GroupBox();
            this.BtnCloseDB = new System.Windows.Forms.Button();
            this.BtnSaveDB = new System.Windows.Forms.Button();
            this.BtnLoadDB = new System.Windows.Forms.Button();
            this.BtnNewDB = new System.Windows.Forms.Button();
            this.GrpEntries = new System.Windows.Forms.GroupBox();
            this.LblSearch = new System.Windows.Forms.Label();
            this.TxtSearch = new System.Windows.Forms.TextBox();
            this.BtnClearClip = new System.Windows.Forms.Button();
            this.BtnCopyComment = new System.Windows.Forms.Button();
            this.BtnCopyPass = new System.Windows.Forms.Button();
            this.BtnCopyUser = new System.Windows.Forms.Button();
            this.BtnDeleteEntry = new System.Windows.Forms.Button();
            this.BtnEditEntry = new System.Windows.Forms.Button();
            this.BtnAddEntry = new System.Windows.Forms.Button();
            this.LstEntries = new System.Windows.Forms.ListView();
            this.ColAccount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColUsername = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColComment = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CmsMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.TsmEditEntry = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmSep1 = new System.Windows.Forms.ToolStripSeparator();
            this.TsmCopyUser = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmCopyPass = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmCopyComment = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmSep2 = new System.Windows.Forms.ToolStripSeparator();
            this.TsmDeleteEntry = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnSettings = new System.Windows.Forms.Button();
            this.GrpManagement.SuspendLayout();
            this.GrpEntries.SuspendLayout();
            this.CmsMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // GrpManagement
            // 
            this.GrpManagement.Controls.Add(this.BtnSettings);
            this.GrpManagement.Controls.Add(this.BtnCloseDB);
            this.GrpManagement.Controls.Add(this.BtnSaveDB);
            this.GrpManagement.Controls.Add(this.BtnLoadDB);
            this.GrpManagement.Controls.Add(this.BtnNewDB);
            this.GrpManagement.Location = new System.Drawing.Point(12, 12);
            this.GrpManagement.Name = "GrpManagement";
            this.GrpManagement.Size = new System.Drawing.Size(551, 72);
            this.GrpManagement.TabIndex = 0;
            this.GrpManagement.TabStop = false;
            this.GrpManagement.Text = "Database Management";
            // 
            // BtnCloseDB
            // 
            this.BtnCloseDB.Location = new System.Drawing.Point(335, 19);
            this.BtnCloseDB.Name = "BtnCloseDB";
            this.BtnCloseDB.Size = new System.Drawing.Size(105, 41);
            this.BtnCloseDB.TabIndex = 3;
            this.BtnCloseDB.Text = "Close database";
            this.BtnCloseDB.UseVisualStyleBackColor = true;
            this.BtnCloseDB.Click += new System.EventHandler(this.BtnCloseDB_Click);
            // 
            // BtnSaveDB
            // 
            this.BtnSaveDB.Location = new System.Drawing.Point(227, 19);
            this.BtnSaveDB.Name = "BtnSaveDB";
            this.BtnSaveDB.Size = new System.Drawing.Size(102, 41);
            this.BtnSaveDB.TabIndex = 2;
            this.BtnSaveDB.Text = "Save Database";
            this.BtnSaveDB.UseVisualStyleBackColor = true;
            this.BtnSaveDB.Click += new System.EventHandler(this.BtnSaveDB_Click);
            // 
            // BtnLoadDB
            // 
            this.BtnLoadDB.Location = new System.Drawing.Point(114, 19);
            this.BtnLoadDB.Name = "BtnLoadDB";
            this.BtnLoadDB.Size = new System.Drawing.Size(107, 41);
            this.BtnLoadDB.TabIndex = 1;
            this.BtnLoadDB.Text = "Load Database";
            this.BtnLoadDB.UseVisualStyleBackColor = true;
            this.BtnLoadDB.Click += new System.EventHandler(this.BtnLoadDB_Click);
            // 
            // BtnNewDB
            // 
            this.BtnNewDB.Location = new System.Drawing.Point(6, 19);
            this.BtnNewDB.Name = "BtnNewDB";
            this.BtnNewDB.Size = new System.Drawing.Size(102, 41);
            this.BtnNewDB.TabIndex = 0;
            this.BtnNewDB.Text = "New Database";
            this.BtnNewDB.UseVisualStyleBackColor = true;
            this.BtnNewDB.Click += new System.EventHandler(this.BtnNewDB_Click);
            // 
            // GrpEntries
            // 
            this.GrpEntries.Controls.Add(this.LblSearch);
            this.GrpEntries.Controls.Add(this.TxtSearch);
            this.GrpEntries.Controls.Add(this.BtnClearClip);
            this.GrpEntries.Controls.Add(this.BtnCopyComment);
            this.GrpEntries.Controls.Add(this.BtnCopyPass);
            this.GrpEntries.Controls.Add(this.BtnCopyUser);
            this.GrpEntries.Controls.Add(this.BtnDeleteEntry);
            this.GrpEntries.Controls.Add(this.BtnEditEntry);
            this.GrpEntries.Controls.Add(this.BtnAddEntry);
            this.GrpEntries.Controls.Add(this.LstEntries);
            this.GrpEntries.Location = new System.Drawing.Point(12, 90);
            this.GrpEntries.Name = "GrpEntries";
            this.GrpEntries.Size = new System.Drawing.Size(551, 396);
            this.GrpEntries.TabIndex = 0;
            this.GrpEntries.TabStop = false;
            this.GrpEntries.Text = "Entries";
            // 
            // LblSearch
            // 
            this.LblSearch.AutoSize = true;
            this.LblSearch.Location = new System.Drawing.Point(6, 74);
            this.LblSearch.Name = "LblSearch";
            this.LblSearch.Size = new System.Drawing.Size(44, 13);
            this.LblSearch.TabIndex = 0;
            this.LblSearch.Text = "Search:";
            // 
            // TxtSearch
            // 
            this.TxtSearch.Location = new System.Drawing.Point(56, 71);
            this.TxtSearch.Name = "TxtSearch";
            this.TxtSearch.Size = new System.Drawing.Size(211, 20);
            this.TxtSearch.TabIndex = 7;
            this.TxtSearch.TextChanged += new System.EventHandler(this.TxtSearch_TextChanged);
            // 
            // BtnClearClip
            // 
            this.BtnClearClip.Location = new System.Drawing.Point(430, 61);
            this.BtnClearClip.Name = "BtnClearClip";
            this.BtnClearClip.Size = new System.Drawing.Size(115, 30);
            this.BtnClearClip.TabIndex = 12;
            this.BtnClearClip.Text = "Clear Clipboard";
            this.BtnClearClip.UseVisualStyleBackColor = true;
            this.BtnClearClip.Click += new System.EventHandler(this.BtnClearClip_Click);
            // 
            // BtnCopyComment
            // 
            this.BtnCopyComment.Location = new System.Drawing.Point(309, 61);
            this.BtnCopyComment.Name = "BtnCopyComment";
            this.BtnCopyComment.Size = new System.Drawing.Size(115, 30);
            this.BtnCopyComment.TabIndex = 11;
            this.BtnCopyComment.Text = "Copy Comment";
            this.BtnCopyComment.UseVisualStyleBackColor = true;
            this.BtnCopyComment.Click += new System.EventHandler(this.BtnCopyComment_Click);
            // 
            // BtnCopyPass
            // 
            this.BtnCopyPass.Location = new System.Drawing.Point(430, 19);
            this.BtnCopyPass.Name = "BtnCopyPass";
            this.BtnCopyPass.Size = new System.Drawing.Size(115, 30);
            this.BtnCopyPass.TabIndex = 10;
            this.BtnCopyPass.Text = "Copy Password";
            this.BtnCopyPass.UseVisualStyleBackColor = true;
            this.BtnCopyPass.Click += new System.EventHandler(this.BtnCopyPass_Click);
            // 
            // BtnCopyUser
            // 
            this.BtnCopyUser.Location = new System.Drawing.Point(309, 19);
            this.BtnCopyUser.Name = "BtnCopyUser";
            this.BtnCopyUser.Size = new System.Drawing.Size(115, 30);
            this.BtnCopyUser.TabIndex = 9;
            this.BtnCopyUser.Text = "Copy Username";
            this.BtnCopyUser.UseVisualStyleBackColor = true;
            this.BtnCopyUser.Click += new System.EventHandler(this.BtnCopyUser_Click);
            // 
            // BtnDeleteEntry
            // 
            this.BtnDeleteEntry.Location = new System.Drawing.Point(184, 19);
            this.BtnDeleteEntry.Name = "BtnDeleteEntry";
            this.BtnDeleteEntry.Size = new System.Drawing.Size(83, 44);
            this.BtnDeleteEntry.TabIndex = 6;
            this.BtnDeleteEntry.Text = "Delete Entry";
            this.BtnDeleteEntry.UseVisualStyleBackColor = true;
            this.BtnDeleteEntry.Click += new System.EventHandler(this.BtnDeleteEntry_Click);
            // 
            // BtnEditEntry
            // 
            this.BtnEditEntry.Location = new System.Drawing.Point(95, 19);
            this.BtnEditEntry.Name = "BtnEditEntry";
            this.BtnEditEntry.Size = new System.Drawing.Size(83, 44);
            this.BtnEditEntry.TabIndex = 5;
            this.BtnEditEntry.Text = "Edit Entry";
            this.BtnEditEntry.UseVisualStyleBackColor = true;
            this.BtnEditEntry.Click += new System.EventHandler(this.BtnEditEntry_Click);
            // 
            // BtnAddEntry
            // 
            this.BtnAddEntry.Location = new System.Drawing.Point(6, 19);
            this.BtnAddEntry.Name = "BtnAddEntry";
            this.BtnAddEntry.Size = new System.Drawing.Size(83, 44);
            this.BtnAddEntry.TabIndex = 4;
            this.BtnAddEntry.Text = "Add Entry";
            this.BtnAddEntry.UseVisualStyleBackColor = true;
            this.BtnAddEntry.Click += new System.EventHandler(this.BtnAddEntry_Click);
            // 
            // LstEntries
            // 
            this.LstEntries.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColAccount,
            this.ColUsername,
            this.ColComment});
            this.LstEntries.ContextMenuStrip = this.CmsMenu;
            this.LstEntries.FullRowSelect = true;
            this.LstEntries.GridLines = true;
            this.LstEntries.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.LstEntries.HideSelection = false;
            this.LstEntries.Location = new System.Drawing.Point(0, 97);
            this.LstEntries.MultiSelect = false;
            this.LstEntries.Name = "LstEntries";
            this.LstEntries.Size = new System.Drawing.Size(551, 299);
            this.LstEntries.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.LstEntries.TabIndex = 13;
            this.LstEntries.UseCompatibleStateImageBehavior = false;
            this.LstEntries.View = System.Windows.Forms.View.Details;
            // 
            // ColAccount
            // 
            this.ColAccount.Text = "Account";
            this.ColAccount.Width = 182;
            // 
            // ColUsername
            // 
            this.ColUsername.Text = "Username/Email";
            this.ColUsername.Width = 182;
            // 
            // ColComment
            // 
            this.ColComment.Text = "Comment";
            this.ColComment.Width = 183;
            // 
            // CmsMenu
            // 
            this.CmsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsmEditEntry,
            this.TsmSep1,
            this.TsmCopyUser,
            this.TsmCopyPass,
            this.TsmCopyComment,
            this.TsmSep2,
            this.TsmDeleteEntry});
            this.CmsMenu.Name = "contextMenuStrip1";
            this.CmsMenu.Size = new System.Drawing.Size(160, 126);
            // 
            // TsmEditEntry
            // 
            this.TsmEditEntry.Name = "TsmEditEntry";
            this.TsmEditEntry.Size = new System.Drawing.Size(159, 22);
            this.TsmEditEntry.Text = "Edit Entry";
            this.TsmEditEntry.Click += new System.EventHandler(this.TsmEditEntry_Click);
            // 
            // TsmSep1
            // 
            this.TsmSep1.Name = "TsmSep1";
            this.TsmSep1.Size = new System.Drawing.Size(156, 6);
            // 
            // TsmCopyUser
            // 
            this.TsmCopyUser.Name = "TsmCopyUser";
            this.TsmCopyUser.Size = new System.Drawing.Size(159, 22);
            this.TsmCopyUser.Text = "Copy Username";
            this.TsmCopyUser.Click += new System.EventHandler(this.TsmCopyUser_Click);
            // 
            // TsmCopyPass
            // 
            this.TsmCopyPass.Name = "TsmCopyPass";
            this.TsmCopyPass.Size = new System.Drawing.Size(159, 22);
            this.TsmCopyPass.Text = "Copy Password";
            this.TsmCopyPass.Click += new System.EventHandler(this.TsmCopyPass_Click);
            // 
            // TsmCopyComment
            // 
            this.TsmCopyComment.Name = "TsmCopyComment";
            this.TsmCopyComment.Size = new System.Drawing.Size(159, 22);
            this.TsmCopyComment.Text = "Copy Comment";
            this.TsmCopyComment.Click += new System.EventHandler(this.TsmCopyComment_Click);
            // 
            // TsmSep2
            // 
            this.TsmSep2.Name = "TsmSep2";
            this.TsmSep2.Size = new System.Drawing.Size(156, 6);
            // 
            // TsmDeleteEntry
            // 
            this.TsmDeleteEntry.Name = "TsmDeleteEntry";
            this.TsmDeleteEntry.Size = new System.Drawing.Size(159, 22);
            this.TsmDeleteEntry.Text = "Delete Entry";
            this.TsmDeleteEntry.Click += new System.EventHandler(this.TsmDeleteEntry_Click);
            // 
            // BtnSettings
            // 
            this.BtnSettings.Location = new System.Drawing.Point(446, 19);
            this.BtnSettings.Name = "BtnSettings";
            this.BtnSettings.Size = new System.Drawing.Size(99, 41);
            this.BtnSettings.TabIndex = 4;
            this.BtnSettings.Text = "Database Settings";
            this.BtnSettings.UseVisualStyleBackColor = true;
            this.BtnSettings.Click += new System.EventHandler(this.BtnSettings_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 498);
            this.Controls.Add(this.GrpEntries);
            this.Controls.Add(this.GrpManagement);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Password Manager";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.GrpManagement.ResumeLayout(false);
            this.GrpEntries.ResumeLayout(false);
            this.GrpEntries.PerformLayout();
            this.CmsMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GrpManagement;
        private System.Windows.Forms.Button BtnCloseDB;
        private System.Windows.Forms.Button BtnSaveDB;
        private System.Windows.Forms.Button BtnLoadDB;
        private System.Windows.Forms.Button BtnNewDB;
        private System.Windows.Forms.GroupBox GrpEntries;
        private System.Windows.Forms.Button BtnDeleteEntry;
        private System.Windows.Forms.Button BtnEditEntry;
        private System.Windows.Forms.Button BtnAddEntry;
        private System.Windows.Forms.ListView LstEntries;
        private System.Windows.Forms.Button BtnClearClip;
        private System.Windows.Forms.Button BtnCopyComment;
        private System.Windows.Forms.Button BtnCopyPass;
        private System.Windows.Forms.Button BtnCopyUser;
        private System.Windows.Forms.ContextMenuStrip CmsMenu;
        private System.Windows.Forms.ToolStripMenuItem TsmEditEntry;
        private System.Windows.Forms.ToolStripSeparator TsmSep1;
        private System.Windows.Forms.ToolStripMenuItem TsmCopyUser;
        private System.Windows.Forms.ToolStripMenuItem TsmCopyPass;
        private System.Windows.Forms.ToolStripMenuItem TsmCopyComment;
        private System.Windows.Forms.ToolStripSeparator TsmSep2;
        private System.Windows.Forms.ToolStripMenuItem TsmDeleteEntry;
        private System.Windows.Forms.Label LblSearch;
        private System.Windows.Forms.TextBox TxtSearch;
        private System.Windows.Forms.ColumnHeader ColAccount;
        private System.Windows.Forms.ColumnHeader ColUsername;
        private System.Windows.Forms.ColumnHeader ColComment;
        private System.Windows.Forms.Button BtnSettings;
    }
}

