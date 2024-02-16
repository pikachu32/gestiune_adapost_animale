namespace TemaBD
{
    partial class AnimalsForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_add = new System.Windows.Forms.Button();
            this.bt_edit = new System.Windows.Forms.Button();
            this.bt_delete = new System.Windows.Forms.Button();
            this.cb_sex = new System.Windows.Forms.ComboBox();
            this.tb_age = new System.Windows.Forms.TextBox();
            this.tb_species = new System.Windows.Forms.TextBox();
            this.tb_name_2 = new System.Windows.Forms.TextBox();
            this.cb_ID = new System.Windows.Forms.ComboBox();
            this.tb_status = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cb_emp_id = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.bt_load = new System.Windows.Forms.Button();
            this.cb_vet = new System.Windows.Forms.ComboBox();
            this.dt_date = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1147, 299);
            this.dataGridView1.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(369, 535);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 20);
            this.label7.TabIndex = 33;
            this.label7.Text = "Sex:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(369, 475);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 20);
            this.label6.TabIndex = 32;
            this.label6.Text = "Age:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(341, 429);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 20);
            this.label5.TabIndex = 31;
            this.label5.Text = "Species:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(356, 370);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 20);
            this.label4.TabIndex = 30;
            this.label4.Text = "Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(101, 324);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 20);
            this.label3.TabIndex = 29;
            this.label3.Text = "Where:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 369);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 20);
            this.label1.TabIndex = 27;
            this.label1.Text = "ID:";
            // 
            // bt_add
            // 
            this.bt_add.Location = new System.Drawing.Point(1008, 609);
            this.bt_add.Name = "bt_add";
            this.bt_add.Size = new System.Drawing.Size(137, 33);
            this.bt_add.TabIndex = 26;
            this.bt_add.Text = "Add";
            this.bt_add.UseVisualStyleBackColor = true;
            this.bt_add.Click += new System.EventHandler(this.bt_add_Click);
            // 
            // bt_edit
            // 
            this.bt_edit.Location = new System.Drawing.Point(1008, 534);
            this.bt_edit.Name = "bt_edit";
            this.bt_edit.Size = new System.Drawing.Size(137, 37);
            this.bt_edit.TabIndex = 25;
            this.bt_edit.Text = "Edit";
            this.bt_edit.UseVisualStyleBackColor = true;
            this.bt_edit.Click += new System.EventHandler(this.bt_edit_Click);
            // 
            // bt_delete
            // 
            this.bt_delete.Location = new System.Drawing.Point(1008, 457);
            this.bt_delete.Name = "bt_delete";
            this.bt_delete.Size = new System.Drawing.Size(137, 38);
            this.bt_delete.TabIndex = 24;
            this.bt_delete.Text = "Delete";
            this.bt_delete.UseVisualStyleBackColor = true;
            this.bt_delete.Click += new System.EventHandler(this.bt_delete_Click);
            // 
            // cb_sex
            // 
            this.cb_sex.FormattingEnabled = true;
            this.cb_sex.Items.AddRange(new object[] {
            "masculin",
            "feminin"});
            this.cb_sex.Location = new System.Drawing.Point(436, 535);
            this.cb_sex.Name = "cb_sex";
            this.cb_sex.Size = new System.Drawing.Size(185, 28);
            this.cb_sex.TabIndex = 23;
            // 
            // tb_age
            // 
            this.tb_age.Location = new System.Drawing.Point(436, 475);
            this.tb_age.Name = "tb_age";
            this.tb_age.Size = new System.Drawing.Size(185, 26);
            this.tb_age.TabIndex = 22;
            this.tb_age.Text = "-1";
            // 
            // tb_species
            // 
            this.tb_species.Location = new System.Drawing.Point(436, 426);
            this.tb_species.Name = "tb_species";
            this.tb_species.Size = new System.Drawing.Size(185, 26);
            this.tb_species.TabIndex = 21;
            // 
            // tb_name_2
            // 
            this.tb_name_2.Location = new System.Drawing.Point(436, 371);
            this.tb_name_2.Name = "tb_name_2";
            this.tb_name_2.Size = new System.Drawing.Size(185, 26);
            this.tb_name_2.TabIndex = 20;
            // 
            // cb_ID
            // 
            this.cb_ID.FormattingEnabled = true;
            this.cb_ID.Location = new System.Drawing.Point(83, 369);
            this.cb_ID.Name = "cb_ID";
            this.cb_ID.Size = new System.Drawing.Size(175, 28);
            this.cb_ID.TabIndex = 19;
            this.cb_ID.Tag = "";
            this.cb_ID.Click += new System.EventHandler(this.cb_ID_Click);
            // 
            // tb_status
            // 
            this.tb_status.Location = new System.Drawing.Point(436, 578);
            this.tb_status.Name = "tb_status";
            this.tb_status.Size = new System.Drawing.Size(185, 26);
            this.tb_status.TabIndex = 34;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(349, 578);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 20);
            this.label8.TabIndex = 35;
            this.label8.Text = "Status:";
            // 
            // cb_emp_id
            // 
            this.cb_emp_id.FormattingEnabled = true;
            this.cb_emp_id.Location = new System.Drawing.Point(436, 623);
            this.cb_emp_id.Name = "cb_emp_id";
            this.cb_emp_id.Size = new System.Drawing.Size(185, 28);
            this.cb_emp_id.TabIndex = 36;
            this.cb_emp_id.Text = "0";
            this.cb_emp_id.Click += new System.EventHandler(this.cb_emp_id_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(316, 623);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(104, 20);
            this.label9.TabIndex = 37;
            this.label9.Text = "Empolyee ID:";
            // 
            // bt_load
            // 
            this.bt_load.Location = new System.Drawing.Point(1030, 382);
            this.bt_load.Name = "bt_load";
            this.bt_load.Size = new System.Drawing.Size(115, 38);
            this.bt_load.TabIndex = 38;
            this.bt_load.Text = "Load";
            this.bt_load.UseVisualStyleBackColor = true;
            this.bt_load.Click += new System.EventHandler(this.bt_load_Click);
            // 
            // cb_vet
            // 
            this.cb_vet.FormattingEnabled = true;
            this.cb_vet.Location = new System.Drawing.Point(833, 371);
            this.cb_vet.Name = "cb_vet";
            this.cb_vet.Size = new System.Drawing.Size(143, 28);
            this.cb_vet.TabIndex = 39;
            this.cb_vet.Click += new System.EventHandler(this.cb_vet_Click);
            // 
            // dt_date
            // 
            this.dt_date.Location = new System.Drawing.Point(684, 461);
            this.dt_date.Name = "dt_date";
            this.dt_date.Size = new System.Drawing.Size(292, 26);
            this.dt_date.TabIndex = 40;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(771, 371);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 20);
            this.label10.TabIndex = 41;
            this.label10.Text = "Vet:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(684, 428);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 20);
            this.label11.TabIndex = 42;
            this.label11.Text = "Date:";
            // 
            // AnimalsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1171, 664);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dt_date);
            this.Controls.Add(this.cb_vet);
            this.Controls.Add(this.bt_load);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cb_emp_id);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tb_status);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_add);
            this.Controls.Add(this.bt_edit);
            this.Controls.Add(this.bt_delete);
            this.Controls.Add(this.cb_sex);
            this.Controls.Add(this.tb_age);
            this.Controls.Add(this.tb_species);
            this.Controls.Add(this.tb_name_2);
            this.Controls.Add(this.cb_ID);
            this.Controls.Add(this.dataGridView1);
            this.Name = "AnimalsForm";
            this.Text = "Monitor Animals";
            this.Load += new System.EventHandler(this.AnimalsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_add;
        private System.Windows.Forms.Button bt_edit;
        private System.Windows.Forms.Button bt_delete;
        private System.Windows.Forms.ComboBox cb_sex;
        private System.Windows.Forms.TextBox tb_age;
        private System.Windows.Forms.TextBox tb_species;
        private System.Windows.Forms.TextBox tb_name_2;
        private System.Windows.Forms.ComboBox cb_ID;
        private System.Windows.Forms.TextBox tb_status;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cb_emp_id;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button bt_load;
        private System.Windows.Forms.ComboBox cb_vet;
        private System.Windows.Forms.DateTimePicker dt_date;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
    }
}