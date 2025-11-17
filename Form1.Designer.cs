namespace Notepad
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.NotepadTextBox = new System.Windows.Forms.TextBox();
            this.NotepadMenuStrip = new System.Windows.Forms.MenuStrip();
            this.ファイルToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ReadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NotepadSaveDialog = new System.Windows.Forms.SaveFileDialog();
            this.NotepadOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.NotepadMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // NotepadTextBox
            // 
            this.NotepadTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NotepadTextBox.Location = new System.Drawing.Point(12, 46);
            this.NotepadTextBox.Multiline = true;
            this.NotepadTextBox.Name = "NotepadTextBox";
            this.NotepadTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.NotepadTextBox.Size = new System.Drawing.Size(767, 392);
            this.NotepadTextBox.TabIndex = 0;
            this.NotepadTextBox.WordWrap = false;
            this.NotepadTextBox.ModifiedChanged += new System.EventHandler(this.NotepadTextBox_ModifiedChanged);
            // 
            // NotepadMenuStrip
            // 
            this.NotepadMenuStrip.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.NotepadMenuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.NotepadMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ファイルToolStripMenuItem});
            this.NotepadMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.NotepadMenuStrip.Name = "NotepadMenuStrip";
            this.NotepadMenuStrip.Size = new System.Drawing.Size(800, 33);
            this.NotepadMenuStrip.TabIndex = 1;
            this.NotepadMenuStrip.Text = "menuStrip1";
            // 
            // ファイルToolStripMenuItem
            // 
            this.ファイルToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewToolStripMenuItem,
            this.ReadToolStripMenuItem,
            this.SaveToolStripMenuItem});
            this.ファイルToolStripMenuItem.Name = "ファイルToolStripMenuItem";
            this.ファイルToolStripMenuItem.Size = new System.Drawing.Size(79, 29);
            this.ファイルToolStripMenuItem.Text = "ファイル";
            // 
            // NewToolStripMenuItem
            // 
            this.NewToolStripMenuItem.Name = "NewToolStripMenuItem";
            this.NewToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.NewToolStripMenuItem.Text = "新規作成";
            this.NewToolStripMenuItem.Click += new System.EventHandler(this.NewToolStripMenuItem_Click);
            // 
            // ReadToolStripMenuItem
            // 
            this.ReadToolStripMenuItem.Name = "ReadToolStripMenuItem";
            this.ReadToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.ReadToolStripMenuItem.Text = "読み込み";
            this.ReadToolStripMenuItem.Click += new System.EventHandler(this.ReadToolStripMenuItem_Click);
            // 
            // SaveToolStripMenuItem
            // 
            this.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem";
            this.SaveToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.SaveToolStripMenuItem.Text = "保存";
            this.SaveToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItem_Click);
            // 
            // NotepadSaveDialog
            // 
            this.NotepadSaveDialog.Filter = "テキストファイル|*.txt|すべてのファイル|*.*";
            this.NotepadSaveDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.NotepadSaveDialog_FileOk);
            // 
            // NotepadOpenFileDialog
            // 
            this.NotepadOpenFileDialog.FileName = "openFileDialog1";
            this.NotepadOpenFileDialog.Filter = "テキストファイル|*.txt|すべてのファイル|*.*";
            this.NotepadOpenFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.NotepadOpenFileDialog_FileOk);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.NotepadTextBox);
            this.Controls.Add(this.NotepadMenuStrip);
            this.MainMenuStrip = this.NotepadMenuStrip;
            this.Name = "Form1";
            this.Text = "無題 - NotePad";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.NotepadMenuStrip.ResumeLayout(false);
            this.NotepadMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NotepadTextBox;
        private System.Windows.Forms.MenuStrip NotepadMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem ファイルToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem NewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ReadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog NotepadSaveDialog;
        private System.Windows.Forms.OpenFileDialog NotepadOpenFileDialog;
    }
}

