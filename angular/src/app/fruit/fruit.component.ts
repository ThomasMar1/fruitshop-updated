import { Component, Injector, OnInit, AfterViewInit } from '@angular/core';
import {FruitApplicationServiceProxy, Fruitdto} from '@shared/service-proxies/service-proxies';
import { PagedListingComponentBase, PagedRequestDto } from "shared/paged-listing-component-base";
import { AppComponentBase } from 'shared/app-component-base';
import { CurrencyPipe } from '@angular/common';


@Component({
  selector: 'app-fruit',
  templateUrl: './fruit.component.html',
  styleUrls: ['./fruit.component.css']
})
export class FruitComponent extends AppComponentBase implements OnInit {

  constructor( injector: Injector, private _fruitService: FruitApplicationServiceProxy) { super(injector); }

  ngOnInit() {
  }

  ngAfterViewInit() {
    this.getFruits();
  }

  public fruits: Fruitdto[];

  getFruits(){
    this._fruitService.getAll('' , 0 , 500)
    .finally(()=>{
        
    })
    .subscribe((result)=>{
  this.fruits = result.items;
   });

  }

  delete(fruits: Fruitdto): void {
    abp.message.confirm(
        "Delete '" + fruits.name + "'?",
        (result: boolean) => {
            if (result) {
                this._fruitService.delete(fruits.id)
                    .subscribe(() => {
                        abp.notify.info("Deleted " + fruits.name);
                        this.getFruits();
                    });
            }
        }
    );


}
itWorks(){
    alert("Hello World");
};
}
