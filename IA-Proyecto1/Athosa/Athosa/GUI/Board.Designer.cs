using System.Drawing;

namespace Athosa.GUI
{
    partial class Board
    {

        public int horizontal;
        public int vertical;
        
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

        public void InitializeComponent()//int sizeHorizontal, int sizeVertical)
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Board));
            this.panel = new System.Windows.Forms.Panel();
            this.pictureBox84 = new System.Windows.Forms.PictureBox();
            this.pictureBox86 = new System.Windows.Forms.PictureBox();
            this.pictureBox87 = new System.Windows.Forms.PictureBox();
            this.pictureBox88 = new System.Windows.Forms.PictureBox();
            this.pictureBox93 = new System.Windows.Forms.PictureBox();
            this.pictureBox94 = new System.Windows.Forms.PictureBox();
            this.pictureBox95 = new System.Windows.Forms.PictureBox();
            this.pictureBox96 = new System.Windows.Forms.PictureBox();
            this.pictureBox97 = new System.Windows.Forms.PictureBox();
            this.pictureBox72 = new System.Windows.Forms.PictureBox();
            this.pictureBox73 = new System.Windows.Forms.PictureBox();
            this.pictureBox74 = new System.Windows.Forms.PictureBox();
            this.pictureBox75 = new System.Windows.Forms.PictureBox();
            this.pictureBox76 = new System.Windows.Forms.PictureBox();
            this.pictureBox77 = new System.Windows.Forms.PictureBox();
            this.pictureBox78 = new System.Windows.Forms.PictureBox();
            this.pictureBox79 = new System.Windows.Forms.PictureBox();
            this.pictureBox80 = new System.Windows.Forms.PictureBox();
            this.pictureBox81 = new System.Windows.Forms.PictureBox();
            this.pictureBox82 = new System.Windows.Forms.PictureBox();
            this.pictureBox83 = new System.Windows.Forms.PictureBox();
            this.pictureBox56 = new System.Windows.Forms.PictureBox();
            this.pictureBox57 = new System.Windows.Forms.PictureBox();
            this.pictureBox58 = new System.Windows.Forms.PictureBox();
            this.pictureBox59 = new System.Windows.Forms.PictureBox();
            this.pictureBox60 = new System.Windows.Forms.PictureBox();
            this.pictureBox61 = new System.Windows.Forms.PictureBox();
            this.pictureBox62 = new System.Windows.Forms.PictureBox();
            this.pictureBox63 = new System.Windows.Forms.PictureBox();
            this.pictureBox64 = new System.Windows.Forms.PictureBox();
            this.pictureBox65 = new System.Windows.Forms.PictureBox();
            this.pictureBox66 = new System.Windows.Forms.PictureBox();
            this.pictureBox67 = new System.Windows.Forms.PictureBox();
            this.pictureBox68 = new System.Windows.Forms.PictureBox();
            this.pictureBox69 = new System.Windows.Forms.PictureBox();
            this.pictureBox42 = new System.Windows.Forms.PictureBox();
            this.pictureBox43 = new System.Windows.Forms.PictureBox();
            this.pictureBox44 = new System.Windows.Forms.PictureBox();
            this.pictureBox45 = new System.Windows.Forms.PictureBox();
            this.pictureBox46 = new System.Windows.Forms.PictureBox();
            this.pictureBox47 = new System.Windows.Forms.PictureBox();
            this.pictureBox48 = new System.Windows.Forms.PictureBox();
            this.pictureBox49 = new System.Windows.Forms.PictureBox();
            this.pictureBox50 = new System.Windows.Forms.PictureBox();
            this.pictureBox51 = new System.Windows.Forms.PictureBox();
            this.pictureBox52 = new System.Windows.Forms.PictureBox();
            this.pictureBox53 = new System.Windows.Forms.PictureBox();
            this.pictureBox54 = new System.Windows.Forms.PictureBox();
            this.pictureBox55 = new System.Windows.Forms.PictureBox();
            this.pictureBox28 = new System.Windows.Forms.PictureBox();
            this.pictureBox29 = new System.Windows.Forms.PictureBox();
            this.pictureBox30 = new System.Windows.Forms.PictureBox();
            this.pictureBox31 = new System.Windows.Forms.PictureBox();
            this.pictureBox32 = new System.Windows.Forms.PictureBox();
            this.pictureBox33 = new System.Windows.Forms.PictureBox();
            this.pictureBox34 = new System.Windows.Forms.PictureBox();
            this.pictureBox35 = new System.Windows.Forms.PictureBox();
            this.pictureBox36 = new System.Windows.Forms.PictureBox();
            this.pictureBox37 = new System.Windows.Forms.PictureBox();
            this.pictureBox38 = new System.Windows.Forms.PictureBox();
            this.pictureBox39 = new System.Windows.Forms.PictureBox();
            this.pictureBox40 = new System.Windows.Forms.PictureBox();
            this.pictureBox41 = new System.Windows.Forms.PictureBox();
            this.pictureBox14 = new System.Windows.Forms.PictureBox();
            this.pictureBox15 = new System.Windows.Forms.PictureBox();
            this.pictureBox16 = new System.Windows.Forms.PictureBox();
            this.pictureBox17 = new System.Windows.Forms.PictureBox();
            this.pictureBox18 = new System.Windows.Forms.PictureBox();
            this.pictureBox19 = new System.Windows.Forms.PictureBox();
            this.pictureBox20 = new System.Windows.Forms.PictureBox();
            this.pictureBox21 = new System.Windows.Forms.PictureBox();
            this.pictureBox22 = new System.Windows.Forms.PictureBox();
            this.pictureBox23 = new System.Windows.Forms.PictureBox();
            this.pictureBox24 = new System.Windows.Forms.PictureBox();
            this.pictureBox25 = new System.Windows.Forms.PictureBox();
            this.pictureBox26 = new System.Windows.Forms.PictureBox();
            this.pictureBox27 = new System.Windows.Forms.PictureBox();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.pictureBox13 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.start = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.horizontalScrollbar = new System.Windows.Forms.HScrollBar();
            this.verticalScrollbar = new System.Windows.Forms.VScrollBar();
            this.pictureBox70 = new System.Windows.Forms.PictureBox();
            this.pictureBox71 = new System.Windows.Forms.PictureBox();
            this.pictureBox85 = new System.Windows.Forms.PictureBox();
            this.pictureBox89 = new System.Windows.Forms.PictureBox();
            this.pictureBox90 = new System.Windows.Forms.PictureBox();
            this.pictureBox91 = new System.Windows.Forms.PictureBox();
            this.pictureBox92 = new System.Windows.Forms.PictureBox();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox84)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox86)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox87)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox88)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox93)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox94)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox95)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox96)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox97)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox72)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox73)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox74)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox75)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox76)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox77)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox78)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox79)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox80)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox81)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox82)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox83)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox56)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox57)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox58)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox59)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox60)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox61)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox62)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox63)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox64)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox65)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox66)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox67)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox68)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox69)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox42)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox43)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox44)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox45)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox46)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox47)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox48)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox49)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox50)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox51)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox52)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox53)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox54)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox55)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox28)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox29)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox30)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox31)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox32)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox33)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox34)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox35)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox36)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox37)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox38)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox39)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox40)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox41)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox19)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox20)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox22)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox23)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox24)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox25)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox26)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox27)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.start)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox70)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox71)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox85)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox89)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox90)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox91)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox92)).BeginInit();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel.BackgroundImage")));
            this.panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel.Controls.Add(this.pictureBox89);
            this.panel.Controls.Add(this.pictureBox90);
            this.panel.Controls.Add(this.pictureBox91);
            this.panel.Controls.Add(this.pictureBox92);
            this.panel.Controls.Add(this.pictureBox85);
            this.panel.Controls.Add(this.pictureBox71);
            this.panel.Controls.Add(this.pictureBox70);
            this.panel.Controls.Add(this.pictureBox84);
            this.panel.Controls.Add(this.pictureBox86);
            this.panel.Controls.Add(this.pictureBox87);
            this.panel.Controls.Add(this.pictureBox88);
            this.panel.Controls.Add(this.pictureBox93);
            this.panel.Controls.Add(this.pictureBox94);
            this.panel.Controls.Add(this.pictureBox95);
            this.panel.Controls.Add(this.pictureBox96);
            this.panel.Controls.Add(this.pictureBox97);
            this.panel.Controls.Add(this.pictureBox72);
            this.panel.Controls.Add(this.pictureBox73);
            this.panel.Controls.Add(this.pictureBox74);
            this.panel.Controls.Add(this.pictureBox75);
            this.panel.Controls.Add(this.pictureBox76);
            this.panel.Controls.Add(this.pictureBox77);
            this.panel.Controls.Add(this.pictureBox78);
            this.panel.Controls.Add(this.pictureBox79);
            this.panel.Controls.Add(this.pictureBox80);
            this.panel.Controls.Add(this.pictureBox81);
            this.panel.Controls.Add(this.pictureBox82);
            this.panel.Controls.Add(this.pictureBox83);
            this.panel.Controls.Add(this.pictureBox56);
            this.panel.Controls.Add(this.pictureBox57);
            this.panel.Controls.Add(this.pictureBox58);
            this.panel.Controls.Add(this.pictureBox59);
            this.panel.Controls.Add(this.pictureBox60);
            this.panel.Controls.Add(this.pictureBox61);
            this.panel.Controls.Add(this.pictureBox62);
            this.panel.Controls.Add(this.pictureBox63);
            this.panel.Controls.Add(this.pictureBox64);
            this.panel.Controls.Add(this.pictureBox65);
            this.panel.Controls.Add(this.pictureBox66);
            this.panel.Controls.Add(this.pictureBox67);
            this.panel.Controls.Add(this.pictureBox68);
            this.panel.Controls.Add(this.pictureBox69);
            this.panel.Controls.Add(this.pictureBox42);
            this.panel.Controls.Add(this.pictureBox43);
            this.panel.Controls.Add(this.pictureBox44);
            this.panel.Controls.Add(this.pictureBox45);
            this.panel.Controls.Add(this.pictureBox46);
            this.panel.Controls.Add(this.pictureBox47);
            this.panel.Controls.Add(this.pictureBox48);
            this.panel.Controls.Add(this.pictureBox49);
            this.panel.Controls.Add(this.pictureBox50);
            this.panel.Controls.Add(this.pictureBox51);
            this.panel.Controls.Add(this.pictureBox52);
            this.panel.Controls.Add(this.pictureBox53);
            this.panel.Controls.Add(this.pictureBox54);
            this.panel.Controls.Add(this.pictureBox55);
            this.panel.Controls.Add(this.pictureBox28);
            this.panel.Controls.Add(this.pictureBox29);
            this.panel.Controls.Add(this.pictureBox30);
            this.panel.Controls.Add(this.pictureBox31);
            this.panel.Controls.Add(this.pictureBox32);
            this.panel.Controls.Add(this.pictureBox33);
            this.panel.Controls.Add(this.pictureBox34);
            this.panel.Controls.Add(this.pictureBox35);
            this.panel.Controls.Add(this.pictureBox36);
            this.panel.Controls.Add(this.pictureBox37);
            this.panel.Controls.Add(this.pictureBox38);
            this.panel.Controls.Add(this.pictureBox39);
            this.panel.Controls.Add(this.pictureBox40);
            this.panel.Controls.Add(this.pictureBox41);
            this.panel.Controls.Add(this.pictureBox14);
            this.panel.Controls.Add(this.pictureBox15);
            this.panel.Controls.Add(this.pictureBox16);
            this.panel.Controls.Add(this.pictureBox17);
            this.panel.Controls.Add(this.pictureBox18);
            this.panel.Controls.Add(this.pictureBox19);
            this.panel.Controls.Add(this.pictureBox20);
            this.panel.Controls.Add(this.pictureBox21);
            this.panel.Controls.Add(this.pictureBox22);
            this.panel.Controls.Add(this.pictureBox23);
            this.panel.Controls.Add(this.pictureBox24);
            this.panel.Controls.Add(this.pictureBox25);
            this.panel.Controls.Add(this.pictureBox26);
            this.panel.Controls.Add(this.pictureBox27);
            this.panel.Controls.Add(this.pictureBox12);
            this.panel.Controls.Add(this.pictureBox13);
            this.panel.Controls.Add(this.pictureBox9);
            this.panel.Controls.Add(this.pictureBox10);
            this.panel.Controls.Add(this.pictureBox11);
            this.panel.Controls.Add(this.pictureBox8);
            this.panel.Controls.Add(this.pictureBox7);
            this.panel.Controls.Add(this.pictureBox6);
            this.panel.Controls.Add(this.pictureBox5);
            this.panel.Controls.Add(this.pictureBox4);
            this.panel.Controls.Add(this.pictureBox3);
            this.panel.Controls.Add(this.pictureBox2);
            this.panel.Controls.Add(this.start);
            this.panel.Controls.Add(this.pictureBox1);
            this.panel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel.Location = new System.Drawing.Point(-1, -1);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(690, 340);
            this.panel.TabIndex = 0;
            // 
            // pictureBox84
            // 
            this.pictureBox84.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox84.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox84.BackgroundImage")));
            this.pictureBox84.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox84.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox84.Location = new System.Drawing.Point(597, 244);
            this.pictureBox84.Name = "pictureBox84";
            this.pictureBox84.Size = new System.Drawing.Size(50, 50);
            this.pictureBox84.TabIndex = 97;
            this.pictureBox84.TabStop = false;
            // 
            // pictureBox86
            // 
            this.pictureBox86.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox86.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox86.BackgroundImage")));
            this.pictureBox86.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox86.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox86.Location = new System.Drawing.Point(548, 244);
            this.pictureBox86.Name = "pictureBox86";
            this.pictureBox86.Size = new System.Drawing.Size(50, 50);
            this.pictureBox86.TabIndex = 95;
            this.pictureBox86.TabStop = false;
            // 
            // pictureBox87
            // 
            this.pictureBox87.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox87.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox87.BackgroundImage")));
            this.pictureBox87.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox87.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox87.Location = new System.Drawing.Point(498, 244);
            this.pictureBox87.Name = "pictureBox87";
            this.pictureBox87.Size = new System.Drawing.Size(50, 50);
            this.pictureBox87.TabIndex = 94;
            this.pictureBox87.TabStop = false;
            // 
            // pictureBox88
            // 
            this.pictureBox88.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox88.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox88.Location = new System.Drawing.Point(448, 295);
            this.pictureBox88.Name = "pictureBox88";
            this.pictureBox88.Size = new System.Drawing.Size(50, 50);
            this.pictureBox88.TabIndex = 93;
            this.pictureBox88.TabStop = false;
            // 
            // pictureBox93
            // 
            this.pictureBox93.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox93.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox93.Location = new System.Drawing.Point(199, 295);
            this.pictureBox93.Name = "pictureBox93";
            this.pictureBox93.Size = new System.Drawing.Size(50, 50);
            this.pictureBox93.TabIndex = 88;
            this.pictureBox93.TabStop = false;
            // 
            // pictureBox94
            // 
            this.pictureBox94.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox94.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox94.Location = new System.Drawing.Point(149, 295);
            this.pictureBox94.Name = "pictureBox94";
            this.pictureBox94.Size = new System.Drawing.Size(50, 50);
            this.pictureBox94.TabIndex = 87;
            this.pictureBox94.TabStop = false;
            // 
            // pictureBox95
            // 
            this.pictureBox95.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox95.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox95.Location = new System.Drawing.Point(99, 295);
            this.pictureBox95.Name = "pictureBox95";
            this.pictureBox95.Size = new System.Drawing.Size(50, 50);
            this.pictureBox95.TabIndex = 86;
            this.pictureBox95.TabStop = false;
            // 
            // pictureBox96
            // 
            this.pictureBox96.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox96.Location = new System.Drawing.Point(49, 295);
            this.pictureBox96.Name = "pictureBox96";
            this.pictureBox96.Size = new System.Drawing.Size(50, 50);
            this.pictureBox96.TabIndex = 85;
            this.pictureBox96.TabStop = false;
            // 
            // pictureBox97
            // 
            this.pictureBox97.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox97.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox97.Location = new System.Drawing.Point(-2, 295);
            this.pictureBox97.Name = "pictureBox97";
            this.pictureBox97.Size = new System.Drawing.Size(50, 50);
            this.pictureBox97.TabIndex = 84;
            this.pictureBox97.TabStop = false;
            this.pictureBox97.Tag = "";
            this.pictureBox97.Click += new System.EventHandler(this.pictureBox97_Click);
            // 
            // pictureBox72
            // 
            this.pictureBox72.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox72.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox72.Location = new System.Drawing.Point(548, 290);
            this.pictureBox72.Name = "pictureBox72";
            this.pictureBox72.Size = new System.Drawing.Size(50, 50);
            this.pictureBox72.TabIndex = 81;
            this.pictureBox72.TabStop = false;
            // 
            // pictureBox73
            // 
            this.pictureBox73.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox73.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox73.Location = new System.Drawing.Point(497, 288);
            this.pictureBox73.Name = "pictureBox73";
            this.pictureBox73.Size = new System.Drawing.Size(50, 50);
            this.pictureBox73.TabIndex = 80;
            this.pictureBox73.TabStop = false;
            // 
            // pictureBox74
            // 
            this.pictureBox74.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox74.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox74.BackgroundImage")));
            this.pictureBox74.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox74.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox74.Location = new System.Drawing.Point(448, 244);
            this.pictureBox74.Name = "pictureBox74";
            this.pictureBox74.Size = new System.Drawing.Size(50, 50);
            this.pictureBox74.TabIndex = 79;
            this.pictureBox74.TabStop = false;
            // 
            // pictureBox75
            // 
            this.pictureBox75.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox75.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox75.BackgroundImage")));
            this.pictureBox75.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox75.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox75.Location = new System.Drawing.Point(299, 244);
            this.pictureBox75.Name = "pictureBox75";
            this.pictureBox75.Size = new System.Drawing.Size(50, 50);
            this.pictureBox75.TabIndex = 78;
            this.pictureBox75.TabStop = false;
            // 
            // pictureBox76
            // 
            this.pictureBox76.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox76.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox76.BackgroundImage")));
            this.pictureBox76.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox76.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox76.Location = new System.Drawing.Point(349, 244);
            this.pictureBox76.Name = "pictureBox76";
            this.pictureBox76.Size = new System.Drawing.Size(50, 50);
            this.pictureBox76.TabIndex = 77;
            this.pictureBox76.TabStop = false;
            // 
            // pictureBox77
            // 
            this.pictureBox77.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox77.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox77.BackgroundImage")));
            this.pictureBox77.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox77.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox77.Location = new System.Drawing.Point(398, 244);
            this.pictureBox77.Name = "pictureBox77";
            this.pictureBox77.Size = new System.Drawing.Size(50, 50);
            this.pictureBox77.TabIndex = 76;
            this.pictureBox77.TabStop = false;
            // 
            // pictureBox78
            // 
            this.pictureBox78.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox78.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox78.BackgroundImage")));
            this.pictureBox78.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox78.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox78.Location = new System.Drawing.Point(249, 244);
            this.pictureBox78.Name = "pictureBox78";
            this.pictureBox78.Size = new System.Drawing.Size(50, 50);
            this.pictureBox78.TabIndex = 75;
            this.pictureBox78.TabStop = false;
            // 
            // pictureBox79
            // 
            this.pictureBox79.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox79.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox79.Location = new System.Drawing.Point(199, 244);
            this.pictureBox79.Name = "pictureBox79";
            this.pictureBox79.Size = new System.Drawing.Size(50, 50);
            this.pictureBox79.TabIndex = 74;
            this.pictureBox79.TabStop = false;
            // 
            // pictureBox80
            // 
            this.pictureBox80.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox80.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox80.Location = new System.Drawing.Point(149, 244);
            this.pictureBox80.Name = "pictureBox80";
            this.pictureBox80.Size = new System.Drawing.Size(50, 50);
            this.pictureBox80.TabIndex = 73;
            this.pictureBox80.TabStop = false;
            // 
            // pictureBox81
            // 
            this.pictureBox81.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox81.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox81.Location = new System.Drawing.Point(99, 244);
            this.pictureBox81.Name = "pictureBox81";
            this.pictureBox81.Size = new System.Drawing.Size(50, 50);
            this.pictureBox81.TabIndex = 72;
            this.pictureBox81.TabStop = false;
            // 
            // pictureBox82
            // 
            this.pictureBox82.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox82.Location = new System.Drawing.Point(49, 244);
            this.pictureBox82.Name = "pictureBox82";
            this.pictureBox82.Size = new System.Drawing.Size(50, 50);
            this.pictureBox82.TabIndex = 71;
            this.pictureBox82.TabStop = false;
            // 
            // pictureBox83
            // 
            this.pictureBox83.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox83.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox83.Location = new System.Drawing.Point(-2, 244);
            this.pictureBox83.Name = "pictureBox83";
            this.pictureBox83.Size = new System.Drawing.Size(50, 50);
            this.pictureBox83.TabIndex = 70;
            this.pictureBox83.TabStop = false;
            // 
            // pictureBox56
            // 
            this.pictureBox56.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox56.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox56.Location = new System.Drawing.Point(648, 196);
            this.pictureBox56.Name = "pictureBox56";
            this.pictureBox56.Size = new System.Drawing.Size(50, 50);
            this.pictureBox56.TabIndex = 69;
            this.pictureBox56.TabStop = false;
            // 
            // pictureBox57
            // 
            this.pictureBox57.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox57.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox57.Location = new System.Drawing.Point(598, 196);
            this.pictureBox57.Name = "pictureBox57";
            this.pictureBox57.Size = new System.Drawing.Size(50, 50);
            this.pictureBox57.TabIndex = 68;
            this.pictureBox57.TabStop = false;
            // 
            // pictureBox58
            // 
            this.pictureBox58.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox58.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox58.Location = new System.Drawing.Point(548, 195);
            this.pictureBox58.Name = "pictureBox58";
            this.pictureBox58.Size = new System.Drawing.Size(50, 50);
            this.pictureBox58.TabIndex = 67;
            this.pictureBox58.TabStop = false;
            // 
            // pictureBox59
            // 
            this.pictureBox59.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox59.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox59.Location = new System.Drawing.Point(498, 195);
            this.pictureBox59.Name = "pictureBox59";
            this.pictureBox59.Size = new System.Drawing.Size(50, 50);
            this.pictureBox59.TabIndex = 66;
            this.pictureBox59.TabStop = false;
            // 
            // pictureBox60
            // 
            this.pictureBox60.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox60.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox60.Location = new System.Drawing.Point(448, 195);
            this.pictureBox60.Name = "pictureBox60";
            this.pictureBox60.Size = new System.Drawing.Size(50, 50);
            this.pictureBox60.TabIndex = 65;
            this.pictureBox60.TabStop = false;
            // 
            // pictureBox61
            // 
            this.pictureBox61.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox61.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox61.BackgroundImage")));
            this.pictureBox61.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox61.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox61.Location = new System.Drawing.Point(299, 195);
            this.pictureBox61.Name = "pictureBox61";
            this.pictureBox61.Size = new System.Drawing.Size(50, 50);
            this.pictureBox61.TabIndex = 64;
            this.pictureBox61.TabStop = false;
            // 
            // pictureBox62
            // 
            this.pictureBox62.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox62.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox62.BackgroundImage")));
            this.pictureBox62.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox62.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox62.Location = new System.Drawing.Point(349, 195);
            this.pictureBox62.Name = "pictureBox62";
            this.pictureBox62.Size = new System.Drawing.Size(50, 50);
            this.pictureBox62.TabIndex = 63;
            this.pictureBox62.TabStop = false;
            // 
            // pictureBox63
            // 
            this.pictureBox63.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox63.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox63.BackgroundImage")));
            this.pictureBox63.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox63.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox63.Location = new System.Drawing.Point(398, 195);
            this.pictureBox63.Name = "pictureBox63";
            this.pictureBox63.Size = new System.Drawing.Size(50, 50);
            this.pictureBox63.TabIndex = 62;
            this.pictureBox63.TabStop = false;
            // 
            // pictureBox64
            // 
            this.pictureBox64.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox64.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox64.BackgroundImage")));
            this.pictureBox64.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox64.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox64.Location = new System.Drawing.Point(249, 195);
            this.pictureBox64.Name = "pictureBox64";
            this.pictureBox64.Size = new System.Drawing.Size(50, 50);
            this.pictureBox64.TabIndex = 61;
            this.pictureBox64.TabStop = false;
            // 
            // pictureBox65
            // 
            this.pictureBox65.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox65.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox65.Location = new System.Drawing.Point(199, 195);
            this.pictureBox65.Name = "pictureBox65";
            this.pictureBox65.Size = new System.Drawing.Size(50, 50);
            this.pictureBox65.TabIndex = 60;
            this.pictureBox65.TabStop = false;
            // 
            // pictureBox66
            // 
            this.pictureBox66.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox66.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox66.Location = new System.Drawing.Point(149, 195);
            this.pictureBox66.Name = "pictureBox66";
            this.pictureBox66.Size = new System.Drawing.Size(50, 50);
            this.pictureBox66.TabIndex = 59;
            this.pictureBox66.TabStop = false;
            // 
            // pictureBox67
            // 
            this.pictureBox67.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox67.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox67.Location = new System.Drawing.Point(99, 195);
            this.pictureBox67.Name = "pictureBox67";
            this.pictureBox67.Size = new System.Drawing.Size(50, 50);
            this.pictureBox67.TabIndex = 58;
            this.pictureBox67.TabStop = false;
            // 
            // pictureBox68
            // 
            this.pictureBox68.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox68.Location = new System.Drawing.Point(49, 195);
            this.pictureBox68.Name = "pictureBox68";
            this.pictureBox68.Size = new System.Drawing.Size(50, 50);
            this.pictureBox68.TabIndex = 57;
            this.pictureBox68.TabStop = false;
            // 
            // pictureBox69
            // 
            this.pictureBox69.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox69.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox69.Location = new System.Drawing.Point(-2, 195);
            this.pictureBox69.Name = "pictureBox69";
            this.pictureBox69.Size = new System.Drawing.Size(50, 50);
            this.pictureBox69.TabIndex = 56;
            this.pictureBox69.TabStop = false;
            // 
            // pictureBox42
            // 
            this.pictureBox42.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox42.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox42.Location = new System.Drawing.Point(649, 146);
            this.pictureBox42.Name = "pictureBox42";
            this.pictureBox42.Size = new System.Drawing.Size(50, 50);
            this.pictureBox42.TabIndex = 55;
            this.pictureBox42.TabStop = false;
            // 
            // pictureBox43
            // 
            this.pictureBox43.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox43.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox43.Location = new System.Drawing.Point(599, 146);
            this.pictureBox43.Name = "pictureBox43";
            this.pictureBox43.Size = new System.Drawing.Size(50, 50);
            this.pictureBox43.TabIndex = 54;
            this.pictureBox43.TabStop = false;
            // 
            // pictureBox44
            // 
            this.pictureBox44.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox44.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox44.Location = new System.Drawing.Point(549, 145);
            this.pictureBox44.Name = "pictureBox44";
            this.pictureBox44.Size = new System.Drawing.Size(50, 50);
            this.pictureBox44.TabIndex = 53;
            this.pictureBox44.TabStop = false;
            // 
            // pictureBox45
            // 
            this.pictureBox45.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox45.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox45.Location = new System.Drawing.Point(499, 145);
            this.pictureBox45.Name = "pictureBox45";
            this.pictureBox45.Size = new System.Drawing.Size(50, 50);
            this.pictureBox45.TabIndex = 52;
            this.pictureBox45.TabStop = false;
            // 
            // pictureBox46
            // 
            this.pictureBox46.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox46.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox46.Location = new System.Drawing.Point(449, 145);
            this.pictureBox46.Name = "pictureBox46";
            this.pictureBox46.Size = new System.Drawing.Size(50, 50);
            this.pictureBox46.TabIndex = 51;
            this.pictureBox46.TabStop = false;
            // 
            // pictureBox47
            // 
            this.pictureBox47.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox47.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox47.BackgroundImage")));
            this.pictureBox47.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox47.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox47.Location = new System.Drawing.Point(300, 145);
            this.pictureBox47.Name = "pictureBox47";
            this.pictureBox47.Size = new System.Drawing.Size(50, 50);
            this.pictureBox47.TabIndex = 50;
            this.pictureBox47.TabStop = false;
            // 
            // pictureBox48
            // 
            this.pictureBox48.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox48.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox48.BackgroundImage")));
            this.pictureBox48.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox48.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox48.Location = new System.Drawing.Point(350, 145);
            this.pictureBox48.Name = "pictureBox48";
            this.pictureBox48.Size = new System.Drawing.Size(50, 50);
            this.pictureBox48.TabIndex = 49;
            this.pictureBox48.TabStop = false;
            // 
            // pictureBox49
            // 
            this.pictureBox49.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox49.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox49.BackgroundImage")));
            this.pictureBox49.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox49.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox49.Location = new System.Drawing.Point(399, 145);
            this.pictureBox49.Name = "pictureBox49";
            this.pictureBox49.Size = new System.Drawing.Size(50, 50);
            this.pictureBox49.TabIndex = 48;
            this.pictureBox49.TabStop = false;
            // 
            // pictureBox50
            // 
            this.pictureBox50.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox50.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox50.BackgroundImage")));
            this.pictureBox50.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox50.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox50.Location = new System.Drawing.Point(250, 145);
            this.pictureBox50.Name = "pictureBox50";
            this.pictureBox50.Size = new System.Drawing.Size(50, 50);
            this.pictureBox50.TabIndex = 47;
            this.pictureBox50.TabStop = false;
            // 
            // pictureBox51
            // 
            this.pictureBox51.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox51.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox51.Location = new System.Drawing.Point(200, 145);
            this.pictureBox51.Name = "pictureBox51";
            this.pictureBox51.Size = new System.Drawing.Size(50, 50);
            this.pictureBox51.TabIndex = 46;
            this.pictureBox51.TabStop = false;
            // 
            // pictureBox52
            // 
            this.pictureBox52.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox52.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox52.Location = new System.Drawing.Point(150, 145);
            this.pictureBox52.Name = "pictureBox52";
            this.pictureBox52.Size = new System.Drawing.Size(50, 50);
            this.pictureBox52.TabIndex = 45;
            this.pictureBox52.TabStop = false;
            // 
            // pictureBox53
            // 
            this.pictureBox53.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox53.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox53.Location = new System.Drawing.Point(100, 145);
            this.pictureBox53.Name = "pictureBox53";
            this.pictureBox53.Size = new System.Drawing.Size(50, 50);
            this.pictureBox53.TabIndex = 44;
            this.pictureBox53.TabStop = false;
            // 
            // pictureBox54
            // 
            this.pictureBox54.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox54.Location = new System.Drawing.Point(50, 145);
            this.pictureBox54.Name = "pictureBox54";
            this.pictureBox54.Size = new System.Drawing.Size(50, 50);
            this.pictureBox54.TabIndex = 43;
            this.pictureBox54.TabStop = false;
            // 
            // pictureBox55
            // 
            this.pictureBox55.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox55.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox55.Location = new System.Drawing.Point(-1, 145);
            this.pictureBox55.Name = "pictureBox55";
            this.pictureBox55.Size = new System.Drawing.Size(50, 50);
            this.pictureBox55.TabIndex = 42;
            this.pictureBox55.TabStop = false;
            // 
            // pictureBox28
            // 
            this.pictureBox28.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox28.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox28.Location = new System.Drawing.Point(650, 100);
            this.pictureBox28.Name = "pictureBox28";
            this.pictureBox28.Size = new System.Drawing.Size(50, 50);
            this.pictureBox28.TabIndex = 41;
            this.pictureBox28.TabStop = false;
            // 
            // pictureBox29
            // 
            this.pictureBox29.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox29.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox29.Location = new System.Drawing.Point(600, 100);
            this.pictureBox29.Name = "pictureBox29";
            this.pictureBox29.Size = new System.Drawing.Size(50, 50);
            this.pictureBox29.TabIndex = 40;
            this.pictureBox29.TabStop = false;
            // 
            // pictureBox30
            // 
            this.pictureBox30.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox30.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox30.Location = new System.Drawing.Point(550, 99);
            this.pictureBox30.Name = "pictureBox30";
            this.pictureBox30.Size = new System.Drawing.Size(50, 50);
            this.pictureBox30.TabIndex = 39;
            this.pictureBox30.TabStop = false;
            // 
            // pictureBox31
            // 
            this.pictureBox31.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox31.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox31.Location = new System.Drawing.Point(500, 99);
            this.pictureBox31.Name = "pictureBox31";
            this.pictureBox31.Size = new System.Drawing.Size(50, 50);
            this.pictureBox31.TabIndex = 38;
            this.pictureBox31.TabStop = false;
            // 
            // pictureBox32
            // 
            this.pictureBox32.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox32.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox32.Location = new System.Drawing.Point(450, 99);
            this.pictureBox32.Name = "pictureBox32";
            this.pictureBox32.Size = new System.Drawing.Size(50, 50);
            this.pictureBox32.TabIndex = 37;
            this.pictureBox32.TabStop = false;
            // 
            // pictureBox33
            // 
            this.pictureBox33.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox33.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox33.BackgroundImage")));
            this.pictureBox33.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox33.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox33.Location = new System.Drawing.Point(301, 99);
            this.pictureBox33.Name = "pictureBox33";
            this.pictureBox33.Size = new System.Drawing.Size(50, 50);
            this.pictureBox33.TabIndex = 36;
            this.pictureBox33.TabStop = false;
            // 
            // pictureBox34
            // 
            this.pictureBox34.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox34.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox34.BackgroundImage")));
            this.pictureBox34.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox34.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox34.Location = new System.Drawing.Point(351, 99);
            this.pictureBox34.Name = "pictureBox34";
            this.pictureBox34.Size = new System.Drawing.Size(50, 50);
            this.pictureBox34.TabIndex = 35;
            this.pictureBox34.TabStop = false;
            // 
            // pictureBox35
            // 
            this.pictureBox35.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox35.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox35.BackgroundImage")));
            this.pictureBox35.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox35.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox35.Location = new System.Drawing.Point(400, 99);
            this.pictureBox35.Name = "pictureBox35";
            this.pictureBox35.Size = new System.Drawing.Size(50, 50);
            this.pictureBox35.TabIndex = 34;
            this.pictureBox35.TabStop = false;
            // 
            // pictureBox36
            // 
            this.pictureBox36.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox36.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox36.BackgroundImage")));
            this.pictureBox36.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox36.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox36.Location = new System.Drawing.Point(251, 99);
            this.pictureBox36.Name = "pictureBox36";
            this.pictureBox36.Size = new System.Drawing.Size(50, 50);
            this.pictureBox36.TabIndex = 33;
            this.pictureBox36.TabStop = false;
            // 
            // pictureBox37
            // 
            this.pictureBox37.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox37.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox37.Location = new System.Drawing.Point(201, 99);
            this.pictureBox37.Name = "pictureBox37";
            this.pictureBox37.Size = new System.Drawing.Size(50, 50);
            this.pictureBox37.TabIndex = 32;
            this.pictureBox37.TabStop = false;
            // 
            // pictureBox38
            // 
            this.pictureBox38.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox38.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox38.Location = new System.Drawing.Point(151, 99);
            this.pictureBox38.Name = "pictureBox38";
            this.pictureBox38.Size = new System.Drawing.Size(50, 50);
            this.pictureBox38.TabIndex = 31;
            this.pictureBox38.TabStop = false;
            // 
            // pictureBox39
            // 
            this.pictureBox39.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox39.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox39.Location = new System.Drawing.Point(101, 99);
            this.pictureBox39.Name = "pictureBox39";
            this.pictureBox39.Size = new System.Drawing.Size(50, 50);
            this.pictureBox39.TabIndex = 30;
            this.pictureBox39.TabStop = false;
            // 
            // pictureBox40
            // 
            this.pictureBox40.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox40.Location = new System.Drawing.Point(51, 99);
            this.pictureBox40.Name = "pictureBox40";
            this.pictureBox40.Size = new System.Drawing.Size(50, 50);
            this.pictureBox40.TabIndex = 29;
            this.pictureBox40.TabStop = false;
            // 
            // pictureBox41
            // 
            this.pictureBox41.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox41.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox41.Location = new System.Drawing.Point(0, 99);
            this.pictureBox41.Name = "pictureBox41";
            this.pictureBox41.Size = new System.Drawing.Size(50, 50);
            this.pictureBox41.TabIndex = 28;
            this.pictureBox41.TabStop = false;
            // 
            // pictureBox14
            // 
            this.pictureBox14.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox14.Location = new System.Drawing.Point(650, 51);
            this.pictureBox14.Name = "pictureBox14";
            this.pictureBox14.Size = new System.Drawing.Size(50, 50);
            this.pictureBox14.TabIndex = 27;
            this.pictureBox14.TabStop = false;
            // 
            // pictureBox15
            // 
            this.pictureBox15.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox15.Location = new System.Drawing.Point(600, 51);
            this.pictureBox15.Name = "pictureBox15";
            this.pictureBox15.Size = new System.Drawing.Size(50, 50);
            this.pictureBox15.TabIndex = 26;
            this.pictureBox15.TabStop = false;
            // 
            // pictureBox16
            // 
            this.pictureBox16.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox16.Location = new System.Drawing.Point(550, 50);
            this.pictureBox16.Name = "pictureBox16";
            this.pictureBox16.Size = new System.Drawing.Size(50, 50);
            this.pictureBox16.TabIndex = 25;
            this.pictureBox16.TabStop = false;
            // 
            // pictureBox17
            // 
            this.pictureBox17.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox17.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox17.Location = new System.Drawing.Point(500, 50);
            this.pictureBox17.Name = "pictureBox17";
            this.pictureBox17.Size = new System.Drawing.Size(50, 50);
            this.pictureBox17.TabIndex = 24;
            this.pictureBox17.TabStop = false;
            // 
            // pictureBox18
            // 
            this.pictureBox18.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox18.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox18.Location = new System.Drawing.Point(450, 50);
            this.pictureBox18.Name = "pictureBox18";
            this.pictureBox18.Size = new System.Drawing.Size(50, 50);
            this.pictureBox18.TabIndex = 23;
            this.pictureBox18.TabStop = false;
            // 
            // pictureBox19
            // 
            this.pictureBox19.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox19.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox19.BackgroundImage")));
            this.pictureBox19.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox19.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox19.Location = new System.Drawing.Point(301, 50);
            this.pictureBox19.Name = "pictureBox19";
            this.pictureBox19.Size = new System.Drawing.Size(50, 50);
            this.pictureBox19.TabIndex = 22;
            this.pictureBox19.TabStop = false;
            // 
            // pictureBox20
            // 
            this.pictureBox20.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox20.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox20.BackgroundImage")));
            this.pictureBox20.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox20.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox20.Location = new System.Drawing.Point(351, 50);
            this.pictureBox20.Name = "pictureBox20";
            this.pictureBox20.Size = new System.Drawing.Size(50, 50);
            this.pictureBox20.TabIndex = 21;
            this.pictureBox20.TabStop = false;
            // 
            // pictureBox21
            // 
            this.pictureBox21.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox21.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox21.BackgroundImage")));
            this.pictureBox21.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox21.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox21.Location = new System.Drawing.Point(400, 50);
            this.pictureBox21.Name = "pictureBox21";
            this.pictureBox21.Size = new System.Drawing.Size(50, 50);
            this.pictureBox21.TabIndex = 20;
            this.pictureBox21.TabStop = false;
            // 
            // pictureBox22
            // 
            this.pictureBox22.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox22.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox22.BackgroundImage")));
            this.pictureBox22.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox22.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox22.Location = new System.Drawing.Point(251, 50);
            this.pictureBox22.Name = "pictureBox22";
            this.pictureBox22.Size = new System.Drawing.Size(50, 50);
            this.pictureBox22.TabIndex = 19;
            this.pictureBox22.TabStop = false;
            // 
            // pictureBox23
            // 
            this.pictureBox23.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox23.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox23.BackgroundImage")));
            this.pictureBox23.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox23.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox23.Location = new System.Drawing.Point(201, 50);
            this.pictureBox23.Name = "pictureBox23";
            this.pictureBox23.Size = new System.Drawing.Size(50, 50);
            this.pictureBox23.TabIndex = 18;
            this.pictureBox23.TabStop = false;
            // 
            // pictureBox24
            // 
            this.pictureBox24.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox24.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox24.Location = new System.Drawing.Point(151, 50);
            this.pictureBox24.Name = "pictureBox24";
            this.pictureBox24.Size = new System.Drawing.Size(50, 50);
            this.pictureBox24.TabIndex = 17;
            this.pictureBox24.TabStop = false;
            // 
            // pictureBox25
            // 
            this.pictureBox25.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox25.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox25.Location = new System.Drawing.Point(101, 50);
            this.pictureBox25.Name = "pictureBox25";
            this.pictureBox25.Size = new System.Drawing.Size(50, 50);
            this.pictureBox25.TabIndex = 16;
            this.pictureBox25.TabStop = false;
            // 
            // pictureBox26
            // 
            this.pictureBox26.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox26.Location = new System.Drawing.Point(51, 50);
            this.pictureBox26.Name = "pictureBox26";
            this.pictureBox26.Size = new System.Drawing.Size(50, 50);
            this.pictureBox26.TabIndex = 15;
            this.pictureBox26.TabStop = false;
            // 
            // pictureBox27
            // 
            this.pictureBox27.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox27.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox27.Location = new System.Drawing.Point(0, 50);
            this.pictureBox27.Name = "pictureBox27";
            this.pictureBox27.Size = new System.Drawing.Size(50, 50);
            this.pictureBox27.TabIndex = 14;
            this.pictureBox27.TabStop = false;
            // 
            // pictureBox12
            // 
            this.pictureBox12.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox12.Location = new System.Drawing.Point(650, 1);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(50, 50);
            this.pictureBox12.TabIndex = 13;
            this.pictureBox12.TabStop = false;
            // 
            // pictureBox13
            // 
            this.pictureBox13.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox13.Location = new System.Drawing.Point(600, 1);
            this.pictureBox13.Name = "pictureBox13";
            this.pictureBox13.Size = new System.Drawing.Size(50, 50);
            this.pictureBox13.TabIndex = 12;
            this.pictureBox13.TabStop = false;
            // 
            // pictureBox9
            // 
            this.pictureBox9.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox9.Location = new System.Drawing.Point(550, 0);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(50, 50);
            this.pictureBox9.TabIndex = 11;
            this.pictureBox9.TabStop = false;
            // 
            // pictureBox10
            // 
            this.pictureBox10.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox10.Location = new System.Drawing.Point(500, 0);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(50, 50);
            this.pictureBox10.TabIndex = 10;
            this.pictureBox10.TabStop = false;
            // 
            // pictureBox11
            // 
            this.pictureBox11.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox11.Location = new System.Drawing.Point(450, 0);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(50, 50);
            this.pictureBox11.TabIndex = 9;
            this.pictureBox11.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox8.BackgroundImage")));
            this.pictureBox8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox8.Location = new System.Drawing.Point(301, 0);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(50, 50);
            this.pictureBox8.TabIndex = 8;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox7.BackgroundImage")));
            this.pictureBox7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox7.Location = new System.Drawing.Point(351, 0);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(50, 50);
            this.pictureBox7.TabIndex = 7;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox6.BackgroundImage")));
            this.pictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox6.Location = new System.Drawing.Point(400, 0);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(50, 50);
            this.pictureBox6.TabIndex = 6;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox5.BackgroundImage")));
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox5.Location = new System.Drawing.Point(251, 0);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(50, 50);
            this.pictureBox5.TabIndex = 5;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox4.BackgroundImage")));
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox4.Location = new System.Drawing.Point(201, 0);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(50, 50);
            this.pictureBox4.TabIndex = 4;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox3.Location = new System.Drawing.Point(151, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(50, 50);
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Location = new System.Drawing.Point(101, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(50, 50);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // start
            // 
            this.start.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.start.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("start.BackgroundImage")));
            this.start.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.start.Location = new System.Drawing.Point(51, 0);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(50, 50);
            this.start.TabIndex = 1;
            this.start.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // horizontalScrollbar
            // 
            this.horizontalScrollbar.BackColor = System.Drawing.Color.Black;
            this.horizontalScrollbar.Location = new System.Drawing.Point(-1, 340);
            this.horizontalScrollbar.Name = "horizontalScrollbar";
            this.horizontalScrollbar.Size = new System.Drawing.Size(690, 15);
            this.horizontalScrollbar.TabIndex = 0;
            // 
            // verticalScrollbar
            // 
            this.verticalScrollbar.BackColor = System.Drawing.Color.Black;
            this.verticalScrollbar.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.verticalScrollbar.Location = new System.Drawing.Point(690, -1);
            this.verticalScrollbar.Name = "verticalScrollbar";
            this.verticalScrollbar.Size = new System.Drawing.Size(15, 340);
            this.verticalScrollbar.TabIndex = 1;
            // 
            // pictureBox70
            // 
            this.pictureBox70.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox70.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox70.Location = new System.Drawing.Point(597, 292);
            this.pictureBox70.Name = "pictureBox70";
            this.pictureBox70.Size = new System.Drawing.Size(50, 50);
            this.pictureBox70.TabIndex = 98;
            this.pictureBox70.TabStop = false;
            // 
            // pictureBox71
            // 
            this.pictureBox71.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox71.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox71.Location = new System.Drawing.Point(648, 244);
            this.pictureBox71.Name = "pictureBox71";
            this.pictureBox71.Size = new System.Drawing.Size(50, 50);
            this.pictureBox71.TabIndex = 99;
            this.pictureBox71.TabStop = false;
            // 
            // pictureBox85
            // 
            this.pictureBox85.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox85.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox85.Location = new System.Drawing.Point(648, 290);
            this.pictureBox85.Name = "pictureBox85";
            this.pictureBox85.Size = new System.Drawing.Size(50, 50);
            this.pictureBox85.TabIndex = 100;
            this.pictureBox85.TabStop = false;
            // 
            // pictureBox89
            // 
            this.pictureBox89.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox89.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox89.Location = new System.Drawing.Point(401, 294);
            this.pictureBox89.Name = "pictureBox89";
            this.pictureBox89.Size = new System.Drawing.Size(50, 50);
            this.pictureBox89.TabIndex = 104;
            this.pictureBox89.TabStop = false;
            // 
            // pictureBox90
            // 
            this.pictureBox90.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox90.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox90.Location = new System.Drawing.Point(249, 294);
            this.pictureBox90.Name = "pictureBox90";
            this.pictureBox90.Size = new System.Drawing.Size(50, 50);
            this.pictureBox90.TabIndex = 103;
            this.pictureBox90.TabStop = false;
            // 
            // pictureBox91
            // 
            this.pictureBox91.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox91.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox91.Location = new System.Drawing.Point(352, 292);
            this.pictureBox91.Name = "pictureBox91";
            this.pictureBox91.Size = new System.Drawing.Size(50, 50);
            this.pictureBox91.TabIndex = 102;
            this.pictureBox91.TabStop = false;
            // 
            // pictureBox92
            // 
            this.pictureBox92.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox92.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox92.Location = new System.Drawing.Point(301, 290);
            this.pictureBox92.Name = "pictureBox92";
            this.pictureBox92.Size = new System.Drawing.Size(50, 50);
            this.pictureBox92.TabIndex = 101;
            this.pictureBox92.TabStop = false;
            // 
            // Board
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 356);
            this.Controls.Add(this.horizontalScrollbar);
            this.Controls.Add(this.verticalScrollbar);
            this.Controls.Add(this.panel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Board";
            this.Text = "Athosa!";
            this.Load += new System.EventHandler(this.Board_Load);
            this.panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox84)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox86)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox87)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox88)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox93)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox94)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox95)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox96)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox97)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox72)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox73)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox74)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox75)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox76)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox77)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox78)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox79)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox80)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox81)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox82)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox83)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox56)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox57)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox58)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox59)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox60)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox61)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox62)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox63)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox64)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox65)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox66)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox67)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox68)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox69)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox42)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox43)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox44)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox45)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox46)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox47)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox48)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox49)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox50)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox51)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox52)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox53)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox54)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox55)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox28)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox29)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox30)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox31)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox32)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox33)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox34)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox35)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox36)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox37)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox38)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox39)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox40)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox41)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox19)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox20)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox22)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox23)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox24)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox25)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox26)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox27)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.start)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox70)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox71)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox85)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox89)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox90)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox91)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox92)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.HScrollBar horizontalScrollbar;
        private System.Windows.Forms.VScrollBar verticalScrollbar;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox start;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox84;
        private System.Windows.Forms.PictureBox pictureBox86;
        private System.Windows.Forms.PictureBox pictureBox87;
        private System.Windows.Forms.PictureBox pictureBox88;
        private System.Windows.Forms.PictureBox pictureBox93;
        private System.Windows.Forms.PictureBox pictureBox94;
        private System.Windows.Forms.PictureBox pictureBox95;
        private System.Windows.Forms.PictureBox pictureBox96;
        private System.Windows.Forms.PictureBox pictureBox97;
        private System.Windows.Forms.PictureBox pictureBox72;
        private System.Windows.Forms.PictureBox pictureBox73;
        private System.Windows.Forms.PictureBox pictureBox74;
        private System.Windows.Forms.PictureBox pictureBox75;
        private System.Windows.Forms.PictureBox pictureBox76;
        private System.Windows.Forms.PictureBox pictureBox77;
        private System.Windows.Forms.PictureBox pictureBox78;
        private System.Windows.Forms.PictureBox pictureBox79;
        private System.Windows.Forms.PictureBox pictureBox80;
        private System.Windows.Forms.PictureBox pictureBox81;
        private System.Windows.Forms.PictureBox pictureBox82;
        private System.Windows.Forms.PictureBox pictureBox83;
        private System.Windows.Forms.PictureBox pictureBox56;
        private System.Windows.Forms.PictureBox pictureBox57;
        private System.Windows.Forms.PictureBox pictureBox58;
        private System.Windows.Forms.PictureBox pictureBox59;
        private System.Windows.Forms.PictureBox pictureBox60;
        private System.Windows.Forms.PictureBox pictureBox61;
        private System.Windows.Forms.PictureBox pictureBox62;
        private System.Windows.Forms.PictureBox pictureBox63;
        private System.Windows.Forms.PictureBox pictureBox64;
        private System.Windows.Forms.PictureBox pictureBox65;
        private System.Windows.Forms.PictureBox pictureBox66;
        private System.Windows.Forms.PictureBox pictureBox67;
        private System.Windows.Forms.PictureBox pictureBox68;
        private System.Windows.Forms.PictureBox pictureBox69;
        private System.Windows.Forms.PictureBox pictureBox42;
        private System.Windows.Forms.PictureBox pictureBox43;
        private System.Windows.Forms.PictureBox pictureBox44;
        private System.Windows.Forms.PictureBox pictureBox45;
        private System.Windows.Forms.PictureBox pictureBox46;
        private System.Windows.Forms.PictureBox pictureBox47;
        private System.Windows.Forms.PictureBox pictureBox48;
        private System.Windows.Forms.PictureBox pictureBox49;
        private System.Windows.Forms.PictureBox pictureBox50;
        private System.Windows.Forms.PictureBox pictureBox51;
        private System.Windows.Forms.PictureBox pictureBox52;
        private System.Windows.Forms.PictureBox pictureBox53;
        private System.Windows.Forms.PictureBox pictureBox54;
        private System.Windows.Forms.PictureBox pictureBox55;
        private System.Windows.Forms.PictureBox pictureBox28;
        private System.Windows.Forms.PictureBox pictureBox29;
        private System.Windows.Forms.PictureBox pictureBox30;
        private System.Windows.Forms.PictureBox pictureBox31;
        private System.Windows.Forms.PictureBox pictureBox32;
        private System.Windows.Forms.PictureBox pictureBox33;
        private System.Windows.Forms.PictureBox pictureBox34;
        private System.Windows.Forms.PictureBox pictureBox35;
        private System.Windows.Forms.PictureBox pictureBox36;
        private System.Windows.Forms.PictureBox pictureBox37;
        private System.Windows.Forms.PictureBox pictureBox38;
        private System.Windows.Forms.PictureBox pictureBox39;
        private System.Windows.Forms.PictureBox pictureBox40;
        private System.Windows.Forms.PictureBox pictureBox41;
        private System.Windows.Forms.PictureBox pictureBox14;
        private System.Windows.Forms.PictureBox pictureBox15;
        private System.Windows.Forms.PictureBox pictureBox16;
        private System.Windows.Forms.PictureBox pictureBox17;
        private System.Windows.Forms.PictureBox pictureBox18;
        private System.Windows.Forms.PictureBox pictureBox19;
        private System.Windows.Forms.PictureBox pictureBox20;
        private System.Windows.Forms.PictureBox pictureBox21;
        private System.Windows.Forms.PictureBox pictureBox22;
        private System.Windows.Forms.PictureBox pictureBox23;
        private System.Windows.Forms.PictureBox pictureBox24;
        private System.Windows.Forms.PictureBox pictureBox25;
        private System.Windows.Forms.PictureBox pictureBox26;
        private System.Windows.Forms.PictureBox pictureBox27;
        private System.Windows.Forms.PictureBox pictureBox12;
        private System.Windows.Forms.PictureBox pictureBox13;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox89;
        private System.Windows.Forms.PictureBox pictureBox90;
        private System.Windows.Forms.PictureBox pictureBox91;
        private System.Windows.Forms.PictureBox pictureBox92;
        private System.Windows.Forms.PictureBox pictureBox85;
        private System.Windows.Forms.PictureBox pictureBox71;
        private System.Windows.Forms.PictureBox pictureBox70;
    }
}