import { Injectable } from '@angular/core';
import { UserForm } from './user-form.model';

@Injectable({
  providedIn: 'root',
})
export class UserFormService {
  constructor() {}

  formData: UserForm = new UserForm();
}
