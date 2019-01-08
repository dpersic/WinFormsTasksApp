namespace PresentationLayer
{
    partial class FormAddUser
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
            this.btnAddNewUser = new System.Windows.Forms.Button();
            this.btnCloseNewUser = new System.Windows.Forms.Button();
            this.lblAddNewUser = new System.Windows.Forms.Label();
            this.lblNewUserName = new System.Windows.Forms.Label();
            this.lblNewName = new System.Windows.Forms.Label();
            this.lblNewLastName = new System.Windows.Forms.Label();
            this.lblNewPassword = new System.Windows.Forms.Label();
            this.inptNewUserName = new System.Windows.Forms.TextBox();
            this.inptNewName = new System.Windows.Forms.TextBox();
            this.inptNewLastName = new System.Windows.Forms.TextBox();
            this.inptNewPassword = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnAddNewUser
            // 
            this.btnAddNewUser.Location = new System.Drawing.Point(234, 255);
            this.btnAddNewUser.Name = "btnAddNewUser";
            this.btnAddNewUser.Size = new System.Drawing.Size(90, 35);
            this.btnAddNewUser.TabIndex = 0;
            this.btnAddNewUser.Text = "Dodaj";
            this.btnAddNewUser.UseVisualStyleBackColor = true;
            this.btnAddNewUser.Click += new System.EventHandler(this.btnAddNewUser_Click);
            // 
            // btnCloseNewUser
            // 
            this.btnCloseNewUser.Location = new System.Drawing.Point(92, 255);
            this.btnCloseNewUser.Name = "btnCloseNewUser";
            this.btnCloseNewUser.Size = new System.Drawing.Size(91, 35);
            this.btnCloseNewUser.TabIndex = 1;
            this.btnCloseNewUser.Text = "Zatvori";
            this.btnCloseNewUser.UseVisualStyleBackColor = true;
            this.btnCloseNewUser.Click += new System.EventHandler(this.btnCloseNewUser_Click);
            // 
            // lblAddNewUser
            // 
            this.lblAddNewUser.AutoSize = true;
            this.lblAddNewUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblAddNewUser.Location = new System.Drawing.Point(171, 30);
            this.lblAddNewUser.Name = "lblAddNewUser";
            this.lblAddNewUser.Size = new System.Drawing.Size(135, 25);
            this.lblAddNewUser.TabIndex = 2;
            this.lblAddNewUser.Text = "Novi korisnik";
            // 
            // lblNewUserName
            // 
            this.lblNewUserName.AutoSize = true;
            this.lblNewUserName.Location = new System.Drawing.Point(32, 89);
            this.lblNewUserName.Name = "lblNewUserName";
            this.lblNewUserName.Size = new System.Drawing.Size(75, 13);
            this.lblNewUserName.TabIndex = 3;
            this.lblNewUserName.Text = "Korisničko ime";
            // 
            // lblNewName
            // 
            this.lblNewName.AutoSize = true;
            this.lblNewName.Location = new System.Drawing.Point(32, 120);
            this.lblNewName.Name = "lblNewName";
            this.lblNewName.Size = new System.Drawing.Size(24, 13);
            this.lblNewName.TabIndex = 4;
            this.lblNewName.Text = "Ime";
            // 
            // lblNewLastName
            // 
            this.lblNewLastName.AutoSize = true;
            this.lblNewLastName.Location = new System.Drawing.Point(32, 154);
            this.lblNewLastName.Name = "lblNewLastName";
            this.lblNewLastName.Size = new System.Drawing.Size(44, 13);
            this.lblNewLastName.TabIndex = 5;
            this.lblNewLastName.Text = "Prezime";
            // 
            // lblNewPassword
            // 
            this.lblNewPassword.AutoSize = true;
            this.lblNewPassword.Location = new System.Drawing.Point(32, 189);
            this.lblNewPassword.Name = "lblNewPassword";
            this.lblNewPassword.Size = new System.Drawing.Size(44, 13);
            this.lblNewPassword.TabIndex = 6;
            this.lblNewPassword.Text = "Lozinka";
            // 
            // inptNewUserName
            // 
            this.inptNewUserName.Location = new System.Drawing.Point(113, 86);
            this.inptNewUserName.Name = "inptNewUserName";
            this.inptNewUserName.Size = new System.Drawing.Size(250, 20);
            this.inptNewUserName.TabIndex = 7;
            // 
            // inptNewName
            // 
            this.inptNewName.Location = new System.Drawing.Point(113, 120);
            this.inptNewName.Name = "inptNewName";
            this.inptNewName.Size = new System.Drawing.Size(250, 20);
            this.inptNewName.TabIndex = 8;
            // 
            // inptNewLastName
            // 
            this.inptNewLastName.Location = new System.Drawing.Point(113, 154);
            this.inptNewLastName.Name = "inptNewLastName";
            this.inptNewLastName.Size = new System.Drawing.Size(250, 20);
            this.inptNewLastName.TabIndex = 9;
            // 
            // inptNewPassword
            // 
            this.inptNewPassword.Location = new System.Drawing.Point(113, 189);
            this.inptNewPassword.Name = "inptNewPassword";
            this.inptNewPassword.Size = new System.Drawing.Size(250, 20);
            this.inptNewPassword.TabIndex = 10;
            // 
            // FormAddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 316);
            this.Controls.Add(this.inptNewPassword);
            this.Controls.Add(this.inptNewLastName);
            this.Controls.Add(this.inptNewName);
            this.Controls.Add(this.inptNewUserName);
            this.Controls.Add(this.lblNewPassword);
            this.Controls.Add(this.lblNewLastName);
            this.Controls.Add(this.lblNewName);
            this.Controls.Add(this.lblNewUserName);
            this.Controls.Add(this.lblAddNewUser);
            this.Controls.Add(this.btnCloseNewUser);
            this.Controls.Add(this.btnAddNewUser);
            this.Name = "FormAddUser";
            this.Text = "FormAddUser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddNewUser;
        private System.Windows.Forms.Button btnCloseNewUser;
        private System.Windows.Forms.Label lblAddNewUser;
        private System.Windows.Forms.Label lblNewUserName;
        private System.Windows.Forms.Label lblNewName;
        private System.Windows.Forms.Label lblNewLastName;
        private System.Windows.Forms.Label lblNewPassword;
        private System.Windows.Forms.TextBox inptNewUserName;
        private System.Windows.Forms.TextBox inptNewName;
        private System.Windows.Forms.TextBox inptNewLastName;
        private System.Windows.Forms.TextBox inptNewPassword;
    }
}