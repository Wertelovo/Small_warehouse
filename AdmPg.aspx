<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="AdmPg.aspx.cs" Inherits="TraidApp.AdmPg" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:DB1ConnectionString %>" DeleteCommand="DELETE FROM [Products] WHERE [Id] = @original_Id" InsertCommand="INSERT INTO [Products] ([Name], [Price], [Quantity], [Description]) VALUES (@Name, @Price, @Quantity, @Description)" OldValuesParameterFormatString="original_{0}" SelectCommand="SELECT * FROM [Products]" UpdateCommand="UPDATE [Products] SET [Name] = @Name, [Price] = @Price, [Quantity] = @Quantity, [Description] = @Description WHERE [Id] = @original_Id">
        
        <DeleteParameters>
            <asp:Parameter Name="original_Id" Type="Int32" />
        </DeleteParameters>
        <InsertParameters>
            <asp:Parameter Name="Name" Type="String" />
            <asp:Parameter Name="Price" Type="Decimal" />
            <asp:Parameter Name="Quantity" Type="Int32" />
            <asp:Parameter Name="Description" Type="String" />
        </InsertParameters>
        <UpdateParameters>
            <asp:Parameter Name="Name" Type="String" />
            <asp:Parameter Name="Price" Type="Decimal" />
            <asp:Parameter Name="Quantity" Type="Int32" />
            <asp:Parameter Name="Description" Type="String" />
            <asp:Parameter Name="original_Id" Type="Int32" />
        </UpdateParameters>
    </asp:SqlDataSource>
    <asp:ValidationSummary ID="valSummaryError" runat="server" ValidationGroup="AccessErrorGroup" CssClass="alert alert-danger" DisplayMode="BulletList" HeaderText="Ошибка доступа:" style="left: 0px; top: 0px" />
    <table style="width: 100%; height: 235px;">
        <tr>
            <td rowspan="6" style="width: 412px">
                <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="Id" DataSourceID="SqlDataSource1" AllowPaging="True" AllowSorting="True" BackColor="#CCCCCC" BorderColor="#999999" BorderStyle="Solid" BorderWidth="3px" CellPadding="4" CellSpacing="2" ForeColor="Black">
                    <Columns>
                        <asp:BoundField DataField="Id" HeaderText="Id" InsertVisible="False" ReadOnly="True" SortExpression="Id" />
                        <asp:BoundField DataField="Name" HeaderText="Название" SortExpression="Name" />
                        <asp:BoundField DataField="Price" HeaderText="Цена" SortExpression="Price" />
                        <asp:BoundField DataField="Quantity" HeaderText="Количество" SortExpression="Quantity" />
                        <asp:BoundField DataField="Description" HeaderText="Описание" SortExpression="Description" />
                        <asp:CommandField HeaderText="Правка и удаление" ShowDeleteButton="True" ShowEditButton="True" />
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
            </td>
            <td class="text-center" colspan="2">Меню добавления товара</td>
            <td>
                <asp:Label ID="errors" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td style="width: 220px; height: 45px">Название</td>
            <td style="height: 45px; width: 218px">
                <asp:TextBox ID="TextBox1" runat="server" Width="206px"></asp:TextBox>
            </td>
            <td rowspan="2">&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 220px; height: 45px">Цена</td>
            <td style="height: 45px; width: 218px">
                <asp:TextBox ID="TextBox2" runat="server" Width="206px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 220px; height: 45px">Количество</td>
            <td style="height: 45px; width: 218px">
                <asp:TextBox ID="TextBox3" runat="server" Width="206px"></asp:TextBox>
            </td>
            <td rowspan="3"></td>
        </tr>
        <tr>
            <td style="width: 220px; height: 45px">Описание(Опционально)</td>
            <td style="height: 45px; width: 218px">
                <asp:TextBox ID="TextBox4" runat="server" Width="206px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="text-center" colspan="2" style="height: 40px">
                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Добавить!" />
            </td>
        </tr>
    </table>

</asp:Content>
