import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { AsignaSucursalColumns, AsignaSucursalRow, AsignaSucursalService } from '../../ServerTypes/JobMP';
import { AsignaSucursalDialog } from './AsignaSucursalDialog';

@Decorators.registerClass('SMarketPlace.JobMP.AsignaSucursalGrid')
export class AsignaSucursalGrid extends EntityGrid<AsignaSucursalRow, any> {
    protected getColumnsKey() { return AsignaSucursalColumns.columnsKey; }
    protected getDialogType() { return AsignaSucursalDialog; }
    protected getRowDefinition() { return AsignaSucursalRow; }
    protected getService() { return AsignaSucursalService.baseUrl; }

    constructor(container: JQuery) {
        super(container);
    }
}