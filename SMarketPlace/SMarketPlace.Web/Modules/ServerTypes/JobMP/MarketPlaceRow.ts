import { fieldsProxy } from "@serenity-is/corelib/q";

export interface MarketPlaceRow {
    Idintegrador?: number;
    Nombre?: string;
    Descripcion?: string;
    Activo?: number;
    FechaInicio?: string;
    Clase?: string;
}

export abstract class MarketPlaceRow {
    static readonly idProperty = 'Idintegrador';
    static readonly nameProperty = 'Nombre';
    static readonly localTextPrefix = 'JobMP.MarketPlace';
    static readonly deletePermission = 'Administration:General';
    static readonly insertPermission = 'Administration:General';
    static readonly readPermission = 'Administration:General';
    static readonly updatePermission = 'Administration:General';

    static readonly Fields = fieldsProxy<MarketPlaceRow>();
}