import { Component, OnInit } from '@angular/core';
import { FormGroup, FormBuilder, FormControl, Validators } from '@angular/forms';
import { DeveloperService } from 'app/model/developer.service';
import { Router, ActivatedRoute, Params } from "@angular/router";
import { Developer } from 'app/model/developer.model';
import { Response} from "@angular/http";
import { TabsetComponent } from 'ngx-bootstrap';


@Component({
  selector: 'app-form',
  templateUrl: './form.component.html',
  styleUrls: ['./form.component.css']
})
export class FormComponent implements OnInit {
  
  form: FormGroup;  
  developer = new Developer();
  title: string;
  id: number = 0;
 
  constructor(
    private formBuilder: FormBuilder,    
    private DeveloperService: DeveloperService,
    private activatedRoute: ActivatedRoute,
    private router: Router
  ) { } 

  ngOnInit(){

    this.activatedRoute.params.subscribe((params: Params) => {
      this.id = params['id'];
    });  
       

        this.form = this.formBuilder.group({
          // page 1
          email: [null],
          name: [null],          
          skype: [null],
          phone: [null],
          linkedin: [null],
          city: [null],
          state: [null],
          portfolio: [null], 

          hourUntilFour: [null],
          hourFourToSix: [null],
          hourFourToEight: [null],
          hourAboveEight: [null],
          hoursOfWeekend: [null], 

          morningPeriod: [null],
          afternoonPeriod: [null],
          nightPeriod: [null],
          dawnPeriod: [null],
          businessPeriod: [null],

          pretension: [null],

          bank: [null],

          //page 2
          bankInf_name: [null],
          bankInf_cpf:  [null],
          bankInf_bank:  [null],
          bankInf_agency:  [null],
          bankInf_account:  [null],
          bankInf_chain:  [null],
          bankInf_savings:  [null],

          //page 3
          ionic: [null],
          android: [null],
          ios: [null],
          html: [null],
          css: [null],

          bootstrap: [null],
          jquery: [null],
          angularJs: [null],
          java: [null],
          aspnet: [null],

          c: [null],
          cplusplus: [null],
          cake: [null],
          django: [null],
          majento: [null],
        
          php: [null],
          wordpress: [null],
          phyton: [null],
          ruby: [null],
          sqlServer: [null],
        
          mySql: [null],
          salesforce: [null],
          photoshop: [null],
          illustrator: [null],
          seo: [null],
        
          otherKnowledge: [null],
 
          crud: [null]

        });  


        this.title = this.id ? 'Edit Developer' : 'New Developer';

        if(this.id != undefined) this.onEdit(this.id);   
  }

