import { Component, OnInit } from '@angular/core';
import { UserFormService } from './shared/user-form.service';

@Component({
  selector: 'app-user-form',
  templateUrl: './user-form.component.html',
  styleUrls: ['./user-form.component.css'],
})
export class UserFormComponent implements OnInit {
  constructor(public service: UserFormService) {}

  ngOnInit(): void {}
}
