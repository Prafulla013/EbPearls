import { CommonModule } from "@angular/common";
import { Component } from "@angular/core";
import { Router, RouterModule } from "@angular/router";
import { UserService } from "../../services/user.service";

@Component({
    selector: 'app-user-list',
    standalone: true,
    templateUrl: './user-list.component.html',
    imports: [
        CommonModule
    ]
})

export class UserListComponent{
    userList: any = [];

    constructor(private _router: Router ,private _userService: UserService){
        this.getUser();
    }

    addUser(): void {
        this._router.navigateByUrl('/add-user')
    }


    getUser(): void {
        this._userService.getUser().subscribe((res)=> {
            this.userList = res;
        })
    }
}