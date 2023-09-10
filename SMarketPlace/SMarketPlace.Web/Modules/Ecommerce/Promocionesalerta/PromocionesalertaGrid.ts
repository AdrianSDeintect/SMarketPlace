import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { PromocionesalertaColumns, PromocionesalertaRow, PromocionesalertaService } from '../../ServerTypes/Ecommerce';
import { PromocionesalertaDialog } from './PromocionesalertaDialog';

@Decorators.registerClass('SMarketPlace.Ecommerce.PromocionesalertaGrid')
export class PromocionesalertaGrid extends EntityGrid<PromocionesalertaRow, any> {
    protected getColumnsKey() { return PromocionesalertaColumns.columnsKey; }
    protected getDialogType() { return PromocionesalertaDialog; }
    protected getRowDefinition() { return PromocionesalertaRow; }
    protected getService() { return PromocionesalertaService.baseUrl; }

    constructor(container: JQuery) {
        super(container);
    }
}