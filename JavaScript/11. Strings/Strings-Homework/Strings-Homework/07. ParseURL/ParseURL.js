/*Problem 7. Parse URL

Write a script that parses an URL address given in the format: [protocol]://[server]/[resource] and extracts from it the [protocol], [server] and [resource] elements.
Return the elements in a JSON object.*/

var url = "http://telerikacademy.com/Courses/Courses/Details/239";

function parseURL(url) {
    var protocol, server, resource;
    url = url || '';
    var pattern = /:\/\//;
    var arr = url.split(pattern)
    .filter(function (word) {
        return !!word;
    });
    protocol = arr[0];
    server = arr[1].toString().substring(0, arr[1].indexOf('/'));
    resource = arr[1].toString().substring(arr[1].indexOf('/'), arr[1].length-1);

    return {
        protocol: protocol,
        server: server,
        resource: resource
    }
}

var JSONobjectURL = parseURL(url);
console.log(JSONobjectURL);
