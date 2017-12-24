import { Knowledge } from "app/model/knowlodge.model";
import { BankInf } from "app/model/bankInf.model";

export class Developer {

    constructor() { 
        this.bankInf = new BankInf();
        this.knowledge = new Knowledge();
    }

    id: number

    email: string
    name: string
    skype: string
    phone: string
    linkedin: string
    city: string
    state: string
    portfolio: string
    
    hourUntilFour: boolean;
    hourFourToSix: boolean;
    hourFourToEight: boolean;
    hourAboveEight: boolean;
    hoursOfWeekend: boolean;

    morningPeriod: boolean;
    afternoonPeriod: boolean;
    nightPeriod: boolean;
    dawnPeriod: boolean;
    businessPeriod: boolean;

    pretension: number    

    bank: string

    crud: string
    
    knowledge: Knowledge
    bankInf: BankInf
}