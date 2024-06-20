namespace Jogo_Sortear
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.imgPokemon3 = new System.Windows.Forms.PictureBox();
            this.imgPokemon2 = new System.Windows.Forms.PictureBox();
            this.imgPokemon1 = new System.Windows.Forms.PictureBox();
            this.btnSortear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imgPokemon3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPokemon2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPokemon1)).BeginInit();
            this.SuspendLayout();
            // 
            // imgPokemon3
            // 
            this.imgPokemon3.Image = global::Jogo_Sortear.Properties.Resources.froakie;
            this.imgPokemon3.Location = new System.Drawing.Point(570, 12);
            this.imgPokemon3.Name = "imgPokemon3";
            this.imgPokemon3.Size = new System.Drawing.Size(244, 235);
            this.imgPokemon3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgPokemon3.TabIndex = 2;
            this.imgPokemon3.TabStop = false;
            // 
            // imgPokemon2
            // 
            this.imgPokemon2.Image = global::Jogo_Sortear.Properties.Resources.charmander;
            this.imgPokemon2.Location = new System.Drawing.Point(289, 12);
            this.imgPokemon2.Name = "imgPokemon2";
            this.imgPokemon2.Size = new System.Drawing.Size(244, 235);
            this.imgPokemon2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgPokemon2.TabIndex = 1;
            this.imgPokemon2.TabStop = false;
            // 
            // imgPokemon1
            // 
            this.imgPokemon1.Image = global::Jogo_Sortear.Properties.Resources.snivy;
            this.imgPokemon1.Location = new System.Drawing.Point(12, 12);
            this.imgPokemon1.Name = "imgPokemon1";
            this.imgPokemon1.Size = new System.Drawing.Size(244, 235);
            this.imgPokemon1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgPokemon1.TabIndex = 0;
            this.imgPokemon1.TabStop = false;
            // 
            // btnSortear
            // 
            this.btnSortear.BackColor = System.Drawing.Color.White;
            this.btnSortear.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSortear.Location = new System.Drawing.Point(336, 310);
            this.btnSortear.Name = "btnSortear";
            this.btnSortear.Size = new System.Drawing.Size(93, 43);
            this.btnSortear.TabIndex = 3;
            this.btnSortear.Text = "Sortear";
            this.btnSortear.UseVisualStyleBackColor = false;
            this.btnSortear.Click += new System.EventHandler(this.btnSortear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 395);
            this.Controls.Add(this.btnSortear);
            this.Controls.Add(this.imgPokemon3);
            this.Controls.Add(this.imgPokemon2);
            this.Controls.Add(this.imgPokemon1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.imgPokemon3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPokemon2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPokemon1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox imgPokemon1;
        private System.Windows.Forms.PictureBox imgPokemon2;
        private System.Windows.Forms.PictureBox imgPokemon3;
        private System.Windows.Forms.Button btnSortear;
    }
}

