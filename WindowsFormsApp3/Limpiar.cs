using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


class Limpiar

{


    public void Borrar(Control Control, GroupBox gb, GroupBox gb1, GroupBox observaciones1, GroupBox Comentario, TabControl Validaciones, GroupBox groupBox6)
    {

        foreach (var txt in Control.Controls)
        {
            if (txt is TextBox)
            {
                ((TextBox)txt).Clear();
            }
            else if (txt is ComboBox)
            {
                ((ComboBox)txt).Text = "";
            }
            else if (txt is RichTextBox)
            {
                ((RichTextBox)txt).Clear();
            }
        }
        foreach (var combo in gb.Controls)
        {
            if (combo is TextBox)
            {
                ((TextBox)combo).Clear();
            }
            else if (combo is ComboBox)
            {
                ((ComboBox)combo).SelectedIndex = 0;
            }
            else if (combo is RichTextBox)
            {
                ((RichTextBox)combo).Clear();
            }
        }
        foreach (var combo1 in gb1.Controls)
        {
            if (combo1 is TextBox)
            {
                ((TextBox)combo1).Clear();
            }
            else if (combo1 is ComboBox)
            {
                ((ComboBox)combo1).Text = "";
            }
            else if (combo1 is RichTextBox)
            {
                ((RichTextBox)combo1).Clear();
            }
        }
        foreach (var observaciones in observaciones1.Controls)
        {
            if (observaciones is TextBox)
            {
                ((TextBox)observaciones).Clear();
            }
            else if (observaciones is ComboBox)
            {
                ((ComboBox)observaciones).Text = "";
            }
            else if (observaciones is RichTextBox)
            {
                ((RichTextBox)observaciones).Clear();
            }
        }
        foreach (var Com in Comentario.Controls)
        {
            if (Com is TextBox)
            {
                ((TextBox)Com).Clear();
            }
            else if (Com is ComboBox)
            {
                ((ComboBox)Com).Text = "";
            }
            else if (Com is RichTextBox)
            {
                ((RichTextBox)Com).Clear();
            }
        }
        foreach (var Val in Validaciones.Controls)
        {
            if (Val is TextBox)
            {
                ((TextBox)Val).Clear();
            }
            else if (Val is ComboBox)
            {
                ((ComboBox)Val).Text = "";
            }
            else if (Val is RichTextBox)
            {
                ((RichTextBox)Val).Clear();
            }
        }

        foreach (var gropudf in groupBox6.Controls)
        {
            if (gropudf is TextBox)
            {
                ((TextBox)gropudf).Clear();
            }
            else if (gropudf is ComboBox)
            {
                ((ComboBox)gropudf).Text = "";
            }
            else if (gropudf is RichTextBox)
            {
                ((RichTextBox)gropudf).Clear();
            }
        }
    }


    public void limpiar(Control Control, GroupBox gb)
    {
        foreach (var txt in Control.Controls)
        {
            if (txt is TextBox)
            {
                ((TextBox)txt).Clear();
            }
            else if (txt is ComboBox)
            {
                ((ComboBox)txt).SelectedIndex = 0;
            }
            else if (txt is RichTextBox)
            {
                ((RichTextBox)txt).Clear();
            }


            
        }
        foreach (var grop in gb.Controls)
        {
            if (grop is TextBox)
            {
                ((TextBox)grop).Clear();
            }
            else if (grop is ComboBox)
            {
                ((ComboBox)grop).SelectedIndex = 0;
            }
            else if (grop is RichTextBox)
            {
                ((RichTextBox)grop).Clear();
            }


           
        }
    }

    public bool vacio; // Variable utilizada para saber si hay algún TextBox vacio. 
    public void validar(Form formulario)
    {
        foreach (Control oControls in formulario.Controls) // Buscamos en cada TextBox de nuestro Formulario. 
        {
            if (oControls is TextBox & oControls.Text == String.Empty) // Verificamos que no este vacio. 
            {
                vacio = true; // Si esta vacio el TextBox asignamos el valor True a nuestra variable. 
            }
        }
        if (vacio == true) MessageBox.Show("Favor de llenar todos los campos."); // Si nuestra variable es verdadera mostramos un mensaje. 
        vacio = false; // Devolvemos el valor original a nuestra variable. 
    }

}

    




    

