using System.Windows.Forms;
using System;

namespace AddressBookApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private TextBox txtName;
        private TextBox txtEmail;
        private TextBox txtPhone;
        private Button btnSave;
        private ListBox lstContacts;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtName = new TextBox();
            this.txtEmail = new TextBox();
            this.txtPhone = new TextBox();
            this.btnSave = new Button();
            this.lstContacts = new ListBox();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(50, 30);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(200, 20);
            this.txtName.TabIndex = 0;
            this.txtName.Text = "Name"; // Set as placeholder
            this.txtName.Enter += new System.EventHandler(this.txtName_Enter); // Event handler for clearing placeholder
            this.txtName.Leave += new System.EventHandler(this.txtName_Leave); // Event handler for restoring placeholder
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(50, 70);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(200, 20);
            this.txtEmail.TabIndex = 1;
            this.txtEmail.Text = "Email"; // Set as placeholder
            this.txtEmail.Enter += new System.EventHandler(this.txtEmail_Enter); // Event handler for clearing placeholder
            this.txtEmail.Leave += new System.EventHandler(this.txtEmail_Leave); // Event handler for restoring placeholder
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(50, 110);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(200, 20);
            this.txtPhone.TabIndex = 2;
            this.txtPhone.Text = "Phone"; // Set as placeholder
            this.txtPhone.Enter += new System.EventHandler(this.txtPhone_Enter); // Event handler for clearing placeholder
            this.txtPhone.Leave += new System.EventHandler(this.txtPhone_Leave); // Event handler for restoring placeholder
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(110, 150);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lstContacts
            // 
            this.lstContacts.FormattingEnabled = true;
            this.lstContacts.Location = new System.Drawing.Point(50, 190);
            this.lstContacts.Name = "lstContacts";
            this.lstContacts.Size = new System.Drawing.Size(200, 95);
            this.lstContacts.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 300);
            this.Controls.Add(this.lstContacts);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtName);
            this.Name = "Form1";
            this.Text = "Address Book";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        // Event handlers to manage placeholders
        private void txtName_Enter(object sender, EventArgs e)
        {
            if (txtName.Text == "Name")
            {
                txtName.Text = "";
            }
        }

        private void txtName_Leave(object sender, EventArgs e)
        {
            if (txtName.Text == "")
            {
                txtName.Text = "Name";
            }
        }

        private void txtEmail_Enter(object sender, EventArgs e)
        {
            if (txtEmail.Text == "Email")
            {
                txtEmail.Text = "";
            }
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (txtEmail.Text == "")
            {
                txtEmail.Text = "Email";
            }
        }

        private void txtPhone_Enter(object sender, EventArgs e)
        {
            if (txtPhone.Text == "Phone")
            {
                txtPhone.Text = "";
            }
        }

        private void txtPhone_Leave(object sender, EventArgs e)
        {
            if (txtPhone.Text == "")
            {
                txtPhone.Text = "Phone";
            }
        }
    }
}
