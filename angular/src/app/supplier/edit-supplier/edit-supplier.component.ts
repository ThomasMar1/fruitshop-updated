import { Component, ViewChild, Injector, Output, Input, EventEmitter, ElementRef } from '@angular/core';
import { AppComponentBase } from 'shared/app-component-base';
import { ModalDirective } from 'ngx-bootstrap';
import { SupplierServiceProxy, UpdateSupplier, SupplierDto } from '@shared/service-proxies/service-proxies';

import * as _ from "lodash";

@Component({
  selector: 'app-edit-supplier',
  templateUrl: './edit-supplier.component.html'
})
export class EditSupplierComponent extends AppComponentBase {

  @ViewChild('editSupplierModal') modal: ModalDirective;
  @ViewChild('supplierName') supplierNameInput: ElementRef;

  @ViewChild('modalContent') modalContent: ElementRef;



  @Output() modalSave: EventEmitter<any> = new EventEmitter<any>();

  active: boolean = false;
  saving: boolean = false;
  suppliers: UpdateSupplier = new UpdateSupplier();

  constructor(
    injector: Injector,
    private _supplierService: SupplierServiceProxy
  ) {
    super(injector);
  }

  show(id: number): void {
    this._supplierService.get(id)
      .finally(() => {
        this.modal.show();
      })
      .subscribe((result: SupplierDto) => {
        this.suppliers.id = result.id;
        this.suppliers.name = result.name;
        this.suppliers.contact = result.contact;
        this.suppliers.phone = result.phone;
        this.suppliers.email = result.email;
      });
  }

  onShown(): void {
    $.AdminBSB.input.activate($(this.modalContent.nativeElement));




  }
  save(): void {
    this.saving = true;
    this._supplierService.update(this.suppliers)
      .finally(() => { this.saving = false; })
      .subscribe(() => {
        this.notify.info("Successfully updated: " + this.suppliers.name);
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
