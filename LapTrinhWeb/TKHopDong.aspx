<%@ Page Title="Quản lý Hợp Đồng" Language="C#" MasterPageFile="~/MainTemplate.Master" AutoEventWireup="true" CodeBehind="TKHopDong.aspx.cs" Inherits="LapTrinhWeb.TKHopDong" %>
<asp:Content ID="ContentSec" ContentPlaceHolderID="ContentSection" runat="server">
    <form runat="server">
        <div class="row">
            <div class="col-xs-4">
                <div class="well well-sm text-center">
                    <h3>Tổng số hợp đồng:</h3>
                    <h1><asp:Label runat="server" ID="lblTong" CssClass="text-success" Text=""/></h1>
                    <asp:Button runat="server" ID="btnTong" Text="Chi tiết"
                            CssClass="btn btn-primary" OnClick="btnTong_Click"/>
                </div>
            </div>
            <div class="col-xs-4">
                <div class="well well-sm text-center">
                    <h3>Số hợp đồng đã hết hạn:</h3>
                    <h1><asp:Label runat="server" ID="lblHH" CssClass="text-danger" Text=""/></h1>
                    <asp:Button runat="server" ID="btnChuaTT" Text="Chi tiết"
                            CssClass="btn btn-primary" OnClick="btnChuakt_Click" />
                </div>
            </div>
            <div class="col-xs-4">
                <div class="well well-sm text-center">
                    <h3>Số hợp đồng đã kết thúc:</h3>
                    <h1><asp:Label runat="server" ID="lblKetThuc" CssClass="text-danger" Text=""/></h1>
                    <asp:Button runat="server" ID="btnDaTT" Text="Chi tiết"
                            CssClass="btn btn-primary" OnClick="btnDakt_Click"/>
                </div>
            </div>
        </div>

        <div class="row">
            <div class="col-lg-12">
            <asp:GridView runat="server" ID="Grid" CssClass="table table-hover table-bordered"
                AllowPaging="True" PageSize="5" AutoGenerateColumns="False"
                OnRowCommand="Grid_RowCommand"
                OnPageIndexChanging="Grid_PageIndexChanging">
                <PagerStyle CssClass="pagination-ys" />
                <Columns>
                    <asp:BoundField
                        DataField="MaHopDong" ReadOnly="True" HeaderText="Mã hợp đồng">
                        <HeaderStyle Width="10%" CssClass="text-center"/>
                        <ItemStyle CssClass="text-center" Font-Bold="true"/>
                    </asp:BoundField>
                    <asp:BoundField
                        DataField="NgayBatDau" ReadOnly="True" HeaderText="Ngày bắt đầu"
                        DataFormatString="{0:dd/MM/yyy}">
                        <HeaderStyle Width="10%" CssClass="text-center"/>
                        <ItemStyle CssClass="text-center" />
                    </asp:BoundField>
                    <asp:BoundField
                        DataField="NgayHetHan" ReadOnly="True" HeaderText="Ngày hết hạn"
                        DataFormatString="{0:dd/MM/yyy}">
                        <HeaderStyle Width="10%" CssClass="text-center"/>
                        <ItemStyle CssClass="text-center" />
                    </asp:BoundField>
                    <asp:BoundField
                        DataField="TenPhong" ReadOnly="True" HeaderText="Phòng">
                        <HeaderStyle Width="10%" CssClass="text-center"/>
                        <ItemStyle CssClass="text-center" />
                    </asp:BoundField>
                    <asp:BoundField
                        DataField="SoNguoi" ReadOnly="True" HeaderText="Số người ở"
                        DataFormatString="<em><b>{0:d}</b> người</em>"
                        HtmlEncodeFormatString="false">
                        <HeaderStyle Width="10%" CssClass="text-center"/>
                        <ItemStyle CssClass="text-center" />
                    </asp:BoundField>
                    <asp:TemplateField HeaderText="Đã hết hạn">
                        <HeaderStyle Width="10%" CssClass="text-center"/>
                        <ItemStyle CssClass="text-center" Font-Bold="true"/>
                        <ItemTemplate>
                            <%# (Int32.Parse(Eval("DaHetHan").ToString())==1) ? "<span class=\"text-danger\">Đã hết hạn</span>" : "<span class=\"text-success\">Chưa hết hạn</span>" %>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Đã kết thúc">
                        <HeaderStyle Width="10%" CssClass="text-center"/>
                        <ItemStyle CssClass="text-center" Font-Bold="true"/>
                        <ItemTemplate>
                            <%# (Boolean.Parse(Eval("DaKetThuc").ToString())) ? "<span class=\"text-danger\">Đã kết thúc</span>" : "<span class=\"text-success\">Chưa kết thúc</span>" %>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Thao tác">
                        <HeaderStyle Width="20%" CssClass="text-center" />
                        <ItemStyle CssClass="text-center" />
                        <ItemTemplate>
                            <div class="btn-group btn-group-justified">
                                <asp:LinkButton ID="btnHoaDon" runat="server" Text="Hóa đơn" CommandName="HoaDon" CssClass="btn btn-sm btn-default" CommandArgument='<%# Eval("MaHopDong") %>'/>
                            </div>
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
            </div>
        </div>
    </form>
</asp:Content>