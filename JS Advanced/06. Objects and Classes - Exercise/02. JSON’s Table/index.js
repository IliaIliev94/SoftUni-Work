function JSONTable(data) {
    let htmlTable = ['<table>'];
    let parsedData = data.map(element => JSON.parse(element));
    parsedData.forEach(row => {
        htmlTable.push('\t<tr>');
        let keys = Object.keys(row);
        keys.forEach(key => htmlTable.push(`\t\t<td>${escapeHTML(row[key].toString())}</td>`));
        htmlTable.push('\t</tr>');
    });
    htmlTable.push('</table>');
    console.log(htmlTable.join('\n'));

    function escapeHTML(text) {
        let replacements = {
            '&': '&amp',
            '<': '&lt;',
            '>': '&gt;',
            '"': '&quot;',
            '\'': '&#39;'
        }
        return text.replace(/&|<|>|"|'/, function (word) {
            return replacements[word];
        })
    }
}

JSONTable(['{"name":"Pesho","position":"Promenliva","salary":100000}',
'{"name":"Teo","position":"Lecturer","salary":1000}',
'{"name":"Georgi","position":"Lecturer","salary":1000}'])