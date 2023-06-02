import { StringEditor, IntegerEditor, PrefixedContext } from "@serenity-is/corelib";
import { initFormType } from "@serenity-is/corelib/q";

export interface TblSucursalForm {
    LocalSap: StringEditor;
    NombreSuc: StringEditor;
    Direccion: StringEditor;
    Codigopostal: StringEditor;
    Pais: IntegerEditor;
    Ciudad: IntegerEditor;
    Estado: IntegerEditor;
    Region: IntegerEditor;
    Zona: IntegerEditor;
}

export class TblSucursalForm extends PrefixedContext {
    static formKey = 'Sucursales.TblSucursal';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!TblSucursalForm.init)  {
            TblSucursalForm.init = true;

            var w0 = StringEditor;
            var w1 = IntegerEditor;

            initFormType(TblSucursalForm, [
                'LocalSap', w0,
                'NombreSuc', w0,
                'Direccion', w0,
                'Codigopostal', w0,
                'Pais', w1,
                'Ciudad', w1,
                'Estado', w1,
                'Region', w1,
                'Zona', w1
            ]);
        }
    }
}