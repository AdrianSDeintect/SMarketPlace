import { Decorators, EntityDialog } from '@serenity-is/corelib';
import { MarketPlaceForm, MarketPlaceRow, MarketPlaceService } from '../../ServerTypes/JobMP';

@Decorators.registerClass('SMarketPlace.JobMP.MarketPlaceDialog')
export class MarketPlaceDialog extends EntityDialog<MarketPlaceRow, any> {
    protected getFormKey() { return MarketPlaceForm.formKey; }
    protected getRowDefinition() { return MarketPlaceRow; }
    protected getService() { return MarketPlaceService.baseUrl; }

    protected form = new MarketPlaceForm(this.idPrefix);
}