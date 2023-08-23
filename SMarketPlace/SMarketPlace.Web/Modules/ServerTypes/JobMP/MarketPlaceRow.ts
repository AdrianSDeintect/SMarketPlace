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
    static readonly deletePermission = 'MP:MarketPlace';
    static readonly insertPermission = 'MP:MarketPlace';
    static readonly readPermission = 'MP:MarketPlace';
    static readonly updatePermission = 'MP:MarketPlace';

    static readonly Fields = fieldsProxy<MarketPlaceRow>();
}