namespace TemaBD
{
    partial class StaffManagement
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
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_add = new System.Windows.Forms.Button();
            this.bt_edit = new System.Windows.Forms.Button();
            this.bt_delete = new System.Windows.Forms.Button();
            this.tb_phone = new System.Windows.Forms.TextBox();
            this.tb_function = new System.Windows.Forms.TextBox();
            this.tb_name_2 = new System.Windows.Forms.TextBox();
            this.cb_ID = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bt_load = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(358, 543);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 20);
            this.label6.TabIndex = 33;
            this.label6.Text = "Phone:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(345, 494);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 20);
            this.label5.TabIndex = 32;
            this.label5.Text = "Function:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(362, 438);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 20);
            this.label4.TabIndex = 31;
            this.label4.Text = "Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(107, 392);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 20);
            this.label3.TabIndex = 30;
            this.label3.Text = "Where:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 437);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 20);
            this.label1.TabIndex = 28;
            this.label1.Text = "ID:";
            // 
            // bt_add
            // 
            this.bt_add.Location = new System.Drawing.Point(691, 589);
            this.bt_add.Name = "bt_add";
            this.bt_add.Size = new System.Drawing.Size(137, 33);
            this.bt_add.TabIndex = 27;
            this.bt_add.Text = "Add";
            this.bt_add.UseVisualStyleBackColor = true;
            this.bt_add.Click += new System.EventHandler(this.bt_add_Click);
            // 
            // bt_edit
            // 
            this.bt_edit.Location = new System.Drawing.Point(691, 514);
            this.bt_edit.Name = "bt_edit";
            this.bt_edit.Size = new System.Drawing.Size(137, 37);
            this.bt_edit.TabIndex = 26;
            this.bt_edit.Text = "Edit";
            this.bt_edit.UseVisualStyleBackColor = true;
            this.bt_edit.Click += new System.EventHandler(this.bt_edit_Click);
            // 
            // bt_delete
            // 
            this.bt_delete.Location = new System.Drawing.Point(691, 437);
            this.bt_delete.Name = "bt_delete";
            this.bt_delete.Size = new System.Drawing.Size(137, 38);
            this.bt_delete.TabIndex = 25;
            this.bt_delete.Text = "Delete";
            this.bt_delete.UseVisualStyleBackColor = true;
            this.bt_delete.Click += new System.EventHandler(this.bt_delete_Click);
            // 
            // tb_phone
            // 
            this.tb_phone.Location = new System.Drawing.Point(442, 543);
            this.tb_phone.Name = "tb_phone";
            this.tb_phone.Size = new System.Drawing.Size(185, 26);
            this.tb_phone.TabIndex = 23;
            // 
            // tb_function
            // 
            this.tb_function.Location = new System.Drawing.Point(442, 494);
            this.tb_function.Name = "tb_function";
            this.tb_function.Size = new System.Drawing.Size(185, 26);
            this.tb_function.TabIndex = 22;
            // 
            // tb_name_2
            // 
            this.tb_name_2.Location = new System.Drawing.Point(442, 439);
            this.tb_name_2.Name = "tb_name_2";
            this.tb_name_2.Size = new System.Drawing.Size(185, 26);
            this.tb_name_2.TabIndex = 21;
            // 
            // cb_ID
            // 
            this.cb_ID.FormattingEnabled = true;
            this.cb_ID.Location = new System.Drawing.Point(89, 437);
            this.cb_ID.Name = "cb_ID";
            this.cb_ID.Size = new System.Drawing.Size(175, 28);
            this.cb_ID.TabIndex = 20;
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
            this.dataGridView1.Size = new System.Drawing.Size(830, 346);
            this.dataGridView1.TabIndex = 18;
            // 
            // bt_load
            // 
            this.bt_load.Location = new System.Drawing.Point(737, 364);
            this.bt_load.Name = "bt_load";
            this.bt_load.Size = new System.Drawing.Size(105, 39);
            this.bt_load.TabIndex = 34;
            this.bt_load.Text = "Load";
            this.bt_load.UseVisualStyleBackColor = true;
            this.bt_load.Click += new System.EventHandler(this.bt_load_Click);
            // 
            // StaffManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 650);
            this.Controls.Add(this.bt_load);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_add);
            this.Controls.Add(this.bt_edit);
            this.Controls.Add(this.bt_delete);
            this.Controls.Add(this.tb_phone);
            this.Controls.Add(this.tb_function);
            this.Controls.Add(this.tb_name_2);
            this.Controls.Add(this.cb_ID);
            this.Controls.Add(this.dataGridView1);
            this.Name = "StaffManagement";
            this.Text = "Manage Staff";
            this.Load += new System.EventHandler(this.StaffManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_add;
        private System.Windows.Forms.Button bt_edit;
        private System.Windows.Forms.Button bt_delete;
        private System.Windows.Forms.TextBox tb_phone;
        private System.Windows.Forms.TextBox tb_function;
        private System.Windows.Forms.TextBox tb_name_2;
        private System.Windows.Forms.ComboBox cb_ID;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button bt_load;
    }
}