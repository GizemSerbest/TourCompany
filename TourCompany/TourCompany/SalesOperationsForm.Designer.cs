namespace TourCompany
{
    partial class SalesOperationsForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.chbOldAge = new System.Windows.Forms.RadioButton();
            this.chbStudent = new System.Windows.Forms.RadioButton();
            this.chbChild = new System.Windows.Forms.RadioButton();
            this.chbStandart = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chbFemale = new System.Windows.Forms.RadioButton();
            this.chbMale = new System.Windows.Forms.RadioButton();
            this.txtCsName = new System.Windows.Forms.TextBox();
            this.txtCname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBox2 = new System.Windows.Forms.RadioButton();
            this.checkBox1 = new System.Windows.Forms.RadioButton();
            this.lstSalesOperations = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnComplete = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.txtCsName);
            this.groupBox1.Controls.Add(this.txtCname);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(322, 256);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Customer Info";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.chbOldAge);
            this.groupBox4.Controls.Add(this.chbStudent);
            this.groupBox4.Controls.Add(this.chbChild);
            this.groupBox4.Controls.Add(this.chbStandart);
            this.groupBox4.Location = new System.Drawing.Point(19, 156);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(280, 94);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Customer Type";
            this.groupBox4.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // chbOldAge
            // 
            this.chbOldAge.AutoSize = true;
            this.chbOldAge.Location = new System.Drawing.Point(112, 62);
            this.chbOldAge.Name = "chbOldAge";
            this.chbOldAge.Size = new System.Drawing.Size(63, 17);
            this.chbOldAge.TabIndex = 5;
            this.chbOldAge.TabStop = true;
            this.chbOldAge.Text = "Old Age";
            this.chbOldAge.UseVisualStyleBackColor = true;
            // 
            // chbStudent
            // 
            this.chbStudent.AutoSize = true;
            this.chbStudent.Location = new System.Drawing.Point(7, 62);
            this.chbStudent.Name = "chbStudent";
            this.chbStudent.Size = new System.Drawing.Size(62, 17);
            this.chbStudent.TabIndex = 2;
            this.chbStudent.TabStop = true;
            this.chbStudent.Text = "Student";
            this.chbStudent.UseVisualStyleBackColor = true;
            // 
            // chbChild
            // 
            this.chbChild.AutoSize = true;
            this.chbChild.Location = new System.Drawing.Point(111, 25);
            this.chbChild.Name = "chbChild";
            this.chbChild.Size = new System.Drawing.Size(48, 17);
            this.chbChild.TabIndex = 1;
            this.chbChild.TabStop = true;
            this.chbChild.Text = "Child";
            this.chbChild.UseVisualStyleBackColor = true;
            // 
            // chbStandart
            // 
            this.chbStandart.AutoSize = true;
            this.chbStandart.Location = new System.Drawing.Point(7, 25);
            this.chbStandart.Name = "chbStandart";
            this.chbStandart.Size = new System.Drawing.Size(65, 17);
            this.chbStandart.TabIndex = 0;
            this.chbStandart.TabStop = true;
            this.chbStandart.Text = "Standart";
            this.chbStandart.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.chbFemale);
            this.groupBox3.Controls.Add(this.chbMale);
            this.groupBox3.Location = new System.Drawing.Point(19, 77);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(270, 72);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Gender";
            // 
            // chbFemale
            // 
            this.chbFemale.AutoSize = true;
            this.chbFemale.Location = new System.Drawing.Point(111, 28);
            this.chbFemale.Name = "chbFemale";
            this.chbFemale.Size = new System.Drawing.Size(59, 17);
            this.chbFemale.TabIndex = 1;
            this.chbFemale.TabStop = true;
            this.chbFemale.Text = "Female";
            this.chbFemale.UseVisualStyleBackColor = true;
            // 
            // chbMale
            // 
            this.chbMale.AutoSize = true;
            this.chbMale.Location = new System.Drawing.Point(8, 29);
            this.chbMale.Name = "chbMale";
            this.chbMale.Size = new System.Drawing.Size(48, 17);
            this.chbMale.TabIndex = 0;
            this.chbMale.TabStop = true;
            this.chbMale.Text = "Male";
            this.chbMale.UseVisualStyleBackColor = true;
            // 
            // txtCsName
            // 
            this.txtCsName.Location = new System.Drawing.Point(131, 51);
            this.txtCsName.Name = "txtCsName";
            this.txtCsName.Size = new System.Drawing.Size(173, 20);
            this.txtCsName.TabIndex = 3;
            // 
            // txtCname
            // 
            this.txtCname.Location = new System.Drawing.Point(131, 22);
            this.txtCname.Name = "txtCname";
            this.txtCname.Size = new System.Drawing.Size(173, 20);
            this.txtCname.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Customer Surname";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer Name";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkBox2);
            this.groupBox2.Controls.Add(this.checkBox1);
            this.groupBox2.Location = new System.Drawing.Point(355, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(322, 71);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Departure Information";
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(193, 27);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(88, 17);
            this.checkBox2.TabIndex = 2;
            this.checkBox2.TabStop = true;
            this.checkBox2.Text = "Not Available";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(18, 27);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(68, 17);
            this.checkBox1.TabIndex = 1;
            this.checkBox1.TabStop = true;
            this.checkBox1.Text = "Available";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // lstSalesOperations
            // 
            this.lstSalesOperations.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.lstSalesOperations.FullRowSelect = true;
            this.lstSalesOperations.GridLines = true;
            this.lstSalesOperations.Location = new System.Drawing.Point(13, 291);
            this.lstSalesOperations.Name = "lstSalesOperations";
            this.lstSalesOperations.Size = new System.Drawing.Size(766, 173);
            this.lstSalesOperations.TabIndex = 2;
            this.lstSalesOperations.UseCompatibleStateImageBehavior = false;
            this.lstSalesOperations.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tour Name";
            this.columnHeader1.Width = 90;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Customer";
            this.columnHeader2.Width = 127;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Gender";
            this.columnHeader3.Width = 97;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Customer Type";
            this.columnHeader4.Width = 155;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Price";
            this.columnHeader5.Width = 142;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Airplane Status";
            this.columnHeader6.Width = 149;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(575, 246);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(204, 23);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add To List";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnComplete
            // 
            this.btnComplete.Location = new System.Drawing.Point(594, 483);
            this.btnComplete.Name = "btnComplete";
            this.btnComplete.Size = new System.Drawing.Size(185, 23);
            this.btnComplete.TabIndex = 4;
            this.btnComplete.Text = "Complete Sales";
            this.btnComplete.UseVisualStyleBackColor = true;
            this.btnComplete.Click += new System.EventHandler(this.btnComplete_Click);
            // 
            // SalesOperationsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 523);
            this.Controls.Add(this.btnComplete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lstSalesOperations);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "SalesOperationsForm";
            this.Text = "SalesOperationsForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCsName;
        private System.Windows.Forms.TextBox txtCname;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView lstSalesOperations;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnComplete;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton chbFemale;
        private System.Windows.Forms.RadioButton chbMale;
        private System.Windows.Forms.RadioButton checkBox2;
        private System.Windows.Forms.RadioButton checkBox1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton chbStandart;
        private System.Windows.Forms.RadioButton chbOldAge;
        private System.Windows.Forms.RadioButton chbStudent;
        private System.Windows.Forms.RadioButton chbChild;
    }
}