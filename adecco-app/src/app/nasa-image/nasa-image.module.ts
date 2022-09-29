import { CommonModule } from '@angular/common';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { DetailModalComponent } from './components/detail-modal/detail-modal.component';
import { SearchDetailsComponent } from './components/search-details/search-details.component';
import { NasaImageRoutingModule } from './nasa-image-routing.module';

@NgModule({
  declarations: [
    SearchDetailsComponent,
    DetailModalComponent
  ],
  imports: [
    CommonModule,
    FormsModule,
    NasaImageRoutingModule
  ],
  entryComponents:[
    DetailModalComponent
  ],
  providers: []
})
export class NasaImageModule { }
