import { Decorators, EntityGrid, ToolButton } from '@serenity-is/corelib';
import { TblSucursalDidiColumns, TblSucursalDidiRow, TblSucursalDidiService } from '../../ServerTypes/Sucursales';
import { TblSucursalDidiDialog } from './TblSucursalDidiDialog';
import { ImportExcelSucursalesDialog } from 'Modules/ImportExcel/ImportExcelSucursalesDialog'
import { ExcelExportHelper, PdfExportHelper, ReportHelper } from "@serenity-is/extensions";

@Decorators.registerClass('SMarketPlace.Sucursales.TblSucursalDidiGrid')
export class TblSucursalDidiGrid extends EntityGrid<TblSucursalDidiRow, any> {
    protected getColumnsKey() { return TblSucursalDidiColumns.columnsKey; }
    protected getDialogType() { return TblSucursalDidiDialog; }
    protected getRowDefinition() { return TblSucursalDidiRow; }
    protected getService() { return TblSucursalDidiService.baseUrl; }

    constructor(container: JQuery) {
        super(container);
    }

    protected getButtons(): ToolButton[] {
        var buttons = super.getButtons();

        buttons.push(ExcelExportHelper.createToolButton({
            grid: this,
            service: TblSucursalDidiService.baseUrl + '/ListExcel',
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
                var dialog = new ImportExcelSucursalesDialog({
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