import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { ActualizarPedidoColumns, ActualizarPedidoRow, ActualizarPedidoService } from '../../ServerTypes/Ecommerce';
import { ActualizarPedidoDialog } from './ActualizarPedidoDialog';

@Decorators.registerClass('SMarketPlace.Ecommerce.ActualizarPedidoGrid')
export class ActualizarPedidoGrid extends EntityGrid<ActualizarPedidoRow, any> {
    protected getColumnsKey() { return ActualizarPedidoColumns.columnsKey; }
    protected getDialogType() { return ActualizarPedidoDialog; }
    protected getRowDefinition() { return ActualizarPedidoRow; }
    protected getService() { return ActualizarPedidoService.baseUrl; }

    constructor(container: JQuery) {
        super(container);
    }
}