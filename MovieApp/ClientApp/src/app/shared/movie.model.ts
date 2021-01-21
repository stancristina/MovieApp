export class Movie {
  id: number;
  title: string;
  description: string;
  duration: number;
  releaseDate: Date;
  revenue: number;
  productionId: number;
  productionName: string;
  moviePremierId: number;
  movieCastId: number;
  movieGenreid: number;

  constructor(input?: any) {
    Object.assign(this, input);
  }
}
