using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; //adicionar para controles de form

namespace Agenda.Classes
{
    class Util
    {
       public void limparTextBoxes(Control.ControlCollection controles)
        {
            //Faz um laço para todos os controles passados no parâmetro
            foreach (Control ctrl in controles)
            {
                //Se o contorle for um TextBox...
                if (ctrl is TextBox) 
                {
                    ((TextBox)(ctrl)).Text = String.Empty;
                }else if (ctrl is MaskedTextBox)// se forem MaskedBox
                {
                    ((MaskedTextBox)(ctrl)).Text = String.Empty;
                }
            }
        }
        
    }
}
