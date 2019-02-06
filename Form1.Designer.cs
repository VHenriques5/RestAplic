namespace SGR
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.TxtProcura = new System.Windows.Forms.TextBox();
            this.DGVPedidos = new System.Windows.Forms.DataGridView();
            this.TxtPrato = new System.Windows.Forms.TextBox();
            this.TxtPNome = new System.Windows.Forms.TextBox();
            this.TxtCompoe = new System.Windows.Forms.TextBox();
            this.TxtQuant = new System.Windows.Forms.TextBox();
            this.TxtHora = new System.Windows.Forms.TextBox();
            this.TxtPAdicional = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.mesaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.testDataSet1 = new SGR.testDataSet1();
            this.mesaTableAdapter = new SGR.testDataSet1TableAdapters.MesaTableAdapter();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbNomeEmpreg = new System.Windows.Forms.ComboBox();
            this.TxtData = new System.Windows.Forms.TextBox();
            this.cbMesa = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            ((System.ComponentModel.ISupportInitialize)(this.DGVPedidos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mesaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDataSet1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(92, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(205, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Carne / Peixe / Marisco";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Silver;
            this.button1.Location = new System.Drawing.Point(723, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(38, 34);
            this.button1.TabIndex = 3;
            this.button1.Text = "<<";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TxtProcura
            // 
            this.TxtProcura.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.TxtProcura.Location = new System.Drawing.Point(303, 22);
            this.TxtProcura.Name = "TxtProcura";
            this.TxtProcura.Size = new System.Drawing.Size(414, 32);
            this.TxtProcura.TabIndex = 4;
            // 
            // DGVPedidos
            // 
            this.DGVPedidos.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DGVPedidos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DGVPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVPedidos.DefaultCellStyle = dataGridViewCellStyle2;
            this.DGVPedidos.Location = new System.Drawing.Point(96, 65);
            this.DGVPedidos.Name = "DGVPedidos";
            this.DGVPedidos.Size = new System.Drawing.Size(756, 189);
            this.DGVPedidos.TabIndex = 5;
            this.DGVPedidos.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            // 
            // TxtPrato
            // 
            this.TxtPrato.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPrato.Location = new System.Drawing.Point(97, 24);
            this.TxtPrato.Name = "TxtPrato";
            this.TxtPrato.Size = new System.Drawing.Size(175, 35);
            this.TxtPrato.TabIndex = 6;
            this.TxtPrato.Text = "Prato tipo";
            // 
            // TxtPNome
            // 
            this.TxtPNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPNome.Location = new System.Drawing.Point(96, 71);
            this.TxtPNome.Name = "TxtPNome";
            this.TxtPNome.Size = new System.Drawing.Size(176, 35);
            this.TxtPNome.TabIndex = 7;
            this.TxtPNome.Text = "Nome do Prato";
            // 
            // TxtCompoe
            // 
            this.TxtCompoe.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCompoe.Location = new System.Drawing.Point(96, 112);
            this.TxtCompoe.Multiline = true;
            this.TxtCompoe.Name = "TxtCompoe";
            this.TxtCompoe.Size = new System.Drawing.Size(176, 51);
            this.TxtCompoe.TabIndex = 8;
            this.TxtCompoe.Text = "Descrição";
            // 
            // TxtQuant
            // 
            this.TxtQuant.BackColor = System.Drawing.SystemColors.Info;
            this.TxtQuant.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtQuant.Location = new System.Drawing.Point(338, 71);
            this.TxtQuant.Name = "TxtQuant";
            this.TxtQuant.Size = new System.Drawing.Size(100, 35);
            this.TxtQuant.TabIndex = 11;
            this.TxtQuant.Text = "Quant";
            // 
            // TxtHora
            // 
            this.TxtHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtHora.Location = new System.Drawing.Point(720, 71);
            this.TxtHora.Name = "TxtHora";
            this.TxtHora.Size = new System.Drawing.Size(101, 35);
            this.TxtHora.TabIndex = 13;
            this.TxtHora.Text = "Hora";
            // 
            // TxtPAdicional
            // 
            this.TxtPAdicional.BackColor = System.Drawing.SystemColors.Info;
            this.TxtPAdicional.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPAdicional.Location = new System.Drawing.Point(329, 112);
            this.TxtPAdicional.Multiline = true;
            this.TxtPAdicional.Name = "TxtPAdicional";
            this.TxtPAdicional.Size = new System.Drawing.Size(514, 51);
            this.TxtPAdicional.TabIndex = 18;
            this.TxtPAdicional.Text = "Pedido Extra Menu";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.DarkRed;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button2.Location = new System.Drawing.Point(96, 6);
            this.button2.Name = "button2";
            this.button2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button2.Size = new System.Drawing.Size(197, 103);
            this.button2.TabIndex = 19;
            this.button2.Text = "Fazer Pedido";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.DarkRed;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.button3.Location = new System.Drawing.Point(303, 7);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(191, 103);
            this.button3.TabIndex = 20;
            this.button3.Text = "Cancelar ";
            this.button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // mesaBindingSource
            // 
            this.mesaBindingSource.DataMember = "Mesa";
            this.mesaBindingSource.DataSource = this.testDataSet1;
            // 
            // testDataSet1
            // 
            this.testDataSet1.DataSetName = "testDataSet1";
            this.testDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mesaTableAdapter
            // 
            this.mesaTableAdapter.ClearBeforeFill = true;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.BalloonTipText = "O seu pedido foi enviado para a cozinha";
            this.notifyIcon1.BalloonTipTitle = "Pedido Enviado";
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Repolho do Mar";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGray;
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.DGVPedidos);
            this.panel1.Controls.Add(this.TxtProcura);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(12, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(974, 265);
            this.panel1.TabIndex = 22;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Silver;
            this.button5.Location = new System.Drawing.Point(766, 20);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(38, 34);
            this.button5.TabIndex = 6;
            this.button5.Text = "%";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkGray;
            this.panel2.Controls.Add(this.cbNomeEmpreg);
            this.panel2.Controls.Add(this.TxtData);
            this.panel2.Controls.Add(this.cbMesa);
            this.panel2.Controls.Add(this.TxtPrato);
            this.panel2.Controls.Add(this.TxtPNome);
            this.panel2.Controls.Add(this.TxtCompoe);
            this.panel2.Controls.Add(this.TxtQuant);
            this.panel2.Controls.Add(this.TxtHora);
            this.panel2.Controls.Add(this.TxtPAdicional);
            this.panel2.Location = new System.Drawing.Point(12, 289);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(974, 190);
            this.panel2.TabIndex = 23;
            // 
            // cbNomeEmpreg
            // 
            this.cbNomeEmpreg.BackColor = System.Drawing.SystemColors.Info;
            this.cbNomeEmpreg.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.mesaBindingSource, "mesa", true));
            this.cbNomeEmpreg.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNomeEmpreg.FormattingEnabled = true;
            this.cbNomeEmpreg.ItemHeight = 29;
            this.cbNomeEmpreg.Location = new System.Drawing.Point(490, 22);
            this.cbNomeEmpreg.Name = "cbNomeEmpreg";
            this.cbNomeEmpreg.Size = new System.Drawing.Size(175, 37);
            this.cbNomeEmpreg.TabIndex = 21;
            // 
            // TxtData
            // 
            this.TxtData.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtData.Location = new System.Drawing.Point(490, 71);
            this.TxtData.Name = "TxtData";
            this.TxtData.Size = new System.Drawing.Size(175, 35);
            this.TxtData.TabIndex = 20;
            this.TxtData.Text = "Data";
            // 
            // cbMesa
            // 
            this.cbMesa.BackColor = System.Drawing.SystemColors.Info;
            this.cbMesa.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.mesaBindingSource, "mesa", true));
            this.cbMesa.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMesa.FormattingEnabled = true;
            this.cbMesa.ItemHeight = 29;
            this.cbMesa.Location = new System.Drawing.Point(338, 24);
            this.cbMesa.Name = "cbMesa";
            this.cbMesa.Size = new System.Drawing.Size(100, 37);
            this.cbMesa.TabIndex = 19;
            this.cbMesa.SelectedIndexChanged += new System.EventHandler(this.cbMesa_SelectedIndexChanged);
            this.cbMesa.Click += new System.EventHandler(this.comboBox1_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkGray;
            this.panel3.Controls.Add(this.button4);
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.button3);
            this.panel3.Location = new System.Drawing.Point(12, 480);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(974, 118);
            this.panel3.TabIndex = 24;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.White;
            this.button4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button4.BackgroundImage")));
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.Maroon;
            this.button4.Location = new System.Drawing.Point(525, 7);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(177, 103);
            this.button4.TabIndex = 21;
            this.button4.Text = "Sair";
            this.button4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // colorDialog1
            // 
            this.colorDialog1.Color = System.Drawing.Color.Red;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1017, 628);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Registar Pedido";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVPedidos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mesaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDataSet1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox TxtProcura;
        private System.Windows.Forms.DataGridView DGVPedidos;
        private System.Windows.Forms.TextBox TxtPrato;
        private System.Windows.Forms.TextBox TxtPNome;
        private System.Windows.Forms.TextBox TxtCompoe;
        private System.Windows.Forms.TextBox TxtPAdicional;
        private System.Windows.Forms.TextBox TxtHora;
        private System.Windows.Forms.TextBox TxtQuant;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private testDataSet1 testDataSet1;
        private System.Windows.Forms.BindingSource mesaBindingSource;
        private testDataSet1TableAdapters.MesaTableAdapter mesaTableAdapter;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ComboBox cbMesa;
        private System.Windows.Forms.TextBox TxtData;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ComboBox cbNomeEmpreg;
       


    }
}

