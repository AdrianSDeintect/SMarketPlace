import { IntegerEditor, PrefixedContext } from "@serenity-is/corelib";
import { initFormType } from "@serenity-is/corelib/q";

export interface AsignaSucursalForm {
    IdMp: IntegerEditor;
    IdSucursal: IntegerEditor;
}

export class AsignaSucursalForm extends PrefixedContext {
    static formKey = 'JobMP.AsignaSucursal';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!AsignaSucursalForm.init)  {
            AsignaSucursalForm.init = true;

            var w0 = IntegerEditor;

            initFormType(AsignaSucursalForm, [
                'IdMp', w0,
                'IdSucursal', w0
            ]);
        }
    }
}