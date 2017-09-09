namespace Labsheet01_A
{
    partial class frmMain
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnShow = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(406, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "CSaratakij\'s feeling....";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnShow
            // 
            this.btnShow.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShow.ForeColor = System.Drawing.Color.White;
            this.btnShow.Location = new System.Drawing.Point(22, 140);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(388, 79);
            this.btnShow.TabIndex = 3;
            this.btnShow.Text = "Click here to show more...";
            this.btnShow.UseVisualStyleBackColor = false;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Maroon;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(22, 225);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(388, 31);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Done";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtMessage
            // 
            this.txtMessage.ForeColor = System.Drawing.Color.Gray;
            this.txtMessage.Location = new System.Drawing.Point(22, 110);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(388, 20);
            this.txtMessage.TabIndex = 2;
            this.txtMessage.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtMessage.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            this.txtMessage.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.textBox_PreviewKeyDown);
            // 
            // txtName
            // 
            this.txtName.ForeColor = System.Drawing.Color.Gray;
            this.txtName.Location = new System.Drawing.Point(22, 84);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(388, 20);
            this.txtName.TabIndex = 1;
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtName.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            this.txtName.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.textBox_PreviewKeyDown);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 269);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Labsheet01_A : 6002526";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.TextBox txtName;
    }
}

