﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014118287_ENT
{
    public class TipoPago
    {
        public int TipoPagoId { get; set; }
        public string MetodoPago { get; set; }

        public virtual int VentaId { get; set; }
        public virtual Venta Venta { get; set; }

        public TipoPago()
        {

        }

    }
}
