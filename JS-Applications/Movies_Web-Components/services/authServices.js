import {request} from './request.js';

const apiKey = 'AIzaSyDHH_v9cMqecxIg3_VTcvZRFdcKhrUjYgk';
const databaseUrl = 'https://movies-dc6e7.firebaseio.com/';

const api = {
    register: `https://identitytoolkit.googleapis.com/v1/accounts:signUp?key=${apiKey}`,
    login: `https://identitytoolkit.googleapis.com/v1/accounts:signInWithPassword?key=${apiKey}`
}

export const getUserData = () => {
    try {
        let data = JSON.parse(localStorage.getItem('userInfo'));
        return {
            isAuthenticated: Boolean(data),
            email: data.email
        };
    } catch(error) {
        return {
            isAuthenticated: false,
            email: ''
        };
    }
}
   

export const register = async (email, password) => {
    let res = await request(api.register, 
    'POST', {email, password});

    localStorage.setItem('userInfo', JSON.stringify(res));

    return res;
}

export const login = async (email, password) => {
    let res = await request(api.login, 
    'POST', {email, password});

    localStorage.setItem('userInfo', JSON.stringify(res));

    return res;
}

export const logout = async () => {
    localStorage.removeItem('userInfo');
}