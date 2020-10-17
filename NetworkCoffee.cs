using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Net.NetworkInformation;


namespace Network_Coffee
{
    public partial class NetworkCoffee : Form
    {
        public List<TargetEntry> EntryList = new List<TargetEntry>();
        public List<NetInterface> InterfaceList = new List<NetInterface>();
        string Currentcsv;
        bool ChangesSaved;
        public bool Cancel = false;

        public NetworkCoffee()
        {
            InitializeComponent();
        }

        private void NetworkCoffee_Load(object sender, EventArgs e)
        {
            try
            {
                OpenFileDlg.InitialDirectory = (System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase) + "\\targets.csv").Replace("file:\\", "");
                loadCsvFile((System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase) + "\\targets.csv").Replace("file:\\", ""));
            }
            catch
            {
            }
            

            foreach (NetworkInterface ni in NetworkInterface.GetAllNetworkInterfaces())
            {
                if (ni.NetworkInterfaceType == NetworkInterfaceType.Wireless80211 || ni.NetworkInterfaceType == NetworkInterfaceType.Ethernet)
                {
                    foreach (UnicastIPAddressInformation ip in ni.GetIPProperties().UnicastAddresses)
                    {
                        if (ip.Address.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                        {
                            InterfaceList.Add(new NetInterface(ip.Address, ip.IPv4Mask));
                        }
                    }
                }
            }
        }

        private void Button_AddUpdate_Click(object sender, EventArgs e)
        {
            if(ListBox_Targets.SelectedItem.ToString() == "Add New")
            {
                string TargetNickname = TextBox_Nickname.Text;
                string TargetMAC = TextBox_MAC1.Text + TextBox_MAC2.Text + TextBox_MAC3.Text + TextBox_MAC4.Text + TextBox_MAC5.Text + TextBox_MAC6.Text;
                EntryList.Add(new TargetEntry(TargetMAC, TargetNickname));
                TargetMAC = TargetMAC.Insert(10, ":");
                TargetMAC = TargetMAC.Insert(8, ":");
                TargetMAC = TargetMAC.Insert(6, ":");
                TargetMAC = TargetMAC.Insert(4, ":");
                TargetMAC = TargetMAC.Insert(2, ":");
                ListBox_Targets.Items.Add(TargetMAC + "\t\t" + TargetNickname);
                ListBox_Targets.SelectedItem = (TargetMAC + "\t\t" + TargetNickname);
                ListBox_Targets.Items.Remove("Add New");
                ListBox_Targets.Items.Add("Add New");
            }
            else
            {
                string TargetNickname = TextBox_Nickname.Text;
                string TargetMAC = TextBox_MAC1.Text + TextBox_MAC2.Text + TextBox_MAC3.Text + TextBox_MAC4.Text + TextBox_MAC5.Text + TextBox_MAC6.Text;
                
                EntryList.RemoveAt(ListBox_Targets.SelectedIndex);
                ListBox_Targets.Items.RemoveAt(ListBox_Targets.SelectedIndex);


                EntryList.Add(new TargetEntry(TargetMAC, TargetNickname));

                TargetMAC = TargetMAC.Insert(10, ":");
                TargetMAC = TargetMAC.Insert(8, ":");
                TargetMAC = TargetMAC.Insert(6, ":");
                TargetMAC = TargetMAC.Insert(4, ":");
                TargetMAC = TargetMAC.Insert(2, ":");
                ListBox_Targets.Items.Add(TargetMAC + "\t\t" + TargetNickname);
                ListBox_Targets.SelectedItem = (TargetMAC + "\t\t" + TargetNickname);
                ListBox_Targets.Items.Remove("Add New");
                ListBox_Targets.Items.Add("Add New");
            }
            Button_AddUpdate.Enabled = false;

            ChangesSaved = false;
        }

        private void Button_Delete_Click(object sender, EventArgs e)
        {
            string TargetNickname = TextBox_Nickname.Text;
            string TargetMAC = TextBox_MAC1.Text + TextBox_MAC2.Text + TextBox_MAC3.Text + TextBox_MAC4.Text + TextBox_MAC5.Text + TextBox_MAC6.Text;
            TargetMAC = TargetMAC.Insert(10, ":");
            TargetMAC = TargetMAC.Insert(8, ":");
            TargetMAC = TargetMAC.Insert(6, ":");
            TargetMAC = TargetMAC.Insert(4, ":");
            TargetMAC = TargetMAC.Insert(2, ":");
            EntryList.RemoveAt(ListBox_Targets.SelectedIndex);
            ListBox_Targets.SelectedItem = ("Add New");
            ListBox_Targets.Items.Remove(TargetMAC + "\t\t" + TargetNickname);
            
        }

