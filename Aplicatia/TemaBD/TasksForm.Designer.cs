namespace TemaBD
{
    partial class TasksForm
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
            this.bt_load = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_add = new System.Windows.Forms.Button();
            this.bt_edit = new System.Windows.Forms.Button();
            this.bt_delete = new System.Windows.Forms.Button();
            this.tb_description = new System.Windows.Forms.TextBox();
            this.cb_ID = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.dt_deadline = new System.Windows.Forms.DateTimePicker();
            this.cb_emp = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_load
            // 
            this.bt_load.Location = new System.Drawing.Point(1008, 364);
            this.bt_load.Name = "bt_load";
            this.bt_load.Size = new System.Drawing.Size(105, 39);
            this.bt_load.TabIndex = 50;
            this.bt_load.Text = "Load";
            this.bt_load.UseVisualStyleBackColor = true;
            this.bt_load.Click += new System.EventHandler(this.bt_load_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(362, 438);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 20);
            this.label4.TabIndex = 47;
            this.label4.Text = "Description:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(107, 392);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 20);
            this.label3.TabIndex = 46;
            this.label3.Text = "Where:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 437);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 20);
            this.label1.TabIndex = 44;
            this.label1.Text = "ID:";
            // 
            // bt_add
            // 
            this.bt_add.Location = new System.Drawing.Point(797, 554);
            this.bt_add.Name = "bt_add";
            this.bt_add.Size = new System.Drawing.Size(137, 33);
            this.bt_add.TabIndex = 43;
            this.bt_add.Text = "Add";
            this.bt_add.UseVisualStyleBackColor = true;
            this.bt_add.Click += new System.EventHandler(this.bt_add_Click);
            // 
            // bt_edit
            // 
            this.bt_edit.Location = new System.Drawing.Point(797, 488);
            this.bt_edit.Name = "bt_edit";
            this.bt_edit.Size = new System.Drawing.Size(137, 37);
            this.bt_edit.TabIndex = 42;
            this.bt_edit.Text = "Edit";
            this.bt_edit.UseVisualStyleBackColor = true;
            this.bt_edit.Click += new System.EventHandler(this.bt_edit_Click);
            // 
            // bt_delete
            // 
            this.bt_delete.Location = new System.Drawing.Point(797, 427);
            this.bt_delete.Name = "bt_delete";
            this.bt_delete.Size = new System.Drawing.Size(137, 38);
            this.bt_delete.TabIndex = 41;
            this.bt_delete.Text = "Delete";
            this.bt_delete.UseVisualStyleBackColor = true;
            this.bt_delete.Click += new System.EventHandler(this.bt_delete_Click);
            // 
            // tb_description
            // 
            this.tb_description.Location = new System.Drawing.Point(461, 439);
            this.tb_description.Name = "tb_description";
            this.tb_description.Size = new System.Drawing.Size(185, 26);
            this.tb_description.TabIndex = 38;
            // 
            // cb_ID
            // 
            this.cb_ID.FormattingEnabled = true;
            this.cb_ID.Location = new System.Drawing.Point(89, 437);
            this.cb_ID.Name = "cb_ID";
            this.cb_ID.Size = new System.Drawing.Size(175, 28);
            this.cb_ID.TabIndex = 37;
            this.cb_ID.Tag = "";
            this.cb_ID.Click += new System.EventHandler(this.cb_ID_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1101, 346);
            this.dataGridView1.TabIndex = 35;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(379, 488);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 20);
            this.label7.TabIndex = 72;
            this.label7.Text = "Deadline:";
            // 
            // dt_deadline
            // 
            this.dt_deadline.Location = new System.Drawing.Point(461, 488);
            this.dt_deadline.Name = "dt_deadline";
            this.dt_deadline.Size = new System.Drawing.Size(292, 26);
            this.dt_deadline.TabIndex = 71;
            this.dt_deadline.Value = new System.DateTime(2024, 1, 1, 0, 0, 0, 0);
            // 
            // cb_emp
            // 
            this.cb_emp.FormattingEnabled = true;
            this.cb_emp.Location = new System.Drawing.Point(461, 548);
            this.cb_emp.Name = "cb_emp";
            this.cb_emp.Size = new System.Drawing.Size(235, 28);
            this.cb_emp.TabIndex = 73;
            this.cb_emp.Click += new System.EventHandler(this.cb_emp_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(372, 548);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 74;
            this.label2.Text = "Employee:";
            // 
            // TasksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1125, 654);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cb_emp);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dt_deadline);
            this.Controls.Add(this.bt_load);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_add);
            this.Controls.Add(this.bt_edit);
            this.Controls.Add(this.bt_delete);
            this.Controls.Add(this.tb_description);
            this.Controls.Add(this.cb_ID);
            this.Controls.Add(this.dataGridView1);
            this.Name = "TasksForm";
            this.Text = "Tasks and Deadlines";
            this.Load += new System.EventHandler(this.TasksForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_load;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_add;
        private System.Windows.Forms.Button bt_edit;
        private System.Windows.Forms.Button bt_delete;
        private System.Windows.Forms.TextBox tb_description;
        private System.Windows.Forms.ComboBox cb_ID;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dt_deadline;
        private System.Windows.Forms.ComboBox cb_emp;
        private System.Windows.Forms.Label label2;
    }
}