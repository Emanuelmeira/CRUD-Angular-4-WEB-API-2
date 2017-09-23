import { Knowledge } from "app/model/knowlodge.model";
import { BankInformation } from "app/model/bankInformation.model";

export class Developer {

    constructor() {        
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
    
    HourUntilFour: boolean
    HourFourToSix: boolean
    HourFourToEight: boolean
    HourAboveEight: boolean
    HoursOfWeekend: boolean
    MorningPeriod: boolean
    AfternoonPeriod: boolean
    NightPeriod: boolean
    DawnPeriod: boolean
    
    Pretension: number    
    Crud: string
    
    Knowledge: Knowledge
    BankInformation: BankInformation
}