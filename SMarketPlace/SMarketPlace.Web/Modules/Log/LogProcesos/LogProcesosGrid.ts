import { Decorators, EntityGrid, ToolButton } from '@serenity-is/corelib';
import { LogProcesosColumns, LogProcesosRow, LogProcesosService } from '../../ServerTypes/Log';
import { LogProcesosDialog } from './LogProcesosDialog';

@Decorators.registerClass('SMarketPlace.Log.LogProcesosGrid')
export class LogProcesosGrid extends EntityGrid<LogProcesosRow, any> {
    protected getColumnsKey() { return LogProcesosColumns.columnsKey; }
    protected getDialogType() { return LogProcesosDialog; }
    protected getRowDefinition() { return LogProcesosRow; }
    protected getService() { return LogProcesosService.baseUrl; }

    constructor(container: JQuery) {
        super(container);
    }


    //protected getButtons() {
    //    return [{
    //        title: 'Perform Bulk Action on Selected Orders',
    //        cssClass: 'send-button'

    //    }];
    //}
    //protected getToolbarButtons() {
    //    return [];
    //}


    protected getButtons(): ToolButton[] {
        var buttons = super.getButtons();

        //buttons.splice(Q.indexOf(buttons, x => x.cssClass == "save-and-close-button"), 1);
        //buttons.splice(Q.indexOf(buttons, x => x.cssClass == "apply-changes-button"), 1);
        //buttons.splice(Q.indexOf(buttons, x => x.cssClass == "delete-button"), 1);
        //buttons.splice(Q.indexOf(buttons, x => x.cssClass == "undo-delete-button"), 1);
        //buttons.splice(Q.indexOf(buttons, x => x.cssClass == "clone-button"), 1);
        //buttons.splice(Q.indexOf(buttons, x => x.cssClass == "add-button"), 1);

        //buttons[Q.indexOf(buttons, x => x.cssClass == "add-button")].cssClass += " disabled";
        //buttons[Q.indexOf(buttons, x => x.cssClass == "delete-button")].cssClass += " disabled";
        //buttons[Q.indexOf(buttons, x => x.cssClass == "save-and-close-button")].cssClass += " disabled";
        //buttons[Q.indexOf(buttons, x => x.cssClass == "apply-changes-button")].cssClass += " disabled";
        //buttons[Q.indexOf(buttons, x => x.cssClass == "undo-delete-button")].cssClass += " disabled";


        return buttons;
    }




    }




