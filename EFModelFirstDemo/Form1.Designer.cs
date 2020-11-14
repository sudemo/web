namespace EFModelFirstDemo
{
    partial class Form1
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
            this.ccf02DataSet = new EFModelFirstDemo.ccf02DataSet();
            this.ccf02DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.person_testTableAdapter1 = new EFModelFirstDemo.ccf02DataSetTableAdapters.person_testTableAdapter();
            this.persontestBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ccf02DataSet1 = new EFModelFirstDemo.ccf02DataSet1();
            this.ccf02DataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.persontestBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.person_testTableAdapter = new EFModelFirstDemo.ccf02DataSet1TableAdapters.person_testTableAdapter();
            this.idpersontestDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ccf02DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ccf02DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.persontestBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ccf02DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ccf02DataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.persontestBindingSource1)).BeginInit();
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
            this.dataGridView1.DataSource = this.persontestBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_2);
            // 
            // ccf02DataSet
            // 
            this.ccf02DataSet.DataSetName = "ccf02DataSet";
            this.ccf02DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ccf02DataSetBindingSource
            // 
            this.ccf02DataSetBindingSource.DataSource = this.ccf02DataSet;
            this.ccf02DataSetBindingSource.Position = 0;
            // 
            // person_testTableAdapter1
            // 
            this.person_testTableAdapter1.ClearBeforeFill = true;
            // 
            // persontestBindingSource
            // 
            this.persontestBindingSource.DataMember = "person_test";
            this.persontestBindingSource.DataSource = this.ccf02DataSetBindingSource;
            // 
            // ccf02DataSet1
            // 
            this.ccf02DataSet1.DataSetName = "ccf02DataSet1";
            this.ccf02DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ccf02DataSet1BindingSource
            // 
            this.ccf02DataSet1BindingSource.DataSource = this.ccf02DataSet1;
            this.ccf02DataSet1BindingSource.Position = 0;
            // 
            // persontestBindingSource1
            // 
            this.persontestBindingSource1.DataMember = "person_test";
            this.persontestBindingSource1.DataSource = this.ccf02DataSet1BindingSource;
            // 
            // person_testTableAdapter
            // 
            this.person_testTableAdapter.ClearBeforeFill = true;
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(457, 91);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ccf02DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ccf02DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.persontestBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ccf02DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ccf02DataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.persontestBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource ccf02DataSetBindingSource;
        private ccf02DataSet ccf02DataSet;
        private System.Windows.Forms.BindingSource ccf02DataSet1BindingSource;
        private ccf02DataSet1 ccf02DataSet1;
        private ccf02DataSetTableAdapters.person_testTableAdapter person_testTableAdapter1;
        private System.Windows.Forms.BindingSource persontestBindingSource;
        private System.Windows.Forms.BindingSource persontestBindingSource1;
        private ccf02DataSet1TableAdapters.person_testTableAdapter person_testTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idpersontestDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
    }
}