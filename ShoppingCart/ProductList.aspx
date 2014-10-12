<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ProductList.aspx.cs" Inherits="ShoppingCart.ProductList" Title="Products" MasterPageFile="~/Site.Master" %>


<asp:Content ID="ProductListContent" ContentPlaceHolderID="MainContent" runat="server">
    <hgroup>
        <h2><%: Page.Title %></h2>
    </hgroup>
    <asp:ListView ID="listViewProductList" runat="server" DataKeyNames="ProductID" GroupItemCount="3" ItemType="ShoppingCart.Models.Product" SelectMethod="GetProducts">


        <GroupTemplate>
            <tr id="itemPlaceholderContainer" runat="server">
                <td id="itemPlaceholder" runat="server"></td>
            </tr>
        </GroupTemplate>

        <ItemTemplate>
            <td runat="server">
                <table>
                    <tr>
                        <td>
                            <a href="<%#: GetRouteUrl("ProductByNameRoute", new {productName = Item.ProductName}) %>">
                                <image src='/Catalog/<%#:Item.ImagePath%>'
                                    width="100" height="75" border="1" />
                            </a>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <a href="<%#: GetRouteUrl("ProductByNameRoute", new {productName = Item.ProductName}) %>">
                                <%#:Item.ProductName%>
                            </a>
                            <br />
                            <span>
                                <b>Price: </b><%#:String.Format("{0:c}", Item.UnitPrice)%>
                            </span>
                            <br />
                            <a href="#">
                                <span class="ProductListItem">
                                    <b>Add To Cart<b>
                                </span>
                            </a>
                        </td>
                    </tr>
                    <tr>
                        <td>&nbsp;</td>
                    </tr>
                </table>

            </td>
        </ItemTemplate>


        <LayoutTemplate>
            <table style="width: 100%;">
                <tbody>
                    <tr>
                        <td>
                            <table id="groupPlaceholderContainer" runat="server" style="width: 100%">
                                <tr id="groupPlaceholder"></tr>
                            </table>
                        </td>
                    </tr>
                    <tr>
                        <td></td>
                    </tr>
                    <tr></tr>
                </tbody>
            </table>
        </LayoutTemplate>

    </asp:ListView>
</asp:Content>
