import { Decorators, EntityGrid, ToolButton } from '@serenity-is/corelib';
import { TblproductosDidiColumns, TblproductosDidiRow, TblproductosDidiService } from '../../ServerTypes/Productos';
import { TblproductosDidiDialog } from './TblproductosDidiDialog';
import { ImportExcelDialog } from 'Modules/ImportExcel/ImportExcelDialog'
import { ExcelExportHelper, PdfExportHelper, ReportHelper } from "@serenity-is/extensions";

@Decorators.registerClass('SMarketPlace.Productos.TblproductosDidiGrid')
export class TblproductosDidiGrid extends EntityGrid<TblproductosDidiRow, any> {
    protected getColumnsKey() { return TblproductosDidiColumns.columnsKey; }
    protected getDialogType() { return TblproductosDidiDialog; }
    protected getRowDefinition() { return TblproductosDidiRow; }
    protected getService() { return TblproductosDidiService.baseUrl; }

    constructor(container: JQuery) {
        super(container);
    }
    protected getButtons(): ToolButton[] {
        var buttons = super.getButtons();

        buttons.push(ExcelExportHelper.createToolButton({
            grid: this,
            service: TblproductosDidiService.baseUrl + '/ListExcel',
            onViewSubmit: () => this.onViewSubmit(),
            separator: true
        }));

        buttons.push(PdfExportHelper.createToolButton({
            grid: this,
            onViewSubmit: () => this.onViewSubmit()
        }));


        // add our import button
        buttons.push({
            title: 'Import From Excel',
            cssClass: 'export-xlsx-button',
            onClick: () => {
                // open import dialog, let it handle rest
                var dialog = new ImportExcelDialog({
                });
                dialog.element.on('dialogclose', () => {
                    this.refresh();
                    dialog = null;
                });
                dialog.TipoMP = 'Didi'
                dialog.dialogOpen();
                
            }
        });

        return buttons;
    }
}