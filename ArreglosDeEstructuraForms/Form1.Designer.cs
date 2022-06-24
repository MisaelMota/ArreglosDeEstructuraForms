
namespace ArreglosDeEstructuraForms
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
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.txtCategoria = new System.Windows.Forms.TextBox();
            this.txtAño = new System.Windows.Forms.TextBox();
            this.txtEditorial = new System.Windows.Forms.TextBox();
            this.txtAutor = new System.Windows.Forms.TextBox();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this._titulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._director = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._escritor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._genero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._Clasificacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 232);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 29;
            this.label5.Text = "Categoria";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "Año de edición";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "Editorial";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Autor";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Titulo";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this._titulo,
            this._director,
            this._escritor,
            this._genero,
            this._Clasificacion});
            this.dataGridView1.Location = new System.Drawing.Point(168, 26);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(543, 360);
            this.dataGridView1.TabIndex = 24;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(17, 416);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 40);
            this.button1.TabIndex = 23;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // txtCategoria
            // 
            this.txtCategoria.Location = new System.Drawing.Point(17, 248);
            this.txtCategoria.Multiline = true;
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.Size = new System.Drawing.Size(124, 29);
            this.txtCategoria.TabIndex = 20;
            // 
            // txtAño
            // 
            this.txtAño.Location = new System.Drawing.Point(17, 194);
            this.txtAño.Multiline = true;
            this.txtAño.Name = "txtAño";
            this.txtAño.Size = new System.Drawing.Size(124, 29);
            this.txtAño.TabIndex = 19;
            // 
            // txtEditorial
            // 
            this.txtEditorial.Location = new System.Drawing.Point(17, 138);
            this.txtEditorial.Multiline = true;
            this.txtEditorial.Name = "txtEditorial";
            this.txtEditorial.Size = new System.Drawing.Size(124, 29);
            this.txtEditorial.TabIndex = 18;
            // 
            // txtAutor
            // 
            this.txtAutor.Location = new System.Drawing.Point(17, 76);
            this.txtAutor.Multiline = true;
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.Size = new System.Drawing.Size(124, 29);
            this.txtAutor.TabIndex = 17;
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(17, 26);
            this.txtTitulo.Multiline = true;
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(124, 29);
            this.txtTitulo.TabIndex = 16;
            // 
            // _titulo
            // 
            this._titulo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this._titulo.DataPropertyName = "titulo";
            this._titulo.HeaderText = "Titulo";
            this._titulo.Name = "_titulo";
            // 
            // _director
            // 
            this._director.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this._director.DataPropertyName = "director";
            this._director.HeaderText = "Autor";
            this._director.Name = "_director";
            // 
            // _escritor
            // 
            this._escritor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this._escritor.DataPropertyName = "escritor";
            this._escritor.HeaderText = "Editorial";
            this._escritor.Name = "_escritor";
            // 
            // _genero
            // 
            this._genero.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this._genero.DataPropertyName = "genero";
            this._genero.HeaderText = "Año de edición";
            this._genero.Name = "_genero";
            // 
            // _Clasificacion
            // 
            this._Clasificacion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this._Clasificacion.DataPropertyName = "clasificacion";
            this._Clasificacion.HeaderText = "Categoria";
            this._Clasificacion.Name = "_Clasificacion";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 481);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtCategoria);
            this.Controls.Add(this.txtAño);
            this.Controls.Add(this.txtEditorial);
            this.Controls.Add(this.txtAutor);
            this.Controls.Add(this.txtTitulo);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtCategoria;
        private System.Windows.Forms.TextBox txtAño;
        private System.Windows.Forms.TextBox txtEditorial;
        private System.Windows.Forms.TextBox txtAutor;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn _titulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn _director;
        private System.Windows.Forms.DataGridViewTextBoxColumn _escritor;
        private System.Windows.Forms.DataGridViewTextBoxColumn _genero;
        private System.Windows.Forms.DataGridViewTextBoxColumn _Clasificacion;
    }
}

