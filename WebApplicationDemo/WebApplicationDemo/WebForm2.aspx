<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="WebApplicationDemo.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script src="jquery-3.4.1.js"></script>
    <script src="jquery-ui.js"></script>
    <link href="jquery-ui.css" rel="stylesheet" />
    <script type ="text/javascript">
        $(document).ready(function () {
            debugger;
            $('#txtName').autocomplete({
                source: function (request, response)
                {
                    $.ajax({
                        url: 'CarService.asmx/GetCarNames',
                        method: 'post',
                        contentType: 'application/json; charset=utf-8',
                        data: JSON.stringify({ term: request.term }),
                        dataType: "JSON",
                        sucess: function (data) {
                            debugger;
                            response(data);
                            console.log(data);
                        },
                        error: function (err) {
                            debugger;
                            var dt = err.responseText;
                            console.log(dt);
                            alert(err);
                        }
                    });
                }
            });
        });
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Car Brand Name :
            <input id="txtName" type ="text" />
        </div>
    </form>
</body>
</html>


