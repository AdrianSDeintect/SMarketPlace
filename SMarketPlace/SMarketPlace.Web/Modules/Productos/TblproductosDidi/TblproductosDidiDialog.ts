import { Decorators, EntityDialog } from '@serenity-is/corelib';
import { TblproductosDidiForm, TblproductosDidiRow, TblproductosDidiService } from '../../ServerTypes/Productos';

@Decorators.registerClass('SMarketPlace.Productos.TblproductosDidiDialog')
export class TblproductosDidiDialog extends EntityDialog<TblproductosDidiRow, any> {


    //public dialogOpen(asPanel?: boolean): void {
    //    super.dialogOpen(asPanel);
    //    this.form.fkIdArticulo.element.focus();
    //}

    protected getFormKey() { return TblproductosDidiForm.formKey; }
    protected getIdProperty() { return TblproductosDidiRow.idProperty; }
    protected getLocalTextPrefix() { return TblproductosDidiRow.localTextPrefix; }
    protected getNameProperty() { return TblproductosDidiRow.nameProperty; }
    protected getService() { return TblproductosDidiService.baseUrl; }
    protected getModifyPermisison() { return TblproductosDidiRow.updatePermission; }
    protected getReadPermisison() { return TblproductosDidiRow.readPermission }
    protected getDeletePermission() { return TblproductosDidiRow.deletePermission; }
    protected getInsertPermission() { return TblproductosDidiRow.insertPermission; }
    protected getUpdatePermission() { return TblproductosDidiRow.updatePermission; }

    public form = new TblproductosDidiForm(this.idPrefix);

}