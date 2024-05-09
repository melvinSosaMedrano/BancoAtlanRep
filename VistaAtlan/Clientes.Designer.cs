
using System.Windows.Forms;

namespace VistaAtlan
{
    partial class Clientes
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.TIPOFILTRO = new System.Windows.Forms.ComboBox();
            this.FILTRO = new System.Windows.Forms.TextBox();
            this.BUSCAR = new System.Windows.Forms.Button();
            this.ClientesGrid = new System.Windows.Forms.DataGridView();
            this.TarjetasGrid = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tBLCLIENTEBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tBLCLIENTEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ClientesGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TarjetasGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLCLIENTEBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLCLIENTEBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // TIPOFILTRO
            // 
            this.TIPOFILTRO.FormattingEnabled = true;
            this.TIPOFILTRO.Items.AddRange(new object[] {
            "TODOS",
            "CODIGO DE CLIENTE"});
            this.TIPOFILTRO.Location = new System.Drawing.Point(12, 39);
            this.TIPOFILTRO.Name = "TIPOFILTRO";
            this.TIPOFILTRO.Size = new System.Drawing.Size(288, 21);
            this.TIPOFILTRO.TabIndex = 0;
            // 
            // FILTRO
            // 
            this.FILTRO.Location = new System.Drawing.Point(306, 39);
            this.FILTRO.Name = "FILTRO";
            this.FILTRO.Size = new System.Drawing.Size(250, 20);
            this.FILTRO.TabIndex = 1;
            // 
            // BUSCAR
            // 
            this.BUSCAR.BackColor = System.Drawing.SystemColors.Desktop;
            this.BUSCAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BUSCAR.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BUSCAR.Location = new System.Drawing.Point(563, 29);
            this.BUSCAR.Margin = new System.Windows.Forms.Padding(0);
            this.BUSCAR.Name = "BUSCAR";
            this.BUSCAR.Size = new System.Drawing.Size(133, 38);
            this.BUSCAR.TabIndex = 2;
            this.BUSCAR.Text = "BUSCAR";
            this.BUSCAR.UseVisualStyleBackColor = false;
            this.BUSCAR.Click += new System.EventHandler(this.BUSCAR_Click);
            // 
            // ClientesGrid
            // 
            this.ClientesGrid.AllowUserToAddRows = false;
            this.ClientesGrid.AllowUserToDeleteRows = false;
            this.ClientesGrid.BackgroundColor = System.Drawing.Color.MintCream;
            this.ClientesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ClientesGrid.Location = new System.Drawing.Point(12, 128);
            this.ClientesGrid.Name = "ClientesGrid";
            this.ClientesGrid.ReadOnly = true;
            this.ClientesGrid.Size = new System.Drawing.Size(684, 352);
            this.ClientesGrid.TabIndex = 3;
            this.ClientesGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ClientesGrid_CellDoubleClick);
            // 
            // TarjetasGrid
            // 
            this.TarjetasGrid.AllowUserToAddRows = false;
            this.TarjetasGrid.AllowUserToDeleteRows = false;
            this.TarjetasGrid.BackgroundColor = System.Drawing.Color.MintCream;
            this.TarjetasGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TarjetasGrid.Location = new System.Drawing.Point(702, 128);
            this.TarjetasGrid.Name = "TarjetasGrid";
            this.TarjetasGrid.ReadOnly = true;
            this.TarjetasGrid.Size = new System.Drawing.Size(612, 352);
            this.TarjetasGrid.TabIndex = 4;
            this.TarjetasGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TarjetasGrid_CellDoubleClick);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(13, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Clientes";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(697, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tarjetas Asociadas";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Desktop;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(928, 29);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 38);
            this.button1.TabIndex = 7;
            this.button1.Text = "Realizar Pago";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Desktop;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.Location = new System.Drawing.Point(1073, 29);
            this.button2.Margin = new System.Windows.Forms.Padding(0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(133, 38);
            this.button2.TabIndex = 8;
            this.button2.Text = "Realizar Compra";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tBLCLIENTEBindingSource1
            // 
            this.tBLCLIENTEBindingSource1.DataSource = typeof(AtlanProject.Models.TBL_CLIENTE);
            // 
            // tBLCLIENTEBindingSource
            // 
            this.tBLCLIENTEBindingSource.DataSource = typeof(AtlanProject.Models.TBL_CLIENTE);
            // 
            // Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(1374, 561);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TarjetasGrid);
            this.Controls.Add(this.ClientesGrid);
            this.Controls.Add(this.BUSCAR);
            this.Controls.Add(this.FILTRO);
            this.Controls.Add(this.TIPOFILTRO);
            this.Name = "Clientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clientes";
            ((System.ComponentModel.ISupportInitialize)(this.ClientesGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TarjetasGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLCLIENTEBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLCLIENTEBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox TIPOFILTRO;
        private System.Windows.Forms.TextBox FILTRO;
        private System.Windows.Forms.Button BUSCAR;
        private System.Windows.Forms.BindingSource tBLCLIENTEBindingSource1;
        private System.Windows.Forms.BindingSource tBLCLIENTEBindingSource;
        private System.Windows.Forms.DataGridView ClientesGrid;
        private System.Windows.Forms.DataGridView TarjetasGrid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Button button1;
        private Button button2;
    }
}

