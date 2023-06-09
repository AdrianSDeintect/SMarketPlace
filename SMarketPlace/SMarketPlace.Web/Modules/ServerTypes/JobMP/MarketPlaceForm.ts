import { StringEditor, IntegerEditor, DateEditor, PrefixedContext } from "@serenity-is/corelib";
import { initFormType } from "@serenity-is/corelib/q";

export interface MarketPlaceForm {
    Nombre: StringEditor;
    Descripcion: StringEditor;
    Activo: IntegerEditor;
    FechaInicio: DateEditor;
    Clase: StringEditor;
}

export class MarketPlaceForm extends PrefixedContext {
    static formKey = 'JobMP.MarketPlace';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!MarketPlaceForm.init)  {
            MarketPlaceForm.init = true;

            var w0 = StringEditor;
            var w1 = IntegerEditor;
            var w2 = DateEditor;

            initFormType(MarketPlaceForm, [
                'Nombre', w0,
                'Descripcion', w0,
                'Activo', w1,
                'FechaInicio', w2,
                'Clase', w0
            ]);
        }
    }
}