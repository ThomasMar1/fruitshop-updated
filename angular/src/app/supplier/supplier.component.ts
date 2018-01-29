import { Component, Injector, OnInit, AfterViewInit, ViewChild } from '@angular/core';
import { SupplierServiceProxy, SupplierDto } from '@shared/service-proxies/service-proxies';
import { PagedListingComponentBase, PagedRequestDto } from "shared/paged-listing-component-base";
import { AppComponentBase } from 'shared/app-component-base';
import { appModuleAnimation } from '@shared/animations/routerTransition';
import { AddSupplierComponent } from "app/supplier/add-supplier/add-supplier.component";
import { EditSupplierComponent } from "app/supplier/edit-supplier/edit-supplier.component";



@Component({
  selector: 'app-supplier',
  templateUrl: './supplier.component.html',
  styleUrls: ['./supplier.component.css'],
  animations: [appModuleAnimation()]

})
export class SupplierComponent extends AppComponentBase implements OnInit {
  @ViewChild('addSupplierModal') addSupplierModal: AddSupplierComponent;
  @ViewChild('editSupplierModal') editSupplierModal: EditSupplierComponent;

  supplier: SupplierDto[] = [];

  constructor(injector: Injector, private _supplierService: SupplierServiceProxy) { super(injector); }

  ngOnInit() {
  }

  ngAfterViewInit() {
    this.getSuppliers();
  }


  getSuppliers() {
    this._supplierService.getAll(0, 500)

      .finally(() => {

      })
      .subscribe((result) => {
        this.supplier = result.items;
      });

  }

  delete(supplier: SupplierDto): void {
    abp.message.confirm(
      "Delete '" + supplier.name + "'?",
      (result: boolean) => {
        if (result) {
          this._supplierService.delete(supplier.id)
            .subscribe(() => {
              abp.notify.info("Deleted " + supplier.name);
              this.getSuppliers();
            });
        }
      }
    );


  }

  addSupplier(): void {
    this.addSupplierModal.show();
}
}
