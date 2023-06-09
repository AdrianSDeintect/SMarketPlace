import { Decorators, EntityDialog } from '@serenity-is/corelib';
import { JobSucursalesForm, JobSucursalesRow, JobSucursalesService } from '../../ServerTypes/JobMP';

@Decorators.registerClass('SMarketPlace.JobMP.JobSucursalesDialog')
export class JobSucursalesDialog extends EntityDialog<JobSucursalesRow, any> {
    protected getFormKey() { return JobSucursalesForm.formKey; }
    protected getRowDefinition() { return JobSucursalesRow; }
    protected getService() { return JobSucursalesService.baseUrl; }

    protected form = new JobSucursalesForm(this.idPrefix);
}