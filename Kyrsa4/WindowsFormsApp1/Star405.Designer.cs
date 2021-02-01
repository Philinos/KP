
namespace WindowsFormsApp1
{
    partial class Star405
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDQDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.predmetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.posDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.starDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.table4BindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.anketDataSet5 = new WindowsFormsApp1.AnketDataSet5();
            this.table4BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.anketDataSet1 = new WindowsFormsApp1.AnketDataSet1();
            this.table_4TableAdapter = new WindowsFormsApp1.AnketDataSet1TableAdapters.Table_4TableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.anketDataSet3 = new WindowsFormsApp1.AnketDataSet3();
            this.table4BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.table_4TableAdapter1 = new WindowsFormsApp1.AnketDataSet3TableAdapters.Table_4TableAdapter();
            this.table4BindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.anketDataSet4 = new WindowsFormsApp1.AnketDataSet4();
            this.table_4TableAdapter2 = new WindowsFormsApp1.AnketDataSet4TableAdapters.Table_4TableAdapter();
            this.table_4TableAdapter3 = new WindowsFormsApp1.AnketDataSet5TableAdapters.Table_4TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table4BindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.anketDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table4BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.anketDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.anketDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table4BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table4BindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.anketDataSet4)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.iDQDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.predmetDataGridViewTextBoxColumn,
            this.posDataGridViewTextBoxColumn,
            this.starDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.table4BindingSource3;
            this.dataGridView1.Location = new System.Drawing.Point(13, 35);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1058, 376);
            this.dataGridView1.TabIndex = 0;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Width = 125;
            // 
            // iDQDataGridViewTextBoxColumn
            // 
            this.iDQDataGridViewTextBoxColumn.DataPropertyName = "IDQ";
            this.iDQDataGridViewTextBoxColumn.HeaderText = "IDQ";
            this.iDQDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDQDataGridViewTextBoxColumn.Name = "iDQDataGridViewTextBoxColumn";
            this.iDQDataGridViewTextBoxColumn.Width = 125;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.Width = 125;
            // 
            // predmetDataGridViewTextBoxColumn
            // 
            this.predmetDataGridViewTextBoxColumn.DataPropertyName = "Predmet";
            this.predmetDataGridViewTextBoxColumn.HeaderText = "Predmet";
            this.predmetDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.predmetDataGridViewTextBoxColumn.Name = "predmetDataGridViewTextBoxColumn";
            this.predmetDataGridViewTextBoxColumn.Width = 125;
            // 
            // posDataGridViewTextBoxColumn
            // 
            this.posDataGridViewTextBoxColumn.DataPropertyName = "Pos";
            this.posDataGridViewTextBoxColumn.HeaderText = "Pos";
            this.posDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.posDataGridViewTextBoxColumn.Name = "posDataGridViewTextBoxColumn";
            this.posDataGridViewTextBoxColumn.Width = 125;
            // 
            // starDataGridViewTextBoxColumn
            // 
            this.starDataGridViewTextBoxColumn.DataPropertyName = "Star";
            this.starDataGridViewTextBoxColumn.HeaderText = "Star";
            this.starDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.starDataGridViewTextBoxColumn.Name = "starDataGridViewTextBoxColumn";
            this.starDataGridViewTextBoxColumn.Width = 125;
            // 
            // table4BindingSource3
            // 
            this.table4BindingSource3.DataMember = "Table_4";
            this.table4BindingSource3.DataSource = this.anketDataSet5;
            // 
            // anketDataSet5
            // 
            this.anketDataSet5.DataSetName = "AnketDataSet5";
            this.anketDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // table4BindingSource
            // 
            this.table4BindingSource.DataMember = "Table_4";
            this.table4BindingSource.DataSource = this.anketDataSet1;
            // 
            // anketDataSet1
            // 
            this.anketDataSet1.DataSetName = "AnketDataSet1";
            this.anketDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // table_4TableAdapter
            // 
            this.table_4TableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(46, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Сохранить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(996, 417);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Назад";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // anketDataSet3
            // 
            this.anketDataSet3.DataSetName = "AnketDataSet3";
            this.anketDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // table4BindingSource1
            // 
            this.table4BindingSource1.DataMember = "Table_4";
            this.table4BindingSource1.DataSource = this.anketDataSet3;
            // 
            // table_4TableAdapter1
            // 
            this.table_4TableAdapter1.ClearBeforeFill = true;
            // 
            // table4BindingSource2
            // 
            this.table4BindingSource2.DataMember = "Table_4";
            this.table4BindingSource2.DataSource = this.anketDataSet4;
            // 
            // anketDataSet4
            // 
            this.anketDataSet4.DataSetName = "AnketDataSet4";
            this.anketDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // table_4TableAdapter2
            // 
            this.table_4TableAdapter2.ClearBeforeFill = true;
            this.table_4TableAdapter2.UpdateCommand = null;
            // 
            // table_4TableAdapter3
            // 
            this.table_4TableAdapter3.ClearBeforeFill = true;
            // 
            // Star405
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Star405";
            this.ShowIcon = false;
            this.Text = "Star405";
            this.Load += new System.EventHandler(this.Star405_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table4BindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.anketDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table4BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.anketDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.anketDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table4BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table4BindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.anketDataSet4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private AnketDataSet1 anketDataSet1;
        private System.Windows.Forms.BindingSource table4BindingSource;
        private AnketDataSet1TableAdapters.Table_4TableAdapter table_4TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDQDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn predmetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn posDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn starDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private AnketDataSet3 anketDataSet3;
        private System.Windows.Forms.BindingSource table4BindingSource1;
        private AnketDataSet3TableAdapters.Table_4TableAdapter table_4TableAdapter1;
        private AnketDataSet4 anketDataSet4;
        private System.Windows.Forms.BindingSource table4BindingSource2;
        private AnketDataSet4TableAdapters.Table_4TableAdapter table_4TableAdapter2;
        private AnketDataSet5 anketDataSet5;
        private System.Windows.Forms.BindingSource table4BindingSource3;
        private AnketDataSet5TableAdapters.Table_4TableAdapter table_4TableAdapter3;
    }
}