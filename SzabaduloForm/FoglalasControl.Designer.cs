namespace SzabaduloForm
{
    partial class FoglalasControl
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
            components = new System.ComponentModel.Container();
            SzobaTxt = new TextBox();
            SzobaLb = new ListBox();
            szobakBindingSource = new BindingSource(components);
            TorlesButton = new Button();
            dataGridView1 = new DataGridView();
            időpontDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            állapotDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn1 = new DataGridViewComboBoxColumn();
            jatekosokBindingSource = new BindingSource(components);
            megjelenitdtoBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)szobakBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)jatekosokBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)megjelenitdtoBindingSource).BeginInit();
            SuspendLayout();
            // 
            // SzobaTxt
            // 
            SzobaTxt.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            SzobaTxt.Location = new Point(17, 12);
            SzobaTxt.Name = "SzobaTxt";
            SzobaTxt.Size = new Size(187, 23);
            SzobaTxt.TabIndex = 0;
            SzobaTxt.TextChanged += SzobaTxt_TextChanged;
            // 
            // SzobaLb
            // 
            SzobaLb.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            SzobaLb.DataSource = szobakBindingSource;
            SzobaLb.DisplayMember = "Nev";
            SzobaLb.FormattingEnabled = true;
            SzobaLb.ItemHeight = 15;
            SzobaLb.Location = new Point(17, 41);
            SzobaLb.Name = "SzobaLb";
            SzobaLb.Size = new Size(187, 289);
            SzobaLb.TabIndex = 1;
            SzobaLb.ValueMember = "SzobaId";
            SzobaLb.SelectedIndexChanged += SzobaLb_SelectedIndexChanged;
            // 
            // szobakBindingSource
            // 
            szobakBindingSource.DataSource = typeof(Mappa.Szobak);
            // 
            // TorlesButton
            // 
            TorlesButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TorlesButton.ForeColor = Color.Red;
            TorlesButton.Location = new Point(17, 351);
            TorlesButton.Name = "TorlesButton";
            TorlesButton.Size = new Size(187, 29);
            TorlesButton.TabIndex = 2;
            TorlesButton.Text = "Szoba törlése";
            TorlesButton.UseVisualStyleBackColor = true;
            TorlesButton.Click += TorlesButton_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { időpontDataGridViewTextBoxColumn, állapotDataGridViewTextBoxColumn, dataGridViewTextBoxColumn1 });
            dataGridView1.DataSource = megjelenitdtoBindingSource;
            dataGridView1.Location = new Point(220, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(558, 368);
            dataGridView1.TabIndex = 3;
            // 
            // időpontDataGridViewTextBoxColumn
            // 
            időpontDataGridViewTextBoxColumn.DataPropertyName = "Időpont";
            időpontDataGridViewTextBoxColumn.HeaderText = "Időpont";
            időpontDataGridViewTextBoxColumn.Name = "időpontDataGridViewTextBoxColumn";
            // 
            // állapotDataGridViewTextBoxColumn
            // 
            állapotDataGridViewTextBoxColumn.DataPropertyName = "Állapot";
            állapotDataGridViewTextBoxColumn.HeaderText = "Állapot";
            állapotDataGridViewTextBoxColumn.Name = "állapotDataGridViewTextBoxColumn";
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.DataPropertyName = "Játékos";
            dataGridViewTextBoxColumn1.DataSource = jatekosokBindingSource;
            dataGridViewTextBoxColumn1.DisplayMember = "Nev";
            dataGridViewTextBoxColumn1.HeaderText = "Játékos";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.Resizable = DataGridViewTriState.True;
            dataGridViewTextBoxColumn1.SortMode = DataGridViewColumnSortMode.Automatic;
            dataGridViewTextBoxColumn1.ValueMember = "JatekosId";
            // 
            // jatekosokBindingSource
            // 
            jatekosokBindingSource.DataSource = typeof(Mappa.Jatekosok);
            // 
            // megjelenitdtoBindingSource
            // 
            megjelenitdtoBindingSource.DataSource = typeof(megjelenitdto);
            // 
            // FoglalasControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            Controls.Add(dataGridView1);
            Controls.Add(TorlesButton);
            Controls.Add(SzobaLb);
            Controls.Add(SzobaTxt);
            Name = "FoglalasControl";
            Size = new Size(793, 402);
            ((System.ComponentModel.ISupportInitialize)szobakBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)jatekosokBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)megjelenitdtoBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox SzobaTxt;
        private ListBox SzobaLb;
        private Button TorlesButton;
        private DataGridView dataGridView1;
        private BindingSource szobakBindingSource;
        private DataGridViewTextBoxColumn időpontDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn állapotDataGridViewTextBoxColumn;
        private DataGridViewComboBoxColumn dataGridViewTextBoxColumn1;
        private BindingSource jatekosokBindingSource;
        private BindingSource megjelenitdtoBindingSource;
    }
}
