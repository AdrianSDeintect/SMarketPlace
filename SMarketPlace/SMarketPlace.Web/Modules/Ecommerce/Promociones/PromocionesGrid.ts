import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { PromocionesColumns, PromocionesRow, PromocionesService } from '../../ServerTypes/Ecommerce';
import { PromocionesDialog } from './PromocionesDialog';

@Decorators.registerClass('SMarketPlace.Ecommerce.PromocionesGrid')
export class PromocionesGrid extends EntityGrid<PromocionesRow, any> {
    protected getColumnsKey() { return PromocionesColumns.columnsKey; }
    protected getDialogType() { return PromocionesDialog; }
    protected getRowDefinition() { return PromocionesRow; }
    protected getService() { return PromocionesService.baseUrl; }

    constructor(container: JQuery) {
        super(container);
    }
}