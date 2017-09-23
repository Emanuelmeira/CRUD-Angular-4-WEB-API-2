import { Component, OnInit } from '@angular/core';
import { BsModalRef } from "ngx-bootstrap/modal";
import { Product } from "app/model/product.model";
import { Developer } from "app/model/developer.model";


@Component({
  selector: 'app-modal',
  templateUrl: './modal.component.html',
  styleUrls: ['./modal.component.css']
})
export class ModalComponent implements OnInit {

  title: string;  
  developer = new Developer();
 
  constructor(private bsModalRef: BsModalRef) { }

  ngOnInit() {    
    
  }

}
