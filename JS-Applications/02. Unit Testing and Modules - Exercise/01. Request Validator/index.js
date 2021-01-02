function solve(request) {
    if(!checkRequestMethod(request.method)) {
        throw new Error(`Invalid request header: Invalid Method`);
    }
    else if(!checkURI(request.uri)) {
        throw new Error('Invalid request header: Invalid URI');
    }
    else if(!checkVersion(request.version)) {
        throw new Error('Invalid request header: Invalid Version');
    }
    else if(!checkMessage(request.message)) {
        throw new Error('Invalid request header: Invalid Message');
    }
    return request;

    function checkRequestMethod(method) {
        let allowedMethods = ['GET', 'POST', 'DELETE', 'CONNECT'];
        return allowedMethods.includes(method);
    }
    function checkURI(uri) {
        if(uri === undefined) {
            return false;
        }
        const re = /^[\w.]+$/;
        return re.test(uri);
    }
    function checkVersion(version) {
        let allowedMethods = ['HTTP/0.9', 'HTTP/1.0', 'HTTP/1.1', 'HTTP/2.0'];
        return allowedMethods.includes(version)
    }
    function checkMessage(message) {
        if (message === undefined) {
            return false;
        }
        const re = /^(?!.*[<>&\\'"]).*$/g;
        return re.test(message);
    }
}

console.log(solve({
    method: 'POST',
    uri: 'home.bash',
    version: 'HTTP/0.9',
}
));