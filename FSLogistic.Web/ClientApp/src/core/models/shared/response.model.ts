export class ResponeModel {
    responeStatus: ResponeStatusEnum;
    message: string;
    data: any;
}

export enum ResponeStatusEnum {
    Successed = 1,
    Failed = 2,
    Existed = 3,
    NotExisted = 4,
}