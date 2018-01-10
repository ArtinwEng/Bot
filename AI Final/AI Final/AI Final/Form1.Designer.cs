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
            this.close = new System.Windows.Forms.Button();
            this.keyword = new System.Windows.Forms.ListBox();
            this.train = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.input = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.start = new System.Windows.Forms.Button();
            this.output = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // close
            // 
            this.close.BackColor = System.Drawing.Color.Red;
            this.close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close.ForeColor = System.Drawing.Color.Transparent;
            this.close.Location = new System.Drawing.Point(535, 12);
            this.close.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(24, 24);
            this.close.TabIndex = 0;
            this.close.Text = "X";
            this.close.UseVisualStyleBackColor = false;
            this.close.Click += new System.EventHandler(this.button1_Click);
            // 
            // keyword
            // 
            this.keyword.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.keyword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.keyword.Font = new System.Drawing.Font("Quark", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.keyword.ForeColor = System.Drawing.SystemColors.GrayText;
            this.keyword.FormattingEnabled = true;
            this.keyword.ItemHeight = 28;
            this.keyword.Location = new System.Drawing.Point(358, 100);
            this.keyword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.keyword.Name = "keyword";
            this.keyword.Size = new System.Drawing.Size(183, 308);
            this.keyword.TabIndex = 1;
            // 
            // train
            // 
            this.train.Font = new System.Drawing.Font("Quark", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.train.ForeColor = System.Drawing.Color.Black;
            this.train.Location = new System.Drawing.Point(466, 448);
            this.train.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.train.Name = "train";
            this.train.Size = new System.Drawing.Size(75, 30);
            this.train.TabIndex = 2;
            this.train.Text = "สอน";
            this.train.UseVisualStyleBackColor = true;
            this.train.Click += new System.EventHandler(this.train_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Quark", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(387, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 43);
            this.label1.TabIndex = 3;
            this.label1.Text = "Keyword";
            // 
            // input
            // 
            this.input.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.input.Font = new System.Drawing.Font("Quark", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input.Location = new System.Drawing.Point(27, 128);
            this.input.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(313, 58);
            this.input.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Quark", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(29, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 39);
            this.label2.TabIndex = 5;
            this.label2.Text = "ใส่คำสั่ง";
            // 
            // start
            // 
            this.start.Font = new System.Drawing.Font("Quark", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start.ForeColor = System.Drawing.Color.Black;
            this.start.Location = new System.Drawing.Point(238, 366);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(114, 42);
            this.start.TabIndex = 7;
            this.start.Text = "โต้ตอบ";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // output
            // 
            this.output.Font = new System.Drawing.Font("Quark", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.output.Location = new System.Drawing.Point(27, 256);
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(313, 47);
            this.output.TabIndex = 8;
            // 
            // Ai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(569, 495);
            this.Controls.Add(this.output);
            this.Controls.Add(this.start);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.input);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.train);
            this.Controls.Add(this.keyword);
            this.Controls.Add(this.close);
            this.Font = new System.Drawing.Font("Quark", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Red;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Ai";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
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
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.TextBox output;
    }
}

