import { Decorators, EntityDialog } from '@serenity-is/corelib';
import { AsignaSucursalForm, AsignaSucursalRow, AsignaSucursalService } from '../../ServerTypes/JobMP';

@Decorators.registerClass('SMarketPlace.JobMP.AsignaSucursalDialog')
export class AsignaSucursalDialog extends EntityDialog<AsignaSucursalRow, any> {
    protected getFormKey() { return AsignaSucursalForm.formKey; }
    protected getRowDefinition() { return AsignaSucursalRow; }
    protected getService() { return AsignaSucursalService.baseUrl; }

    protected form = new AsignaSucursalForm(this.idPrefix);
}