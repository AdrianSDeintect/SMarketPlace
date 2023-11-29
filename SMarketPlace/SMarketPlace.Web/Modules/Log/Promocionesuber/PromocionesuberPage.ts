import { initFullHeightGridPage } from '@serenity-is/corelib/q';
import { PromocionesuberGrid } from './PromocionesuberGrid';

export default function pageInit() {
    initFullHeightGridPage(new PromocionesuberGrid($('#GridDiv')).element);
}