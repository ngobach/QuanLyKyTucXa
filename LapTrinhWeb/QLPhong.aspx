<%@ Page Title="Quản lý phòng" Language="C#" MasterPageFile="~/MainTemplate.Master" AutoEventWireup="true" CodeBehind="QLPhong.aspx.cs" Inherits="LapTrinhWeb.QLPhong" %>
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
                        DataField="ID" ReadOnly="True" HeaderText="ID Phòng">
                        <HeaderStyle Width="20%" CssClass="text-center"/>
                        <ItemStyle CssClass="text-center" />
                    </asp:BoundField>
                    <asp:BoundField
                        DataField="TenPhong" ReadOnly="True" HeaderText="Tên Phòng">
                        <HeaderStyle Width="60%" CssClass="text-center"/>
                        <ItemStyle CssClass="text-center" />
                    </asp:BoundField>
                    <asp:TemplateField HeaderText="Thao tác">
                        <HeaderStyle Width="20%" CssClass="text-center" />
                        <ItemStyle CssClass="text-center" />
                        <ItemTemplate>
                            <asp:Button ID="btnEdit" runat="server" Text="Sửa" CommandName="Sua" CssClass="btn btn-sm btn-primary" CommandArgument='<%# Eval("ID") %>'/>
                            <asp:Button ID="btnDelete" runat="server" Text="Xóa" CommandName="Xoa" CssClass="btn btn-sm btn-danger" CommandArgument='<%# Eval("ID") %>'/>
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
                <div class="col-xs-8">
                    <div class="form-group">
                        <label>Tên phòng</label>
                        <asp:TextBox ID="txtName" runat="server" CssClass="form-control" />
                    </div>
                </div>
                <div class="col-xs-4">
                    <div class="form-group">
                        <label>Thao tác</label><br />
                        <div class="btn-group">
                            <asp:Button runat="server" ID="btnAdd" Text="Thêm Mới"
                                OnClick="btnAdd_Click" CssClass="btn btn-primary" />
                            <asp:Button runat="server" ID="btnUpdate" Text="Cập nhật"
                                OnClick="btnUpdate_Click" CssClass="btn btn-primary" />
                            <asp:Button runat="server" ID="btnCancel" Text="Hủy"
                                OnClick="btnCancel_Click" CssClass="btn btn-info" />
                        </div>
                    </div>
                </div>
            </div>
            <asp:ScriptManager runat="server"/>
        </form>
    </div>
</asp:Content>