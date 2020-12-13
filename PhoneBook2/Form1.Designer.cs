
namespace PhoneBook2
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
            this.grBadduser = new System.Windows.Forms.GroupBox();
            this.grbUpdate = new System.Windows.Forms.GroupBox();
            this.grBdelete = new System.Windows.Forms.GroupBox();
            this.grpPhonebook = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.lbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.User = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.grBadduser.SuspendLayout();
            this.grbUpdate.SuspendLayout();
            this.grBdelete.SuspendLayout();
            this.grpPhonebook.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // grBadduser
            // 
            this.grBadduser.Controls.Add(this.txtPhone);
            this.grBadduser.Controls.Add(this.txtLastName);
            this.grBadduser.Controls.Add(this.txtname);
            this.grBadduser.Controls.Add(this.label3);
            this.grBadduser.Controls.Add(this.label1);
            this.grBadduser.Controls.Add(this.lbl);
            this.grBadduser.Controls.Add(this.btnAddUser);
            this.grBadduser.Location = new System.Drawing.Point(13, 13);
            this.grBadduser.Name = "grBadduser";
            this.grBadduser.Size = new System.Drawing.Size(200, 193);
            this.grBadduser.TabIndex = 0;
            this.grBadduser.TabStop = false;
            this.grBadduser.Text = "Add User";
            // 
            // grbUpdate
            // 
            this.grbUpdate.Controls.Add(this.button1);
            this.grbUpdate.Controls.Add(this.textBox3);
            this.grbUpdate.Controls.Add(this.textBox2);
            this.grbUpdate.Controls.Add(this.User);
            this.grbUpdate.Controls.Add(this.label2);
            this.grbUpdate.Location = new System.Drawing.Point(229, 13);
            this.grbUpdate.Name = "grbUpdate";
            this.grbUpdate.Size = new System.Drawing.Size(200, 193);
            this.grbUpdate.TabIndex = 0;
            this.grbUpdate.TabStop = false;
            this.grbUpdate.Text = "Update User";
            // 
            // grBdelete
            // 
            this.grBdelete.Controls.Add(this.btnDelete);
            this.grBdelete.Controls.Add(this.textBox1);
            this.grBdelete.Controls.Add(this.label5);
            this.grBdelete.Location = new System.Drawing.Point(447, 13);
            this.grBdelete.Name = "grBdelete";
            this.grBdelete.Size = new System.Drawing.Size(200, 193);
            this.grBdelete.TabIndex = 0;
            this.grBdelete.TabStop = false;
            this.grBdelete.Text = "Delete User";
            // 
            // grpPhonebook
            // 
            this.grpPhonebook.Controls.Add(this.dataGridView1);
            this.grpPhonebook.Location = new System.Drawing.Point(13, 212);
            this.grpPhonebook.Name = "grpPhonebook";
            this.grpPhonebook.Size = new System.Drawing.Size(634, 217);
            this.grpPhonebook.TabIndex = 0;
            this.grpPhonebook.TabStop = false;
            this.grpPhonebook.Text = "Phone Book";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(7, 20);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(621, 191);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnAddUser
            // 
            this.btnAddUser.Location = new System.Drawing.Point(119, 164);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(75, 23);
            this.btnAddUser.TabIndex = 0;
            this.btnAddUser.Text = "Add User";
            this.btnAddUser.UseVisualStyleBackColor = true;
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(6, 41);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(38, 13);
            this.lbl.TabIndex = 2;
            this.lbl.Text = "Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Last Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Phone Number:";
            // 
            // User
            // 
            this.User.AutoSize = true;
            this.User.Location = new System.Drawing.Point(22, 38);
            this.User.Name = "User";
            this.User.Size = new System.Drawing.Size(32, 13);
            this.User.TabIndex = 2;
            this.User.Text = "User:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "User:";
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(94, 38);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(100, 20);
            this.txtname.TabIndex = 3;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(94, 73);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(100, 20);
            this.txtLastName.TabIndex = 3;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(94, 104);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(100, 20);
            this.txtPhone.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(30, 69);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(154, 20);
            this.textBox1.TabIndex = 3;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(112, 164);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Phone Number:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(25, 54);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(158, 20);
            this.textBox2.TabIndex = 3;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(25, 107);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(158, 20);
            this.textBox3.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(111, 164);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grpPhonebook);
            this.Controls.Add(this.grBdelete);
            this.Controls.Add(this.grbUpdate);
            this.Controls.Add(this.grBadduser);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grBadduser.ResumeLayout(false);
            this.grBadduser.PerformLayout();
            this.grbUpdate.ResumeLayout(false);
            this.grbUpdate.PerformLayout();
            this.grBdelete.ResumeLayout(false);
            this.grBdelete.PerformLayout();
            this.grpPhonebook.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grBadduser;
        private System.Windows.Forms.GroupBox grbUpdate;
        private System.Windows.Forms.GroupBox grBdelete;
        private System.Windows.Forms.GroupBox grpPhonebook;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label User;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
    }
}

