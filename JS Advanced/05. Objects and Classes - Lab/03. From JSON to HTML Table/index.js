function fromJSONToHTML(data) {
    let replaceValues = {
        '&': "&amp;",
        '<': "&lt;",
        '>': "&gt;",
        '"': "&quot;",
        "'": "&apos;",
        "®": "&reg;",
        "©": "&copy;",
        "™": "&trade;",
        '€': " &#8364;"
    }
    let parsedData = JSON.parse(data);
    let table = ["<table>"];
    table.push(`<tr>${Object.keys(parsedData[0]).map(x => `<th>${x}</th>`).join('')}</tr>`);
    parsedData.forEach((data) => {
        table.push(`<tr>${Object.values(data).map(x => `<td>${Encode(x)}</td>`).join('')}</tr>`)
    })
    table.push("</table>");
    function Encode(value) {
        return value.toString().replace(/&|<|>|"|®|©|™|'/gi, function(value) {
            return replaceValues[value];
        });
    }
    console.log(table.join("\n"));
}

fromJSONToHTML(['[{"Name":"Pesho <div>-a","Age":20,"City":"Sofia"},{"Name":"Gosho","Age":18,"City":"Plovdiv"},{"Name":"Angel","Age":18,"City":"Veliko Tarnovo"}]'])