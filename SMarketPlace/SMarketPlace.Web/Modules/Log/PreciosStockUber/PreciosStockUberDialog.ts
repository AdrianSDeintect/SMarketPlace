import { Decorators, EntityDialog } from '@serenity-is/corelib';
import { PreciosStockUberForm, PreciosStockUberRow, PreciosStockUberService } from '../../ServerTypes/Log';

@Decorators.registerClass('SMarketPlace.Log.PreciosStockUberDialog')
export class PreciosStockUberDialog extends EntityDialog<PreciosStockUberRow, any> {
    protected getFormKey() { return PreciosStockUberForm.formKey; }
    protected getRowDefinition() { return PreciosStockUberRow; }
    protected getService() { return PreciosStockUberService.baseUrl; }

    protected form = new PreciosStockUberForm(this.idPrefix);
}