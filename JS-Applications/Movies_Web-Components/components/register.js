import {html, render} from "https://unpkg.com/lit-html?module";
import {register} from "../services/authServices.js";

const template = (ctx) => html`
        <form class="text-center border border-light p-5" action="#" method="post" @submit=${ctx.onSubmit}>
            <div class="form-group">
                <label for="email">Email</label>
                <input type="email" class="form-control" placeholder="Email" name="email" value="">
            </div>
            <div class="form-group">
                <label for="password">Password</label>
                <input type="password" class="form-control" placeholder="Password" name="password" value="">
            </div>
        
            <div class="form-group">
                <label for="repeatPassword">Repeat Password</label>
                <input type="password" class="form-control" placeholder="Repeat-Password" name="repeatPassword" value="">
            </div>
        
            <button type="submit" class="btn btn-primary">Register</button>
        </form>
`;

export class Register extends HTMLElement {
    connectedCallback() {
        this.render();
    };

    onSubmit(e) {
        e.preventDefault();
        let formData = new FormData(e.target);
        let email = formData.get('email');
        let password = formData.get('password');
        let repeatPassword = formData.get('repeatPassword');


        if(password.length < 6) {
            console.error("password must be more than 6 characters!");
            notify('password too short!', 'error');
            return;
        }
        if(password !== repeatPassword){
            console.error("password and repeat password must match!");
            notify('password and repeat password have to be equal!', 'error');
            return;
        }
        register(email, password)
        .then(data => {
            notify('Successful Registration', 'success');
        })
        .catch(err => {
            console.error(err);
        });
    }
    render() {
        render(template(this), this, {eventContext: this});
    }
};

