namespace Araba_Yarışı
{
    partial class FormRace
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.crash = new System.Windows.Forms.PictureBox();
            this.ourCar = new System.Windows.Forms.PictureBox();
            this.car2 = new System.Windows.Forms.PictureBox();
            this.car1 = new System.Windows.Forms.PictureBox();
            this.road2 = new System.Windows.Forms.PictureBox();
            this.road = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label_score = new System.Windows.Forms.Label();
            this.button_start = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label_highScore = new System.Windows.Forms.Label();
            this.labelMusic = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.crash)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ourCar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.car2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.car1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.road2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.road)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.crash);
            this.panel1.Controls.Add(this.ourCar);
            this.panel1.Controls.Add(this.car2);
            this.panel1.Controls.Add(this.car1);
            this.panel1.Controls.Add(this.road2);
            this.panel1.Controls.Add(this.road);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(360, 620);
            this.panel1.TabIndex = 0;
            // 
            // crash
            // 
            this.crash.Image = global::Araba_Yarışı.Properties.Resources.explosion;
            this.crash.Location = new System.Drawing.Point(222, 440);
            this.crash.Name = "crash";
            this.crash.Size = new System.Drawing.Size(75, 75);
            this.crash.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.crash.TabIndex = 5;
            this.crash.TabStop = false;
            // 
            // ourCar
            // 
            this.ourCar.Image = global::Araba_Yarışı.Properties.Resources.car3;
            this.ourCar.Location = new System.Drawing.Point(222, 467);
            this.ourCar.Name = "ourCar";
            this.ourCar.Size = new System.Drawing.Size(75, 150);
            this.ourCar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ourCar.TabIndex = 4;
            this.ourCar.TabStop = false;
            // 
            // car2
            // 
            this.car2.Image = global::Araba_Yarışı.Properties.Resources.car1;
            this.car2.Location = new System.Drawing.Point(222, 3);
            this.car2.Name = "car2";
            this.car2.Size = new System.Drawing.Size(75, 150);
            this.car2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.car2.TabIndex = 3;
            this.car2.TabStop = false;
            // 
            // car1
            // 
            this.car1.Image = global::Araba_Yarışı.Properties.Resources.car2;
            this.car1.Location = new System.Drawing.Point(56, 440);
            this.car1.Name = "car1";
            this.car1.Size = new System.Drawing.Size(75, 150);
            this.car1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.car1.TabIndex = 2;
            this.car1.TabStop = false;
            // 
            // road2
            // 
            this.road2.Image = global::Araba_Yarışı.Properties.Resources.road;
            this.road2.Location = new System.Drawing.Point(0, 0);
            this.road2.Name = "road2";
            this.road2.Size = new System.Drawing.Size(360, 620);
            this.road2.TabIndex = 1;
            this.road2.TabStop = false;
            // 
            // road
            // 
            this.road.Image = global::Araba_Yarışı.Properties.Resources.road;
            this.road.Location = new System.Drawing.Point(0, -620);
            this.road.Name = "road";
            this.road.Size = new System.Drawing.Size(360, 620);
            this.road.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.road.TabIndex = 0;
            this.road.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(255, 635);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Puan:";
            // 
            // label_score
            // 
            this.label_score.AutoSize = true;
            this.label_score.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_score.Location = new System.Drawing.Point(325, 635);
            this.label_score.Name = "label_score";
            this.label_score.Size = new System.Drawing.Size(21, 24);
            this.label_score.TabIndex = 1;
            this.label_score.Text = "0";
            // 
            // button_start
            // 
            this.button_start.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_start.Location = new System.Drawing.Point(148, 665);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(87, 23);
            this.button_start.TabIndex = 2;
            this.button_start.Text = "Başlat";
            this.button_start.UseVisualStyleBackColor = true;
            this.button_start.Click += new System.EventHandler(this.button_start_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 638);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "En Yüksek Skor:";
            // 
            // label_highScore
            // 
            this.label_highScore.AutoSize = true;
            this.label_highScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_highScore.Location = new System.Drawing.Point(181, 638);
            this.label_highScore.Name = "label_highScore";
            this.label_highScore.Size = new System.Drawing.Size(21, 24);
            this.label_highScore.TabIndex = 1;
            this.label_highScore.Text = "0";
            // 
            // labelMusic
            // 
            this.labelMusic.AutoSize = true;
            this.labelMusic.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMusic.Location = new System.Drawing.Point(279, 726);
            this.labelMusic.Name = "labelMusic";
            this.labelMusic.Size = new System.Drawing.Size(77, 20);
            this.labelMusic.TabIndex = 3;
            this.labelMusic.Text = "Müziği Aç";
            this.labelMusic.Click += new System.EventHandler(this.labelMusic_Click);
            // 
            // FormRace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 755);
            this.Controls.Add(this.labelMusic);
            this.Controls.Add(this.button_start);
            this.Controls.Add(this.label_highScore);
            this.Controls.Add(this.label_score);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "FormRace";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yarış";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormRace_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FormRace_KeyUp);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.crash)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ourCar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.car2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.car1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.road2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.road)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox road;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_score;
        private System.Windows.Forms.Button button_start;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_highScore;
        private System.Windows.Forms.PictureBox crash;
        private System.Windows.Forms.PictureBox ourCar;
        private System.Windows.Forms.PictureBox car2;
        private System.Windows.Forms.PictureBox car1;
        private System.Windows.Forms.PictureBox road2;
        private System.Windows.Forms.Label labelMusic;
    }
}

