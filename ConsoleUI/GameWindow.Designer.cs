namespace ConsoleUI
{
    partial class GameWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameWindow));
            this.roomPB = new System.Windows.Forms.PictureBox();
            this.heroPNL = new System.Windows.Forms.Panel();
            this.nameLBL = new System.Windows.Forms.Label();
            this.heroPB = new System.Windows.Forms.PictureBox();
            this.inputTB = new System.Windows.Forms.TextBox();
            this.enterBTN = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.itemPB = new System.Windows.Forms.PictureBox();
            this.displayLBL = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.roomPB)).BeginInit();
            this.heroPNL.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.heroPB)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemPB)).BeginInit();
            this.SuspendLayout();
            // 
            // roomPB
            // 
            this.roomPB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.roomPB.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.roomPB.Location = new System.Drawing.Point(12, 9);
            this.roomPB.Name = "roomPB";
            this.roomPB.Size = new System.Drawing.Size(512, 384);
            this.roomPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.roomPB.TabIndex = 0;
            this.roomPB.TabStop = false;
            // 
            // heroPNL
            // 
            this.heroPNL.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.heroPNL.Controls.Add(this.nameLBL);
            this.heroPNL.Controls.Add(this.heroPB);
            this.heroPNL.Location = new System.Drawing.Point(12, 399);
            this.heroPNL.Name = "heroPNL";
            this.heroPNL.Size = new System.Drawing.Size(336, 108);
            this.heroPNL.TabIndex = 1;
            // 
            // nameLBL
            // 
            this.nameLBL.AutoSize = true;
            this.nameLBL.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLBL.Location = new System.Drawing.Point(105, 3);
            this.nameLBL.Name = "nameLBL";
            this.nameLBL.Size = new System.Drawing.Size(79, 36);
            this.nameLBL.TabIndex = 1;
            this.nameLBL.Text = "NAME";
            // 
            // heroPB
            // 
            this.heroPB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.heroPB.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.heroPB.Location = new System.Drawing.Point(3, 3);
            this.heroPB.Name = "heroPB";
            this.heroPB.Size = new System.Drawing.Size(96, 96);
            this.heroPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.heroPB.TabIndex = 0;
            this.heroPB.TabStop = false;
            // 
            // inputTB
            // 
            this.inputTB.BackColor = System.Drawing.Color.Black;
            this.inputTB.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputTB.ForeColor = System.Drawing.Color.White;
            this.inputTB.Location = new System.Drawing.Point(530, 481);
            this.inputTB.Name = "inputTB";
            this.inputTB.Size = new System.Drawing.Size(331, 31);
            this.inputTB.TabIndex = 2;
            // 
            // enterBTN
            // 
            this.enterBTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.enterBTN.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterBTN.ForeColor = System.Drawing.Color.White;
            this.enterBTN.Location = new System.Drawing.Point(867, 480);
            this.enterBTN.Name = "enterBTN";
            this.enterBTN.Size = new System.Drawing.Size(73, 27);
            this.enterBTN.TabIndex = 3;
            this.enterBTN.Text = "Enter";
            this.enterBTN.UseVisualStyleBackColor = true;
            this.enterBTN.Click += new System.EventHandler(this.enterBTN_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.itemPB);
            this.panel1.Location = new System.Drawing.Point(354, 399);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(170, 108);
            this.panel1.TabIndex = 4;
            // 
            // itemPB
            // 
            this.itemPB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.itemPB.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.itemPB.Location = new System.Drawing.Point(3, 3);
            this.itemPB.Name = "itemPB";
            this.itemPB.Size = new System.Drawing.Size(96, 96);
            this.itemPB.TabIndex = 2;
            this.itemPB.TabStop = false;
            // 
            // displayLBL
            // 
            this.displayLBL.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.displayLBL.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayLBL.Location = new System.Drawing.Point(530, 9);
            this.displayLBL.Name = "displayLBL";
            this.displayLBL.Size = new System.Drawing.Size(410, 468);
            this.displayLBL.TabIndex = 5;
            this.displayLBL.Text = resources.GetString("displayLBL.Text");
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "1.png");
            this.imageList1.Images.SetKeyName(1, "2.png");
            this.imageList1.Images.SetKeyName(2, "3.png");
            // 
            // GameWindow
            // 
            this.AcceptButton = this.enterBTN;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(950, 513);
            this.Controls.Add(this.displayLBL);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.enterBTN);
            this.Controls.Add(this.inputTB);
            this.Controls.Add(this.heroPNL);
            this.Controls.Add(this.roomPB);
            this.Font = new System.Drawing.Font("Consolas", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "GameWindow";
            this.Text = "DATACOMBS v0.1";
            this.Load += new System.EventHandler(this.GameWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.roomPB)).EndInit();
            this.heroPNL.ResumeLayout(false);
            this.heroPNL.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.heroPB)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.itemPB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox roomPB;
        private System.Windows.Forms.Panel heroPNL;
        private System.Windows.Forms.PictureBox heroPB;
        private System.Windows.Forms.Label nameLBL;
        private System.Windows.Forms.TextBox inputTB;
        private System.Windows.Forms.Button enterBTN;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox itemPB;
        private System.Windows.Forms.Label displayLBL;
        private System.Windows.Forms.ImageList imageList1;
    }
}