import { initFullHeightGridPage } from '@serenity-is/corelib/q';
import { TblproductosRappiGrid } from './TblproductosRappiGrid';

export default function pageInit() {
    initFullHeightGridPage(new TblproductosRappiGrid($('#GridDiv')).element);
}