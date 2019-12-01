import { Injectable } from "@angular/core";
import {
  HttpRequest,
  HttpHandler,
  HttpEvent,
  HttpInterceptor,
  HttpResponse,
  HttpErrorResponse,
  HttpHeaders
} from "@angular/common/http";
import { Observable } from "rxjs/Observable";
import { nextTick } from 'q';

@Injectable()
export class MyInterceptor implements HttpInterceptor {
    constructor() { }
    intercept(
        request: HttpRequest<any>,
        next: HttpHandler
      ): Observable<HttpEvent<any>> {
        
        const updatedRequest = request.clone({
          headers: new HttpHeaders().append('httpInterceptor', 'DummyInterceptor')
        });

        return next.handle(updatedRequest);
    }
    
}