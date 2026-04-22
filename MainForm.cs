using System;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Windows.Forms;
namespace BashiraliGSMUnlockTool
{
    public partial class MainForm : Form
    {
        private bool isDeviceConnected=false,operationRunning=false;
        private System.Windows.Forms.Timer connTimer=null!,clockTimer=null!;
        public MainForm(){InitializeComponent();Init();}
        private void Init(){
            connTimer=new System.Windows.Forms.Timer{Interval=4000};
            connTimer.Tick+=(s,e)=>{isDeviceConnected=new Random().Next(0,2)==1;UpdateStatus();};
            connTimer.Start();
            clockTimer=new System.Windows.Forms.Timer{Interval=1000};
            clockTimer.Tick+=(s,e)=>{if(lblClock!=null)lblClock.Text=DateTime.Now.ToString("dd-MM-yyyy  HH:mm:ss");};
            clockTimer.Start();
            Log("BASHIRALIGSM UNLOCK TOOL [v1.0.0.0]");
            Log("Initializing...");
            Log("Checking server connection... OK");
            Log("Waiting for device...");
        }
        private void UpdateStatus(){
            lblStatus.Text=isDeviceConnected?"● CONNECTED":"● NOT CONNECTED";
            lblStatus.ForeColor=isDeviceConnected?Color.LimeGreen:Color.OrangeRed;
            lblDeviceStatus.Text=isDeviceConnected?"DEVICE READY":"WAITING FOR DEVICE...";
        }
        private bool Chk(){
            if(!isDeviceConnected){Log("⚠ No device connected!");return false;}
            if(operationRunning){Log("⚠ Operation running!");return false;}
            return true;
        }
        private void Run(string name,int ms){
            operationRunning=true;
            progressBar.Value=0;
            lblOp.Text="Operation : "+name;
            lblStat.Text="Status : Running...";
            lblStat.ForeColor=Color.Yellow;
            for(int i=0;i<=100;i++){progressBar.Value=i;lblPct.Text=i+" %";Application.DoEvents();Thread.Sleep(ms/100);}
            lblStat.Text="Status : Completed ✓";
            lblStat.ForeColor=Color.LimeGreen;
            Log("✓ "+name+" completed!");
            progressBar.Value=0;lblPct.Text="0 %";lblOp.Text="Operation : ---";
            operationRunning=false;
        }
        public void Log(string msg){
            if(txtLog.InvokeRequired){txtLog.Invoke(new Action(()=>Log(msg)));return;}
            txtLog.AppendText("["+DateTime.Now.ToString("HH:mm:ss")+"] "+msg+Environment.NewLine);
            txtLog.ScrollToCaret();
        }
        private void BtnUnlockBootloader_Click(object? s,EventArgs e){if(Chk()){Log("Starting Bootloader Unlock...");Run("Unlock Bootloader",3000);}}
        private void BtnUnlockFRP_Click(object? s,EventArgs e){if(Chk()){Log("Starting FRP Unlock...");Run("FRP Unlock",2000);}}
        private void BtnUnlockNetwork_Click(object? s,EventArgs e){if(Chk()){Log("Network Unlock...");Run("Network Unlock",2500);}}
        private void BtnFactoryReset_Click(object? s,EventArgs e){if(MessageBox.Show("Factory Reset? All data erased!","Warning",MessageBoxButtons.YesNo,MessageBoxIcon.Warning)==DialogResult.Yes&&isDeviceConnected)Run("Factory Reset",4000);}
        private void BtnBypassFRP_Click(object? s,EventArgs e){if(Chk()){Log("Bypass FRP ADB...");Run("FRP Bypass ADB",1500);}}
        private void BypassMi_Click(object? s,EventArgs e){if(Chk()){Log("Bypass Mi Account...");Run("Mi Account Bypass",3000);}}
        private void BypassSamsung_Click(object? s,EventArgs e){if(Chk()){Log("Bypass Samsung Account...");Run("Samsung Account Bypass",2800);}}
        private void BypassHuawei_Click(object? s,EventArgs e){if(Chk()){Log("Bypass Huawei ID...");Run("Huawei ID Bypass",3200);}}
        private void BtnFlash_Click(object? s,EventArgs e){if(!Chk())return;var o=new OpenFileDialog{Filter="Firmware|*.tar;*.zip;*.bin|All|*.*"};if(o.ShowDialog()==DialogResult.OK){Log("Flashing: "+Path.GetFileName(o.FileName));Run("Flash Firmware",5000);}}
        private void BtnReadFW_Click(object? s,EventArgs e){if(!Chk())return;Run("Read Firmware",2000);Log("Version: G990BXXU1AVF1");Log("Build: 2024-01-15");}
        private void BtnWriteFW_Click(object? s,EventArgs e){if(!Chk())return;var o=new OpenFileDialog{Filter="Firmware|*.bin;*.img|All|*.*"};if(o.ShowDialog()==DialogResult.OK){Log("Writing: "+Path.GetFileName(o.FileName));Run("Write Firmware",4500);}}
        private void BtnReadInfo_Click(object? s,EventArgs e){if(!Chk())return;Run("Read Info",1500);Log("Device: SM-G990B");Log("Android: 13");Log("IMEI: 352634******123");Log("Status: Locked");}
        private void BtnReboot_Click(object? s,EventArgs e){if(Chk()){Log("Rebooting...");Run("Reboot Device",1000);}}
        private void BtnRemoveMi_Click(object? s,EventArgs e){if(Chk()){Log("Remove Mi Account...");Run("Remove Mi Account",2500);}}
        private void BtnOTA_Click(object? s,EventArgs e){if(Chk()){Log("Disabling OTA...");Run("Disable OTA",1800);Log("OTA disabled!");}}
        private void BtnStop_Click(object? s,EventArgs e){operationRunning=false;Log("⛔ Stopped.");lblStat.Text="Status : Stopped";lblStat.ForeColor=Color.OrangeRed;progressBar.Value=0;lblPct.Text="0 %";lblOp.Text="Operation : ---";}
        private void BtnClearLog_Click(object? s,EventArgs e){txtLog.Clear();Log("Log cleared!");}
        private void CmbDev_Changed(object? s,EventArgs e){if(cmbDev.SelectedItem!=null)Log("USB: "+cmbDev.SelectedItem);}
        private void CmbPort_Changed(object? s,EventArgs e){if(cmbPort.SelectedItem!=null)Log("COM: "+cmbPort.SelectedItem);}
    }
}
