using Serenity.ComponentModel;
using System.ComponentModel;

namespace SMarketPlace.Ecommerce.Columns;

[ColumnsScript("Ecommerce.Promocionesalerta")]
[BasedOnRow(typeof(PromocionesalertaRow), CheckNames = true)]
public class PromocionesalertaColumns
{
    [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
    public int Id { get; set; }
    [EditLink]
    public string IdPromocion { get; set; }
    public string MapCod { get; set; }
    public string NroLocal { get; set; }
    public string Mecanica { get; set; }
    public string DescripcionPromocion { get; set; }
    public string CantidadBeneficio { get; set; }
    public string CantidadRequisito { get; set; }
    public string Beneficio { get; set; }
    public string InicioVigencia { get; set; }
    public string FinVigencia { get; set; }
    public string MostrarPrecioRebajado { get; set; }
    public string Alcanceas { get; set; }
    public string ZonaVisualizacion { get; set; }
    public string DescripcionCorta { get; set; }
    public string LealtadCodigoAcumula { get; set; }
    public string LealtadLimitePiezas { get; set; }
    public string LealtadLimitePeriodicidad { get; set; }
}