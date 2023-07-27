import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AllshipsComponent } from './allships/allships.component';
import { DeleteshipsComponent } from './deleteships/deleteships.component';
import { ShipstationsComponent } from './shipstations/shipstations.component';
import { ShiptypesComponent } from './shiptypes/shiptypes.component';
import { AllcustomersComponent } from './allcustomers/allcustomers.component';
import { SigninComponent } from './signin/signin.component';

const routes: Routes = [
{
  path :'' , component : AllcustomersComponent
},
{path:'stations',component:ShipstationsComponent},
{path:'types' , component:ShiptypesComponent},
{path: 'admin',component : AllshipsComponent},
{path : 'signin', component :SigninComponent}

];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
