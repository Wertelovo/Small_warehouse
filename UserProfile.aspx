<%@ Page Title="Профиль" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="UserProfile.aspx.cs" Inherits="TraidApp.UserProfile" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
        <div class="text-center">
            <h1>Профиль пользователя<table style="width: 100%; height: 241px;">
                <tr>
                    <td style="height: 49px; width: 488px"></td>
                    <td rowspan="4" style="width: 306px">
            <table>
                <tr>
                    <td class="text-start" style="font-size: large">Логин:</td>
                    <td><asp:TextBox ID="userLoginTextBox" runat="server" Enabled="false" style="font-size: large" /></td>
                </tr>
                <tr>
                    <td class="text-start" style="font-size: large">Пароль:</td>
                    <td><asp:TextBox ID="passwordTextBox" runat="server" TextMode="Password" style="font-size: large" /></td>
                </tr>
                <tr>
                    <td class="text-start" style="font-size: large">Имя:</td>
                    <td><asp:TextBox ID="firstNameTextBox" runat="server" style="font-size: large" /></td>
                </tr>
                <tr>
                    <td class="text-start" style="font-size: large">Фамилия:</td>
                    <td><asp:TextBox ID="lastNameTextBox" runat="server" style="font-size: large" /></td>
                </tr>
                <tr>
                    <td class="text-start" style="font-size: large">Название магазина:</td>
                    <td><asp:TextBox ID="shopNameTextBox" runat="server" style="font-size: large" /></td>
                </tr>
                <tr>
                    <td class="text-start" style="font-size: large">Адрес:</td>
                    <td><asp:TextBox ID="addressTextBox" runat="server" style="font-size: large" /></td>
                </tr>
            </table>
                    </td>
                    <td style="height: 49px"></td>
                </tr>
                <tr>
                    <td style="width: 488px">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td style="width: 488px">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td style="width: 488px">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                </table>
            </h1>
            <br />
            <asp:Button ID="saveButton" runat="server" Text="Сохранить" OnClick="saveButton_Click" />
        </div>
</asp:Content>
