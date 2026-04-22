using System;using System.Drawing;using System.Windows.Forms;
namespace BashiraliGSMUnlockTool{
partial class MainForm{
private System.ComponentModel.IContainer components=null!;
private Panel pHdr=null!,pBrands=null!,pSide=null!,pMain=null!,pRight=null!;
private Label lblTitle=null!,lblSub=null!,lblStatus=null!,lblDeviceStatus=null!;
private Label lblOp=null!,lblStat=null!,lblPct=null!,lblClock=null!;
private ComboBox cmbDev=null!,cmbPort=null!;
private TextBox txtLog=null!;
private Button btnStop=null!,btnClear=null!;
private ProgressBar progressBar=null!;
private Button bUB=null!,bUF=null!,bUN=null!,bFR=null!;
private Button bBF=null!,bBM=null!,bBS=null!,bBH=null!;
private Button bFF=null!,bRF=null!,bWF=null!;
private Button bRI=null!,bRB=null!,bRM=null!,bOTA=null!;
static readonly Color BG=Color.FromArgb(18,18,22),HDR=Color.FromArgb(12,12,16);
static readonly Color PNL=Color.FromArgb(25,25,30),SID=Color.FromArgb(20,20,25);
static readonly Color RED=Color.FromArgb(180,20,20),RED2=Color.FromArgb(220,30,30);
static readonly Color TXT=Color.FromArgb(230,230,235),DIM=Color.FromArgb(140,140,150);
static readonly Color BDR=Color.FromArgb(45,45,55),GRN=Color.FromArgb(0,200,80);
static readonly Color BTN=Color.FromArgb(32,32,40);
protected override void Dispose(bool d){if(d&&components!=null)components.Dispose();base.Dispose(d);}
private void InitializeComponent(){
this.SuspendLayout();
this.Text="BASHIRALIGSM UNLOCK TOOL";this.Size=new Size(1100,750);
this.BackColor=BG;this.FormBorderStyle=FormBorderStyle.FixedSingle;
this.MaximizeBox=false;this.StartPosition=FormStartPosition.CenterScreen;
H();Br();Si();Ma();Ri();Sb();
this.ResumeLayout(false);}
Button MB(string t,int x,int y,int w=290,int h=28){
var b=new Button{Text=t,Font=new Font("Consolas",8.5f),ForeColor=TXT,BackColor=BTN,FlatStyle=FlatStyle.Flat,Location=new Point(x,y),Size=new Size(w,h),TextAlign=ContentAlignment.MiddleLeft,Padding=new Padding(8,0,0,0),Cursor=Cursors.Hand,TabStop=false};
b.FlatAppearance.BorderColor=BDR;b.FlatAppearance.BorderSize=1;b.FlatAppearance.MouseOverBackColor=Color.FromArgb(40,40,50);return b;}
void H(){
pHdr=new Panel{BackColor=HDR,Dock=DockStyle.Top,Height=58};
pHdr.Controls.Add(new Label{Text="🔒",Font=new Font("Segoe UI Emoji",22f),ForeColor=RED2,Location=new Point(14,10),Size=new Size(42,38),TextAlign=ContentAlignment.MiddleCenter});
pHdr.Controls.Add(new Panel{BackColor=RED,Location=new Point(58,8),Size=new Size(3,42)});
lblTitle=new Label{Text="BASHIRALIGSM UNLOCK TOOL",Font=new Font("Consolas",15f,FontStyle.Bold),ForeColor=TXT,Location=new Point(68,8),Size=new Size(440,26)};
lblSub=new Label{Text="THE MASTER KEY TO YOUR DIGITAL ACCESS",Font=new Font("Consolas",7.5f),ForeColor=DIM,Location=new Point(68,34),Size=new Size(440,18)};
lblStatus=new Label{Text="● NOT CONNECTED",Font=new Font("Consolas",9f,FontStyle.Bold),ForeColor=Color.OrangeRed,Location=new Point(590,10),Size=new Size(230,18)};
lblDeviceStatus=new Label{Text="WAITING FOR DEVICE...",Font=new Font("Consolas",7f),ForeColor=DIM,Location=new Point(590,30),Size=new Size(230,16)};
var bL=new Button{Text="  Login",Font=new Font("Consolas",9f,FontStyle.Bold),ForeColor=TXT,BackColor=Color.FromArgb(38,38,48),FlatStyle=FlatStyle.Flat,Location=new Point(840,15),Size=new Size(80,28),Cursor=Cursors.Hand};
bL.FlatAppearance.BorderColor=BDR;
var bM=new Button{Text="≡",Font=new Font("Consolas",14f,FontStyle.Bold),ForeColor=TXT,BackColor=Color.FromArgb(38,38,48),FlatStyle=FlatStyle.Flat,Location=new Point(928,15),Size=new Size(36,28),Cursor=Cursors.Hand};
bM.FlatAppearance.BorderColor=BDR;
pHdr.Controls.AddRange(new Control[]{lblTitle,lblSub,lblStatus,lblDeviceStatus,bL,bM,new Panel{BackColor=RED,Dock=DockStyle.Bottom,Height=2}});
this.Controls.Add(pHdr);}
void Br(){
pBrands=new Panel{BackColor=Color.FromArgb(22,22,28),Location=new Point(0,58),Size=new Size(1100,36)};
string[]br={"SAMSUNG","XIAOMI","HUAWEI","OPPO","VIVO","REALME","TECNO","INFINIX","NOKIA","APPLE","MEDIATEK","···"};
Color[]bc={Color.FromArgb(30,120,230),Color.FromArgb(255,100,0),Color.FromArgb(200,0,0),Color.FromArgb(0,160,80),Color.FromArgb(0,120,210),Color.FromArgb(255,180,0),Color.FromArgb(0,180,200),Color.FromArgb(255,60,60),Color.FromArgb(0,150,220),Color.FromArgb(180,180,185),Color.FromArgb(120,80,200),Color.FromArgb(100,100,110)};
int x=8;
for(int i=0;i<br.Length;i++){int w=br[i]=="···"?36:br[i].Length>7?88:76;
var b=new Button{Text=br[i],Font=new Font("Consolas",8f,FontStyle.Bold),ForeColor=bc[i],BackColor=Color.FromArgb(30,30,38),FlatStyle=FlatStyle.Flat,Location=new Point(x,4),Size=new Size(w,26),Cursor=Cursors.Hand,TabStop=false};
b.FlatAppearance.BorderColor=Color.FromArgb(50,50,60);b.FlatAppearance.BorderSize=1;b.FlatAppearance.MouseOverBackColor=Color.FromArgb(42,42,52);
pBrands.Controls.Add(b);x+=w+4;}
pBrands.Controls.Add(new Panel{BackColor=BDR,Dock=DockStyle.Bottom,Height=1});
this.Controls.Add(pBrands);}
void Si(){
pSide=new Panel{BackColor=SID,Location=new Point(0,94),Size=new Size(155,608)};
pSide.Controls.Add(new Panel{BackColor=BDR,Dock=DockStyle.Right,Width=1});
var logo=new Panel{BackColor=Color.FromArgb(22,22,28),Location=new Point(10,10),Size=new Size(133,112)};
logo.Paint+=(s,e)=>{e.Graphics.SmoothingMode=System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
using var bg2=new SolidBrush(Color.FromArgb(35,35,42));e.Graphics.FillEllipse(bg2,16,5,100,100);
using var p=new Pen(RED,3);e.Graphics.DrawEllipse(p,16,5,100,100);
using var f=new Font("Segoe UI Emoji",34f);e.Graphics.DrawString("🦅",f,Brushes.White,new PointF(24,18));};
pSide.Controls.Add(logo);
string[]mi={"ℹ  INFO","🔓  UNLOCK","⬛  BYPASS","🛡  FRP TOOLS","📶  NETWORK","🔧  FLASH","💾  BACKUP","📊  DIAG TOOLS","⚙  SETTINGS"};
int y=130;bool first=true;
foreach(var m in mi){
var b=new Button{Text=m,Font=new Font("Consolas",8f,first?FontStyle.Bold:FontStyle.Regular),ForeColor=first?RED2:DIM,BackColor=first?Color.FromArgb(35,18,18):Color.Transparent,FlatStyle=FlatStyle.Flat,Location=new Point(0,y),Size=new Size(154,32),TextAlign=ContentAlignment.MiddleLeft,Padding=new Padding(12,0,0,0),Cursor=Cursors.Hand,TabStop=false};
b.FlatAppearance.BorderSize=0;b.FlatAppearance.MouseOverBackColor=Color.FromArgb(30,30,38);
if(first)pSide.Controls.Add(new Panel{BackColor=RED,Location=new Point(0,y),Size=new Size(3,32)});
pSide.Controls.Add(b);y+=33;first=false;}
pSide.Controls.Add(new Label{Text="Version 1.0.0.0",Font=new Font("Consolas",7f),ForeColor=DIM,Location=new Point(8,580),Size=new Size(140,16)});
this.Controls.Add(pSide);}
void Ma(){
pMain=new Panel{BackColor=BG,Location=new Point(155,94),Size=new Size(625,608)};
var tBar=new Panel{BackColor=Color.FromArgb(20,20,26),Location=new Point(0,0),Size=new Size(625,34)};
tBar.Controls.Add(new Panel{BackColor=BDR,Dock=DockStyle.Bottom,Height=1});
string[]tabs={"FUNCTIONS","DIAGNOSTIC","UTILITIES","ADVANCED"};int tx=0;bool tf=true;
foreach(var t in tabs){int tw=t.Length*9+22;
var tb=new Button{Text=t,Font=new Font("Consolas",8f,FontStyle.Bold),ForeColor=tf?TXT:DIM,BackColor=tf?Color.FromArgb(28,28,35):Color.Transparent,FlatStyle=FlatStyle.Flat,Location=new Point(tx,0),Size=new Size(tw,33),Cursor=Cursors.Hand,TabStop=false};
tb.FlatAppearance.BorderSize=0;tb.FlatAppearance.MouseOverBackColor=Color.FromArgb(30,30,38);
if(tf)tBar.Controls.Add(new Panel{BackColor=RED,Location=new Point(tx,31),Size=new Size(tw,2)});
tBar.Controls.Add(tb);tx+=tw+2;tf=false;}
pMain.Controls.Add(tBar);
pMain.Controls.Add(new Label{Text="UNLOCK",Font=new Font("Consolas",8f,FontStyle.Bold),ForeColor=DIM,Location=new Point(12,46),Size=new Size(290,18)});
bUB=MB("🔓  UNLOCK BOOTLOADER",12,68);bUF=MB("🔐  UNLOCK FRP",12,100);
bUN=MB("📶  UNLOCK NETWORK",12,132);bFR=MB("🔄  FACTORY RESET",12,164);
pMain.Controls.Add(new Label{Text="BYPASS",Font=new Font("Consolas",8f,FontStyle.Bold),ForeColor=DIM,Location=new Point(12,204),Size=new Size(290,18)});
bBF=MB("🤖  BYPASS FRP (ADB)",12,226);bBM=MB("  BYPASS MI ACCOUNT",12,258);
bBS=MB("  BYPASS SAMSUNG ACCOUNT",12,290);bBH=MB("  BYPASS HUAWEI ID",12,322);
pMain.Controls.Add(new Label{Text="FLASH",Font=new Font("Consolas",8f,FontStyle.Bold),ForeColor=DIM,Location=new Point(322,46),Size=new Size(290,18)});
bFF=MB("💾  FLASH FIRMWARE",322,68);bRF=MB("📖  READ FIRMWARE",322,100);bWF=MB("✏  WRITE FIRMWARE",322,132);
pMain.Controls.Add(new Label{Text="TOOLS",Font=new Font("Consolas",8f,FontStyle.Bold),ForeColor=DIM,Location=new Point(322,204),Size=new Size(290,18)});
bRI=MB("ℹ  READ INFO",322,226);bRB=MB("🔁  REBOOT DEVICE",322,258);
bRM=MB("  REMOVE MI ACCOUNT",322,290);bOTA=MB("🚫  DISABLE OTA UPDATE",322,322);
pMain.Controls.AddRange(new Control[]{bUB,bUF,bUN,bFR,bBF,bBM,bBS,bBH,bFF,bRF,bWF,bRI,bRB,bRM,bOTA});
pMain.Controls.Add(new Panel{BackColor=BDR,Location=new Point(308,36),Size=new Size(1,380)});
pMain.Controls.Add(new Panel{BackColor=BDR,Location=new Point(12,194),Size=new Size(288,1)});
pMain.Controls.Add(new Panel{BackColor=BDR,Location=new Point(322,194),Size=new Size(288,1)});
bUB.Click+=BtnUnlockBootloader_Click;bUF.Click+=BtnUnlockFRP_Click;bUN.Click+=BtnUnlockNetwork_Click;bFR.Click+=BtnFactoryReset_Click;
bBF.Click+=BtnBypassFRP_Click;bBM.Click+=BypassMi_Click;bBS.Click+=BypassSamsung_Click;bBH.Click+=BypassHuawei_Click;
bFF.Click+=BtnFlash_Click;bRF.Click+=BtnReadFW_Click;bWF.Click+=BtnWriteFW_Click;
bRI.Click+=BtnReadInfo_Click;bRB.Click+=BtnReboot_Click;bRM.Click+=BtnRemoveMi_Click;bOTA.Click+=BtnOTA_Click;
this.Controls.Add(pMain);}
void Ri(){
pRight=new Panel{BackColor=PNL,Location=new Point(780,94),Size=new Size(320,608)};
pRight.Controls.Add(new Panel{BackColor=BDR,Dock=DockStyle.Left,Width=1});
pRight.Controls.Add(new Label{Text="USB",Font=new Font("Consolas",8f,FontStyle.Bold),ForeColor=DIM,Location=new Point(12,14),Size=new Size(35,22),TextAlign=ContentAlignment.MiddleLeft});
cmbDev=new ComboBox{Font=new Font("Consolas",8f),ForeColor=TXT,BackColor=Color.FromArgb(30,30,38),FlatStyle=FlatStyle.Flat,Location=new Point(50,12),Size=new Size(155,24),DropDownStyle=ComboBoxStyle.DropDownList};
cmbDev.Items.AddRange(new object[]{"- Select Device -","Samsung","Xiaomi","Huawei","OPPO","VIVO"});cmbDev.SelectedIndex=0;cmbDev.SelectedIndexChanged+=CmbDev_Changed;
var bRef=new Button{Text="↻",Font=new Font("Consolas",12f,FontStyle.Bold),ForeColor=GRN,BackColor=Color.FromArgb(30,30,38),FlatStyle=FlatStyle.Flat,Location=new Point(210,12),Size=new Size(26,24),Cursor=Cursors.Hand,TabStop=false};bRef.FlatAppearance.BorderSize=0;
pRight.Controls.Add(new Label{Text="COM",Font=new Font("Consolas",8f,FontStyle.Bold),ForeColor=DIM,Location=new Point(12,44),Size=new Size(35,22),TextAlign=ContentAlignment.MiddleLeft});
cmbPort=new ComboBox{Font=new Font("Consolas",8f),ForeColor=TXT,BackColor=Color.FromArgb(30,30,38),FlatStyle=FlatStyle.Flat,Location=new Point(50,42),Size=new Size(125,24),DropDownStyle=ComboBoxStyle.DropDownList};
cmbPort.Items.AddRange(new object[]{"- Select Port -","COM1","COM2","COM3","COM4"});cmbPort.SelectedIndex=0;cmbPort.SelectedIndexChanged+=CmbPort_Changed;
var chk=new CheckBox{Text="Auto",Font=new Font("Consolas",8f),ForeColor=GRN,BackColor=Color.Transparent,Location=new Point(182,44),Size=new Size(60,22),Checked=true};
pRight.Controls.Add(new Panel{BackColor=BDR,Location=new Point(8,74),Size=new Size(304,1)});
pRight.Controls.Add(new Label{Text="LOG OUTPUT",Font=new Font("Consolas",8f,FontStyle.Bold),ForeColor=DIM,Location=new Point(12,82),Size=new Size(200,16)});
btnClear=new Button{Text="CLEAR",Font=new Font("Consolas",7f,FontStyle.Bold),ForeColor=DIM,BackColor=Color.FromArgb(30,30,38),FlatStyle=FlatStyle.Flat,Location=new Point(248,79),Size=new Size(56,20),Cursor=Cursors.Hand,TabStop=false};
btnClear.FlatAppearance.BorderColor=BDR;btnClear.FlatAppearance.BorderSize=1;btnClear.Click+=BtnClearLog_Click;
txtLog=new TextBox{Location=new Point(8,104),Multiline=true,ScrollBars=ScrollBars.Vertical,Size=new Size(304,330),BackColor=Color.FromArgb(10,10,14),ForeColor=GRN,Font=new Font("Consolas",8f),ReadOnly=true,BorderStyle=BorderStyle.FixedSingle};
lblOp=new Label{Text="Operation : ---",Font=new Font("Consolas",8f),ForeColor=DIM,Location=new Point(12,445),Size=new Size(300,18)};
lblStat=new Label{Text="Status : ---",Font=new Font("Consolas",8f),ForeColor=DIM,Location=new Point(12,465),Size=new Size(300,18)};
progressBar=new ProgressBar{Location=new Point(8,488),Size=new Size(264,18),Style=ProgressBarStyle.Continuous};
lblPct=new Label{Text="0 %",Font=new Font("Consolas",8f,FontStyle.Bold),ForeColor=TXT,Location=new Point(276,488),Size=new Size(36,18),TextAlign=ContentAlignment.MiddleRight};
btnStop=new Button{Text="◼  STOP",Font=new Font("Consolas",9f,FontStyle.Bold),ForeColor=TXT,BackColor=Color.FromArgb(140,15,15),FlatStyle=FlatStyle.Flat,Location=new Point(8,515),Size=new Size(304,36),Cursor=Cursors.Hand,TabStop=false};
btnStop.FlatAppearance.BorderColor=Color.FromArgb(180,20,20);btnStop.FlatAppearance.BorderSize=1;btnStop.FlatAppearance.MouseOverBackColor=Color.FromArgb(180,20,20);btnStop.Click+=BtnStop_Click;
pRight.Controls.AddRange(new Control[]{cmbDev,bRef,cmbPort,chk,btnClear,txtLog,lblOp,lblStat,progressBar,lblPct,btnStop});
this.Controls.Add(pRight);}
void Sb(){
var sb=new Panel{BackColor=Color.FromArgb(14,14,18),Location=new Point(0,702),Size=new Size(1100,28)};
sb.Controls.Add(new Panel{BackColor=BDR,Dock=DockStyle.Top,Height=1});
sb.Controls.Add(new Label{Text="✈  Telegram: bashiraligsm_support",Font=new Font("Consolas",7.5f),ForeColor=Color.FromArgb(0,160,220),Location=new Point(12,6),Size=new Size(220,16)});
sb.Controls.Add(new Label{Text="▶  BashiraliGSM Official",Font=new Font("Consolas",7.5f),ForeColor=Color.FromArgb(220,40,40),Location=new Point(240,6),Size=new Size(170,16)});
sb.Controls.Add(new Label{Text="👤  User  |  Guest",Font=new Font("Consolas",7.5f),ForeColor=DIM,Location=new Point(430,6),Size=new Size(130,16)});
sb.Controls.Add(new Label{Text="DESKTOP-UNLOCK",Font=new Font("Consolas",7.5f),ForeColor=DIM,Location=new Point(790,6),Size=new Size(140,16),TextAlign=ContentAlignment.MiddleRight});
lblClock=new Label{Text=DateTime.Now.ToString("dd-MM-yyyy  HH:mm:ss"),Font=new Font("Consolas",7.5f),ForeColor=DIM,Location=new Point(940,6),Size=new Size(150,16),TextAlign=ContentAlignment.MiddleRight};
sb.Controls.Add(lblClock);
this.Controls.Add(sb);}
}}
