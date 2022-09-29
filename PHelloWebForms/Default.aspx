<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="PHelloWebForms.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="BtnProcessar" runat="server" Text="Processar" OnClick="BtnProcessar_Click" />
        </div>
        <p>
            &nbsp;</p>
        <p>
            <asp:Label ID="LblNome" runat="server" Text="Nome"></asp:Label>
        </p>
        <p>
            <asp:TextBox ID="TxtNome" runat="server" OnTextChanged="TextBox2_TextChanged"></asp:TextBox>
            </p>
        <p>
            <asp:Label ID="LblProcessado" runat="server" Text="Processado"></asp:Label>
        </p>
        <p>
            <asp:TextBox ID="txtProcessar" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
        </p>
    </form>
</body>
</html>
