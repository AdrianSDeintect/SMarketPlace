import { IntegerEditor, StringEditor, DateEditor, PrefixedContext } from "@serenity-is/corelib";
import { initFormType } from "@serenity-is/corelib/q";

export interface JobSucursalesForm {
    Idintegrador: IntegerEditor;
    NombreMp: StringEditor;
    Descripcion: StringEditor;
    Dias: StringEditor;
    Hora: StringEditor;
    Activo: IntegerEditor;
    FechaInicio: DateEditor;
    Diario: IntegerEditor;
}

export class JobSucursalesForm extends PrefixedContext {
    static formKey = 'JobMP.JobSucursales';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!JobSucursalesForm.init)  {
            JobSucursalesForm.init = true;

            var w0 = IntegerEditor;
            var w1 = StringEditor;
            var w2 = DateEditor;

            initFormType(JobSucursalesForm, [
                'Idintegrador', w0,
                'NombreMp', w1,
                'Descripcion', w1,
                'Dias', w1,
                'Hora', w1,
                'Activo', w0,
                'FechaInicio', w2,
                'Diario', w0
            ]);
        }
    }
}