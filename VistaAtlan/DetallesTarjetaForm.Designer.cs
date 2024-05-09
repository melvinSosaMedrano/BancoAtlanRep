
namespace VistaAtlan
{
    partial class DetallesTarjetaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DetallesTarjetaForm));
            this.label3 = new System.Windows.Forms.Label();
            this.DetalleTarjetaGrid = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.TransacGrid = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.totalanterior = new System.Windows.Forms.Label();
            this.totalactual = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.totalapagar = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DetalleTarjetaGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TransacGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // DetalleTarjetaGrid
            // 
            this.DetalleTarjetaGrid.AllowUserToAddRows = false;
            this.DetalleTarjetaGrid.AllowUserToDeleteRows = false;
            this.DetalleTarjetaGrid.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DetalleTarjetaGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.DetalleTarjetaGrid, "DetalleTarjetaGrid");
            this.DetalleTarjetaGrid.Name = "DetalleTarjetaGrid";
            this.DetalleTarjetaGrid.ReadOnly = true;
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Name = "label1";
            // 
            // TransacGrid
            // 
            this.TransacGrid.AllowUserToAddRows = false;
            this.TransacGrid.AllowUserToDeleteRows = false;
            this.TransacGrid.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TransacGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.TransacGrid, "TransacGrid");
            this.TransacGrid.Name = "TransacGrid";
            this.TransacGrid.ReadOnly = true;
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Name = "label2";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Name = "label4";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Name = "label5";
            // 
            // totalanterior
            // 
            resources.ApplyResources(this.totalanterior, "totalanterior");
            this.totalanterior.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.totalanterior.Name = "totalanterior";
            // 
            // totalactual
            // 
            resources.ApplyResources(this.totalactual, "totalactual");
            this.totalactual.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.totalactual.Name = "totalactual";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Name = "label6";
            // 
            // totalapagar
            // 
            resources.ApplyResources(this.totalapagar, "totalapagar");
            this.totalapagar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.totalapagar.Name = "totalapagar";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Green;
            resources.ApplyResources(this.button2, "button2");
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.Name = "button2";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // DetallesTarjetaForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.totalapagar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.totalactual);
            this.Controls.Add(this.totalanterior);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TransacGrid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DetalleTarjetaGrid);
            this.Controls.Add(this.label3);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "DetallesTarjetaForm";
            this.Load += new System.EventHandler(this.DetallesTarjetaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DetalleTarjetaGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TransacGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView DetalleTarjetaGrid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView TransacGrid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label totalanterior;
        private System.Windows.Forms.Label totalactual;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label totalapagar;
        private System.Windows.Forms.Button button2;
    }
}