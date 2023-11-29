import { Decorators, EntityDialog } from '@serenity-is/corelib';
import { PreciosStockRappiForm, PreciosStockRappiRow, PreciosStockRappiService } from '../../ServerTypes/Log';

@Decorators.registerClass('SMarketPlace.Log.PreciosStockRappiDialog')
export class PreciosStockRappiDialog extends EntityDialog<PreciosStockRappiRow, any> {
    protected getFormKey() { return PreciosStockRappiForm.formKey; }
    protected getRowDefinition() { return PreciosStockRappiRow; }
    protected getService() { return PreciosStockRappiService.baseUrl; }

    protected form = new PreciosStockRappiForm(this.idPrefix);
}