
namespace DoAnCuoiKi
{
    partial class QuanLyVe
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonDSALL = new System.Windows.Forms.Button();
            this.buttonDSDung = new System.Windows.Forms.Button();
            this.buttonDSTrong = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridViewVe = new System.Windows.Forms.DataGridView();
            this.buttonReset = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVe)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(11, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(932, 132);
            this.panel1.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(646, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Vé chưa phát";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(465, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Vé đã phát:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(170, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tổng số vé: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thông tin vé:";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.buttonDSALL);
            this.flowLayoutPanel1.Controls.Add(this.buttonDSDung);
            this.flowLayoutPanel1.Controls.Add(this.buttonDSTrong);
            this.flowLayoutPanel1.Controls.Add(this.buttonAdd);
            this.flowLayoutPanel1.Controls.Add(this.buttonReset);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(11, 163);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(932, 53);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // buttonDSALL
            // 
            this.buttonDSALL.Location = new System.Drawing.Point(3, 3);
            this.buttonDSALL.Name = "buttonDSALL";
            this.buttonDSALL.Size = new System.Drawing.Size(161, 37);
            this.buttonDSALL.TabIndex = 0;
            this.buttonDSALL.Text = "Danh sách tổng số vé";
            this.buttonDSALL.UseVisualStyleBackColor = true;
            // 
            // buttonDSDung
            // 
            this.buttonDSDung.Location = new System.Drawing.Point(170, 3);
            this.buttonDSDung.Name = "buttonDSDung";
            this.buttonDSDung.Size = new System.Drawing.Size(194, 37);
            this.buttonDSDung.TabIndex = 1;
            this.buttonDSDung.Text = "Danh sách vé đang dùng";
            this.buttonDSDung.UseVisualStyleBackColor = true;
            // 
            // buttonDSTrong
            // 
            this.buttonDSTrong.Location = new System.Drawing.Point(370, 3);
            this.buttonDSTrong.Name = "buttonDSTrong";
            this.buttonDSTrong.Size = new System.Drawing.Size(207, 37);
            this.buttonDSTrong.TabIndex = 2;
            this.buttonDSTrong.Text = "Danh sách vé chưa dùng";
            this.buttonDSTrong.UseVisualStyleBackColor = true;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(583, 3);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(171, 37);
            this.buttonAdd.TabIndex = 3;
            this.buttonAdd.Text = "Thay Đổi Thông Tin Vé";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.dataGridViewVe);
            this.panel2.Location = new System.Drawing.Point(11, 222);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(932, 318);
            this.panel2.TabIndex = 1;
            // 
            // dataGridViewVe
            // 
            this.dataGridViewVe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewVe.Location = new System.Drawing.Point(3, 52);
            this.dataGridViewVe.Name = "dataGridViewVe";
            this.dataGridViewVe.RowHeadersWidth = 51;
            this.dataGridViewVe.RowTemplate.Height = 24;
            this.dataGridViewVe.Size = new System.Drawing.Size(918, 263);
            this.dataGridViewVe.TabIndex = 0;
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(760, 3);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(161, 37);
            this.buttonReset.TabIndex = 4;
            this.buttonReset.Text = "Cập Nhật";
            this.buttonReset.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(398, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "DANH SÁCH VÉ";
            // 
            // QuanLyVe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Name = "QuanLyVe";
            this.Size = new System.Drawing.Size(969, 553);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVe)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button buttonDSALL;
        private System.Windows.Forms.Button buttonDSDung;
        private System.Windows.Forms.Button buttonDSTrong;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridViewVe;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Label label5;
    }
}
