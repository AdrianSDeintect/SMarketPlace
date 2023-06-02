import { initFullHeightGridPage } from '@serenity-is/corelib/q';
import { TblSucursalRappiGrid } from './TblSucursalRappiGrid';

export default function pageInit() {
    initFullHeightGridPage(new TblSucursalRappiGrid($('#GridDiv')).element);
}