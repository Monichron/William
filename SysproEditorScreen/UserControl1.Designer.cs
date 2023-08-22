namespace SysproEditorScreen
{
    partial class UserControl1
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
            this.components = new System.ComponentModel.Container();
            this.MainGrid = new System.Windows.Forms.DataGridView();
            this.FilterOptionsCmbo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SearchGrp = new System.Windows.Forms.GroupBox();
            this.SearchInput = new System.Windows.Forms.RichTextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ColumnCmbo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DateGrp = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.MainGrid)).BeginInit();
            this.SearchGrp.SuspendLayout();
            this.DateGrp.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainGrid
            // 
            this.MainGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MainGrid.Location = new System.Drawing.Point(3, 3);
            this.MainGrid.Name = "MainGrid";
            this.MainGrid.Size = new System.Drawing.Size(1019, 444);
            this.MainGrid.TabIndex = 0;
            this.MainGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // FilterOptionsCmbo
            // 
            this.FilterOptionsCmbo.FormattingEnabled = true;
            this.FilterOptionsCmbo.Location = new System.Drawing.Point(1028, 31);
            this.FilterOptionsCmbo.Name = "FilterOptionsCmbo";
            this.FilterOptionsCmbo.Size = new System.Drawing.Size(214, 21);
            this.FilterOptionsCmbo.TabIndex = 1;
            this.FilterOptionsCmbo.SelectedIndexChanged += new System.EventHandler(this.FilterOptionsCmbo_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1028, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Filter Options:";
            // 
            // SearchGrp
            // 
            this.SearchGrp.Controls.Add(this.label3);
            this.SearchGrp.Controls.Add(this.label2);
            this.SearchGrp.Controls.Add(this.ColumnCmbo);
            this.SearchGrp.Controls.Add(this.SearchInput);
            this.SearchGrp.Location = new System.Drawing.Point(1028, 82);
            this.SearchGrp.Name = "SearchGrp";
            this.SearchGrp.Size = new System.Drawing.Size(246, 161);
            this.SearchGrp.TabIndex = 3;
            this.SearchGrp.TabStop = false;
            this.SearchGrp.Text = "Search";
            this.SearchGrp.Visible = false;
            // 
            // SearchInput
            // 
            this.SearchInput.Location = new System.Drawing.Point(6, 97);
            this.SearchInput.Name = "SearchInput";
            this.SearchInput.Size = new System.Drawing.Size(234, 32);
            this.SearchInput.TabIndex = 0;
            this.SearchInput.Text = "";
            this.SearchInput.TextChanged += new System.EventHandler(this.SearchInput_TextChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // ColumnCmbo
            // 
            this.ColumnCmbo.FormattingEnabled = true;
            this.ColumnCmbo.Location = new System.Drawing.Point(6, 44);
            this.ColumnCmbo.Name = "ColumnCmbo";
            this.ColumnCmbo.Size = new System.Drawing.Size(234, 21);
            this.ColumnCmbo.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Pick Field To Filter On:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Type To Search";
            // 
            // DateGrp
            // 
            this.DateGrp.Controls.Add(this.button1);
            this.DateGrp.Controls.Add(this.label6);
            this.DateGrp.Controls.Add(this.dateTimePicker2);
            this.DateGrp.Controls.Add(this.comboBox1);
            this.DateGrp.Controls.Add(this.label5);
            this.DateGrp.Controls.Add(this.label4);
            this.DateGrp.Controls.Add(this.dateTimePicker1);
            this.DateGrp.Location = new System.Drawing.Point(1031, 268);
            this.DateGrp.Name = "DateGrp";
            this.DateGrp.Size = new System.Drawing.Size(246, 228);
            this.DateGrp.TabIndex = 3;
            this.DateGrp.TabStop = false;
            this.DateGrp.Text = "Find By Date";
            this.DateGrp.Visible = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(20, 99);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(20, 157);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Start Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "End Date";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(75, 193);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Find";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 47);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(234, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Pick Field To Filter On:";
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.DateGrp);
            this.Controls.Add(this.SearchGrp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FilterOptionsCmbo);
            this.Controls.Add(this.MainGrid);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(1299, 602);
            this.Load += new System.EventHandler(this.UserControl1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MainGrid)).EndInit();
            this.SearchGrp.ResumeLayout(false);
            this.SearchGrp.PerformLayout();
            this.DateGrp.ResumeLayout(false);
            this.DateGrp.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView MainGrid;
        private System.Windows.Forms.ComboBox FilterOptionsCmbo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox SearchGrp;
        private System.Windows.Forms.RichTextBox SearchInput;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ComboBox ColumnCmbo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox DateGrp;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}
