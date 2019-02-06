namespace SGR
{
    partial class Fmt_PedMesa_Detail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fmt_PedMesa_Detail));
            this.label1 = new System.Windows.Forms.Label();
            this.LblID = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LblEmp = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LblMesa = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LblC = new System.Windows.Forms.Label();
            this.LblM = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.dsSt1 = new SGR.dsSt1();
            this.pedidoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pedidoTableAdapter = new SGR.dsSt1TableAdapters.PedidoTableAdapter();
            this.label5 = new System.Windows.Forms.Label();
            this.LblPrato = new System.Windows.Forms.Label();
            this.LblQuant = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dsSt1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pedidoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pedido";
            // 
            // LblID
            // 
            this.LblID.AutoSize = true;
            this.LblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblID.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.LblID.Location = new System.Drawing.Point(109, 9);
            this.LblID.Name = "LblID";
            this.LblID.Size = new System.Drawing.Size(26, 29);
            this.LblID.TabIndex = 1;
            this.LblID.Text = "#";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Empregado";
            // 
            // LblEmp
            // 
            this.LblEmp.AutoSize = true;
            this.LblEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEmp.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.LblEmp.Location = new System.Drawing.Point(165, 47);
            this.LblEmp.Name = "LblEmp";
            this.LblEmp.Size = new System.Drawing.Size(31, 29);
            this.LblEmp.TabIndex = 3;
            this.LblEmp.Text = "N";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(202, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mesa";
            // 
            // LblMesa
            // 
            this.LblMesa.AutoSize = true;
            this.LblMesa.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMesa.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.LblMesa.Location = new System.Drawing.Point(323, 9);
            this.LblMesa.Name = "LblMesa";
            this.LblMesa.Size = new System.Drawing.Size(26, 29);
            this.LblMesa.TabIndex = 5;
            this.LblMesa.Text = "#";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 29);
            this.label4.TabIndex = 6;
            this.label4.Text = "Estado";
            // 
            // LblC
            // 
            this.LblC.AutoSize = true;
            this.LblC.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblC.ForeColor = System.Drawing.Color.Green;
            this.LblC.Location = new System.Drawing.Point(167, 137);
            this.LblC.Name = "LblC";
            this.LblC.Size = new System.Drawing.Size(72, 29);
            this.LblC.TabIndex = 7;
            this.LblC.Text = "Mesa";
            this.LblC.Visible = false;
            // 
            // LblM
            // 
            this.LblM.AutoSize = true;
            this.LblM.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblM.ForeColor = System.Drawing.Color.Red;
            this.LblM.Location = new System.Drawing.Point(165, 137);
            this.LblM.Name = "LblM";
            this.LblM.Size = new System.Drawing.Size(100, 29);
            this.LblM.TabIndex = 8;
            this.LblM.Text = "Cozinha";
            this.LblM.Visible = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.Gray;
            this.button6.Image = ((System.Drawing.Image)(resources.GetObject("button6.Image")));
            this.button6.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button6.Location = new System.Drawing.Point(226, 183);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(134, 129);
            this.button6.TabIndex = 16;
            this.button6.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // dsSt1
            // 
            this.dsSt1.DataSetName = "dsSt1";
            this.dsSt1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pedidoBindingSource
            // 
            this.pedidoBindingSource.DataMember = "Pedido";
            this.pedidoBindingSource.DataSource = this.dsSt1;
            // 
            // pedidoTableAdapter
            // 
            this.pedidoTableAdapter.ClearBeforeFill = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 93);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(70, 29);
            this.label5.TabIndex = 17;
            this.label5.Text = "Prato";
            // 
            // LblPrato
            // 
            this.LblPrato.AutoSize = true;
            this.LblPrato.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPrato.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.LblPrato.Location = new System.Drawing.Point(170, 93);
            this.LblPrato.Name = "LblPrato";
            this.LblPrato.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LblPrato.Size = new System.Drawing.Size(29, 29);
            this.LblPrato.TabIndex = 18;
            this.LblPrato.Text = "P";
            // 
            // LblQuant
            // 
            this.LblQuant.AutoSize = true;
            this.LblQuant.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblQuant.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.LblQuant.Location = new System.Drawing.Point(325, 93);
            this.LblQuant.Name = "LblQuant";
            this.LblQuant.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LblQuant.Size = new System.Drawing.Size(26, 29);
            this.LblQuant.TabIndex = 19;
            this.LblQuant.Text = "#";
            // 
            // Fmt_PedMesa_Detail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 324);
            this.Controls.Add(this.LblQuant);
            this.Controls.Add(this.LblPrato);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.LblM);
            this.Controls.Add(this.LblC);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.LblMesa);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LblEmp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LblID);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Fmt_PedMesa_Detail";
            this.Text = "Localização do Pedido";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Load += new System.EventHandler(this.Fmt_PedMesa_Detail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsSt1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pedidoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LblEmp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LblMesa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LblC;
        private System.Windows.Forms.Label LblM;
        private System.Windows.Forms.Button button6;
        private dsSt1 dsSt1;
        private System.Windows.Forms.BindingSource pedidoBindingSource;
        private dsSt1TableAdapters.PedidoTableAdapter pedidoTableAdapter;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label LblPrato;
        private System.Windows.Forms.Label LblQuant;
    }
}