import { Decorators, EntityGrid, GridRowSelectionMixin, ToolButton } from '@serenity-is/corelib';
import { TblproductosUberColumns, TblproductosUberRow, TblproductosUberService } from '../../ServerTypes/Productos';
import { TblproductosUberDialog } from './TblproductosUberDialog';
import { ImportExcelDialog } from 'Modules/ImportExcel/ImportExcelDialog'
import { ExcelExportHelper, PdfExportHelper, ReportHelper } from "@serenity-is/extensions";
import { Column } from '@serenity-is/sleekgrid';


@Decorators.registerClass('SMarketPlace.Productos.TblproductosUberGrid')
export class TblproductosUberGrid extends EntityGrid<TblproductosUberRow, any> {

    private rowSelection: GridRowSelectionMixin;

    protected getColumnsKey() { return TblproductosUberColumns.columnsKey; }
    protected getDialogType() { return TblproductosUberDialog; }
    protected getRowDefinition() { return TblproductosUberRow; }
    protected getService() { return TblproductosUberService.baseUrl; }

    constructor(container: JQuery) {
        super(container);
        this.rowSelection = new GridRowSelectionMixin(this);
    }

    protected getColumns(): Column[] {
        let columns = super.getColumns();
        /*        let extOptions = this.get_ExtGridOptions();*/
        columns.splice(0, 0, GridRowSelectionMixin.createSelectColumn(() => this.rowSelection));
        return columns;
    }

    protected getButtons(): ToolButton[] {
        var buttons = super.getButtons();

        buttons.push(ExcelExportHelper.createToolButton({
            grid: this,
            service: TblproductosUberService.baseUrl + '/ListExcel',
            onViewSubmit: () => this.onViewSubmit(),
            separator: true
        }));

        buttons.push(PdfExportHelper.createToolButton({
            grid: this,
            onViewSubmit: () => this.onViewSubmit()
        }));

        /*	if (Q.Authorization.hasPermission(this.getModifyPermisison())) {*/
        buttons.push({
            title: "Eliminar",
            cssClass: "text-red",
            icon: "fa-times text-red",
            onClick: () => {
                let selectedKeys = this.rowSelection.getSelectedKeys();
                if (selectedKeys != null && typeof selectedKeys != 'undefined' && selectedKeys.length > 0) {
                    Q.confirm(
                        "Confirma borrado de Productos ? ",
                        () => {
                            TblproductosUberService.DeleteMulti({ Ids: selectedKeys }, res => {
                                Q.notifySuccess("Productos Eliminados");
                                this.refresh();
                            });
                        },
                        {
                            onNo: () => {
                                Q.notifyInfo("Productos no Eliminados");
                            },
                            onCancel: () => {
                                Q.notifyError("Operacion Cancelada");
                            },
                            dialogClass: 's-MessageDialog s-WarningDialog'
                        });
                }

                else {
                    Q.warning("Seleccionar un producto para eliminar");
                }
            }
        });
			/*}*/

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
                dialog.TipoMP = 'Uber'
                dialog.dialogOpen();
            }
        });

        return buttons;
    }
}