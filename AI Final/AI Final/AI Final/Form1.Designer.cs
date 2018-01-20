namespace AI_Final
{
    partial class Ai
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ai));
            this.keyword = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.input = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.output = new System.Windows.Forms.TextBox();
            this.panelA = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panelB = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.panelC = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.close = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.F = new System.Windows.Forms.PictureBox();
            this.Sc = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.train = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.panelA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panelB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.panelC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.F)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Sc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // keyword
            // 
            this.keyword.BackColor = System.Drawing.Color.GhostWhite;
            this.keyword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.keyword.Font = new System.Drawing.Font("Quark", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.keyword.ForeColor = System.Drawing.SystemColors.GrayText;
            this.keyword.FormattingEnabled = true;
            this.keyword.ItemHeight = 28;
            this.keyword.Location = new System.Drawing.Point(400, 341);
            this.keyword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.keyword.Name = "keyword";
            this.keyword.Size = new System.Drawing.Size(157, 140);
            this.keyword.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.label1.Font = new System.Drawing.Font("Quark", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(415, 316);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Words Analysis";
            // 
            // input
            // 
            this.input.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.input.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.input.Font = new System.Drawing.Font("Quark", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input.ForeColor = System.Drawing.Color.GhostWhite;
            this.input.Location = new System.Drawing.Point(33, 382);
            this.input.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.input.Multiline = true;
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(330, 57);
            this.input.TabIndex = 4;
            this.input.TextChanged += new System.EventHandler(this.input_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.label2.Font = new System.Drawing.Font("Quark", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(27, 350);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 32);
            this.label2.TabIndex = 5;
            this.label2.Text = "ใส่คำสั่ง";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // output
            // 
            this.output.BackColor = System.Drawing.Color.GhostWhite;
            this.output.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.output.Font = new System.Drawing.Font("Quark", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.output.Location = new System.Drawing.Point(287, 129);
            this.output.Multiline = true;
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(273, 52);
            this.output.TabIndex = 8;
            this.output.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panelA
            // 
            this.panelA.Controls.Add(this.pictureBox2);
            this.panelA.Controls.Add(this.label3);
            this.panelA.Location = new System.Drawing.Point(41, 12);
            this.panelA.Name = "panelA";
            this.panelA.Size = new System.Drawing.Size(252, 296);
            this.panelA.TabIndex = 16;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::AI_Final.Properties.Resources.graphic_design;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(12, 25);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(230, 225);
            this.pictureBox2.TabIndex = 18;
            this.pictureBox2.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Quark", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.label3.Location = new System.Drawing.Point(67, 252);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 39);
            this.label3.TabIndex = 19;
            this.label3.Text = "ยินดีต้อนรับ";
            // 
            // panelB
            // 
            this.panelB.Controls.Add(this.label4);
            this.panelB.Controls.Add(this.pictureBox5);
            this.panelB.Location = new System.Drawing.Point(41, 19);
            this.panelB.Name = "panelB";
            this.panelB.Size = new System.Drawing.Size(252, 285);
            this.panelB.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Quark", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.label4.Location = new System.Drawing.Point(75, 250);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 39);
            this.label4.TabIndex = 19;
            this.label4.Text = "ออกคำสั่ง";
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackgroundImage = global::AI_Final.Properties.Resources.idea;
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox5.Location = new System.Drawing.Point(12, 18);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(230, 225);
            this.pictureBox5.TabIndex = 18;
            this.pictureBox5.TabStop = false;
            // 
            // panelC
            // 
            this.panelC.Controls.Add(this.label5);
            this.panelC.Controls.Add(this.pictureBox6);
            this.panelC.Location = new System.Drawing.Point(41, 29);
            this.panelC.Name = "panelC";
            this.panelC.Size = new System.Drawing.Size(252, 275);
            this.panelC.TabIndex = 21;
            this.panelC.Paint += new System.Windows.Forms.PaintEventHandler(this.panelC_Paint);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Quark", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.label5.Location = new System.Drawing.Point(84, 236);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 39);
            this.label5.TabIndex = 19;
            this.label5.Text = "คุยกันนะ";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackgroundImage = global::AI_Final.Properties.Resources.like;
            this.pictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox6.Location = new System.Drawing.Point(12, 9);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(230, 225);
            this.pictureBox6.TabIndex = 18;
            this.pictureBox6.TabStop = false;
            // 
            // close
            // 
            this.close.BackColor = System.Drawing.Color.GhostWhite;
            this.close.BackgroundImage = global::AI_Final.Properties.Resources.error;
            this.close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.close.Cursor = System.Windows.Forms.Cursors.Default;
            this.close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.GhostWhite;
            this.close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close.ForeColor = System.Drawing.Color.GhostWhite;
            this.close.Location = new System.Drawing.Point(541, 4);
            this.close.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(25, 24);
            this.close.TabIndex = 0;
            this.close.UseVisualStyleBackColor = false;
            this.close.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.pictureBox3.Location = new System.Drawing.Point(-1, -79);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(18, 73);
            this.pictureBox3.TabIndex = 15;
            this.pictureBox3.TabStop = false;
            // 
            // F
            // 
            this.F.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.F.Location = new System.Drawing.Point(-1, 71);
            this.F.Name = "F";
            this.F.Size = new System.Drawing.Size(18, 73);
            this.F.TabIndex = 14;
            this.F.TabStop = false;
            this.F.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // Sc
            // 
            this.Sc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.Sc.Location = new System.Drawing.Point(-1, -1);
            this.Sc.Name = "Sc";
            this.Sc.Size = new System.Drawing.Size(18, 73);
            this.Sc.TabIndex = 13;
            this.Sc.TabStop = false;
            this.Sc.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(20)))), ((int)(((byte)(55)))));
            this.pictureBox1.Location = new System.Drawing.Point(158, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(341, 10);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // train
            // 
            this.train.BackColor = System.Drawing.Color.GhostWhite;
            this.train.BackgroundImage = global::AI_Final.Properties.Resources.plus;
            this.train.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.train.FlatAppearance.MouseOverBackColor = System.Drawing.Color.GhostWhite;
            this.train.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.train.Font = new System.Drawing.Font("Quark", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.train.ForeColor = System.Drawing.Color.GhostWhite;
            this.train.Location = new System.Drawing.Point(510, 3);
            this.train.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.train.Name = "train";
            this.train.Size = new System.Drawing.Size(25, 25);
            this.train.TabIndex = 2;
            this.train.UseVisualStyleBackColor = false;
            this.train.Click += new System.EventHandler(this.train_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.pictureBox4.Location = new System.Drawing.Point(-1, 310);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(572, 185);
            this.pictureBox4.TabIndex = 10;
            this.pictureBox4.TabStop = false;
            // 
            // Ai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(569, 495);
            this.Controls.Add(this.close);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.output);
            this.Controls.Add(this.F);
            this.Controls.Add(this.Sc);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.input);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.train);
            this.Controls.Add(this.keyword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.panelA);
            this.Controls.Add(this.panelB);
            this.Controls.Add(this.panelC);
            this.Font = new System.Drawing.Font("Quark", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Red;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Ai";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelA.ResumeLayout(false);
            this.panelA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panelB.ResumeLayout(false);
            this.panelB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.panelC.ResumeLayout(false);
            this.panelC.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.F)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Sc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button close;
        private System.Windows.Forms.ListBox keyword;
        private System.Windows.Forms.Button train;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox input;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox output;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox Sc;
        private System.Windows.Forms.PictureBox F;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panelA;
        private System.Windows.Forms.Panel panelB;
        private System.Windows.Forms.Panel panelC;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

