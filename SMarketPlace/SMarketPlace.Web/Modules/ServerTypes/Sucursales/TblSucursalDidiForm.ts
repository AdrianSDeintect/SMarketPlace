import { LookupEditor, PrefixedContext } from "@serenity-is/corelib";
import { initFormType } from "@serenity-is/corelib/q";

export interface TblSucursalDidiForm {
    LocalSap: LookupEditor;
}

export class TblSucursalDidiForm extends PrefixedContext {
    static formKey = 'Sucursales.TblSucursalDidi';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!TblSucursalDidiForm.init)  {
            TblSucursalDidiForm.init = true;

            var w0 = LookupEditor;

            initFormType(TblSucursalDidiForm, [
                'LocalSap', w0
            ]);
        }
    }
}