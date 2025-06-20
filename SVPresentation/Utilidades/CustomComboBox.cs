﻿

using SVPresentation.Utilidades.Objetos;

namespace SVPresentation.Utilidades
{
    public static class CustomComboBox
    {
        public static void InsertarItems(this ComboBox combo, OpcionCombo[] items)
        {
            combo.Items.AddRange(items);
            combo.DisplayMember = "Texto";          //Como guardar cada uno
            combo.ValueMember = "Valor";
            combo.SelectedIndex = 0;         //Por defecto siempre se seleccione el 0
        }

        public static void EstablecerValor(this ComboBox combo, int valor)
        {
            foreach (OpcionCombo opcion in combo.Items)
            {
                if (opcion.Valor == valor)
                {
                    combo.SelectedItem = opcion;
                    break;
                }

            }
        }

    }
}
