function ShowMessage(Messagetext, Title, Image) {
    try {
        $.noConflict();
        $("<div class='dialog_content '> <br /> " + Messagetext + "</div>").dialog({

            title: Title.toUpperCase(),
            modal: true,
            overflow: "hidden",
            resizable: false,
            closeOnEscape: false,
            show: 'slide',
            buttons: {
                "Close": function () {

                    $(this).dialog("close");
                }

            }

        });
    }
    catch (e) {
    }
}
function ShowDiv(div, Title, Image) {

    $.noConflict();
    $(div).dialog({

        title: Title.toUpperCase(),
        modal: true,
        overflow: "hidden",
        resizable: false,
        closeOnEscape: false,
        show: 'slide',
        buttons: {
            "Close": function () {

                $(this).dialog("close");
            }

        }

    });
}

function ShowImages(Title, Image) {
    // $.noConflict();
    // var img = $("#"+Image);
    $("<div></div>").append(Image).dialog({

        title: Title.toUpperCase(),
        modal: true,
        overflow: "hidden",
        resizable: false,
        closeOnEscape: false,
        show: 'slide',
        buttons: {
            "Close": function () {

                $(this).dialog("close");
            }

        }

    });

}

var formatAllow = ["JPG", "JFIF", "EXIF", "TIFF", "GIF", "BMP", "PNG"];
function formatURL(format) {
    switch (format.toUpperCase()) {
        case 'DOC':
            return "../Images/documentLogo/Doc.png";
            break;
        case 'DOCX':
            return "../Images/documentLogo/Docx.jpg";
            break;
        case 'PDF':
            return "../Images/documentLogo/pdf.jpg";
            break;
        case 'RTF':
            return "../Images/documentLogo/rtf.jpg";
            break;
        case 'TXT':
            return "../Images/documentLogo/txt.jpg";
            break;
    }
    return "";
}


function ShowImageReadURL(input, imageId) {
    if (input.files && input.files[0]) {
        var fileName = input.files[0].name;
        var ext = fileName.substr(fileName.lastIndexOf('.') + 1);

        if (formatAllow.indexOf(ext.toUpperCase()) < 0) {
            $('#' + imageId).attr('src', formatURL(ext));
        }
        else {
            var reader = new FileReader();
            reader.onload = function (e) {
                $('#' + imageId).attr('src', e.target.result);
            }
            reader.readAsDataURL(input.files[0]);
        }
    }
}

function DatePicker(DateControl) {
    try {
        var date_settings = {
            //  dateFormat: "MM/dd/yy",//dd/M/yy",
            changeYear: true,
            changeMonth: true,
            yearRange: '1964:2091',
            defaultDate: new Date()
        }
        var control = $(DateControl);
        if (control != null && control != undefined)
        { $(DateControl).datepicker(date_settings); }
    }
    catch (e) {
        $.noConflict();
        var date_settings = {
            //dateFormat: "MM/dd/yy",//dd/M/yy",
            changeYear: true,
            changeMonth: true,
            yearRange: '1964:2091',
            defaultDate: new Date()
        }
        var control = $(DateControl);
        if (control != null && control != undefined)
        { $(DateControl).datepicker(date_settings); }
    }

}

function EnabledisableControlOnCheckBox(checkbox, control) {
    if ($("#" + checkbox).is(':checked')) {
        $("#" + control).removeAttr("disabled");
    }
    else { $("#" + control).attr("disabled", "disabled"); }
}


function EnabledisableControlOnCheckBoxWorkExperience(checkbox, control) {
    if ($("#" + checkbox).is(':checked'))
    { $("#" + control).attr("disabled", "disabled"); }
    else
    {
        $("#" + control).removeAttr("disabled");
    }
};
function Redirect(formName) {
    window.location.href = formName;
}
function Accordian(accordianObj) {
    try {
        $(accordianObj).accordion();
    }
    catch (e) {
    }

};
function Tab(tabObj) {
    try {
        $(tabObj).tabs({
            collapsible: true,
            hide: { effect: "highlight", duration: 1000 }

        });
    }
    catch (e) {
    }

}
function IsEmptyData(e) {
    var txtComments = $(e).parent("td").find("#txtComments").val();
    if ($.trim(txtComments) == "" || $.trim(txtComments) == null || $.trim(txtComments) == undefined) {
        alert("Please enter comment");
        return false;
    }
    else {
        return true;
    }
}

function RedirectWithQS(formName) {
    var qs = window.location.href.slice(window.location.href.indexOf('?') + 1).split('&')[0]

    window.location.href = formName + "?" + qs;
}


function loadURL(item) {
    var fetchurlid = $(item).attr('fetchurlid');
    var url = $("#" + fetchurlid).val();
    var x = screen.width / 2 - 700 / 2;
    var y = screen.height / 2 - 450 / 2;
    if (url.indexOf('http') == -1) {
        window.open("http://" + url, "Web", 'width=500,height=200,left=' + x + ',top=' + y);
    }
    else {
        window.open(url, "Web", 'width=500,height=200,left=' + x + ',top=' + y);
    }
}

function OpenPageInDialogue(PageUrl,item) {
    try {

       // $.noConflict();
        $("<div id='tempdiv'> <br /> </div>").load(PageUrl + "?JobId=" + item.title).dialog({

           // title: Title.toUpperCase(),
            modal: true,
            overflow: "hidden",
            resizable: false,
            show: 'slide',
            width: '650px',
            closeOnEscape: true,
            show: { effect: 'drop', direction: "up" },
            dialogClass: 'no-close success-dialog',
            buttons: {
                "Close": function () {
                    $(".ui-dialog-titlebar-close").trigger('click');
                }

            }

        });
    }
    catch (e) {
    }
    return false;
}