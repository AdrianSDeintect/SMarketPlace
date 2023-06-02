import { initFullHeightGridPage } from '@serenity-is/corelib/q';
import { TblSucursalUberGrid } from './TblSucursalUberGrid';

export default function pageInit() {
    initFullHeightGridPage(new TblSucursalUberGrid($('#GridDiv')).element);
}