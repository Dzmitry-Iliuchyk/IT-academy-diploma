
export class Person implements IPerson {
    id: string="";
    name: string="";
    story: string="";
}

export interface IPerson {
    id: string,
    name: string,
    story: string
}

export interface IPersonsApi {
    products: IPerson[]
}