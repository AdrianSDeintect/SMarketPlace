import { Decorators, EntityDialog } from '@serenity-is/corelib';
import { TblproductosUberForm, TblproductosUberRow, TblproductosUberService } from '../../ServerTypes/Productos';

@Decorators.registerClass('SMarketPlace.Productos.TblproductosUberDialog')
export class TblproductosUberDialog extends EntityDialog<TblproductosUberRow, any> {
    protected getFormKey() { return TblproductosUberForm.formKey; }
    protected getRowDefinition() { return TblproductosUberRow; }
    protected getService() { return TblproductosUberService.baseUrl; }
    protected getModifyPermisison() { return TblproductosUberRow.updatePermission; }
    protected getReadPermisison() { return TblproductosUberRow.readPermission }
    protected getDeletePermission() { return TblproductosUberRow.deletePermission; }
    protected getInsertPermission() { return TblproductosUberRow.insertPermission; }
    protected getUpdatePermission() { return TblproductosUberRow.updatePermission; }
    protected form = new TblproductosUberForm(this.idPrefix);
}