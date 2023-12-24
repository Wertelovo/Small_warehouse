<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="ToDoOrders.aspx.cs" Inherits="TraidApp.ToDoOrders" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:GridView ID="fileGridView" runat="server" AutoGenerateColumns="False" BackColor="#CCCCCC" BorderColor="#999999" BorderStyle="Solid" BorderWidth="3px" CellPadding="4" CellSpacing="2" ForeColor="Black">
    <Columns>
        <asp:BoundField DataField="FileName" HeaderText="Имя файла" />
        <asp:BoundField DataField="CreationTime" HeaderText="Дата создания" DataFormatString="{0:dd/MM/yyyy HH:mm:ss}" />
        <asp:TemplateField HeaderText="Скачать">
            <ItemTemplate>
                <asp:LinkButton ID="downloadLink" runat="server" Text="Скачать" CommandArgument='<%# Eval("FilePath") %>' OnClick="DownloadFile" />
            </ItemTemplate>
        </asp:TemplateField>
    </Columns>
        <FooterStyle BackColor="#CCCCCC" />
        <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#CCCCCC" ForeColor="Black" HorizontalAlign="Left" />
        <RowStyle BackColor="White" />
        <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
        <SortedAscendingCellStyle BackColor="#F1F1F1" />
        <SortedAscendingHeaderStyle BackColor="#808080" />
        <SortedDescendingCellStyle BackColor="#CAC9C9" />
        <SortedDescendingHeaderStyle BackColor="#383838" />
</asp:GridView>
</asp:Content>
