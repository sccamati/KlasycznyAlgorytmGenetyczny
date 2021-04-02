
namespace lab2
{
    partial class NBox
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.ObliczButton = new System.Windows.Forms.Button();
            this.ABox = new System.Windows.Forms.TextBox();
            this.BBox = new System.Windows.Forms.TextBox();
            this.CountBox = new System.Windows.Forms.TextBox();
            this.DBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BitCountBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pkBox = new System.Windows.Forms.TextBox();
            this.pmBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tBox = new System.Windows.Forms.TextBox();
            this.chartButton = new System.Windows.Forms.Button();
            this.TableView = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xrealDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xbitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fxDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.persentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.individualBindingSource10 = new System.Windows.Forms.BindingSource(this.components);
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.wykres = new System.Windows.Forms.Panel();
            this.zad2 = new System.Windows.Forms.Button();
            this.zad2Panel = new System.Windows.Forms.Panel();
            this.zad2Table = new System.Windows.Forms.DataGridView();
            this.nDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pmDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fmaxDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.favgDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.generationBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.generateZad2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.checkElite = new System.Windows.Forms.CheckBox();
            this.generationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.TableView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.individualBindingSource10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            this.wykres.SuspendLayout();
            this.zad2Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.zad2Table)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.generationBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.generationBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ObliczButton
            // 
            this.ObliczButton.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ObliczButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ObliczButton.ForeColor = System.Drawing.Color.DodgerBlue;
            this.ObliczButton.Location = new System.Drawing.Point(653, 65);
            this.ObliczButton.Name = "ObliczButton";
            this.ObliczButton.Size = new System.Drawing.Size(126, 31);
            this.ObliczButton.TabIndex = 0;
            this.ObliczButton.Text = "Generuj";
            this.ObliczButton.UseVisualStyleBackColor = false;
            this.ObliczButton.Click += new System.EventHandler(this.ObliczButton_Click);
            // 
            // ABox
            // 
            this.ABox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ABox.Location = new System.Drawing.Point(52, 23);
            this.ABox.Name = "ABox";
            this.ABox.Size = new System.Drawing.Size(21, 20);
            this.ABox.TabIndex = 1;
            this.ABox.Text = "-4";
            this.ABox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ABox_KeyPress);
            // 
            // BBox
            // 
            this.BBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BBox.Location = new System.Drawing.Point(79, 23);
            this.BBox.Name = "BBox";
            this.BBox.Size = new System.Drawing.Size(24, 20);
            this.BBox.TabIndex = 2;
            this.BBox.Text = "12";
            this.BBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BBox_KeyPress);
            // 
            // CountBox
            // 
            this.CountBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CountBox.Location = new System.Drawing.Point(35, 76);
            this.CountBox.Name = "CountBox";
            this.CountBox.Size = new System.Drawing.Size(100, 20);
            this.CountBox.TabIndex = 3;
            this.CountBox.Text = "65";
            this.CountBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CountBox_KeyPress);
            // 
            // DBox
            // 
            this.DBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DBox.ForeColor = System.Drawing.Color.Black;
            this.DBox.Location = new System.Drawing.Point(166, 24);
            this.DBox.Name = "DBox";
            this.DBox.Size = new System.Drawing.Size(100, 20);
            this.DBox.TabIndex = 4;
            this.DBox.Text = "1000";
            this.DBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DBox_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(31, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "[";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(109, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "]";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.SteelBlue;
            this.label3.Location = new System.Drawing.Point(32, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "ilość osobników";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.Color.SteelBlue;
            this.label4.Location = new System.Drawing.Point(175, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "dokładność";
            // 
            // BitCountBox
            // 
            this.BitCountBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BitCountBox.Location = new System.Drawing.Point(544, 24);
            this.BitCountBox.Name = "BitCountBox";
            this.BitCountBox.ReadOnly = true;
            this.BitCountBox.Size = new System.Drawing.Size(60, 20);
            this.BitCountBox.TabIndex = 10;
            this.BitCountBox.TextChanged += new System.EventHandler(this.BitCountBox_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Gainsboro;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.Color.SteelBlue;
            this.label5.Location = new System.Drawing.Point(530, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "liczba bitów";
            // 
            // pkBox
            // 
            this.pkBox.Location = new System.Drawing.Point(335, 24);
            this.pkBox.Name = "pkBox";
            this.pkBox.Size = new System.Drawing.Size(100, 20);
            this.pkBox.TabIndex = 13;
            this.pkBox.Text = "0,7";
            this.pkBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.pkBox_KeyPress);
            // 
            // pmBox
            // 
            this.pmBox.Location = new System.Drawing.Point(211, 76);
            this.pmBox.Name = "pmBox";
            this.pmBox.Size = new System.Drawing.Size(100, 20);
            this.pmBox.TabIndex = 14;
            this.pmBox.Text = "0,0001";
            this.pmBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.pmBox_KeyPress);
            // 
            // label6
            // 
            this.label6.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.ForeColor = System.Drawing.Color.SteelBlue;
            this.label6.Location = new System.Drawing.Point(290, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(218, 15);
            this.label6.TabIndex = 15;
            this.label6.Text = "prawdopodobieństwo kryżowania";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.ForeColor = System.Drawing.Color.SteelBlue;
            this.label7.Location = new System.Drawing.Point(163, 58);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(194, 15);
            this.label7.TabIndex = 16;
            this.label7.Text = "prawdopodobieństwo mutacji";
            // 
            // tBox
            // 
            this.tBox.Location = new System.Drawing.Point(389, 76);
            this.tBox.Name = "tBox";
            this.tBox.Size = new System.Drawing.Size(100, 20);
            this.tBox.TabIndex = 17;
            this.tBox.Text = "140";
            // 
            // chartButton
            // 
            this.chartButton.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.chartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.chartButton.ForeColor = System.Drawing.Color.DodgerBlue;
            this.chartButton.Location = new System.Drawing.Point(653, 17);
            this.chartButton.Name = "chartButton";
            this.chartButton.Size = new System.Drawing.Size(126, 31);
            this.chartButton.TabIndex = 20;
            this.chartButton.Text = "Wykres";
            this.chartButton.UseVisualStyleBackColor = false;
            this.chartButton.Click += new System.EventHandler(this.chartButton_Click);
            // 
            // TableView
            // 
            this.TableView.AllowUserToAddRows = false;
            this.TableView.AllowUserToDeleteRows = false;
            this.TableView.AutoGenerateColumns = false;
            this.TableView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TableView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.xrealDataGridViewTextBoxColumn,
            this.xbitDataGridViewTextBoxColumn,
            this.fxDataGridViewTextBoxColumn,
            this.persentDataGridViewTextBoxColumn});
            this.TableView.DataSource = this.individualBindingSource10;
            this.TableView.Location = new System.Drawing.Point(23, 115);
            this.TableView.Name = "TableView";
            this.TableView.ReadOnly = true;
            this.TableView.Size = new System.Drawing.Size(569, 272);
            this.TableView.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // xrealDataGridViewTextBoxColumn
            // 
            this.xrealDataGridViewTextBoxColumn.DataPropertyName = "Xreal";
            this.xrealDataGridViewTextBoxColumn.HeaderText = "Xreal";
            this.xrealDataGridViewTextBoxColumn.Name = "xrealDataGridViewTextBoxColumn";
            this.xrealDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // xbitDataGridViewTextBoxColumn
            // 
            this.xbitDataGridViewTextBoxColumn.DataPropertyName = "Xbit";
            this.xbitDataGridViewTextBoxColumn.HeaderText = "Xbit";
            this.xbitDataGridViewTextBoxColumn.Name = "xbitDataGridViewTextBoxColumn";
            this.xbitDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fxDataGridViewTextBoxColumn
            // 
            this.fxDataGridViewTextBoxColumn.DataPropertyName = "Fx";
            this.fxDataGridViewTextBoxColumn.HeaderText = "Fx";
            this.fxDataGridViewTextBoxColumn.Name = "fxDataGridViewTextBoxColumn";
            this.fxDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // persentDataGridViewTextBoxColumn
            // 
            this.persentDataGridViewTextBoxColumn.DataPropertyName = "Persent";
            this.persentDataGridViewTextBoxColumn.HeaderText = "Persent";
            this.persentDataGridViewTextBoxColumn.Name = "persentDataGridViewTextBoxColumn";
            this.persentDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // individualBindingSource10
            // 
            this.individualBindingSource10.DataSource = typeof(lab2.classes.Individual);
            // 
            // chart
            // 
            chartArea3.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart.Legends.Add(legend3);
            this.chart.Location = new System.Drawing.Point(14, 13);
            this.chart.Name = "chart";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chart.Series.Add(series3);
            this.chart.Size = new System.Drawing.Size(1320, 590);
            this.chart.TabIndex = 18;
            this.chart.Text = "chart1";
            this.chart.Click += new System.EventHandler(this.chart_Click);
            // 
            // wykres
            // 
            this.wykres.Controls.Add(this.chart);
            this.wykres.Location = new System.Drawing.Point(12, 102);
            this.wykres.Name = "wykres";
            this.wykres.Size = new System.Drawing.Size(1378, 619);
            this.wykres.TabIndex = 21;
            // 
            // zad2
            // 
            this.zad2.Location = new System.Drawing.Point(818, 24);
            this.zad2.Name = "zad2";
            this.zad2.Size = new System.Drawing.Size(75, 23);
            this.zad2.TabIndex = 22;
            this.zad2.Text = "zad2";
            this.zad2.UseVisualStyleBackColor = true;
            this.zad2.Click += new System.EventHandler(this.zad2_Click);
            // 
            // zad2Panel
            // 
            this.zad2Panel.Controls.Add(this.zad2Table);
            this.zad2Panel.Controls.Add(this.generateZad2);
            this.zad2Panel.Controls.Add(this.button1);
            this.zad2Panel.Location = new System.Drawing.Point(15, 6);
            this.zad2Panel.Name = "zad2Panel";
            this.zad2Panel.Size = new System.Drawing.Size(1383, 723);
            this.zad2Panel.TabIndex = 23;
            // 
            // zad2Table
            // 
            this.zad2Table.AllowUserToAddRows = false;
            this.zad2Table.AllowUserToDeleteRows = false;
            this.zad2Table.AutoGenerateColumns = false;
            this.zad2Table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.zad2Table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nDataGridViewTextBoxColumn,
            this.tDataGridViewTextBoxColumn,
            this.pkDataGridViewTextBoxColumn,
            this.pmDataGridViewTextBoxColumn,
            this.fmaxDataGridViewTextBoxColumn,
            this.favgDataGridViewTextBoxColumn});
            this.zad2Table.DataSource = this.generationBindingSource1;
            this.zad2Table.Location = new System.Drawing.Point(67, 70);
            this.zad2Table.Name = "zad2Table";
            this.zad2Table.ReadOnly = true;
            this.zad2Table.Size = new System.Drawing.Size(820, 584);
            this.zad2Table.TabIndex = 2;
            // 
            // nDataGridViewTextBoxColumn
            // 
            this.nDataGridViewTextBoxColumn.DataPropertyName = "N";
            this.nDataGridViewTextBoxColumn.HeaderText = "N";
            this.nDataGridViewTextBoxColumn.Name = "nDataGridViewTextBoxColumn";
            this.nDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tDataGridViewTextBoxColumn
            // 
            this.tDataGridViewTextBoxColumn.DataPropertyName = "T";
            this.tDataGridViewTextBoxColumn.HeaderText = "T";
            this.tDataGridViewTextBoxColumn.Name = "tDataGridViewTextBoxColumn";
            this.tDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pkDataGridViewTextBoxColumn
            // 
            this.pkDataGridViewTextBoxColumn.DataPropertyName = "Pk";
            this.pkDataGridViewTextBoxColumn.HeaderText = "Pk";
            this.pkDataGridViewTextBoxColumn.Name = "pkDataGridViewTextBoxColumn";
            this.pkDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pmDataGridViewTextBoxColumn
            // 
            this.pmDataGridViewTextBoxColumn.DataPropertyName = "Pm";
            this.pmDataGridViewTextBoxColumn.HeaderText = "Pm";
            this.pmDataGridViewTextBoxColumn.Name = "pmDataGridViewTextBoxColumn";
            this.pmDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fmaxDataGridViewTextBoxColumn
            // 
            this.fmaxDataGridViewTextBoxColumn.DataPropertyName = "Fmax";
            this.fmaxDataGridViewTextBoxColumn.HeaderText = "Fmax";
            this.fmaxDataGridViewTextBoxColumn.Name = "fmaxDataGridViewTextBoxColumn";
            this.fmaxDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // favgDataGridViewTextBoxColumn
            // 
            this.favgDataGridViewTextBoxColumn.DataPropertyName = "Favg";
            this.favgDataGridViewTextBoxColumn.HeaderText = "Favg";
            this.favgDataGridViewTextBoxColumn.Name = "favgDataGridViewTextBoxColumn";
            this.favgDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // generationBindingSource1
            // 
            this.generationBindingSource1.DataSource = typeof(lab2.classes.Generation);
            // 
            // generateZad2
            // 
            this.generateZad2.Location = new System.Drawing.Point(81, 34);
            this.generateZad2.Name = "generateZad2";
            this.generateZad2.Size = new System.Drawing.Size(75, 23);
            this.generateZad2.TabIndex = 1;
            this.generateZad2.Text = "Generuj";
            this.generateZad2.UseVisualStyleBackColor = true;
            this.generateZad2.Click += new System.EventHandler(this.generateZad2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(176, 34);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "zad1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkElite
            // 
            this.checkElite.AutoSize = true;
            this.checkElite.Checked = true;
            this.checkElite.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkElite.Location = new System.Drawing.Point(919, 26);
            this.checkElite.Name = "checkElite";
            this.checkElite.Size = new System.Drawing.Size(45, 17);
            this.checkElite.TabIndex = 24;
            this.checkElite.Text = "elite";
            this.checkElite.UseVisualStyleBackColor = true;
            // 
            // generationBindingSource
            // 
            this.generationBindingSource.DataSource = typeof(lab2.classes.Generation);
            // 
            // NBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1402, 733);
            this.Controls.Add(this.checkElite);
            this.Controls.Add(this.zad2Panel);
            this.Controls.Add(this.zad2);
            this.Controls.Add(this.wykres);
            this.Controls.Add(this.TableView);
            this.Controls.Add(this.chartButton);
            this.Controls.Add(this.tBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pmBox);
            this.Controls.Add(this.pkBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.BitCountBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DBox);
            this.Controls.Add(this.CountBox);
            this.Controls.Add(this.BBox);
            this.Controls.Add(this.ABox);
            this.Controls.Add(this.ObliczButton);
            this.Name = "NBox";
            this.Text = "Inteligentne Systemy Agentowe";
            ((System.ComponentModel.ISupportInitialize)(this.TableView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.individualBindingSource10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.wykres.ResumeLayout(false);
            this.zad2Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.zad2Table)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.generationBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.generationBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ObliczButton;
        private System.Windows.Forms.TextBox ABox;
        private System.Windows.Forms.TextBox BBox;
        private System.Windows.Forms.TextBox CountBox;
        private System.Windows.Forms.TextBox DBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox BitCountBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn xDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox pkBox;
        private System.Windows.Forms.TextBox pmBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tBox;
        private System.Windows.Forms.Button chartButton;
        private System.Windows.Forms.DataGridView TableView;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn xrealDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn xbitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fxDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn persentDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource individualBindingSource10;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.Panel wykres;
        private System.Windows.Forms.Button zad2;
        private System.Windows.Forms.Panel zad2Panel;
        private System.Windows.Forms.Button generateZad2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn fminDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource generationBindingSource;
        private System.Windows.Forms.DataGridView zad2Table;
        private System.Windows.Forms.DataGridViewTextBoxColumn nDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pkDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pmDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fmaxDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn favgDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource generationBindingSource1;
        private System.Windows.Forms.CheckBox checkElite;
    }
}

