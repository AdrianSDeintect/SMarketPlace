import { StringEditor, DateEditor, PrefixedContext } from "@serenity-is/corelib";
import { initFormType } from "@serenity-is/corelib/q";

export interface ActualizarPedidoForm {
    IdPedidoEcommerce: StringEditor;
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

            var w0 = StringEditor;
            var w1 = DateEditor;

            initFormType(ActualizarPedidoForm, [
                'IdPedidoEcommerce', w0,
                'EstadoPedidoInternet', w0,
                'Estado', w0,
                'DtRegistroUsr', w1,
                'DtCambio', w1
            ]);
        }
    }
}