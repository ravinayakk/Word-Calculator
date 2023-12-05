using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using System.IO;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            DialogResult result = this.openFileDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                txtFileName.Text = openFileDialog1.FileName.Split('\\').LastOrDefault();
            }

        }
        private void btnExit_Click(object sender, EventArgs e)
        {

        }

        private async void btnSubmit_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            List<Task> tasks = new List<Task>();
            var file = openFileDialog1.FileName;

            var WordTask = ReadBook(file);
            tasks.Add(WordTask);

            await Task.WhenAll(tasks);

        }

        //Ravi

        private async Task ReadBook(string filename)
        {
            var lines = await Task.FromResult(File.ReadAllLinesAsync(filename));
            var arrayLinesWithoutPunctuation =
                    lines.Result.Where(x => x != string.Empty)
                    .AsParallel()
                    .Select(x => x.ToLower().Trim().Replace(",", "").Replace("'", "").Replace("{", ""));
            var arrayOfWords = arrayLinesWithoutPunctuation.SelectMany(x => x.Split(" "));
            Dictionary<string, int> wordDic = new Dictionary<string, int>();
            arrayOfWords.ToList().ForEach(x =>
            {
                if (wordDic.ContainsKey(x))
                {
                    wordDic[x] += 1;
                }
                else
                {
                    wordDic.Add(x, 1);
                }
            });

            var top10 = wordDic.Where(x => !string.IsNullOrWhiteSpace(x.Key)).OrderByDescending(x => x.Value).Take(10);
            foreach (var word in top10)
            {
                listBox1.Items.Add(word.Key + " - " + word.Value);
                listBox2.Items.Add(word.Key + " - " + word.Value);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnBrowse2_Click(object sender, EventArgs e)
        {
            DialogResult result = this.openFileDialog2.ShowDialog();

            if (result == DialogResult.OK)
            {
                txtFileName.Text = openFileDialog2.FileName.Split('\\').LastOrDefault();
            }
        }

        private async void btnSubmit2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            List<Task> tasks = new List<Task>();
            var file = openFileDialog2.FileName;

            var WordTask = ReadBook(file);
            tasks.Add(WordTask);

            await Task.WhenAll(tasks);
        }
    }
}