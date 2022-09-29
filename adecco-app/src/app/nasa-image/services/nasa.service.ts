import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

import { Observable, of } from 'rxjs';
import { map } from 'rxjs/operators';
import { ListResult } from '../models/list-result';
import { SearchInput } from '../models/search-input';

@Injectable({
  providedIn: 'root',
})
export class NasaService {
  imageMap = new Map<string, Array<string>>();
  serviceUrl:string= "http://localhost:5001/api/NasaImage";
  constructor(private httpClient: HttpClient) { }

  getNasaListData(searchInput:SearchInput):Observable<any>{

    if(!searchInput.endYear){
      searchInput.endYear='';
    }
    if(!searchInput.searchText){
      searchInput.searchText='';
    }
    if(!searchInput.startYear){
      searchInput.startYear='';
    }
    if(!searchInput.mediaType){
      searchInput.mediaType='';
    }
    return this.httpClient.get(
      this.serviceUrl+'?searchText='
      +searchInput.searchText +'&yearEnd='+
      searchInput.endYear+'&yearStart='+
      searchInput.startYear+'&mediaType='+searchInput.mediaType,
        );
   }

  getImageDetails(url:string):Observable<any>{
    return this.httpClient.get(url);
  }
}



/*
Copyright Google LLC. All Rights Reserved.
Use of this source code is governed by an MIT-style license that
can be found in the LICENSE file at https://angular.io/license
*/
