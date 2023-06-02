using Serenity.ComponentModel;
using SMarketPlace.Administration;
using System;
using System.Collections.Generic;

namespace SMarketPlace.Sucursales.Forms;

[FormScript("Sucursales.TblSucursalDidi")]
[BasedOnRow(typeof(TblSucursalDidiRow), CheckNames = true)]
public class TblSucursalDidiForm
{
    [Tab("General")]
    public string LocalSap { get; set; }
}