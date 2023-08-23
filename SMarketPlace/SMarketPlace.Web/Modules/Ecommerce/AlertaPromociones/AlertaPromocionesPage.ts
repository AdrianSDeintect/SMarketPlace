import { initFullHeightGridPage } from '@serenity-is/corelib/q';
import { AlertaPromocionesGrid } from './AlertaPromocionesGrid';

export default function pageInit() {
    initFullHeightGridPage(new AlertaPromocionesGrid($('#GridDiv')).element);
}