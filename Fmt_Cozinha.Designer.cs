namespace SGR
{
    partial class Fmt_Cozinha
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fmt_Cozinha));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tmrNextImage = new System.Windows.Forms.Timer(this.components);
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pedidoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dsSt1 = new SGR.dsSt1();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.DGVCozinha = new System.Windows.Forms.DataGridView();
            this.idPedidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empCodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pNomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mesaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pratoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeEmpregDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pAdicionalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusLocalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusPedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pedidoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSCozinha = new SGR.DSCozinha();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.pedidoTableAdapter = new SGR.DSCozinhaTableAdapters.PedidoTableAdapter();
            this.pedidoTableAdapter1 = new SGR.dsSt1TableAdapters.PedidoTableAdapter();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pedidoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSt1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVCozinha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pedidoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSCozinha)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tmrNextImage
            // 
            this.tmrNextImage.Enabled = true;
            this.tmrNextImage.Interval = 5000;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.listView1);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(880, 541);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Ementa";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView1.Location = new System.Drawing.Point(350, 58);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(321, 375);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Pedido";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Prato";
            this.columnHeader2.Width = 96;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Mesa";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Empregado";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader4.Width = 90;
            // 
            // pedidoBindingSource1
            // 
            this.pedidoBindingSource1.DataMember = "Pedido";
            this.pedidoBindingSource1.DataSource = this.dsSt1;
            // 
            // dsSt1
            // 
            this.dsSt1.DataSetName = "dsSt1";
            this.dsSt1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabPage2
            // 
            this.tabPage2.AutoScroll = true;
            this.tabPage2.Controls.Add(this.button3);
            this.tabPage2.Controls.Add(this.DGVCozinha);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(880, 541);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Pedidos do dia";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Gray;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(675, 404);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(172, 123);
            this.button3.TabIndex = 18;
            this.button3.Text = "Sair";
            this.button3.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // DGVCozinha
            // 
            this.DGVCozinha.AutoGenerateColumns = false;
            this.DGVCozinha.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DGVCozinha.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVCozinha.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idPedidoDataGridViewTextBoxColumn,
            this.empCodDataGridViewTextBoxColumn,
            this.pNomeDataGridViewTextBoxColumn,
            this.mesaDataGridViewTextBoxColumn,
            this.pratoDataGridViewTextBoxColumn,
            this.nomeEmpregDataGridViewTextBoxColumn,
            this.quantidadeDataGridViewTextBoxColumn,
            this.pAdicionalDataGridViewTextBoxColumn,
            this.statusLocalDataGridViewTextBoxColumn,
            this.statusPedDataGridViewTextBoxColumn,
            this.horaDataGridViewTextBoxColumn,
            this.dataDataGridViewTextBoxColumn});
            this.DGVCozinha.DataSource = this.pedidoBindingSource;
            this.DGVCozinha.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.DGVCozinha.Location = new System.Drawing.Point(-4, 3);
            this.DGVCozinha.MultiSelect = false;
            this.DGVCozinha.Name = "DGVCozinha";
            this.DGVCozinha.RightToLeft = System.Windows.Forms.RightToLeft.No;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Olive;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Goldenrod;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVCozinha.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DGVCozinha.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVCozinha.Size = new System.Drawing.Size(874, 385);
            this.DGVCozinha.TabIndex = 0;
            this.DGVCozinha.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVCozinha_CellClick);
            // 
            // idPedidoDataGridViewTextBoxColumn
            // 
            this.idPedidoDataGridViewTextBoxColumn.DataPropertyName = "Id_Pedido";
            this.idPedidoDataGridViewTextBoxColumn.HeaderText = "Id_Pedido";
            this.idPedidoDataGridViewTextBoxColumn.Name = "idPedidoDataGridViewTextBoxColumn";
            this.idPedidoDataGridViewTextBoxColumn.ReadOnly = true;
            this.idPedidoDataGridViewTextBoxColumn.Width = 30;
            // 
            // empCodDataGridViewTextBoxColumn
            // 
            this.empCodDataGridViewTextBoxColumn.DataPropertyName = "Emp_Cod";
            this.empCodDataGridViewTextBoxColumn.HeaderText = "Emp_Cod";
            this.empCodDataGridViewTextBoxColumn.Name = "empCodDataGridViewTextBoxColumn";
            this.empCodDataGridViewTextBoxColumn.Width = 50;
            // 
            // pNomeDataGridViewTextBoxColumn
            // 
            this.pNomeDataGridViewTextBoxColumn.DataPropertyName = "PNome";
            this.pNomeDataGridViewTextBoxColumn.HeaderText = "PNome";
            this.pNomeDataGridViewTextBoxColumn.Name = "pNomeDataGridViewTextBoxColumn";
            // 
            // mesaDataGridViewTextBoxColumn
            // 
            this.mesaDataGridViewTextBoxColumn.DataPropertyName = "mesa";
            this.mesaDataGridViewTextBoxColumn.HeaderText = "mesa";
            this.mesaDataGridViewTextBoxColumn.Name = "mesaDataGridViewTextBoxColumn";
            this.mesaDataGridViewTextBoxColumn.Width = 40;
            // 
            // pratoDataGridViewTextBoxColumn
            // 
            this.pratoDataGridViewTextBoxColumn.DataPropertyName = "Prato";
            this.pratoDataGridViewTextBoxColumn.HeaderText = "Prato";
            this.pratoDataGridViewTextBoxColumn.Name = "pratoDataGridViewTextBoxColumn";
            // 
            // nomeEmpregDataGridViewTextBoxColumn
            // 
            this.nomeEmpregDataGridViewTextBoxColumn.DataPropertyName = "NomeEmpreg";
            this.nomeEmpregDataGridViewTextBoxColumn.HeaderText = "NomeEmpreg";
            this.nomeEmpregDataGridViewTextBoxColumn.Name = "nomeEmpregDataGridViewTextBoxColumn";
            this.nomeEmpregDataGridViewTextBoxColumn.Width = 120;
            // 
            // quantidadeDataGridViewTextBoxColumn
            // 
            this.quantidadeDataGridViewTextBoxColumn.DataPropertyName = "Quantidade";
            this.quantidadeDataGridViewTextBoxColumn.HeaderText = "Quantidade";
            this.quantidadeDataGridViewTextBoxColumn.Name = "quantidadeDataGridViewTextBoxColumn";
            this.quantidadeDataGridViewTextBoxColumn.Width = 30;
            // 
            // pAdicionalDataGridViewTextBoxColumn
            // 
            this.pAdicionalDataGridViewTextBoxColumn.DataPropertyName = "PAdicional";
            this.pAdicionalDataGridViewTextBoxColumn.HeaderText = "PAdicional";
            this.pAdicionalDataGridViewTextBoxColumn.Name = "pAdicionalDataGridViewTextBoxColumn";
            this.pAdicionalDataGridViewTextBoxColumn.Width = 150;
            // 
            // statusLocalDataGridViewTextBoxColumn
            // 
            this.statusLocalDataGridViewTextBoxColumn.DataPropertyName = "Status_Local";
            this.statusLocalDataGridViewTextBoxColumn.HeaderText = "Status_Local";
            this.statusLocalDataGridViewTextBoxColumn.Name = "statusLocalDataGridViewTextBoxColumn";
            this.statusLocalDataGridViewTextBoxColumn.Width = 30;
            // 
            // statusPedDataGridViewTextBoxColumn
            // 
            this.statusPedDataGridViewTextBoxColumn.DataPropertyName = "Status_Ped";
            this.statusPedDataGridViewTextBoxColumn.HeaderText = "Status_Ped";
            this.statusPedDataGridViewTextBoxColumn.Name = "statusPedDataGridViewTextBoxColumn";
            this.statusPedDataGridViewTextBoxColumn.Width = 30;
            // 
            // horaDataGridViewTextBoxColumn
            // 
            this.horaDataGridViewTextBoxColumn.DataPropertyName = "Hora";
            this.horaDataGridViewTextBoxColumn.HeaderText = "Hora";
            this.horaDataGridViewTextBoxColumn.Name = "horaDataGridViewTextBoxColumn";
            this.horaDataGridViewTextBoxColumn.Width = 60;
            // 
            // dataDataGridViewTextBoxColumn
            // 
            this.dataDataGridViewTextBoxColumn.DataPropertyName = "Data";
            this.dataDataGridViewTextBoxColumn.HeaderText = "Data";
            this.dataDataGridViewTextBoxColumn.Name = "dataDataGridViewTextBoxColumn";
            // 
            // pedidoBindingSource
            // 
            this.pedidoBindingSource.DataMember = "Pedido";
            this.pedidoBindingSource.DataSource = this.dSCozinha;
            // 
            // dSCozinha
            // 
            this.dSCozinha.DataSetName = "DSCozinha";
            this.dSCozinha.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(21, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(888, 570);
            this.tabControl1.TabIndex = 0;
            // 
            // pedidoTableAdapter
            // 
            this.pedidoTableAdapter.ClearBeforeFill = true;
            // 
            // pedidoTableAdapter1
            // 
            this.pedidoTableAdapter1.ClearBeforeFill = true;
            // 
            // Fmt_Cozinha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 593);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Fmt_Cozinha";
            this.Text = "Receção e despacho de Pedidos";
            this.Load += new System.EventHandler(this.Fmt_Cozinha_Load);
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pedidoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSt1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVCozinha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pedidoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSCozinha)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer tmrNextImage;
        private DSCozinhaTableAdapters.PedidoTableAdapter pedidoTableAdapter;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView DGVCozinha;
        private System.Windows.Forms.BindingSource pedidoBindingSource;
        private DSCozinha dSCozinha;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPedidoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn empCodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pNomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mesaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pratoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeEmpregDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pAdicionalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusLocalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusPedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn horaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDataGridViewTextBoxColumn;
        private dsSt1 dsSt1;
        private System.Windows.Forms.BindingSource pedidoBindingSource1;
        private dsSt1TableAdapters.PedidoTableAdapter pedidoTableAdapter1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button button3;
    }
}