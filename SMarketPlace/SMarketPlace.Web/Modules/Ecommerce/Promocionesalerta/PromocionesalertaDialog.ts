import { Decorators, EntityDialog } from '@serenity-is/corelib';
import { PromocionesalertaForm, PromocionesalertaRow, PromocionesalertaService } from '../../ServerTypes/Ecommerce';

@Decorators.registerClass('SMarketPlace.Ecommerce.PromocionesalertaDialog')
export class PromocionesalertaDialog extends EntityDialog<PromocionesalertaRow, any> {
    protected getFormKey() { return PromocionesalertaForm.formKey; }
    protected getRowDefinition() { return PromocionesalertaRow; }
    protected getService() { return PromocionesalertaService.baseUrl; }

    protected form = new PromocionesalertaForm(this.idPrefix);
}