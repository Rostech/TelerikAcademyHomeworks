function solve() {
    return function (selector) {
        var $element = $(selector),
            $dropDownList,
            $optionsContainer,
            i,
            len;
        var optionsInSelect = $(selector).find('option');
        $element.css('display', 'none');
        $dropDownList = $('<div />', { class: "dropdown-list" }).append($element);
        $dropDownList.append($('<div />', { class: 'current' }).attr('data-value', 'value-1').text('Option1'));
        
        $optionsContainer = $('<div />', { class: 'options-container' }).css({
            position: 'absolute',
            display: 'none'
        });

        for (i = 0, len = $element[0].length; i < len; i += 1) {
            $optionsContainer.append($('<div />', { class: 'dropdown-item' })
                .attr('data-value', $(optionsInSelect[i]).val())
                .attr('data-index', i)
                .text($(optionsInSelect[i]).text()));
        }
        

        $dropDownList.append($optionsContainer);

        $dropDownList.on('click', function (e) {
            if ($dropDownList.children('.options-container').css('display') !== 'none') {
                $dropDownList.children('.current').attr('data-value', $(e.target).data('value'));
                $dropDownList.children('.current').text($(e.target).text());
                $dropDownList.children($element).val($(e.target).data('value'));
                $element.val($(e.target).data('value'));
            } else {
                $dropDownList.children('.current').text('Select a value');
            }

            $dropDownList.children('.options-container').toggle();
        });

        $dropDownList.appendTo('body');
        return this;
    };
}

module.exports = solve;