export class Genre {
  id: number;
  type: string;

  constructor(input?: any) {
    Object.assign(this, input);
  }
}
