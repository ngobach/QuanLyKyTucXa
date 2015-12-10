<%@ Page Title="Quản lý hóa đơn" Language="C#" MasterPageFile="~/MainTemplate.Master" AutoEventWireup="true" CodeBehind="QLHoaDon.aspx.cs" Inherits="LapTrinhWeb.QLHoaDon" %>
<asp:Content ID="ContentSec" ContentPlaceHolderID="ContentSection" runat="server">
    <div class="well well-sm">
        <form runat="server">
            <asp:GridView runat="server" ID="Grid" CssClass="table table-hover table-bordered"
                AllowPaging="True" PageSize="5" AutoGenerateColumns="False"
                OnRowCommand="Grid_RowCommand"
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

            <%-- alert box --%>
            <% if (alert != null) { %>
            <div class="alert alert-dismissible alert-<%=alert.Class%>">
                <button type="button" class="close" data-dismiss="alert">×</button>
                <h4><%= alert.Title %></h4>
                <p><%= alert.Content %></p>
            </div>
            <% } %>
            <hr />
            <%-- form area --%>
            <asp:Panel runat="server" CssClass="row">
                <div class="col-xs-5">
                    <div class="form-group">
                        <label>Mã hợp đồng</label>
                        <asp:DropDownList ID="dropMaHD" runat="server" CssClass="form-control" />
                    </div>
                </div>
                <div class="col-xs-2">
                    <div class="form-group">
                        <label>Năm</label>
                        <asp:DropDownList ID="dropNam" runat="server" CssClass="form-control" />
                    </div>
                </div>
                <div class="col-xs-2">
                    <div class="form-group">
                        <label>Tháng</label>
                        <asp:DropDownList ID="dropThang" runat="server" CssClass="form-control" />
                    </div>
                </div>
                <div class="col-xs-3">
                    <div class="form-group">
                        <label></label>
                        <asp:LinkButton runat="server" ID="btnAdd" Text="Thêm Mới" OnClick="btnAdd_Click" CssClass="btn btn-primary btn-block" />
                    </div>
                </div>
            </asp:Panel>
        </form>
    </div>
</asp:Content>