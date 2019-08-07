namespace NikamoozBuild2019.WindowsFormAfterMigrate
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
            this.firstNameTitle = new System.Windows.Forms.Label();
            this.lastNameTitle = new System.Windows.Forms.Label();
            this.firstName = new System.Windows.Forms.TextBox();
            this.lastName = new System.Windows.Forms.TextBox();
            this.Save = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // firstNameTitle
            // 
            this.firstNameTitle.AutoSize = true;
            this.firstNameTitle.Location = new System.Drawing.Point(12, 9);
            this.firstNameTitle.Name = "firstNameTitle";
            this.firstNameTitle.Size = new System.Drawing.Size(80, 17);
            this.firstNameTitle.TabIndex = 0;
            this.firstNameTitle.Text = "First Name:";
            // 
            // lastNameTitle
            // 
            this.lastNameTitle.AutoSize = true;
            this.lastNameTitle.Location = new System.Drawing.Point(12, 46);
            this.lastNameTitle.Name = "lastNameTitle";
            this.lastNameTitle.Size = new System.Drawing.Size(80, 17);
            this.lastNameTitle.TabIndex = 1;
            this.lastNameTitle.Text = "Last Name:";
            // 
            // firstName
            // 
            this.firstName.Location = new System.Drawing.Point(98, 9);
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(190, 22);
            this.firstName.TabIndex = 2;
            // 
            // lastName
            // 
            this.lastName.Location = new System.Drawing.Point(98, 46);
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(190, 22);
            this.lastName.TabIndex = 3;
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(17, 88);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(271, 23);
            this.Save.TabIndex = 4;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 135);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.lastName);
            this.Controls.Add(this.firstName);
            this.Controls.Add(this.lastNameTitle);
            this.Controls.Add(this.firstNameTitle);
            this.Name = "Form1";
            this.Text = "NikamoozBuild";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label firstNameTitle;
        private System.Windows.Forms.Label lastNameTitle;
        private System.Windows.Forms.TextBox firstName;
        private System.Windows.Forms.TextBox lastName;
        private System.Windows.Forms.Button Save;
    }
}

