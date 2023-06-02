import { LookupEditor, PrefixedContext } from "@serenity-is/corelib";
import { initFormType } from "@serenity-is/corelib/q";

export interface TblSucursalRappiForm {
    LocalSap: LookupEditor;
}

export class TblSucursalRappiForm extends PrefixedContext {
    static formKey = 'Sucursales.TblSucursalRappi';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!TblSucursalRappiForm.init)  {
            TblSucursalRappiForm.init = true;

            var w0 = LookupEditor;

            initFormType(TblSucursalRappiForm, [
                'LocalSap', w0
            ]);
        }
    }
}