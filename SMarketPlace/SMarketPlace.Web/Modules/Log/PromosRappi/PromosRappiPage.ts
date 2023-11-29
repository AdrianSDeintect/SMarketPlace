import { initFullHeightGridPage } from '@serenity-is/corelib/q';
import { PromosRappiGrid } from './PromosRappiGrid';

export default function pageInit() {
    initFullHeightGridPage(new PromosRappiGrid($('#GridDiv')).element);
}