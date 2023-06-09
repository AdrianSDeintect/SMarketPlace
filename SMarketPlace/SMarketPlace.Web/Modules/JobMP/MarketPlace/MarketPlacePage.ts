import { initFullHeightGridPage } from '@serenity-is/corelib/q';
import { MarketPlaceGrid } from './MarketPlaceGrid';

export default function pageInit() {
    initFullHeightGridPage(new MarketPlaceGrid($('#GridDiv')).element);
}