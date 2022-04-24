import { Component, OnInit } from '@angular/core';
import { NgForm } from '@angular/forms';
import { UserForm } from './shared/user-form.model';
import { UserFormService } from './shared/user-form.service';

@Component({
  selector: 'app-user-form',
  templateUrl: './user-form.component.html',
  styleUrls: ['./user-form.component.css'],
})
export class UserFormComponent implements OnInit {
  constructor(public service: UserFormService) {}

  ngOnInit(): void {}

  onSubmit(form: NgForm) {
    this.service.postSaveUser().subscribe(
      (res) => {
        this.resetForm(form);
      },
      (err) => {
        console.log(err);
      }
    );
  }

  resetForm(form: NgForm) {
    form.form.reset();
    this.service.formData = new UserForm();
  }
}
