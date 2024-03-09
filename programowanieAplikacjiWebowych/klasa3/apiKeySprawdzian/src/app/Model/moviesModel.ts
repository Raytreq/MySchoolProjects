import { movieLinks } from "./moviesLinksModel";
import { movieResults } from "./moviesResultsModel";

export interface movies{
    links: movieLinks[];
    count: number;
    results: movieResults[];
}