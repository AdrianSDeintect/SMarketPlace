import { Decorators, EntityDialog } from '@serenity-is/corelib';
import { DialogButton } from '@serenity-is/corelib/q';
import { ImportExcelForm } from 'Modules/ServerTypes/Web';
import { TblSucursalDidiService, TblSucursalRappiService, TblSucursalUberService } from '../ServerTypes/Sucursales';
/*import { TblproductosDidiImportExcelForm } from '../ImportExcel/';*/

@Decorators.registerClass('SMarketPlace.ImportExcelSucursalesDialog')
export class ImportExcelSucursalesDialog extends EntityDialog<any, any> {

    protected getFormKey() { return ImportExcelForm.formKey; }
 /*   protected getService() { return TblproductosDidiService.baseUrl; }*/


/*    private form: Forms.TblproductosDidiGridForm;*/

    protected form = new ImportExcelForm(this.idPrefix);
    public TipoMP = '' ;

    constructor(TipoMP: any) {
        super();

        this.TipoMP = TipoMP
        this.form = new ImportExcelForm(this.idPrefix);
    }

    protected getDialogTitle(): string {
        return "Excel Import";
    }

    protected getDialogButtons(): DialogButton[] {
        return [
            {
                text: 'Import',
                click: () => {
                    if (!this.validateBeforeSave())
                        return;

                    if (this.form.FileName.value == null ||

                        Q.isEmptyOrNull(this.form.FileName.value.Filename)) {
                        Q.notifyError("Please select a file!");
                        return;
                    }
                    if (this.TipoMP == "Didi") {
                        TblSucursalDidiService.ExcelImport({
                            FileName: this.form.FileName.value.Filename,
                        }, response => {
                            Q.notifyInfo(
                                'Inserted: ' + (response.Inserted || 0));
                              /*  ', Updated: ' + (response.Updated || 0));*/

                            if (response.ErrorList != null && response.ErrorList.length > 0) {
                                Q.notifyError(response.ErrorList.join(',\r\n '));
                            }

                            this.dialogClose();
                        });
                    } else if (this.TipoMP == "Rappi") {
                        TblSucursalRappiService.ExcelImport({
                            FileName: this.form.FileName.value.Filename,
                        }, response => {
                            Q.notifyInfo(
                                'Inserted: ' + (response.Inserted || 0));
                                /*', Updated: ' + (response.Updated || 0));*/

                            if (response.ErrorList != null && response.ErrorList.length > 0) {
                                Q.notifyError(response.ErrorList.join(',\r\n '));
                            }

                            this.dialogClose();
                        });
                    } else if (this.TipoMP == "Uber") {
                        TblSucursalUberService.ExcelImport({
                            FileName: this.form.FileName.value.Filename,
                        }, response => {
                            Q.notifyInfo(
                                'Inserted: ' + (response.Inserted || 0));
                          /*      ', Updated: ' + (response.Updated || 0));*/

                            if (response.ErrorList != null && response.ErrorList.length > 0) {
                                Q.notifyError(response.ErrorList.join(',\r\n '));
                            }

                            this.dialogClose();
                        });
                    }

                    
                },
            },
            {
                text: 'Cancel',
                click: () => this.dialogClose()
            }
        ];
    }

}