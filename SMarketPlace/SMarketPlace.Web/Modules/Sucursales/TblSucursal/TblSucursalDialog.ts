import { Decorators, EntityDialog } from '@serenity-is/corelib';
import { TblSucursalForm, TblSucursalRow, TblSucursalService } from '../../ServerTypes/Sucursales';

@Decorators.registerClass('SMarketPlace.Sucursales.TblSucursalDialog')
export class TblSucursalDialog extends EntityDialog<TblSucursalRow, any> {
    protected getFormKey() { return TblSucursalForm.formKey; }
    protected getRowDefinition() { return TblSucursalRow; }
    protected getService() { return TblSucursalService.baseUrl; }

    protected form = new TblSucursalForm(this.idPrefix);
}