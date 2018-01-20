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
        private int CoutM;
        private int diceMs;
        private string conversation;
        private string inputT;
        Random rnd = new Random();
        SpeechSynthesizer s = new SpeechSynthesizer();


        



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
            
            input.Clear();
           
        }

        public void command_AI()
        {
            int cout = 0;
            string line;
            string Cache = "CacheM.txt";
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


                if (readText.Contains("ช่วยอะไรหน่อย"))
                {
                    pictureBox3.Height = Sc.Height;
                    pictureBox3.Top = Sc.Top;
                    panelB.BringToFront();
                    CoutM = 1;
                    say("พร้อมรับคำสั่งแล้ว");

                }
//-------------------------------------------------------------------------------------------------------------------
                else if (readText.Contains("หาข้อมูล"))
                {

                    pictureBox3.Height = F.Height;
                    pictureBox3.Top = F.Top;
                    panelC.BringToFront();
                    CoutM = 2;
                    say("มาคุยกันเถอะ");

                }
                //-------------------------------------------------------------------------------------------------------------------




                else if (readText.Contains("ไง"))
                {
                    switch (diceMs)
                    {
                        case 0: say("สวัดดี"); break;
                        case 1: say("ไง"); break;
                        case 2: say("เจอกันอีกแล้ว"); break;
                        case 3: say("จ้า"); break;
                    }
                }
                else if (readText.Contains("สวัดดี"))
                {
                    switch (diceMs)
                    {
                        case 0: say("สวัสดี"); break;
                        case 1: say("ไง"); break;
                        case 2: say("เจอกันอีกแล้ว"); break;
                        case 3: say("จ้า"); break;
                    }
                }
                else if (readText.Contains("ตอนเช้า"))
                {
                    switch (diceMs)
                    {
                        case 0: say("อรุณสวัสดิ์จ้า"); break;
                        case 1: say("มอนิ่ง จ้า"); break;
                        case 2: say("รีปตืนเลย"); break;
                        case 3: say("จ้า"); break;
                    }
                }

                else if (readText.Contains("ฝันดี"))
                {
                    switch (diceMs)
                    {
                        case 0: say("ฝันดีนะ"); break;
                        case 1: say("ฝันดีจ้า"); break;
                        case 2: say("บายๆ"); break;
                        case 3: say("จ้า"); break;
                    }
                }

                



                //------------------------------------------------------------Add----------------------------------------//


                else
                {
                    switch (diceMs)
                    {
                        case 0: say("ไม่มีคำสั่ง"); break;
                        case 1: say("สอนฉันสิ"); break;
                        case 2: say("ยังไม่พิมดีๆอีก"); break;
                        case 3: say("ช่างพ่อง"); break;
                    }
                }


            }
        }

            public void commandM()
            {
         
            int cout = 0;
                string line;
                string Cache = "Cacheone.txt";
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
                int countst = word.Count;
                countst = countst - 2;


                if (readText.Contains("กี่โมง"))
                    {
                        say("ขณะนี้เวลา" + DateTime.Now.ToString("h:mm tt"));
                    }
                else if (readText.Contains("เปิดเฟสบุ๊ค"))
                    {
                    Process.Start("http://facebook.com");
                    switch (diceMs)
                    {
                        case 0: say("เรียบร้อย"); break;
                        case 1: say("เสร็จแล้ว"); break;
                        case 2: say("เรียบ100"); break;
                        case 3: say("จ้า"); break;
                    }
                    }


               else if (readText[0] == ("ใคร") )
                { 
                             
                    Process.Start("https://www.google.co.th/#q=" + (conversation) + "wikipedia");
                    switch (diceMs)
                    {
                        case 0: say("เรียบร้อย"); break;
                        case 1: say("เสร็จแล้ว"); break;
                        case 2: say("เรียบ100"); break;
                        case 3: say("จ้า"); break;

                    }
                    cler();
                }

               else if (readText[0] == ("ที่ไหน") || readText[countst] == ("ไหน"))
                {

                    Process.Start("https://www.google.co.th/maps/place/" + (conversation));
                    switch (diceMs)
                    {
                        case 0: say("เรียบร้อย"); break;
                        case 1: say("เสร็จแล้ว"); break;
                        case 2: say("เรียบ100"); break;
                        case 3: say("จ้า"); break;

                    }
                    cler();
                }























                else if (readText[0] == ("ขอบคุณ"))
                {
                    pictureBox3.Height = Sc.Height;
                    pictureBox3.Top = Sc.Top;
                    panelA.BringToFront();
                    CoutM = 0;
                    switch (diceMs)
                    {
                        case 0: say("เรียบร้อย"); break;
                        case 1: say("เสร็จแล้ว"); break;
                        case 2: say("เรียบ100"); break;
                        case 3: say("จ้า"); break;
                    }
                }

             













                //------------------------------------------------------------Add----------------------------------------//

            }


            }
        public void cler()
        {

            conversation = (null);

        }
        public void commandE()
        {
            int cout = 0;
            string line;
            string Cache = "CacheTwo.txt";
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
                int countst = word.Count;
                countst = countst - 2;


                

                if (readText[0]==("อะไร") || readText[countst] == ("อะไร"))
                {
                    
                    switch (diceMs)
                    {
                        case 0: say("อะไรนะสัส"); break;
                        case 1: say("กูไม่ตอบมึงหรอก"); break;
                        case 2: say("ช่างพ่อมึง"); break;
                        case 3: say("แล้วแต่มึงเลย"); break;
                    }
                }


                else if (readText[0]==("ขอบคุณ"))
                {
                    pictureBox3.Height = Sc.Height;
                    pictureBox3.Top = Sc.Top;
                    panelA.BringToFront();
                    CoutM = 0;
                    switch (diceMs)
                    {
                        case 0: say("เรียบร้อย"); break;
                        case 1: say("เสร็จแล้ว"); break;
                        case 2: say("เรียบ100"); break;
                        case 3: say("จ้า"); break;
                    }
                }


                //------------------------------------------------------------Add----------------------------------------//

            }


        }



        public void InputT()
        {
            Spliter spliter = new Spliter();
            string text = input.Text;
            var word = spliter.SegmentByDictionary(text);
            foreach (string value in word)
               if (value == "ซอล")
                {
                    diceMs = rnd.Next(3);



                    if (CoutM == 0)
                    {

                        command_AI();

                    }
                    else if (CoutM == 1)
                    {

                        commandM();


                    }
                    else if (CoutM == 2)
                    {

                        commandE();


                    }
                }
               


        }


















        private void start_Click(object sender, EventArgs e)
            {
            
            diceMs = rnd.Next(3);



                if (CoutM == 0)
                {
               
                command_AI();
                 
                }
                else if (CoutM == 1)
                {
              
                commandM();
               

            }
                else if (CoutM == 2)
                {
                
                commandE();
                

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


            private void train_Click(object sender, EventArgs e)
            {
     


             Process.Start("ai training.exe");
        }

        private void input_TextChanged(object sender, EventArgs e)
        {

            inputT = input.Text; 
        InputT();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void panelC_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
    }


