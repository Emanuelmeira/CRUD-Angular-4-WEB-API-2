import { Component, OnInit, TemplateRef } from '@angular/core';
import { BsModalService } from 'ngx-bootstrap/modal';
//import { BsModalRef } from 'ngx-bootstrap/modal/modal-options.class';
import { BsModalRef } from 'ngx-bootstrap/modal';
import { ModalComponent } from "./modal/modal.component";
import { Developer } from "app/model/developer.model";
import { DeveloperService } from "app/model/developer.service";

@Component({
  selector: 'app-list',
  templateUrl: './list.component.html',
  styleUrls: ['./list.component.css']
})
export class ListComponent implements OnInit {

  
  developers: Developer[];
  developer: Developer;  
  
  bsModalRef: BsModalRef;

  constructor(    
    private DeveloperService: DeveloperService,
    private modalService: BsModalService
  ) { }

  ngOnInit() {
      this.DeveloperService.getAll().then((response) => {
      this.developers = response;   
      console.log(this.developers);  
    }); 
  }

  onDelete(name: string, id: number) {    
    if(confirm("Are you sure you want to delete the developer "+ name +"?")) {            
      this.DeveloperService.delete(id).then(response =>  this.ngOnInit() );       
    }
  } 

  onDetails(id: number){      
      
    this.DeveloperService.getById(id).then((response) => {      
       this.developer = response;
       this.bsModalRef = this.modalService.show(ModalComponent); 
       this.bsModalRef.content.title = "Details";                    
       this.bsModalRef.content.developer = this.developer;                   
    });
  }
}


 
