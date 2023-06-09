using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System.ComponentModel;

namespace SMarketPlace.Ecommerce;

[ConnectionKey("Default"), Module("Ecommerce"), TableName("PROMOCIONESC2SSMP")]
[DisplayName("Promociones"), InstanceName("Promociones")]
[ReadPermission("Administration:General")]
[ModifyPermission("Administration:General")]
public sealed class PromocionesRow : Row<PromocionesRow.RowFields>, IIdRow, INameRow
{
    [DisplayName("Id"), Column("id"), Identity, IdProperty]
    public int? Id
    {
        get => fields.Id[this];
        set => fields.Id[this] = value;
    }

    [DisplayName("Id Order"), Column("ID_ORDER"), Size(500), QuickSearch, NameProperty]
    public string IdOrder
    {
        get => fields.IdOrder[this];
        set => fields.IdOrder[this] = value;
    }

    [DisplayName("Id Promocion"), Column("ID_PROMOCION"), Size(500)]
    public string IdPromocion
    {
        get => fields.IdPromocion[this];
        set => fields.IdPromocion[this] = value;
    }

    [DisplayName("Map Cod"), Column("MAP_COD"), Size(500)]
    public string MapCod
    {
        get => fields.MapCod[this];
        set => fields.MapCod[this] = value;
    }

    [DisplayName("Nro Local"), Column("NRO_LOCAL"), Size(500)]
    public string NroLocal
    {
        get => fields.NroLocal[this];
        set => fields.NroLocal[this] = value;
    }

    [DisplayName("Mecanica"), Column("MECANICA"), Size(500)]
    public string Mecanica
    {
        get => fields.Mecanica[this];
        set => fields.Mecanica[this] = value;
    }

    [DisplayName("Descripcion Promocion"), Column("DESCRIPCION_PROMOCION"), Size(500)]
    public string DescripcionPromocion
    {
        get => fields.DescripcionPromocion[this];
        set => fields.DescripcionPromocion[this] = value;
    }

    [DisplayName("Cantidad Beneficio"), Column("CANTIDAD_BENEFICIO"), Size(500)]
    public string CantidadBeneficio
    {
        get => fields.CantidadBeneficio[this];
        set => fields.CantidadBeneficio[this] = value;
    }

    [DisplayName("Cantidad Requisito"), Column("CANTIDAD_REQUISITO"), Size(500)]
    public string CantidadRequisito
    {
        get => fields.CantidadRequisito[this];
        set => fields.CantidadRequisito[this] = value;
    }

    [DisplayName("Beneficio"), Column("BENEFICIO"), Size(500)]
    public string Beneficio
    {
        get => fields.Beneficio[this];
        set => fields.Beneficio[this] = value;
    }

    [DisplayName("Inicio Vigencia"), Column("INICIO_VIGENCIA"), Size(500)]
    public string InicioVigencia
    {
        get => fields.InicioVigencia[this];
        set => fields.InicioVigencia[this] = value;
    }

    [DisplayName("Fin Vigencia"), Column("FIN_VIGENCIA"), Size(500)]
    public string FinVigencia
    {
        get => fields.FinVigencia[this];
        set => fields.FinVigencia[this] = value;
    }

    [DisplayName("Mostrar Precio Rebajado"), Column("MOSTRAR_PRECIO_REBAJADO"), Size(500)]
    public string MostrarPrecioRebajado
    {
        get => fields.MostrarPrecioRebajado[this];
        set => fields.MostrarPrecioRebajado[this] = value;
    }

    [DisplayName("Alcanceas"), Column("ALCANCEAS"), Size(500)]
    public string Alcanceas
    {
        get => fields.Alcanceas[this];
        set => fields.Alcanceas[this] = value;
    }

    [DisplayName("Zona Visualizacion"), Column("ZONA_VISUALIZACION"), Size(500)]
    public string ZonaVisualizacion
    {
        get => fields.ZonaVisualizacion[this];
        set => fields.ZonaVisualizacion[this] = value;
    }

    [DisplayName("Descripcion Corta"), Column("DESCRIPCION_CORTA"), Size(500)]
    public string DescripcionCorta
    {
        get => fields.DescripcionCorta[this];
        set => fields.DescripcionCorta[this] = value;
    }

    [DisplayName("Lealtad Codigo Acumula"), Column("Lealtad_Codigo_Acumula"), Size(500)]
    public string LealtadCodigoAcumula
    {
        get => fields.LealtadCodigoAcumula[this];
        set => fields.LealtadCodigoAcumula[this] = value;
    }

    [DisplayName("Lealtad Limite Piezas"), Column("Lealtad_limite_piezas"), Size(500)]
    public string LealtadLimitePiezas
    {
        get => fields.LealtadLimitePiezas[this];
        set => fields.LealtadLimitePiezas[this] = value;
    }

    [DisplayName("Lealtad Limite Periodicidad"), Column("Lealtad_limite_periodicidad"), Size(500)]
    public string LealtadLimitePeriodicidad
    {
        get => fields.LealtadLimitePeriodicidad[this];
        set => fields.LealtadLimitePeriodicidad[this] = value;
    }

    public class RowFields : RowFieldsBase
    {
        public Int32Field Id;
        public StringField IdOrder;
        public StringField IdPromocion;
        public StringField MapCod;
        public StringField NroLocal;
        public StringField Mecanica;
        public StringField DescripcionPromocion;
        public StringField CantidadBeneficio;
        public StringField CantidadRequisito;
        public StringField Beneficio;
        public StringField InicioVigencia;
        public StringField FinVigencia;
        public StringField MostrarPrecioRebajado;
        public StringField Alcanceas;
        public StringField ZonaVisualizacion;
        public StringField DescripcionCorta;
        public StringField LealtadCodigoAcumula;
        public StringField LealtadLimitePiezas;
        public StringField LealtadLimitePeriodicidad;

    }
}