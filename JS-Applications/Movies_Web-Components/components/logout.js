import {html, render} from "https://unpkg.com/lit-html?module";
import {logout} from "../services/authServices.js";


export class Logout extends HTMLElement {
    onSubmit(e) {
        e.preventDefault();
        login(email, password)
        .then(data => {
            notify('Successful Login', 'success');
        })
        .catch(err => {
            console.error(err);
            notify(err, 'error');
        });
    }
};

