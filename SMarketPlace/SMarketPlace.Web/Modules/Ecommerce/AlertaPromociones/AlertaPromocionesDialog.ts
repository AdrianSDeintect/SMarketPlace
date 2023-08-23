import { Decorators, EntityDialog } from '@serenity-is/corelib';
import { AlertaPromocionesForm, AlertaPromocionesRow, AlertaPromocionesService } from '../../ServerTypes/Ecommerce';

@Decorators.registerClass('SMarketPlace.Ecommerce.AlertaPromocionesDialog')
export class AlertaPromocionesDialog extends EntityDialog<AlertaPromocionesRow, any> {
    protected getFormKey() { return AlertaPromocionesForm.formKey; }
    protected getRowDefinition() { return AlertaPromocionesRow; }
    protected getService() { return AlertaPromocionesService.baseUrl; }

    protected form = new AlertaPromocionesForm(this.idPrefix);
}