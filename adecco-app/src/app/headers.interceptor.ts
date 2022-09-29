import { HttpRequest ,HttpInterceptor,HttpHandler, HttpEvent, HttpHeaders} from '@angular/common/http';
import { Injectable } from '@angular/core';

import { Observable, of } from 'rxjs';
import { map } from 'rxjs/operators';

@Injectable()
export class HeadersInterceptor implements HttpInterceptor {

  constructor() { }
  intercept(request: HttpRequest<unknown>,next:HttpHandler):Observable<HttpEvent<unknown>>{

  const authReq = request.clone({
    headers: new HttpHeaders({
      'Content-Type':  'application/json'
    })
  });
  return next.handle(authReq);
  }

}
