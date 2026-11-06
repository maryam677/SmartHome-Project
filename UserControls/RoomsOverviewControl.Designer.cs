namespace WinFormsApp2;

partial class RoomsOverviewControl
{
    private System.ComponentModel.IContainer components = null;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
            components.Dispose();
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    private void InitializeComponent()
    {
        tableLayoutMain = new TableLayoutPanel();
        panelHeader = new Panel();
        lblRoomsOverview = new Label();
        lblSubtitle = new Label();
        flowStats = new FlowLayoutPanel();
        statRooms = new Panel();
        statRooms_val = new Label();
        statRooms_cap = new Label();
        statRooms_badge = new Label();
        statTemp = new Panel();
        statTemp_val = new Label();
        statTemp_cap = new Label();
        statLights = new Panel();
        statLights_val = new Label();
        statLights_cap = new Label();
        statDevices = new Panel();
        statDevices_val = new Label();
        statDevices_cap = new Label();
        flowRoomCards = new FlowLayoutPanel();
        card1 = new Panel();
        card1_status = new Label();
        card1_star = new Button();
        card1_pic = new PictureBox();
        card1_name = new Label();
        card1_desc = new Label();
        card1_temp = new Label();
        card1_counts = new Label();
        card1_btn0 = new Button();
        card1_btn1 = new Button();
        card1_btn2 = new Button();
        card1_btn3 = new Button();
        card2 = new Panel();
        card2_status = new Label();
        card2_star = new Button();
        card2_pic = new PictureBox();
        card2_name = new Label();
        card2_desc = new Label();
        card2_temp = new Label();
        card2_counts = new Label();
        card2_btn0 = new Button();
        card2_btn1 = new Button();
        card2_btn2 = new Button();
        card2_btn3 = new Button();
        card3 = new Panel();
        card3_status = new Label();
        card3_star = new Button();
        card3_pic = new PictureBox();
        card3_name = new Label();
        card3_desc = new Label();
        card3_temp = new Label();
        card3_counts = new Label();
        card3_btn0 = new Button();
        card3_btn1 = new Button();
        card3_btn2 = new Button();
        card3_btn3 = new Button();
        card4 = new Panel();
        card4_status = new Label();
        card4_star = new Button();
        card4_pic = new PictureBox();
        card4_name = new Label();
        card4_desc = new Label();
        card4_temp = new Label();
        card4_counts = new Label();
        card4_btn0 = new Button();
        card4_btn1 = new Button();
        card4_btn2 = new Button();
        card4_btn3 = new Button();
        card5 = new Panel();
        card5_status = new Label();
        card5_star = new Button();
        card5_pic = new PictureBox();
        card5_name = new Label();
        card5_desc = new Label();
        card5_temp = new Label();
        card5_counts = new Label();
        card5_btn0 = new Button();
        card5_btn1 = new Button();
        card5_btn2 = new Button();
        card5_btn3 = new Button();
        tableLayoutMain.SuspendLayout();
        panelHeader.SuspendLayout();
        flowStats.SuspendLayout();
        statRooms.SuspendLayout();
        statTemp.SuspendLayout();
        statLights.SuspendLayout();
        statDevices.SuspendLayout();
        flowRoomCards.SuspendLayout();
        card1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)card1_pic).BeginInit();
        card2.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)card2_pic).BeginInit();
        card3.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)card3_pic).BeginInit();
        card4.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)card4_pic).BeginInit();
        card5.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)card5_pic).BeginInit();
        SuspendLayout();
        // 
        // tableLayoutMain
        // 
        tableLayoutMain.ColumnCount = 1;
        tableLayoutMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        tableLayoutMain.Controls.Add(panelHeader, 0, 0);
        tableLayoutMain.Controls.Add(flowStats, 0, 1);
        tableLayoutMain.Controls.Add(flowRoomCards, 0, 2);
        tableLayoutMain.Dock = DockStyle.Fill;
        tableLayoutMain.Location = new Point(0, 0);
        tableLayoutMain.Margin = new Padding(3, 4, 3, 4);
        tableLayoutMain.Name = "tableLayoutMain";
        tableLayoutMain.Padding = new Padding(27, 21, 27, 21);
        tableLayoutMain.RowCount = 3;
        tableLayoutMain.RowStyles.Add(new RowStyle());
        tableLayoutMain.RowStyles.Add(new RowStyle());
        tableLayoutMain.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        tableLayoutMain.Size = new Size(931, 832);
        tableLayoutMain.TabIndex = 0;
        // 
        // panelHeader
        // 
        panelHeader.AutoSize = true;
        panelHeader.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        panelHeader.Controls.Add(lblRoomsOverview);
        panelHeader.Controls.Add(lblSubtitle);
        panelHeader.Dock = DockStyle.Fill;
        panelHeader.Location = new Point(30, 25);
        panelHeader.Margin = new Padding(3, 4, 3, 4);
        panelHeader.MinimumSize = new Size(0, 85);
        panelHeader.Name = "panelHeader";
        panelHeader.Size = new Size(871, 85);
        panelHeader.TabIndex = 0;
        // 
        // lblRoomsOverview
        // 
        lblRoomsOverview.AutoSize = true;
        lblRoomsOverview.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
        lblRoomsOverview.ForeColor = Color.White;
        lblRoomsOverview.Location = new Point(0, 0);
        lblRoomsOverview.Name = "lblRoomsOverview";
        lblRoomsOverview.Size = new Size(316, 50);
        lblRoomsOverview.TabIndex = 0;
        lblRoomsOverview.Text = "Rooms Overview";
        // 
        // lblSubtitle
        // 
        lblSubtitle.AutoSize = true;
        lblSubtitle.ForeColor = Color.FromArgb(180, 180, 200);
        lblSubtitle.Location = new Point(2, 51);
        lblSubtitle.Name = "lblSubtitle";
        lblSubtitle.Size = new Size(344, 20);
        lblSubtitle.TabIndex = 1;
        lblSubtitle.Text = "Manage and control all rooms in your smart home.";
        // 
        // flowStats
        // 
        flowStats.AutoSize = true;
        flowStats.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        flowStats.BackColor = Color.FromArgb(15, 15, 35);
        flowStats.Controls.Add(statRooms);
        flowStats.Controls.Add(statTemp);
        flowStats.Controls.Add(statLights);
        flowStats.Controls.Add(statDevices);
        flowStats.Dock = DockStyle.Fill;
        flowStats.Location = new Point(30, 118);
        flowStats.Margin = new Padding(3, 4, 3, 4);
        flowStats.Name = "flowStats";
        flowStats.Padding = new Padding(0, 11, 0, 11);
        flowStats.Size = new Size(871, 214);
        flowStats.TabIndex = 1;
        // 
        // statRooms
        // 
        statRooms.BackColor = Color.FromArgb(40, 40, 70);
        statRooms.Controls.Add(statRooms_val);
        statRooms.Controls.Add(statRooms_cap);
        statRooms.Controls.Add(statRooms_badge);
        statRooms.Location = new Point(0, 11);
        statRooms.Margin = new Padding(0, 0, 18, 11);
        statRooms.Name = "statRooms";
        statRooms.Size = new Size(229, 85);
        statRooms.TabIndex = 0;
        // 
        // statRooms_val
        // 
        statRooms_val.AutoSize = true;
        statRooms_val.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
        statRooms_val.ForeColor = Color.White;
        statRooms_val.Location = new Point(14, 13);
        statRooms_val.Name = "statRooms_val";
        statRooms_val.Size = new Size(67, 32);
        statRooms_val.TabIndex = 0;
        statRooms_val.Text = "4 / 5";
        // 
        // statRooms_cap
        // 
        statRooms_cap.AutoSize = true;
        statRooms_cap.ForeColor = Color.FromArgb(180, 180, 200);
        statRooms_cap.Location = new Point(14, 48);
        statRooms_cap.Name = "statRooms_cap";
        statRooms_cap.Size = new Size(100, 20);
        statRooms_cap.TabIndex = 1;
        statRooms_cap.Text = "Rooms Active";
        // 
        // statRooms_badge
        // 
        statRooms_badge.AutoSize = true;
        statRooms_badge.ForeColor = Color.LightGreen;
        statRooms_badge.Location = new Point(137, 16);
        statRooms_badge.Name = "statRooms_badge";
        statRooms_badge.Size = new Size(65, 20);
        statRooms_badge.TabIndex = 2;
        statRooms_badge.Text = "● Online";
        // 
        // statTemp
        // 
        statTemp.BackColor = Color.FromArgb(40, 40, 70);
        statTemp.Controls.Add(statTemp_val);
        statTemp.Controls.Add(statTemp_cap);
        statTemp.Location = new Point(247, 11);
        statTemp.Margin = new Padding(0, 0, 18, 11);
        statTemp.Name = "statTemp";
        statTemp.Size = new Size(229, 85);
        statTemp.TabIndex = 1;
        // 
        // statTemp_val
        // 
        statTemp_val.AutoSize = true;
        statTemp_val.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
        statTemp_val.ForeColor = Color.White;
        statTemp_val.Location = new Point(14, 13);
        statTemp_val.Name = "statTemp_val";
        statTemp_val.Size = new Size(66, 32);
        statTemp_val.TabIndex = 0;
        statTemp_val.Text = "22°C";
        // 
        // statTemp_cap
        // 
        statTemp_cap.AutoSize = true;
        statTemp_cap.ForeColor = Color.FromArgb(180, 180, 200);
        statTemp_cap.Location = new Point(14, 48);
        statTemp_cap.Name = "statTemp_cap";
        statTemp_cap.Size = new Size(126, 20);
        statTemp_cap.TabIndex = 1;
        statTemp_cap.Text = "Avg. Temperature";
        // 
        // statLights
        // 
        statLights.BackColor = Color.FromArgb(40, 40, 70);
        statLights.Controls.Add(statLights_val);
        statLights.Controls.Add(statLights_cap);
        statLights.Location = new Point(494, 11);
        statLights.Margin = new Padding(0, 0, 18, 11);
        statLights.Name = "statLights";
        statLights.Size = new Size(229, 85);
        statLights.TabIndex = 2;
        // 
        // statLights_val
        // 
        statLights_val.AutoSize = true;
        statLights_val.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
        statLights_val.ForeColor = Color.White;
        statLights_val.Location = new Point(14, 13);
        statLights_val.Name = "statLights_val";
        statLights_val.Size = new Size(42, 32);
        statLights_val.TabIndex = 0;
        statLights_val.Text = "12";
        // 
        // statLights_cap
        // 
        statLights_cap.AutoSize = true;
        statLights_cap.ForeColor = Color.FromArgb(180, 180, 200);
        statLights_cap.Location = new Point(14, 48);
        statLights_cap.Name = "statLights_cap";
        statLights_cap.Size = new Size(85, 20);
        statLights_cap.TabIndex = 1;
        statLights_cap.Text = "Total Lights";
        // 
        // statDevices
        // 
        statDevices.BackColor = Color.FromArgb(40, 40, 70);
        statDevices.Controls.Add(statDevices_val);
        statDevices.Controls.Add(statDevices_cap);
        statDevices.Location = new Point(0, 107);
        statDevices.Margin = new Padding(0, 0, 18, 11);
        statDevices.Name = "statDevices";
        statDevices.Size = new Size(229, 85);
        statDevices.TabIndex = 3;
        // 
        // statDevices_val
        // 
        statDevices_val.AutoSize = true;
        statDevices_val.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
        statDevices_val.ForeColor = Color.White;
        statDevices_val.Location = new Point(14, 13);
        statDevices_val.Name = "statDevices_val";
        statDevices_val.Size = new Size(42, 32);
        statDevices_val.TabIndex = 0;
        statDevices_val.Text = "24";
        // 
        // statDevices_cap
        // 
        statDevices_cap.AutoSize = true;
        statDevices_cap.ForeColor = Color.FromArgb(180, 180, 200);
        statDevices_cap.Location = new Point(14, 48);
        statDevices_cap.Name = "statDevices_cap";
        statDevices_cap.Size = new Size(97, 20);
        statDevices_cap.TabIndex = 1;
        statDevices_cap.Text = "Total Devices";
        // 
        // flowRoomCards
        // 
        flowRoomCards.AutoScroll = true;
        flowRoomCards.BackColor = Color.FromArgb(15, 15, 35);
        flowRoomCards.Controls.Add(card1);
        flowRoomCards.Controls.Add(card2);
        flowRoomCards.Controls.Add(card3);
        flowRoomCards.Controls.Add(card4);
        flowRoomCards.Controls.Add(card5);
        flowRoomCards.Dock = DockStyle.Fill;
        flowRoomCards.Location = new Point(30, 340);
        flowRoomCards.Margin = new Padding(3, 4, 3, 4);
        flowRoomCards.Name = "flowRoomCards";
        flowRoomCards.Padding = new Padding(0, 11, 0, 0);
        flowRoomCards.Size = new Size(871, 467);
        flowRoomCards.TabIndex = 2;
        // 
        // card1
        // 
        card1.BackColor = Color.FromArgb(40, 40, 70);
        card1.Controls.Add(card1_status);
        card1.Controls.Add(card1_star);
        card1.Controls.Add(card1_pic);
        card1.Controls.Add(card1_name);
        card1.Controls.Add(card1_desc);
        card1.Controls.Add(card1_temp);
        card1.Controls.Add(card1_counts);
        card1.Controls.Add(card1_btn0);
        card1.Controls.Add(card1_btn1);
        card1.Controls.Add(card1_btn2);
        card1.Controls.Add(card1_btn3);
        card1.Location = new Point(0, 11);
        card1.Margin = new Padding(0, 0, 23, 27);
        card1.MinimumSize = new Size(343, 507);
        card1.Name = "card1";
        card1.Size = new Size(366, 533);
        card1.TabIndex = 0;
        // 
        // card1_status
        // 
        card1_status.AutoSize = true;
        card1_status.ForeColor = Color.LightGreen;
        card1_status.Location = new Point(14, 11);
        card1_status.Name = "card1_status";
        card1_status.Size = new Size(65, 20);
        card1_status.TabIndex = 0;
        card1_status.Text = "● Online";
        // 
        // card1_star
        // 
        card1_star.BackColor = Color.FromArgb(40, 40, 70);
        card1_star.FlatAppearance.BorderSize = 0;
        card1_star.FlatStyle = FlatStyle.Flat;
        card1_star.ForeColor = Color.Gold;
        card1_star.Location = new Point(311, 5);
        card1_star.Margin = new Padding(3, 4, 3, 4);
        card1_star.Name = "card1_star";
        card1_star.Size = new Size(37, 37);
        card1_star.TabIndex = 1;
        card1_star.Text = "★";
        card1_star.UseVisualStyleBackColor = false;
        // 
        // card1_pic
        // 
        card1_pic.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        card1_pic.Image = Properties.Resources.romm1;
        card1_pic.Location = new Point(14, 48);
        card1_pic.Margin = new Padding(3, 4, 3, 4);
        card1_pic.Name = "card1_pic";
        card1_pic.Size = new Size(338, 187);
        card1_pic.SizeMode = PictureBoxSizeMode.StretchImage;
        card1_pic.TabIndex = 2;
        card1_pic.TabStop = false;
        // 
        // card1_name
        // 
        card1_name.AutoSize = true;
        card1_name.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
        card1_name.ForeColor = Color.White;
        card1_name.Location = new Point(14, 251);
        card1_name.Name = "card1_name";
        card1_name.Size = new Size(130, 28);
        card1_name.TabIndex = 3;
        card1_name.Text = "Living Room";
        // 
        // card1_desc
        // 
        card1_desc.AutoSize = true;
        card1_desc.ForeColor = Color.FromArgb(180, 180, 200);
        card1_desc.Location = new Point(14, 283);
        card1_desc.Name = "card1_desc";
        card1_desc.Size = new Size(172, 20);
        card1_desc.TabIndex = 4;
        card1_desc.Text = "Main entertainment area";
        // 
        // card1_temp
        // 
        card1_temp.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        card1_temp.AutoSize = true;
        card1_temp.ForeColor = Color.White;
        card1_temp.Location = new Point(297, 251);
        card1_temp.Name = "card1_temp";
        card1_temp.Size = new Size(40, 20);
        card1_temp.TabIndex = 5;
        card1_temp.Text = "22°C";
        // 
        // card1_counts
        // 
        card1_counts.AutoSize = true;
        card1_counts.ForeColor = Color.FromArgb(180, 180, 200);
        card1_counts.Location = new Point(14, 317);
        card1_counts.Name = "card1_counts";
        card1_counts.Size = new Size(141, 20);
        card1_counts.TabIndex = 6;
        card1_counts.Text = "Lights: 4   Devices: 6";
        // 
        // card1_btn0
        // 
        card1_btn0.BackColor = Color.FromArgb(108, 92, 231);
        card1_btn0.FlatAppearance.BorderSize = 0;
        card1_btn0.FlatStyle = FlatStyle.Flat;
        card1_btn0.ForeColor = Color.White;
        card1_btn0.Location = new Point(14, 357);
        card1_btn0.Margin = new Padding(3, 4, 3, 4);
        card1_btn0.Name = "card1_btn0";
        card1_btn0.Size = new Size(160, 48);
        card1_btn0.TabIndex = 7;
        card1_btn0.Text = "Lights On";
        card1_btn0.UseVisualStyleBackColor = false;
        // 
        // card1_btn1
        // 
        card1_btn1.BackColor = Color.FromArgb(108, 92, 231);
        card1_btn1.FlatAppearance.BorderSize = 0;
        card1_btn1.FlatStyle = FlatStyle.Flat;
        card1_btn1.ForeColor = Color.White;
        card1_btn1.Location = new Point(183, 357);
        card1_btn1.Margin = new Padding(3, 4, 3, 4);
        card1_btn1.Name = "card1_btn1";
        card1_btn1.Size = new Size(160, 48);
        card1_btn1.TabIndex = 8;
        card1_btn1.Text = "AC On";
        card1_btn1.UseVisualStyleBackColor = false;
        // 
        // card1_btn2
        // 
        card1_btn2.BackColor = Color.FromArgb(108, 92, 231);
        card1_btn2.FlatAppearance.BorderSize = 0;
        card1_btn2.FlatStyle = FlatStyle.Flat;
        card1_btn2.ForeColor = Color.White;
        card1_btn2.Location = new Point(14, 416);
        card1_btn2.Margin = new Padding(3, 4, 3, 4);
        card1_btn2.Name = "card1_btn2";
        card1_btn2.Size = new Size(160, 48);
        card1_btn2.TabIndex = 9;
        card1_btn2.Text = "TV On";
        card1_btn2.UseVisualStyleBackColor = false;
        // 
        // card1_btn3
        // 
        card1_btn3.BackColor = Color.FromArgb(55, 55, 85);
        card1_btn3.FlatAppearance.BorderSize = 0;
        card1_btn3.FlatStyle = FlatStyle.Flat;
        card1_btn3.ForeColor = Color.White;
        card1_btn3.Location = new Point(183, 416);
        card1_btn3.Margin = new Padding(3, 4, 3, 4);
        card1_btn3.Name = "card1_btn3";
        card1_btn3.Size = new Size(160, 48);
        card1_btn3.TabIndex = 10;
        card1_btn3.Text = "...";
        card1_btn3.UseVisualStyleBackColor = false;
        // 
        // card2
        // 
        card2.BackColor = Color.FromArgb(40, 40, 70);
        card2.Controls.Add(card2_status);
        card2.Controls.Add(card2_star);
        card2.Controls.Add(card2_pic);
        card2.Controls.Add(card2_name);
        card2.Controls.Add(card2_desc);
        card2.Controls.Add(card2_temp);
        card2.Controls.Add(card2_counts);
        card2.Controls.Add(card2_btn0);
        card2.Controls.Add(card2_btn1);
        card2.Controls.Add(card2_btn2);
        card2.Controls.Add(card2_btn3);
        card2.Location = new Point(389, 11);
        card2.Margin = new Padding(0, 0, 23, 27);
        card2.MinimumSize = new Size(343, 507);
        card2.Name = "card2";
        card2.Size = new Size(366, 533);
        card2.TabIndex = 1;
        // 
        // card2_status
        // 
        card2_status.AutoSize = true;
        card2_status.ForeColor = Color.LightGreen;
        card2_status.Location = new Point(14, 11);
        card2_status.Name = "card2_status";
        card2_status.Size = new Size(65, 20);
        card2_status.TabIndex = 0;
        card2_status.Text = "● Online";
        // 
        // card2_star
        // 
        card2_star.BackColor = Color.FromArgb(40, 40, 70);
        card2_star.FlatAppearance.BorderSize = 0;
        card2_star.FlatStyle = FlatStyle.Flat;
        card2_star.ForeColor = Color.Gold;
        card2_star.Location = new Point(311, 5);
        card2_star.Margin = new Padding(3, 4, 3, 4);
        card2_star.Name = "card2_star";
        card2_star.Size = new Size(37, 37);
        card2_star.TabIndex = 1;
        card2_star.Text = "★";
        card2_star.UseVisualStyleBackColor = false;
        // 
        // card2_pic
        // 
        card2_pic.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        card2_pic.Image = Properties.Resources.room2;
        card2_pic.Location = new Point(14, 48);
        card2_pic.Margin = new Padding(3, 4, 3, 4);
        card2_pic.Name = "card2_pic";
        card2_pic.Size = new Size(338, 187);
        card2_pic.SizeMode = PictureBoxSizeMode.StretchImage;
        card2_pic.TabIndex = 2;
        card2_pic.TabStop = false;
        // 
        // card2_name
        // 
        card2_name.AutoSize = true;
        card2_name.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
        card2_name.ForeColor = Color.White;
        card2_name.Location = new Point(14, 251);
        card2_name.Name = "card2_name";
        card2_name.Size = new Size(98, 28);
        card2_name.TabIndex = 3;
        card2_name.Text = "Bedroom";
        // 
        // card2_desc
        // 
        card2_desc.AutoSize = true;
        card2_desc.ForeColor = Color.FromArgb(180, 180, 200);
        card2_desc.Location = new Point(14, 283);
        card2_desc.Name = "card2_desc";
        card2_desc.Size = new Size(136, 20);
        card2_desc.TabIndex = 4;
        card2_desc.Text = "Rest and relaxation";
        // 
        // card2_temp
        // 
        card2_temp.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        card2_temp.AutoSize = true;
        card2_temp.ForeColor = Color.White;
        card2_temp.Location = new Point(297, 251);
        card2_temp.Name = "card2_temp";
        card2_temp.Size = new Size(40, 20);
        card2_temp.TabIndex = 5;
        card2_temp.Text = "20°C";
        // 
        // card2_counts
        // 
        card2_counts.AutoSize = true;
        card2_counts.ForeColor = Color.FromArgb(180, 180, 200);
        card2_counts.Location = new Point(14, 317);
        card2_counts.Name = "card2_counts";
        card2_counts.Size = new Size(141, 20);
        card2_counts.TabIndex = 6;
        card2_counts.Text = "Lights: 2   Devices: 4";
        // 
        // card2_btn0
        // 
        card2_btn0.BackColor = Color.FromArgb(108, 92, 231);
        card2_btn0.FlatAppearance.BorderSize = 0;
        card2_btn0.FlatStyle = FlatStyle.Flat;
        card2_btn0.ForeColor = Color.White;
        card2_btn0.Location = new Point(14, 357);
        card2_btn0.Margin = new Padding(3, 4, 3, 4);
        card2_btn0.Name = "card2_btn0";
        card2_btn0.Size = new Size(160, 48);
        card2_btn0.TabIndex = 7;
        card2_btn0.Text = "Night Mode";
        card2_btn0.UseVisualStyleBackColor = false;
        // 
        // card2_btn1
        // 
        card2_btn1.BackColor = Color.FromArgb(55, 55, 85);
        card2_btn1.FlatAppearance.BorderSize = 0;
        card2_btn1.FlatStyle = FlatStyle.Flat;
        card2_btn1.ForeColor = Color.White;
        card2_btn1.Location = new Point(183, 357);
        card2_btn1.Margin = new Padding(3, 4, 3, 4);
        card2_btn1.Name = "card2_btn1";
        card2_btn1.Size = new Size(160, 48);
        card2_btn1.TabIndex = 8;
        card2_btn1.Text = "Lights Off";
        card2_btn1.UseVisualStyleBackColor = false;
        // 
        // card2_btn2
        // 
        card2_btn2.BackColor = Color.FromArgb(55, 55, 85);
        card2_btn2.FlatAppearance.BorderSize = 0;
        card2_btn2.FlatStyle = FlatStyle.Flat;
        card2_btn2.ForeColor = Color.White;
        card2_btn2.Location = new Point(14, 416);
        card2_btn2.Margin = new Padding(3, 4, 3, 4);
        card2_btn2.Name = "card2_btn2";
        card2_btn2.Size = new Size(160, 48);
        card2_btn2.TabIndex = 9;
        card2_btn2.Text = "Blinds Closed";
        card2_btn2.UseVisualStyleBackColor = false;
        // 
        // card2_btn3
        // 
        card2_btn3.BackColor = Color.FromArgb(55, 55, 85);
        card2_btn3.FlatAppearance.BorderSize = 0;
        card2_btn3.FlatStyle = FlatStyle.Flat;
        card2_btn3.ForeColor = Color.White;
        card2_btn3.Location = new Point(183, 416);
        card2_btn3.Margin = new Padding(3, 4, 3, 4);
        card2_btn3.Name = "card2_btn3";
        card2_btn3.Size = new Size(160, 48);
        card2_btn3.TabIndex = 10;
        card2_btn3.Text = "...";
        card2_btn3.UseVisualStyleBackColor = false;
        // 
        // card3
        // 
        card3.BackColor = Color.FromArgb(40, 40, 70);
        card3.Controls.Add(card3_status);
        card3.Controls.Add(card3_star);
        card3.Controls.Add(card3_pic);
        card3.Controls.Add(card3_name);
        card3.Controls.Add(card3_desc);
        card3.Controls.Add(card3_temp);
        card3.Controls.Add(card3_counts);
        card3.Controls.Add(card3_btn0);
        card3.Controls.Add(card3_btn1);
        card3.Controls.Add(card3_btn2);
        card3.Controls.Add(card3_btn3);
        card3.Location = new Point(0, 571);
        card3.Margin = new Padding(0, 0, 23, 27);
        card3.MinimumSize = new Size(343, 507);
        card3.Name = "card3";
        card3.Size = new Size(366, 533);
        card3.TabIndex = 2;
        // 
        // card3_status
        // 
        card3_status.AutoSize = true;
        card3_status.ForeColor = Color.LightGreen;
        card3_status.Location = new Point(14, 11);
        card3_status.Name = "card3_status";
        card3_status.Size = new Size(65, 20);
        card3_status.TabIndex = 0;
        card3_status.Text = "● Online";
        // 
        // card3_star
        // 
        card3_star.BackColor = Color.FromArgb(40, 40, 70);
        card3_star.FlatAppearance.BorderSize = 0;
        card3_star.FlatStyle = FlatStyle.Flat;
        card3_star.ForeColor = Color.Gold;
        card3_star.Location = new Point(311, 5);
        card3_star.Margin = new Padding(3, 4, 3, 4);
        card3_star.Name = "card3_star";
        card3_star.Size = new Size(37, 37);
        card3_star.TabIndex = 1;
        card3_star.Text = "★";
        card3_star.UseVisualStyleBackColor = false;
        // 
        // card3_pic
        // 
        card3_pic.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        card3_pic.Image = Properties.Resources.room3;
        card3_pic.Location = new Point(14, 48);
        card3_pic.Margin = new Padding(3, 4, 3, 4);
        card3_pic.Name = "card3_pic";
        card3_pic.Size = new Size(338, 187);
        card3_pic.SizeMode = PictureBoxSizeMode.StretchImage;
        card3_pic.TabIndex = 2;
        card3_pic.TabStop = false;
        // 
        // card3_name
        // 
        card3_name.AutoSize = true;
        card3_name.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
        card3_name.ForeColor = Color.White;
        card3_name.Location = new Point(14, 251);
        card3_name.Name = "card3_name";
        card3_name.Size = new Size(84, 28);
        card3_name.TabIndex = 3;
        card3_name.Text = "Kitchen";
        // 
        // card3_desc
        // 
        card3_desc.AutoSize = true;
        card3_desc.ForeColor = Color.FromArgb(180, 180, 200);
        card3_desc.Location = new Point(14, 283);
        card3_desc.Name = "card3_desc";
        card3_desc.Size = new Size(139, 20);
        card3_desc.TabIndex = 4;
        card3_desc.Text = "Cooking and dining";
        // 
        // card3_temp
        // 
        card3_temp.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        card3_temp.AutoSize = true;
        card3_temp.ForeColor = Color.White;
        card3_temp.Location = new Point(297, 251);
        card3_temp.Name = "card3_temp";
        card3_temp.Size = new Size(40, 20);
        card3_temp.TabIndex = 5;
        card3_temp.Text = "24°C";
        // 
        // card3_counts
        // 
        card3_counts.AutoSize = true;
        card3_counts.ForeColor = Color.FromArgb(180, 180, 200);
        card3_counts.Location = new Point(14, 317);
        card3_counts.Name = "card3_counts";
        card3_counts.Size = new Size(141, 20);
        card3_counts.TabIndex = 6;
        card3_counts.Text = "Lights: 3   Devices: 5";
        // 
        // card3_btn0
        // 
        card3_btn0.BackColor = Color.FromArgb(108, 92, 231);
        card3_btn0.FlatAppearance.BorderSize = 0;
        card3_btn0.FlatStyle = FlatStyle.Flat;
        card3_btn0.ForeColor = Color.White;
        card3_btn0.Location = new Point(14, 357);
        card3_btn0.Margin = new Padding(3, 4, 3, 4);
        card3_btn0.Name = "card3_btn0";
        card3_btn0.Size = new Size(160, 48);
        card3_btn0.TabIndex = 7;
        card3_btn0.Text = "Lights On";
        card3_btn0.UseVisualStyleBackColor = false;
        // 
        // card3_btn1
        // 
        card3_btn1.BackColor = Color.FromArgb(108, 92, 231);
        card3_btn1.FlatAppearance.BorderSize = 0;
        card3_btn1.FlatStyle = FlatStyle.Flat;
        card3_btn1.ForeColor = Color.White;
        card3_btn1.Location = new Point(183, 357);
        card3_btn1.Margin = new Padding(3, 4, 3, 4);
        card3_btn1.Name = "card3_btn1";
        card3_btn1.Size = new Size(160, 48);
        card3_btn1.TabIndex = 8;
        card3_btn1.Text = "Hood On";
        card3_btn1.UseVisualStyleBackColor = false;
        // 
        // card3_btn2
        // 
        card3_btn2.BackColor = Color.FromArgb(108, 92, 231);
        card3_btn2.FlatAppearance.BorderSize = 0;
        card3_btn2.FlatStyle = FlatStyle.Flat;
        card3_btn2.ForeColor = Color.White;
        card3_btn2.Location = new Point(14, 416);
        card3_btn2.Margin = new Padding(3, 4, 3, 4);
        card3_btn2.Name = "card3_btn2";
        card3_btn2.Size = new Size(160, 48);
        card3_btn2.TabIndex = 9;
        card3_btn2.Text = "Coffee Ready";
        card3_btn2.UseVisualStyleBackColor = false;
        // 
        // card3_btn3
        // 
        card3_btn3.BackColor = Color.FromArgb(55, 55, 85);
        card3_btn3.FlatAppearance.BorderSize = 0;
        card3_btn3.FlatStyle = FlatStyle.Flat;
        card3_btn3.ForeColor = Color.White;
        card3_btn3.Location = new Point(183, 416);
        card3_btn3.Margin = new Padding(3, 4, 3, 4);
        card3_btn3.Name = "card3_btn3";
        card3_btn3.Size = new Size(160, 48);
        card3_btn3.TabIndex = 10;
        card3_btn3.Text = "...";
        card3_btn3.UseVisualStyleBackColor = false;
        // 
        // card4
        // 
        card4.BackColor = Color.FromArgb(40, 40, 70);
        card4.Controls.Add(card4_status);
        card4.Controls.Add(card4_star);
        card4.Controls.Add(card4_pic);
        card4.Controls.Add(card4_name);
        card4.Controls.Add(card4_desc);
        card4.Controls.Add(card4_temp);
        card4.Controls.Add(card4_counts);
        card4.Controls.Add(card4_btn0);
        card4.Controls.Add(card4_btn1);
        card4.Controls.Add(card4_btn2);
        card4.Controls.Add(card4_btn3);
        card4.Location = new Point(389, 571);
        card4.Margin = new Padding(0, 0, 23, 27);
        card4.MinimumSize = new Size(343, 507);
        card4.Name = "card4";
        card4.Size = new Size(366, 533);
        card4.TabIndex = 3;
        // 
        // card4_status
        // 
        card4_status.AutoSize = true;
        card4_status.ForeColor = Color.FromArgb(108, 92, 231);
        card4_status.Location = new Point(14, 11);
        card4_status.Name = "card4_status";
        card4_status.Size = new Size(76, 20);
        card4_status.TabIndex = 0;
        card4_status.Text = "● Standby";
        // 
        // card4_star
        // 
        card4_star.BackColor = Color.FromArgb(40, 40, 70);
        card4_star.FlatAppearance.BorderSize = 0;
        card4_star.FlatStyle = FlatStyle.Flat;
        card4_star.ForeColor = Color.Gold;
        card4_star.Location = new Point(311, 5);
        card4_star.Margin = new Padding(3, 4, 3, 4);
        card4_star.Name = "card4_star";
        card4_star.Size = new Size(37, 37);
        card4_star.TabIndex = 1;
        card4_star.Text = "★";
        card4_star.UseVisualStyleBackColor = false;
        // 
        // card4_pic
        // 
        card4_pic.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        card4_pic.Image = Properties.Resources.images4;
        card4_pic.Location = new Point(14, 48);
        card4_pic.Margin = new Padding(3, 4, 3, 4);
        card4_pic.Name = "card4_pic";
        card4_pic.Size = new Size(338, 187);
        card4_pic.SizeMode = PictureBoxSizeMode.StretchImage;
        card4_pic.TabIndex = 2;
        card4_pic.TabStop = false;
        // 
        // card4_name
        // 
        card4_name.AutoSize = true;
        card4_name.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
        card4_name.ForeColor = Color.White;
        card4_name.Location = new Point(14, 251);
        card4_name.Name = "card4_name";
        card4_name.Size = new Size(106, 28);
        card4_name.TabIndex = 3;
        card4_name.Text = "Bathroom";
        // 
        // card4_desc
        // 
        card4_desc.AutoSize = true;
        card4_desc.ForeColor = Color.FromArgb(180, 180, 200);
        card4_desc.Location = new Point(14, 283);
        card4_desc.Name = "card4_desc";
        card4_desc.Size = new Size(120, 20);
        card4_desc.TabIndex = 4;
        card4_desc.Text = "Personal hygiene";
        // 
        // card4_temp
        // 
        card4_temp.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        card4_temp.AutoSize = true;
        card4_temp.ForeColor = Color.White;
        card4_temp.Location = new Point(297, 251);
        card4_temp.Name = "card4_temp";
        card4_temp.Size = new Size(40, 20);
        card4_temp.TabIndex = 5;
        card4_temp.Text = "21°C";
        // 
        // card4_counts
        // 
        card4_counts.AutoSize = true;
        card4_counts.ForeColor = Color.FromArgb(180, 180, 200);
        card4_counts.Location = new Point(14, 317);
        card4_counts.Name = "card4_counts";
        card4_counts.Size = new Size(141, 20);
        card4_counts.TabIndex = 6;
        card4_counts.Text = "Lights: 2   Devices: 3";
        // 
        // card4_btn0
        // 
        card4_btn0.BackColor = Color.FromArgb(55, 55, 85);
        card4_btn0.FlatAppearance.BorderSize = 0;
        card4_btn0.FlatStyle = FlatStyle.Flat;
        card4_btn0.ForeColor = Color.White;
        card4_btn0.Location = new Point(14, 357);
        card4_btn0.Margin = new Padding(3, 4, 3, 4);
        card4_btn0.Name = "card4_btn0";
        card4_btn0.Size = new Size(160, 48);
        card4_btn0.TabIndex = 7;
        card4_btn0.Text = "Heater Off";
        card4_btn0.UseVisualStyleBackColor = false;
        // 
        // card4_btn1
        // 
        card4_btn1.BackColor = Color.FromArgb(55, 55, 85);
        card4_btn1.FlatAppearance.BorderSize = 0;
        card4_btn1.FlatStyle = FlatStyle.Flat;
        card4_btn1.ForeColor = Color.White;
        card4_btn1.Location = new Point(183, 357);
        card4_btn1.Margin = new Padding(3, 4, 3, 4);
        card4_btn1.Name = "card4_btn1";
        card4_btn1.Size = new Size(160, 48);
        card4_btn1.TabIndex = 8;
        card4_btn1.Text = "Lights Off";
        card4_btn1.UseVisualStyleBackColor = false;
        // 
        // card4_btn2
        // 
        card4_btn2.BackColor = Color.FromArgb(55, 55, 85);
        card4_btn2.FlatAppearance.BorderSize = 0;
        card4_btn2.FlatStyle = FlatStyle.Flat;
        card4_btn2.ForeColor = Color.White;
        card4_btn2.Location = new Point(14, 416);
        card4_btn2.Margin = new Padding(3, 4, 3, 4);
        card4_btn2.Name = "card4_btn2";
        card4_btn2.Size = new Size(160, 48);
        card4_btn2.TabIndex = 9;
        card4_btn2.Text = "Fan Off";
        card4_btn2.UseVisualStyleBackColor = false;
        // 
        // card4_btn3
        // 
        card4_btn3.BackColor = Color.FromArgb(55, 55, 85);
        card4_btn3.FlatAppearance.BorderSize = 0;
        card4_btn3.FlatStyle = FlatStyle.Flat;
        card4_btn3.ForeColor = Color.White;
        card4_btn3.Location = new Point(183, 416);
        card4_btn3.Margin = new Padding(3, 4, 3, 4);
        card4_btn3.Name = "card4_btn3";
        card4_btn3.Size = new Size(160, 48);
        card4_btn3.TabIndex = 10;
        card4_btn3.Text = "...";
        card4_btn3.UseVisualStyleBackColor = false;
        // 
        // card5
        // 
        card5.BackColor = Color.FromArgb(40, 40, 70);
        card5.Controls.Add(card5_status);
        card5.Controls.Add(card5_star);
        card5.Controls.Add(card5_pic);
        card5.Controls.Add(card5_name);
        card5.Controls.Add(card5_desc);
        card5.Controls.Add(card5_temp);
        card5.Controls.Add(card5_counts);
        card5.Controls.Add(card5_btn0);
        card5.Controls.Add(card5_btn1);
        card5.Controls.Add(card5_btn2);
        card5.Controls.Add(card5_btn3);
        card5.Location = new Point(0, 1131);
        card5.Margin = new Padding(0, 0, 23, 27);
        card5.MinimumSize = new Size(343, 507);
        card5.Name = "card5";
        card5.Size = new Size(366, 533);
        card5.TabIndex = 4;
        // 
        // card5_status
        // 
        card5_status.AutoSize = true;
        card5_status.ForeColor = Color.FromArgb(108, 92, 231);
        card5_status.Location = new Point(14, 11);
        card5_status.Name = "card5_status";
        card5_status.Size = new Size(76, 20);
        card5_status.TabIndex = 0;
        card5_status.Text = "● Standby";
        // 
        // card5_star
        // 
        card5_star.BackColor = Color.FromArgb(40, 40, 70);
        card5_star.FlatAppearance.BorderSize = 0;
        card5_star.FlatStyle = FlatStyle.Flat;
        card5_star.ForeColor = Color.Gold;
        card5_star.Location = new Point(311, 5);
        card5_star.Margin = new Padding(3, 4, 3, 4);
        card5_star.Name = "card5_star";
        card5_star.Size = new Size(37, 37);
        card5_star.TabIndex = 1;
        card5_star.Text = "★";
        card5_star.UseVisualStyleBackColor = false;
        // 
        // card5_pic
        // 
        card5_pic.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        card5_pic.Image = Properties.Resources.images5;
        card5_pic.Location = new Point(14, 48);
        card5_pic.Margin = new Padding(3, 4, 3, 4);
        card5_pic.Name = "card5_pic";
        card5_pic.Size = new Size(338, 187);
        card5_pic.SizeMode = PictureBoxSizeMode.StretchImage;
        card5_pic.TabIndex = 2;
        card5_pic.TabStop = false;
        // 
        // card5_name
        // 
        card5_name.AutoSize = true;
        card5_name.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
        card5_name.ForeColor = Color.White;
        card5_name.Location = new Point(14, 251);
        card5_name.Name = "card5_name";
        card5_name.Size = new Size(79, 28);
        card5_name.TabIndex = 3;
        card5_name.Text = "Garage";
        // 
        // card5_desc
        // 
        card5_desc.AutoSize = true;
        card5_desc.ForeColor = Color.FromArgb(180, 180, 200);
        card5_desc.Location = new Point(14, 283);
        card5_desc.Name = "card5_desc";
        card5_desc.Size = new Size(110, 20);
        card5_desc.TabIndex = 4;
        card5_desc.Text = "Vehicle storage";
        // 
        // card5_temp
        // 
        card5_temp.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        card5_temp.AutoSize = true;
        card5_temp.ForeColor = Color.White;
        card5_temp.Location = new Point(297, 251);
        card5_temp.Name = "card5_temp";
        card5_temp.Size = new Size(40, 20);
        card5_temp.TabIndex = 5;
        card5_temp.Text = "18°C";
        // 
        // card5_counts
        // 
        card5_counts.AutoSize = true;
        card5_counts.ForeColor = Color.FromArgb(180, 180, 200);
        card5_counts.Location = new Point(14, 317);
        card5_counts.Name = "card5_counts";
        card5_counts.Size = new Size(141, 20);
        card5_counts.TabIndex = 6;
        card5_counts.Text = "Lights: 1   Devices: 2";
        // 
        // card5_btn0
        // 
        card5_btn0.BackColor = Color.FromArgb(55, 55, 85);
        card5_btn0.FlatAppearance.BorderSize = 0;
        card5_btn0.FlatStyle = FlatStyle.Flat;
        card5_btn0.ForeColor = Color.White;
        card5_btn0.Location = new Point(14, 357);
        card5_btn0.Margin = new Padding(3, 4, 3, 4);
        card5_btn0.Name = "card5_btn0";
        card5_btn0.Size = new Size(160, 48);
        card5_btn0.TabIndex = 7;
        card5_btn0.Text = "Lights Off";
        card5_btn0.UseVisualStyleBackColor = false;
        // 
        // card5_btn1
        // 
        card5_btn1.BackColor = Color.FromArgb(55, 55, 85);
        card5_btn1.FlatAppearance.BorderSize = 0;
        card5_btn1.FlatStyle = FlatStyle.Flat;
        card5_btn1.ForeColor = Color.White;
        card5_btn1.Location = new Point(183, 357);
        card5_btn1.Margin = new Padding(3, 4, 3, 4);
        card5_btn1.Name = "card5_btn1";
        card5_btn1.Size = new Size(160, 48);
        card5_btn1.TabIndex = 8;
        card5_btn1.Text = "Door Closed";
        card5_btn1.UseVisualStyleBackColor = false;
        // 
        // card5_btn2
        // 
        card5_btn2.BackColor = Color.FromArgb(55, 55, 85);
        card5_btn2.FlatAppearance.BorderSize = 0;
        card5_btn2.FlatStyle = FlatStyle.Flat;
        card5_btn2.ForeColor = Color.White;
        card5_btn2.Location = new Point(14, 416);
        card5_btn2.Margin = new Padding(3, 4, 3, 4);
        card5_btn2.Name = "card5_btn2";
        card5_btn2.Size = new Size(160, 48);
        card5_btn2.TabIndex = 9;
        card5_btn2.Text = "Charger Standby";
        card5_btn2.UseVisualStyleBackColor = false;
        // 
        // card5_btn3
        // 
        card5_btn3.BackColor = Color.FromArgb(55, 55, 85);
        card5_btn3.FlatAppearance.BorderSize = 0;
        card5_btn3.FlatStyle = FlatStyle.Flat;
        card5_btn3.ForeColor = Color.White;
        card5_btn3.Location = new Point(183, 416);
        card5_btn3.Margin = new Padding(3, 4, 3, 4);
        card5_btn3.Name = "card5_btn3";
        card5_btn3.Size = new Size(160, 48);
        card5_btn3.TabIndex = 10;
        card5_btn3.Text = "...";
        card5_btn3.UseVisualStyleBackColor = false;
        // 
        // RoomsOverviewControl
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(15, 15, 35);
        Controls.Add(tableLayoutMain);
        Font = new Font("Segoe UI", 9F);
        Margin = new Padding(3, 4, 3, 4);
        Name = "RoomsOverviewControl";
        Size = new Size(931, 832);
        tableLayoutMain.ResumeLayout(false);
        tableLayoutMain.PerformLayout();
        panelHeader.ResumeLayout(false);
        panelHeader.PerformLayout();
        flowStats.ResumeLayout(false);
        statRooms.ResumeLayout(false);
        statRooms.PerformLayout();
        statTemp.ResumeLayout(false);
        statTemp.PerformLayout();
        statLights.ResumeLayout(false);
        statLights.PerformLayout();
        statDevices.ResumeLayout(false);
        statDevices.PerformLayout();
        flowRoomCards.ResumeLayout(false);
        card1.ResumeLayout(false);
        card1.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)card1_pic).EndInit();
        card2.ResumeLayout(false);
        card2.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)card2_pic).EndInit();
        card3.ResumeLayout(false);
        card3.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)card3_pic).EndInit();
        card4.ResumeLayout(false);
        card4.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)card4_pic).EndInit();
        card5.ResumeLayout(false);
        card5.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)card5_pic).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private TableLayoutPanel tableLayoutMain;
    private Panel panelHeader;
    private Label lblRoomsOverview, lblSubtitle;
    private FlowLayoutPanel flowStats, flowRoomCards;
    private Panel statRooms, statTemp, statLights, statDevices;
    private Label statRooms_val, statRooms_cap, statRooms_badge, statTemp_val, statTemp_cap, statLights_val, statLights_cap, statDevices_val, statDevices_cap;
    private Panel card1;
    private Label card1_status, card1_name, card1_desc, card1_temp, card1_counts;
    private Button card1_star; private PictureBox card1_pic;
    private Button card1_btn0, card1_btn1, card1_btn2, card1_btn3;
    private Panel card2;
    private Label card2_status, card2_name, card2_desc, card2_temp, card2_counts;
    private Button card2_star; private PictureBox card2_pic;
    private Button card2_btn0, card2_btn1, card2_btn2, card2_btn3;
    private Panel card3;
    private Label card3_status, card3_name, card3_desc, card3_temp, card3_counts;
    private Button card3_star; private PictureBox card3_pic;
    private Button card3_btn0, card3_btn1, card3_btn2, card3_btn3;
    private Panel card4;
    private Label card4_status, card4_name, card4_desc, card4_temp, card4_counts;
    private Button card4_star; private PictureBox card4_pic;
    private Button card4_btn0, card4_btn1, card4_btn2, card4_btn3;
    private Panel card5;
    private Label card5_status, card5_name, card5_desc, card5_temp, card5_counts;
    private Button card5_star; private PictureBox card5_pic;
    private Button card5_btn0, card5_btn1, card5_btn2, card5_btn3;
}
