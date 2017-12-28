import { NgModule } from '@angular/core';
import { FormComponent } from './form.component';
import { CommonModule } from "@angular/common";
import { ReactiveFormsModule } from "@angular/forms";
import { HttpModule } from "@angular/http";

import { TabsModule } from 'ngx-bootstrap';
import { DeveloperService } from "app/model/developer.service";


@NgModule({
  imports: [
     CommonModule,
     ReactiveFormsModule,
     HttpModule,
     TabsModule.forRoot()
       
  ],
  declarations: [
    FormComponent,    
  ],
  exports: [
    FormComponent
  ],
  providers: [DeveloperService]
})
export class FormModule { }
