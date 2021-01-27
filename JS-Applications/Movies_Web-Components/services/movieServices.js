import {request} from './request.js';


const databaseUrl = 'https://movies-dc6e7.firebaseio.com';

const api = {
    movies: `${databaseUrl}/movies.json`
}



export const getAllMovies = async(searchText) => {
    let res = await request(api.movies, 'GET');
    console.log(res)
    return Object.keys(res).map(key => ({id: key, ...res[key]})).filter(x => !searchText || searchText == x.title);
}

export const getMovieById = async(id) => {
    let res = await request(`${databaseUrl}/movies/${id}.json`, 'GET');
    return {id, ...res};
}

export const likeMovie = async(id, creater) => {
    let res = await request(`${databaseUrl}/movies/${id}/peopleLiked.json`, 'POST', {creater});
    return res;
}