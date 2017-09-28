import { Component, OnInit } from '@angular/core';
import { FormGroup, FormBuilder, FormControl, Validators } from '@angular/forms';
import { Product } from "app/model/product.model";
import { ProductService } from "app/model/product.service";
import { Router, ActivatedRoute, Params } from "@angular/router";

import { Response} from "@angular/http";

import { TabsetComponent } from 'ngx-bootstrap';

@Component({
  selector: 'app-form',
  templateUrl: './form.component.html',
  styleUrls: ['./form.component.css']
})
export class FormComponent implements OnInit {
  
  form: FormGroup;
  product = new Product();
  title: string;
  id: number = 0;
 
  constructor(
    private formBuilder: FormBuilder,
    private ProductService: ProductService,
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
          query: [null],
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

        });  


        this.title = this.id ? 'Edit Developer' : 'New Developer';

        if(this.id != undefined) this.onEdit(this.id);   
  }

  onSubmit(){

    this.product.Name = this.form.controls['name'].value;
    this.product.Descricao = this.form.controls['descricao'].value;
    this.product.Codigo = this.form.controls['codigo'].value;
    this.product.Preco = this.form.controls['preco'].value;
    this.product.Email = this.form.controls['email'].value;         
    
    if(this.product.Id){ 
      this.ProductService.updateProduct(this.product).then(() => this.router.navigate(['/list']) );
    }else{
      this.ProductService.addProduct(this.product).then(() => this.router.navigate(['/list']) );
    }
  } 

  onEdit(id: number){

     this.ProductService.getProduct(id).then(response => {
        this.product = response;
        
        this.form.get('name').setValue(this.product.Name);
        this.form.get('descricao').setValue(this.product.Descricao); 
        this.form.get('codigo').setValue(this.product.Codigo); 
        this.form.get('preco').setValue(this.product.Preco); 
        this.form.get('email').setValue(this.product.Email); 
      });
  }

  reset(){
    this.form.reset();
  }
 
 
}
