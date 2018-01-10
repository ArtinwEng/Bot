using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using THSplit;
using System.Speech.Synthesis;
using System.Speech.Recognition;
using System.Diagnostics;
using System.IO.Ports;
using System.Xml;
using System.Net;
using System.IO;

namespace AI_Final
{
    public partial class Ai : Form
    {

        SpeechSynthesizer s = new SpeechSynthesizer();
        



        WebClient w = new WebClient();


        Choices list = new Choices();
        int comm = 0;







        public Ai()
        {

            s.Speak("opening");

            SpeechRecognitionEngine rec = new SpeechRecognitionEngine();



            

            











            InitializeComponent();
        }




        
       

        

        public void say(String h)
        {
            s.Speak(h);
            output.AppendText(h + "\n");
        }

        public void command_AI()
        {

            

                int cout = 0;
                string line;

                string Cache = "Cache.txt";



                Spliter spliter = new Spliter();
                string conversation = input.Text;
                var word = spliter.SegmentByDictionary(conversation);



                File.WriteAllLines(Cache, word, Encoding.UTF8);



                string[] readText = File.ReadAllLines(Cache, Encoding.UTF8);
                System.IO.StreamReader file = new System.IO.StreamReader(Cache);
                List<string> list = new List<string>();
                while ((line = file.ReadLine()) != null)
                {

                    keyword.Items.Add(line);
                    list.Add(line);
                    cout++;

                   
                    if (readText.Contains("สั่ง")){comm = 1;} else if (readText.Contains("คุย")) { comm = 0; }
                    if (comm == 1)
                    {
                        output.Text = ("ให้ทำไรว่ามา");
                        if (readText.Contains("ทำ")){ output.Text = ("รอรับคำสั่งไง");}
                        if (readText.Contains("ง่วง")) { output.Text = ("งวงทำไมละตื่ินสิ"); }





                    }

                  

                    else 
                    {
                        output.Text = ("มาคุยกันเถอะ");
                        if (readText.Contains("สั่ง")) { comm = 1; }

                        if (readText.Contains("กิน")){output.Text = ("ยังเลย");}

                    }





                }





            





        

    }












        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


            Application.Exit();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void start_Click(object sender, EventArgs e)
        {


            command_AI();
        }

        private void train_Click(object sender, EventArgs e)
        {
            Process.Start("ai training.exe");
        }
    }
}
