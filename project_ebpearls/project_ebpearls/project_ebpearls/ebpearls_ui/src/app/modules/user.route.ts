import { Routes } from '@angular/router';
import { UserListComponent } from './user-list/user-list.component';
import { AddUserListComponent } from './add-user/add-user-list.component';
export const UserRoutingModule: Routes = [
    { path: '', component: UserListComponent },
    { path: 'add-user', component: AddUserListComponent },
];