        private void Button_WakeUp_Click(object sender, EventArgs e)
        {
            string MAC = TextBox_MAC1.Text + "-" + TextBox_MAC2.Text + "-" + TextBox_MAC3.Text + "-" + TextBox_MAC4.Text + "-" + TextBox_MAC5.Text + "-" + TextBox_MAC6.Text;

            foreach (NetInterface Interface in InterfaceList)
            {
                if (Interface.Enabled)
                {
                    SendPowerOn(MAC, Interface.BroadcastAddress);
                }
            }
        }

        #region Text Update
        private void TextBox_MAC1_TextChanged(object sender, EventArgs e)
        {
            ParseMACText(TextBox_MAC1);
        }

        private void TextBox_MAC2_TextChanged(object sender, EventArgs e)
        {
            ParseMACText(TextBox_MAC2);
        }

        private void TextBox_MAC3_TextChanged(object sender, EventArgs e)
        {
            ParseMACText(TextBox_MAC3);
        }

        private void TextBox_MAC4_TextChanged(object sender, EventArgs e)
        {
            ParseMACText(TextBox_MAC4);
        }

        private void TextBox_MAC5_TextChanged(object sender, EventArgs e)
        {
            ParseMACText(TextBox_MAC5);
        }

        private void TextBox_MAC6_TextChanged(object sender, EventArgs e)
        {
            ParseMACText(TextBox_MAC6);
        }

        // Only Allow Hex Entries In MAC Address Text Boxes
        private void ParseMACText(TextBox InputBox)
        {
            string entry = InputBox.Text;
            int n = 0;
            if (!int.TryParse(entry, System.Globalization.NumberStyles.HexNumber, System.Globalization.NumberFormatInfo.CurrentInfo, out n) && (entry != string.Empty))
            {
                InputBox.Text = entry.Remove(entry.Length - 1, 1);
                InputBox.SelectionStart = InputBox.Text.Length;
            }

            if (ListBox_Targets.SelectedItem.ToString() != "Add New")
            {
                if ((TextBox_MAC1.Text != EntryList[ListBox_Targets.SelectedIndex].MAC.Substring(0, 2)) || (TextBox_MAC2.Text != EntryList[ListBox_Targets.SelectedIndex].MAC.Substring(2, 2)) || (TextBox_MAC3.Text != EntryList[ListBox_Targets.SelectedIndex].MAC.Substring(4, 2)) || (TextBox_MAC4.Text != EntryList[ListBox_Targets.SelectedIndex].MAC.Substring(6, 2)) || (TextBox_MAC5.Text != EntryList[ListBox_Targets.SelectedIndex].MAC.Substring(8, 2)) || (TextBox_MAC6.Text != EntryList[ListBox_Targets.SelectedIndex].MAC.Substring(10, 2)))
                {
                    Button_AddUpdate.Enabled = true;
                }
                else
                {
                    Button_AddUpdate.Enabled = false;
                }
            }
            else
            {
                if((TextBox_MAC1.Text.Length == 2) && (TextBox_MAC2.Text.Length == 2) && (TextBox_MAC3.Text.Length == 2) && (TextBox_MAC4.Text.Length == 2) && (TextBox_MAC5.Text.Length == 2) && (TextBox_MAC6.Text.Length == 2))
                {
                    Button_AddUpdate.Enabled = true;
                }
                else
                {
                    Button_AddUpdate.Enabled = false;
                }
            }
            if (ListBox_Targets.SelectedItem.ToString() == "Add New")
            {
                if (InputBox.Text.Length == 2)
                {
                    SendKeys.Send("{TAB}");
                }
            }
        }
        #endregion Text Update

