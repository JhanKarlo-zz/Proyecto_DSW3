//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HotelWCF
{
    using System;
    using System.Collections.Generic;
    
    public partial class Consumo
    {
        public short id_Consumo { get; set; }
        public byte id_Estado_Consumo { get; set; }
        public short id_Producto { get; set; }
        public System.DateTime Fecha { get; set; }
        public short cantidad { get; set; }
        public short id_Reserva { get; set; }
    
        public virtual Producto Producto { get; set; }
        public virtual Reserva Reserva { get; set; }
    }
}
