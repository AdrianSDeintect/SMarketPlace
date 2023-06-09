import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { MarketPlaceColumns, MarketPlaceRow, MarketPlaceService } from '../../ServerTypes/JobMP';
import { MarketPlaceDialog } from './MarketPlaceDialog';

@Decorators.registerClass('SMarketPlace.JobMP.MarketPlaceGrid')
export class MarketPlaceGrid extends EntityGrid<MarketPlaceRow, any> {
    protected getColumnsKey() { return MarketPlaceColumns.columnsKey; }
    protected getDialogType() { return MarketPlaceDialog; }
    protected getRowDefinition() { return MarketPlaceRow; }
    protected getService() { return MarketPlaceService.baseUrl; }

    constructor(container: JQuery) {
        super(container);
    }
}