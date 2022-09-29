import { Component, OnInit, Input } from '@angular/core';
import { NgbActiveModal } from '@ng-bootstrap/ng-bootstrap';


@Component({
  selector: 'detail-modal',
  templateUrl: './detail-modal.component.html',
  styleUrls: ['./detail-modal.component.less']
})
export class DetailModalComponent implements OnInit  {
  @Input() my_modal_title :any | undefined;
  @Input() my_modal_content :any | undefined;

  constructor(private activeModal: NgbActiveModal) {}

  ngOnInit() {
  }

  close(){
    this.activeModal.close();
  }
}
