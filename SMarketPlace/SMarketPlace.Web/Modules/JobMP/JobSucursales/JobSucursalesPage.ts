import { initFullHeightGridPage } from '@serenity-is/corelib/q';
import { JobSucursalesGrid } from './JobSucursalesGrid';

export default function pageInit() {
    initFullHeightGridPage(new JobSucursalesGrid($('#GridDiv')).element);
}