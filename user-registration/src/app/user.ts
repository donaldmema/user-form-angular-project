export class User {
  constructor(
    public id: number,
    public name: string,
    public surname: string,
    public birthDate: string,
    public email: string,
    public phone: string,
    public password: string
  ) {}
}
