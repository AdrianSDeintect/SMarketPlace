using Serenity.ComponentModel;
using System;
using System.ComponentModel;

namespace SMarketPlace.JobMP.Columns;

[ColumnsScript("JobMP.JobSucursales")]
[BasedOnRow(typeof(JobSucursalesRow), CheckNames = true)]
public class JobSucursalesColumns
{
    [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
    public string IdMpNombreMp { get; set; }
    public string IdintegradorNombre { get; set; }
    [EditLink]
    public string NombreMp { get; set; }
    public string Descripcion { get; set; }
    public string Dias { get; set; }
    public string Hora { get; set; }
    public int Activo { get; set; }
    public DateTime FechaInicio { get; set; }
    public int Diario { get; set; }
}