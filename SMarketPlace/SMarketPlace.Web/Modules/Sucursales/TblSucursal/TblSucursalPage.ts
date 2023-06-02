import { initFullHeightGridPage } from '@serenity-is/corelib/q';
import { TblSucursalGrid } from './TblSucursalGrid';

export default function pageInit() {
    initFullHeightGridPage(new TblSucursalGrid($('#GridDiv')).element);
}