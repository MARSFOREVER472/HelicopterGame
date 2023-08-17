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
            // Cuando se presionan las teclas de arriba y abajo:
            
            if (e.KeyCode == Keys.Up) // Si el helicóptero va hacia arriba.
            {
                // Si el jugador ha presionado la tecla de arriba,
                // cambiaremos el modo de ir hacia arriba a verdadero.

                goUp = true; // Arriba.
            }

            if (e.KeyCode == Keys.Down) // Si el helicóptero va hacia abajo.
            {
                // Si el jugador ha presionado la tecla de abajo,
                // cambiaremos el modo de ir hacia abajo a verdadero.

                goDown = true; // Abajo.
            }

            if (e.KeyCode == Keys.Space && disparar == false)
            {
                // Si el jugador ha presionado la tecla "Espacio"
                // y el disparo booleano es falso cuando lo crearon,
                // luego ejecutaremos la función de crear las balas
                // y cambiar el modo de disparo de falso a verdadero.

                crearBalas();
                disparar = true;
            }

        }

        // Método que permite interactuar al jugador soltando una tecla del teclado.

        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            // Crearemos un algoritmo sencillo al soltar las teclas del teclado.

            if (e.KeyCode == Keys.Up) // Si la tecla de arriba está suelta.
            {
                goUp = false; // Suelta la tecla de arriba del teclado.
            }

            if (e.KeyCode == Keys.Down) // Si la tecla de abajo está suelta.
            {
                goDown = false; // Suelta la tecla de abajo del teclado.
            }

            if (disparar == true) // Si dispara una de sus balas del helicóptero.
            {
                disparar = false; // No lo va a disparar.
            }

        }

        // Métodos para reiniciar, finalizar la partida, eliminar las balas y cambiar alienígenas, respectivamente.

        // Para reiniciar el juego.

        private void restartGame()
        {
            // EN INSTANTES...
        }

        // Para finalizar la partida.

        private void GameOver()
        {
            // EN INSTANTES...
        }

        // Para eliminar las balas lanzadas.

        private void eliminarBalas()
        {
            // EN INSTANTES...
        }

        // Para cambiar de alienígenas.

        private void cambiarUFOs()
        {
            // EN INSTANTES...
        }

        // Para crear las balas respectivas.

        private void crearBalas()
        {
            // EN INSTANTES...
        }
    }
}
