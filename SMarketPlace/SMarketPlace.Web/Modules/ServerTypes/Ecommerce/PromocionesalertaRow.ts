import { fieldsProxy } from "@serenity-is/corelib/q";

export interface PromocionesalertaRow {
    Id?: number;
    IdPromocion?: string;
    MapCod?: string;
    NroLocal?: string;
    Mecanica?: string;
    DescripcionPromocion?: string;
    CantidadBeneficio?: string;
    CantidadRequisito?: string;
    Beneficio?: string;
    InicioVigencia?: string;
    FinVigencia?: string;
    MostrarPrecioRebajado?: string;
    Alcanceas?: string;
    ZonaVisualizacion?: string;
    DescripcionCorta?: string;
    LealtadCodigoAcumula?: string;
    LealtadLimitePiezas?: string;
    LealtadLimitePeriodicidad?: string;
}

export abstract class PromocionesalertaRow {
    static readonly idProperty = 'Id';
    static readonly nameProperty = 'IdPromocion';
    static readonly localTextPrefix = 'Ecommerce.Promocionesalerta';
    static readonly deletePermission = 'Administration:General';
    static readonly insertPermission = 'Administration:General';
    static readonly readPermission = 'Administration:General';
    static readonly updatePermission = 'Administration:General';

    static readonly Fields = fieldsProxy<PromocionesalertaRow>();
}