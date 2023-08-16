using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelicopterFlyingAndShootingGame
{
    public partial class Form1 : Form
    {
        // Ingresaremos las variables dentro de la clase de la interfaz.

        bool goUp; // Este es un booleano para permitir que el jugador pueda subir o ir hacia arriba.
        bool goDown; // Este es un booleano para permitir que el jugador pueda bajar o ir hacia abajo.
        bool disparar = false; // Esto verificará si el jugador ha disparado alguna bala o no.
        int puntuacion = 0; // La puntuación total se inicializa en 0.
        int velocidad = 8; // La velocidad inicial del juego es de 8 km/h.
        Random rnd = new Random(); // Variable aleatoria.
        int velocidadHelicoptero = 7; // La velocidad inicial del helicóptero es de 7 km/h.
        int index; // Este es un entero vacío que se usará para cambiar las imágenes de ovnis.


        public Form1()
        {
            InitializeComponent();
        }

        // Método para el temporizador del juego.

        private void MenuEventoTemporizador(object sender, EventArgs e)
        {
            // EN INSTANTES...
        }

        // Método que permite interactuar al jugador con la tecla presionada del teclado.

        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            // EN INSTANTES...
        }

        // Método que permite interactuar al jugador soltando una tecla del teclado.

        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            // EN INSTANTES...
        }
    }
}
