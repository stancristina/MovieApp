export class MoviePremier {
  id: number;
  premierDate: string;
  premierLocation: string;
  movieId: number;

  constructor(input?: any) {
    Object.assign(this, input);
  }
}
