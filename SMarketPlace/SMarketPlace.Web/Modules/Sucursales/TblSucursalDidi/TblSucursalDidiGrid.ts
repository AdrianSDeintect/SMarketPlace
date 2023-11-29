import { Decorators, EntityGrid, GridRowSelectionMixin, ToolButton } from '@serenity-is/corelib';
import { TblSucursalDidiColumns, TblSucursalDidiRow, TblSucursalDidiService } from '../../ServerTypes/Sucursales';
import { TblSucursalDidiDialog } from './TblSucursalDidiDialog';
import { ImportExcelSucursalesDialog } from 'Modules/ImportExcel/ImportExcelSucursalesDialog'
import { ExcelExportHelper, PdfExportHelper, ReportHelper } from "@serenity-is/extensions";
import { Column } from '@serenity-is/sleekgrid';

@Decorators.registerClass('SMarketPlace.Sucursales.TblSucursalDidiGrid')
export class TblSucursalDidiGrid extends EntityGrid<TblSucursalDidiRow, any> {

    private rowSelection: GridRowSelectionMixin;

    protected getColumnsKey() { return TblSucursalDidiColumns.columnsKey; }
    protected getDialogType() { return TblSucursalDidiDialog; }
    protected getRowDefinition() { return TblSucursalDidiRow; }
    protected getService() { return TblSucursalDidiService.baseUrl; }

    constructor(container: JQuery) {
        super(container);
        this.rowSelection = new GridRowSelectionMixin(this);
    }

    protected createToolbarExtensions() {
        super.createToolbarExtensions();
        this.rowSelection = new GridRowSelectionMixin(this);
    }

    protected getColumns() {
        var columns = super.getColumns();
        columns.splice(0, 0, GridRowSelectionMixin.createSelectColumn(() => this.rowSelection));
        return columns;
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

        buttons.push({
            title: "Eliminar",
            cssClass: "text-red",
            icon: "fa-times text-red",
            onClick: () => {
                let selectedKeys = this.rowSelection.getSelectedKeys();
                this.rowSelection.resetCheckedAndRefresh();
                if (selectedKeys != null && typeof selectedKeys != 'undefined' && selectedKeys.length > 0) {
                    Q.confirm(
                        "Confirma borrado de Sucursales ? ",
                        () => {
                            TblSucursalDidiService.DeleteMulti({ Ids: selectedKeys }, res => {
                                Q.notifySuccess("Sucursales Eliminadas");
                                this.refresh();
                            });
                        },
                        {
                            onNo: () => {
                                Q.notifyInfo("Sucursales no Eliminados");
                            },
                            onCancel: () => {
                                Q.notifyError("Operacion Cancelada");
                            },
                            dialogClass: 's-MessageDialog s-WarningDialog'
                        });
                }

                else {
                    Q.warning("Seleccionar una sucursal para eliminar");
                }
            }
        });

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