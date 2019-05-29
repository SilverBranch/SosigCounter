namespace SosigCounter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSubtract = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblSosigCoutner = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnSubtractHobby = new System.Windows.Forms.Button();
            this.btnAddHobby = new System.Windows.Forms.Button();
            this.lblHobbyCounter = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnSubtract
            // 
            this.btnSubtract.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubtract.Location = new System.Drawing.Point(94, 12);
            this.btnSubtract.Name = "btnSubtract";
            this.btnSubtract.Size = new System.Drawing.Size(64, 64);
            this.btnSubtract.TabIndex = 1;
            this.btnSubtract.Text = "-";
            this.btnSubtract.UseVisualStyleBackColor = true;
            this.btnSubtract.Click += new System.EventHandler(this.btnSubtract_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(240, 12);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(64, 64);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblSosigCoutner
            // 
            this.lblSosigCoutner.AutoSize = true;
            this.lblSosigCoutner.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSosigCoutner.Location = new System.Drawing.Point(183, 25);
            this.lblSosigCoutner.Name = "lblSosigCoutner";
            this.lblSosigCoutner.Size = new System.Drawing.Size(37, 39);
            this.lblSosigCoutner.TabIndex = 3;
            this.lblSosigCoutner.Text = "0";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.InitialImage")));
            this.pictureBox2.Location = new System.Drawing.Point(12, 82);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(64, 64);
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // btnSubtractHobby
            // 
            this.btnSubtractHobby.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubtractHobby.Location = new System.Drawing.Point(94, 82);
            this.btnSubtractHobby.Name = "btnSubtractHobby";
            this.btnSubtractHobby.Size = new System.Drawing.Size(64, 64);
            this.btnSubtractHobby.TabIndex = 5;
            this.btnSubtractHobby.Text = "-";
            this.btnSubtractHobby.UseVisualStyleBackColor = true;
            this.btnSubtractHobby.Click += new System.EventHandler(this.btnSubtractHobby_Click);
            // 
            // btnAddHobby
            // 
            this.btnAddHobby.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddHobby.Location = new System.Drawing.Point(240, 82);
            this.btnAddHobby.Name = "btnAddHobby";
            this.btnAddHobby.Size = new System.Drawing.Size(64, 64);
            this.btnAddHobby.TabIndex = 6;
            this.btnAddHobby.Text = "+";
            this.btnAddHobby.UseVisualStyleBackColor = true;
            this.btnAddHobby.Click += new System.EventHandler(this.btnAddHobby_Click);
            // 
            // lblHobbyCounter
            // 
            this.lblHobbyCounter.AutoSize = true;
            this.lblHobbyCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHobbyCounter.Location = new System.Drawing.Point(183, 95);
            this.lblHobbyCounter.Name = "lblHobbyCounter";
            this.lblHobbyCounter.Size = new System.Drawing.Size(37, 39);
            this.lblHobbyCounter.TabIndex = 7;
            this.lblHobbyCounter.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 156);
            this.Controls.Add(this.lblHobbyCounter);
            this.Controls.Add(this.btnAddHobby);
            this.Controls.Add(this.btnSubtractHobby);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lblSosigCoutner);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnSubtract);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Sosig Counter";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnSubtract;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblSosigCoutner;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnSubtractHobby;
        private System.Windows.Forms.Button btnAddHobby;
        private System.Windows.Forms.Label lblHobbyCounter;
    }
}

