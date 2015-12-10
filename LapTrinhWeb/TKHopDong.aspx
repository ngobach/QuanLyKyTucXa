<%@ Page Title="Quản lý Hợp Đồng" Language="C#" MasterPageFile="~/MainTemplate.Master" AutoEventWireup="true" CodeBehind="TKHopDong.aspx.cs" Inherits="LapTrinhWeb.TKHopDong" %>
<asp:Content ID="ContentSec" ContentPlaceHolderID="ContentSection" runat="server">
    <form runat="server">
        <div class="row">
            <div class="col-xs-4">
                <div class="well well-sm text-center">
                    <h3>Tổng số hợp đồng:</h3>
                    <h1><asp:Label runat="server" ID="lblTong" CssClass="text-success" Text=""/></h1>
                </div>
            </div>
            <div class="col-xs-4">
                <div class="well well-sm text-center">
                    <h3>Số hợp đồng đã hết hạn:</h3>
                    <h1><asp:Label runat="server" ID="lblHH" CssClass="text-danger" Text=""/></h1>
                </div>
            </div>
            <div class="col-xs-4">
                <div class="well well-sm text-center">
                    <h3>Số hợp đồng đã kết thúc:</h3>
                    <h1><asp:Label runat="server" ID="lblKetThuc" CssClass="text-danger" Text=""/></h1>
                </div>
            </div>
        </div>
    </form>
</asp:Content>