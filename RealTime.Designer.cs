namespace Lead.Tool.Log
{
    partial class RealTime
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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.时间 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.级别 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.线程ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.信息 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Fatal = new System.Windows.Forms.CheckBox();
            this.Error = new System.Windows.Forms.CheckBox();
            this.Warn = new System.Windows.Forms.CheckBox();
            this.Info = new System.Windows.Forms.CheckBox();
            this.OK = new System.Windows.Forms.CheckBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(734, 426);
            this.panel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(734, 426);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView2);
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(2, 42);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(730, 382);
            this.panel2.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.时间,
            this.级别,
            this.线程ID,
            this.信息});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(730, 382);
            this.dataGridView1.TabIndex = 0;
            // 
            // 时间
            // 
            this.时间.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.时间.HeaderText = "时间";
            this.时间.Name = "时间";
            this.时间.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.时间.Width = 35;
            // 
            // 级别
            // 
            this.级别.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.级别.HeaderText = "级别";
            this.级别.Name = "级别";
            this.级别.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.级别.Width = 35;
            // 
            // 线程ID
            // 
            this.线程ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.线程ID.HeaderText = "线程ID";
            this.线程ID.Name = "线程ID";
            this.线程ID.Width = 66;
            // 
            // 信息
            // 
            this.信息.HeaderText = "信息";
            this.信息.Name = "信息";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.Fatal);
            this.panel3.Controls.Add(this.Error);
            this.panel3.Controls.Add(this.Warn);
            this.panel3.Controls.Add(this.Info);
            this.panel3.Controls.Add(this.OK);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(2, 2);
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(730, 36);
            this.panel3.TabIndex = 1;
            // 
            // Fatal
            // 
            this.Fatal.AutoSize = true;
            this.Fatal.Checked = true;
            this.Fatal.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Fatal.Location = new System.Drawing.Point(585, 2);
            this.Fatal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Fatal.Name = "Fatal";
            this.Fatal.Size = new System.Drawing.Size(54, 16);
            this.Fatal.TabIndex = 4;
            this.Fatal.Text = "Fatal";
            this.Fatal.UseVisualStyleBackColor = true;
            this.Fatal.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // Error
            // 
            this.Error.AutoSize = true;
            this.Error.Checked = true;
            this.Error.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Error.Location = new System.Drawing.Point(448, 2);
            this.Error.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Error.Name = "Error";
            this.Error.Size = new System.Drawing.Size(54, 16);
            this.Error.TabIndex = 3;
            this.Error.Text = "Error";
            this.Error.UseVisualStyleBackColor = true;
            this.Error.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // Warn
            // 
            this.Warn.AutoSize = true;
            this.Warn.Checked = true;
            this.Warn.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Warn.Location = new System.Drawing.Point(322, 2);
            this.Warn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Warn.Name = "Warn";
            this.Warn.Size = new System.Drawing.Size(48, 16);
            this.Warn.TabIndex = 2;
            this.Warn.Text = "Warn";
            this.Warn.UseVisualStyleBackColor = true;
            this.Warn.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // Info
            // 
            this.Info.AutoSize = true;
            this.Info.Location = new System.Drawing.Point(79, 2);
            this.Info.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Info.Name = "Info";
            this.Info.Size = new System.Drawing.Size(48, 16);
            this.Info.TabIndex = 1;
            this.Info.Text = "Info";
            this.Info.UseVisualStyleBackColor = true;
            this.Info.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // OK
            // 
            this.OK.AutoSize = true;
            this.OK.Checked = true;
            this.OK.CheckState = System.Windows.Forms.CheckState.Checked;
            this.OK.Location = new System.Drawing.Point(207, 2);
            this.OK.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(36, 16);
            this.OK.TabIndex = 0;
            this.OK.Text = "OK";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToResizeColumns = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(0, 0);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 27;
            this.dataGridView2.Size = new System.Drawing.Size(730, 382);
            this.dataGridView2.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn1.HeaderText = "时间";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn1.Width = 35;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn2.HeaderText = "级别";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn2.Width = 35;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn3.HeaderText = "线程ID";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 66;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "信息";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // RealTime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "RealTime";
            this.Size = new System.Drawing.Size(734, 426);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.CheckBox Fatal;
        private System.Windows.Forms.CheckBox Error;
        private System.Windows.Forms.CheckBox Warn;
        private System.Windows.Forms.CheckBox Info;
        private System.Windows.Forms.CheckBox OK;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 时间;
        private System.Windows.Forms.DataGridViewTextBoxColumn 级别;
        private System.Windows.Forms.DataGridViewTextBoxColumn 线程ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn 信息;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}
