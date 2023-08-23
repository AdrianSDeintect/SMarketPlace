import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { AlertaPromocionesColumns, AlertaPromocionesRow, AlertaPromocionesService } from '../../ServerTypes/Ecommerce';
import { AlertaPromocionesDialog } from './AlertaPromocionesDialog';

@Decorators.registerClass('SMarketPlace.Ecommerce.AlertaPromocionesGrid')
export class AlertaPromocionesGrid extends EntityGrid<AlertaPromocionesRow, any> {
    protected getColumnsKey() { return AlertaPromocionesColumns.columnsKey; }
    protected getDialogType() { return AlertaPromocionesDialog; }
    protected getRowDefinition() { return AlertaPromocionesRow; }
    protected getService() { return AlertaPromocionesService.baseUrl; }

    constructor(container: JQuery) {
        super(container);
    }
}