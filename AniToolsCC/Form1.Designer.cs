
namespace AniToolsCC
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnCarpeta = new System.Windows.Forms.Button();
            this.txtCarpeta = new System.Windows.Forms.TextBox();
            this.lbArchivos = new System.Windows.Forms.ListBox();
            this.btnTaN = new System.Windows.Forms.Button();
            this.lbResultado = new System.Windows.Forms.Label();
            this.btnToNumV2 = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.lbAutor = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCarpeta
            // 
            this.btnCarpeta.BackColor = System.Drawing.Color.OliveDrab;
            this.btnCarpeta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCarpeta.Location = new System.Drawing.Point(12, 33);
            this.btnCarpeta.Name = "btnCarpeta";
            this.btnCarpeta.Size = new System.Drawing.Size(75, 22);
            this.btnCarpeta.TabIndex = 0;
            this.btnCarpeta.Text = "Seleccionar carpeta";
            this.btnCarpeta.UseVisualStyleBackColor = false;
            this.btnCarpeta.Click += new System.EventHandler(this.btnCarpeta_Click);
            // 
            // txtCarpeta
            // 
            this.txtCarpeta.Location = new System.Drawing.Point(86, 34);
            this.txtCarpeta.Name = "txtCarpeta";
            this.txtCarpeta.ReadOnly = true;
            this.txtCarpeta.Size = new System.Drawing.Size(445, 20);
            this.txtCarpeta.TabIndex = 1;
            // 
            // lbArchivos
            // 
            this.lbArchivos.FormattingEnabled = true;
            this.lbArchivos.Location = new System.Drawing.Point(12, 63);
            this.lbArchivos.Name = "lbArchivos";
            this.lbArchivos.Size = new System.Drawing.Size(519, 108);
            this.lbArchivos.TabIndex = 2;
            // 
            // btnTaN
            // 
            this.btnTaN.BackColor = System.Drawing.Color.Silver;
            this.btnTaN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTaN.Location = new System.Drawing.Point(6, 18);
            this.btnTaN.Name = "btnTaN";
            this.btnTaN.Size = new System.Drawing.Size(83, 23);
            this.btnTaN.TabIndex = 3;
            this.btnTaN.Text = "Metodo 1";
            this.btnTaN.UseVisualStyleBackColor = false;
            this.btnTaN.Click += new System.EventHandler(this.btnTaN_Click);
            // 
            // lbResultado
            // 
            this.lbResultado.AutoSize = true;
            this.lbResultado.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbResultado.ForeColor = System.Drawing.Color.SeaGreen;
            this.lbResultado.Location = new System.Drawing.Point(82, 7);
            this.lbResultado.Name = "lbResultado";
            this.lbResultado.Size = new System.Drawing.Size(0, 24);
            this.lbResultado.TabIndex = 4;
            // 
            // btnToNumV2
            // 
            this.btnToNumV2.BackColor = System.Drawing.Color.Silver;
            this.btnToNumV2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToNumV2.Location = new System.Drawing.Point(88, 18);
            this.btnToNumV2.Name = "btnToNumV2";
            this.btnToNumV2.Size = new System.Drawing.Size(83, 23);
            this.btnToNumV2.TabIndex = 6;
            this.btnToNumV2.Text = "Metodo 2";
            this.btnToNumV2.UseVisualStyleBackColor = false;
            this.btnToNumV2.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(442, 172);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(89, 23);
            this.btnLimpiar.TabIndex = 7;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // lbAutor
            // 
            this.lbAutor.AutoSize = true;
            this.lbAutor.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAutor.Location = new System.Drawing.Point(500, 198);
            this.lbAutor.Name = "lbAutor";
            this.lbAutor.Size = new System.Drawing.Size(33, 14);
            this.lbAutor.TabIndex = 8;
            this.lbAutor.Text = "- cccs";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnTaN);
            this.groupBox1.Controls.Add(this.btnToNumV2);
            this.groupBox1.Location = new System.Drawing.Point(30, 171);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(180, 46);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Enumerar";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(534, 220);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbAutor);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.lbResultado);
            this.Controls.Add(this.lbArchivos);
            this.Controls.Add(this.txtCarpeta);
            this.Controls.Add(this.btnCarpeta);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "AniToolsCC V 0.0.0.3";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCarpeta;
        private System.Windows.Forms.TextBox txtCarpeta;
        private System.Windows.Forms.ListBox lbArchivos;
        private System.Windows.Forms.Button btnTaN;
        private System.Windows.Forms.Label lbResultado;
        private System.Windows.Forms.Button btnToNumV2;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Label lbAutor;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

