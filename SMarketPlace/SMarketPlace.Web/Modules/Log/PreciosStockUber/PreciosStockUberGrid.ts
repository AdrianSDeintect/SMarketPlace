import { Decorators, EntityGrid, ToolButton } from '@serenity-is/corelib';
import { PreciosStockUberColumns, PreciosStockUberRow, PreciosStockUberService } from '../../ServerTypes/Log';
import { PreciosStockUberDialog } from './PreciosStockUberDialog';
import { ExcelExportHelper, PdfExportHelper, ReportHelper } from "@serenity-is/extensions";

@Decorators.registerClass('SMarketPlace.Log.PreciosStockUberGrid')
export class PreciosStockUberGrid extends EntityGrid<PreciosStockUberRow, any> {
    protected getColumnsKey() { return PreciosStockUberColumns.columnsKey; }
    protected getDialogType() { return PreciosStockUberDialog; }
    protected getRowDefinition() { return PreciosStockUberRow; }
    protected getService() { return PreciosStockUberService.baseUrl; }

    constructor(container: JQuery) {
        super(container);
    }



    protected getButtons(): ToolButton[] {
        var buttons = super.getButtons();

        buttons.push(ExcelExportHelper.createToolButton({
            grid: this,
            service: PreciosStockUberService.baseUrl + '/ListExcel',
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