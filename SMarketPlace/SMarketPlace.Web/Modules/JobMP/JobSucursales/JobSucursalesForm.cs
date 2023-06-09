using Serenity.ComponentModel;
using System;

namespace SMarketPlace.JobMP.Forms;

[FormScript("JobMP.JobSucursales")]
[BasedOnRow(typeof(JobSucursalesRow), CheckNames = true)]
public class JobSucursalesForm
{
    public int Idintegrador { get; set; }
    public string NombreMp { get; set; }
    public string Descripcion { get; set; }
    public string Dias { get; set; }
    public string Hora { get; set; }
    public int Activo { get; set; }
    public DateTime FechaInicio { get; set; }
    public int Diario { get; set; }
}