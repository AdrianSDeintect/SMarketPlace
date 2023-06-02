import { initFullHeightGridPage } from '@serenity-is/corelib/q';
import { TblArticuloGrid } from './TblArticuloGrid';

export default function pageInit() {
    initFullHeightGridPage(new TblArticuloGrid($('#GridDiv')).element);
}