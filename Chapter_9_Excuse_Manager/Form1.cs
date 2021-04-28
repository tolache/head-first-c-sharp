using System;
using System.IO;
using System.Windows.Forms;

namespace Chapter_9_Excuse_Manager
{
    public partial class Form1 : Form
    {
        private bool formChanged = false;
        private string excuseFolder;
        private Random random;
        private Excuse currentExcuse;

        public Form1()
        {
            InitializeComponent();
            currentExcuse = new Excuse {LastUsed = lastUsed.Value};
            random = new Random();
        }
        
        private void UpdateForm(bool changed)
        {
            if (!changed)
            {
                description.Text = currentExcuse.Description;
                results.Text = currentExcuse.Results;
                lastUsed.Value = currentExcuse.LastUsed;
                if (!String.IsNullOrEmpty(currentExcuse.ExcusePath))
                {
                    fileDate.Text = File.GetLastWriteTime(currentExcuse.ExcusePath).ToString();
                }
                Text = "Excuse Manager";
            }
            else
            {
                Text = "Excuse Manager*";
            }

            formChanged = changed;
        }

        private void description_TextChanged(object sender, EventArgs e)
        {
            currentExcuse.Description = description.Text;
            UpdateForm(true);
        }

        private void results_TextChanged(object sender, EventArgs e)
        {
            currentExcuse.Results = results.Text;
            UpdateForm(true);
        }

        private void lastUsed_ValueChanged(object sender, EventArgs e)
        {
            currentExcuse.LastUsed = lastUsed.Value;
            UpdateForm(true);
        }

        private void folder_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() != DialogResult.OK) return;
            excuseFolder = folderBrowserDialog1.SelectedPath;
            save.Enabled = true;
            open.Enabled = true;
            randomButton.Enabled = true;
        }

        private void save_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(description.Text) || String.IsNullOrEmpty(results.Text))
            {
                MessageBox.Show("Enter the an excuse and a result.", "WO WAI CAN'T SAVE");
                return;
            }
            if (saveFileDialog1.ShowDialog() != DialogResult.OK) return;
            currentExcuse.Save(saveFileDialog1.FileName);
            UpdateForm(false);
        }

        private void open_Click(object sender, EventArgs e)
        {
            if (formChanged)
            {
                DialogResult unsavedExcuseDialog = MessageBox.Show("Discard changed to current excuse?","Unsaved excuse", MessageBoxButtons.YesNo);
                if (unsavedExcuseDialog == DialogResult.No) return;
            }
            if (openFileDialog1.ShowDialog() != DialogResult.OK) return;
            currentExcuse = new Excuse(openFileDialog1.FileName);
            UpdateForm(false);
        }

        private void randomButton_Click(object sender, EventArgs e)
        {
            currentExcuse = new Excuse(random, excuseFolder);
            UpdateForm(false);
        }
    }
}