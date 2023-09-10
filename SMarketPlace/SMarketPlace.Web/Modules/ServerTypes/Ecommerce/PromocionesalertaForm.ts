import { StringEditor, PrefixedContext } from "@serenity-is/corelib";
import { initFormType } from "@serenity-is/corelib/q";

export interface PromocionesalertaForm {
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

export class PromocionesalertaForm extends PrefixedContext {
    static formKey = 'Ecommerce.Promocionesalerta';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!PromocionesalertaForm.init)  {
            PromocionesalertaForm.init = true;

            var w0 = StringEditor;

            initFormType(PromocionesalertaForm, [
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