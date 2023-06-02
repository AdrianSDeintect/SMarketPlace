import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { TblSucursalColumns, TblSucursalRow, TblSucursalService } from '../../ServerTypes/Sucursales';
import { TblSucursalDialog } from './TblSucursalDialog';

@Decorators.registerClass('SMarketPlace.Sucursales.TblSucursalGrid')
export class TblSucursalGrid extends EntityGrid<TblSucursalRow, any> {
    protected getColumnsKey() { return TblSucursalColumns.columnsKey; }
    protected getDialogType() { return TblSucursalDialog; }
    protected getRowDefinition() { return TblSucursalRow; }
    protected getService() { return TblSucursalService.baseUrl; }

    constructor(container: JQuery) {
        super(container);
    }
}