import { initFullHeightGridPage } from '@serenity-is/corelib/q';
import { LogProcesosGrid } from './LogProcesosGrid';

export default function pageInit() {
    initFullHeightGridPage(new LogProcesosGrid($('#GridDiv')).element);
}