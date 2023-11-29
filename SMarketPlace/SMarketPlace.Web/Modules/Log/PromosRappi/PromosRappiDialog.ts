import { Decorators, EntityDialog } from '@serenity-is/corelib';
import { PromosRappiForm, PromosRappiRow, PromosRappiService } from '../../ServerTypes/Log';

@Decorators.registerClass('SMarketPlace.Log.PromosRappiDialog')
export class PromosRappiDialog extends EntityDialog<PromosRappiRow, any> {
    protected getFormKey() { return PromosRappiForm.formKey; }
    protected getRowDefinition() { return PromosRappiRow; }
    protected getService() { return PromosRappiService.baseUrl; }

    protected form = new PromosRappiForm(this.idPrefix);
}