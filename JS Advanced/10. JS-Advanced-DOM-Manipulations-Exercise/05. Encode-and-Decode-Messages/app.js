function encodeAndDecodeMessages() {
    console.log('TODO...')
    //Add an event listener to the encode button
    const encodeButton = document.getElementsByTagName("button")[0];
    const encodeText = document.getElementsByTagName("textarea")[0]
    //When the button is clicked encode the message and display it in the decoded textarea
    encodeButton.addEventListener("click", function () {
        document.getElementsByTagName("textarea")[1].value = encode(encodeText.value);
        encodeText.value = "";
    });
    //Add an event listener to the decode button
    const decodeButton = document.getElementsByTagName("button")[1];
    const decodeText = document.getElementsByTagName("textarea")[1];
    decodeButton.addEventListener("click", function () {
        //When the button is clicked decode the encoded message
        decodeText.value = decode(decodeText);
    });

    function encode(message) {
        let result = "";
        for(let i = 0; i < message.length; i++) {
            result += String.fromCharCode((message.charCodeAt(i) + 1) % 128);
        }
        return result;
    }

    function decode(message) {
        let result = "";
        for(let i = 0; i < message.length; i++) {
            let value = message.charCodeAt(i) - 1;
            if(value  < 0) {
                value = 127;
            }
            result += String.fromCharCode(value);
        }
        return result;
    }
}