import { Component, Injector, AfterViewInit, ViewChild, OnInit } from '@angular/core';
import { AppComponentBase } from '@shared/app-component-base';
import { appModuleAnimation } from '@shared/animations/routerTransition';
import { SupplierComponent } from 'app/supplier/supplier.component';
import { Router, ActivatedRoute, ParamMap } from '@angular/router';
import { SupplierServiceProxy, UpdateSupplier, SupplierDto } from '@shared/service-proxies/service-proxies';
import 'rxjs/add/operator/switchMap';
import { OnDestroy } from '@angular/core/src/metadata/lifecycle_hooks';
import { EditSupplierComponent } from "app/supplier/edit-supplier/edit-supplier.component";



@Component({
  selector: 'app-view-supplier',
  templateUrl: './view-supplier.component.html',
  animations: [appModuleAnimation()]

})
export class ViewSupplierComponent extends AppComponentBase implements OnInit, OnDestroy {
  id: number;
  name: string;
  private supplier: any;
  suppliers: SupplierDto = new SupplierDto;
  @ViewChild('editSupplierModal') editSupplierModal: EditSupplierComponent;

  //suppliers: UpdateSupplier = new UpdateSupplier();

  constructor(
    private route: ActivatedRoute,
    injector: Injector,
    
    private _supplierService: SupplierServiceProxy,
  ) { 
    super(injector);
  }


  ngOnInit() {
    this.supplier = this.route.params.subscribe(params => {
      this.id = +params['id'];
    });
    this.get(this.id)

  }

  reload(){
    this.get(this.id)
  }

  ngOnDestroy() {
    this.supplier.unsubscribe();
  }

  view() {
    alert(this.id);
    alert(this.name);
  }

  get(id:number): void {
    this._supplierService.get(this.id)
      .subscribe((result: SupplierDto) => {
        this.suppliers.name = result.name;
        this.suppliers.contact = result.contact;
        this.suppliers.phone = result.phone;
        this.suppliers.email = result.email;
      });
  }

  editSupplier(suppliers: UpdateSupplier): void {
    this.editSupplierModal.show(this.id);
  }


}
