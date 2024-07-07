import { CommonModule } from "@angular/common";
import { Component } from "@angular/core";
import { FormBuilder, FormGroup, ReactiveFormsModule, Validators } from "@angular/forms";
import { UserService } from "../../services/user.service";
import { Router } from "@angular/router";

@Component({
    selector: 'app-add-user-list',
    standalone: true,
    imports: [
        CommonModule,
        ReactiveFormsModule
    ],
    templateUrl: './add-user-list.component.html'
})

export class AddUserListComponent{
    userForm!: FormGroup;
    constructor(
        private _fb: FormBuilder,
        private _userServive: UserService,
        private _router: Router
    ) {
        this.userForm = this._fb.group({
            name: ['', Validators.required],
            age: ['', Validators.required],
            phoneNumber: ['', Validators.required],
            status: [''],
            designation: ['']
        });
    }

    onSubmit(): void {
        console.log('here')
        if(this.userForm.valid){
            this._userServive.addUser({...this.userForm.value}).subscribe((res)=> {
                if(res){
                    this._router.navigateByUrl('/')
                }
            })
        }
    }
}