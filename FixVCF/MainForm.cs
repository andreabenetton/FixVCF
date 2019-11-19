using System;
using System.IO;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using MixERP.Net.VCards;
using System.Linq;

namespace FixVCF
{
    public partial class MainForm : Form
    {
        private IEnumerable<VCard> vcards;

        public MainForm()
        {
            InitializeComponent();
        }

        private void ButtonLoadSelectorOpen_Click(object sender, EventArgs e)
        {
            
            string path = textBoxLoadFullPath.Text;
            try
            {
                string contents = File.ReadAllText(path, Encoding.UTF8);
                vcards = Deserializer.GetVCards(contents);
            }
            catch (IOException)
            {
            }
        }

        private void ButtonProcess_Click(object sender, EventArgs e)
        {
            List<VCard> vout = new List<VCard>();
            double n = 100.0/vcards.Count();
            int count = 0;

            foreach (var vcard in vcards)
            {
                count += 1;
                string[] words = vcard.FormattedName.Split(' ');
                vcard.FirstName = words[0];

                if (words.Length == 2) vcard.LastName = words[1];
                if (words.Length == 3) vcard.LastName = words[1] + " " + words[2];

                vcard.CustomExtensions = null;
                vcard.UniqueIdentifier = null;

                if (vcard.Telephones != null)
                {
                    foreach (var tel in vcard.Telephones)
                    {
                        tel.Number = TrimAllWithInplaceCharArray(tel.Number);
                        tel.Type = MixERP.Net.VCards.Types.TelephoneType.Voice;
                    }
                    vout.Add(vcard);
                }
                progressBarProcess.Value = Convert.ToInt32(count * n);
            }

            string content = MixERP.Net.VCards.Serializer.VCardCollectionSerializer.Serialize(vout);
            File.WriteAllText(textBoxSaveFullPath.Text, content);
        }

        private void TextBoxLoadFullPath_DoubleClick(object sender, EventArgs e)
        {
            DialogResult result = openFileDialogLoadSelector.ShowDialog();
            if (result == DialogResult.OK) // Test result.
            {
                textBoxLoadFullPath.Text = openFileDialogLoadSelector.FileName;
                buttonLoadSelectorOpen.Enabled = true;
            }
        }

        private void TextBoxSaveFullPath_DoubleClick(object sender, EventArgs e)
        {
            if (saveFileDialogSelector.ShowDialog() == DialogResult.OK)
            {
                textBoxSaveFullPath.Text = saveFileDialogSelector.FileName;
                buttonProcess.Enabled = true;
            }
        }

        public static string TrimAllWithInplaceCharArray(string str)
        {
            var len = str.Length;
            var src = str.ToCharArray();
            int dstIdx = 0;
            for (int i = 0; i < len; i++)
            {
                var ch = src[i];
                if (!isWhiteSpace(ch))
                    src[dstIdx++] = ch;
            }
            return new string(src, 0, dstIdx);
        }

        public static bool isWhiteSpace(char ch)
        {
            // this is surprisingly faster than the equivalent if statement
            switch (ch)
            {
                case '\u0009':
                case '\u000A':
                case '\u000B':
                case '\u000C':
                case '\u000D':
                case '\u0020':
                case '\u0085':
                case '\u00A0':
                case '\u1680':
                case '\u2000':
                case '\u2001':
                case '\u2002':
                case '\u2003':
                case '\u2004':
                case '\u2005':
                case '\u2006':
                case '\u2007':
                case '\u2008':
                case '\u2009':
                case '\u200A':
                case '\u2028':
                case '\u2029':
                case '\u202F':
                case '\u205F':
                case '\u3000':
                    return true;
                default:
                    return false;
            }
        }
    }
}
