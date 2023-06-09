import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { JobSucursalesColumns, JobSucursalesRow, JobSucursalesService } from '../../ServerTypes/JobMP';
import { JobSucursalesDialog } from './JobSucursalesDialog';

@Decorators.registerClass('SMarketPlace.JobMP.JobSucursalesGrid')
export class JobSucursalesGrid extends EntityGrid<JobSucursalesRow, any> {
    protected getColumnsKey() { return JobSucursalesColumns.columnsKey; }
    protected getDialogType() { return JobSucursalesDialog; }
    protected getRowDefinition() { return JobSucursalesRow; }
    protected getService() { return JobSucursalesService.baseUrl; }

    constructor(container: JQuery) {
        super(container);
    }
}