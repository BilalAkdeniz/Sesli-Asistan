using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Recognition;
using System.Speech.Synthesis;
using System.Threading;
using System.Diagnostics;

namespace SesliAsistan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SpeechRecognitionEngine reco = new SpeechRecognitionEngine();
        SpeechSynthesizer yanit = new SpeechSynthesizer();

        private void Mic1_Click(object sender, EventArgs e)
        {
            try
            {
                Mic1.Visible = false;
                reco.RecognizeAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Mic2_Click(object sender, EventArgs e)
        {
            Mic1.Visible = true;
        }

        void sesimiTanirsa()
        {
            // Algılayabildiği komutlar //
            string[] komutlar = { "kromu aç", "Komutları Göster", "Alışveriş", "not" };
            Choices secenekler = new Choices(komutlar);
            Grammar grammer = new Grammar(new GrammarBuilder(secenekler));
            reco.LoadGrammar(grammer);
            reco.SetInputToDefaultAudioDevice();
            reco.SpeechRecognized += sesimiTanidi;

            foreach(var x in komutlar)
            {
                listBox1.Items.Add(x);
            }
        }

        private void sesimiTanidi(object sender, SpeechRecognizedEventArgs e)
        {
            try
            {
                switch (e.Result.Text)
                {
                    case "not":
                        yanit.SpeakAsync("ı am opening");
                        System.Diagnostics.Process.Start("\"C:\\Users\\bilal\\AppData\\Local\\Programs\\Notion\\Notion.exe\"");
                        break;
                    case "Alışveriş":
                        yanit.SpeakAsync("Ok");
                        System.Diagnostics.Process.Start("\"C:\\Users\\bilal\\OneDrive\\Masaüstü\\New Internet Shortcut.url\"");
                        break;
                    case "kromu aç":
                        yanit.SpeakAsync("ok");
                        System.Diagnostics.Process.Start("\"C:\\Program Files\\Google\\Chrome\\Application\\chrome.exe\"");
                        break;
                    case "Komutları Göster":
                        // Komutları Gösterme Bloğu //
                        yanit.SpeakAsync("ok");
                        timer1.Start();
                        listBox1.Visible = true;
                        break;
                    default:
                        MessageBox.Show("Tanımlanmamış bir komut girdiniz.\n Komutları görmek için KOMUTLARI GÖSTER diyebilirsiniz...");
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            sesimiTanirsa();
            // Karşılama //
            yanit.SpeakAsync("Welcome , Tell me what you need");
        }

        private void seçeneklerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mic1.Visible = false;
            Mic2.Visible = false;
            Komutlartxt.Visible = true;
        }

        private void konuşToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mic1.Visible = true;
            Mic2.Visible = true;
            Komutlartxt.Visible = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            listBox1.Visible = false;
            yanit.SpeakAsync("closed");
        }
    }
}
