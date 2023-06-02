import { Decorators, EntityDialog } from '@serenity-is/corelib';
import { TblproductosRappiForm, TblproductosRappiRow, TblproductosRappiService } from '../../ServerTypes/Productos';

@Decorators.registerClass('SMarketPlace.Productos.TblproductosRappiDialog')
export class TblproductosRappiDialog extends EntityDialog<TblproductosRappiRow, any> {
    protected getFormKey() { return TblproductosRappiForm.formKey; }
    protected getRowDefinition() { return TblproductosRappiRow; }
    protected getService() { return TblproductosRappiService.baseUrl; }
    protected getModifyPermisison() { return TblproductosRappiRow.updatePermission; }
    protected getReadPermisison() { return TblproductosRappiRow.readPermission }
    protected getDeletePermission() { return TblproductosRappiRow.deletePermission; }
    protected getInsertPermission() { return TblproductosRappiRow.insertPermission; }
    protected getUpdatePermission() { return TblproductosRappiRow.updatePermission; }

    protected form = new TblproductosRappiForm(this.idPrefix);
}