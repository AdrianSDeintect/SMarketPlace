import { LookupEditor, StringEditor, DateEditor, PrefixedContext } from "@serenity-is/corelib";
import { initFormType } from "@serenity-is/corelib/q";

export interface ActualizarPedidoForm {
    IdPedidoEcommerce: LookupEditor;
    EstadoPedidoInternet: StringEditor;
    Estado: StringEditor;
    DtRegistroUsr: DateEditor;
    DtCambio: DateEditor;
}

export class ActualizarPedidoForm extends PrefixedContext {
    static formKey = 'Ecommerce.ActualizarPedido';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!ActualizarPedidoForm.init)  {
            ActualizarPedidoForm.init = true;

            var w0 = LookupEditor;
            var w1 = StringEditor;
            var w2 = DateEditor;

            initFormType(ActualizarPedidoForm, [
                'IdPedidoEcommerce', w0,
                'EstadoPedidoInternet', w1,
                'Estado', w1,
                'DtRegistroUsr', w2,
                'DtCambio', w2
            ]);
        }
    }
}