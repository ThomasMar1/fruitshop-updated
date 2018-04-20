import { Component, Injector, ViewEncapsulation, OnInit } from '@angular/core';
import { AppComponentBase } from '@shared/app-component-base';
import { MenuItem } from '@shared/layout/menu-item';
import { AppAuthService } from '@shared/auth/app-auth.service';
import { RouterLinkActive } from '@angular/router';



@Component({
    templateUrl: './topbar.component.html',
    selector: 'top-bar',
    encapsulation: ViewEncapsulation.None
})
export class TopBarComponent extends AppComponentBase implements OnInit {
    menuItems: MenuItem[] = [
        new MenuItem("Home", "", "home", "/app/home"),
        new MenuItem("Users", "Pages.Users", "people", "/app/users"),
        new MenuItem("Roles", "Pages.Roles", "local_offer", "/app/roles"),
        new MenuItem("Fruit Stock", "", "list", "/app/fruit"),
        new MenuItem("Suppliers", "Pages.Suppliers", "local_shipping", "/app/supplier/supplierlist"),

    ];

    shownLoginName: string = "";
    constructor(
        injector: Injector,
        private _authService: AppAuthService
    ) {
        super(injector);
    }

    showMenuItem(menuItem): boolean {
        if (menuItem.permissionName) {
            return this.permission.isGranted(menuItem.permissionName);
        }

        

        return true;
    }

    ngOnInit() {
        this.shownLoginName = this.appSession.getShownLoginName();
        this.shownLoginName = this.shownLoginName.substring(2);
    }

    logout(): void {
        this._authService.logout();
    }

    
}
