import { Component, ViewChild, Injector, Output, Input, EventEmitter, ElementRef, Pipe, PipeTransform, NgModule } from '@angular/core';
import { AppComponentBase } from 'shared/app-component-base';
import { ModalDirective } from 'ngx-bootstrap';
import { FruitApplicationServiceProxy, UpdateFruit, Fruitdto } from '@shared/service-proxies/service-proxies';
import { CurrencyPipe } from "@angular/common"


import * as _ from "lodash";

@Component({
  selector: 'app-edit-fruit',
  templateUrl: './edit-fruit.component.html'
})
export class EditFruitComponent extends AppComponentBase {

  @ViewChild('editFruitModal') modal: ModalDirective;
  @ViewChild('fruitname') fruitNameInput: ElementRef;
  @ViewChild('modalContent') modalContent: ElementRef;



  @Output() modalSave: EventEmitter<any> = new EventEmitter<any>();

  active: boolean = false;
  saving: boolean = false;
  fruits: UpdateFruit = new UpdateFruit();

  constructor(
    injector: Injector,
    private _fruitService: FruitApplicationServiceProxy
  ) {
    super(injector);
  }

  show(id: number): void {
    this._fruitService.get(id)
      .finally(() => {
        this.modal.show();
      })
      .subscribe((result: Fruitdto) => {
        this.fruits.id = result.id;
        this.fruits.name = result.name;
        this.fruits.colour = result.colour;
        this.fruits.stockAvailable = result.stockAvailable;
        this.fruits.pricePerItem = result.pricePerItem;
        this.fruits.supplierRefId = result.supplierRefId;
      });
  }

  onShown(): void {
    $.AdminBSB.input.activate($(this.modalContent.nativeElement));




  }
  save(): void {
    this.saving = true;
    this._fruitService.update(this.fruits)
      .finally(() => { this.saving = false; })
      .subscribe(() => {
        this.notify.success("Successfully updated " + this.fruits.name);
        this.close();
        this.modalSave.emit(null);
      });
  }

  close(): void {
    this.active = false;
    this.modal.hide();
  }
  ngOnInit() {
  }

}
