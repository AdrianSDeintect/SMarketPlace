import { Decorators, EntityGrid, ToolButton } from '@serenity-is/corelib';
import { PromocionesuberColumns, PromocionesuberRow, PromocionesuberService } from '../../ServerTypes/Log';
import { PromocionesuberDialog } from './PromocionesuberDialog';
import { ExcelExportHelper, PdfExportHelper, ReportHelper } from "@serenity-is/extensions";


@Decorators.registerClass('SMarketPlace.Log.PromocionesuberGrid')
export class PromocionesuberGrid extends EntityGrid<PromocionesuberRow, any> {
    protected getColumnsKey() { return PromocionesuberColumns.columnsKey; }
    protected getDialogType() { return PromocionesuberDialog; }
    protected getRowDefinition() { return PromocionesuberRow; }
    protected getService() { return PromocionesuberService.baseUrl; }

    constructor(container: JQuery) {
        super(container);
    }




    protected getButtons(): ToolButton[] {
        var buttons = super.getButtons();

        buttons.push(ExcelExportHelper.createToolButton({
            grid: this,
            service: PromocionesuberService.baseUrl + '/ListExcel',
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