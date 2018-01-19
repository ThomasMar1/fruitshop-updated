import { Component, Injector, ViewEncapsulation } from '@angular/core';
import { AppComponentBase } from '@shared/app-component-base';
import { MenuItem } from '@shared/layout/menu-item';


@Component({
    templateUrl: './topbar.component.html',
    selector: 'top-bar',
    encapsulation: ViewEncapsulation.None
})
export class TopBarComponent extends AppComponentBase {
    menuItems: MenuItem[] = [
        new MenuItem(this.l("Home"), "", "home", "/app/home"),
        new MenuItem(this.l("About"), "", "info", "/app/about"),
        new MenuItem(this.l("Users"), "Pages.Users", "people", "/app/users"),
        new MenuItem(this.l("Roles"), "Pages.Roles", "local_offer", "/app/roles"),

    ];
    constructor(
        injector: Injector
    ) {
        super(injector);
    }
}