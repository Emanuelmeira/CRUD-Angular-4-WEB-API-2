import { Knowledge } from "app/model/knowlodge.model";
import { BankInf } from "app/model/bankInf.model";

export class Developer {

    constructor() { 
        this.BankInf = new BankInf();
        this.Knowledge = new Knowledge();
    }

    Id: number

    Email: string
    Name: string
    Skype: string
    Phone: string
    Linkedin: string
    City: string
    State: string
    Portfolio: string
    
    HourUntilFour: boolean;
    HourFourToSix: boolean;
    HourFourToEight: boolean;
    HourAboveEight: boolean;
    HoursOfWeekend: boolean;

    MorningPeriod: boolean;
    AfternoonPeriod: boolean;
    NightPeriod: boolean;
    DawnPeriod: boolean;
    BusinessPeriod: boolean;

    Pretension: number    

    Bank: string

    Crud: string
    
    Knowledge: Knowledge
    BankInf: BankInf
}