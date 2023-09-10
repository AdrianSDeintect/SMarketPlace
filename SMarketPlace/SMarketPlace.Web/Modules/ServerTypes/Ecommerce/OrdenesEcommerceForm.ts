import { StringEditor, PrefixedContext } from "@serenity-is/corelib";
import { initFormType } from "@serenity-is/corelib/q";

export interface OrdenesEcommerceForm {
    IdPedidoEcommerce: StringEditor;
    EstadoPedidoInternet: StringEditor;
}

export class OrdenesEcommerceForm extends PrefixedContext {
    static formKey = 'Ecommerce.OrdenesEcommerce';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!OrdenesEcommerceForm.init)  {
            OrdenesEcommerceForm.init = true;

            var w0 = StringEditor;

            initFormType(OrdenesEcommerceForm, [
                'IdPedidoEcommerce', w0,
                'EstadoPedidoInternet', w0
            ]);
        }
    }
}