<%@ Page Language="C#" title="Логин" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="TraidApp.WebForm2" %>

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
        .auto-style1 {
            width: 406px;
        }
        .auto-style2 {
            font-size: x-large;
        }
        .auto-style3 {
            font-size: large;
        }
        .auto-style4 {
            font-size: large;
            margin-top: 0px;
        }
        .auto-style6 {
            height: 889px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style6">
            <asp:Label ID="Label1" runat="server" Font-Size="Larger" Text="TraidApp" CssClass="auto-style2" ForeColor="#34495E"></asp:Label>
            <div>
                <br />
                <table style="width: 100%;">
                    <tr>
                        <td class="auto-style1">
                            <asp:Label ID="errors" runat="server" ForeColor="Red"></asp:Label>
                        </td>
                        <td>
                            <asp:Label ID="Label2" runat="server" Text="Войдите в свой профиль!" CssClass="auto-style3"></asp:Label>
                        </td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style1">&nbsp;</td>
                        <td>
                            <asp:Login ID="Login1" runat="server" Height="99px">
                                <LayoutTemplate>
                                    <table cellpadding="1" cellspacing="0" style="border-collapse: collapse;">
                                        <tr>
                                            <td class="auto-style2">
                                                <table cellpadding="0">
                                                    <tr>
                                                        <td align="center" colspan="2" class="auto-style3">Выполнить вход</td>
                                                    </tr>
                                                    <tr>
                                                        <td align="right">
                                                            <asp:Label ID="UserNameLabel" runat="server" AssociatedControlID="UserName" CssClass="auto-style3">Имя пользователя:</asp:Label>
                                                        </td>
                                                        <td>
                                                            <asp:TextBox ID="UserName" runat="server"></asp:TextBox>
                                                            <asp:RequiredFieldValidator ID="UserNameRequired" runat="server" ControlToValidate="UserName" ErrorMessage="Поле &quot;Имя пользователя&quot; является обязательным." ToolTip="Поле &quot;Имя пользователя&quot; является обязательным." ValidationGroup="Login1">*</asp:RequiredFieldValidator>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td align="right">
                                                            <asp:Label ID="PasswordLabel" runat="server" AssociatedControlID="Password" CssClass="auto-style3">Пароль:</asp:Label>
                                                        </td>
                                                        <td>
                                                            <asp:TextBox ID="Password" runat="server" TextMode="Password"></asp:TextBox>
                                                            <asp:RequiredFieldValidator ID="PasswordRequired" runat="server" ControlToValidate="Password" ErrorMessage="Поле &quot;Пароль&quot; является обязательным." ToolTip="Поле &quot;Пароль&quot; является обязательным." ValidationGroup="Login1">*</asp:RequiredFieldValidator>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td colspan="2" class="auto-style3">&nbsp;</td>
                                                    </tr>
                                                    <tr>
                                                        <td align="center" colspan="2" style="color: Red;" class="auto-style3">&nbsp;</td>
                                                    </tr>
                                                    <tr>
                                                        <td align="right" colspan="2">
                                                            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Регистрация" Width="200px" CssClass="auto-style4" />
                                                            <asp:Button ID="LoginButton" runat="server" CommandName="Login" OnClick="LoginButton_Click" Text="Выполнить вход" ValidationGroup="Login1" CssClass="auto-style3" Width="200px" />
                                                        </td>
                                                    </tr>
                                                </table>
                                            </td>
                                        </tr>
                                    </table>
                                </LayoutTemplate>
                            </asp:Login>
                        </td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style1">&nbsp;</td>
                        <td>&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style1">&nbsp;</td>
                        <td>&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                </table>
                <br />
                <br />
                <br />
            </div>
        </div>
    </form>
</body>
</html>
