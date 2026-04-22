namespace BashiraliGSMUnlockTool
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Label lblConnectionStatus;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblDeviceStatus;
        private System.Windows.Forms.Panel panelBrands;
        private System.Windows.Forms.Label lblBrands;
        private System.Windows.Forms.GroupBox groupBoxFunctions;
        private System.Windows.Forms.GroupBox groupBoxUnlock;
        private System.Windows.Forms.GroupBox groupBoxFlash;
        private System.Windows.Forms.GroupBox groupBoxTools;
        private System.Windows.Forms.Button btnUnlockBootloader;
        private System.Windows.Forms.Button btnUnlockFRP;
        private System.Windows.Forms.Button btnUnlockNetwork;
        private System.Windows.Forms.Button btnFactoryReset;
        private System.Windows.Forms.Button btnBypassFRP;
        private System.Windows.Forms.Button btnBypassMiAccount;
        private System.Windows.Forms.Button btnBypassSamsung;
        private System.Windows.Forms.Button btnBypassHuawei;
        private System.Windows.Forms.Button btnFlashFirmware;
        private System.Windows.Forms.Button btnReadFirmware;
        private System.Windows.Forms.Button btnWriteFirmware;
        private System.Windows.Forms.Button btnReadInfo;
        private System.Windows.Forms.Button btnBootDevice;
        private System.Windows.Forms.Button btnDisableOTA;
        private System.Windows.Forms.ComboBox cmbSelectDevice;
        private System.Windows.Forms.ComboBox cmbSelectPort;
        private System.Windows.Forms.Label lblUSB;
        private System.Windows.Forms.Label lblCOM;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.Button btnClearLog;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label lblOperation;
        private System.Windows.Forms.Label lblStatusOperation;
        private System.Windows.Forms.Label lblPercent;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.lblConnectionStatus = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblDeviceStatus = new System.Windows.Forms.Label();
            this.panelBrands = new System.Windows.Forms.Panel();
            this.lblBrands = new System.Windows.Forms.Label();
            this.groupBoxFunctions = new System.Windows.Forms.GroupBox();
            this.groupBoxUnlock = new System.Windows.Forms.GroupBox();
            this.btnUnlockBootloader = new System.Windows.Forms.Button();
            this.btnUnlockFRP = new System.Windows.Forms.Button();
            this.btnUnlockNetwork = new System.Windows.Forms.Button();
            this.btnFactoryReset = new System.Windows.Forms.Button();
            this.btnBypassFRP = new System.Windows.Forms.Button();
            this.btnBypassMiAccount = new System.Windows.Forms.Button();
            this.btnBypassSamsung = new System.Windows.Forms.Button();
            this.btnBypassHuawei = new System.Windows.Forms.Button();
            this.groupBoxFlash = new System.Windows.Forms.GroupBox();
            this.btnFlashFirmware = new System.Windows.Forms.Button();
            this.btnReadFirmware = new System.Windows.Forms.Button();
            this.btnWriteFirmware = new System.Windows.Forms.Button();
            this.groupBoxTools = new System.Windows.Forms.GroupBox();
            this.btnReadInfo = new System.Windows.Forms.Button();
            this.btnBootDevice = new System.Windows.Forms.Button();
            this.btnDisableOTA = new System.Windows.Forms.Button();
            this.cmbSelectDevice = new System.Windows.Forms.ComboBox();
            this.cmbSelectPort = new System.Windows.Forms.ComboBox();
            this.lblUSB = new System.Windows.Forms.Label();
            this.lblCOM = new System.Windows.Forms.Label();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.btnClearLog = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.lblOperation = new System.Windows.Forms.Label();
            this.lblStatusOperation = new System.Windows.Forms.Label();
            this.lblPercent = new System.Windows.Forms.Label();
            this.panelHeader.SuspendLayout();
            this.panelBrands.SuspendLayout();
            this.groupBoxFunctions.SuspendLayout();
            this.groupBoxUnlock.SuspendLayout();
            this.groupBoxFlash.SuspendLayout();
            this.groupBoxTools.SuspendLayout();
            this.SuspendLayout();

            // panelHeader
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(0, 51, 102);
            this.panelHeader.Controls.Add(this.lblTitle);
            this.panelHeader.Controls.Add(this.lblSubtitle);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(900, 80);
            this.panelHeader.TabIndex = 0;

            // lblTitle
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(20, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(320, 32);
            this.lblTitle.Text = "BASHIRALIGSM UNLOCK TOOL";
            
            // lblSubtitle
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            this.lblSubtitle.ForeColor = System.Drawing.Color.LightGray;
            this.lblSubtitle.Location = new System.Drawing.Point(22, 55);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Text = "THE MASTER KEY TO YOUR DIGITAL ACCESS";

            // lblConnectionStatus
            this.lblConnectionStatus.AutoSize = true;
            this.lblConnectionStatus.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblConnectionStatus.Location = new System.Drawing.Point(700, 15);
            this.lblConnectionStatus.Name = "lblConnectionStatus";
            this.lblConnectionStatus.Text = "STATUS:";
            
            // lblStatus
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblStatus.Location = new System.Drawing.Point(700, 35);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Text = "NOT CONNECTED";
            this.lblStatus.ForeColor = System.Drawing.Color.OrangeRed;

            // lblDeviceStatus
            this.lblDeviceStatus.AutoSize = true;
            this.lblDeviceStatus.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblDeviceStatus.Location = new System.Drawing.Point(700, 55);
            this.lblDeviceStatus.Name = "lblDeviceStatus";
            this.lblDeviceStatus.Text = "WAITING FOR DEVICE...";

            // panelBrands
            this.panelBrands.BackColor = System.Drawing.Color.FromArgb(45, 45, 48);
            this.panelBrands.Controls.Add(this.lblBrands);
            this.panelBrands.Location = new System.Drawing.Point(0, 80);
            this.panelBrands.Name = "panelBrands";
            this.panelBrands.Size = new System.Drawing.Size(900, 30);
            
            // lblBrands
            this.lblBrands.AutoSize = true;
            this.lblBrands.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblBrands.ForeColor = System.Drawing.Color.Gold;
            this.lblBrands.Location = new System.Drawing.Point(20, 8);
            this.lblBrands.Text = "SAMSUNG | XIAOMI | HUAWEI | OPPO | VIVO | REALME | TECNO | INFINIX | NOKIA | APPLE | MEDIATEK";

            // groupBoxFunctions
            this.groupBoxFunctions.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.groupBoxFunctions.ForeColor = System.Drawing.Color.White;
            this.groupBoxFunctions.Location = new System.Drawing.Point(12, 120);
            this.groupBoxFunctions.Name = "groupBoxFunctions";
            this.groupBoxFunctions.Size = new System.Drawing.Size(876, 280);
            this.groupBoxFunctions.TabIndex = 1;
            this.groupBoxFunctions.TabStop = false;
            this.groupBoxFunctions.Text = "FUNCTIONS";

            // groupBoxUnlock
            this.groupBoxUnlock.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.groupBoxUnlock.ForeColor = System.Drawing.Color.Cyan;
            this.groupBoxUnlock.Location = new System.Drawing.Point(20, 145);
            this.groupBoxUnlock.Name = "groupBoxUnlock";
            this.groupBoxUnlock.Size = new System.Drawing.Size(280, 200);
            this.groupBoxUnlock.Text = "UNLOCK";
            
            // Buttons for Unlock
            this.btnUnlockBootloader = CreateButton("UNLOCK BOOTLOADER", 25, 25);
            this.btnUnlockFRP = CreateButton("UNLOCK FRP", 25, 55);
            this.btnUnlockNetwork = CreateButton("UNLOCK NETWORK", 25, 85);
            this.btnFactoryReset = CreateButton("FACTORY RESET", 25, 115);
            this.btnBypassFRP = CreateButton("BYPASS FRP (ADB)", 25, 145);
            this.btnBypassMiAccount = CreateButton("BYPASS MI ACCOUNT", 25, 175);
            this.btnBypassSamsung = CreateButton("BYPASS SAMSUNG ACCOUNT", 25, 205);
            this.btnBypassHuawei = CreateButton("BYPASS HUAWEI ID", 25, 235);
            
            this.groupBoxUnlock.Controls.Add(this.btnUnlockBootloader);
            this.groupBoxUnlock.Controls.Add(this.btnUnlockFRP);
            this.groupBoxUnlock.Controls.Add(this.btnUnlockNetwork);
            this.groupBoxUnlock.Controls.Add(this.btnFactoryReset);
            this.groupBoxUnlock.Controls.Add(this.btnBypassFRP);
            this.groupBoxUnlock.Controls.Add(this.btnBypassMiAccount);
            this.groupBoxUnlock.Controls.Add(this.btnBypassSamsung);
            this.groupBoxUnlock.Controls.Add(this.btnBypassHuawei);

            // groupBoxFlash
            this.groupBoxFlash.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.groupBoxFlash.ForeColor = System.Drawing.Color.Lime;
            this.groupBoxFlash.Location = new System.Drawing.Point(310, 145);
            this.groupBoxFlash.Name = "groupBoxFlash";
            this.groupBoxFlash.Size = new System.Drawing.Size(250, 200);
            this.groupBoxFlash.Text = "FLASH";
            
            this.btnFlashFirmware = CreateButton("FLASH FIRMWARE", 25, 30);
            this.btnReadFirmware = CreateButton("READ FIRMWARE", 25, 65);
            this.btnWriteFirmware = CreateButton("WRITE FIRMWARE", 25, 100);
            
            this.groupBoxFlash.Controls.Add(this.btnFlashFirmware);
            this.groupBoxFlash.Controls.Add(this.btnReadFirmware);
            this.groupBoxFlash.Controls.Add(this.btnWriteFirmware);

            // groupBoxTools
            this.groupBoxTools.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.groupBoxTools.ForeColor = System.Drawing.Color.Yellow;
            this.groupBoxTools.Location = new System.Drawing.Point(570, 145);
            this.groupBoxTools.Name = "groupBoxTools";
            this.groupBoxTools.Size = new System.Drawing.Size(300, 200);
            this.groupBoxTools.Text = "TOOLS";
            
            this.btnReadInfo = CreateButton("READ INFO", 25, 30);
            this.btnBootDevice = CreateButton("BOOT DEVICE", 25, 65);
            this.btnDisableOTA = CreateButton("DISABLE OTA UPDATE", 25, 100);
            
            this.groupBoxTools.Controls.Add(this.btnReadInfo);
            this.groupBoxTools.Controls.Add(this.btnBootDevice);
            this.groupBoxTools.Controls.Add(this.btnDisableOTA);

            // USB and COM
            this.lblUSB = new System.Windows.Forms.Label();
            this.lblUSB.Text = "USB:";
            this.lblUSB.Location = new System.Drawing.Point(20, 365);
            this.lblUSB.Size = new System.Drawing.Size(40, 20);
            
            this.cmbSelectDevice = new System.Windows.Forms.ComboBox();
            this.cmbSelectDevice.Location = new System.Drawing.Point(60, 362);
            this.cmbSelectDevice.Size = new System.Drawing.Size(150, 25);
            this.cmbSelectDevice.Items.AddRange(new object[] { "Auto Detect", "Samsung", "Xiaomi", "Huawei", "OPPO", "VIVO" });
            this.cmbSelectDevice.SelectedIndex = 0;
            this.cmbSelectDevice.SelectedIndexChanged += new System.EventHandler(this.CmbSelectDevice_SelectedIndexChanged);
            
            this.lblCOM = new System.Windows.Forms.Label();
            this.lblCOM.Text = "COM:";
            this.lblCOM.Location = new System.Drawing.Point(240, 365);
            this.lblCOM.Size = new System.Drawing.Size(40, 20);
            
            this.cmbSelectPort = new System.Windows.Forms.ComboBox();
            this.cmbSelectPort.Location = new System.Drawing.Point(280, 362);
            this.cmbSelectPort.Size = new System.Drawing.Size(150, 25);
            this.cmbSelectPort.Items.AddRange(new object[] { "Auto", "COM1", "COM2", "COM3", "COM4" });
            this.cmbSelectPort.SelectedIndex = 0;
            this.cmbSelectPort.SelectedIndexChanged += new System.EventHandler(this.CmbSelectPort_SelectedIndexChanged);

            // Log TextBox
            this.txtLog = new System.Windows.Forms.TextBox();
            this.txtLog.Location = new System.Drawing.Point(12, 400);
            this.txtLog.Multiline = true;
            this.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLog.Size = new System.Drawing.Size(700, 150);
            this.txtLog.BackColor = System.Drawing.Color.Black;
            this.txtLog.ForeColor = System.Drawing.Color.Lime;
            this.txtLog.Font = new System.Drawing.Font("Consolas", 9F);
            this.txtLog.ReadOnly = true;

            // Progress Bar
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.progressBar.Location = new System.Drawing.Point(12, 570);
            this.progressBar.Size = new System.Drawing.Size(700, 25);
            
            this.lblOperation = new System.Windows.Forms.Label();
            this.lblOperation.Text = "Operation : ---";
            this.lblOperation.Location = new System.Drawing.Point(12, 605);
            this.lblOperation.Size = new System.Drawing.Size(200, 20);
            
            this.lblStatusOperation = new System.Windows.Forms.Label();
            this.lblStatusOperation.Text = "Status : ---";
            this.lblStatusOperation.Location = new System.Drawing.Point(250, 605);
            this.lblStatusOperation.Size = new System.Drawing.Size(200, 20);
            
            this.lblPercent = new System.Windows.Forms.Label();
            this.lblPercent.Text = "0 %";
            this.lblPercent.Location = new System.Drawing.Point(680, 570);
            this.lblPercent.Size = new System.Drawing.Size(40, 25);

            // Buttons Stop and Clear Log
            this.btnStop = new System.Windows.Forms.Button();
            this.btnStop.Text = "STOP";
            this.btnStop.BackColor = System.Drawing.Color.DarkRed;
            this.btnStop.ForeColor = System.Drawing.Color.White;
            this.btnStop.Location = new System.Drawing.Point(730, 400);
            this.btnStop.Size = new System.Drawing.Size(150, 40);
            this.btnStop.Click += new System.EventHandler(this.BtnStop_Click);
            
            this.btnClearLog = new System.Windows.Forms.Button();
            this.btnClearLog.Text = "CLEAR LOG";
            this.btnClearLog.BackColor = System.Drawing.Color.Gray;
            this.btnClearLog.ForeColor = System.Drawing.Color.White;
            this.btnClearLog.Location = new System.Drawing.Point(730, 460);
            this.btnClearLog.Size = new System.Drawing.Size(150, 40);
            this.btnClearLog.Click += new System.EventHandler(this.BtnClearLog_Click);

            // Add controls to form
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.lblConnectionStatus);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblDeviceStatus);
            this.Controls.Add(this.panelBrands);
            this.Controls.Add(this.groupBoxFunctions);
            this.Controls.Add(this.groupBoxUnlock);
            this.Controls.Add(this.groupBoxFlash);
            this.Controls.Add(this.groupBoxTools);
            this.Controls.Add(this.lblUSB);
            this.Controls.Add(this.cmbSelectDevice);
            this.Controls.Add(this.lblCOM);
            this.Controls.Add(this.cmbSelectPort);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.lblOperation);
            this.Controls.Add(this.lblStatusOperation);
            this.Controls.Add(this.lblPercent);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnClearLog);

            // Event handlers
            this.btnUnlockBootloader.Click += new System.EventHandler(this.BtnUnlockBootloader_Click);
            this.btnUnlockFRP.Click += new System.EventHandler(this.BtnUnlockFRP_Click);
            this.btnUnlockNetwork.Click += new System.EventHandler(this.BtnUnlockNetwork_Click);
            this.btnFactoryReset.Click += new System.EventHandler(this.BtnFactoryReset_Click);
            this.btnBypassFRP.Click += new System.EventHandler(this.BtnBypassFRP_Click);
            this.btnBypassMiAccount.Click += new System.EventHandler(this.BypassMiAccount_Click);
            this.btnBypassSamsung.Click += new System.EventHandler(this.BypassSamsungAccount_Click);
            this.btnBypassHuawei.Click += new System.EventHandler(this.BypassHuaweiID_Click);
            this.btnFlashFirmware.Click += new System.EventHandler(this.BtnFlashFirmware_Click);
            this.btnReadFirmware.Click += new System.EventHandler(this.BtnReadFirmware_Click);
            this.btnWriteFirmware.Click += new System.EventHandler(this.BtnWriteFirmware_Click);
            this.btnReadInfo.Click += new System.EventHandler(this.BtnReadInfo_Click);
            this.btnBootDevice.Click += new System.EventHandler(this.BtnBootDevice_Click);
            this.btnDisableOTA.Click += new System.EventHandler(this.BtnDisableOTA_Click);

            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button CreateButton(string text, int x, int y)
        {
            Button btn = new System.Windows.Forms.Button();
            btn.Text = text;
            btn.Location = new System.Drawing.Point(x, y);
            btn.Size = new System.Drawing.Size(230, 25);
            btn.BackColor = System.Drawing.Color.FromArgb(60, 60, 65);
            btn.ForeColor = System.Drawing.Color.White;
            btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular);
            return btn;
        }
    }
}
