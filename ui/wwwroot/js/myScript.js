var tasks = ["call mommy", "do your homework"];
var sira = tasks.length;
$(document).ready(function () {
    $.each(tasks, function (index, item) {
        $("#listTodo").append("<a href='#' class='list-group-item list-group-item-action'><input type='checkbox' class='yapilacak'> " + (index + 1) + " - " + item + "<span class='close'>x</span></a>");
    });
})
$("#task").on("keydown", function (event) {
    if (event.keyCode == 13) {
        sira++;
        $("#listTodo").append("<a href='#' class='list-group-item list-group-item-action'><input type='checkbox' class='yapilacak'> " + sira + " - " + $(this).val() + "<span class='close'>x</span></a>");
        $(this).val("");
    }
})
$("#listTodo").on('click', '.yapilacak', function () {
    var satir = $(this).closest("a");
    $(this).removeClass("yapilacak");
    $(this).addClass("yapilmis");
    $("#listDone").append(satir);
});
$("#listDone").on('click', '.yapilmis', function () {
    var satir = $(this).closest("a");
    $(this).removeClass("yapilmis");
    $(this).addClass("yapilacak");
    $("#listTodo").append(satir);
});
$("#listTodo, #listDone").on('click', '.close', function () {
    var satir = $(this).closest("a");
    $(satir).remove();
});