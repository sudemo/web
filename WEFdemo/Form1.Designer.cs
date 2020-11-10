namespace WEFdemo
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idpersontestDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.persontestBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ccf02DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ccf02DataSet = new WEFdemo.ccf02DataSet();
            this.person_testTableAdapter = new WEFdemo.ccf02DataSetTableAdapters.person_testTableAdapter();
            this.capsulesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.capsulesTableAdapter = new WEFdemo.ccf02DataSetTableAdapters.capsulesTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.persontestBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ccf02DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ccf02DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.capsulesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idpersontestDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.ageDataGridViewTextBoxColumn,
            this.sexDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.persontestBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(471, 281);
            this.dataGridView1.TabIndex = 0;
            // 
            // idpersontestDataGridViewTextBoxColumn
            // 
            this.idpersontestDataGridViewTextBoxColumn.DataPropertyName = "idperson_test";
            this.idpersontestDataGridViewTextBoxColumn.HeaderText = "idperson_test";
            this.idpersontestDataGridViewTextBoxColumn.Name = "idpersontestDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // ageDataGridViewTextBoxColumn
            // 
            this.ageDataGridViewTextBoxColumn.DataPropertyName = "age";
            this.ageDataGridViewTextBoxColumn.HeaderText = "age";
            this.ageDataGridViewTextBoxColumn.Name = "ageDataGridViewTextBoxColumn";
            // 
            // sexDataGridViewTextBoxColumn
            // 
            this.sexDataGridViewTextBoxColumn.DataPropertyName = "sex";
            this.sexDataGridViewTextBoxColumn.HeaderText = "sex";
            this.sexDataGridViewTextBoxColumn.Name = "sexDataGridViewTextBoxColumn";
            // 
            // persontestBindingSource
            // 
            this.persontestBindingSource.DataMember = "person_test";
            this.persontestBindingSource.DataSource = this.ccf02DataSetBindingSource;
            // 
            // ccf02DataSetBindingSource
            // 
            this.ccf02DataSetBindingSource.DataSource = this.ccf02DataSet;
            this.ccf02DataSetBindingSource.Position = 0;
            // 
            // ccf02DataSet
            // 
            this.ccf02DataSet.DataSetName = "ccf02DataSet";
            this.ccf02DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // person_testTableAdapter
            // 
            this.person_testTableAdapter.ClearBeforeFill = true;
            // 
            // capsulesBindingSource
            // 
            this.capsulesBindingSource.DataMember = "capsules";
            this.capsulesBindingSource.DataSource = this.ccf02DataSetBindingSource;
            // 
            // capsulesTableAdapter
            // 
            this.capsulesTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(564, 78);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(529, 170);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(191, 85);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.persontestBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ccf02DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ccf02DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.capsulesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource ccf02DataSetBindingSource;
        private ccf02DataSet ccf02DataSet;
        private System.Windows.Forms.BindingSource persontestBindingSource;
        private ccf02DataSetTableAdapters.person_testTableAdapter person_testTableAdapter;
        private System.Windows.Forms.BindingSource capsulesBindingSource;
        private ccf02DataSetTableAdapters.capsulesTableAdapter capsulesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idpersontestDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

