/* globals $ */

function solve() {

    return function (selector) {
        //var template =
        //   '<table class="items-table">' +
        //       '<thead>' +
        //           '<tr>' +
        //               '<th>#</th>' +
        //               '{{#each headers}}' +
        //                   '<th>{{this}}</th>' +
        //               '{{/each}}' +
        //           '</tr>' +
        //       '</thead>' +
        //       '<tbody>' +
        //           '{{#each items}}' +
        //               '<tr>' +
        //                   '<td>{{@index}}</td>' +
        //                   '<td>{{this.col1}}</td>' +
        //                   '<td>{{this.col2}}</td>' +
        //                   '<td>{{this.col3}}</td>' +
        //               '</tr>' +
        //           '{{/each}}' +
        //       '</tbody>' +
        //   '</table>';

        var $template = $('<table />').addClass('items-table'),
            $thead = $('<thead />'),
            $tr = $('<tr />'),
            $tbody = $('<tbody />');
        $tr.text('pufito');
        $tr.append('<th>#</th>' + '{{#headers}}' + '<th>{{this}} </th><div>{{/headers}}');

        $thead.append($tr);
        $template.append($thead);
        $template.append($tbody);
        console.log($template.get(0).outerHTML);
        $(selector).html($template.get(0).outerHTML);
    };
};

module.exports = solve;