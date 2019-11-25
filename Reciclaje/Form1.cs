using Reciclaje.ParteProlog;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reciclaje
{
    public partial class Form1 : Form
    {
        List<Residuo> listaResiduo = new List<Residuo>();
        List<Material> listaMaterial = new List<Material>();
        Residuo residuo;
        Material material;
        int posicion = 0, posicion2 = 0;
        string nombrePrologResiduo = "";
        string nombrePrologMaterial = "";
        string bote;
        string organico = "";

        public Form1()
        {
            InitializeComponent();
            PrologEngine.Start("reciclar.pl");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LlenarListaResiduo();
            LlenarListaMaterial();

            imagenResiduo.Image = Image.FromFile("caja.png");
            nombreResiduo.Text = "Caja";
            nombrePrologResiduo = "caja";

            imagenMaterial.Image = Image.FromFile("carton.png");
            nombreMaterial.Text = "Carton";
            nombrePrologMaterial = "carton";

            //imagenBote.Image = Image.FromFile("reciclaje.png");

            //imagenOrganica.Image = Image.FromFile("reciclaje.png");
        }

        public void LlenarListaResiduo()//Lista de los Residuos
        {
            int i = 0;
            //          1:Nombre de la imagen  2:Texto del Residuo  3:Nombre usado en el archivo pl de Prolog
            residuo = new Residuo("caja.png", "Caja", "caja", i);
            listaResiduo.Add(residuo);
            i++;

            residuo = new Residuo("vaso.png", "Vaso", "vaso", i);
            listaResiduo.Add(residuo);
            i++;

            residuo = new Residuo("botella.png", " Botella", "botella", i);
            listaResiduo.Add(residuo);
            i++;

            residuo = new Residuo("cascara.png", "Cascara", "cascara", i);
            listaResiduo.Add(residuo);
            i++;

            residuo = new Residuo("papel_bano.png", "Papel de baño", "papel_bano", i);
            listaResiduo.Add(residuo);
            i++;

            residuo = new Residuo("aceite.png", "Aceite", "aceite", i);
            listaResiduo.Add(residuo);
            i++;

            residuo = new Residuo("bote.png", "Bote", "bote", i);
            listaResiduo.Add(residuo);
            i++;

            residuo = new Residuo("porta_vaso.png", "Porta vaso", "porta_vaso", i);
            listaResiduo.Add(residuo);
            i++;

            residuo = new Residuo("charola.png", "Charola", "charola", i);
            listaResiduo.Add(residuo);
            i++;

            residuo = new Residuo("hoja.png", "Hoja", "hoja", i);
            listaResiduo.Add(residuo);
            i++;

            residuo = new Residuo("revista.png", "Revista", "revista", i);
            listaResiduo.Add(residuo);
            i++;

            residuo = new Residuo("libro.png", "Libro", "libro", i);
            listaResiduo.Add(residuo);
            i++;

            residuo = new Residuo("cuaderno.png", "Cuaderno", "cuaderno", i);
            listaResiduo.Add(residuo);
            i++;

            residuo = new Residuo("periodico.png", "Periodico", "periodico", i);
            listaResiduo.Add(residuo);
            i++;

            residuo = new Residuo("folleto.png", "Folleto", "folleto", i);
            listaResiduo.Add(residuo);
            i++;

            residuo = new Residuo("garrafa.png", "Garrafa", "garrafa", i);
            listaResiduo.Add(residuo);
            i++;

            residuo = new Residuo("bolsa.png", "Bolsa", "bolsa", i);
            listaResiduo.Add(residuo);
            i++;

            residuo = new Residuo("envase.png", "Envase", "envase", i);
            listaResiduo.Add(residuo);
            i++;

            residuo = new Residuo("plato.png", "Plato", "plato", i);
            listaResiduo.Add(residuo);
            i++;

            residuo = new Residuo("lata.png", "Lata", "lata", i);
            listaResiduo.Add(residuo);
            i++;

            residuo = new Residuo("bandeja.png", "Bandeja", "bandeja", i);
            listaResiduo.Add(residuo);
            i++;

            residuo = new Residuo("aerosol.png", "Aerosol", "aerosol", i);
            listaResiduo.Add(residuo);
            i++;

            residuo = new Residuo("rollo.png", "Rollo", "rollo", i);
            listaResiduo.Add(residuo);
            i++;

            residuo = new Residuo("bote.png", "Bote", "bote", i);
            listaResiduo.Add(residuo);
            i++;

            residuo = new Residuo("globo.png", "Globo", "globo", i);
            listaResiduo.Add(residuo);
            i++;

            residuo = new Residuo("guantes.png", "Guantes", "guantes", i);
            listaResiduo.Add(residuo);
            i++;

            residuo = new Residuo("banda.png", "Banda", "banda", i);
            listaResiduo.Add(residuo);
            i++;

            residuo = new Residuo("biberon.png", "Biberon", "biberon", i);
            listaResiduo.Add(residuo);
            i++;

            residuo = new Residuo("manguera.png", "Manguera", "manguera", i);
            listaResiduo.Add(residuo);
            i++;

            residuo = new Residuo("jarra.png", "Jarra", "jarra", i);
            listaResiduo.Add(residuo);
            i++;

            residuo = new Residuo("copa.png", "Copa", "copa", i);
            listaResiduo.Add(residuo);
            i++;

            residuo = new Residuo("hueso.png", "Hueso", "hueso", i);
            listaResiduo.Add(residuo);
            i++;

            residuo = new Residuo("sobras_comida.png", "Sobras comida", "sobras_comida", i);
            listaResiduo.Add(residuo);
            i++;

            residuo = new Residuo("planta.png", "Planta", "planta", i);
            listaResiduo.Add(residuo);
            i++;

            residuo = new Residuo("servilleta.png", "Servilleta", "servilleta", i);
            listaResiduo.Add(residuo);
            i++;

            residuo = new Residuo("papel_cocina.png", "Papel cocina", "papel_cocina", i);
            listaResiduo.Add(residuo);
            i++;

            residuo = new Residuo("palillo.png", "Palillo", "palillo", i);
            listaResiduo.Add(residuo);
            i++;

            residuo = new Residuo("cerillo.png", "Cerillo ", "cerillo ", i);
            listaResiduo.Add(residuo);
            i++;

            residuo = new Residuo("lapiz.png", "Lapiz", "lapiz", i);
            listaResiduo.Add(residuo);
            i++;

            residuo = new Residuo("toalla_sanitaria.png", "Toalla sanitaria", "toalla_sanitaria", i);
            listaResiduo.Add(residuo);
            i++;

            residuo = new Residuo("reciduo_animal.png", "Reciduo animal", "reciduo_animal", i);
            listaResiduo.Add(residuo);
            i++;

            residuo = new Residuo("panal.png", "Panal", "panal", i);
            listaResiduo.Add(residuo);
            i++;

            residuo = new Residuo("cuchilla_afeitar.png", "Cuchilla afeitar", "cuchilla_afeitar", i);
            listaResiduo.Add(residuo);
            i++;

            residuo = new Residuo("cepillo_dientes.png", "Cepillo dientes", "cepillo_dientes", i);
            listaResiduo.Add(residuo);
            i++;

            residuo = new Residuo("hilo_dental.png", "Hilo dental", "hilo_dental", i);
            listaResiduo.Add(residuo);
            i++;

            residuo = new Residuo("tinta_impresora.png", "Tinta impresora", "tinta_impresora", i);
            listaResiduo.Add(residuo);
            i++;

            residuo = new Residuo("pintura.png", "Pintura", "pintura", i);
            listaResiduo.Add(residuo);
            i++;

            residuo = new Residuo("juguete.png", "Juguete", "juguete", i);
            listaResiduo.Add(residuo);
            i++;

            residuo = new Residuo("pila.png", "Pila", "pila", i);
            listaResiduo.Add(residuo);
            i++;

            residuo = new Residuo("electrodomestico.png", "Electrodomestico", "electrodomestico", i);
            listaResiduo.Add(residuo);
            i++;

        }

        public void LlenarListaMaterial()//Lista de los tipos de Materiales
        {
            int i = 0;
            //          1:Nombre de la imagen  2:Texto del Residuo  3:Nombre usado en el archivo pl de Prolog
            material = new Material("carton.png", "Carton", "carton", i);
            listaMaterial.Add(material);
            i++;

            material = new Material("plastico.png", "Plastico", "plastico", i);
            listaMaterial.Add(material);
            i++;

            material = new Material("vidrio.png", "Vidrio", "vidrio", i);
            listaMaterial.Add(material);
            i++;

            material = new Material("resto.png", "Resto", "resto", i);
            listaMaterial.Add(material);
            i++;

            material = new Material("sanitario.png", "Sanitario", "sanitario", i);
            listaMaterial.Add(material);
            i++;

            material = new Material("liquido.png", "Liquido", "liquido", i);
            listaMaterial.Add(material);
            i++;

            material = new Material("aluminio.png", "Aluminio", "aluminio", i);
            listaMaterial.Add(material);
            i++;

            material = new Material("latex.jpg", "Latex", "latex", i);
            listaMaterial.Add(material);
            i++;

            material = new Material("caucho.png", "Caucho", "caucho", i);
            listaMaterial.Add(material);
            i++;

            material = new Material("unicel.png", "Unicel", "unicel", i);
            listaMaterial.Add(material);
            i++;

            material = new Material("lino.jpg", "Lino", "lino", i);
            listaMaterial.Add(material);
            i++;

            material = new Material("madera.png", "Madera", "madera", i);
            listaMaterial.Add(material);
            i++;

            material = new Material("higiene.png", "Higiene", "higiene", i);
            listaMaterial.Add(material);
            i++;

            material = new Material("papel.png", "Papel", "papel", i);
            listaMaterial.Add(material);
            i++;
        }

        public void ReciclarResiduo()
        {
            var resultados = QueryProcessor.ProcessForResults("color(" + nombrePrologResiduo + "," + nombrePrologMaterial + ",Z).");
            
            resultados.ForEach(resultado =>
            {
                bote = resultado["Z"];
            });
        }

        public void EsOrganico()
        {
            var resultados = QueryProcessor.ProcessForResults("clase(W," + nombrePrologResiduo + "," + nombrePrologMaterial + ","+ bote +").");
            resultados.ForEach(resultado =>
            {
                organico = resultado["W"];
            });

            if (organico.Equals("organico"))
            {
                imagenOrganica.Image = Image.FromFile("organico.png");
                textoOrganica.Text = "La basura organica es...";
            }
            else if(organico.Equals("inorganico"))
            {
                imagenOrganica.Image = Image.FromFile("inorganico.png");
                textoOrganica.Text = "La basura inorganica es...";
            }
        }

        private void reciclar_Click(object sender, EventArgs e)
        {
            bote = "error";
            ReciclarResiduo();

            if (bote.Equals("azul"))
            {
                imagenBote.Image = Image.FromFile("azul.png");
                textoBote.Text = "El contenedor azul";
                EsOrganico();
            }
            else if (bote.Equals("amarillo"))
            {
                imagenBote.Image = Image.FromFile("amarillo.png");
                textoBote.Text = "El contenedor amarillo";
                EsOrganico();
            }
            else if (bote.Equals("verde"))
            {
                imagenBote.Image = Image.FromFile("verde.png");
                textoBote.Text = "El contenedor verde";
                EsOrganico();
            }
            else if (bote.Equals("marron"))
            {
                imagenBote.Image = Image.FromFile("marron.png");
                textoBote.Text = "El contenedor marron";
                EsOrganico();
            }
            else if (bote.Equals("gris"))
            {
                imagenBote.Image = Image.FromFile("gris.png");
                textoBote.Text = "El contenedor gris";
                EsOrganico();
            }
            else if (bote.Equals("punto_limpio"))
            {
                imagenBote.Image = Image.FromFile("punto_limpio.jpg");
                textoBote.Text = "El punto limpio";
                EsOrganico();
            }
            else
            {
                MessageBox.Show("Lo sentimos, tu residuo no puede ser reciclado.");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void adelante_Click(object sender, EventArgs e)
        {
            if (posicion < listaResiduo.Count-1)
            {
                posicion++;
                foreach (Residuo r in listaResiduo)
                {
                    if(r.Posicion == posicion)
                    {
                        imagenResiduo.Image = Image.FromFile(r.Imagen);
                        nombreResiduo.Text = r.Nombre;
                        nombrePrologResiduo = r.NombreProlog;
                        break;
                    }
                }
            }
        }

        private void atras_Click(object sender, EventArgs e)
        {  
            if (posicion > 0)
            {
                posicion--;
                foreach (Residuo r in listaResiduo)
                {
                    if (r.Posicion == posicion)
                    {
                        imagenResiduo.Image = Image.FromFile(r.Imagen);
                        nombreResiduo.Text = r.Nombre;
                        nombrePrologResiduo = r.NombreProlog;
                        break;
                    }
                }
            }
        }

        private void nombreResiduo_Click(object sender, EventArgs e)
        {

        }

        private void imagenMaterial_Click(object sender, EventArgs e)
        {

        }

        private void adelanteMaterial_Click(object sender, EventArgs e)
        {
            if (posicion2 < listaMaterial.Count - 1)
            {
                posicion2++;
                foreach (Material r in listaMaterial)
                {
                    if (r.Posicion == posicion2)
                    {
                        imagenMaterial.Image = Image.FromFile(r.Imagen);
                        nombreMaterial.Text = r.Nombre;
                        nombrePrologMaterial = r.NombreProlog;
                        break;
                    }
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
                    }

        private void atrasMaterial_Click(object sender, EventArgs e)
        {
            if (posicion2 > 0)
            {
                posicion2--;
                foreach (Material r in listaMaterial)
                {
                    if (r.Posicion == posicion2)
                    {
                        imagenMaterial.Image = Image.FromFile(r.Imagen);
                        nombreMaterial.Text = r.Nombre;
                        nombrePrologMaterial = r.NombreProlog;
                        break;
                    }
                }
            }
        }
    }
}
