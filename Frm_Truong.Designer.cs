namespace QL_TuyenSinh
{
    partial class Frm_Truong
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_timkiem = new System.Windows.Forms.Label();
            this.cbo_name = new System.Windows.Forms.ComboBox();
            this.cbo_id = new System.Windows.Forms.ComboBox();
            this.rbtn_name = new System.Windows.Forms.RadioButton();
            this.rbtn_id = new System.Windows.Forms.RadioButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_search = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(402, 418);
            this.panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(396, 412);
            this.dataGridView1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lbl_timkiem);
            this.panel2.Controls.Add(this.cbo_name);
            this.panel2.Controls.Add(this.cbo_id);
            this.panel2.Controls.Add(this.rbtn_name);
            this.panel2.Controls.Add(this.rbtn_id);
            this.panel2.Location = new System.Drawing.Point(420, 13);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(355, 342);
            this.panel2.TabIndex = 1;
            // 
            // lbl_timkiem
            // 
            this.lbl_timkiem.AutoSize = true;
            this.lbl_timkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_timkiem.Location = new System.Drawing.Point(3, 2);
            this.lbl_timkiem.Name = "lbl_timkiem";
            this.lbl_timkiem.Size = new System.Drawing.Size(106, 25);
            this.lbl_timkiem.TabIndex = 4;
            this.lbl_timkiem.Text = "Tìm kiếm";
            // 
            // cbo_name
            // 
            this.cbo_name.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_name.FormattingEnabled = true;
            this.cbo_name.Location = new System.Drawing.Point(104, 97);
            this.cbo_name.Name = "cbo_name";
            this.cbo_name.Size = new System.Drawing.Size(241, 21);
            this.cbo_name.TabIndex = 7;
            // 
            // cbo_id
            // 
            this.cbo_id.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_id.FormattingEnabled = true;
            this.cbo_id.Location = new System.Drawing.Point(104, 43);
            this.cbo_id.Name = "cbo_id";
            this.cbo_id.Size = new System.Drawing.Size(241, 21);
            this.cbo_id.TabIndex = 6;
            // 
            // rbtn_name
            // 
            this.rbtn_name.AutoSize = true;
            this.rbtn_name.Location = new System.Drawing.Point(3, 101);
            this.rbtn_name.Name = "rbtn_name";
            this.rbtn_name.Size = new System.Drawing.Size(80, 17);
            this.rbtn_name.TabIndex = 5;
            this.rbtn_name.TabStop = true;
            this.rbtn_name.Text = "Tên trường:";
            this.rbtn_name.UseVisualStyleBackColor = true;
            this.rbtn_name.CheckedChanged += new System.EventHandler(this.rbtn_name_CheckedChanged);
            // 
            // rbtn_id
            // 
            this.rbtn_id.AutoSize = true;
            this.rbtn_id.Location = new System.Drawing.Point(3, 43);
            this.rbtn_id.Name = "rbtn_id";
            this.rbtn_id.Size = new System.Drawing.Size(76, 17);
            this.rbtn_id.TabIndex = 4;
            this.rbtn_id.TabStop = true;
            this.rbtn_id.Text = "Mã trường:";
            this.rbtn_id.UseVisualStyleBackColor = true;
            this.rbtn_id.CheckedChanged += new System.EventHandler(this.rbtn_id_CheckedChanged);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btn_exit);
            this.panel3.Controls.Add(this.btn_search);
            this.panel3.Location = new System.Drawing.Point(420, 361);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(355, 69);
            this.panel3.TabIndex = 2;
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(204, 3);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(75, 23);
            this.btn_exit.TabIndex = 1;
            this.btn_exit.Text = "Thoát";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(104, 3);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(75, 23);
            this.btn_search.TabIndex = 0;
            this.btn_search.Text = "Tìm kiếm";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // Frm_Trường
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Frm_Trường";
            this.Text = "Truong";
            this.Load += new System.EventHandler(this.Trường_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.ComboBox cbo_name;
        private System.Windows.Forms.ComboBox cbo_id;
        private System.Windows.Forms.RadioButton rbtn_name;
        private System.Windows.Forms.RadioButton rbtn_id;
        private System.Windows.Forms.Label lbl_timkiem;
    }
}