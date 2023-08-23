import { initFullHeightGridPage } from '@serenity-is/corelib/q';
import { ActualizarPedidoGrid } from './ActualizarPedidoGrid';

export default function pageInit() {
    initFullHeightGridPage(new ActualizarPedidoGrid($('#GridDiv')).element);
}