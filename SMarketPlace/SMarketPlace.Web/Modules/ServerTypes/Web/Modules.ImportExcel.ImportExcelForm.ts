import { ImageUploadEditor, PrefixedContext } from "@serenity-is/corelib";
import { initFormType } from "@serenity-is/corelib/q";

export interface ImportExcelForm {
    FileName: ImageUploadEditor;
}

export class ImportExcelForm extends PrefixedContext {
    static formKey = 'Modules.ImportExcel';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!ImportExcelForm.init)  {
            ImportExcelForm.init = true;

            var w0 = ImageUploadEditor;

            initFormType(ImportExcelForm, [
                'FileName', w0
            ]);
        }
    }
}