import { LookupEditor, PrefixedContext } from "@serenity-is/corelib";
import { initFormType } from "@serenity-is/corelib/q";

export interface TblproductosDidiForm {
    IntArticuloid: LookupEditor;
}

export class TblproductosDidiForm extends PrefixedContext {
    static formKey = 'Productos.TblproductosDidi';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!TblproductosDidiForm.init)  {
            TblproductosDidiForm.init = true;

            var w0 = LookupEditor;

            initFormType(TblproductosDidiForm, [
                'IntArticuloid', w0
            ]);
        }
    }
}