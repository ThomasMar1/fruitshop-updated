import { Component, Injector, ViewChild } from '@angular/core';
import { appModuleAnimation } from '@shared/animations/routerTransition';
import { FruitApplicationServiceProxy, Fruitdto, PagedResultDtoOfFruitdto, UpdateFruit } from '@shared/service-proxies/service-proxies';
import { PagedListingComponentBase, PagedRequestDto } from "shared/paged-listing-component-base";
import { AddFruitComponent } from "app/fruit/add-fruit/add-fruit.component";
import { EditFruitComponent } from "app/fruit/edit-fruit/edit-fruit.component";
import { CurrencyPipe } from "@angular/common"


@Component({
    selector: 'app-fruit',
    templateUrl: './fruit.component.html',
    styleUrls: ['./fruit.component.css'],
    animations: [appModuleAnimation()]

})
export class FruitComponent extends PagedListingComponentBase<Fruitdto> {

    @ViewChild('addFruitModal') addFruitModal: AddFruitComponent;
    @ViewChild('editFruitModal') editFruitModal: EditFruitComponent;

    fruits: Fruitdto[] = [];

    constructor(
        injector: Injector,
        private _fruitService: FruitApplicationServiceProxy
    ) {
        super(injector);
    }

    protected list(request: PagedRequestDto, pageNumber: number, finishedCallback: Function): void {
        this._fruitService.getAll('', request.skipCount, request.maxResultCount)
            .finally(() => {
                finishedCallback();
            })
            .subscribe((result: PagedResultDtoOfFruitdto) => {
                this.fruits = result.items;
                this.showPaging(result, pageNumber);
            });
    }
    /*
    getFruits() {
        this._fruitService.getAll('', 0, 500)
            .finally(() => {
            })
            .subscribe((result) => {
                this.fruits = result.items;
            });

    }*/

    warning(stock){
        if (stock == 0){
            abp.message.error("This item is out of stock or not available. Please contact supplier to restock supplies.", "Out of stock");
        }
        else {
            abp.message.warn("This item is low in stock. Please contact supplier to restock supplies.", "Low stock");
        }
    }

    protected delete(fruits: Fruitdto): void {
        abp.message.confirm(
            "Delete '" + fruits.name + "'?",
            (result: boolean) => {
                if (result) {
                    this._fruitService.delete(fruits.id)
                        .subscribe(() => {
                            abp.notify.success("Deleted " + fruits.name);
                            this.refresh();
                        });
                }
            }
        );
    }

    // Show modals
    addFruit(): void {
        this.addFruitModal.show();
    }

    editFruit(fruits: UpdateFruit): void {
        this.editFruitModal.show(fruits.id);
    }
}