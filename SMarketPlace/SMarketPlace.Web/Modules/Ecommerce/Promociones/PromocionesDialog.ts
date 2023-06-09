import { Decorators, EntityDialog } from '@serenity-is/corelib';
import { PromocionesForm, PromocionesRow, PromocionesService } from '../../ServerTypes/Ecommerce';

@Decorators.registerClass('SMarketPlace.Ecommerce.PromocionesDialog')
export class PromocionesDialog extends EntityDialog<PromocionesRow, any> {
    protected getFormKey() { return PromocionesForm.formKey; }
    protected getRowDefinition() { return PromocionesRow; }
    protected getService() { return PromocionesService.baseUrl; }

    protected form = new PromocionesForm(this.idPrefix);
}