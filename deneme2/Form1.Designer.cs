namespace deneme2
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
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
            this.components = new System.ComponentModel.Container();
            this.gbxCategori = new System.Windows.Forms.GroupBox();
            this.lblKategori = new System.Windows.Forms.Label();
            this.cbxCategori = new System.Windows.Forms.ComboBox();
            this.gbxSearch = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.dgwProduct = new System.Windows.Forms.DataGridView();
            this.nORTHWNDDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nORTHWNDDataSet = new deneme2.NORTHWNDDataSet();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productsTableAdapter = new deneme2.NORTHWNDDataSetTableAdapters.ProductsTableAdapter();
            this.fKOrderDetailsProductsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.order_DetailsTableAdapter = new deneme2.NORTHWNDDataSetTableAdapters.Order_DetailsTableAdapter();
            this.gbxCategori.SuspendLayout();
            this.gbxSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nORTHWNDDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nORTHWNDDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKOrderDetailsProductsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxCategori
            // 
            this.gbxCategori.Controls.Add(this.lblKategori);
            this.gbxCategori.Controls.Add(this.cbxCategori);
            this.gbxCategori.Location = new System.Drawing.Point(31, 22);
            this.gbxCategori.Name = "gbxCategori";
            this.gbxCategori.Size = new System.Drawing.Size(669, 127);
            this.gbxCategori.TabIndex = 0;
            this.gbxCategori.TabStop = false;
            this.gbxCategori.Text = "Kategoriye Göre Listele";
            // 
            // lblKategori
            // 
            this.lblKategori.AutoSize = true;
            this.lblKategori.Location = new System.Drawing.Point(123, 48);
            this.lblKategori.Name = "lblKategori";
            this.lblKategori.Size = new System.Drawing.Size(63, 16);
            this.lblKategori.TabIndex = 1;
            this.lblKategori.Text = "Kategori :";
            // 
            // cbxCategori
            // 
            this.cbxCategori.FormattingEnabled = true;
            this.cbxCategori.Location = new System.Drawing.Point(230, 41);
            this.cbxCategori.Name = "cbxCategori";
            this.cbxCategori.Size = new System.Drawing.Size(150, 24);
            this.cbxCategori.TabIndex = 0;
            // 
            // gbxSearch
            // 
            this.gbxSearch.Controls.Add(this.textBox1);
            this.gbxSearch.Controls.Add(this.lblSearch);
            this.gbxSearch.Location = new System.Drawing.Point(34, 167);
            this.gbxSearch.Name = "gbxSearch";
            this.gbxSearch.Size = new System.Drawing.Size(669, 127);
            this.gbxSearch.TabIndex = 1;
            this.gbxSearch.TabStop = false;
            this.gbxSearch.Text = "Ürün İsmine Göre Ara";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(227, 45);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(150, 22);
            this.textBox1.TabIndex = 2;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(123, 48);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(31, 16);
            this.lblSearch.TabIndex = 1;
            this.lblSearch.Text = "Ara:";
            // 
            // dgwProduct
            // 
            this.dgwProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwProduct.Location = new System.Drawing.Point(34, 318);
            this.dgwProduct.Name = "dgwProduct";
            this.dgwProduct.RowHeadersWidth = 51;
            this.dgwProduct.RowTemplate.Height = 24;
            this.dgwProduct.Size = new System.Drawing.Size(669, 211);
            this.dgwProduct.TabIndex = 2;
            // 
            // nORTHWNDDataSetBindingSource
            // 
            this.nORTHWNDDataSetBindingSource.DataSource = this.nORTHWNDDataSet;
            this.nORTHWNDDataSetBindingSource.Position = 0;
            // 
            // nORTHWNDDataSet
            // 
            this.nORTHWNDDataSet.DataSetName = "NORTHWNDDataSet";
            this.nORTHWNDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataMember = "Products";
            this.productsBindingSource.DataSource = this.nORTHWNDDataSetBindingSource;
            // 
            // productsTableAdapter
            // 
            this.productsTableAdapter.ClearBeforeFill = true;
            // 
            // fKOrderDetailsProductsBindingSource
            // 
            this.fKOrderDetailsProductsBindingSource.DataMember = "FK_Order_Details_Products";
            this.fKOrderDetailsProductsBindingSource.DataSource = this.productsBindingSource;
            // 
            // order_DetailsTableAdapter
            // 
            this.order_DetailsTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 604);
            this.Controls.Add(this.dgwProduct);
            this.Controls.Add(this.gbxSearch);
            this.Controls.Add(this.gbxCategori);
            this.Name = "Form1";
            this.Text = "Ürünler";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbxCategori.ResumeLayout(false);
            this.gbxCategori.PerformLayout();
            this.gbxSearch.ResumeLayout(false);
            this.gbxSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nORTHWNDDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nORTHWNDDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKOrderDetailsProductsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxCategori;
        private System.Windows.Forms.Label lblKategori;
        private System.Windows.Forms.ComboBox cbxCategori;
        private System.Windows.Forms.GroupBox gbxSearch;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.DataGridView dgwProduct;
        private System.Windows.Forms.BindingSource nORTHWNDDataSetBindingSource;
        private NORTHWNDDataSet nORTHWNDDataSet;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private NORTHWNDDataSetTableAdapters.ProductsTableAdapter productsTableAdapter;
        private System.Windows.Forms.BindingSource fKOrderDetailsProductsBindingSource;
        private NORTHWNDDataSetTableAdapters.Order_DetailsTableAdapter order_DetailsTableAdapter;
    }
}

