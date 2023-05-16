namespace almacenamientoDeDatos
{
    partial class frmPrincipal
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
            this.lblDat = new System.Windows.Forms.Label();
            this.btnTxt = new System.Windows.Forms.Button();
            this.btnCsv = new System.Windows.Forms.Button();
            this.btnRtf = new System.Windows.Forms.Button();
            this.btnXml = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDat
            // 
            this.lblDat.AutoSize = true;
            this.lblDat.Font = new System.Drawing.Font("High Tower Text", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDat.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDat.Location = new System.Drawing.Point(36, 28);
            this.lblDat.Name = "lblDat";
            this.lblDat.Size = new System.Drawing.Size(272, 31);
            this.lblDat.TabIndex = 0;
            this.lblDat.Text = "Almacenamiento de datos";
            // 
            // btnTxt
            // 
            this.btnTxt.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnTxt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTxt.Font = new System.Drawing.Font("High Tower Text", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTxt.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnTxt.Location = new System.Drawing.Point(53, 72);
            this.btnTxt.Name = "btnTxt";
            this.btnTxt.Size = new System.Drawing.Size(75, 32);
            this.btnTxt.TabIndex = 1;
            this.btnTxt.Text = "TXT";
            this.btnTxt.UseVisualStyleBackColor = false;
            this.btnTxt.Click += new System.EventHandler(this.btnTxt_Click);
            // 
            // btnCsv
            // 
            this.btnCsv.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnCsv.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCsv.Font = new System.Drawing.Font("High Tower Text", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCsv.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCsv.Location = new System.Drawing.Point(194, 72);
            this.btnCsv.Name = "btnCsv";
            this.btnCsv.Size = new System.Drawing.Size(75, 32);
            this.btnCsv.TabIndex = 2;
            this.btnCsv.Text = "CSV";
            this.btnCsv.UseVisualStyleBackColor = false;
            this.btnCsv.Click += new System.EventHandler(this.btnCsv_Click);
            // 
            // btnRtf
            // 
            this.btnRtf.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnRtf.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRtf.Font = new System.Drawing.Font("High Tower Text", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRtf.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnRtf.Location = new System.Drawing.Point(194, 121);
            this.btnRtf.Name = "btnRtf";
            this.btnRtf.Size = new System.Drawing.Size(75, 33);
            this.btnRtf.TabIndex = 3;
            this.btnRtf.Text = "RTF";
            this.btnRtf.UseVisualStyleBackColor = false;
            this.btnRtf.Click += new System.EventHandler(this.btnRtf_Click);
            // 
            // btnXml
            // 
            this.btnXml.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnXml.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnXml.Font = new System.Drawing.Font("High Tower Text", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXml.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnXml.Location = new System.Drawing.Point(53, 121);
            this.btnXml.Name = "btnXml";
            this.btnXml.Size = new System.Drawing.Size(75, 33);
            this.btnXml.TabIndex = 4;
            this.btnXml.Text = "XML";
            this.btnXml.UseVisualStyleBackColor = false;
            this.btnXml.Click += new System.EventHandler(this.btnXml_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(342, 206);
            this.Controls.Add(this.btnXml);
            this.Controls.Add(this.btnRtf);
            this.Controls.Add(this.btnCsv);
            this.Controls.Add(this.btnTxt);
            this.Controls.Add(this.lblDat);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDat;
        private System.Windows.Forms.Button btnTxt;
        private System.Windows.Forms.Button btnCsv;
        private System.Windows.Forms.Button btnRtf;
        private System.Windows.Forms.Button btnXml;
    }
}

