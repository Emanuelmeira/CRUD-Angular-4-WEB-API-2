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
  fieldAlert:string = 'This field is required';
 
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
          email: [null, Validators.required], 
          name: [null, Validators.required],
          skype: [null, Validators.required],
          phone: [null],
          linkedin: [null],
          city: [null, Validators.required],
          state: [null, Validators.required],
          portfolio: [null],

          hourUntilFour: [false],
          hourFourToSix: [false],
          hourSixToEight: [false],
          hourAboveEight: [false],
          hoursOfWeekend: [false], 

          morningPeriod: [false],
          afternoonPeriod: [false],
          nightPeriod: [false],
          dawnPeriod: [false],
          businessPeriod: [false],

          pretension: [0, Validators.required],

          bank: [null ],

          //page 2
          bankInf_name: [null],
          bankInf_cpf:  [null],
          bankInf_bank:  [null],
          bankInf_agency:  [null],
          bankInf_account:  [null],
          bankInf_chain:  [false],
          bankInf_savings:  [false],

          //page 3
          ionic: [null , Validators.required],
          android: [null, Validators.required],
          ios: [null, Validators.required],
          html: [null],
          css: [null],

          bootstrap: [null , Validators.required],
          jquery: [null, Validators.required],
          angularJs: [null, Validators.required],
          java: [null],
          aspnet: [null, Validators.required],

          c: [null],
          cplusplus: [null],
          cake: [null],
          django: [null],
          majento: [null],
        
          php: [null , Validators.required],
          wordpress: [null, Validators.required],
          phyton: [null],
          ruby: [null],
          sqlServer: [null],
        
          mySql: [null],
          salesforce: [null],
          photoshop: [null],
          illustrator: [null],
          seo: [null],
        
          otherKnowledge: [null],
 
          crud: [null, ]

        });  

        this.title = this.id ? 'Edit Developer' : 'New Developer';

        if(this.id != undefined) this.onEdit(this.id);   
  }

  onSubmit(){   
   
	  this.developer.email = this.form.controls['email'].value;
	  this.developer.name = this.form.controls['name'].value;
	  this.developer.skype = this.form.controls['skype'].value;
	  this.developer.phone = this.form.controls['phone'].value;
	  this.developer.linkedin = this.form.controls['linkedin'].value;
	  this.developer.city = this.form.controls['city'].value;
	  this.developer.state = this.form.controls['state'].value;
	  this.developer.portfolio = this.form.controls['portfolio'].value;
	    
    this.developer.hourUntilFour = this.form.controls['hourUntilFour'].value;

	  this.developer.hourFourToSix = this.form.controls['hourFourToSix'].value;
	  this.developer.hourSixToEight = this.form.controls['hourSixToEight'].value;
	  this.developer.hourAboveEight = this.form.controls['hourAboveEight'].value;
	  this.developer.hoursOfWeekend = this.form.controls['hoursOfWeekend'].value; 
		
	  this.developer.morningPeriod = this.form.controls['morningPeriod'].value;
	  this.developer.afternoonPeriod = this.form.controls['afternoonPeriod'].value;
	  this.developer.nightPeriod = this.form.controls['nightPeriod'].value;
	  this.developer.dawnPeriod = this.form.controls['dawnPeriod'].value;
	  this.developer.businessPeriod = this.form.controls['businessPeriod'].value; 
	
  	this.developer.pretension = this.form.controls['pretension'].value;
	
    this.developer.bank = this.form.controls['bank'].value;
	
  	this.developer.crud = this.form.controls['crud'].value;
	
	  //bank
	  this.developer.bankInf.name = this.form.controls['bankInf_name'].value;
	  this.developer.bankInf.cpf = this.form.controls['bankInf_cpf'].value;
	  this.developer.bankInf.bank = this.form.controls['bankInf_bank'].value;
	  this.developer.bankInf.agency = this.form.controls['bankInf_agency'].value;
	  this.developer.bankInf.account = this.form.controls['bankInf_account'].value;
  	this.developer.bankInf.chain = this.form.controls['bankInf_chain'].value;
  	this.developer.bankInf.savings = this.form.controls['bankInf_savings'].value;
		
	  //Knowledge
  	this.developer.knowledge.ionic = this.form.controls['ionic'].value;
  	this.developer.knowledge.android = this.form.controls['android'].value;
    this.developer.knowledge.ios = this.form.controls['ios'].value;
    this.developer.knowledge.html = this.form.controls['html'].value;
    this.developer.knowledge.css = this.form.controls['css'].value;
    this.developer.knowledge.bootstrap = this.form.controls['bootstrap'].value;
	  this.developer.knowledge.jquery = this.form.controls['jquery'].value;
	  this.developer.knowledge.angularJs = this.form.controls['angularJs'].value;
	
  	this.developer.knowledge.java = this.form.controls['java'].value;
	  this.developer.knowledge.aspnet = this.form.controls['aspnet'].value;
  	this.developer.knowledge.c = this.form.controls['c'].value;
  	this.developer.knowledge.cplusplus = this.form.controls['cplusplus'].value;
  	this.developer.knowledge.cake = this.form.controls['cake'].value;
	  this.developer.knowledge.django = this.form.controls['django'].value;
  	this.developer.knowledge.majento = this.form.controls['majento'].value;
  	this.developer.knowledge.php = this.form.controls['php'].value;
  	this.developer.knowledge.wordpress = this.form.controls['wordpress'].value;
  	this.developer.knowledge.phyton = this.form.controls['phyton'].value;
	
	  this.developer.knowledge.ruby = this.form.controls['ruby'].value;
  	this.developer.knowledge.sqlServer = this.form.controls['sqlServer'].value;
  	this.developer.knowledge.mySql = this.form.controls['mySql'].value;
  	this.developer.knowledge.salesforce = this.form.controls['salesforce'].value;
	  this.developer.knowledge.photoshop = this.form.controls['photoshop'].value;
  	this.developer.knowledge.illustrator = this.form.controls['illustrator'].value;
  	this.developer.knowledge.seo = this.form.controls['seo'].value;
  	this.developer.knowledge.otherKnowledge = this.form.controls['otherKnowledge'].value; 
   
    //console.log(this.developer);

    if(this.developer.id){ 
      this.DeveloperService.update(this.developer).then(() => this.router.navigate(['/list']) );
    }else{      
      this.DeveloperService.add(this.developer).then(() => this.router.navigate(['/list']) );
    }

  } 

  onEdit(id: number){

      this.DeveloperService.getById(id).then(response => {
        this.developer = response;
        
        console.log( this.developer);

        this.form.get('email').setValue(this.developer.email); 
        this.form.get('name').setValue(this.developer.name);		
        this.form.get('skype').setValue(this.developer.skype); 
        this.form.get('phone').setValue(this.developer.phone); 
        this.form.get('linkedin').setValue(this.developer.linkedin);
        this.form.get('city').setValue(this.developer.city);
        this.form.get('state').setValue(this.developer.state);
        this.form.get('portfolio').setValue(this.developer.portfolio);
        
        this.form.get('hourUntilFour').setValue(this.developer.hourUntilFour);
        this.form.get('hourFourToSix').setValue(this.developer.hourFourToSix);
        this.form.get('hourSixToEight').setValue(this.developer.hourSixToEight);
        this.form.get('hourAboveEight').setValue(this.developer.hourAboveEight);
        this.form.get('hoursOfWeekend').setValue(this.developer.hoursOfWeekend);
        
        this.form.get('morningPeriod').setValue(this.developer.morningPeriod);
        this.form.get('afternoonPeriod').setValue(this.developer.afternoonPeriod);
        this.form.get('nightPeriod').setValue(this.developer.nightPeriod);
        this.form.get('dawnPeriod').setValue(this.developer.dawnPeriod);
        this.form.get('businessPeriod').setValue(this.developer.businessPeriod);
        
        
        this.form.get('pretension').setValue(this.developer.pretension);
        this.form.get('bank').setValue(this.developer.bank);
        
        //bank
        this.form.get('bankInf_name').setValue(this.developer.bankInf.name);
        this.form.get('bankInf_cpf').setValue(this.developer.bankInf.cpf);
        this.form.get('bankInf_bank').setValue(this.developer.bankInf.bank);
        this.form.get('bankInf_agency').setValue(this.developer.bankInf.agency);
        this.form.get('bankInf_account').setValue(this.developer.bankInf.account);
        this.form.get('bankInf_chain').setValue(this.developer.bankInf.chain);
        this.form.get('bankInf_savings').setValue(this.developer.bankInf.savings);
        
        
        //Knowlodge
        this.form.get('ionic').setValue(this.developer.knowledge.ionic);
        this.form.get('android').setValue(this.developer.knowledge.android);
        this.form.get('ios').setValue(this.developer.knowledge.ios);
        this.form.get('html').setValue(this.developer.knowledge.html);
        this.form.get('css').setValue(this.developer.knowledge.css);
        this.form.get('bootstrap').setValue(this.developer.knowledge.bootstrap);
        this.form.get('jquery').setValue(this.developer.knowledge.jquery);
        this.form.get('angularJs').setValue(this.developer.knowledge.angularJs);
       
       
        this.form.get('java').setValue(this.developer.knowledge.java);
        this.form.get('aspnet').setValue(this.developer.knowledge.aspnet);
        this.form.get('c').setValue(this.developer.knowledge.c);
        this.form.get('cplusplus').setValue(this.developer.knowledge.cplusplus);
        this.form.get('cake').setValue(this.developer.knowledge.cake);
        this.form.get('django').setValue(this.developer.knowledge.django);
        this.form.get('majento').setValue(this.developer.knowledge.majento);
        this.form.get('php').setValue(this.developer.knowledge.php);
        this.form.get('wordpress').setValue(this.developer.knowledge.wordpress);    
        this.form.get('phyton').setValue(this.developer.knowledge.phyton);

        this.form.get('ruby').setValue(this.developer.knowledge.ruby);
        this.form.get('sqlServer').setValue(this.developer.knowledge.sqlServer);
        this.form.get('mySql').setValue(this.developer.knowledge.mySql);
        this.form.get('salesforce').setValue(this.developer.knowledge.salesforce);
        this.form.get('photoshop').setValue(this.developer.knowledge.photoshop);
        this.form.get('illustrator').setValue(this.developer.knowledge.illustrator);
        this.form.get('seo').setValue(this.developer.knowledge.seo);
        this.form.get('otherKnowledge').setValue(this.developer.knowledge.otherKnowledge);
                
        
        this.form.get('crud').setValue(this.developer.crud);     


      }); 
  }

  reset(){
    this.form.reset();
  }
 
 
}
