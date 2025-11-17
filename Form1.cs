using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notepad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 保存確認
        /// </summary>
        /// <returns>true: 保存済または保存しないと選択されたとき。　False：保存確認でキャンセルを押下したとき</returns>
        private bool SaveConfirmation()
        {
            if (NotepadTextBox.Modified == true)
            {
                DialogResult result = MessageBox.Show("内容が変更されています。保存しますか。", "ファイルの保存確認", MessageBoxButtons.YesNoCancel);
                // 保存ボタンの「はい」を押下時
                if (result == DialogResult.Yes)
                {
                    // ファイル保存
                    DialogResult saveDialogResult = NotepadSaveDialog.ShowDialog();
                    if (saveDialogResult == DialogResult.OK)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                }
                // キャンセルボタン押下時
                else if (result == DialogResult.Cancel)
                {
                    // キャンセル押下時
                    return false;
                }
                    NotepadTextBox.Modified = false;    // テキストボックスの変更検知フラグをオフにする
            }

            return true;
        }

        /// <summary>
        /// 新規作成ボタンの選択
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool result = SaveConfirmation();
            if (result == true)
            {
                NotepadTextBox.Text = "";
                Text = "無題 - Notepad";
                NotepadTextBox.Modified = false;    // 変更済みのフラグをFalseにすることでファイル保存後の

            }
        }

        /// <summary>
        /// 読み込みボタンの選択
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ReadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveConfirmation();
            NotepadOpenFileDialog.ShowDialog();
        }

        /// <summary>
        /// 保存ボタンの選択
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NotepadSaveDialog.ShowDialog();
        }

        /// <summary>
        /// ファイルの保存、OKボタン押下
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NotepadSaveDialog_FileOk(object sender, CancelEventArgs e)
        {
            bool APPEND = false; // true: 追記モード、false: 上書きモード
            StreamWriter sw = new StreamWriter(NotepadSaveDialog.FileName, APPEND, Encoding.UTF8);
            sw.Write(NotepadTextBox.Text);
            sw.Close();

            String fileName = Path.GetFileName(NotepadSaveDialog.FileName); // C:\Users\Owner\a.txt -> a.txt
            Text = fileName + " - Notepad";
            NotepadTextBox.Modified = false;    // 変更済みのフラグをFalseにすることでファイル保存後の
        }

        /// <summary>
        /// ファイルを開く、OKボタン押下
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NotepadOpenFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            StreamReader sr = new StreamReader(NotepadOpenFileDialog.FileName, Encoding.UTF8);
            NotepadTextBox.Text = sr.ReadToEnd();
            sr.Close();


            String fileName = Path.GetFileName(NotepadOpenFileDialog.FileName); // C:\Users\Owner\a.txt -> a.txt
            Text = fileName + " - Notepad";
            NotepadTextBox.Modified = false;    // 変更済みのフラグをFalseにすることでファイル保存後の

        }

        private void NotepadTextBox_ModifiedChanged(object sender, EventArgs e)
        {
            if (NotepadTextBox.Modified)
            {
                Text = "*" + Text;
            }
            else
            {
                Text = Text.TrimStart('*');
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            bool result = SaveConfirmation();
            if (result == false)
            {
                e.Cancel = true;
            }
        }
    }
}
