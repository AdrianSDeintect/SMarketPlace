
import { Decorators, Select2Editor } from '@serenity-is/corelib';

namespace SMarketPlace.Web.Modules.Ecommerce.ActualizarPedido
{
    @Decorators.registerEditor('SMarketPlace.Ecommerce.TipoPedidos')
    export class TipoPedidos extends Select2Editor<any, any>
        {
            constructor(hidden: JQuery) {
                super(hidden, null);
                this.addItem({ id: "Pending", text: "Pending" });
                this.addItem({ id: "Issued", text: "Issued" });
                this.addItem({ id: "Denied", text: "Denied" });
            }
        
    }
}
