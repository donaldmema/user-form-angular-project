import { Injectable } from '@angular/core';
import { UserForm } from './user-form.model';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root',
})
export class UserFormService {
  constructor(private http: HttpClient) {}

  formData: UserForm = new UserForm();

  readonly baseURL = 'http://localhost:5049/api/Test';

  postSaveUser() {
    return this.http.post(this.baseURL, this.formData);
  }
}
