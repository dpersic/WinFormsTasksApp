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
            this.dataGridViewTasks = new System.Windows.Forms.DataGridView();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.izbonikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oProgramuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izlazToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.tabPage.SuspendLayout();
            this.Korisnici.SuspendLayout();
            this.tabPageTasks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTasks)).BeginInit();
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
            this.dataGridViewUsers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewUsers_CellContentClick);
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
            this.btnNewUser.Click += new System.EventHandler(this.btnNewUser_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.izbonikToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1059, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tabPage
            // 
            this.tabPage.Controls.Add(this.Korisnici);
            this.tabPage.Controls.Add(this.tabPageTasks);
            this.tabPage.Location = new System.Drawing.Point(12, 39);
            this.tabPage.Name = "tabPage";
            this.tabPage.SelectedIndex = 0;
            this.tabPage.Size = new System.Drawing.Size(1025, 385);
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
            this.tabPageTasks.Controls.Add(this.dataGridViewTasks);
            this.tabPageTasks.Location = new System.Drawing.Point(4, 22);
            this.tabPageTasks.Name = "tabPageTasks";
            this.tabPageTasks.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTasks.Size = new System.Drawing.Size(1017, 359);
            this.tabPageTasks.TabIndex = 1;
            this.tabPageTasks.Text = "Zadaci";
            this.tabPageTasks.UseVisualStyleBackColor = true;
            // 
            // dataGridViewTasks
            // 
            this.dataGridViewTasks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTasks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column11,
            this.Column12});
            this.dataGridViewTasks.Location = new System.Drawing.Point(6, 26);
            this.dataGridViewTasks.Name = "dataGridViewTasks";
            this.dataGridViewTasks.Size = new System.Drawing.Size(864, 289);
            this.dataGridViewTasks.TabIndex = 0;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "nID";
            this.Column6.HeaderText = "Rbr";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "sTitle";
            this.Column7.HeaderText = "Naziv zadatka";
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "sDescription";
            this.Column8.HeaderText = "Opis zadatka";
            this.Column8.Name = "Column8";
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "sDeadline";
            this.Column9.HeaderText = "Krajnji rok";
            this.Column9.Name = "Column9";
            // 
            // Column10
            // 
            this.Column10.DataPropertyName = "nOwnerId";
            this.Column10.HeaderText = "Vlasnik";
            this.Column10.Name = "Column10";
            // 
            // Column11
            // 
            this.Column11.DataPropertyName = "nWorkerId";
            this.Column11.HeaderText = "Radnik";
            this.Column11.Name = "Column11";
            // 
            // Column12
            // 
            this.Column12.DataPropertyName = "nActive";
            this.Column12.HeaderText = "Aktivnost";
            this.Column12.Name = "Column12";
            // 
            // izbonikToolStripMenuItem
            // 
            this.izbonikToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.oProgramuToolStripMenuItem,
            this.izlazToolStripMenuItem});
            this.izbonikToolStripMenuItem.Name = "izbonikToolStripMenuItem";
            this.izbonikToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.izbonikToolStripMenuItem.Text = "Izbonik";
            // 
            // oProgramuToolStripMenuItem
            // 
            this.oProgramuToolStripMenuItem.Name = "oProgramuToolStripMenuItem";
            this.oProgramuToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.oProgramuToolStripMenuItem.Text = "O programu";
            this.oProgramuToolStripMenuItem.Click += new System.EventHandler(this.oProgramuToolStripMenuItem_Click);
            // 
            // izlazToolStripMenuItem
            // 
            this.izlazToolStripMenuItem.Name = "izlazToolStripMenuItem";
            this.izlazToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.izlazToolStripMenuItem.Text = "Izlaz";
            this.izlazToolStripMenuItem.Click += new System.EventHandler(this.izlazToolStripMenuItem_Click);
            // 
            // FormUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1059, 459);
            this.Controls.Add(this.tabPage);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormUsers";
            this.Text = "Tasks";
            this.Load += new System.EventHandler(this.FormUsers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabPage.ResumeLayout(false);
            this.Korisnici.ResumeLayout(false);
            this.tabPageTasks.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTasks)).EndInit();
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
        private System.Windows.Forms.DataGridView dataGridViewTasks;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.ToolStripMenuItem izbonikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oProgramuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izlazToolStripMenuItem;
    }
}

