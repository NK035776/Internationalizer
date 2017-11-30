using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Internalization
{
    public partial class Translator : Form
    {
        private Boolean bbFirstTime = false;
        public Translator()
        {
            InitializeComponent();
            YandexTranslate.PopulateLanguageCbo(comboBox1);
            UpdateStatusBar("Ready...");
        }



        private void button1_Click(object sender, EventArgs e)
        {
            YandexTranslate vm = new YandexTranslate();
            UpdateStatusBar("InProcess...");
            if (this.checkBox1.CheckState == CheckState.Unchecked)
            {
                if (this.maskedTextBox1.Text.Contains("StringResource"))
                    XMLParse.GetStringValueFromResource(this.maskedTextBox1.Text, ((KeyValuePair<string, string>)comboBox1.SelectedItem).Key, this.textBox1.Text);
                else
                    Internalization.FormResourceConverter.ConvertFormResx(this.maskedTextBox1.Text, ((KeyValuePair<string, string>)comboBox1.SelectedItem).Key, this.textBox1.Text);
            }
            else
            {
                if ((this.textBox2.Text != string.Empty) && (this.textBox3.Text != String.Empty))
                {
                    if (this.maskedTextBox1.Text.Contains("StringResource"))
                        XMLParse.GetStringValueFromResource(this.maskedTextBox1.Text, (this.textBox2.Text + "-" + this.textBox3.Text), this.textBox1.Text);
                    else
                        Internalization.FormResourceConverter.ConvertFormResx(this.maskedTextBox1.Text, (this.textBox2.Text + "-" + this.textBox3.Text), this.textBox1.Text);
                }
            }
            
            UpdateStatusBar("Done");
        }

        private void Form1_DragDrop(object sender, DragEventArgs e)
        {
            string[] FileList = (string[])e.Data.GetData(DataFormats.FileDrop, false);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (var selectFileDialog = new OpenFileDialog())
            {
                selectFileDialog.Filter = "resx files (*.resx)|*.resx|All files (*.*)|*.*";
                //selectFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                selectFileDialog.FilterIndex = 2;
                selectFileDialog.RestoreDirectory = true;
                if (selectFileDialog.ShowDialog() == DialogResult.OK)
                {
                    this.maskedTextBox1.Text = selectFileDialog.FileName;
                }
            }
        }

        private void buttonForBuild_Click(object sender, EventArgs e)
        {
            //BuildTraget.Compile("C:\\Users\\Nikhil\\Documents\\Visual Studio 2017\\Projects\\Sample\\Sample");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            this.richTextBox1.Enabled = false;
            this.button3.Enabled = false;
            if (this.checkBox1.CheckState == CheckState.Unchecked)
            {
                this.comboBox1.Enabled = true;
                this.textBox2.Enabled = false;
                this.textBox3.Enabled = false;
                this.button2.Enabled = false;
            }
            
        }

        private void UpdateStatusBar(string text)
        {
            this.toolStripStatusLabel1.Text = text;
            this.statusStrip1.Invalidate();
            this.statusStrip1.Refresh();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Grid objGrid = new Grid();
            objGrid.Show();
        }

        private void checkBox1_CheckStateChanged(object sender, EventArgs e)
        {
            if(this.checkBox1.CheckState == CheckState.Checked)
            {
                this.comboBox1.Enabled = false;
                this.textBox2.Enabled = true;
                this.textBox3.Enabled = true;
                this.button2.Enabled = true;
                if (bbFirstTime == false)
                {
                    MessageBox.Show("Click on Help button to get supported language codes");
                    bbFirstTime = true;
                }

            }
            else
            {
                this.comboBox1.Enabled = true;
                this.textBox2.Enabled = false;
                this.textBox3.Enabled = false;
                this.button2.Enabled = false;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            using (var selectFileDialog = new OpenFileDialog())
            {
               
                if (selectFileDialog.ShowDialog() == DialogResult.OK)
                {
                    this.textBox1.Text = selectFileDialog.FileName;
                }
            }
        }
    }

    }

