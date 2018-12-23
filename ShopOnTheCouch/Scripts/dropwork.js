var jo = [{ "full_name": "Рихтер Джеффри" }, { "full_name": "Шилдт Герберт" }, { "full_name": "Борзунов Сергей Викторович" }, { "full_name": "Кургалин Сергей Дмитриевич" }];
var saveauthor = "";
var buf = $('script[id=dropjs]');
var countAuthors =buf.attr('data-countauthornow');

var showHints = function () {
    var str = $('#searchAuth' + countAuthors).val().toLowerCase();//формирование строки запроса
    $('ul[id=' + countAuthors + ']').html(""); //обновление вывода меню
    if (typeof str != "?" && str !== "") {
        for (var el of jo) {
            var name = el.full_name.toLowerCase();
            if (name.indexOf(str) !== -1) {
                $('ul[id=' + countAuthors + ']').append('<li><a>' + el.full_name + '</a></li>');
            }
        }
    } else {
        $('ul[id=' + countAuthors + ']').append('<li><a href="#">write something..</a></li>');
    }

}

//обработка нажатия на элемент меню
$('ul').on('click', "li", function () {
    var txt = $(this).text(); // текст из нажатого элемента
    var class_name = '.auth' + countAuthors;
    
    $(class_name).click(function () {
        //установка в элемент имени автора
        $(class_name).each(function () {
            $(this).val(txt);
            $(this).attr({ "value": txt });
            $('ul[id=' + countAuthors + ']').empty();
        });
    });
   
    ;  
});