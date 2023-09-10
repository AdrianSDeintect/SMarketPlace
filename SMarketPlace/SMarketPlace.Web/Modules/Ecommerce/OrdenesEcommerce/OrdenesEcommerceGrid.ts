import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { OrdenesEcommerceColumns, OrdenesEcommerceRow, OrdenesEcommerceService } from '../../ServerTypes/Ecommerce';
import { OrdenesEcommerceDialog } from './OrdenesEcommerceDialog';

@Decorators.registerClass('SMarketPlace.Ecommerce.OrdenesEcommerceGrid')
export class OrdenesEcommerceGrid extends EntityGrid<OrdenesEcommerceRow, any> {
    protected getColumnsKey() { return OrdenesEcommerceColumns.columnsKey; }
    protected getDialogType() { return OrdenesEcommerceDialog; }
    protected getRowDefinition() { return OrdenesEcommerceRow; }
    protected getService() { return OrdenesEcommerceService.baseUrl; }

    constructor(container: JQuery) {
        super(container);
    }
}