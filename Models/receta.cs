//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MVC.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class receta
    {
        public string idreceta { get; set; }
        public string nombre_receta { get; set; }
        public string descripcion { get; set; }
        public Nullable<int> valorReceta { get; set; }
        public string ingrdientes { get; set; }
        public string ubicacionReceta { get; set; }
    }
}
