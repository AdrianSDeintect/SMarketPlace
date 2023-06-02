import { ServiceRequest } from "@serenity-is/corelib/q";

export interface DeleteMultiRequest extends ServiceRequest {
    Ids?: string[];
}