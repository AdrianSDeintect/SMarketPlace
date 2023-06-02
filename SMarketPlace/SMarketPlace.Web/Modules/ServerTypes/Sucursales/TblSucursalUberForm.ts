import { LookupEditor, PrefixedContext } from "@serenity-is/corelib";
import { initFormType } from "@serenity-is/corelib/q";

export interface TblSucursalUberForm {
    LocalSap: LookupEditor;
}

export class TblSucursalUberForm extends PrefixedContext {
    static formKey = 'Sucursales.TblSucursalUber';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!TblSucursalUberForm.init)  {
            TblSucursalUberForm.init = true;

            var w0 = LookupEditor;

            initFormType(TblSucursalUberForm, [
                'LocalSap', w0
            ]);
        }
    }
}