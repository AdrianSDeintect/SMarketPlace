import { LookupEditor, PrefixedContext } from "@serenity-is/corelib";
import { initFormType } from "@serenity-is/corelib/q";

export interface TblproductosUberForm {
    IntArticuloid: LookupEditor;
}

export class TblproductosUberForm extends PrefixedContext {
    static formKey = 'Productos.TblproductosUber';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!TblproductosUberForm.init)  {
            TblproductosUberForm.init = true;

            var w0 = LookupEditor;

            initFormType(TblproductosUberForm, [
                'IntArticuloid', w0
            ]);
        }
    }
}