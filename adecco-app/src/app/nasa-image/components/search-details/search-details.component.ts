import { Component, OnInit } from '@angular/core';
import {NgbModal, ModalDismissReasons, NgbModalOptions} from '@ng-bootstrap/ng-bootstrap';
import { SearchInput } from '../../models/search-input';
import { NasaService } from '../../services/nasa.service';
import { DetailModalComponent } from '../detail-modal/detail-modal.component';


@Component({
  selector: 'search-details',
  templateUrl: './search-details.component.html',
  styleUrls: ['./search-details.component.less']
})
export class SearchDetailsComponent implements OnInit  {
  title = 'adecco-app';
  searchInput:SearchInput= new SearchInput();
  dataResult:any;
  imageDetails:Array<any>| undefined;

  closeResult: string| undefined;
  modalOptions:NgbModalOptions| undefined;

  constructor(private service:NasaService,
    private modalService: NgbModal)
  {
    this.modalOptions = {
      backdrop:'static',
      backdropClass:'customBackdrop',
      size:'xl'

    }
  }
  ngOnInit() {
    this.searchInput=new SearchInput();
  }


   open(content:any) {
    const modalRef = this.modalService.open(DetailModalComponent,this.modalOptions);
    modalRef.componentInstance.my_modal_title = 'Image Details';
    modalRef.componentInstance.my_modal_content = content.Data;

   }

  searchData(){
   this.service.getNasaListData(this.searchInput).subscribe(x=>{
     if(x.Collection && x.Collection.Items){
      this.dataResult=x.Collection.Items.slice(0, 10);;
      this.dataResult.forEach((element:any) => {
        if(this.service.imageMap.has(element.Href)){
          element.imageList=this.service.imageMap.get(element.Href);
        }else{
        this.service.getImageDetails(element.Href).subscribe(img=>{
          element.imageList=img;
          });
        }
     });
    }
   });

  }
}
