import { Decorators, EntityDialog } from '@serenity-is/corelib';
import { TblArticuloForm, TblArticuloRow, TblArticuloService } from '../../ServerTypes/Productos';

@Decorators.registerClass('SMarketPlace.Productos.TblArticuloDialog')
export class TblArticuloDialog extends EntityDialog<TblArticuloRow, any> {
    protected getFormKey() { return TblArticuloForm.formKey; }
    protected getRowDefinition() { return TblArticuloRow; }
    protected getService() { return TblArticuloService.baseUrl; }

    protected form = new TblArticuloForm(this.idPrefix);
}