import { StringEditor, IntegerEditor, DecimalEditor, PrefixedContext } from "@serenity-is/corelib";
import { initFormType } from "@serenity-is/corelib/q";

export interface TblArticuloForm {
    Nombrearticulo: StringEditor;
    Categorialealtad: IntegerEditor;
    Division: StringEditor;
    Categoria: StringEditor;
    Subcategoria: StringEditor;
    Grupo: StringEditor;
    Proveedor: StringEditor;
    Iva: DecimalEditor;
    Codbar: StringEditor;
    ParametroProducto: StringEditor;
    MapMod: StringEditor;
    Precio: DecimalEditor;
}

export class TblArticuloForm extends PrefixedContext {
    static formKey = 'Productos.TblArticulo';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!TblArticuloForm.init)  {
            TblArticuloForm.init = true;

            var w0 = StringEditor;
            var w1 = IntegerEditor;
            var w2 = DecimalEditor;

            initFormType(TblArticuloForm, [
                'Nombrearticulo', w0,
                'Categorialealtad', w1,
                'Division', w0,
                'Categoria', w0,
                'Subcategoria', w0,
                'Grupo', w0,
                'Proveedor', w0,
                'Iva', w2,
                'Codbar', w0,
                'ParametroProducto', w0,
                'MapMod', w0,
                'Precio', w2
            ]);
        }
    }
}