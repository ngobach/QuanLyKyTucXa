<%@ Page Title="Quản lý Hợp Đồng" Language="C#" MasterPageFile="~/MainTemplate.Master" AutoEventWireup="true" CodeBehind="TKHoaDon.aspx.cs" Inherits="LapTrinhWeb.TKHoaDon" %>
<asp:Content ID="ContentSec" ContentPlaceHolderID="ContentSection" runat="server">
    <form runat="server">
        <div class="row">
            <div class="col-xs-4">
                <div class="well well-sm text-center">
                    <h3>Tổng số hóa đơn:</h3>
                    <h1><asp:Label runat="server" ID="lblTong" CssClass="text-success" Text=""/></h1>
                    <asp:Button runat="server" ID="btnTong" Text="Chi tiết"
                            CssClass="btn btn-primary" OnClick="btnTong_Click" />
                </div>
            </div>
            <div class="col-xs-4">
                <div class="well well-sm text-center">
                    <h3>Số hóa đơn chưa thanh toán:</h3>
                    <h1><asp:Label runat="server" ID="lblChuaTT" CssClass="text-danger" Text=""/></h1>
                    <asp:Button runat="server" ID="btnChuaTT" Text="Chi tiết"
                            CssClass="btn btn-primary" />
                </div>
            </div>
            <div class="col-xs-4">
                <div class="well well-sm text-center">
                    <h3>Số hóa đơn đã thanh toán:</h3>
                    <h1><asp:Label runat="server" ID="lblDaTT" CssClass="text-success" Text=""/></h1>
                    <asp:Button runat="server" ID="btnDaTT" Text="Chi tiết"
                            CssClass="btn btn-primary" />
                </div>
            </div>
        </div>
    </form>
</asp:Content>