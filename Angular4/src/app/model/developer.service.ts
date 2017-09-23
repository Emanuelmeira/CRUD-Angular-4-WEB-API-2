import { Injectable } from '@angular/core';
import { Http, Response, Headers, RequestOptions } from "@angular/http";
import { Product } from "app/model/product.model";

import 'rxjs/add/operator/toPromise';
import { Developer } from "app/model/developer.model";


@Injectable()
export class DeveloperService {

    //Adicione aqui seu host SEM PATH ex: http://localhost:51694
   private host: string = "http://localhost:51694";
    
   private url: string = this.host +"/api/developer";
   
   public headers: Headers;
   public options: RequestOptions;

  constructor(private http: Http)
   {
       this.headers = new Headers({ 'Content-Type': 'application/json' });
       this.options = new RequestOptions({ headers: this.headers });
   }

   // POST product
    add(developer: Developer): Promise<Product> {       
        
        return this.http.post(this.url, JSON.stringify(developer), this.options  )
               .toPromise()
               .then(response => <Product>response.json())
               .catch(this.handleError)
    }
 
    // PUT product
    update(developer: Developer): Promise<void> {       
        
        return this.http.put(this.url, JSON.stringify(developer), this.options  )
               .toPromise()
               .then( response => console.log(response) )
               .catch(this.handleError)
    }
    

    // GET ALL product
    getAll(): Promise<Developer[]> {    
        
        return  this.http.get(this.url, this.options )
                .toPromise()
                .then(response => <Developer[]>response.json())
                .catch(this.handleError);        
    }

 
    // GET product
    get(id: number): Promise<Developer>{
       
      return  this.http.get(this.getUrl(id), this.options )
              .toPromise()
              .then(response => <Developer>response.json())
              .catch(this.handleError);       
    } 
 
    // DELETE product
    delete(id: number){
         
      return   this.http.delete(this.getUrl(id), this.options )
               .toPromise()
               .then(response => <Developer>response.json())
               .catch(this.handleError)
    }    

    //URL with paramiter id
    private getUrl(id){
        return this.url + "/" + id;
    }

    private handleError(error: any): Promise<any> {
        console.error('An error occurred', error); 
        return Promise.reject(error.message || error);
    }
}
