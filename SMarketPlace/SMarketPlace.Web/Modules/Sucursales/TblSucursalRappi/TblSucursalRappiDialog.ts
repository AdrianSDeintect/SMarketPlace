import { Decorators, EntityDialog } from '@serenity-is/corelib';
import { TblSucursalRappiForm, TblSucursalRappiRow, TblSucursalRappiService } from '../../ServerTypes/Sucursales';

@Decorators.registerClass('SMarketPlace.Sucursales.TblSucursalRappiDialog')
export class TblSucursalRappiDialog extends EntityDialog<TblSucursalRappiRow, any> {
    protected getFormKey() { return TblSucursalRappiForm.formKey; }
    protected getRowDefinition() { return TblSucursalRappiRow; }
    protected getService() { return TblSucursalRappiService.baseUrl; }
    protected getModifyPermisison() { return TblSucursalRappiRow.updatePermission; }
    protected getReadPermisison() { return TblSucursalRappiRow.readPermission }
    protected getDeletePermission() { return TblSucursalRappiRow.deletePermission; }
    protected getInsertPermission() { return TblSucursalRappiRow.insertPermission; }
    protected getUpdatePermission() { return TblSucursalRappiRow.updatePermission; }

    protected form = new TblSucursalRappiForm(this.idPrefix);
}