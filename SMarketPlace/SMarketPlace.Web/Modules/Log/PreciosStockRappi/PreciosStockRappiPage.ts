import { initFullHeightGridPage } from '@serenity-is/corelib/q';
import { PreciosStockRappiGrid } from './PreciosStockRappiGrid';

export default function pageInit() {
    initFullHeightGridPage(new PreciosStockRappiGrid($('#GridDiv')).element);
}