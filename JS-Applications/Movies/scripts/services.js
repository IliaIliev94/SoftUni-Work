const apiKey = `AIzaSyDHH_v9cMqecxIg3_VTcvZRFdcKhrUjYgk`;
const url =`https://identitytoolkit.googleapis.com/v1/accounts:signInWithPassword?key=${apiKey}`;
const dbURL = `https://movies-dc6e7.firebaseio.com`;

const request = async (url, method , body) => {
    let options = {
        method
    };

    if(body !== undefined) {
        Object.assign(options, {
            method: method,
            headers: {
                'content-type': 'application/json'
            },
            body: JSON.stringify(body)
        })
    }
    console.log(options);
    let response = await fetch(url, options);
    let data = await response.json();
    return data;
}

const authService = {
     logIn: async(email, password) => {
      let response = await fetch(url, {
           method: 'POST',
           headers: {
            "content-type": "application/json"
           },
           body: JSON.stringify({
               "email": email,
               "password": password
           })
       })
       let data = await response.json()
       localStorage.setItem('auth', JSON.stringify(data));
       return data;
    },
    getData() {
        
        try {
            let data = JSON.parse(localStorage.getItem('auth'));
            return {
                isAuthenticated: Boolean(data.idToken),
                data: data.email || ''
            };
        } catch (error) {
            return {
                isAuthenticated: false,
                data: ''
            }
        }
    },
    logOut() {
        localStorage.setItem('auth', '');
        navigate('home')
    }
}

const moviesService = {
    async add(movieData) {
        let data = await request(`${dbURL}/movies.json`, 'POST', movieData);
        console.log(data);
    },
    async getAll() {
        let data = await request(`${dbURL}/movies.json`, 'GET');
        return Object.keys(data).map(movie => ({movie, ...data[movie]}));
    },
    async getOne(id) {
        let data = await request(`${dbURL}/movies/${id}.json`, 'GET');
        return data;
    },
    async deleteMovie(id) {
        let data = await request(`${dbURL}/movies/${id}.json`, 'DELETE');
        return data;
    },
    async editMovie(id, movieData) {
        let data = await request(`${dbURL}/movies/${id}.json`, 'PUT', movieData);
        return data;
    }
}