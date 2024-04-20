namespace SinemaSeansTakip
{
    partial class Form1
    {
       
        private System.ComponentModel.IContainer components = null;

        
        
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btn_Onay = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lb_filmAdi = new System.Windows.Forms.Label();
            this.dgv_seans = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salonId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tarih = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.cb_filmAdi = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_filmOnay = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage3.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_seans)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Controls.Add(this.btn_Onay);
            resources.ApplyResources(this.tabPage3, "tabPage3");
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            this.tabPage3.Click += new System.EventHandler(this.tabPage3_Click);
            // 
            // btn_Onay
            // 
            this.btn_Onay.BackColor = System.Drawing.Color.Orange;
            this.btn_Onay.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            resources.ApplyResources(this.btn_Onay, "btn_Onay");
            this.btn_Onay.Name = "btn_Onay";
            this.btn_Onay.UseVisualStyleBackColor = false;
            this.btn_Onay.Click += new System.EventHandler(this.btn_KoltukOnayla_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.lb_filmAdi);
            this.tabPage2.Controls.Add(this.dgv_seans);
            resources.ApplyResources(this.tabPage2, "tabPage2");
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lb_filmAdi
            // 
            resources.ApplyResources(this.lb_filmAdi, "lb_filmAdi");
            this.lb_filmAdi.Name = "lb_filmAdi";
            this.lb_filmAdi.Click += new System.EventHandler(this.lb_filmAdi_Click);
            // 
            // dgv_seans
            // 
            this.dgv_seans.AllowUserToAddRows = false;
            this.dgv_seans.AllowUserToDeleteRows = false;
            this.dgv_seans.AllowUserToResizeColumns = false;
            this.dgv_seans.AllowUserToResizeRows = false;
            this.dgv_seans.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_seans.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgv_seans.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_seans.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.salonId,
            this.tarih,
            this.saat});
            resources.ApplyResources(this.dgv_seans, "dgv_seans");
            this.dgv_seans.Name = "dgv_seans";
            this.dgv_seans.ReadOnly = true;
            this.dgv_seans.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv_seans.RowTemplate.Height = 24;
            this.dgv_seans.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_seans_CellContentClick);
            // 
            // id
            // 
            resources.ApplyResources(this.id, "id");
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // salonId
            // 
            resources.ApplyResources(this.salonId, "salonId");
            this.salonId.Name = "salonId";
            this.salonId.ReadOnly = true;
            this.salonId.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.salonId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // tarih
            // 
            resources.ApplyResources(this.tarih, "tarih");
            this.tarih.Name = "tarih";
            this.tarih.ReadOnly = true;
            this.tarih.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.tarih.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // saat
            // 
            resources.ApplyResources(this.saat, "saat");
            this.saat.Name = "saat";
            this.saat.ReadOnly = true;
            this.saat.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.saat.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.cb_filmAdi);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.btn_filmOnay);
            resources.ApplyResources(this.tabPage1, "tabPage1");
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // cb_filmAdi
            // 
            resources.ApplyResources(this.cb_filmAdi, "cb_filmAdi");
            this.cb_filmAdi.FormattingEnabled = true;
            this.cb_filmAdi.Name = "cb_filmAdi";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // btn_filmOnay
            // 
            this.btn_filmOnay.BackColor = System.Drawing.Color.Orange;
            this.btn_filmOnay.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btn_filmOnay, "btn_filmOnay");
            this.btn_filmOnay.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_filmOnay.Name = "btn_filmOnay";
            this.btn_filmOnay.UseVisualStyleBackColor = false;
            this.btn_filmOnay.Click += new System.EventHandler(this.btn_onayla_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            resources.ApplyResources(this.tabControl1, "tabControl1");
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_seans)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label lb_filmAdi;
        private System.Windows.Forms.DataGridView dgv_seans;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ComboBox cb_filmAdi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_filmOnay;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Button btn_Onay;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn salonId;
        private System.Windows.Forms.DataGridViewTextBoxColumn tarih;
        private System.Windows.Forms.DataGridViewTextBoxColumn saat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

