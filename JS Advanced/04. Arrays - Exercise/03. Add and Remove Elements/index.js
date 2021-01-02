function addAndRemove(data) {
    let count = 1;
    let elements = new Array();
    for(let i = 0; i < data.length; i++) {
        switch (data[i]) {
            case "add":
                elements.push(count);
                count++;
                break;
            case "remove":
                elements.pop();
                count++;
                break;
        }
    }
    if(elements.length == 0) {
        console.log("Empty");
    }
    else {
        for(let i = 0; i < elements.length; i++) {
            console.log(elements[i]);
        }
    }
}

addAndRemove(['add',
'add',
'remove',
'add',
'add'])