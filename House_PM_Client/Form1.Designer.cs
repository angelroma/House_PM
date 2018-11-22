namespace House_PM_Client
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
            this.LabelID = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.GetById = new System.Windows.Forms.Button();
            this.GetAll = new System.Windows.Forms.Button();
            this.Create = new System.Windows.Forms.Button();
            this.Edit = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LabelPhone = new System.Windows.Forms.Label();
            this.LabelEmail = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LabelID
            // 
            this.LabelID.AutoSize = true;
            this.LabelID.Location = new System.Drawing.Point(263, 18);
            this.LabelID.Name = "LabelID";
            this.LabelID.Size = new System.Drawing.Size(37, 13);
            this.LabelID.TabIndex = 0;
            this.LabelID.Text = "Result";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 18);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Test()";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(137, 18);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(75, 20);
            this.txtID.TabIndex = 2;
            // 
            // GetById
            // 
            this.GetById.Location = new System.Drawing.Point(12, 47);
            this.GetById.Name = "GetById";
            this.GetById.Size = new System.Drawing.Size(75, 23);
            this.GetById.TabIndex = 3;
            this.GetById.Text = "GetById()";
            this.GetById.UseVisualStyleBackColor = true;
            this.GetById.Click += new System.EventHandler(this.button2_Click);
            // 
            // GetAll
            // 
            this.GetAll.Location = new System.Drawing.Point(12, 76);
            this.GetAll.Name = "GetAll";
            this.GetAll.Size = new System.Drawing.Size(75, 23);
            this.GetAll.TabIndex = 4;
            this.GetAll.Text = "GetAll()";
            this.GetAll.UseVisualStyleBackColor = true;
            this.GetAll.Click += new System.EventHandler(this.GetAll_Click);
            // 
            // Create
            // 
            this.Create.Location = new System.Drawing.Point(12, 105);
            this.Create.Name = "Create";
            this.Create.Size = new System.Drawing.Size(75, 23);
            this.Create.TabIndex = 5;
            this.Create.Text = "Create()";
            this.Create.UseVisualStyleBackColor = true;
            this.Create.Click += new System.EventHandler(this.Create_Click);
            // 
            // Edit
            // 
            this.Edit.Location = new System.Drawing.Point(12, 134);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(75, 23);
            this.Edit.TabIndex = 6;
            this.Edit.Text = "Edit()";
            this.Edit.UseVisualStyleBackColor = true;
            this.Edit.Click += new System.EventHandler(this.Edit_Click);
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(12, 163);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(75, 23);
            this.Delete.TabIndex = 7;
            this.Delete.Text = "Delete()";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(137, 43);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 8;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(137, 69);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(100, 20);
            this.txtPhone.TabIndex = 9;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(137, 95);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(100, 20);
            this.txtEmail.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(110, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(96, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Name";
            // 
            // LabelPhone
            // 
            this.LabelPhone.AutoSize = true;
            this.LabelPhone.Location = new System.Drawing.Point(93, 72);
            this.LabelPhone.Name = "LabelPhone";
            this.LabelPhone.Size = new System.Drawing.Size(38, 13);
            this.LabelPhone.TabIndex = 13;
            this.LabelPhone.Text = "Phone";
            // 
            // LabelEmail
            // 
            this.LabelEmail.AutoSize = true;
            this.LabelEmail.Location = new System.Drawing.Point(96, 98);
            this.LabelEmail.Name = "LabelEmail";
            this.LabelEmail.Size = new System.Drawing.Size(35, 13);
            this.LabelEmail.TabIndex = 14;
            this.LabelEmail.Text = "Email:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LabelEmail);
            this.Controls.Add(this.LabelPhone);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Edit);
            this.Controls.Add(this.Create);
            this.Controls.Add(this.GetAll);
            this.Controls.Add(this.GetById);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.LabelID);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelID;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Button GetById;
        private System.Windows.Forms.Button GetAll;
        private System.Windows.Forms.Button Create;
        private System.Windows.Forms.Button Edit;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LabelPhone;
        private System.Windows.Forms.Label LabelEmail;
    }
}

