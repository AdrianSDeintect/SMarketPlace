import { Decorators, EntityGrid, ToolButton } from '@serenity-is/corelib';
import { PreciosStockRappiColumns, PreciosStockRappiRow, PreciosStockRappiService } from '../../ServerTypes/Log';
import { PreciosStockRappiDialog } from './PreciosStockRappiDialog';
import { ExcelExportHelper, PdfExportHelper, ReportHelper } from "@serenity-is/extensions";


@Decorators.registerClass('SMarketPlace.Log.PreciosStockRappiGrid')
export class PreciosStockRappiGrid extends EntityGrid<PreciosStockRappiRow, any> {
    protected getColumnsKey() { return PreciosStockRappiColumns.columnsKey; }
    protected getDialogType() { return PreciosStockRappiDialog; }
    protected getRowDefinition() { return PreciosStockRappiRow; }
    protected getService() { return PreciosStockRappiService.baseUrl; }

    constructor(container: JQuery) {
        super(container);
    }



    protected getButtons(): ToolButton[] {
        var buttons = super.getButtons();

        buttons.push(ExcelExportHelper.createToolButton({
            grid: this,
            service: PreciosStockRappiService.baseUrl + '/ListExcel',
            onViewSubmit: () => this.onViewSubmit(),
            separator: true
        }));

        buttons.push(PdfExportHelper.createToolButton({
            grid: this,
            onViewSubmit: () => this.onViewSubmit()
        }));




        return buttons;
    }
}