namespace OfferCreation
{
    partial class OfferCreator
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
            this.upperPanel = new System.Windows.Forms.Panel();
            this.labelGreeting = new System.Windows.Forms.Label();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.buttonAddNew = new System.Windows.Forms.Button();
            this.labelChooseCustomer = new System.Windows.Forms.Label();
            this.comboBoxCustomerChoice = new System.Windows.Forms.ComboBox();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.DescriptionColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CountColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LaborColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaterialsColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EquipmentColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalUnitCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelPanel = new System.Windows.Forms.Panel();
            this.textBoxCommentary = new System.Windows.Forms.TextBox();
            this.labelCommentaryTitle = new System.Windows.Forms.Label();
            this.textBoxWorkSite = new System.Windows.Forms.TextBox();
            this.labelWorkSite = new System.Windows.Forms.Label();
            this.textBoxOfferTitle = new System.Windows.Forms.TextBox();
            this.labelTitleOfOffer = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.comboBoxOfferChoice = new System.Windows.Forms.ComboBox();
            this.labelOfferTitle = new System.Windows.Forms.Label();
            this.labelTotalWithVat = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelVatAmount = new System.Windows.Forms.Label();
            this.labelVat = new System.Windows.Forms.Label();
            this.labelTotalCost = new System.Windows.Forms.Label();
            this.labelTotalCostTitle = new System.Windows.Forms.Label();
            this.labelEquipmentCost = new System.Windows.Forms.Label();
            this.labelMaterialCost = new System.Windows.Forms.Label();
            this.labelLaborCost = new System.Windows.Forms.Label();
            this.labelEquipmentCostTitle = new System.Windows.Forms.Label();
            this.labelMaterialCostTitle = new System.Windows.Forms.Label();
            this.labelTotalLaborTitle = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.buttonClearDataGridVIew = new System.Windows.Forms.Button();
            this.buttonDeleteOffer = new System.Windows.Forms.Button();
            this.upperPanel.SuspendLayout();
            this.mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.labelPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // upperPanel
            // 
            this.upperPanel.AutoSize = true;
            this.upperPanel.Controls.Add(this.labelGreeting);
            this.upperPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.upperPanel.Location = new System.Drawing.Point(0, 0);
            this.upperPanel.Name = "upperPanel";
            this.upperPanel.Size = new System.Drawing.Size(1310, 38);
            this.upperPanel.TabIndex = 0;
            // 
            // labelGreeting
            // 
            this.labelGreeting.AutoSize = true;
            this.labelGreeting.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGreeting.Location = new System.Drawing.Point(3, 9);
            this.labelGreeting.Name = "labelGreeting";
            this.labelGreeting.Size = new System.Drawing.Size(124, 29);
            this.labelGreeting.TabIndex = 0;
            this.labelGreeting.Text = "Hey Guest";
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Location = new System.Drawing.Point(8, 3);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(316, 23);
            this.buttonRefresh.TabIndex = 4;
            this.buttonRefresh.Text = "Refresh";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // buttonAddNew
            // 
            this.buttonAddNew.Location = new System.Drawing.Point(8, 54);
            this.buttonAddNew.Name = "buttonAddNew";
            this.buttonAddNew.Size = new System.Drawing.Size(316, 23);
            this.buttonAddNew.TabIndex = 3;
            this.buttonAddNew.Text = "Add new";
            this.buttonAddNew.UseVisualStyleBackColor = true;
            this.buttonAddNew.Click += new System.EventHandler(this.buttonAddNew_Click);
            // 
            // labelChooseCustomer
            // 
            this.labelChooseCustomer.AutoSize = true;
            this.labelChooseCustomer.Location = new System.Drawing.Point(6, 37);
            this.labelChooseCustomer.Name = "labelChooseCustomer";
            this.labelChooseCustomer.Size = new System.Drawing.Size(90, 13);
            this.labelChooseCustomer.TabIndex = 2;
            this.labelChooseCustomer.Text = "Choose Customer";
            // 
            // comboBoxCustomerChoice
            // 
            this.comboBoxCustomerChoice.FormattingEnabled = true;
            this.comboBoxCustomerChoice.Location = new System.Drawing.Point(108, 35);
            this.comboBoxCustomerChoice.Name = "comboBoxCustomerChoice";
            this.comboBoxCustomerChoice.Size = new System.Drawing.Size(217, 21);
            this.comboBoxCustomerChoice.TabIndex = 1;
            this.comboBoxCustomerChoice.SelectedIndexChanged += new System.EventHandler(this.comboBoxCustomerChoice_SelectedIndexChanged);
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.dataGridView1);
            this.mainPanel.Controls.Add(this.labelPanel);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 38);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1310, 807);
            this.mainPanel.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DescriptionColumn,
            this.UnitColumn,
            this.CountColumn,
            this.LaborColumn,
            this.MaterialsColumn,
            this.EquipmentColumn,
            this.TotalUnitCost,
            this.TotalCost});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(976, 807);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValue);
            // 
            // DescriptionColumn
            // 
            this.DescriptionColumn.HeaderText = "Description";
            this.DescriptionColumn.MaxInputLength = 50;
            this.DescriptionColumn.MinimumWidth = 6;
            this.DescriptionColumn.Name = "DescriptionColumn";
            // 
            // UnitColumn
            // 
            this.UnitColumn.HeaderText = "Unit";
            this.UnitColumn.MinimumWidth = 6;
            this.UnitColumn.Name = "UnitColumn";
            // 
            // CountColumn
            // 
            this.CountColumn.HeaderText = "Count";
            this.CountColumn.MinimumWidth = 6;
            this.CountColumn.Name = "CountColumn";
            // 
            // LaborColumn
            // 
            this.LaborColumn.HeaderText = "Labor";
            this.LaborColumn.MinimumWidth = 6;
            this.LaborColumn.Name = "LaborColumn";
            // 
            // MaterialsColumn
            // 
            this.MaterialsColumn.HeaderText = "Materials";
            this.MaterialsColumn.MinimumWidth = 6;
            this.MaterialsColumn.Name = "MaterialsColumn";
            // 
            // EquipmentColumn
            // 
            this.EquipmentColumn.HeaderText = "Equipment";
            this.EquipmentColumn.MinimumWidth = 6;
            this.EquipmentColumn.Name = "EquipmentColumn";
            // 
            // TotalUnitCost
            // 
            this.TotalUnitCost.HeaderText = "Total Unit Cost";
            this.TotalUnitCost.MinimumWidth = 6;
            this.TotalUnitCost.Name = "TotalUnitCost";
            this.TotalUnitCost.ReadOnly = true;
            // 
            // TotalCost
            // 
            this.TotalCost.HeaderText = "Total Cost";
            this.TotalCost.MinimumWidth = 6;
            this.TotalCost.Name = "TotalCost";
            this.TotalCost.ReadOnly = true;
            // 
            // labelPanel
            // 
            this.labelPanel.Controls.Add(this.buttonDeleteOffer);
            this.labelPanel.Controls.Add(this.buttonClearDataGridVIew);
            this.labelPanel.Controls.Add(this.textBoxCommentary);
            this.labelPanel.Controls.Add(this.labelCommentaryTitle);
            this.labelPanel.Controls.Add(this.textBoxWorkSite);
            this.labelPanel.Controls.Add(this.labelWorkSite);
            this.labelPanel.Controls.Add(this.textBoxOfferTitle);
            this.labelPanel.Controls.Add(this.labelTitleOfOffer);
            this.labelPanel.Controls.Add(this.buttonSave);
            this.labelPanel.Controls.Add(this.buttonLoad);
            this.labelPanel.Controls.Add(this.comboBoxOfferChoice);
            this.labelPanel.Controls.Add(this.labelOfferTitle);
            this.labelPanel.Controls.Add(this.buttonRefresh);
            this.labelPanel.Controls.Add(this.labelTotalWithVat);
            this.labelPanel.Controls.Add(this.buttonAddNew);
            this.labelPanel.Controls.Add(this.label1);
            this.labelPanel.Controls.Add(this.comboBoxCustomerChoice);
            this.labelPanel.Controls.Add(this.labelChooseCustomer);
            this.labelPanel.Controls.Add(this.labelVatAmount);
            this.labelPanel.Controls.Add(this.labelVat);
            this.labelPanel.Controls.Add(this.labelTotalCost);
            this.labelPanel.Controls.Add(this.labelTotalCostTitle);
            this.labelPanel.Controls.Add(this.labelEquipmentCost);
            this.labelPanel.Controls.Add(this.labelMaterialCost);
            this.labelPanel.Controls.Add(this.labelLaborCost);
            this.labelPanel.Controls.Add(this.labelEquipmentCostTitle);
            this.labelPanel.Controls.Add(this.labelMaterialCostTitle);
            this.labelPanel.Controls.Add(this.labelTotalLaborTitle);
            this.labelPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.labelPanel.Location = new System.Drawing.Point(976, 0);
            this.labelPanel.Name = "labelPanel";
            this.labelPanel.Size = new System.Drawing.Size(334, 807);
            this.labelPanel.TabIndex = 0;
            // 
            // textBoxCommentary
            // 
            this.textBoxCommentary.Location = new System.Drawing.Point(108, 152);
            this.textBoxCommentary.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxCommentary.Name = "textBoxCommentary";
            this.textBoxCommentary.Size = new System.Drawing.Size(217, 20);
            this.textBoxCommentary.TabIndex = 21;
            // 
            // labelCommentaryTitle
            // 
            this.labelCommentaryTitle.AutoSize = true;
            this.labelCommentaryTitle.Location = new System.Drawing.Point(6, 154);
            this.labelCommentaryTitle.Name = "labelCommentaryTitle";
            this.labelCommentaryTitle.Size = new System.Drawing.Size(65, 13);
            this.labelCommentaryTitle.TabIndex = 20;
            this.labelCommentaryTitle.Text = "Commentary";
            // 
            // textBoxWorkSite
            // 
            this.textBoxWorkSite.Location = new System.Drawing.Point(108, 129);
            this.textBoxWorkSite.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxWorkSite.Name = "textBoxWorkSite";
            this.textBoxWorkSite.Size = new System.Drawing.Size(217, 20);
            this.textBoxWorkSite.TabIndex = 19;
            // 
            // labelWorkSite
            // 
            this.labelWorkSite.AutoSize = true;
            this.labelWorkSite.Location = new System.Drawing.Point(6, 132);
            this.labelWorkSite.Name = "labelWorkSite";
            this.labelWorkSite.Size = new System.Drawing.Size(54, 13);
            this.labelWorkSite.TabIndex = 18;
            this.labelWorkSite.Text = "Work Site";
            // 
            // textBoxOfferTitle
            // 
            this.textBoxOfferTitle.Location = new System.Drawing.Point(108, 106);
            this.textBoxOfferTitle.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxOfferTitle.Name = "textBoxOfferTitle";
            this.textBoxOfferTitle.Size = new System.Drawing.Size(217, 20);
            this.textBoxOfferTitle.TabIndex = 17;
            // 
            // labelTitleOfOffer
            // 
            this.labelTitleOfOffer.AutoSize = true;
            this.labelTitleOfOffer.Location = new System.Drawing.Point(4, 109);
            this.labelTitleOfOffer.Name = "labelTitleOfOffer";
            this.labelTitleOfOffer.Size = new System.Drawing.Size(53, 13);
            this.labelTitleOfOffer.TabIndex = 16;
            this.labelTitleOfOffer.Text = "Offer Title";
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(189, 175);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(135, 23);
            this.buttonSave.TabIndex = 15;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonLoad
            // 
            this.buttonLoad.Location = new System.Drawing.Point(8, 175);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(135, 23);
            this.buttonLoad.TabIndex = 14;
            this.buttonLoad.Text = "Load";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // comboBoxOfferChoice
            // 
            this.comboBoxOfferChoice.FormattingEnabled = true;
            this.comboBoxOfferChoice.Location = new System.Drawing.Point(108, 80);
            this.comboBoxOfferChoice.Name = "comboBoxOfferChoice";
            this.comboBoxOfferChoice.Size = new System.Drawing.Size(217, 21);
            this.comboBoxOfferChoice.TabIndex = 13;
            this.comboBoxOfferChoice.SelectedIndexChanged += new System.EventHandler(this.comboBoxOfferChoice_SelectedIndexChanged);
            // 
            // labelOfferTitle
            // 
            this.labelOfferTitle.AutoSize = true;
            this.labelOfferTitle.Location = new System.Drawing.Point(6, 83);
            this.labelOfferTitle.Name = "labelOfferTitle";
            this.labelOfferTitle.Size = new System.Drawing.Size(69, 13);
            this.labelOfferTitle.TabIndex = 12;
            this.labelOfferTitle.Text = "Choose Offer";
            // 
            // labelTotalWithVat
            // 
            this.labelTotalWithVat.AutoSize = true;
            this.labelTotalWithVat.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.labelTotalWithVat.Location = new System.Drawing.Point(215, 406);
            this.labelTotalWithVat.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTotalWithVat.Name = "labelTotalWithVat";
            this.labelTotalWithVat.Size = new System.Drawing.Size(94, 31);
            this.labelTotalWithVat.TabIndex = 11;
            this.labelTotalWithVat.Text = "0 EUR";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label1.Location = new System.Drawing.Point(65, 405);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 31);
            this.label1.TabIndex = 10;
            this.label1.Text = "Total Cost";
            // 
            // labelVatAmount
            // 
            this.labelVatAmount.AutoSize = true;
            this.labelVatAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.labelVatAmount.Location = new System.Drawing.Point(215, 375);
            this.labelVatAmount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelVatAmount.Name = "labelVatAmount";
            this.labelVatAmount.Size = new System.Drawing.Size(94, 31);
            this.labelVatAmount.TabIndex = 9;
            this.labelVatAmount.Text = "0 EUR";
            // 
            // labelVat
            // 
            this.labelVat.AutoSize = true;
            this.labelVat.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.labelVat.Location = new System.Drawing.Point(131, 375);
            this.labelVat.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelVat.Name = "labelVat";
            this.labelVat.Size = new System.Drawing.Size(67, 31);
            this.labelVat.TabIndex = 8;
            this.labelVat.Text = "VAT";
            // 
            // labelTotalCost
            // 
            this.labelTotalCost.AutoSize = true;
            this.labelTotalCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.labelTotalCost.Location = new System.Drawing.Point(215, 344);
            this.labelTotalCost.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTotalCost.Name = "labelTotalCost";
            this.labelTotalCost.Size = new System.Drawing.Size(94, 31);
            this.labelTotalCost.TabIndex = 7;
            this.labelTotalCost.Text = "0 EUR";
            // 
            // labelTotalCostTitle
            // 
            this.labelTotalCostTitle.AutoSize = true;
            this.labelTotalCostTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.labelTotalCostTitle.Location = new System.Drawing.Point(28, 344);
            this.labelTotalCostTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTotalCostTitle.Name = "labelTotalCostTitle";
            this.labelTotalCostTitle.Size = new System.Drawing.Size(181, 31);
            this.labelTotalCostTitle.TabIndex = 6;
            this.labelTotalCostTitle.Text = "Cost w/o VAT";
            // 
            // labelEquipmentCost
            // 
            this.labelEquipmentCost.AutoSize = true;
            this.labelEquipmentCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.labelEquipmentCost.Location = new System.Drawing.Point(195, 318);
            this.labelEquipmentCost.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelEquipmentCost.Name = "labelEquipmentCost";
            this.labelEquipmentCost.Size = new System.Drawing.Size(57, 20);
            this.labelEquipmentCost.TabIndex = 5;
            this.labelEquipmentCost.Text = "0 EUR";
            // 
            // labelMaterialCost
            // 
            this.labelMaterialCost.AutoSize = true;
            this.labelMaterialCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.labelMaterialCost.Location = new System.Drawing.Point(195, 298);
            this.labelMaterialCost.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMaterialCost.Name = "labelMaterialCost";
            this.labelMaterialCost.Size = new System.Drawing.Size(57, 20);
            this.labelMaterialCost.TabIndex = 4;
            this.labelMaterialCost.Text = "0 EUR";
            // 
            // labelLaborCost
            // 
            this.labelLaborCost.AutoSize = true;
            this.labelLaborCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.labelLaborCost.Location = new System.Drawing.Point(195, 278);
            this.labelLaborCost.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelLaborCost.Name = "labelLaborCost";
            this.labelLaborCost.Size = new System.Drawing.Size(57, 20);
            this.labelLaborCost.TabIndex = 3;
            this.labelLaborCost.Text = "0 EUR";
            // 
            // labelEquipmentCostTitle
            // 
            this.labelEquipmentCostTitle.AutoSize = true;
            this.labelEquipmentCostTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.labelEquipmentCostTitle.Location = new System.Drawing.Point(75, 318);
            this.labelEquipmentCostTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelEquipmentCostTitle.Name = "labelEquipmentCostTitle";
            this.labelEquipmentCostTitle.Size = new System.Drawing.Size(125, 20);
            this.labelEquipmentCostTitle.TabIndex = 2;
            this.labelEquipmentCostTitle.Text = "Total Equipment";
            // 
            // labelMaterialCostTitle
            // 
            this.labelMaterialCostTitle.AutoSize = true;
            this.labelMaterialCostTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.labelMaterialCostTitle.Location = new System.Drawing.Point(93, 298);
            this.labelMaterialCostTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMaterialCostTitle.Name = "labelMaterialCostTitle";
            this.labelMaterialCostTitle.Size = new System.Drawing.Size(104, 20);
            this.labelMaterialCostTitle.TabIndex = 1;
            this.labelMaterialCostTitle.Text = "Total Material";
            // 
            // labelTotalLaborTitle
            // 
            this.labelTotalLaborTitle.AutoSize = true;
            this.labelTotalLaborTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.labelTotalLaborTitle.Location = new System.Drawing.Point(107, 278);
            this.labelTotalLaborTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTotalLaborTitle.Name = "labelTotalLaborTitle";
            this.labelTotalLaborTitle.Size = new System.Drawing.Size(89, 20);
            this.labelTotalLaborTitle.TabIndex = 0;
            this.labelTotalLaborTitle.Text = "Total Labor";
            // 
            // buttonClearDataGridVIew
            // 
            this.buttonClearDataGridVIew.Location = new System.Drawing.Point(189, 204);
            this.buttonClearDataGridVIew.Name = "buttonClearDataGridVIew";
            this.buttonClearDataGridVIew.Size = new System.Drawing.Size(135, 23);
            this.buttonClearDataGridVIew.TabIndex = 22;
            this.buttonClearDataGridVIew.Text = "Clear";
            this.buttonClearDataGridVIew.UseVisualStyleBackColor = true;
            this.buttonClearDataGridVIew.Click += new System.EventHandler(this.buttonClearDataGridVIew_Click);
            // 
            // buttonDeleteOffer
            // 
            this.buttonDeleteOffer.Location = new System.Drawing.Point(8, 204);
            this.buttonDeleteOffer.Name = "buttonDeleteOffer";
            this.buttonDeleteOffer.Size = new System.Drawing.Size(135, 23);
            this.buttonDeleteOffer.TabIndex = 23;
            this.buttonDeleteOffer.Text = "Delete";
            this.buttonDeleteOffer.UseVisualStyleBackColor = true;
            this.buttonDeleteOffer.Click += new System.EventHandler(this.buttonDeleteOffer_Click);
            // 
            // OfferCreator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1310, 845);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.upperPanel);
            this.Name = "OfferCreator";
            this.Text = "Offer Creator";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.upperPanel.ResumeLayout(false);
            this.upperPanel.PerformLayout();
            this.mainPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.labelPanel.ResumeLayout(false);
            this.labelPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel upperPanel;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel labelPanel;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescriptionColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CountColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn LaborColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaterialsColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn EquipmentColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalUnitCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalCost;
        private System.Windows.Forms.Label labelGreeting;
        private System.Windows.Forms.Button buttonAddNew;
        private System.Windows.Forms.Label labelChooseCustomer;
        private System.Windows.Forms.ComboBox comboBoxCustomerChoice;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.Label labelEquipmentCost;
        private System.Windows.Forms.Label labelMaterialCost;
        private System.Windows.Forms.Label labelLaborCost;
        private System.Windows.Forms.Label labelEquipmentCostTitle;
        private System.Windows.Forms.Label labelMaterialCostTitle;
        private System.Windows.Forms.Label labelTotalLaborTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelVatAmount;
        private System.Windows.Forms.Label labelVat;
        private System.Windows.Forms.Label labelTotalCost;
        private System.Windows.Forms.Label labelTotalCostTitle;
        private System.Windows.Forms.Label labelTotalWithVat;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.ComboBox comboBoxOfferChoice;
        private System.Windows.Forms.Label labelOfferTitle;
        private System.Windows.Forms.Label labelTitleOfOffer;
        private System.Windows.Forms.TextBox textBoxOfferTitle;
        private System.Windows.Forms.TextBox textBoxWorkSite;
        private System.Windows.Forms.Label labelWorkSite;
        private System.Windows.Forms.TextBox textBoxCommentary;
        private System.Windows.Forms.Label labelCommentaryTitle;
        private System.Windows.Forms.Button buttonDeleteOffer;
        private System.Windows.Forms.Button buttonClearDataGridVIew;
    }
}

