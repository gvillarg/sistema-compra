using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Validadores
{
    public class Validador
    {
        private System.Windows.Forms.ErrorProvider errorProvider;
        public Validador(ErrorProvider errorProvider)
        {
            this.errorProvider = errorProvider;
        }
        public bool validarCampoNoVacio(TextBox txtBox)
        {
            bool error=false;
            if (txtBox.TextLength == 0)
            {
                error = true;
                errorProvider.SetError(txtBox, "Llenar Campo");
            }
            return error;
        }
        public bool validarNumeroEntero(TextBox txtBox)
        {
            bool error;
            string text = txtBox.Text;
            bool hasDigit = true;
            foreach (char letter in text)
            {
                if (!char.IsDigit(letter))
                {
                    hasDigit = false;
                    break;
                }
            }
            error = !hasDigit;
            if (error)
            {
                errorProvider.SetError(txtBox, "Debe contener un número");
            }
            else
            {
                errorProvider.Clear();
            }
            return error;
        }

        public bool validarEmail(TextBox txtBox)
        {
            bool error;
            string text = txtBox.Text;
            int numArrobas = 0;
            char lastLetter = ' ';
            foreach (char letter in text)
            {
                lastLetter = letter;
                if (letter == '@')
                {
                    numArrobas++;
                }
            }
            error = (numArrobas != 1) || (lastLetter == '@');
            //Console.Out.WriteLine("Has Digit: " + hasDigit + " Numero de Puntos: " + numPuntos);
            // Call SetError or Clear on the ErrorProvider.
            if (error)
            {
                errorProvider.SetError(txtBox, "Email incorrecto");
            }
            else
            {
                errorProvider.Clear();
            }
            return error;
        }
        public bool validarContrasena(TextBox txtBox,TextBox txtBox2)
        {
            bool error;
            string text = txtBox.Text;
            string text2 = txtBox2.Text;
            int numArrobas = 0;
            char lastLetter = ' ';
            foreach (char letter in text)
            {
                lastLetter = letter;
                if (letter == '@')
                {
                    numArrobas++;
                }
            }
            error = !string.Equals(text, text2);
            //Console.Out.WriteLine("Has Digit: " + hasDigit + " Numero de Puntos: " + numPuntos);
            // Call SetError or Clear on the ErrorProvider.
            if (error)
            {
                errorProvider.SetError(txtBox, "Contraseña Incorrecta");
            }
            else
            {
                errorProvider.Clear();
            }
            return error;
        }

        public bool validarNumeroReal(TextBox txtBox)
        {
            bool error;
            string text = txtBox.Text;
            bool hasDigit = true;
            int numPuntos = 0;
            char lastLetter = ' ';
            foreach (char letter in text)
            {
                lastLetter = letter;
                if (!char.IsDigit(letter))
                {
                    if (letter == '.')
                        numPuntos++;
                    else
                    {
                        hasDigit = false;
                        break;
                    }
                }
            }
            error = !hasDigit || (numPuntos >= 2) || (lastLetter == '.');
            //Console.Out.WriteLine("Has Digit: " + hasDigit + " Numero de Puntos: " + numPuntos);
            // Call SetError or Clear on the ErrorProvider.
            if (error)
            {
                errorProvider.SetError(txtBox, "Debe contener un número");
            }
            else
            {
                errorProvider.Clear();
            }
            return error;
        }
    }
}
