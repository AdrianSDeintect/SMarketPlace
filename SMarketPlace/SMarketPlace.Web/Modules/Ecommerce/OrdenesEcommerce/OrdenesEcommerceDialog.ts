import { Decorators, EntityDialog } from '@serenity-is/corelib';
import { OrdenesEcommerceForm, OrdenesEcommerceRow, OrdenesEcommerceService } from '../../ServerTypes/Ecommerce';

@Decorators.registerClass('SMarketPlace.Ecommerce.OrdenesEcommerceDialog')
export class OrdenesEcommerceDialog extends EntityDialog<OrdenesEcommerceRow, any> {
    protected getFormKey() { return OrdenesEcommerceForm.formKey; }
    protected getRowDefinition() { return OrdenesEcommerceRow; }
    protected getService() { return OrdenesEcommerceService.baseUrl; }

    protected form = new OrdenesEcommerceForm(this.idPrefix);
}