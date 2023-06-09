import { StringEditor, PrefixedContext } from "@serenity-is/corelib";
import { initFormType } from "@serenity-is/corelib/q";

export interface PromocionesForm {
    IdOrder: StringEditor;
    IdPromocion: StringEditor;
    MapCod: StringEditor;
    NroLocal: StringEditor;
    Mecanica: StringEditor;
    DescripcionPromocion: StringEditor;
    CantidadBeneficio: StringEditor;
    CantidadRequisito: StringEditor;
    Beneficio: StringEditor;
    InicioVigencia: StringEditor;
    FinVigencia: StringEditor;
    MostrarPrecioRebajado: StringEditor;
    Alcanceas: StringEditor;
    ZonaVisualizacion: StringEditor;
    DescripcionCorta: StringEditor;
    LealtadCodigoAcumula: StringEditor;
    LealtadLimitePiezas: StringEditor;
    LealtadLimitePeriodicidad: StringEditor;
}

export class PromocionesForm extends PrefixedContext {
    static formKey = 'Ecommerce.Promociones';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!PromocionesForm.init)  {
            PromocionesForm.init = true;

            var w0 = StringEditor;

            initFormType(PromocionesForm, [
                'IdOrder', w0,
                'IdPromocion', w0,
                'MapCod', w0,
                'NroLocal', w0,
                'Mecanica', w0,
                'DescripcionPromocion', w0,
                'CantidadBeneficio', w0,
                'CantidadRequisito', w0,
                'Beneficio', w0,
                'InicioVigencia', w0,
                'FinVigencia', w0,
                'MostrarPrecioRebajado', w0,
                'Alcanceas', w0,
                'ZonaVisualizacion', w0,
                'DescripcionCorta', w0,
                'LealtadCodigoAcumula', w0,
                'LealtadLimitePiezas', w0,
                'LealtadLimitePeriodicidad', w0
            ]);
        }
    }
}