import { Decorators, EntityDialog } from '@serenity-is/corelib';
import { PromocionesuberForm, PromocionesuberRow, PromocionesuberService } from '../../ServerTypes/Log';

@Decorators.registerClass('SMarketPlace.Log.PromocionesuberDialog')
export class PromocionesuberDialog extends EntityDialog<PromocionesuberRow, any> {
    protected getFormKey() { return PromocionesuberForm.formKey; }
    protected getRowDefinition() { return PromocionesuberRow; }
    protected getService() { return PromocionesuberService.baseUrl; }

    protected form = new PromocionesuberForm(this.idPrefix);
}