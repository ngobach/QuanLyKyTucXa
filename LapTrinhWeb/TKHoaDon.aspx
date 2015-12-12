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
                            CssClass="btn btn-primary" OnClick="btnChuaTT_Click" />
                </div>
            </div>
            <div class="col-xs-4">
                <div class="well well-sm text-center">
                    <h3>Số hóa đơn đã thanh toán:</h3>
                    <h1><asp:Label runat="server" ID="lblDaTT" CssClass="text-success" Text=""/></h1>
                    <asp:Button runat="server" ID="btnDaTT" Text="Chi tiết"
                            CssClass="btn btn-primary" OnClick="btnDaTT_Click"/>
                </div>
            </div>
            

        </div>
        
        <div class="row">
            <div class="col-lg-12">
            <asp:GridView runat="server" ID="Grid" CssClass="table table-hover table-bordered"
                AllowPaging="True" PageSize="5" AutoGenerateColumns="False"
                OnPageIndexChanging="Grid_PageIndexChanging">
                <PagerStyle CssClass="pagination-ys" />
                <Columns>
                    <asp:BoundField
                        DataField="ID" HeaderText="ID">
                        <HeaderStyle Width="5%" CssClass="text-center"/>
                        <ItemStyle CssClass="text-center" Font-Bold="true"/>
                    </asp:BoundField>
                    <asp:BoundField
                        DataField="MaHopDong" HeaderText="Mã HD">
                        <HeaderStyle Width="15%" CssClass="text-center"/>
                        <ItemStyle CssClass="text-center"/>
                    </asp:BoundField>
                    <asp:BoundField
                        DataField="Nam" HeaderText="Năm">
                        <HeaderStyle Width="5%" CssClass="text-center"/>
                        <ItemStyle CssClass="text-center"/>
                    </asp:BoundField>
                    <asp:BoundField
                        DataField="Thang" HeaderText="Tháng">
                        <HeaderStyle Width="5%" CssClass="text-center"/>
                        <ItemStyle CssClass="text-center"/>
                    </asp:BoundField>
                    <asp:BoundField
                        DataField="Tong" HeaderText="Tổng tiền">
                        <HeaderStyle Width="20%" CssClass="text-center"/>
                        <ItemStyle CssClass="text-center"/>
                    </asp:BoundField>
                    <asp:TemplateField HeaderText="Trạng thái">
                        <HeaderStyle Width="20%" CssClass="text-center"/>
                        <ItemStyle CssClass="text-center"/>
                        <ItemTemplate>
                            <%# ((bool)Eval("DaThanhToan"))?"<span class=\"text-success\">Đã thanh toán</span>":"<span class=\"text-danger\">Chưa thanh toán</span>" %>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Thao tác">
                        <HeaderStyle Width="20%" CssClass="text-center" />
                        <ItemStyle CssClass="text-center" />
                        <ItemTemplate>
                            <div class="btn-group btn-group-justified">
                                <asp:LinkButton ID="btnEdit" runat="server" Text="Cập nhật" CommandName="CapNhat" CssClass="btn btn-sm btn-primary" CommandArgument='<%# Eval("ID") %>'/>
                                <asp:LinkButton ID="btnDelete" runat="server" Text="Xóa" CommandName="Xoa" CssClass="btn btn-sm btn-danger" CommandArgument='<%# Eval("ID") %>'/>
                            </div>
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
            </div>
        </div>
    </form>
</asp:Content>