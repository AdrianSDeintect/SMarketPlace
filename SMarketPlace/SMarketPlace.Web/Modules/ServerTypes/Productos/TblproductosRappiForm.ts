import { LookupEditor, PrefixedContext } from "@serenity-is/corelib";
import { initFormType } from "@serenity-is/corelib/q";

export interface TblproductosRappiForm {
    IntArticuloid: LookupEditor;
}

export class TblproductosRappiForm extends PrefixedContext {
    static formKey = 'Productos.TblproductosRappi';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!TblproductosRappiForm.init)  {
            TblproductosRappiForm.init = true;

            var w0 = LookupEditor;

            initFormType(TblproductosRappiForm, [
                'IntArticuloid', w0
            ]);
        }
    }
}