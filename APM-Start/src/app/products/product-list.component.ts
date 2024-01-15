import { Component, OnInit } from "@angular/core";

import { PersonsService } from "./person.service";
import { Subscription } from "rxjs";
import { IPerson, Person } from "./person";

@Component({
    selector: 'pm-product',
    styleUrls: ['person.component.css'],
    templateUrl: './person.component.html'
})
export class ProductComponent implements OnInit {
OnRaitingClicked(message: string):void{
    this.pageTitle='Product list'+ message;
}

    ngOnInit(): void {
        this.personService.getProducts().subscribe((response) => {
            this.persons = response;
            console.log("test");
            console.log(response);
        });
        
        
    }
    pageTitle: string = "About";
    sub!: Subscription;
    errorMessage: string = '';
    persons: any;
 
    constructor(private personService: PersonsService) { }

}

