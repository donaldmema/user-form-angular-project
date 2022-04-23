export class UserForm {
  userId: number;
  name: string;
  surname: string;
  birthDate: string;
  email: string;
  phone: string;
  password: string;

  constructor() {
    this.userId = 0;
    this.name = '';
    this.surname = '';
    this.birthDate = '';
    this.email = '';
    this.phone = '';
    this.password = '';
  }
}
