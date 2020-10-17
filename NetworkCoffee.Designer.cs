namespace Network_Coffee
{
    partial class NetworkCoffee
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
            this.MenuBar_Menu = new System.Windows.Forms.MenuStrip();
            this.MenuItem_File = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_File_Open = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_File_Save = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_File_SaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuItem_File_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_Preferences = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_Preferences_Security = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_Preferences_Network = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.networkCoffeeRepoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutNetworkCoffeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ListBox_Targets = new System.Windows.Forms.ListBox();
            this.Label_SavedTargets = new System.Windows.Forms.Label();
            this.StatusStrip_StatusStrip = new System.Windows.Forms.StatusStrip();
            this.TextBox_Nickname = new System.Windows.Forms.TextBox();
            this.Label_Nickname = new System.Windows.Forms.Label();
            this.Label_MAC = new System.Windows.Forms.Label();
            this.TextBox_MAC1 = new System.Windows.Forms.TextBox();
            this.Label_MACColon1 = new System.Windows.Forms.Label();
            this.TextBox_MAC2 = new System.Windows.Forms.TextBox();
            this.TextBox_MAC3 = new System.Windows.Forms.TextBox();
            this.TextBox_MAC4 = new System.Windows.Forms.TextBox();
            this.Label_MACColon3 = new System.Windows.Forms.Label();
            this.Label_MACColon2 = new System.Windows.Forms.Label();
            this.TextBox_MAC5 = new System.Windows.Forms.TextBox();
            this.Label_MACColon4 = new System.Windows.Forms.Label();
            this.TextBox_MAC6 = new System.Windows.Forms.TextBox();
            this.Label_MACColon5 = new System.Windows.Forms.Label();
            this.Button_AddUpdate = new System.Windows.Forms.Button();
            this.Button_Delete = new System.Windows.Forms.Button();
            this.Button_WakeUp = new System.Windows.Forms.Button();
            this.Group_EntryControl = new System.Windows.Forms.GroupBox();
            this.Label_SavedMAC = new System.Windows.Forms.Label();
            this.Label_SavedNickname = new System.Windows.Forms.Label();
            this.OpenFileDlg = new System.Windows.Forms.OpenFileDialog();
            this.SaveFileDlg = new System.Windows.Forms.SaveFileDialog();
            this.MenuBar_Menu.SuspendLayout();
            this.Group_EntryControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuBar_Menu
            // 
            this.MenuBar_Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItem_File,
            this.MenuItem_Preferences,
            this.helpToolStripMenuItem});
            this.MenuBar_Menu.Location = new System.Drawing.Point(0, 0);
            this.MenuBar_Menu.Name = "MenuBar_Menu";
            this.MenuBar_Menu.Size = new System.Drawing.Size(296, 24);
            this.MenuBar_Menu.TabIndex = 0;
            this.MenuBar_Menu.Text = "menuStrip1";
            // 
            // MenuItem_File
            // 
            this.MenuItem_File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItem_File_Open,
            this.MenuItem_File_Save,
            this.MenuItem_File_SaveAs,
            this.toolStripSeparator1,
            this.MenuItem_File_Exit});
            this.MenuItem_File.Name = "MenuItem_File";
            this.MenuItem_File.Size = new System.Drawing.Size(37, 20);
            this.MenuItem_File.Text = "File";
            // 
            // MenuItem_File_Open
            // 
            this.MenuItem_File_Open.Name = "MenuItem_File_Open";
            this.MenuItem_File_Open.Size = new System.Drawing.Size(180, 22);
            this.MenuItem_File_Open.Text = "Open";
            this.MenuItem_File_Open.Click += new System.EventHandler(this.MenuItem_File_Open_Click);
            // 
            // MenuItem_File_Save
            // 
            this.MenuItem_File_Save.Name = "MenuItem_File_Save";
            this.MenuItem_File_Save.Size = new System.Drawing.Size(180, 22);
            this.MenuItem_File_Save.Text = "Save";
            this.MenuItem_File_Save.Click += new System.EventHandler(this.MenuItem_File_Save_Click);
            // 
            // MenuItem_File_SaveAs
            // 
            this.MenuItem_File_SaveAs.Name = "MenuItem_File_SaveAs";
            this.MenuItem_File_SaveAs.Size = new System.Drawing.Size(180, 22);
            this.MenuItem_File_SaveAs.Text = "Save As";
            this.MenuItem_File_SaveAs.Click += new System.EventHandler(this.MenuItem_File_SaveAs_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // MenuItem_File_Exit
            // 
            this.MenuItem_File_Exit.Name = "MenuItem_File_Exit";
            this.MenuItem_File_Exit.Size = new System.Drawing.Size(180, 22);
            this.MenuItem_File_Exit.Text = "Exit";
            this.MenuItem_File_Exit.Click += new System.EventHandler(this.MenuItem_File_Exit_Click);
            // 
            // MenuItem_Preferences
            // 
            this.MenuItem_Preferences.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItem_Preferences_Security,
            this.MenuItem_Preferences_Network});
            this.MenuItem_Preferences.Name = "MenuItem_Preferences";
            this.MenuItem_Preferences.Size = new System.Drawing.Size(80, 20);
            this.MenuItem_Preferences.Text = "Preferences";
            // 
            // MenuItem_Preferences_Security
            // 
            this.MenuItem_Preferences_Security.Name = "MenuItem_Preferences_Security";
            this.MenuItem_Preferences_Security.Size = new System.Drawing.Size(119, 22);
            this.MenuItem_Preferences_Security.Text = "Security";
            // 
            // MenuItem_Preferences_Network
            // 
            this.MenuItem_Preferences_Network.Name = "MenuItem_Preferences_Network";
            this.MenuItem_Preferences_Network.Size = new System.Drawing.Size(119, 22);
            this.MenuItem_Preferences_Network.Text = "Network";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.networkCoffeeRepoToolStripMenuItem,
            this.aboutNetworkCoffeeToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // networkCoffeeRepoToolStripMenuItem
            // 
            this.networkCoffeeRepoToolStripMenuItem.Name = "networkCoffeeRepoToolStripMenuItem";
            this.networkCoffeeRepoToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.networkCoffeeRepoToolStripMenuItem.Text = "Network Coffee Repo";
            this.networkCoffeeRepoToolStripMenuItem.Click += new System.EventHandler(this.networkCoffeeRepoToolStripMenuItem_Click);
            // 
            // aboutNetworkCoffeeToolStripMenuItem
            // 
            this.aboutNetworkCoffeeToolStripMenuItem.Name = "aboutNetworkCoffeeToolStripMenuItem";
            this.aboutNetworkCoffeeToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.aboutNetworkCoffeeToolStripMenuItem.Text = "About Network Coffee";
            this.aboutNetworkCoffeeToolStripMenuItem.Click += new System.EventHandler(this.aboutNetworkCoffeeToolStripMenuItem_Click);
            // 
            // ListBox_Targets
            // 
            this.ListBox_Targets.FormattingEnabled = true;
            this.ListBox_Targets.Location = new System.Drawing.Point(12, 65);
            this.ListBox_Targets.Name = "ListBox_Targets";
            this.ListBox_Targets.ScrollAlwaysVisible = true;
            this.ListBox_Targets.Size = new System.Drawing.Size(274, 121);
            this.ListBox_Targets.TabIndex = 1;
            this.ListBox_Targets.SelectedIndexChanged += new System.EventHandler(this.ListBox_Targets_SelectedIndexChanged);
            // 
            // Label_SavedTargets
            // 
            this.Label_SavedTargets.Dock = System.Windows.Forms.DockStyle.Top;
            this.Label_SavedTargets.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_SavedTargets.Location = new System.Drawing.Point(0, 24);
            this.Label_SavedTargets.Name = "Label_SavedTargets";
            this.Label_SavedTargets.Size = new System.Drawing.Size(296, 25);
            this.Label_SavedTargets.TabIndex = 2;
            this.Label_SavedTargets.Text = "Saved Targets";
            this.Label_SavedTargets.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // StatusStrip_StatusStrip
            // 
            this.StatusStrip_StatusStrip.Location = new System.Drawing.Point(0, 332);
            this.StatusStrip_StatusStrip.Name = "StatusStrip_StatusStrip";
            this.StatusStrip_StatusStrip.Size = new System.Drawing.Size(296, 22);
            this.StatusStrip_StatusStrip.TabIndex = 4;
            this.StatusStrip_StatusStrip.Text = "statusStrip1";
            // 
            // TextBox_Nickname
            // 
            this.TextBox_Nickname.Location = new System.Drawing.Point(84, 13);
            this.TextBox_Nickname.Name = "TextBox_Nickname";
            this.TextBox_Nickname.Size = new System.Drawing.Size(180, 20);
            this.TextBox_Nickname.TabIndex = 2;
            // 
            // Label_Nickname
            // 
            this.Label_Nickname.AutoSize = true;
            this.Label_Nickname.Location = new System.Drawing.Point(6, 16);
            this.Label_Nickname.Name = "Label_Nickname";
            this.Label_Nickname.Size = new System.Drawing.Size(58, 13);
            this.Label_Nickname.TabIndex = 5;
            this.Label_Nickname.Text = "Nickname:";
            // 
            // Label_MAC
            // 
            this.Label_MAC.AutoSize = true;
            this.Label_MAC.Location = new System.Drawing.Point(6, 43);
            this.Label_MAC.Name = "Label_MAC";
            this.Label_MAC.Size = new System.Drawing.Size(74, 13);
            this.Label_MAC.TabIndex = 5;
            this.Label_MAC.Text = "MAC Address:";
            // 
            // TextBox_MAC1
            // 
            this.TextBox_MAC1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TextBox_MAC1.Location = new System.Drawing.Point(84, 40);
            this.TextBox_MAC1.Margin = new System.Windows.Forms.Padding(1, 3, 1, 3);
            this.TextBox_MAC1.MaxLength = 2;
            this.TextBox_MAC1.Name = "TextBox_MAC1";
            this.TextBox_MAC1.Size = new System.Drawing.Size(20, 20);
            this.TextBox_MAC1.TabIndex = 3;
            this.TextBox_MAC1.TextChanged += new System.EventHandler(this.TextBox_MAC1_TextChanged);
            // 
            // Label_MACColon1
            // 
            this.Label_MACColon1.AutoSize = true;
            this.Label_MACColon1.Location = new System.Drawing.Point(105, 43);
            this.Label_MACColon1.Margin = new System.Windows.Forms.Padding(0);
            this.Label_MACColon1.Name = "Label_MACColon1";
            this.Label_MACColon1.Size = new System.Drawing.Size(10, 13);
            this.Label_MACColon1.TabIndex = 5;
            this.Label_MACColon1.Text = ":";
            // 
            // TextBox_MAC2
            // 
            this.TextBox_MAC2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TextBox_MAC2.Location = new System.Drawing.Point(116, 40);
            this.TextBox_MAC2.Margin = new System.Windows.Forms.Padding(1, 3, 1, 3);
            this.TextBox_MAC2.MaxLength = 2;
            this.TextBox_MAC2.Name = "TextBox_MAC2";
            this.TextBox_MAC2.Size = new System.Drawing.Size(20, 20);
            this.TextBox_MAC2.TabIndex = 4;
            this.TextBox_MAC2.TextChanged += new System.EventHandler(this.TextBox_MAC2_TextChanged);
            // 
            // TextBox_MAC3
            // 
            this.TextBox_MAC3.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TextBox_MAC3.Location = new System.Drawing.Point(148, 40);
            this.TextBox_MAC3.Margin = new System.Windows.Forms.Padding(1, 3, 1, 3);
            this.TextBox_MAC3.MaxLength = 2;
            this.TextBox_MAC3.Name = "TextBox_MAC3";
            this.TextBox_MAC3.Size = new System.Drawing.Size(20, 20);
            this.TextBox_MAC3.TabIndex = 5;
            this.TextBox_MAC3.TextChanged += new System.EventHandler(this.TextBox_MAC3_TextChanged);
            // 
            // TextBox_MAC4
            // 
            this.TextBox_MAC4.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TextBox_MAC4.Location = new System.Drawing.Point(180, 40);
            this.TextBox_MAC4.Margin = new System.Windows.Forms.Padding(1, 3, 1, 3);
            this.TextBox_MAC4.MaxLength = 2;
            this.TextBox_MAC4.Name = "TextBox_MAC4";
            this.TextBox_MAC4.Size = new System.Drawing.Size(20, 20);
            this.TextBox_MAC4.TabIndex = 6;
            this.TextBox_MAC4.TextChanged += new System.EventHandler(this.TextBox_MAC4_TextChanged);
            // 
            // Label_MACColon3
            // 
            this.Label_MACColon3.AutoSize = true;
            this.Label_MACColon3.Location = new System.Drawing.Point(169, 43);
            this.Label_MACColon3.Margin = new System.Windows.Forms.Padding(0);
            this.Label_MACColon3.Name = "Label_MACColon3";
            this.Label_MACColon3.Size = new System.Drawing.Size(10, 13);
            this.Label_MACColon3.TabIndex = 5;
            this.Label_MACColon3.Text = ":";
            // 
            // Label_MACColon2
            // 
            this.Label_MACColon2.AutoSize = true;
            this.Label_MACColon2.Location = new System.Drawing.Point(137, 43);
            this.Label_MACColon2.Margin = new System.Windows.Forms.Padding(0);
            this.Label_MACColon2.Name = "Label_MACColon2";
            this.Label_MACColon2.Size = new System.Drawing.Size(10, 13);
            this.Label_MACColon2.TabIndex = 5;
            this.Label_MACColon2.Text = ":";
            // 
            // TextBox_MAC5
            // 
            this.TextBox_MAC5.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TextBox_MAC5.Location = new System.Drawing.Point(212, 40);
            this.TextBox_MAC5.Margin = new System.Windows.Forms.Padding(1, 3, 1, 3);
            this.TextBox_MAC5.MaxLength = 2;
            this.TextBox_MAC5.Name = "TextBox_MAC5";
            this.TextBox_MAC5.Size = new System.Drawing.Size(20, 20);
            this.TextBox_MAC5.TabIndex = 7;
            this.TextBox_MAC5.TextChanged += new System.EventHandler(this.TextBox_MAC5_TextChanged);
            // 
            // Label_MACColon4
            // 
            this.Label_MACColon4.AutoSize = true;
            this.Label_MACColon4.Location = new System.Drawing.Point(201, 43);
            this.Label_MACColon4.Margin = new System.Windows.Forms.Padding(0);
            this.Label_MACColon4.Name = "Label_MACColon4";
            this.Label_MACColon4.Size = new System.Drawing.Size(10, 13);
            this.Label_MACColon4.TabIndex = 5;
            this.Label_MACColon4.Text = ":";
            // 
            // TextBox_MAC6
            // 
            this.TextBox_MAC6.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TextBox_MAC6.Location = new System.Drawing.Point(244, 40);
            this.TextBox_MAC6.Margin = new System.Windows.Forms.Padding(1, 3, 1, 3);
            this.TextBox_MAC6.MaxLength = 2;
            this.TextBox_MAC6.Name = "TextBox_MAC6";
            this.TextBox_MAC6.Size = new System.Drawing.Size(20, 20);
            this.TextBox_MAC6.TabIndex = 8;
            this.TextBox_MAC6.TextChanged += new System.EventHandler(this.TextBox_MAC6_TextChanged);
            // 
            // Label_MACColon5
            // 
            this.Label_MACColon5.AutoSize = true;
            this.Label_MACColon5.Location = new System.Drawing.Point(233, 43);
            this.Label_MACColon5.Margin = new System.Windows.Forms.Padding(0);
            this.Label_MACColon5.Name = "Label_MACColon5";
            this.Label_MACColon5.Size = new System.Drawing.Size(10, 13);
            this.Label_MACColon5.TabIndex = 5;
            this.Label_MACColon5.Text = ":";
            // 
            // Button_AddUpdate
            // 
            this.Button_AddUpdate.Location = new System.Drawing.Point(9, 71);
            this.Button_AddUpdate.Name = "Button_AddUpdate";
            this.Button_AddUpdate.Size = new System.Drawing.Size(125, 25);
            this.Button_AddUpdate.TabIndex = 9;
            this.Button_AddUpdate.Text = "Add";
            this.Button_AddUpdate.UseVisualStyleBackColor = true;
            this.Button_AddUpdate.Click += new System.EventHandler(this.Button_AddUpdate_Click);
            // 
            // Button_Delete
            // 
            this.Button_Delete.Location = new System.Drawing.Point(140, 71);
            this.Button_Delete.Name = "Button_Delete";
            this.Button_Delete.Size = new System.Drawing.Size(125, 25);
            this.Button_Delete.TabIndex = 10;
            this.Button_Delete.Text = "Delete";
            this.Button_Delete.UseVisualStyleBackColor = true;
            this.Button_Delete.Click += new System.EventHandler(this.Button_Delete_Click);
            // 
            // Button_WakeUp
            // 
            this.Button_WakeUp.Location = new System.Drawing.Point(9, 99);
            this.Button_WakeUp.Name = "Button_WakeUp";
            this.Button_WakeUp.Size = new System.Drawing.Size(255, 25);
            this.Button_WakeUp.TabIndex = 11;
            this.Button_WakeUp.Text = "Send Wake-On-LAN Packet";
            this.Button_WakeUp.UseVisualStyleBackColor = true;
            this.Button_WakeUp.Click += new System.EventHandler(this.Button_WakeUp_Click);
            // 
            // Group_EntryControl
            // 
            this.Group_EntryControl.Controls.Add(this.Button_WakeUp);
            this.Group_EntryControl.Controls.Add(this.Label_Nickname);
            this.Group_EntryControl.Controls.Add(this.Button_Delete);
            this.Group_EntryControl.Controls.Add(this.TextBox_Nickname);
            this.Group_EntryControl.Controls.Add(this.Button_AddUpdate);
            this.Group_EntryControl.Controls.Add(this.TextBox_MAC1);
            this.Group_EntryControl.Controls.Add(this.Label_MACColon5);
            this.Group_EntryControl.Controls.Add(this.TextBox_MAC3);
            this.Group_EntryControl.Controls.Add(this.Label_MACColon4);
            this.Group_EntryControl.Controls.Add(this.TextBox_MAC2);
            this.Group_EntryControl.Controls.Add(this.Label_MACColon3);
            this.Group_EntryControl.Controls.Add(this.TextBox_MAC4);
            this.Group_EntryControl.Controls.Add(this.Label_MACColon2);
            this.Group_EntryControl.Controls.Add(this.TextBox_MAC5);
            this.Group_EntryControl.Controls.Add(this.Label_MACColon1);
            this.Group_EntryControl.Controls.Add(this.TextBox_MAC6);
            this.Group_EntryControl.Controls.Add(this.Label_MAC);
            this.Group_EntryControl.Location = new System.Drawing.Point(12, 192);
            this.Group_EntryControl.Name = "Group_EntryControl";
            this.Group_EntryControl.Size = new System.Drawing.Size(274, 130);
            this.Group_EntryControl.TabIndex = 7;
            this.Group_EntryControl.TabStop = false;
            this.Group_EntryControl.Text = "Target Options";
            // 
            // Label_SavedMAC
            // 
            this.Label_SavedMAC.AutoSize = true;
            this.Label_SavedMAC.Location = new System.Drawing.Point(12, 49);
            this.Label_SavedMAC.Name = "Label_SavedMAC";
            this.Label_SavedMAC.Size = new System.Drawing.Size(71, 13);
            this.Label_SavedMAC.TabIndex = 8;
            this.Label_SavedMAC.Text = "MAC Address";
            // 
            // Label_SavedNickname
            // 
            this.Label_SavedNickname.AutoSize = true;
            this.Label_SavedNickname.Location = new System.Drawing.Point(155, 49);
            this.Label_SavedNickname.Name = "Label_SavedNickname";
            this.Label_SavedNickname.Size = new System.Drawing.Size(55, 13);
            this.Label_SavedNickname.TabIndex = 8;
            this.Label_SavedNickname.Text = "Nickname";
            // 
            // OpenFileDlg
            // 
            this.OpenFileDlg.FileName = "openFileDialog1";
            this.OpenFileDlg.Filter = "Comma Seperated Values (.cvs)|*.csv";
            // 
            // SaveFileDlg
            // 
            this.SaveFileDlg.Filter = "Comma Seperated Values (.cvs)|*.csv";
            // 
            // NetworkCoffee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 354);
            this.Controls.Add(this.Label_SavedNickname);
            this.Controls.Add(this.Label_SavedMAC);
            this.Controls.Add(this.StatusStrip_StatusStrip);
            this.Controls.Add(this.Label_SavedTargets);
            this.Controls.Add(this.ListBox_Targets);
            this.Controls.Add(this.MenuBar_Menu);
            this.Controls.Add(this.Group_EntryControl);
            this.MainMenuStrip = this.MenuBar_Menu;
            this.MaximizeBox = false;
            this.Name = "NetworkCoffee";
            this.Text = "Network Coffee";
            this.Load += new System.EventHandler(this.NetworkCoffee_Load);
            this.MenuBar_Menu.ResumeLayout(false);
            this.MenuBar_Menu.PerformLayout();
            this.Group_EntryControl.ResumeLayout(false);
            this.Group_EntryControl.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuBar_Menu;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_File;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_File_Open;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_File_Save;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_File_SaveAs;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_File_Exit;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_Preferences;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_Preferences_Security;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_Preferences_Network;
        private System.Windows.Forms.ListBox ListBox_Targets;
        private System.Windows.Forms.Label Label_SavedTargets;
        private System.Windows.Forms.StatusStrip StatusStrip_StatusStrip;
        private System.Windows.Forms.TextBox TextBox_Nickname;
        private System.Windows.Forms.Label Label_Nickname;
        private System.Windows.Forms.Label Label_MAC;
        private System.Windows.Forms.TextBox TextBox_MAC1;
        private System.Windows.Forms.Label Label_MACColon1;
        private System.Windows.Forms.TextBox TextBox_MAC2;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem networkCoffeeRepoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutNetworkCoffeeToolStripMenuItem;
        private System.Windows.Forms.TextBox TextBox_MAC3;
        private System.Windows.Forms.TextBox TextBox_MAC4;
        private System.Windows.Forms.Label Label_MACColon3;
        private System.Windows.Forms.Label Label_MACColon2;
        private System.Windows.Forms.TextBox TextBox_MAC5;
        private System.Windows.Forms.Label Label_MACColon4;
        private System.Windows.Forms.TextBox TextBox_MAC6;
        private System.Windows.Forms.Label Label_MACColon5;
        private System.Windows.Forms.Button Button_AddUpdate;
        private System.Windows.Forms.Button Button_Delete;
        private System.Windows.Forms.Button Button_WakeUp;
        private System.Windows.Forms.GroupBox Group_EntryControl;
        private System.Windows.Forms.Label Label_SavedMAC;
        private System.Windows.Forms.Label Label_SavedNickname;
        private System.Windows.Forms.OpenFileDialog OpenFileDlg;
        private System.Windows.Forms.SaveFileDialog SaveFileDlg;
    }
}

