namespace WinFormsAppCreate
{
    partial class StoreProcedureMulParam
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
            txtEmpName = new TextBox();
            lblEmpId = new Label();
            btnInsert = new Button();
            txtEmpId = new TextBox();
            lblEmployeeId = new Label();
            lblEmpDesignation = new Label();
            txtEmpDesig = new TextBox();
            lblEmpDOJ = new Label();
            txtEmpDOJ = new TextBox();
            txtEmpSal = new TextBox();
            txtEmpDept = new TextBox();
            lblEmpSal = new Label();
            lblEmpDeptno = new Label();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnClear = new Button();
            btnFind = new Button();
            SuspendLayout();
            // 
            // txtEmpName
            // 
            txtEmpName.Location = new Point(272, 70);
            txtEmpName.Name = "txtEmpName";
            txtEmpName.Size = new Size(214, 27);
            txtEmpName.TabIndex = 0;
            // 
            // lblEmpId
            // 
            lblEmpId.AutoSize = true;
            lblEmpId.Location = new Point(112, 77);
            lblEmpId.Name = "lblEmpId";
            lblEmpId.Size = new Size(119, 20);
            lblEmpId.TabIndex = 1;
            lblEmpId.Text = "Employee Name";
            // 
            // btnInsert
            // 
            btnInsert.Location = new Point(159, 302);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(94, 29);
            btnInsert.TabIndex = 2;
            btnInsert.Text = "Insert";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click;
            // 
            // txtEmpId
            // 
            txtEmpId.Location = new Point(272, 30);
            txtEmpId.Name = "txtEmpId";
            txtEmpId.Size = new Size(214, 27);
            txtEmpId.TabIndex = 3;
            // 
            // lblEmployeeId
            // 
            lblEmployeeId.AutoSize = true;
            lblEmployeeId.Location = new Point(112, 37);
            lblEmployeeId.Name = "lblEmployeeId";
            lblEmployeeId.Size = new Size(52, 20);
            lblEmployeeId.TabIndex = 4;
            lblEmployeeId.Text = "EmpId";
            // 
            // lblEmpDesignation
            // 
            lblEmpDesignation.AutoSize = true;
            lblEmpDesignation.Location = new Point(112, 115);
            lblEmpDesignation.Name = "lblEmpDesignation";
            lblEmpDesignation.Size = new Size(123, 20);
            lblEmpDesignation.TabIndex = 5;
            lblEmpDesignation.Text = "Emp Designation";
            // 
            // txtEmpDesig
            // 
            txtEmpDesig.Location = new Point(272, 115);
            txtEmpDesig.Name = "txtEmpDesig";
            txtEmpDesig.Size = new Size(214, 27);
            txtEmpDesig.TabIndex = 6;
            // 
            // lblEmpDOJ
            // 
            lblEmpDOJ.AutoSize = true;
            lblEmpDOJ.Location = new Point(112, 151);
            lblEmpDOJ.Name = "lblEmpDOJ";
            lblEmpDOJ.Size = new Size(70, 20);
            lblEmpDOJ.TabIndex = 7;
            lblEmpDOJ.Text = "Emp DOJ";
            // 
            // txtEmpDOJ
            // 
            txtEmpDOJ.Location = new Point(272, 151);
            txtEmpDOJ.Name = "txtEmpDOJ";
            txtEmpDOJ.Size = new Size(214, 27);
            txtEmpDOJ.TabIndex = 8;
            // 
            // txtEmpSal
            // 
            txtEmpSal.Location = new Point(272, 194);
            txtEmpSal.Name = "txtEmpSal";
            txtEmpSal.Size = new Size(214, 27);
            txtEmpSal.TabIndex = 9;
            // 
            // txtEmpDept
            // 
            txtEmpDept.Location = new Point(272, 233);
            txtEmpDept.Name = "txtEmpDept";
            txtEmpDept.Size = new Size(214, 27);
            txtEmpDept.TabIndex = 10;
            // 
            // lblEmpSal
            // 
            lblEmpSal.AutoSize = true;
            lblEmpSal.Location = new Point(112, 194);
            lblEmpSal.Name = "lblEmpSal";
            lblEmpSal.Size = new Size(63, 20);
            lblEmpSal.TabIndex = 11;
            lblEmpSal.Text = "Emp Sal";
            // 
            // lblEmpDeptno
            // 
            lblEmpDeptno.AutoSize = true;
            lblEmpDeptno.Location = new Point(112, 233);
            lblEmpDeptno.Name = "lblEmpDeptno";
            lblEmpDeptno.Size = new Size(93, 20);
            lblEmpDeptno.TabIndex = 12;
            lblEmpDeptno.Text = "Emp Deptno";
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(272, 302);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 13;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(159, 337);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 14;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(272, 337);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(94, 29);
            btnClear.TabIndex = 15;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnFind
            // 
            btnFind.Location = new Point(434, 321);
            btnFind.Name = "btnFind";
            btnFind.Size = new Size(94, 29);
            btnFind.TabIndex = 16;
            btnFind.Text = "Find";
            btnFind.UseVisualStyleBackColor = true;
            btnFind.Click += btnFind_Click;
            // 
            // StoreProcedureMulParam
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnFind);
            Controls.Add(btnClear);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(lblEmpDeptno);
            Controls.Add(lblEmpSal);
            Controls.Add(txtEmpDept);
            Controls.Add(txtEmpSal);
            Controls.Add(txtEmpDOJ);
            Controls.Add(lblEmpDOJ);
            Controls.Add(txtEmpDesig);
            Controls.Add(lblEmpDesignation);
            Controls.Add(lblEmployeeId);
            Controls.Add(txtEmpId);
            Controls.Add(btnInsert);
            Controls.Add(lblEmpId);
            Controls.Add(txtEmpName);
            Name = "StoreProcedureMulParam";
            Text = "StoreProcedureMulParam";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtEmpName;
        private Label lblEmpId;
        private Button btnInsert;
        private TextBox txtEmpId;
        private Label lblEmployeeId;
        private Label lblEmpDesignation;
        private TextBox txtEmpDesig;
        private Label lblEmpDOJ;
        private TextBox txtEmpDOJ;
        private TextBox txtEmpSal;
        private TextBox txtEmpDept;
        private Label lblEmpSal;
        private Label lblEmpDeptno;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnClear;
        private Button btnFind;
    }
}