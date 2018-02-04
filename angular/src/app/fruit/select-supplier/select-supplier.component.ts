import { Component, Injector, ViewChild } from '@angular/core';
import { appModuleAnimation } from '@shared/animations/routerTransition';
import { SupplierServiceProxy, SupplierDto, PagedResultDtoOfSupplierDto } from '@shared/service-proxies/service-proxies';
import { PagedListingComponentBase, PagedRequestDto } from "shared/paged-listing-component-base";



@Component({
  selector: 'app-select-supplier',
  templateUrl: './select-supplier.component.html',
})
export class SelectSupplierComponent extends PagedListingComponentBase<SupplierDto> {


    suppliers: SupplierDto[] = [];

  constructor(
    injector: Injector,
    private _supplierService: SupplierServiceProxy
  ) {
    super(injector);
  }

  list(request: PagedRequestDto, pageNumber: number, finishedCallback: Function): void {
    this._supplierService.getAll('',request.skipCount, request.maxResultCount)
      .finally(() => {
        finishedCallback();
      })
      .subscribe((result: PagedResultDtoOfSupplierDto) => {
        this.suppliers = result.items;
        this.showPaging(result, pageNumber);
      });
  }


  delete(suppliers: SupplierDto): void {


  }

}
