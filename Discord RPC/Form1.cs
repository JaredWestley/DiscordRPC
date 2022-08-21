using Newtonsoft.Json;
using System;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Collections.Generic;
using DiscordRPC;
using Button = DiscordRPC.Button;


namespace Discord_RPC
{
    public partial class Form1 : Form
    {
        class DiscordRPCINFO
        {
            public string ClientIDRPC { get; set; }
            public string DetailsRPC { get; set; }
            public string StateRPC { get; set; }
            public string LargeImageIconRPC { get; set; }
            public string LargeImageTextRPC { get; set; }
            public string SmallImageIconRPC { get; set; }
            public string SmallImageTextRPC { get; set; }
            public string ButtonTitleRPC { get; set; }
            public string ButtonLinkRPC { get; set; }
        }

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
         (
               int nLeftRect,
               int nTopRect,
               int nRightRect,
               int nBottomRect,
               int nWidthEllipse,
               int nHeightEllipse

         );

        public int SelectionLength { get; private set; }


        public Form1()
        {
            Createjson();
            InitializeComponent();
            siticoneRoundedTextBox1.Visible = false;
            siticoneRoundedTextBox2.Visible = false;
            siticoneRoundedTextBox3.Visible = false;
            siticoneRoundedTextBox4.Visible = false;
            siticoneRoundedTextBox5.Visible = false;
            siticoneRoundedTextBox6.Visible = false;
            siticoneRoundedTextBox7.Visible = false;
            siticoneRoundedTextBox8.Visible = false;
            siticoneRoundedTextBox9.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            siticoneRoundedButton5.Visible = true;
            siticoneRoundedButton4.Visible = false;
            siticoneRoundedButton3.Visible = false;
            siticoneRoundedButton1.Visible = false;
            siticoneRoundedButton2.Visible = true;
            siticonePanel1.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, siticonePanel1.Width, siticonePanel1.Height, 15, 15));
            
        }

        private void form_design1_enter(object sender, EventArgs e)
        {
            try
            {
                string _path = @"config.json";
                string jsonFromFile;
                using (var reader = new StreamReader(_path))
                {
                    jsonFromFile = reader.ReadToEnd();
                }
                string result_Panel_Main_Design = "";
                dynamic obj_Panel_Main_Design = JsonConvert.DeserializeObject(jsonFromFile);
                result_Panel_Main_Design = (obj_Panel_Main_Design.Panel_Main_Design);
                Color panel3backcolour = ColorTranslator.FromHtml($"{result_Panel_Main_Design}");

                string result_Panel_Secondary_Design = "";
                dynamic obj_Panel_Secondary_Design = JsonConvert.DeserializeObject(jsonFromFile);
                result_Panel_Secondary_Design = (obj_Panel_Secondary_Design.Panel_Secondary_Design);
                Color panel1backcolour = ColorTranslator.FromHtml($"{result_Panel_Secondary_Design}");

                this.panel2.BackgroundImageLayout = ImageLayout.Zoom;
                this.panel2.BackgroundImage = Image.FromFile(@"header.png");
                this.panel3.BackColor = panel3backcolour;
                this.siticoneRoundedTextBox1.BackColor = panel3backcolour;
                this.siticoneRoundedTextBox2.BackColor = panel3backcolour;
                this.siticoneRoundedTextBox3.BackColor = panel3backcolour;
                this.siticoneRoundedTextBox4.BackColor = panel3backcolour;
                this.siticoneRoundedTextBox5.BackColor = panel3backcolour;
                this.siticoneRoundedTextBox6.BackColor = panel3backcolour;
                this.siticoneRoundedTextBox7.BackColor = panel3backcolour;
                this.siticoneRoundedTextBox8.BackColor = panel3backcolour;
                this.siticoneRoundedTextBox9.BackColor = panel3backcolour;
                this.panel1.BackColor = panel3backcolour;
                this.siticoneLabel1.ForeColor = panel1backcolour;
                this.label1.BackColor = panel3backcolour;
                this.label2.BackColor = panel3backcolour;
                this.label3.BackColor = panel3backcolour;
                this.label4.BackColor = panel3backcolour;
                this.label5.BackColor = panel3backcolour;
                this.label6.BackColor = panel3backcolour;
                this.label7.BackColor = panel3backcolour;
                this.label8.BackColor = panel3backcolour;
                this.label9.BackColor = panel3backcolour;
                this.label1.ForeColor = panel1backcolour;
                this.label2.ForeColor = panel1backcolour;
                this.label3.ForeColor = panel1backcolour;
                this.label4.ForeColor = panel1backcolour;
                this.label5.ForeColor = panel1backcolour;
                this.label6.ForeColor = panel1backcolour;
                this.label7.ForeColor = panel1backcolour;
                this.label8.ForeColor = panel1backcolour;
                this.label9.ForeColor = panel1backcolour;
                this.siticoneRoundedButton4.BackColor = panel1backcolour;
                this.siticoneRoundedButton3.BackColor = panel1backcolour;
                this.siticoneRoundedButton1.BackColor = panel1backcolour;
                this.siticoneRoundedButton5.BackColor = panel1backcolour;
                this.siticoneRoundedButton2.BackColor = panel1backcolour;
                this.siticoneControlBox1.FillColor = panel1backcolour;
                this.siticoneControlBox2.FillColor = panel1backcolour;
            }
            catch (Exception ex)
            {
                // ignored
            }
        }

        private void SiticoneControlBox1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void SiticoneRoundedTextBox1_enter(object sender, EventArgs e)
        {
            try
            {
                string _path = @"config.json";
                string jsonFromFile;
                using (var reader = new StreamReader(_path))
                {
                    jsonFromFile = reader.ReadToEnd();
                }
                string result_ClientIDRPC = "";
                dynamic obj_ClientIDRPC = JsonConvert.DeserializeObject(jsonFromFile);
                result_ClientIDRPC = (obj_ClientIDRPC.ClientIDRPC);
                siticoneRoundedTextBox1.Text = $"{result_ClientIDRPC}";
            }
            catch (Exception ex)
            {
                // ignored
            }
        }

        private void SiticoneRoundedTextBox2_enter(object sender, EventArgs e)
        {
            try
            {
                string _path = @"config.json";
                string jsonFromFile;
                using (var reader = new StreamReader(_path))
                {
                    jsonFromFile = reader.ReadToEnd();
                }
                string result_DetailsRPC = "";
                dynamic obj_DetailsRPC = JsonConvert.DeserializeObject(jsonFromFile);
                result_DetailsRPC = (obj_DetailsRPC.DetailsRPC);
                siticoneRoundedTextBox2.Text = $"{result_DetailsRPC}";
            }
            catch (Exception ex)
            {
                // ignored
            }
        }

        private void SiticoneRoundedTextBox3_enter(object sender, EventArgs e)
        {
            try
            {
                string _path = @"config.json";
                string jsonFromFile;
                using (var reader = new StreamReader(_path))
                {
                    jsonFromFile = reader.ReadToEnd();
                }
                string result_StateRPC = "";
                dynamic obj_StateRPC = JsonConvert.DeserializeObject(jsonFromFile);
                result_StateRPC = (obj_StateRPC.StateRPC);
                siticoneRoundedTextBox3.Text = $"{result_StateRPC}";
            }
            catch (Exception ex)
            {
                // ignored
            }
        }

        private void SiticoneRoundedTextBox5_enter(object sender, EventArgs e)
        {
            try
            {
                string _path = @"config.json";
                string jsonFromFile;
                using (var reader = new StreamReader(_path))
                {
                    jsonFromFile = reader.ReadToEnd();
                }
                string result_LargeImageIconRPC = "";
                dynamic obj_LargeImageIconRPC = JsonConvert.DeserializeObject(jsonFromFile);
                result_LargeImageIconRPC = (obj_LargeImageIconRPC.LargeImageIconRPC);
                siticoneRoundedTextBox5.Text = $"{result_LargeImageIconRPC}";
            }
            catch (Exception ex)
            {
                // ignored
            }
        }

        private void SiticoneRoundedTextBox4_enter(object sender, EventArgs e)
        {
            try
            {
                string _path = @"config.json";
                string jsonFromFile;
                using (var reader = new StreamReader(_path))
                {
                    jsonFromFile = reader.ReadToEnd();
                }
                string result_LargeImageTextRPC = "";
                dynamic obj_LargeImageTextRPC = JsonConvert.DeserializeObject(jsonFromFile);
                result_LargeImageTextRPC = (obj_LargeImageTextRPC.LargeImageTextRPC);
                siticoneRoundedTextBox4.Text = $"{result_LargeImageTextRPC}";
            }
            catch (Exception ex)
            {
                // ignored
            }
        }

        private void SiticoneRoundedTextBox6_enter(object sender, EventArgs e)
        {
            try
            {
                string _path = @"config.json";
                string jsonFromFile;
                using (var reader = new StreamReader(_path))
                {
                    jsonFromFile = reader.ReadToEnd();
                }
                string result_SmallImageIconRPC = "";
                dynamic obj_SmallImageIconRPC = JsonConvert.DeserializeObject(jsonFromFile);
                result_SmallImageIconRPC = (obj_SmallImageIconRPC.SmallImageIconRPC);
                siticoneRoundedTextBox7.Text = $"{result_SmallImageIconRPC}";
            }
            catch (Exception ex)
            {
                // ignored
            }
        }

        private void SiticoneRoundedTextBox7_enter(object sender, EventArgs e)
        {
            try
            {
                string _path = @"config.json";
                string jsonFromFile;
                using (var reader = new StreamReader(_path))
                {
                    jsonFromFile = reader.ReadToEnd();
                }
                string result_SmallImageTextRPC = "";
                dynamic obj_SmallImageTextRPC = JsonConvert.DeserializeObject(jsonFromFile);
                result_SmallImageTextRPC = (obj_SmallImageTextRPC.SmallImageTextRPC);
                siticoneRoundedTextBox6.Text = $"{result_SmallImageTextRPC}";
            }
            catch (Exception ex)
            {
                // ignored
            }
        }

        private void SiticoneRoundedTextBox8_enter(object sender, EventArgs e)
        {
            try
            {
                string _path = @"config.json";
                string jsonFromFile;
                using (var reader = new StreamReader(_path))
                {
                    jsonFromFile = reader.ReadToEnd();
                }
                string result_ButtonTitleRPC = "";
                dynamic obj_ButtonTitleRPC = JsonConvert.DeserializeObject(jsonFromFile);
                result_ButtonTitleRPC = (obj_ButtonTitleRPC.ButtonTitleRPC);
                siticoneRoundedTextBox8.Text = $"{result_ButtonTitleRPC}";
            }
            catch (Exception ex)
            {
                // ignored
            }
        }

        private void SiticoneRoundedTextBox9_enter(object sender, EventArgs e)
        {
            try
            {
                string _path = @"config.json";
                string jsonFromFile;
                using (var reader = new StreamReader(_path))
                {
                    jsonFromFile = reader.ReadToEnd();
                }
                string result_ButtonLinkRPC = "";
                dynamic obj_ButtonLinkRPC = JsonConvert.DeserializeObject(jsonFromFile);
                result_ButtonLinkRPC = (obj_ButtonLinkRPC.ButtonLinkRPC);
                siticoneRoundedTextBox9.Text = $"{result_ButtonLinkRPC}";
            }
            catch (Exception ex)
            {
                // ignored
            }
        }

        private void Createjson()
        {
            if (File.Exists(@"config.json"))
            {
                
            }
            else
            {
                string path = @"config.json";

                // The line below will create a text file, my_file.txt, in 
                // the Text_Files folder in D:\ drive.
                // The CreateText method that returns a StreamWriter object
#pragma warning disable CS0642 // Possible mistaken empty statement
                using (StreamWriter sw = File.CreateText(path)) ;
#pragma warning restore CS0642 // Possible mistaken empty statement

                DiscordRPCINFO DiscordRPCinfo = new DiscordRPCINFO()
                {
                    ClientIDRPC = "877701431652655155",
                    DetailsRPC = "RPCdetails",
                    StateRPC = "RPCstate",
                    LargeImageIconRPC = "RPClogo",
                    LargeImageTextRPC = "RPCLargeIcon",
                    SmallImageIconRPC = "RPClogo",
                    SmallImageTextRPC = "RPCSmallIcon",
                    ButtonLinkRPC = "https://RPC.com",
                    ButtonTitleRPC = "RPC",
                };
                // serialize JSON to a string and then write string to a file
                File.WriteAllText(@"config.json", JsonConvert.SerializeObject(DiscordRPCinfo));

                // serialize JSON directly to a file
                using (StreamWriter file = File.CreateText(@"config.json"))
                {
                    JsonSerializer serializer = new JsonSerializer();
                    serializer.Serialize(file, DiscordRPCinfo);
                }
            }
        }

        public DiscordRpcClient client;


        private void Discordrpc()
        {
            client = new DiscordRpcClient($"{siticoneRoundedTextBox1.Text}");


            client.Initialize();


            client.SetPresence(new RichPresence()

            {
                Timestamps = Timestamps.Now,
                Details = $"{siticoneRoundedTextBox2.Text}",
                State = $"{siticoneRoundedTextBox3.Text}",
                Assets = new Assets()
                {
                    LargeImageKey = $"{siticoneRoundedTextBox5.Text}",
                    LargeImageText = $"{siticoneRoundedTextBox4.Text}",
                    SmallImageKey = $"{siticoneRoundedTextBox7.Text}",
                    SmallImageText = $"{siticoneRoundedTextBox6.Text}",
                },
                Buttons = new Button[] {new Button()
                {
                    Label = $"{siticoneRoundedTextBox8.Text}",
                    Url = $"{siticoneRoundedTextBox9.Text}",
                } }
            });
        }

        private void Button3_Click(object sender, EventArgs e)
        {
                if (File.Exists(@"config.json"))
                {
                    File.Delete(@"config.json");
                }
                string path = @"config.json";

                // The line below will create a text file, my_file.txt, in 
                // the Text_Files folder in D:\ drive.
                // The CreateText method that returns a StreamWriter object
#pragma warning disable CS0642 // Possible mistaken empty statement
                using (StreamWriter sw = File.CreateText(path)) ;
#pragma warning restore CS0642 // Possible mistaken empty statement

            DiscordRPCINFO DiscordRPCinfo = new DiscordRPCINFO()
            {
                ClientIDRPC = "877701431652655155",
                DetailsRPC = "RPCdetails",
                StateRPC = "RPCstate",
                LargeImageIconRPC = "RPClogo",
                LargeImageTextRPC = "RPCLargeIcon",
                SmallImageIconRPC = "RPClogo",
                SmallImageTextRPC = "RPCSmallIcon",
                ButtonLinkRPC = "https://RPC.com",
                ButtonTitleRPC = "RPC",
            };
            // serialize JSON to a string and then write string to a file
            File.WriteAllText(@"config.json", JsonConvert.SerializeObject(DiscordRPCinfo));

                // serialize JSON directly to a file
                using (StreamWriter file = File.CreateText(@"config.json"))
                {
                    JsonSerializer serializer = new JsonSerializer();
                    serializer.Serialize(file, DiscordRPCinfo);
                }
        }

        private void siticoneRoundedButton2_Click(object sender, EventArgs e)
        {
            try
            {
                client.Dispose();
            }
            catch (Exception ex)
            {
                // ignored
            }
            siticoneRoundedTextBox1.Visible = true;
            siticoneRoundedTextBox2.Visible = true;
            siticoneRoundedTextBox3.Visible = true;
            siticoneRoundedTextBox4.Visible = true;
            siticoneRoundedTextBox5.Visible = true;
            siticoneRoundedTextBox6.Visible = true;
            siticoneRoundedTextBox7.Visible = true;
            siticoneRoundedTextBox8.Visible = true;
            siticoneRoundedTextBox9.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            label7.Visible = true;
            label8.Visible = true;
            label9.Visible = true;
            siticoneRoundedButton4.Visible = false;
            siticoneRoundedButton5.Visible = false;
            siticoneRoundedButton3.Visible = true;
            siticoneRoundedButton1.Visible = true;
            siticoneRoundedButton2.Visible = false;
        }

        private void siticoneRoundedButton3_Click(object sender, EventArgs e)
        {

            if (File.Exists(@"config.json"))
            {


                string json = File.ReadAllText("config.json");
                dynamic jsonObj = Newtonsoft.Json.JsonConvert.DeserializeObject(json);
                jsonObj["ClientIDRPC"] = $"{siticoneRoundedTextBox1.Text}";
                string output = Newtonsoft.Json.JsonConvert.SerializeObject(jsonObj, Newtonsoft.Json.Formatting.Indented);
                File.WriteAllText("config.json", output);

                string json2 = File.ReadAllText("config.json");
                dynamic jsonObj2 = Newtonsoft.Json.JsonConvert.DeserializeObject(json2);
                jsonObj2["DetailsRPC"] = $"{siticoneRoundedTextBox2.Text}";
                string output2 = Newtonsoft.Json.JsonConvert.SerializeObject(jsonObj2, Newtonsoft.Json.Formatting.Indented);
                File.WriteAllText("config.json", output2);

                string json3 = File.ReadAllText("config.json");
                dynamic jsonObj3 = Newtonsoft.Json.JsonConvert.DeserializeObject(json3);
                jsonObj3["StateRPC"] = $"{siticoneRoundedTextBox3.Text}";
                string output3 = Newtonsoft.Json.JsonConvert.SerializeObject(jsonObj3, Newtonsoft.Json.Formatting.Indented);
                File.WriteAllText("config.json", output3);

                string json4 = File.ReadAllText("config.json");
                dynamic jsonObj4 = Newtonsoft.Json.JsonConvert.DeserializeObject(json4);
                jsonObj4["LargeImageTextRPC"] = $"{siticoneRoundedTextBox4.Text}";
                string output4 = Newtonsoft.Json.JsonConvert.SerializeObject(jsonObj4, Newtonsoft.Json.Formatting.Indented);
                File.WriteAllText("config.json", output4);

                string json5 = File.ReadAllText("config.json");
                dynamic jsonObj5 = Newtonsoft.Json.JsonConvert.DeserializeObject(json5);
                jsonObj5["LargeImageIconRPC"] = $"{siticoneRoundedTextBox5.Text}";
                string output5 = Newtonsoft.Json.JsonConvert.SerializeObject(jsonObj5, Newtonsoft.Json.Formatting.Indented);
                File.WriteAllText("config.json", output5);

                string json6 = File.ReadAllText("config.json");
                dynamic jsonObj6 = Newtonsoft.Json.JsonConvert.DeserializeObject(json6);
                jsonObj6["SmallImageTextRPC"] = $"{siticoneRoundedTextBox6.Text}";
                string output6 = Newtonsoft.Json.JsonConvert.SerializeObject(jsonObj6, Newtonsoft.Json.Formatting.Indented);
                File.WriteAllText("config.json", output6);

                string json7 = File.ReadAllText("config.json");
                dynamic jsonObj7 = Newtonsoft.Json.JsonConvert.DeserializeObject(json7);
                jsonObj7["SmallImageIconRPC"] = $"{siticoneRoundedTextBox7.Text}";
                string output7 = Newtonsoft.Json.JsonConvert.SerializeObject(jsonObj7, Newtonsoft.Json.Formatting.Indented);
                File.WriteAllText("config.json", output7);

                string json8 = File.ReadAllText("config.json");
                dynamic jsonObj8 = Newtonsoft.Json.JsonConvert.DeserializeObject(json8);
                jsonObj8["ButtonTitleRPC"] = $"{siticoneRoundedTextBox8.Text}";
                string output8 = Newtonsoft.Json.JsonConvert.SerializeObject(jsonObj8, Newtonsoft.Json.Formatting.Indented);
                File.WriteAllText("config.json", output8);

                string json9 = File.ReadAllText("config.json");
                dynamic jsonObj9 = Newtonsoft.Json.JsonConvert.DeserializeObject(json9);
                jsonObj9["ButtonLinkRPC"] = $"{siticoneRoundedTextBox9.Text}";
                string output9 = Newtonsoft.Json.JsonConvert.SerializeObject(jsonObj9, Newtonsoft.Json.Formatting.Indented);
                File.WriteAllText("config.json", output9);

                siticoneRoundedTextBox1.Visible = false;
                siticoneRoundedTextBox2.Visible = false;
                siticoneRoundedTextBox3.Visible = false;
                siticoneRoundedTextBox4.Visible = false;
                siticoneRoundedTextBox5.Visible = false;
                siticoneRoundedTextBox6.Visible = false;
                siticoneRoundedTextBox7.Visible = false;
                siticoneRoundedTextBox8.Visible = false;
                siticoneRoundedTextBox9.Visible = false;
                label1.Visible = false;
                label2.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
                label5.Visible = false;
                label6.Visible = false;
                label7.Visible = false;
                label8.Visible = false;
                label9.Visible = false;
                siticoneRoundedButton1.Visible = false;
                siticoneRoundedButton4.Visible = false;
                siticoneRoundedButton3.Visible = false;
                siticoneRoundedButton5.Visible = true;
                siticoneRoundedButton2.Visible = true;

            }

            else
            {
                MessageBox.Show("ERROR: config.json was not found! Please Re-Download AtomSB.");
            }
        }

        private void siticoneRoundedButton1_Click(object sender, EventArgs e)
        {
            if (File.Exists(@"config.json"))
            {
                File.Delete(@"config.json");
            }
            string path = @"config.json";

            // The line below will create a text file, my_file.txt, in 
            // the Text_Files folder in D:\ drive.
            // The CreateText method that returns a StreamWriter object
#pragma warning disable CS0642 // Possible mistaken empty statement
            using (StreamWriter sw = File.CreateText(path)) ;
#pragma warning restore CS0642 // Possible mistaken empty statement

            DiscordRPCINFO DiscordRPCinfo = new DiscordRPCINFO()
            {
                ClientIDRPC = "877701431652655155",
                DetailsRPC = "RPCdetails",
                StateRPC = "RPCstate",
                LargeImageIconRPC = "RPClogo",
                LargeImageTextRPC = "RPCLargeIcon",
                SmallImageIconRPC = "RPClogo",
                SmallImageTextRPC = "RPCSmallIcon",
                ButtonLinkRPC = "https://RPC.com",
                ButtonTitleRPC = "RPC",
            };
            // serialize JSON to a string and then write string to a file
            File.WriteAllText(@"config.json", JsonConvert.SerializeObject(DiscordRPCinfo));

            // serialize JSON directly to a file
            using (StreamWriter file = File.CreateText(@"config.json"))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(file, DiscordRPCinfo);
            }
        }

        private void siticoneRoundedButton4_Click(object sender, EventArgs e)
        {
            client.Dispose();
            siticoneRoundedButton5.Visible = true;
            siticoneRoundedButton1.Text = "Start rpc";
            siticoneRoundedButton4.Visible = false;
        }

        private void siticoneRoundedButton5_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(siticoneRoundedTextBox1.Text))
            {
                siticoneRoundedTextBox1.Text = "877701431652655155";
            }
            if (String.IsNullOrEmpty(siticoneRoundedTextBox2.Text))
            {
                siticoneRoundedTextBox2.Text = "RPCDetails";
            }
            if (String.IsNullOrEmpty(siticoneRoundedTextBox3.Text))
            {
                siticoneRoundedTextBox3.Text = "RPCState";
            }
            if (String.IsNullOrEmpty(siticoneRoundedTextBox4.Text))
            {
                siticoneRoundedTextBox4.Text = "RPCLargeIconText";
            }
            if (String.IsNullOrEmpty(siticoneRoundedTextBox5.Text))
            {
                siticoneRoundedTextBox5.Text = "RPCLargeIcon";
            }
            if (String.IsNullOrEmpty(siticoneRoundedTextBox6.Text))
            {
                siticoneRoundedTextBox6.Text = "RPCSmallIcon";
            }
            if (String.IsNullOrEmpty(siticoneRoundedTextBox7.Text))
            {
                siticoneRoundedTextBox7.Text = "RPCSmallIconText";
            }
            if (String.IsNullOrEmpty(siticoneRoundedTextBox8.Text))
            {
                siticoneRoundedTextBox8.Text = "RPCTitle";
            }
            if (String.IsNullOrEmpty(siticoneRoundedTextBox9.Text))
            {
                siticoneRoundedTextBox9.Text = "ButtonLink";
            }
            Discordrpc();
            siticoneRoundedButton4.Visible = true;
            siticoneRoundedButton5.Visible = false;
        }
    }
}
