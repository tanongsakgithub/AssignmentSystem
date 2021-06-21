
namespace WindowsFormsApp1
{
    partial class ToDoTeamEditor
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
            this.btnSubmit = new System.Windows.Forms.Button();
            this.txtdetail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbbmembers = new System.Windows.Forms.ComboBox();
            this.tblteammemcbbBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetAssignDB = new WindowsFormsApp1.DataSetAssignDB();
            this.tblteammemcbbTableAdapter = new WindowsFormsApp1.DataSetAssignDBTableAdapters.tblteammemcbbTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tblteammemcbbBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetAssignDB)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(437, 291);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(113, 30);
            this.btnSubmit.TabIndex = 8;
            this.btnSubmit.Text = "บันทึก";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // txtdetail
            // 
            this.txtdetail.Location = new System.Drawing.Point(109, 22);
            this.txtdetail.MaxLength = 1000;
            this.txtdetail.Multiline = true;
            this.txtdetail.Name = "txtdetail";
            this.txtdetail.Size = new System.Drawing.Size(441, 232);
            this.txtdetail.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label1.Location = new System.Drawing.Point(17, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "รายละเอียด";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label2.Location = new System.Drawing.Point(17, 260);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "สมาชิก";
            // 
            // cbbmembers
            // 
            this.cbbmembers.DataSource = this.tblteammemcbbBindingSource;
            this.cbbmembers.DisplayMember = "Name";
            this.cbbmembers.FormattingEnabled = true;
            this.cbbmembers.Location = new System.Drawing.Point(109, 260);
            this.cbbmembers.Name = "cbbmembers";
            this.cbbmembers.Size = new System.Drawing.Size(250, 24);
            this.cbbmembers.TabIndex = 10;
            this.cbbmembers.ValueMember = "userid";
            // 
            // tblteammemcbbBindingSource
            // 
            this.tblteammemcbbBindingSource.DataMember = "tblteammemcbb";
            this.tblteammemcbbBindingSource.DataSource = this.dataSetAssignDB;
            // 
            // dataSetAssignDB
            // 
            this.dataSetAssignDB.DataSetName = "DataSetAssignDB";
            this.dataSetAssignDB.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblteammemcbbTableAdapter
            // 
            this.tblteammemcbbTableAdapter.ClearBeforeFill = true;
            // 
            // ToDoTeamEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 334);
            this.Controls.Add(this.cbbmembers);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtdetail);
            this.Controls.Add(this.label1);
            this.Name = "ToDoTeamEditor";
            this.Text = "ToDoTeamEditor";
            this.Load += new System.EventHandler(this.ToDoTeamEditor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblteammemcbbBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetAssignDB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox txtdetail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbbmembers;
        private System.Windows.Forms.BindingSource tblteammemcbbBindingSource;
        private DataSetAssignDB dataSetAssignDB;
        private DataSetAssignDBTableAdapters.tblteammemcbbTableAdapter tblteammemcbbTableAdapter;
    }
}