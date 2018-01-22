import { Component, Injector, OnInit, AfterViewInit } from '@angular/core';
import {FruitApplicationServiceProxy, Fruitdto} from '@shared/service-proxies/service-proxies';
import { PagedListingComponentBase, PagedRequestDto } from "shared/paged-listing-component-base";
import { AppComponentBase } from 'shared/app-component-base';
import { CurrencyPipe } from '@angular/common';


@Component({
  selector: 'app-add-fruit',
  templateUrl: './add-fruit.component.html'
})
export class AddFruitComponent extends AppComponentBase implements OnInit {

  constructor( injector: Injector, private _fruitService: FruitApplicationServiceProxy) { super(injector); }


  ngOnInit() {
  }

}
