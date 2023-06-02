import { initFullHeightGridPage } from '@serenity-is/corelib/q';
import { TblproductosDidiGrid } from './TblproductosDidiGrid';

export default function pageInit() {
    initFullHeightGridPage(new TblproductosDidiGrid($('#GridDiv')).element);
}