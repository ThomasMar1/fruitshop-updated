import { Component, ViewChild, Injector, Output, EventEmitter, ElementRef } from '@angular/core';
import { ModalDirective } from 'ngx-bootstrap';
import { SupplierServiceProxy, AddSupplier } from '@shared/service-proxies/service-proxies';
import { AppComponentBase } from '@shared/app-component-base';

import * as _ from "lodash";

@Component({
  selector: 'app-add-supplier',
  templateUrl: './add-supplier.component.html',
  styleUrls: ['./add-supplier.component.css']
})
export class AddSupplierComponent extends AppComponentBase {

    @ViewChild('addSupplierModal') modal: ModalDirective;
    @ViewChild('editSupplierModal') modalContent: ElementRef;

    @Output() modalSave: EventEmitter<any> = new EventEmitter<any>();

    active: boolean = false;
    saving: boolean = false;
    supplier: AddSupplier = null;

    constructor(
        injector: Injector,
        private _supplierService: SupplierServiceProxy
    ) {
        super(injector);
    }
    show(): void {
      this.modal.show();
      this.supplier = new AddSupplier();
  }
  ngOnInit() {
  }

}
