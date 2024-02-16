namespace TemaBD
{
    partial class MainMenuForm
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
            this.bt_adopters = new System.Windows.Forms.Button();
            this.bt_animals = new System.Windows.Forms.Button();
            this.bt_staff = new System.Windows.Forms.Button();
            this.bt_vet_visits = new System.Windows.Forms.Button();
            this.bt_tasks = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_adopters
            // 
            this.bt_adopters.Location = new System.Drawing.Point(105, 62);
            this.bt_adopters.Name = "bt_adopters";
            this.bt_adopters.Size = new System.Drawing.Size(174, 53);
            this.bt_adopters.TabIndex = 0;
            this.bt_adopters.Text = "Manage Adopters";
            this.bt_adopters.UseVisualStyleBackColor = true;
            this.bt_adopters.Click += new System.EventHandler(this.bt_adopters_Click);
            // 
            // bt_animals
            // 
            this.bt_animals.Location = new System.Drawing.Point(105, 155);
            this.bt_animals.Name = "bt_animals";
            this.bt_animals.Size = new System.Drawing.Size(174, 43);
            this.bt_animals.TabIndex = 1;
            this.bt_animals.Text = "Monitor Animals";
            this.bt_animals.UseVisualStyleBackColor = true;
            this.bt_animals.Click += new System.EventHandler(this.bt_animals_Click);
            // 
            // bt_staff
            // 
            this.bt_staff.Location = new System.Drawing.Point(105, 240);
            this.bt_staff.Name = "bt_staff";
            this.bt_staff.Size = new System.Drawing.Size(174, 46);
            this.bt_staff.TabIndex = 2;
            this.bt_staff.Text = "Manage Staff";
            this.bt_staff.UseVisualStyleBackColor = true;
            this.bt_staff.Click += new System.EventHandler(this.bt_staff_Click);
            // 
            // bt_vet_visits
            // 
            this.bt_vet_visits.Location = new System.Drawing.Point(398, 62);
            this.bt_vet_visits.Name = "bt_vet_visits";
            this.bt_vet_visits.Size = new System.Drawing.Size(163, 52);
            this.bt_vet_visits.TabIndex = 3;
            this.bt_vet_visits.Text = "Veterinary Visits";
            this.bt_vet_visits.UseVisualStyleBackColor = true;
            this.bt_vet_visits.Click += new System.EventHandler(this.bt_vet_visits_Click);
            // 
            // bt_tasks
            // 
            this.bt_tasks.Location = new System.Drawing.Point(398, 155);
            this.bt_tasks.Name = "bt_tasks";
            this.bt_tasks.Size = new System.Drawing.Size(163, 52);
            this.bt_tasks.TabIndex = 4;
            this.bt_tasks.Text = "Tasks and Deadlines";
            this.bt_tasks.UseVisualStyleBackColor = true;
            this.bt_tasks.Click += new System.EventHandler(this.bt_tasks_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(47, 347);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(680, 124);
            this.dataGridView1.TabIndex = 5;
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 509);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.bt_tasks);
            this.Controls.Add(this.bt_vet_visits);
            this.Controls.Add(this.bt_staff);
            this.Controls.Add(this.bt_animals);
            this.Controls.Add(this.bt_adopters);
            this.Name = "MainMenuForm";
            this.Text = "Animal Shelter";
            this.Load += new System.EventHandler(this.MainMenuForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_adopters;
        private System.Windows.Forms.Button bt_animals;
        private System.Windows.Forms.Button bt_staff;
        private System.Windows.Forms.Button bt_vet_visits;
        private System.Windows.Forms.Button bt_tasks;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

