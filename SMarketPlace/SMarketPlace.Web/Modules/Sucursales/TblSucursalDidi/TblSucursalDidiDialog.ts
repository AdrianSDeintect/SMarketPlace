import { Decorators, EntityDialog } from '@serenity-is/corelib';
import { TblSucursalDidiForm, TblSucursalDidiRow, TblSucursalDidiService } from '../../ServerTypes/Sucursales';

@Decorators.registerClass('SMarketPlace.Sucursales.TblSucursalDidiDialog')
export class TblSucursalDidiDialog extends EntityDialog<TblSucursalDidiRow, any> {
    protected getFormKey() { return TblSucursalDidiForm.formKey; }
    protected getRowDefinition() { return TblSucursalDidiRow; }
    protected getService() { return TblSucursalDidiService.baseUrl; }
    protected getModifyPermisison() { return TblSucursalDidiRow.updatePermission; }
    protected getReadPermisison() { return TblSucursalDidiRow.readPermission }
    protected getDeletePermission() { return TblSucursalDidiRow.deletePermission; }
    protected getInsertPermission() { return TblSucursalDidiRow.insertPermission; }
    protected getUpdatePermission() { return TblSucursalDidiRow.updatePermission; }

    protected form = new TblSucursalDidiForm(this.idPrefix);
}