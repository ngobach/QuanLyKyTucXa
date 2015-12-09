<%@ Page Title="Quản lý Hợp Đồng" Language="C#" MasterPageFile="~/MainTemplate.Master" AutoEventWireup="true" CodeBehind="QLHopDong.aspx.cs" Inherits="LapTrinhWeb.QLHopDong" %>
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
                            <asp:Button ID="btnEdit" runat="server" Text="Cập nhật" CommandName="CapNhat" CssClass="btn btn-sm btn-primary" CommandArgument='<%# Eval("MaHopDong") %>'/>
                            <asp:Button ID="btnDelete" runat="server" Text="Xóa" CommandName="Xoa" CssClass="btn btn-sm btn-danger" CommandArgument='<%# Eval("MaHopDong") %>'/>
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
            <div class="row">
                <div class="col-xs-2 col-xs-offset-5">
                    <asp:Button runat="server" ID="btnAdd" Text="Thêm Mới"
                        OnClick="btnAdd_Click" CssClass="btn btn-primary btn-block" />
                </div>
            </div>
            <asp:ScriptManager runat="server"/>
        </form>
    </div>
</asp:Content>