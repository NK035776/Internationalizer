namespace Internalization
{
    partial class Grid
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Grid));
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Items.AddRange(new object[] {
            "Language\tCode\t\tLanguage\tCode",
            "",
            "Azerbaijan\taz\t\tMalayalam\tml",
            "Albanian\t\tsq\t\tMaltese\t\tmt",
            "Amharic\t\tam\t\tMacedonian\tmk",
            "English\t\ten\t\tMaori\t\tmi",
            "Arabic\t\tar\t\tMarathi\t\tmr",
            "Armenian\t\thy\t\tMari\t\tmhr",
            "Afrikaans\t\taf\t\tMongolian\tmn",
            "Basque\t\teu\t\tGerman\t\tde",
            "Bashkir\t\tba\t\tNepali\t\tne",
            "Belarusian\tbe\t\tNorwegian\tno",
            "Bengali\t\tbn\t\tPunjabi\t\tpa",
            "Burmese\t\tmy\t\tPapiamento\tpap",
            "Bulgarian\t\tbg\t\tPersian\t\tfa",
            "Bosnian\t\tbs\t\tPolish\t\tpl",
            "Welsh\t\tcy\t\tPortuguese\tpt",
            "Hungarian\thu\t\tRomanian\tro",
            "Vietnamese\tvi\t\tRussian\t\tru",
            "Haitian (Creole)\tht\t\tCebuano\t\tceb",
            "Galician\t\tgl\t\tSerbian\t\tsr",
            "Dutch\t\tnl\t\tSinhala\t\tsi",
            "Hill Mari\t\tmrj\t\tSlovakian\t\tsk",
            "Greek\t\tel\t\tSlovenian\t\tsl",
            "Georgian\t\tka\t\tSwahili\t\tsw",
            "Gujarati\t\tgu\t\tSundanese\tsu",
            "Danish\t\tda\t\tTajik\t\ttg",
            "Hebrew\t\the\t\tThai\t\tth",
            "Yiddish\t\tyi\t\tTagalog\t\ttl",
            "Indonesian\tid\t\tTamil\t\tta",
            "Irish\t\tga\t\tTatar\t\ttt",
            "Italian\t\tit\t\tTelugu\t\tte",
            "Icelandic\t\tis\t\tTurkish\t\ttr",
            "Spanish\t\tes\t\tUdmurt\t\tudm",
            "Kazakh\t\tkk\t\tUzbek\t\tuz",
            "Kannada\t\tkn\t\tUkrainian\t\tuk",
            "Catalan\t\tca\t\tUrdu\t\tur",
            "Kyrgyz\t\tky\t\tFinnish\t\tfi",
            "Chinese\t\tzh\t\tFrench\t\tfr",
            "Korean\t\tko\t\tHindi\t\thi",
            "Xhosa\t\txh\t\tCroatian\t\thr",
            "Khmer\t\tkm\t\tCzech\t\tcs",
            "Laotian\t\tlo\t\tSwedish\t\tsv",
            "Latin\t\tla\t\tScottish\t\tgd",
            "Latvian\t\tlv\t\tEstonian\t\tet",
            "Lithuanian\tlt\t\tEsperanto\teo",
            "Luxembourgish\tlb\t\tJavanese\t\tjv",
            "Malagasy\t\tmg\t\tJapanese\t\tja",
            "Malay\t\tms\t\t"});
            this.listBox2.Location = new System.Drawing.Point(1, 5);
            this.listBox2.Name = "listBox2";
            this.listBox2.ScrollAlwaysVisible = true;
            this.listBox2.Size = new System.Drawing.Size(405, 524);
            this.listBox2.TabIndex = 1;
            // 
            // Grid
            // 
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(410, 534);
            this.Controls.Add(this.listBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Grid";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "List Of Supported Languages";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Grid_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
    }
}