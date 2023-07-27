import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { FormsModule ,ReactiveFormsModule} from '@angular/forms';
import { HttpClientModule} from '@angular/common/http'
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { AllshipsComponent } from './allships/allships.component';
import { DeleteshipsComponent } from './deleteships/deleteships.component';
import { UpdateshipsComponent } from './updateships/updateships.component';
import { InsertshipsComponent } from './insertships/insertships.component';
import { ShiptypesComponent } from './shiptypes/shiptypes.component';
import { ShipstationsComponent } from './shipstations/shipstations.component';
import { AdminComponent } from './admin/admin.component';
import { UsersideComponent } from './userside/userside.component';
import { AllcustomersComponent } from './allcustomers/allcustomers.component';
import { AddcustomersComponent } from './addcustomers/addcustomers.component';
import { UpdatecustomersComponent } from './updatecustomers/updatecustomers.component';
import { DeletecustomersComponent } from './deletecustomers/deletecustomers.component';
import { SeeshipsComponent } from './seeships/seeships.component';
import { SeecustomersComponent } from './seecustomers/seecustomers.component';
import { SigninComponent } from './signin/signin.component';

@NgModule({
  declarations: [
    AppComponent,
    AllshipsComponent,
    DeleteshipsComponent,
    UpdateshipsComponent,
    InsertshipsComponent,
    ShiptypesComponent,
    ShipstationsComponent,
    AdminComponent,
    UsersideComponent,
    AllcustomersComponent,
    AddcustomersComponent,
    UpdatecustomersComponent,
    DeletecustomersComponent,
    SeeshipsComponent,
    SeecustomersComponent,
    SigninComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule, ReactiveFormsModule,
    HttpClientModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
