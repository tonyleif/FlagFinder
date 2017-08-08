
var redIsSelected = "";
var orangeIsSelected = "";

function clickColor(sender) {
    //console.log("clickColor(sender)");
    changeButton(sender);
    //console.log("after changeButton(sender)");
    var colorButtons = $(".filter-color");
    var filterStatuses = [];
    colorButtons.each((function (i) {
        var colorButton = $(this);
        var color = colorButton.val();
        var status = "";
        if (colorButton.hasClass("selected")) {
            status = "yes";
        } else if (colorButton.hasClass("not-selected")) {
            status = "no";
        }
        //console.log("pushing " + color + " | " + status);
        filterStatuses.push({ Filter: color, Status: status });
    }));

    var shapeButtons = $(".filter-shape");
    shapeButtons.each((function (i) {
        var shapeButton = $(this);
        var shape = shapeButton.val();
        var status = "";
        if (shapeButton.hasClass("selected-shape")) {
            status = "yes";
        } else if (shapeButton.hasClass("not-selected-shape")) {
            status = "no";
        }
        filterStatuses.push({ Filter: shape, Status: status });
    }));

    console.log("out of loop");

    var flagRows = $(".flag-tile"); //.flag-row
    var flagCount = 0;
    flagRows.each(function (row) {
        var flagRow = $(this);
        flagRow.show();
        flagCount++;
        $.each(filterStatuses, function (i) {
            if (filterStatuses[i].Status != "") {
                var checkBox = flagRow.find("." + filterStatuses[i].Filter + "-check");
                var checkBoxChecked = flagRow.is("[data-" + filterStatuses[i].Filter + "]");
                var colorIsSelected = (filterStatuses[i].Status == "yes");
                if ((!colorIsSelected && checkBoxChecked) ||
                    (colorIsSelected && !checkBoxChecked)) {
                    flagRow.hide();
                    flagCount--;
                    return false;
                }
            }
        });
    })

    //console.log("counter: " + $("#counter").text());
    //console.log("flagCount: " + flagCount);
    $("#counter").text(flagCount);
}



function changeButton(sender) {
    var clickedButton = $(sender);
    var glyphSpan = clickedButton.children();
    if (glyphSpan.hasClass("glyphicon-minus")) {
        //selected
        //clickedButton.removeClass("in-limbeau");
        if (clickedButton.hasClass("filter-color")) {
            clickedButton.removeClass("in-limbeau");
        } else {
            clickedButton.removeClass("in-limbeau-shape");
        }
        glyphSpan.removeClass("glyphicon-minus");
        glyphSpan.addClass("glyphicon-ok");
        clickedButton.css("background-color", clickedButton.val());
        if (clickedButton.hasClass("filter-color")) {
            clickedButton.addClass("selected");
        } else {
            clickedButton.addClass("selected-shape");
        }
        return true;
    } else if (glyphSpan.hasClass("glyphicon-ok")) {
        //not selected
        if (clickedButton.hasClass("filter-color")) {
            clickedButton.removeClass("selected");
        } else {
            clickedButton.removeClass("selected-shape");
        }
        //clickedButton.removeClass("selected");
        glyphSpan.removeClass("glyphicon-ok");
        glyphSpan.addClass("glyphicon-remove");
        //clickedButton.css("opacity", 1);
        //clickedButton.addClass("not-selected");
        if (clickedButton.hasClass("filter-color")) {
            clickedButton.addClass("not-selected");
        } else {
            clickedButton.addClass("not-selected-shape");
        }
        return false;
    } else if (glyphSpan.hasClass("glyphicon-remove")) {
        //in limbeau
        //clickedButton.removeClass("not-selected");
        if (clickedButton.hasClass("filter-color")) {
            clickedButton.removeClass("not-selected");
        } else {
            clickedButton.removeClass("not-selected-shape");
        }
        glyphSpan.removeClass("glyphicon-remove");
        glyphSpan.addClass("glyphicon-minus");
        //clickedButton.css("opacity", .6);
        clickedButton.css("background-color", clickedButton.val());
        //clickedButton.addClass("in-limbeau");
        if (clickedButton.hasClass("filter-color")) {
            clickedButton.addClass("in-limbeau");
        } else {
            clickedButton.addClass("in-limbeau-shape");
        }
        //glyphSpan.addClass("glyphicon-ok");
        //clickedButton.css("background-color", clickedButton.val());
        //clickedButton.addClass("selected");
        return true;
    }
}

$(function () {
    //Set button colors
    $(".filter-color").each(function () {
        $(this).css("background-color", $(this).val())
    });
});
