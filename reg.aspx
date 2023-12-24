<%@ Page Language="C#" Title="Регистрация" AutoEventWireup="true" CodeBehind="reg.aspx.cs" Inherits="TraidApp.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        body {
            background-color:   #F2F2F2;
            font-family: Arial, sans-serif;
        }
        .auto-style2 {
            width: 155px;
            font-size: large;
        }
        .auto-style3 {
            width: 329px;
        }
        .auto-style4 {
            width: 372px;
            height: 26px;
        }
        .auto-style7 {
            height: 26px;
        }
        .auto-style8 {
            height: 26px;
            text-align: center;
        }
        .auto-style9 {
            text-align: center;
            font-size: large;
        }
        .auto-style10 {
            height: 737px;
        }
        .auto-style11 {
            font-size: medium;
        }
        .auto-style12 {
            width: 372px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style10">
            <asp:Label ID="Label1" runat="server" Font-Size="Larger" Text="TraidApp"></asp:Label>
            <table style="width: 100%;">
                <tr>
                    <td class="auto-style12">
                        <asp:Label ID="errors" runat="server" ForeColor="Red"></asp:Label>
                    </td>
                    <td class="auto-style9" colspan="2">Форма регистрации</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style12">&nbsp;</td>
                    <td class="auto-style2">Логин</td>
                    <td class="auto-style3">
                        <asp:TextBox ID="TextBox1" runat="server" Width="270px"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style12">&nbsp;</td>
                    <td class="auto-style2">Пароль</td>
                    <td class="auto-style3">
                        <asp:TextBox ID="TextBox2" runat="server" Width="270px"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style12">&nbsp;</td>
                    <td class="auto-style2">Имя</td>
                    <td class="auto-style3">
                        <asp:TextBox ID="TextBox3" runat="server" Width="268px"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style12">&nbsp;</td>
                    <td class="auto-style2">Фамилия</td>
                    <td class="auto-style3">
                        <asp:TextBox ID="TextBox4" runat="server" Width="267px"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style12">&nbsp;</td>
                    <td class="auto-style2">Магазин</td>
                    <td class="auto-style3">
                        <asp:TextBox ID="TextBox5" runat="server" Width="267px"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style12">&nbsp;</td>
                    <td class="auto-style2">Адрес</td>
                    <td class="auto-style3">
                        <asp:TextBox ID="TextBox6" runat="server" Width="267px"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style4"></td>
                    <td class="auto-style8" colspan="2">
                        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Зарегистрироваться!" Width="232px" CssClass="auto-style11" />
                    </td>
                    <td class="auto-style7"></td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
