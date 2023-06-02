import { Decorators, EntityDialog } from '@serenity-is/corelib';
import { TblSucursalUberForm, TblSucursalUberRow, TblSucursalUberService } from '../../ServerTypes/Sucursales';

@Decorators.registerClass('SMarketPlace.Sucursales.TblSucursalUberDialog')
export class TblSucursalUberDialog extends EntityDialog<TblSucursalUberRow, any> {
    protected getFormKey() { return TblSucursalUberForm.formKey; }
    protected getRowDefinition() { return TblSucursalUberRow; }
    protected getService() { return TblSucursalUberService.baseUrl; }
    protected getModifyPermisison() { return TblSucursalUberRow.updatePermission; }
    protected getReadPermisison() { return TblSucursalUberRow.readPermission }
    protected getDeletePermission() { return TblSucursalUberRow.deletePermission; }
    protected getInsertPermission() { return TblSucursalUberRow.insertPermission; }
    protected getUpdatePermission() { return TblSucursalUberRow.updatePermission; }
    protected form = new TblSucursalUberForm(this.idPrefix);
}