import { Routes } from '@angular/router';
import { AppComponent } from './app.component';

export const routes: Routes = [
    {
        path: '',
        component: AppComponent,
        children:[
            {
                path: '',
                loadChildren: () =>
                    import('./modules/user.module').then(
                        (mod) => mod.UserModule
                    ),}
        ]
    }
];
