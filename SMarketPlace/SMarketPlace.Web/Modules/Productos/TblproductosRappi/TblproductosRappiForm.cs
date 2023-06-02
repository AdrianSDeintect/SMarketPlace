using Serenity.ComponentModel;
using SMarketPlace.Administration;
using System;
using System.Collections.Generic;

namespace SMarketPlace.Productos.Forms;

[FormScript("Productos.TblproductosRappi")]
[BasedOnRow(typeof(TblproductosRappiRow), CheckNames = false)]
public class TblproductosRappiForm
{
    //[ChangingLookupTextEditor]
    //public string StrDivision { get; set; }
    //public string StrCategoria { get; set; }
    //public string StrSubCat { get; set; }
    //public string StrGrupo { get; set; }
    //public string StrUpc { get; set; }
    //public string StrMarca { get; set; }
    //public string StrNombre { get; set; }
    //public string StrFormato { get; set; }
    //public string Strimagen { get; set; }
    [Tab("General")]
    //public string NombrePerfil { get; set; }
    //public int Proveedor { get; set; }
    //public int TipoPlan { get; set; }
    public int IntArticuloid { get; set; }
}