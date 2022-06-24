using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArreglosDeEstructuraForms
{
    public partial class Form1 : Form
    {

        struct Peliculas
        {
            public string titulo;
            public string autor;
            public string editorial;
            public string añoEdicion;
            public string Categoria;
            
        }


         Peliculas[] peliculasL = new Peliculas[3];
         int n = 0;



        public Form1()
        {
            InitializeComponent();
            button1.Click += Button1_Click;
        }


        private void leerPeliculas(int i)
        {


            Peliculas form1 = new Peliculas();
            form1.titulo = txtTitulo.Text;
            form1.autor = txtAutor.Text;
            form1.editorial = txtEditorial.Text;
            form1.añoEdicion = txtAño.Text;
            form1.Categoria = txtCategoria.Text;
            
            peliculasL[i] = form1;

                dataGridView1.Rows.Add(
            peliculasL[i].titulo,
            peliculasL[i].autor,
            peliculasL[i].editorial,
            peliculasL[i].añoEdicion,
            peliculasL[i].Categoria
            );









        }


        private void Button1_Click(object sender, EventArgs e)
        {
            leerPeliculas(n);
            n += 1;

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
