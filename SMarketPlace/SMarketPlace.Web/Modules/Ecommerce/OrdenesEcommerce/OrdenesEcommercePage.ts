import { initFullHeightGridPage } from '@serenity-is/corelib/q';
import { OrdenesEcommerceGrid } from './OrdenesEcommerceGrid';

export default function pageInit() {
    initFullHeightGridPage(new OrdenesEcommerceGrid($('#GridDiv')).element);
}