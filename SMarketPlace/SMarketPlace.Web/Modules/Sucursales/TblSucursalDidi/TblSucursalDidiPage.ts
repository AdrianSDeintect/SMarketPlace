import { initFullHeightGridPage } from '@serenity-is/corelib/q';
import { TblSucursalDidiGrid } from './TblSucursalDidiGrid';

export default function pageInit() {
    initFullHeightGridPage(new TblSucursalDidiGrid($('#GridDiv')).element);
}