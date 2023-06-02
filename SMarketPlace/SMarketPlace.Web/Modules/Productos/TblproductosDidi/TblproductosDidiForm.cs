using Serenity.ComponentModel;
using SMarketPlace.Administration;
using System;
using System.Collections.Generic;

namespace SMarketPlace.Productos.Forms;

[FormScript("Productos.TblproductosDidi")]
[BasedOnRow(typeof(TblproductosDidiRow), CheckNames = false)]
public class TblproductosDidiForm
{
    //public string StrDivision { get; set; }
    //public string StrCategoria { get; set; }
    //public string StrSubCat { get; set; }
    //public string StrGrupo { get; set; }
    //public string StrUpc { get; set; }
    //public string StrMarca { get; set; }
    //public string StrNombre { get; set; }
    //public string StrFormato { get; set; }    
    //public string Strimagen { get; set; }
    //public Int32 fkIdArticulo { get; set; }
    //public String fkDesArticulo { get; set; }

    [Tab("General")]
    public int IntArticuloid { get; set; }
}