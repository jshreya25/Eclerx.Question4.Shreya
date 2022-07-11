namespace Test2
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
            this.LblEmpNo = new System.Windows.Forms.Label();
            this.TxtEmpNo = new System.Windows.Forms.TextBox();
            this.TxtEmpName = new System.Windows.Forms.TextBox();
            this.LblEmpName = new System.Windows.Forms.Label();
            this.TxtSalary = new System.Windows.Forms.TextBox();
            this.LblSalary = new System.Windows.Forms.Label();
            this.RadioPayroll = new System.Windows.Forms.RadioButton();
            this.LblEmpType = new System.Windows.Forms.Label();
            this.RadioConsult = new System.Windows.Forms.RadioButton();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.BtnReset = new System.Windows.Forms.Button();
            this.GridEmployee = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.GridEmployee)).BeginInit();
            this.SuspendLayout();
            // 
            // LblEmpNo
            // 
            this.LblEmpNo.AutoSize = true;
            this.LblEmpNo.Location = new System.Drawing.Point(99, 30);
            this.LblEmpNo.Name = "LblEmpNo";
            this.LblEmpNo.Size = new System.Drawing.Size(103, 20);
            this.LblEmpNo.TabIndex = 0;
            this.LblEmpNo.Text = "Employee No";
            // 
            // TxtEmpNo
            // 
            this.TxtEmpNo.Location = new System.Drawing.Point(277, 30);
            this.TxtEmpNo.Name = "TxtEmpNo";
            this.TxtEmpNo.Size = new System.Drawing.Size(162, 26);
            this.TxtEmpNo.TabIndex = 1;
            // 
            // TxtEmpName
            // 
            this.TxtEmpName.Location = new System.Drawing.Point(277, 87);
            this.TxtEmpName.Name = "TxtEmpName";
            this.TxtEmpName.Size = new System.Drawing.Size(162, 26);
            this.TxtEmpName.TabIndex = 3;
            // 
            // LblEmpName
            // 
            this.LblEmpName.AutoSize = true;
            this.LblEmpName.Location = new System.Drawing.Point(99, 87);
            this.LblEmpName.Name = "LblEmpName";
            this.LblEmpName.Size = new System.Drawing.Size(125, 20);
            this.LblEmpName.TabIndex = 2;
            this.LblEmpName.Text = "Employee Name";
            // 
            // TxtSalary
            // 
            this.TxtSalary.Location = new System.Drawing.Point(277, 143);
            this.TxtSalary.Name = "TxtSalary";
            this.TxtSalary.Size = new System.Drawing.Size(162, 26);
            this.TxtSalary.TabIndex = 5;
            // 
            // LblSalary
            // 
            this.LblSalary.AutoSize = true;
            this.LblSalary.Location = new System.Drawing.Point(99, 143);
            this.LblSalary.Name = "LblSalary";
            this.LblSalary.Size = new System.Drawing.Size(53, 20);
            this.LblSalary.TabIndex = 4;
            this.LblSalary.Text = "Salary";
            // 
            // RadioPayroll
            // 
            this.RadioPayroll.AutoSize = true;
            this.RadioPayroll.Location = new System.Drawing.Point(588, 101);
            this.RadioPayroll.Name = "RadioPayroll";
            this.RadioPayroll.Size = new System.Drawing.Size(80, 24);
            this.RadioPayroll.TabIndex = 6;
            this.RadioPayroll.TabStop = true;
            this.RadioPayroll.Text = "Payroll";
            this.RadioPayroll.UseVisualStyleBackColor = true;
            // 
            // LblEmpType
            // 
            this.LblEmpType.AutoSize = true;
            this.LblEmpType.Location = new System.Drawing.Point(597, 46);
            this.LblEmpType.Name = "LblEmpType";
            this.LblEmpType.Size = new System.Drawing.Size(117, 20);
            this.LblEmpType.TabIndex = 7;
            this.LblEmpType.Text = "Employee Type";
            // 
            // RadioConsult
            // 
            this.RadioConsult.AutoSize = true;
            this.RadioConsult.Location = new System.Drawing.Point(588, 157);
            this.RadioConsult.Name = "RadioConsult";
            this.RadioConsult.Size = new System.Drawing.Size(111, 24);
            this.RadioConsult.TabIndex = 8;
            this.RadioConsult.TabStop = true;
            this.RadioConsult.Text = "Consultant";
            this.RadioConsult.UseVisualStyleBackColor = true;
            // 
            // BtnAdd
            // 
            this.BtnAdd.Location = new System.Drawing.Point(230, 190);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(96, 31);
            this.BtnAdd.TabIndex = 9;
            this.BtnAdd.Text = "Add New";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // BtnReset
            // 
            this.BtnReset.Location = new System.Drawing.Point(382, 190);
            this.BtnReset.Name = "BtnReset";
            this.BtnReset.Size = new System.Drawing.Size(97, 31);
            this.BtnReset.TabIndex = 10;
            this.BtnReset.Text = "Reset";
            this.BtnReset.UseVisualStyleBackColor = true;
            this.BtnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // GridEmployee
            // 
            this.GridEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridEmployee.Location = new System.Drawing.Point(60, 259);
            this.GridEmployee.Name = "GridEmployee";
            this.GridEmployee.RowHeadersWidth = 62;
            this.GridEmployee.RowTemplate.Height = 28;
            this.GridEmployee.Size = new System.Drawing.Size(612, 150);
            this.GridEmployee.TabIndex = 11;
            this.GridEmployee.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridEmployee_CellContentClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GridEmployee);
            this.Controls.Add(this.BtnReset);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.RadioConsult);
            this.Controls.Add(this.LblEmpType);
            this.Controls.Add(this.RadioPayroll);
            this.Controls.Add(this.TxtSalary);
            this.Controls.Add(this.LblSalary);
            this.Controls.Add(this.TxtEmpName);
            this.Controls.Add(this.LblEmpName);
            this.Controls.Add(this.TxtEmpNo);
            this.Controls.Add(this.LblEmpNo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridEmployee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblEmpNo;
        private System.Windows.Forms.TextBox TxtEmpNo;
        private System.Windows.Forms.TextBox TxtEmpName;
        private System.Windows.Forms.Label LblEmpName;
        private System.Windows.Forms.TextBox TxtSalary;
        private System.Windows.Forms.Label LblSalary;
        private System.Windows.Forms.RadioButton RadioPayroll;
        private System.Windows.Forms.Label LblEmpType;
        private System.Windows.Forms.RadioButton RadioConsult;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Button BtnReset;
        private System.Windows.Forms.DataGridView GridEmployee;
    }
}

