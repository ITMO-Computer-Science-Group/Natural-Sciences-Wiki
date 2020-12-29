<script>
var word = new Array();
var https = new XMLHttpRequest();
var url = `index.php`;
var HTML = "API检索中！";
var index = 0;
https.open("GET", url);
https.send();
https.onreadystatechange = () => {
    if (https.readyState == 4 && https.status == 200) {
        word = JSON.parse(https.responseText);
        HTML = `<table>`;
        HTML += `<tr><td>index</td><td>русский</td><td>中文</td></tr>`;
        for (let i in word){
            HTML += `<tr><td>${index++}</td><td>${word[i][0]}</td><td>${word[i][1]}</td></tr>`;
        }
        HTML += `</table>`
        document.getElementById("wordContent").innerHTML = HTML;
    }
}
</script>

<div id = "wordContent"></div>

