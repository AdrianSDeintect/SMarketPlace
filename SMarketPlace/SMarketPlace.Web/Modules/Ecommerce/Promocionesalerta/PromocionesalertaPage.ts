import { initFullHeightGridPage } from '@serenity-is/corelib/q';
import { PromocionesalertaGrid } from './PromocionesalertaGrid';

export default function pageInit() {
    initFullHeightGridPage(new PromocionesalertaGrid($('#GridDiv')).element);
}