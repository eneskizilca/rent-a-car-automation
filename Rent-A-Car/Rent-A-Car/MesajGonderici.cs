using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rent_A_Car
{
    class MesajGonderici
    {
        public void WhatappMesajiYolla(string telefon, string faturaPath)
        {
            string mesaj = "KızılCar kiralam işlemi için faturanız:  " + faturaPath;
            System.Diagnostics.Process.Start($"https://api.whatsapp.com/send?phone=" + telefon + "&text=" + mesaj);
        }
    }
}
