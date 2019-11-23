namespace OfferCreation
{
    partial class AddNew
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
            this.LeftPanel = new System.Windows.Forms.Panel();
            this.checkBoxAdminstrator = new System.Windows.Forms.CheckBox();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.textBoxContactorPassword = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelAddress = new System.Windows.Forms.Label();
            this.labelContactPerson = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.radioButtonNewEmployee = new System.Windows.Forms.RadioButton();
            this.radioButtonNewCustomer = new System.Windows.Forms.RadioButton();
            this.panelRight = new System.Windows.Forms.Panel();
            this.dataGridViewEmployees = new System.Windows.Forms.DataGridView();
            this.panelCenter = new System.Windows.Forms.Panel();
            this.dataGridViewCustomers = new System.Windows.Forms.DataGridView();
            this.Create = new System.Windows.Forms.Button();
            this.LeftPanel.SuspendLayout();
            this.panelRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployees)).BeginInit();
            this.panelCenter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomers)).BeginInit();
            this.SuspendLayout();
            // 
            // LeftPanel
            // 
            this.LeftPanel.Controls.Add(this.Create);
            this.LeftPanel.Controls.Add(this.checkBoxAdminstrator);
            this.LeftPanel.Controls.Add(this.textBoxAddress);
            this.LeftPanel.Controls.Add(this.textBoxContactorPassword);
            this.LeftPanel.Controls.Add(this.textBoxName);
            this.LeftPanel.Controls.Add(this.labelAddress);
            this.LeftPanel.Controls.Add(this.labelContactPerson);
            this.LeftPanel.Controls.Add(this.labelName);
            this.LeftPanel.Controls.Add(this.radioButtonNewEmployee);
            this.LeftPanel.Controls.Add(this.radioButtonNewCustomer);
            this.LeftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.LeftPanel.Location = new System.Drawing.Point(0, 0);
            this.LeftPanel.Name = "LeftPanel";
            this.LeftPanel.Size = new System.Drawing.Size(277, 668);
            this.LeftPanel.TabIndex = 0;
            // 
            // checkBoxAdminstrator
            // 
            this.checkBoxAdminstrator.AutoSize = true;
            this.checkBoxAdminstrator.Location = new System.Drawing.Point(150, 118);
            this.checkBoxAdminstrator.Name = "checkBoxAdminstrator";
            this.checkBoxAdminstrator.Size = new System.Drawing.Size(84, 17);
            this.checkBoxAdminstrator.TabIndex = 8;
            this.checkBoxAdminstrator.Text = "Adminstrator";
            this.checkBoxAdminstrator.UseVisualStyleBackColor = true;
            this.checkBoxAdminstrator.Visible = false;
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Location = new System.Drawing.Point(150, 141);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(100, 20);
            this.textBoxAddress.TabIndex = 7;
            // 
            // textBoxContactorPassword
            // 
            this.textBoxContactorPassword.Location = new System.Drawing.Point(150, 88);
            this.textBoxContactorPassword.Name = "textBoxContactorPassword";
            this.textBoxContactorPassword.Size = new System.Drawing.Size(100, 20);
            this.textBoxContactorPassword.TabIndex = 6;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(150, 39);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 20);
            this.textBoxName.TabIndex = 5;
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddress.Location = new System.Drawing.Point(3, 136);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(91, 25);
            this.labelAddress.TabIndex = 4;
            this.labelAddress.Text = "Address";
            // 
            // labelContactPerson
            // 
            this.labelContactPerson.AutoSize = true;
            this.labelContactPerson.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelContactPerson.Location = new System.Drawing.Point(3, 82);
            this.labelContactPerson.Name = "labelContactPerson";
            this.labelContactPerson.Size = new System.Drawing.Size(86, 25);
            this.labelContactPerson.TabIndex = 3;
            this.labelContactPerson.Text = "Contact";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(18, 33);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(71, 26);
            this.labelName.TabIndex = 2;
            this.labelName.Text = "Name";
            // 
            // radioButtonNewEmployee
            // 
            this.radioButtonNewEmployee.AutoSize = true;
            this.radioButtonNewEmployee.Location = new System.Drawing.Point(113, 12);
            this.radioButtonNewEmployee.Name = "radioButtonNewEmployee";
            this.radioButtonNewEmployee.Size = new System.Drawing.Size(96, 17);
            this.radioButtonNewEmployee.TabIndex = 1;
            this.radioButtonNewEmployee.Text = "New Employee";
            this.radioButtonNewEmployee.UseVisualStyleBackColor = true;
            this.radioButtonNewEmployee.Visible = false;
            this.radioButtonNewEmployee.CheckedChanged += new System.EventHandler(this.radioButtonNewEmployee_CheckedChanged);
            // 
            // radioButtonNewCustomer
            // 
            this.radioButtonNewCustomer.AutoSize = true;
            this.radioButtonNewCustomer.Checked = true;
            this.radioButtonNewCustomer.Location = new System.Drawing.Point(13, 13);
            this.radioButtonNewCustomer.Name = "radioButtonNewCustomer";
            this.radioButtonNewCustomer.Size = new System.Drawing.Size(94, 17);
            this.radioButtonNewCustomer.TabIndex = 0;
            this.radioButtonNewCustomer.TabStop = true;
            this.radioButtonNewCustomer.Text = "New Customer";
            this.radioButtonNewCustomer.UseVisualStyleBackColor = true;
            this.radioButtonNewCustomer.CheckedChanged += new System.EventHandler(this.radioButtonNewCustomer_CheckedChanged);
            // 
            // panelRight
            // 
            this.panelRight.Controls.Add(this.dataGridViewEmployees);
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelRight.Location = new System.Drawing.Point(899, 0);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(282, 668);
            this.panelRight.TabIndex = 1;
            // 
            // dataGridViewEmployees
            // 
            this.dataGridViewEmployees.AllowUserToAddRows = false;
            this.dataGridViewEmployees.AllowUserToDeleteRows = false;
            this.dataGridViewEmployees.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEmployees.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewEmployees.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewEmployees.Name = "dataGridViewEmployees";
            this.dataGridViewEmployees.ReadOnly = true;
            this.dataGridViewEmployees.Size = new System.Drawing.Size(282, 668);
            this.dataGridViewEmployees.TabIndex = 1;
            this.dataGridViewEmployees.Visible = false;
            this.dataGridViewEmployees.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // panelCenter
            // 
            this.panelCenter.Controls.Add(this.dataGridViewCustomers);
            this.panelCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCenter.Location = new System.Drawing.Point(277, 0);
            this.panelCenter.Name = "panelCenter";
            this.panelCenter.Size = new System.Drawing.Size(622, 668);
            this.panelCenter.TabIndex = 2;
            // 
            // dataGridViewCustomers
            // 
            this.dataGridViewCustomers.AllowUserToAddRows = false;
            this.dataGridViewCustomers.AllowUserToDeleteRows = false;
            this.dataGridViewCustomers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCustomers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewCustomers.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewCustomers.Name = "dataGridViewCustomers";
            this.dataGridViewCustomers.ReadOnly = true;
            this.dataGridViewCustomers.Size = new System.Drawing.Size(622, 668);
            this.dataGridViewCustomers.TabIndex = 0;
            // 
            // Create
            // 
            this.Create.Location = new System.Drawing.Point(13, 188);
            this.Create.Name = "Create";
            this.Create.Size = new System.Drawing.Size(237, 23);
            this.Create.TabIndex = 9;
            this.Create.Text = "Create";
            this.Create.UseVisualStyleBackColor = true;
            this.Create.Click += new System.EventHandler(this.Create_Click);
            // 
            // AddNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1181, 668);
            this.Controls.Add(this.panelCenter);
            this.Controls.Add(this.panelRight);
            this.Controls.Add(this.LeftPanel);
            this.Name = "AddNew";
            this.Text = "Add new";
            this.LeftPanel.ResumeLayout(false);
            this.LeftPanel.PerformLayout();
            this.panelRight.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployees)).EndInit();
            this.panelCenter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel LeftPanel;
        private System.Windows.Forms.RadioButton radioButtonNewEmployee;
        private System.Windows.Forms.RadioButton radioButtonNewCustomer;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.Panel panelCenter;
        private System.Windows.Forms.DataGridView dataGridViewCustomers;
        private System.Windows.Forms.DataGridView dataGridViewEmployees;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.Label labelContactPerson;
        private System.Windows.Forms.CheckBox checkBoxAdminstrator;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.TextBox textBoxContactorPassword;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Button Create;
    }
}