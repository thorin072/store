var countOfFields = 1; // Текущее число полей
var curFieldNameId = 1; // Уникальное значение для атрибута name
var maxFieldLimit = 4; // Максимальное число возможных полей
var buf = $('script[id=dropjs]');
var countAuthors = buf.attr('data-countauthornow');
function deleteField(a) {
    if (countOfFields > 1) {
        // Получаем доступ к ДИВу, содержащему поле
        var contDiv = a.parentNode;
        // Удаляем этот ДИВ из DOM-дерева
        contDiv.parentNode.removeChild(contDiv);
        // Уменьшаем значение текущего числа полей
        countOfFields--;
        countAuthors--;
    }
    // Возвращаем false, чтобы не было перехода по сслыке
    return false;
}
function addField() {
    // Проверяем, не достигло ли число полей максимума
    if (countOfFields >= maxFieldLimit) {
        alert("Число полей достигло своего максимума = " + maxFieldLimit);
        return false;
    }
    // Увеличиваем текущее значение числа полей
    countOfFields++;
    countAuthors++;
    // Увеличиваем ID
    curFieldNameId++;
    // Создаем элемент ДИВ
    var div = document.createElement("div");
    // Добавляем HTML-контент с пом. свойства innerHTML

    div.innerHTML ="<div class=\"form-group\" id=\"authItemListId\"><label class=\"control-label col-md-2\" for=\"Author\">Author " + countAuthors + "</label><div class=\"dropdown" + countAuthors + " col-md-10\"><input type=\"text\" class=\"form-control auth" + countAuthors + "\" name=\"authFullName\" placeholder=\"Enter any author...\" onclick=\"showHints()\" onkeyup=\"showHints()\" value=\"null\" id=\"searchAuth" + countAuthors + "\" data-toggle=\"dropdown\" /><ul class=\"dropdown-menu\" id=" + countAuthors + "></ul></div>";
    // Добавляем новый узел в конец списка полей
    document.getElementById("authListId").appendChild(div);
    // Возвращаем false, чтобы не было перехода по сслыке
    
    $(buf).attr({ "data-countauthornow": countAuthors });
    countAuthors++;
    return false;
}