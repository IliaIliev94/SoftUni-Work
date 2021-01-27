import { Router } from 'https://unpkg.com/@vaadin/router';
import {html, render} from "https://unpkg.com/lit-html?module";
import {login} from "../services/authServices.js";

const template = (ctx) => html`
        <form class="text-center border border-light p-5" action="" method="" @submit=${ctx.onSubmit}>
            <div class="form-group">
                <label for="email">Email</label>
                <input type="email" class="form-control" placeholder="Email" name="email" value="">
            </div>
            <div class="form-group">
                <label for="password">Password</label>
                <input type="password" class="form-control" placeholder="Password" name="password" value="">
            </div>
        
            <button type="submit" class="btn btn-primary">Login</button>
        </form>
`;

export class Login extends HTMLElement {
    connectedCallback() {
        this.render();
    };

    onSubmit(e) {
        e.preventDefault();
        let formData = new FormData(e.target);
        let email = formData.get('email');
        let password = formData.get('password');


        if(password.length < 6) {
            console.error("password must be more than 6 characters!");
            notify('password too short!', 'error');
            return;
        }
        login(email, password)
        .then(data => {
            notify('Successful Login', 'success');
            Router.go('/');
        })
        .catch(err => {
            console.error(err);
            notify(err, 'error');
        });
    }
    render() {
        render(template(this), this, {eventContext: this});
    }
};

