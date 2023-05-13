// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

function ActiveMenu(id) {
    var targetObj = $(id);
    $('.nav-sidebar').find('.menu-open').removeClass('menu-open');
    $('.nav-sidebar').find('.nav-link').removeClass('active');
    $('.nav-item').find('.menu-open').removeClass('menu-open');
    $('.nav-item').find('.nav-link').removeClass('active');
    setTimeout(function () {
        var currObj = targetObj;
        if (currObj.hasClass('nav-link')) {
            currObj.addClass('active');
        }
        while (!currObj.hasClass('nav-sidebar')) {
            if (currObj.hasClass('nav')) {
                currObj.show();
            }
            if (currObj.hasClass('nav-item')) {

                currObj.addClass('menu-open');
            }
            currObj = currObj.parent();
        }
    }, 100);
}

function ValidateForm(form) {
    if (!$(form).parsley().validate()) {
        return false;
    }
    else {
        return true;
    }
}

function SelectedValue(DataTableID, rowData) {
    var row = $("#" + DataTableID).find(".dtactive");
    if (row.length > 0)
        return $("#" + DataTableID).DataTable().row(row[0]).data()[rowData];
    else
        return 0;
}


function GetMonth(monthName) {
    var month = 0;
    switch (monthName) {
        case "January":
            month = 1;
            break;
        case "February":
            month = 2;
            break;
        case "March":
            month = 3;
            break;
        case "April":
            month = 4;
            break;
        case "May":
            month = 5;
            break;
        case "June":
            month = 6;
            break;
        case "July":
            month = 7;
            break;
        case "August":
            month = 8;
            break;
        case "September":
            month = 9;
            break;
        case "October":
            month = 10;
            break;
        case "November":
            month = 11;
            break;
        case "December":
            month = 12;
            break;
    }
    return month;
}

