export class MovieGenre {
  id: number;
  movieId: number;
  actorId: number;
  role: string;
  revenue: number;

  constructor(input?: any) {
    Object.assign(this, input);
  }
}
