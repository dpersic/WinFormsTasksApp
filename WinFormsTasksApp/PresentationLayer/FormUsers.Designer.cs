namespace PresentationLayer
{
    partial class FormUsers
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
            this.dataGridViewUsers = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnNewUser = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tabPage = new System.Windows.Forms.TabControl();
            this.Korisnici = new System.Windows.Forms.TabPage();
            this.tabPageTasks = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).BeginInit();
            this.tabPage.SuspendLayout();
            this.Korisnici.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewUsers
            // 
            this.dataGridViewUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dataGridViewUsers.Location = new System.Drawing.Point(24, 58);
            this.dataGridViewUsers.Name = "dataGridViewUsers";
            this.dataGridViewUsers.Size = new System.Drawing.Size(595, 271);
            this.dataGridViewUsers.TabIndex = 0;
            this.dataGridViewUsers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "nId";
            this.Column1.HeaderText = "Rbr";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "sName";
            this.Column2.HeaderText = "Name";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "sSurname";
            this.Column3.HeaderText = "Surname";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "sUsername";
            this.Column4.HeaderText = "Username";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "sPassword";
            this.Column5.HeaderText = "Password";
            this.Column5.Name = "Column5";
            // 
            // btnNewUser
            // 
            this.btnNewUser.Location = new System.Drawing.Point(634, 58);
            this.btnNewUser.Name = "btnNewUser";
            this.btnNewUser.Size = new System.Drawing.Size(122, 44);
            this.btnNewUser.TabIndex = 1;
            this.btnNewUser.Text = "Novi korisnik";
            this.btnNewUser.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(867, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tabPage
            // 
            this.tabPage.Controls.Add(this.Korisnici);
            this.tabPage.Controls.Add(this.tabPageTasks);
            this.tabPage.Location = new System.Drawing.Point(12, 12);
            this.tabPage.Name = "tabPage";
            this.tabPage.SelectedIndex = 0;
            this.tabPage.Size = new System.Drawing.Size(804, 412);
            this.tabPage.TabIndex = 3;
            // 
            // Korisnici
            // 
            this.Korisnici.Controls.Add(this.dataGridViewUsers);
            this.Korisnici.Controls.Add(this.btnNewUser);
            this.Korisnici.Location = new System.Drawing.Point(4, 22);
            this.Korisnici.Name = "Korisnici";
            this.Korisnici.Padding = new System.Windows.Forms.Padding(3);
            this.Korisnici.Size = new System.Drawing.Size(796, 386);
            this.Korisnici.TabIndex = 0;
            this.Korisnici.Text = "Korisnici";
            this.Korisnici.UseVisualStyleBackColor = true;
            // 
            // tabPageTasks
            // 
            this.tabPageTasks.Location = new System.Drawing.Point(4, 22);
            this.tabPageTasks.Name = "tabPageTasks";
            this.tabPageTasks.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTasks.Size = new System.Drawing.Size(796, 386);
            this.tabPageTasks.TabIndex = 1;
            this.tabPageTasks.Text = "Zadaci";
            this.tabPageTasks.UseVisualStyleBackColor = true;
            // 
            // FormUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 459);
            this.Controls.Add(this.tabPage);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormUsers";
            this.Text = "Prikaz korisnika";
            this.Load += new System.EventHandler(this.FormUsers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).EndInit();
            this.tabPage.ResumeLayout(false);
            this.Korisnici.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewUsers;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Button btnNewUser;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.TabControl tabPage;
        private System.Windows.Forms.TabPage Korisnici;
        private System.Windows.Forms.TabPage tabPageTasks;
    }
}

