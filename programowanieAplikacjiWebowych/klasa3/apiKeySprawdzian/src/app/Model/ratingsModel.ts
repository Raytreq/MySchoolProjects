import { movieLinks } from "./moviesLinksModel";
import { ratingsResults } from "./ratingsResultsModel";

export interface ratings{
    links: movieLinks[];
    count: number;
    results: ratingsResults[];
}