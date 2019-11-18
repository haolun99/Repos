<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplicationDemo.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script src="jquery-3.4.1.js"></script>
    <script src="jquery-ui.js"></script>
    <link href="jquery-ui.css" rel="stylesheet" />
    <script type ="text/javascript">
        $(document).ready(function () {
            $('#txtName').autocomplete({
                source: 'CarHandler.ashx'
            })
        });
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Car Brand Name :
            <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
        </div>
    </form>
</body>
</html>
