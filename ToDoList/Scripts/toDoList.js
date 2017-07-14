$(document).ready(function () {
    $(document).on('click', '.jqToDo input[type=checkbox]', function () {
        var $control = $(this);
        var id = $control.attr('data-id');
        var url = $control.attr('data-url');
        var complete = $control.is(':checked');
        $.post(url,{ 'id': id, 'complete': complete }, function (data, textStatus, jqXHR) {
           $('.jqList').replaceWith($('.jqList', data));
        });
    });

    $(document).on('click', '.jqToDo button', function (e) {
        e.preventDefault();
        var $control = $(this);
        var id = $control.attr('data-id');
        var url = $control.attr('data-url');
        $.post(url, { 'id': id }, function (data, textStatus, jqXHR) {
            $('.jqList').replaceWith($('.jqList', data));
        });
    });

    $(document).on('click', '.jumbotron .inline button', function (e) {
        e.preventDefault();
        var $control = $(this);
        var newDescription = $('.jqDescription').val();
        $('.jqDescription').val('');
        var url = $control.attr('data-url');
        $.post(url, { 'newDescription': newDescription }, function (data, textStatus, jqXHR) {
            $('.jqList').replaceWith($('.jqList', data));
        });
    });
});