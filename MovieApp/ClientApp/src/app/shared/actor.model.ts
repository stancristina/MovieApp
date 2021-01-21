export class Actor {
  id: number;
  firstname: string;
  lastname: string;
  birthdate: Date;
  gender: string;

  constructor(input?: any) {
    Object.assign(this, input);
  }
}
