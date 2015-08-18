/*Problem 9. Extract e-mails

Write a function for extracting all email addresses from given text.
All sub-strings that match the format @… should be recognized as emails.
Return the emails as array of strings.*/

var text,
    result;

text = 'This is an email sbs@asd.bg and this is email o@o.o or it isn\'t and this is also an email email@email.email.com';
console.log("Text: " + text);

function extractEmails(text) {
    text = text || '';
    var reg = /[a-zA-Z0-9_.]*@[a-z]{2,}\.[a-z.A-Z]{2,}/gi;
    var maches = text.match(reg);
    return maches;
}

console.log("Extracted emails: ");
result = extractEmails(text);
result.forEach(function (item) {
    console.log(item);
});