import { initFullHeightGridPage } from '@serenity-is/corelib/q';
import { PreciosStockUberGrid } from './PreciosStockUberGrid';

export default function pageInit() {
    initFullHeightGridPage(new PreciosStockUberGrid($('#GridDiv')).element);
}