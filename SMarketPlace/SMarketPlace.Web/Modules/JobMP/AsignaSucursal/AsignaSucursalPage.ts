import { initFullHeightGridPage } from '@serenity-is/corelib/q';
import { AsignaSucursalGrid } from './AsignaSucursalGrid';

export default function pageInit() {
    initFullHeightGridPage(new AsignaSucursalGrid($('#GridDiv')).element);
}