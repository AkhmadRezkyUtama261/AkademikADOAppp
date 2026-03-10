namespace AkademikADOAppp
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
            this.Connect_Database = new System.Windows.Forms.Button();
            this.DisconnectDatabase = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Connect_Database
            // 
            this.Connect_Database.Location = new System.Drawing.Point(134, 177);
            this.Connect_Database.Name = "Connect_Database";
            this.Connect_Database.Size = new System.Drawing.Size(146, 51);
            this.Connect_Database.TabIndex = 0;
            this.Connect_Database.Text = "Connect Database";
            this.Connect_Database.UseVisualStyleBackColor = true;
            this.Connect_Database.Click += new System.EventHandler(this.btnConnect);
            // 
            // DisconnectDatabase
            // 
            this.DisconnectDatabase.Location = new System.Drawing.Point(96, 253);
            this.DisconnectDatabase.Name = "DisconnectDatabase";
            this.DisconnectDatabase.Size = new System.Drawing.Size(134, 57);
            this.DisconnectDatabase.TabIndex = 1;
            this.DisconnectDatabase.Text = "Disconnect Databse";
            this.DisconnectDatabase.UseVisualStyleBackColor = true;
            this.DisconnectDatabase.Click += new System.EventHandler(this.btnDisconnect);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(96, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Status";
            this.label1.Click += new System.EventHandler(this.lblstatus);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DisconnectDatabase);
            this.Controls.Add(this.Connect_Database);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Connect_Database;
        private System.Windows.Forms.Button DisconnectDatabase;
        private System.Windows.Forms.Label label1;
    }
}

