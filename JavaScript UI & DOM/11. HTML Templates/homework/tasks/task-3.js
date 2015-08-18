function solve(){
  return function(){
    $.fn.listview = function(data){
        var $this = $(this),
            templateSelector = '#' + $this.attr('data-template'),
            template = $(templateSelector).html(),
            templateCompile = handlebars.compile(template),
            i,
            len;

        for (i = 0, len = data.length; i < len; i += 1) {
            $this.append(templateCompile(data[i]));
        }

        return this;
    };
  };
}

module.exports = solve;