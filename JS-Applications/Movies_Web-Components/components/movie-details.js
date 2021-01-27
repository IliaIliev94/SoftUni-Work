import {html, render} from "https://unpkg.com/lit-html?module";
import {getMovieById, likeMovie} from '../services/movieServices.js';
import {getUserData} from '../services/authServices.js';

const hasLiked = (likes, uid) => {
    console.log(Object.values(likes))
    return Object.values(likes).some(like => like.creater === uid);
}

export const template = (ctx) =>  html`<div class="container">
<div class="row bg-light text-dark">
<h1>Movie title: ${ctx.title}</h1>
    
    <div class="col-md-8">
        <img class="img-thumbnail" src="${ctx.imageUrl}" alt="Movie">
    </div>
    <div class="col-md-4 text-center">
        <h3 class="my-3 ">Movie Description</h3>
        <p>${ctx.description}</p>
        ${ctx.creater === ctx.user.email
            ? html`
                <a class="btn btn-danger" href="#">Delete</a>
                <a class="btn btn-warning" href="#">Edit</a>
            `
            : html `
                ${hasLiked(ctx.peopleLiked, ctx.user.uid)
                ? html`<span class="enrolled-span">Liked ${Object.values(ctx.peopleLiked).length}</span>`
                : html`<a class="btn btn-primary" href="#" @click="${ctx.onLike}">Like</a>`
                } 
            `
        }
    </div>
</div>
</div>`;

class MovieDetails extends HTMLElement {
    constructor() {
        super();
        this.user = getUserData();
        console.log(this.user)
    }
    connectedCallback() {
        getMovieById(this.location.params.id)
        .then(data => {
            console.log(getUserData())
            Object.assign(this, data)
            this.render();
        })
    };

    onLike(e) {
        console.log('success');
        likeMovie(this.id, this.user.uid)
        .then(data => {
            this.render();
        });
    }

    render() {
        render(template(this), this, {eventContext: this});
    };
};

export default MovieDetails;