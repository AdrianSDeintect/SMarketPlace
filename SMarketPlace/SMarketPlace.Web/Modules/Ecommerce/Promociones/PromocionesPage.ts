import { initFullHeightGridPage } from '@serenity-is/corelib/q';
import { PromocionesGrid } from './PromocionesGrid';

export default function pageInit() {
    initFullHeightGridPage(new PromocionesGrid($('#GridDiv')).element);
}