export class MovieCast {
  id: number;
  movieId: number;
  shopId: number;

  constructor(input?: any) {
    Object.assign(this, input);
  }
}
