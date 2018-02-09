import { Component, ViewChild, Injector, Output, EventEmitter, ElementRef } from '@angular/core';
import { ModalDirective } from 'ngx-bootstrap';
import { SupplierServiceProxy, AddSupplierDto } from '@shared/service-proxies/service-proxies';
import { AppComponentBase } from '@shared/app-component-base';

import * as _ from "lodash";

@Component({
  selector: 'app-add-supplier',
  templateUrl: './add-supplier.component.html'
})

export class AddSupplierComponent extends AppComponentBase {

    @ViewChild('addSupplierModal') modal: ModalDirective;
    @ViewChild('modalContent') modalContent: ElementRef;

    @Output() modalSave: EventEmitter<any> = new EventEmitter<any>();

    active: boolean = false;
    saving: boolean = false;
    suppliers: AddSupplierDto = new AddSupplierDto();

    constructor(
        injector: Injector,
        private _supplierService: SupplierServiceProxy
    ) {
        super(injector);
    }

    show(): void {
        this.suppliers = new AddSupplierDto();
        this.modal.show();
    }

    onShown(): void {
        $.AdminBSB.input.activate($(this.modalContent.nativeElement));
    }

    save(): void {
        this.saving = true;
        this._supplierService.create(this.suppliers)
            .finally(() => { this.saving = false; })
            .subscribe(() => {
                this.notify.success("Successfully added " + this.suppliers.name );
                this.close();
                this.modalSave.emit(null);
            });
    }

    close(): void {
        this.active = false;
        this.modal.hide();
    }
}
