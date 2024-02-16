namespace TemaBD
{
    partial class VetVisitsForm
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
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dt_date = new System.Windows.Forms.DateTimePicker();
            this.cb_vet = new System.Windows.Forms.ComboBox();
            this.bt_load = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_add = new System.Windows.Forms.Button();
            this.bt_edit = new System.Windows.Forms.Button();
            this.bt_delete = new System.Windows.Forms.Button();
            this.cb_animal = new System.Windows.Forms.ComboBox();
            this.tb_tratament = new System.Windows.Forms.TextBox();
            this.tb_diagnostic = new System.Windows.Forms.TextBox();
            this.cb_ID = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(361, 471);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 20);
            this.label11.TabIndex = 68;
            this.label11.Text = "Date:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(371, 405);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 20);
            this.label10.TabIndex = 67;
            this.label10.Text = "Vet:";
            // 
            // dt_date
            // 
            this.dt_date.Location = new System.Drawing.Point(418, 471);
            this.dt_date.Name = "dt_date";
            this.dt_date.Size = new System.Drawing.Size(292, 26);
            this.dt_date.TabIndex = 66;
            // 
            // cb_vet
            // 
            this.cb_vet.FormattingEnabled = true;
            this.cb_vet.Location = new System.Drawing.Point(418, 404);
            this.cb_vet.Name = "cb_vet";
            this.cb_vet.Size = new System.Drawing.Size(225, 28);
            this.cb_vet.TabIndex = 65;
            this.cb_vet.Click += new System.EventHandler(this.cb_vet_Click);
            // 
            // bt_load
            // 
            this.bt_load.Location = new System.Drawing.Point(1118, 300);
            this.bt_load.Name = "bt_load";
            this.bt_load.Size = new System.Drawing.Size(115, 38);
            this.bt_load.TabIndex = 64;
            this.bt_load.Text = "Load";
            this.bt_load.UseVisualStyleBackColor = true;
            this.bt_load.Click += new System.EventHandler(this.bt_load_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(348, 345);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 20);
            this.label7.TabIndex = 59;
            this.label7.Text = "Animal:";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(323, 569);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(86, 20);
            this.label.TabIndex = 57;
            this.label.Text = "Tratament:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(321, 517);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 20);
            this.label4.TabIndex = 56;
            this.label4.Text = "Diagnostic:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(101, 300);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 20);
            this.label3.TabIndex = 55;
            this.label3.Text = "Where:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 345);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 20);
            this.label1.TabIndex = 53;
            this.label1.Text = "ID:";
            // 
            // bt_add
            // 
            this.bt_add.Location = new System.Drawing.Point(756, 530);
            this.bt_add.Name = "bt_add";
            this.bt_add.Size = new System.Drawing.Size(137, 33);
            this.bt_add.TabIndex = 52;
            this.bt_add.Text = "Add";
            this.bt_add.UseVisualStyleBackColor = true;
            this.bt_add.Click += new System.EventHandler(this.bt_add_Click);
            // 
            // bt_edit
            // 
            this.bt_edit.Location = new System.Drawing.Point(756, 460);
            this.bt_edit.Name = "bt_edit";
            this.bt_edit.Size = new System.Drawing.Size(137, 37);
            this.bt_edit.TabIndex = 51;
            this.bt_edit.Text = "Edit";
            this.bt_edit.UseVisualStyleBackColor = true;
            this.bt_edit.Click += new System.EventHandler(this.bt_edit_Click);
            // 
            // bt_delete
            // 
            this.bt_delete.Location = new System.Drawing.Point(756, 383);
            this.bt_delete.Name = "bt_delete";
            this.bt_delete.Size = new System.Drawing.Size(137, 38);
            this.bt_delete.TabIndex = 50;
            this.bt_delete.Text = "Delete";
            this.bt_delete.UseVisualStyleBackColor = true;
            this.bt_delete.Click += new System.EventHandler(this.bt_delete_Click);
            // 
            // cb_animal
            // 
            this.cb_animal.FormattingEnabled = true;
            this.cb_animal.Location = new System.Drawing.Point(418, 345);
            this.cb_animal.Name = "cb_animal";
            this.cb_animal.Size = new System.Drawing.Size(185, 28);
            this.cb_animal.TabIndex = 49;
            this.cb_animal.Click += new System.EventHandler(this.cb_animal_Click);
            // 
            // tb_tratament
            // 
            this.tb_tratament.Location = new System.Drawing.Point(418, 563);
            this.tb_tratament.Name = "tb_tratament";
            this.tb_tratament.Size = new System.Drawing.Size(292, 26);
            this.tb_tratament.TabIndex = 47;
            this.tb_tratament.Text = "None";
            // 
            // tb_diagnostic
            // 
            this.tb_diagnostic.Location = new System.Drawing.Point(418, 517);
            this.tb_diagnostic.Name = "tb_diagnostic";
            this.tb_diagnostic.Size = new System.Drawing.Size(292, 26);
            this.tb_diagnostic.TabIndex = 46;
            this.tb_diagnostic.Text = "None";
            // 
            // cb_ID
            // 
            this.cb_ID.FormattingEnabled = true;
            this.cb_ID.Location = new System.Drawing.Point(119, 343);
            this.cb_ID.Name = "cb_ID";
            this.cb_ID.Size = new System.Drawing.Size(175, 28);
            this.cb_ID.TabIndex = 45;
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
            this.dataGridView1.Size = new System.Drawing.Size(1221, 272);
            this.dataGridView1.TabIndex = 43;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // VetVisitsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1243, 615);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dt_date);
            this.Controls.Add(this.cb_vet);
            this.Controls.Add(this.bt_load);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_add);
            this.Controls.Add(this.bt_edit);
            this.Controls.Add(this.bt_delete);
            this.Controls.Add(this.cb_animal);
            this.Controls.Add(this.tb_tratament);
            this.Controls.Add(this.tb_diagnostic);
            this.Controls.Add(this.cb_ID);
            this.Controls.Add(this.dataGridView1);
            this.Name = "VetVisitsForm";
            this.Text = "Veterinary Visits";
            this.Load += new System.EventHandler(this.VetVisitsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dt_date;
        private System.Windows.Forms.ComboBox cb_vet;
        private System.Windows.Forms.Button bt_load;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_add;
        private System.Windows.Forms.Button bt_edit;
        private System.Windows.Forms.Button bt_delete;
        private System.Windows.Forms.ComboBox cb_animal;
        private System.Windows.Forms.TextBox tb_tratament;
        private System.Windows.Forms.TextBox tb_diagnostic;
        private System.Windows.Forms.ComboBox cb_ID;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}