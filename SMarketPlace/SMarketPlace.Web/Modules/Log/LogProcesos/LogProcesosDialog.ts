import { Decorators, EntityDialog } from '@serenity-is/corelib';
import { LogProcesosForm, LogProcesosRow, LogProcesosService } from '../../ServerTypes/Log';

@Decorators.registerClass('SMarketPlace.Log.LogProcesosDialog')
export class LogProcesosDialog extends EntityDialog<LogProcesosRow, any> {
    protected getFormKey() { return LogProcesosForm.formKey; }
    protected getRowDefinition() { return LogProcesosRow; }
    protected getService() { return LogProcesosService.baseUrl; }

    protected form: LogProcesosForm;

    constructor() {
        super();



        this.form = new LogProcesosForm(this.idPrefix);
        if (this.form.Activo.value = 1) {
            this.form.Descripcion.value = "Proceso Activo" 
        }


        if (this.form.Activo.value = 0) {
            this.form.Descripcion.value = "Proceso Terminado"
        }




    }

}