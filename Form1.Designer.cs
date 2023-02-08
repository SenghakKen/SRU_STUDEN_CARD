namespace SRU_STUDEN_CARD
{
    partial class Form1
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
            this.p_Head = new System.Windows.Forms.Panel();
            this.p_Navigation = new System.Windows.Forms.Panel();
            this.p_seperate = new System.Windows.Forms.Panel();
            this.p_small_menu = new System.Windows.Forms.Panel();
            this.p_Contain = new System.Windows.Forms.Panel();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.p_Logo = new System.Windows.Forms.PictureBox();
            this.btBack = new System.Windows.Forms.Button();
            this.p_Navigation.SuspendLayout();
            this.p_small_menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.p_Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // p_Head
            // 
            this.p_Head.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.p_Head.Dock = System.Windows.Forms.DockStyle.Top;
            this.p_Head.Location = new System.Drawing.Point(0, 0);
            this.p_Head.Name = "p_Head";
            this.p_Head.Size = new System.Drawing.Size(1036, 1);
            this.p_Head.TabIndex = 0;
            // 
            // p_Navigation
            // 
            this.p_Navigation.BackColor = System.Drawing.Color.Aqua;
            this.p_Navigation.Controls.Add(this.button2);
            this.p_Navigation.Controls.Add(this.panel1);
            this.p_Navigation.Controls.Add(this.button1);
            this.p_Navigation.Controls.Add(this.p_seperate);
            this.p_Navigation.Controls.Add(this.p_Logo);
            this.p_Navigation.Controls.Add(this.p_small_menu);
            this.p_Navigation.Dock = System.Windows.Forms.DockStyle.Left;
            this.p_Navigation.ForeColor = System.Drawing.Color.SlateGray;
            this.p_Navigation.Location = new System.Drawing.Point(0, 1);
            this.p_Navigation.Name = "p_Navigation";
            this.p_Navigation.Size = new System.Drawing.Size(150, 503);
            this.p_Navigation.TabIndex = 1;
            this.p_Navigation.Paint += new System.Windows.Forms.PaintEventHandler(this.p_Navigation_Paint);
            // 
            // p_seperate
            // 
            this.p_seperate.BackColor = System.Drawing.Color.Salmon;
            this.p_seperate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.p_seperate.Dock = System.Windows.Forms.DockStyle.Top;
            this.p_seperate.Location = new System.Drawing.Point(35, 73);
            this.p_seperate.Name = "p_seperate";
            this.p_seperate.Size = new System.Drawing.Size(115, 2);
            this.p_seperate.TabIndex = 2;
            // 
            // p_small_menu
            // 
            this.p_small_menu.BackColor = System.Drawing.Color.DarkSlateGray;
            this.p_small_menu.Controls.Add(this.btBack);
            this.p_small_menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.p_small_menu.Location = new System.Drawing.Point(0, 0);
            this.p_small_menu.Name = "p_small_menu";
            this.p_small_menu.Size = new System.Drawing.Size(35, 503);
            this.p_small_menu.TabIndex = 0;
            // 
            // p_Contain
            // 
            this.p_Contain.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.p_Contain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.p_Contain.Location = new System.Drawing.Point(150, 1);
            this.p_Contain.Name = "p_Contain";
            this.p_Contain.Size = new System.Drawing.Size(886, 503);
            this.p_Contain.TabIndex = 2;
            // 
            // timer
            // 
            this.timer.Interval = 10;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Salmon;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(35, 103);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(115, 2);
            this.panel1.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Image = global::SRU_STUDEN_CARD.Properties.Resources._search_25px;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(35, 105);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(115, 29);
            this.button2.TabIndex = 5;
            this.button2.Text = "View";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Image = global::SRU_STUDEN_CARD.Properties.Resources._search_25px;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(35, 75);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 28);
            this.button1.TabIndex = 3;
            this.button1.Text = "Add Stu";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // p_Logo
            // 
            this.p_Logo.Dock = System.Windows.Forms.DockStyle.Top;
            this.p_Logo.Image = global::SRU_STUDEN_CARD.Properties.Resources._student_male_50px_2;
            this.p_Logo.Location = new System.Drawing.Point(35, 0);
            this.p_Logo.Name = "p_Logo";
            this.p_Logo.Size = new System.Drawing.Size(115, 73);
            this.p_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.p_Logo.TabIndex = 1;
            this.p_Logo.TabStop = false;
            // 
            // btBack
            // 
            this.btBack.FlatAppearance.BorderSize = 0;
            this.btBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btBack.Image = global::SRU_STUDEN_CARD.Properties.Resources._1_back_to_26px;
            this.btBack.Location = new System.Drawing.Point(0, 202);
            this.btBack.Name = "btBack";
            this.btBack.Size = new System.Drawing.Size(35, 31);
            this.btBack.TabIndex = 0;
            this.btBack.UseVisualStyleBackColor = true;
            this.btBack.Click += new System.EventHandler(this.btBack_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 504);
            this.Controls.Add(this.p_Contain);
            this.Controls.Add(this.p_Navigation);
            this.Controls.Add(this.p_Head);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SRU STUDEN CARD";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.p_Navigation.ResumeLayout(false);
            this.p_small_menu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.p_Logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel p_Head;
        private System.Windows.Forms.Panel p_Navigation;
        private System.Windows.Forms.Panel p_small_menu;
        private System.Windows.Forms.Panel p_Contain;
        private System.Windows.Forms.Button btBack;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.PictureBox p_Logo;
        private System.Windows.Forms.Panel p_seperate;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
    }
}