  onSubmit(){
   
   
	  this.developer.Email = this.form.controls['email'].value;
	  this.developer.Name = this.form.controls['name'].value;
	  this.developer.Skype = this.form.controls['skype'].value;
	  this.developer.Phone = this.form.controls['phone'].value;
	  this.developer.Linkedin = this.form.controls['linkedin'].value;
	  this.developer.City = this.form.controls['city'].value;
	  this.developer.State = this.form.controls['state'].value;
	  this.developer.Portfolio = this.form.controls['portfolio'].value;
	
	  this.developer.HourUntilFour = this.form.controls['hourUntilFour'].value;
	  this.developer.HourFourToSix = this.form.controls['hourFourToSix'].value;
	  this.developer.HourFourToEight = this.form.controls['hourFourToEight'].value;
	  this.developer.HourAboveEight = this.form.controls['hourAboveEight'].value;
	  this.developer.HoursOfWeekend = this.form.controls['hoursOfWeekend'].value; 
		
	  this.developer.MorningPeriod = this.form.controls['morningPeriod'].value;
	  this.developer.AfternoonPeriod = this.form.controls['afternoonPeriod'].value;
	  this.developer.NightPeriod = this.form.controls['nightPeriod'].value;
	  this.developer.DawnPeriod = this.form.controls['dawnPeriod'].value;
	  this.developer.BusinessPeriod = this.form.controls['businessPeriod'].value; 
	
  	this.developer.Pretension = this.form.controls['pretension'].value;
	
    this.developer.Bank = this.form.controls['bank'].value;
	
  	this.developer.Crud = this.form.controls['crud'].value;
	
	  //bank
	  this.developer.BankInf.Name = this.form.controls['bankInf_name'].value;
	  this.developer.BankInf.CPF = this.form.controls['bankInf_cpf'].value;
	  this.developer.BankInf.Bank = this.form.controls['bankInf_bank'].value;
	  this.developer.BankInf.Agency = this.form.controls['bankInf_agency'].value;
	  this.developer.BankInf.Account = this.form.controls['bankInf_account'].value;
  	this.developer.BankInf.Chain = this.form.controls['bankInf_chain'].value;
  	this.developer.BankInf.Savings = this.form.controls['bankInf_savings'].value;
		
	  //Knowledge
  	this.developer.Knowledge.Ionic = this.form.controls['ionic'].value;
  	this.developer.Knowledge.Android = this.form.controls['android'].value;
    this.developer.Knowledge.Ios = this.form.controls['ios'].value;
    this.developer.Knowledge.Html = this.form.controls['html'].value;
  	this.developer.Knowledge.Css = this.form.controls['css'].value;
  	this.developer.Knowledge.Bootstrap = this.form.controls['bootstrap'].value;
	  this.developer.Knowledge.Jquery = this.form.controls['jquery'].value;
	  this.developer.Knowledge.AngularJs = this.form.controls['angularJs'].value;
	
  	this.developer.Knowledge.Java = this.form.controls['java'].value;
	  this.developer.Knowledge.Aspnet = this.form.controls['aspnet'].value;
  	this.developer.Knowledge.C = this.form.controls['c'].value;
  	this.developer.Knowledge.Cplusplus = this.form.controls['cplusplus'].value;
  	this.developer.Knowledge.Cake = this.form.controls['cake'].value;
	  this.developer.Knowledge.Django = this.form.controls['django'].value;
  	this.developer.Knowledge.Majento = this.form.controls['majento'].value;
  	this.developer.Knowledge.Php = this.form.controls['php'].value;
  	this.developer.Knowledge.Wordpress = this.form.controls['wordpress'].value;
  	this.developer.Knowledge.Phyton = this.form.controls['phyton'].value;
	
	  this.developer.Knowledge.Ruby = this.form.controls['ruby'].value;
  	this.developer.Knowledge.SqlServer = this.form.controls['sqlServer'].value;
  	this.developer.Knowledge.MySql = this.form.controls['mySql'].value;
  	this.developer.Knowledge.Salesforce = this.form.controls['salesforce'].value;
	  this.developer.Knowledge.Photoshop = this.form.controls['photoshop'].value;
  	this.developer.Knowledge.Illustrator = this.form.controls['illustrator'].value;
  	this.developer.Knowledge.Seo = this.form.controls['seo'].value;
  	this.developer.Knowledge.OtherKnowledge = this.form.controls['otherKnowledge'].value; 
   
    console.log(this.developer);

    if(this.developer.Id){ 
      this.DeveloperService.update(this.developer).then(() => this.router.navigate(['/list']) );
    }else{
      this.DeveloperService.add(this.developer).then(() => this.router.navigate(['/list']) );
    }

  } 

  onEdit(id: number){

    /*  this.DeveloperService.getById(id).then(response => {
        this.developer = response;
        
        this.form.get('name').setValue(this.developer.Name);
        this.form.get('descricao').setValue(this.developer.Descricao); 
        this.form.get('codigo').setValue(this.developer.Codigo); 
        this.form.get('preco').setValue(this.developer.Preco); 
        this.form.get('email').setValue(this.developer.Email); 
      }); */
  }

  reset(){
    this.form.reset();
  }
 
 
}
