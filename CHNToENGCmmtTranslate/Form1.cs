using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CHNToENGCmmtTranslate
{
    public partial class TranslateToEng : Form
    {
        public TranslateToEng()
        {
            InitializeComponent();
        }
        private void btnselectfolderpath_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderDialog = new FolderBrowserDialog())
            {
                folderDialog.Description = "Select a folder Path";
                folderDialog.ShowNewFolderButton = true;

                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    txtpath.Text = folderDialog.SelectedPath;
                }
            }
        }

        private void btntnslate_Click(object sender, EventArgs e)
        {
            try
            {
                string folderPath = txtpath.Text;
                var csFiles = Directory.GetFiles(folderPath, "*.cs", SearchOption.AllDirectories);

                foreach (var file in csFiles)
                {
                    TranslateCommentsInFile(file);
                }
                MessageBox.Show("✅ All Chinese comments translated.");
                txtpath.Text = "";
            }
            catch(Exception)
            {
                MessageBox.Show("Please select valid path.");
            }
            
        }


        static void TranslateCommentsInFile(string filePath)
        {
            string[] lines = File.ReadAllLines(filePath);
            bool changed = false;

            for (int i = 0; i < lines.Length; i++)
            {
                string line = lines[i];
                //  if (line.Trim().StartsWith("#region", StringComparison.OrdinalIgnoreCase))
                if (line.Trim().StartsWith("//"))
                {
                    string comment = line.Trim().Substring(2).Trim();

                    if (Regex.IsMatch(comment, @"[\u4e00-\u9fff]"))
                    {
                        string translated = TranslateViaFreeGoogle(comment);
                        lines[i] = line.Replace(comment, translated);
                        Console.WriteLine($"📄 {Path.GetFileName(filePath)}: {comment} → {translated}");
                        changed = true;
                    }
                }
            }

            if (changed)
                File.WriteAllLines(filePath, lines);
        }
        static string TranslateViaFreeGoogle(string text)
        {
            try
            {
                string url = $"https://translate.googleapis.com/translate_a/single?client=gtx&sl=zh-CN&tl=en&dt=t&q={Uri.EscapeDataString(text)}";
                //string url = $"https://translate.googleapis.com/translate_a/single?client=gtx&sl=auto&tl=en&dt=t&q={Uri.EscapeDataString(originalText)}";

                using (WebClient wc = new WebClient())
                {
                    wc.Headers.Add("User-Agent", "Mozilla/5.0");
                    string result = wc.DownloadString(url);

                    // Parse result: [["Hello","你好",...]]
                    var match = Regex.Match(result, @"\[\[\[\""(.*?)\""");
                    return match.Success ? match.Groups[1].Value : text;
                }
            }
            catch
            {
                return text; // fallback if fails
            }
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            txtpath.Text = "";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
