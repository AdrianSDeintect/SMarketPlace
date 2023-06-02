import { initFullHeightGridPage } from '@serenity-is/corelib/q';
import { TblproductosUberGrid } from './TblproductosUberGrid';

export default function pageInit() {
    initFullHeightGridPage(new TblproductosUberGrid($('#GridDiv')).element);
}