﻿namespace clase1_programacion.ner
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtnumero1 = new System.Windows.Forms.TextBox();
            this.txtnumero2 = new System.Windows.Forms.TextBox();
            this.btnsumar = new System.Windows.Forms.Button();
            this.lblresultado = new System.Windows.Forms.Label();
            this.btnrestar = new System.Windows.Forms.Button();
            this.btnmultiplicar = new System.Windows.Forms.Button();
            this.btndividir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(238, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Super Calculadora";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(49, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(250, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ingresa el primer Número:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(49, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(271, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ingresa el segundo Número:";
            // 
            // txtnumero1
            // 
            this.txtnumero1.Location = new System.Drawing.Point(340, 131);
            this.txtnumero1.Name = "txtnumero1";
            this.txtnumero1.Size = new System.Drawing.Size(100, 20);
            this.txtnumero1.TabIndex = 3;
            // 
            // txtnumero2
            // 
            this.txtnumero2.Location = new System.Drawing.Point(340, 196);
            this.txtnumero2.Name = "txtnumero2";
            this.txtnumero2.Size = new System.Drawing.Size(100, 20);
            this.txtnumero2.TabIndex = 4;
            // 
            // btnsumar
            // 
            this.btnsumar.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsumar.Location = new System.Drawing.Point(558, 122);
            this.btnsumar.Name = "btnsumar";
            this.btnsumar.Size = new System.Drawing.Size(96, 29);
            this.btnsumar.TabIndex = 5;
            this.btnsumar.Text = "Sumar";
            this.btnsumar.UseVisualStyleBackColor = true;
            this.btnsumar.Click += new System.EventHandler(this.btnsumar_Click);
            // 
            // lblresultado
            // 
            this.lblresultado.AutoSize = true;
            this.lblresultado.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblresultado.Location = new System.Drawing.Point(49, 295);
            this.lblresultado.Name = "lblresultado";
            this.lblresultado.Size = new System.Drawing.Size(110, 24);
            this.lblresultado.TabIndex = 6;
            this.lblresultado.Text = "Resultado:";
            this.lblresultado.Visible = false;
            // 
            // btnrestar
            // 
            this.btnrestar.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrestar.Location = new System.Drawing.Point(558, 187);
            this.btnrestar.Name = "btnrestar";
            this.btnrestar.Size = new System.Drawing.Size(96, 29);
            this.btnrestar.TabIndex = 7;
            this.btnrestar.Text = "Restar";
            this.btnrestar.UseVisualStyleBackColor = true;
            this.btnrestar.Click += new System.EventHandler(this.btnrestar_Click);
            // 
            // btnmultiplicar
            // 
            this.btnmultiplicar.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmultiplicar.Location = new System.Drawing.Point(551, 259);
            this.btnmultiplicar.Name = "btnmultiplicar";
            this.btnmultiplicar.Size = new System.Drawing.Size(103, 29);
            this.btnmultiplicar.TabIndex = 8;
            this.btnmultiplicar.Text = "Multiplicar";
            this.btnmultiplicar.UseVisualStyleBackColor = true;
            this.btnmultiplicar.Click += new System.EventHandler(this.btnmultiplicar_Click);
            // 
            // btndividir
            // 
            this.btndividir.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndividir.Location = new System.Drawing.Point(558, 315);
            this.btndividir.Name = "btndividir";
            this.btndividir.Size = new System.Drawing.Size(96, 29);
            this.btndividir.TabIndex = 9;
            this.btndividir.Text = "Dividir";
            this.btndividir.UseVisualStyleBackColor = true;
            this.btndividir.Click += new System.EventHandler(this.btndividir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btndividir);
            this.Controls.Add(this.btnmultiplicar);
            this.Controls.Add(this.btnrestar);
            this.Controls.Add(this.lblresultado);
            this.Controls.Add(this.btnsumar);
            this.Controls.Add(this.txtnumero2);
            this.Controls.Add(this.txtnumero1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtnumero1;
        private System.Windows.Forms.TextBox txtnumero2;
        private System.Windows.Forms.Button btnsumar;
        private System.Windows.Forms.Label lblresultado;
        private System.Windows.Forms.Button btnrestar;
        private System.Windows.Forms.Button btnmultiplicar;
        private System.Windows.Forms.Button btndividir;
    }
}

