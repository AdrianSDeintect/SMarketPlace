import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { TblArticuloColumns, TblArticuloRow, TblArticuloService } from '../../ServerTypes/Productos';
import { TblArticuloDialog } from './TblArticuloDialog';

@Decorators.registerClass('SMarketPlace.Productos.TblArticuloGrid')
export class TblArticuloGrid extends EntityGrid<TblArticuloRow, any> {
    protected getColumnsKey() { return TblArticuloColumns.columnsKey; }
    protected getDialogType() { return TblArticuloDialog; }
    protected getRowDefinition() { return TblArticuloRow; }
    protected getService() { return TblArticuloService.baseUrl; }

    constructor(container: JQuery) {
        super(container);
    }
}