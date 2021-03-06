import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ListComponent } from './list.component';

import { ModalComponent } from './modal/modal.component';

import { BsModalService } from 'ngx-bootstrap/modal';
import { DetailsComponent } from './details/details.component';

@NgModule({
  imports: [
    CommonModule    
  ],
  declarations: [
    ListComponent,
    ModalComponent,
    DetailsComponent
    
  ],
  providers: [
    BsModalService
  ],
  entryComponents: [
     ModalComponent
  ]
})
export class ListModule { }
