using Serenity.ComponentModel;

namespace SMarketPlace.Ecommerce.Forms;

[FormScript("Ecommerce.AlertaPromociones")]
[BasedOnRow(typeof(AlertaPromocionesRow), CheckNames = true)]
public class AlertaPromocionesForm
{
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