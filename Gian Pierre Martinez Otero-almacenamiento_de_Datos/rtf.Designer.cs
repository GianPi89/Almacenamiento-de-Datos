namespace almacenamientoDeDatos
{
    partial class frmRtf
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
            this.imgAtras = new System.Windows.Forms.PictureBox();
            this.dgvPersonas = new System.Windows.Forms.DataGridView();
            this.lblTituloCSV = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblEliID = new System.Windows.Forms.Label();
            this.txtEliminar = new System.Windows.Forms.TextBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblEditID = new System.Windows.Forms.Label();
            this.txtNueID = new System.Windows.Forms.TextBox();
            this.lblEditNombre = new System.Windows.Forms.Label();
            this.txtNueNombre = new System.Windows.Forms.TextBox();
            this.btnEditar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblAgNombre = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtAgregar = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgAtras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonas)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // imgAtras
            // 
            this.imgAtras.Image = global::almacenamientoDeDatos.Properties.Resources.icons8_atrás_96;
            this.imgAtras.Location = new System.Drawing.Point(12, 12);
            this.imgAtras.Name = "imgAtras";
            this.imgAtras.Size = new System.Drawing.Size(46, 39);
            this.imgAtras.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgAtras.TabIndex = 15;
            this.imgAtras.TabStop = false;
            this.imgAtras.Click += new System.EventHandler(this.imgAtras_Click);
            // 
            // dgvPersonas
            // 
            this.dgvPersonas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPersonas.Location = new System.Drawing.Point(314, 87);
            this.dgvPersonas.Name = "dgvPersonas";
            this.dgvPersonas.Size = new System.Drawing.Size(344, 342);
            this.dgvPersonas.TabIndex = 32;
            // 
            // lblTituloCSV
            // 
            this.lblTituloCSV.AutoSize = true;
            this.lblTituloCSV.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblTituloCSV.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloCSV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblTituloCSV.Location = new System.Drawing.Point(180, 21);
            this.lblTituloCSV.Name = "lblTituloCSV";
            this.lblTituloCSV.Size = new System.Drawing.Size(292, 29);
            this.lblTituloCSV.TabIndex = 31;
            this.lblTituloCSV.Text = "CRUD con archivos RFT";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.RoyalBlue;
            this.groupBox3.Controls.Add(this.lblEliID);
            this.groupBox3.Controls.Add(this.txtEliminar);
            this.groupBox3.Controls.Add(this.btnEliminar);
            this.groupBox3.Font = new System.Drawing.Font("High Tower Text", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(32, 326);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(250, 84);
            this.groupBox3.TabIndex = 38;
            this.groupBox3.TabStop = false;
            // 
            // lblEliID
            // 
            this.lblEliID.AutoSize = true;
            this.lblEliID.Font = new System.Drawing.Font("High Tower Text", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEliID.Location = new System.Drawing.Point(6, 16);
            this.lblEliID.Name = "lblEliID";
            this.lblEliID.Size = new System.Drawing.Size(37, 22);
            this.lblEliID.TabIndex = 26;
            this.lblEliID.Text = "ID:";
            // 
            // txtEliminar
            // 
            this.txtEliminar.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEliminar.Location = new System.Drawing.Point(6, 41);
            this.txtEliminar.Name = "txtEliminar";
            this.txtEliminar.Size = new System.Drawing.Size(100, 22);
            this.txtEliminar.TabIndex = 22;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("High Tower Text", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(143, 35);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(86, 32);
            this.btnEliminar.TabIndex = 18;
            this.btnEliminar.Text = "Eliminar persona";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click_1);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.RoyalBlue;
            this.groupBox2.Controls.Add(this.lblEditID);
            this.groupBox2.Controls.Add(this.txtNueID);
            this.groupBox2.Controls.Add(this.lblEditNombre);
            this.groupBox2.Controls.Add(this.txtNueNombre);
            this.groupBox2.Controls.Add(this.btnEditar);
            this.groupBox2.Font = new System.Drawing.Font("High Tower Text", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(32, 172);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(250, 148);
            this.groupBox2.TabIndex = 37;
            this.groupBox2.TabStop = false;
            // 
            // lblEditID
            // 
            this.lblEditID.AutoSize = true;
            this.lblEditID.Font = new System.Drawing.Font("High Tower Text", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditID.Location = new System.Drawing.Point(6, 22);
            this.lblEditID.Name = "lblEditID";
            this.lblEditID.Size = new System.Drawing.Size(181, 22);
            this.lblEditID.TabIndex = 23;
            this.lblEditID.Text = " Digite ID  para editar:";
            // 
            // txtNueID
            // 
            this.txtNueID.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNueID.Location = new System.Drawing.Point(6, 47);
            this.txtNueID.Name = "txtNueID";
            this.txtNueID.Size = new System.Drawing.Size(100, 22);
            this.txtNueID.TabIndex = 24;
            // 
            // lblEditNombre
            // 
            this.lblEditNombre.AutoSize = true;
            this.lblEditNombre.Font = new System.Drawing.Font("High Tower Text", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditNombre.Location = new System.Drawing.Point(6, 85);
            this.lblEditNombre.Name = "lblEditNombre";
            this.lblEditNombre.Size = new System.Drawing.Size(125, 22);
            this.lblEditNombre.TabIndex = 25;
            this.lblEditNombre.Text = "Nombre Nuevo:";
            // 
            // txtNueNombre
            // 
            this.txtNueNombre.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNueNombre.Location = new System.Drawing.Point(6, 110);
            this.txtNueNombre.Name = "txtNueNombre";
            this.txtNueNombre.Size = new System.Drawing.Size(100, 22);
            this.txtNueNombre.TabIndex = 21;
            // 
            // btnEditar
            // 
            this.btnEditar.Font = new System.Drawing.Font("High Tower Text", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Location = new System.Drawing.Point(143, 65);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(86, 28);
            this.btnEditar.TabIndex = 17;
            this.btnEditar.Text = "Editar persona";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.RoyalBlue;
            this.groupBox1.Controls.Add(this.lblAgNombre);
            this.groupBox1.Controls.Add(this.btnAgregar);
            this.groupBox1.Controls.Add(this.txtAgregar);
            this.groupBox1.Font = new System.Drawing.Font("High Tower Text", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(32, 75);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(250, 91);
            this.groupBox1.TabIndex = 36;
            this.groupBox1.TabStop = false;
            // 
            // lblAgNombre
            // 
            this.lblAgNombre.AutoSize = true;
            this.lblAgNombre.Font = new System.Drawing.Font("High Tower Text", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgNombre.Location = new System.Drawing.Point(6, 19);
            this.lblAgNombre.Name = "lblAgNombre";
            this.lblAgNombre.Size = new System.Drawing.Size(151, 25);
            this.lblAgNombre.TabIndex = 27;
            this.lblAgNombre.Text = "Agregar Nombre:";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("High Tower Text", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(137, 43);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(86, 33);
            this.btnAgregar.TabIndex = 16;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click_1);
            // 
            // txtAgregar
            // 
            this.txtAgregar.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAgregar.Location = new System.Drawing.Point(10, 50);
            this.txtAgregar.Name = "txtAgregar";
            this.txtAgregar.Size = new System.Drawing.Size(100, 22);
            this.txtAgregar.TabIndex = 20;
            // 
            // frmRtf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(701, 450);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvPersonas);
            this.Controls.Add(this.lblTituloCSV);
            this.Controls.Add(this.imgAtras);
            this.Name = "frmRtf";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "rtf";
            this.Load += new System.EventHandler(this.frmRtf_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgAtras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonas)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox imgAtras;
        private System.Windows.Forms.DataGridView dgvPersonas;
        private System.Windows.Forms.Label lblTituloCSV;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblEliID;
        private System.Windows.Forms.TextBox txtEliminar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblEditID;
        private System.Windows.Forms.TextBox txtNueID;
        private System.Windows.Forms.Label lblEditNombre;
        private System.Windows.Forms.TextBox txtNueNombre;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblAgNombre;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtAgregar;
    }
}