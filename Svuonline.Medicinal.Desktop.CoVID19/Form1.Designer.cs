namespace Svuonline.Medicinal.Desktop.CoVID19
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
            this.button1 = new System.Windows.Forms.Button();
            this.TxtBoxerrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.txtBoxScreenUserName = new System.Windows.Forms.TextBox();
            this.txtBoxUserEmail = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.TxtBoxerrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(323, 360);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(325, 78);
            this.button1.TabIndex = 0;
            this.button1.Text = "Test";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TxtBoxerrorProvider
            // 
            this.TxtBoxerrorProvider.ContainerControl = this;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(298, 311);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // txtBoxScreenUserName
            // 
            this.txtBoxScreenUserName.Location = new System.Drawing.Point(311, 150);
            this.txtBoxScreenUserName.MaxLength = 15;
            this.txtBoxScreenUserName.Name = "txtBoxScreenUserName";
            this.txtBoxScreenUserName.Size = new System.Drawing.Size(221, 24);
            this.txtBoxScreenUserName.TabIndex = 2;
            this.txtBoxScreenUserName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxScreenUserName_KeyPress);
            // 
            // txtBoxUserEmail
            // 
            this.txtBoxUserEmail.Location = new System.Drawing.Point(311, 180);
            this.txtBoxUserEmail.Name = "txtBoxUserEmail";
            this.txtBoxUserEmail.Size = new System.Drawing.Size(221, 24);
            this.txtBoxUserEmail.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtBoxUserEmail);
            this.Controls.Add(this.txtBoxScreenUserName);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.TxtBoxerrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ErrorProvider TxtBoxerrorProvider;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtBoxScreenUserName;
        private System.Windows.Forms.TextBox txtBoxUserEmail;
    }
}

