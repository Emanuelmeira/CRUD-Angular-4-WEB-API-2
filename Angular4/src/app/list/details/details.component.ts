import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Params } from "@angular/router";
import { Developer } from "app/model/developer.model";
import { DeveloperService } from "app/model/developer.service";

@Component({
  selector: 'app-details',
  templateUrl: './details.component.html',
  styleUrls: ['./details.component.css']
})
export class DetailsComponent implements OnInit {

  constructor(
    private activatedRoute: ActivatedRoute,
    private DeveloperService: DeveloperService,
  ) { }
 
  title: string
  id: number
  developer: Developer;  
  
  ngOnInit(){
    
        this.activatedRoute.params.subscribe((params: Params) => {
          this.id = params['id'];
        });  
        
        this.title = 'Details';
        this.getDeveloper(this.id);            
  }

  getDeveloper(id: number){
    
         this.DeveloperService.getById(id).then(response => {
            this.developer = response;           
            
         });
  }
}
