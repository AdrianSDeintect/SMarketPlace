import { Decorators, EntityDialog } from '@serenity-is/corelib';
import { ActualizarPedidoForm, ActualizarPedidoRow, ActualizarPedidoService } from '../../ServerTypes/Ecommerce';

@Decorators.registerClass('SMarketPlace.Ecommerce.ActualizarPedidoDialog')
export class ActualizarPedidoDialog extends EntityDialog<ActualizarPedidoRow, any> {
    protected getFormKey() { return ActualizarPedidoForm.formKey; }
    protected getRowDefinition() { return ActualizarPedidoRow; }
    protected getService() { return ActualizarPedidoService.baseUrl; }

    protected form = new ActualizarPedidoForm(this.idPrefix);
}