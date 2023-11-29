import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { PromosRappiColumns, PromosRappiRow, PromosRappiService } from '../../ServerTypes/Log';
import { PromosRappiDialog } from './PromosRappiDialog';

@Decorators.registerClass('SMarketPlace.Log.PromosRappiGrid')
export class PromosRappiGrid extends EntityGrid<PromosRappiRow, any> {
    protected getColumnsKey() { return PromosRappiColumns.columnsKey; }
    protected getDialogType() { return PromosRappiDialog; }
    protected getRowDefinition() { return PromosRappiRow; }
    protected getService() { return PromosRappiService.baseUrl; }

    constructor(container: JQuery) {
        super(container);
    }
}