        private void loadCsvFile(string filePath)
        {
            EntryList.Clear();
            ListBox_Targets.Items.Clear();
            var reader = new StreamReader(File.OpenRead(filePath));
            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();
                string[] linevals = line.Split(',');
                TargetEntry Target = new TargetEntry(linevals[1], linevals[0]);
                EntryList.Add(Target);
            }
            foreach (TargetEntry Target in EntryList)
            {
                string TargetMAC = Target.MAC.Insert(10, ":");
                TargetMAC = TargetMAC.Insert(8, ":");
                TargetMAC = TargetMAC.Insert(6, ":");
                TargetMAC = TargetMAC.Insert(4, ":");
                TargetMAC = TargetMAC.Insert(2, ":");
                ListBox_Targets.Items.Add(TargetMAC + "\t\t" + Target.Nickname);
            }
            ListBox_Targets.Items.Add("Add New");
            Currentcsv = filePath;
        }

        private void ListBox_Targets_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(ListBox_Targets.SelectedItem == "Add New")
            {
                Button_AddUpdate.Text = "Add";
                TextBox_Nickname.Text = string.Empty;
                TextBox_MAC1.Text = string.Empty;
                TextBox_MAC2.Text = string.Empty;
                TextBox_MAC3.Text = string.Empty;
                TextBox_MAC4.Text = string.Empty;
                TextBox_MAC5.Text = string.Empty;
                TextBox_MAC6.Text = string.Empty;
                Button_Delete.Enabled = false;
                Button_AddUpdate.Enabled = false;
            }
            else
            {
                try
                {
                    Button_AddUpdate.Text = "Update";
                    TextBox_Nickname.Text = EntryList[ListBox_Targets.SelectedIndex].Nickname;
                    TextBox_MAC1.Text = EntryList[ListBox_Targets.SelectedIndex].MAC.Substring(0, 2);
                    TextBox_MAC2.Text = EntryList[ListBox_Targets.SelectedIndex].MAC.Substring(2, 2);
                    TextBox_MAC3.Text = EntryList[ListBox_Targets.SelectedIndex].MAC.Substring(4, 2);
                    TextBox_MAC4.Text = EntryList[ListBox_Targets.SelectedIndex].MAC.Substring(6, 2);
                    TextBox_MAC5.Text = EntryList[ListBox_Targets.SelectedIndex].MAC.Substring(8, 2);
                    TextBox_MAC6.Text = EntryList[ListBox_Targets.SelectedIndex].MAC.Substring(10, 2);
                    Button_Delete.Enabled = true;
                    Button_AddUpdate.Enabled = false;
                }
                catch
                {
                }
            }
        }

        void SendPowerOn(string MAC, IPAddress Broadcast)
        {
            IPEndPoint endip = new IPEndPoint(Broadcast, 9);
            string streamstr = "FF-FF-FF-FF-FF-FF";
            byte[] magicpacket = streamstr.Split('-').Select(x => Convert.ToByte(x, 16)).ToArray();
            byte[] macpacket = MAC.Split('-').Select(x => Convert.ToByte(x, 16)).ToArray();
            for (int a = 0; a < 16; a++)
            {
                magicpacket = magicpacket.Concat(macpacket).ToArray();
            }
            UdpClient udpclient = new UdpClient();
            udpclient.Connect(endip);
            udpclient.Send(magicpacket, magicpacket.Length);
            udpclient.Close();
        }

        private void MenuItem_File_Open_Click(object sender, EventArgs e)
        {
            string csvpath;
            DialogResult FileSelectResult = OpenFileDlg.ShowDialog();
            if (FileSelectResult == DialogResult.OK)
            {
                csvpath = OpenFileDlg.FileName;
                loadCsvFile(csvpath);
            }
        }

        private void MenuItem_File_Save_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void MenuItem_File_SaveAs_Click(object sender, EventArgs e)
        {
            SaveAs();
        }

        void Exportcsv(string Path)
        {
            string csvexport =string.Empty;
            foreach (TargetEntry Entry in EntryList)
            {
                csvexport = csvexport + Entry.Nickname + "," + Entry.MAC + "\n";
            }
            System.IO.File.WriteAllText(@Path, csvexport);
            ChangesSaved = true;
        }

        private void MenuItem_File_Exit_Click(object sender, EventArgs e)
        {
            if (!ChangesSaved)
            {
                SaveChanges SaveChanges = new SaveChanges();
                SaveChanges.ShowDialog();

                if (!SaveChanges.cancelstat)
                {
                    Application.Exit();
                }
            }
            else
            {
                Application.Exit();
            }
            
        }

        private void aboutNetworkCoffeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InfoPopup InfoPopup = new InfoPopup();
            InfoPopup.ShowDialog();
        }

        public void SaveAs()
        {
            DialogResult FileSelectResult = SaveFileDlg.ShowDialog();
            if (FileSelectResult == DialogResult.OK)
            {
                string csvpath = SaveFileDlg.FileName;
                Currentcsv = csvpath;
                Exportcsv(csvpath);
            }
        }

        public void Save()
        {
            File.Delete(Currentcsv);
            Exportcsv(Currentcsv);
        }

        private void networkCoffeeRepoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Version.GitHubLink);
        }
    }
}
