namespace SGR
{
    partial class Fmt_VerPedido
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fmt_VerPedido));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
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
            this.pedidoTableAdapter = new SGR.DSCozinhaTableAdapters.PedidoTableAdapter();
            this.Lblcozinha = new System.Windows.Forms.Label();
            this.LblMesa = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pedidoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSCozinha)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowDrop = true;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.dataGridView1.DataSource = this.pedidoBindingSource;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.Location = new System.Drawing.Point(38, 31);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(983, 224);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // idPedidoDataGridViewTextBoxColumn
            // 
            this.idPedidoDataGridViewTextBoxColumn.DataPropertyName = "Id_Pedido";
            this.idPedidoDataGridViewTextBoxColumn.HeaderText = "Id_Pedido";
            this.idPedidoDataGridViewTextBoxColumn.Name = "idPedidoDataGridViewTextBoxColumn";
            this.idPedidoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // empCodDataGridViewTextBoxColumn
            // 
            this.empCodDataGridViewTextBoxColumn.DataPropertyName = "Emp_Cod";
            this.empCodDataGridViewTextBoxColumn.HeaderText = "Emp_Cod";
            this.empCodDataGridViewTextBoxColumn.Name = "empCodDataGridViewTextBoxColumn";
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
            // 
            // quantidadeDataGridViewTextBoxColumn
            // 
            this.quantidadeDataGridViewTextBoxColumn.DataPropertyName = "Quantidade";
            this.quantidadeDataGridViewTextBoxColumn.HeaderText = "Quantidade";
            this.quantidadeDataGridViewTextBoxColumn.Name = "quantidadeDataGridViewTextBoxColumn";
            // 
            // pAdicionalDataGridViewTextBoxColumn
            // 
            this.pAdicionalDataGridViewTextBoxColumn.DataPropertyName = "PAdicional";
            this.pAdicionalDataGridViewTextBoxColumn.HeaderText = "PAdicional";
            this.pAdicionalDataGridViewTextBoxColumn.Name = "pAdicionalDataGridViewTextBoxColumn";
            // 
            // statusLocalDataGridViewTextBoxColumn
            // 
            this.statusLocalDataGridViewTextBoxColumn.DataPropertyName = "Status_Local";
            this.statusLocalDataGridViewTextBoxColumn.HeaderText = "Status_Local";
            this.statusLocalDataGridViewTextBoxColumn.Name = "statusLocalDataGridViewTextBoxColumn";
            // 
            // statusPedDataGridViewTextBoxColumn
            // 
            this.statusPedDataGridViewTextBoxColumn.DataPropertyName = "Status_Ped";
            this.statusPedDataGridViewTextBoxColumn.HeaderText = "Status_Ped";
            this.statusPedDataGridViewTextBoxColumn.Name = "statusPedDataGridViewTextBoxColumn";
            // 
            // horaDataGridViewTextBoxColumn
            // 
            this.horaDataGridViewTextBoxColumn.DataPropertyName = "Hora";
            this.horaDataGridViewTextBoxColumn.HeaderText = "Hora";
            this.horaDataGridViewTextBoxColumn.Name = "horaDataGridViewTextBoxColumn";
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
            // pedidoTableAdapter
            // 
            this.pedidoTableAdapter.ClearBeforeFill = true;
            // 
            // Lblcozinha
            // 
            this.Lblcozinha.AutoSize = true;
            this.Lblcozinha.Location = new System.Drawing.Point(78, 133);
            this.Lblcozinha.Name = "Lblcozinha";
            this.Lblcozinha.Size = new System.Drawing.Size(31, 13);
            this.Lblcozinha.TabIndex = 3;
            this.Lblcozinha.Text = "Total";
            // 
            // LblMesa
            // 
            this.LblMesa.AutoSize = true;
            this.LblMesa.Location = new System.Drawing.Point(274, 133);
            this.LblMesa.Name = "LblMesa";
            this.LblMesa.Size = new System.Drawing.Size(31, 13);
            this.LblMesa.TabIndex = 4;
            this.LblMesa.Text = "Total";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.Lblcozinha);
            this.panel1.Controls.Add(this.LblMesa);
            this.panel1.Location = new System.Drawing.Point(136, 268);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(381, 358);
            this.panel1.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(685, 305);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Fmt_VerPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1068, 638);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Fmt_VerPedido";
            this.Text = "Fmt_VerPedido";
           // this.Load += new System.EventHandler(this.Fmt_VerPedido_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pedidoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSCozinha)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private DSCozinha dSCozinha;
        private System.Windows.Forms.BindingSource pedidoBindingSource;
        private DSCozinhaTableAdapters.PedidoTableAdapter pedidoTableAdapter;
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
        private System.Windows.Forms.Label Lblcozinha;
        private System.Windows.Forms.Label LblMesa;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
    }
}