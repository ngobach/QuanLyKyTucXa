<%@ Page Title="Quản lý User" Language="C#" MasterPageFile="~/MainTemplate.Master" AutoEventWireup="true" CodeBehind="QLUser.aspx.cs" Inherits="LapTrinhWeb.QLUser" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit"%>
<asp:Content ID="ContentSec" ContentPlaceHolderID="ContentSection" runat="server">
    <div class="section">
        <div class="well well-sm">
            <form runat="server">
                <asp:GridView runat="server" ID="Grid" CssClass="table table-hover table-bordered"
                    AllowPaging="True" PageSize="5" AutoGenerateColumns="False"
                    OnRowCommand="Grid_RowCommand"
                    OnPageIndexChanging="Grid_PageIndexChanging">
                    <PagerStyle CssClass="pagination-ys" />
                    <Columns>
                        <asp:BoundField
                            DataField="Username" ReadOnly="True" HeaderText="Tên đăng nhập">
                            <HeaderStyle Width="10%" CssClass="text-center"/>
                            <ItemStyle CssClass="text-center" />
                        </asp:BoundField>
                        <asp:BoundField
                            DataField="HoTen" ReadOnly="True" HeaderText="Họ tên">
                            <HeaderStyle Width="10%" CssClass="text-center"/>
                            <ItemStyle CssClass="text-center" />
                        </asp:BoundField>
                        <asp:BoundField
                            DataField="NgaySinh" ReadOnly="True" HeaderText="Ngày sinh"
                            DataFormatString="{0:yyyy-MM-dd}">
                            <HeaderStyle Width="10%" CssClass="text-center"/>
                            <ItemStyle CssClass="text-center" />
                        </asp:BoundField>
                        <asp:BoundField
                            DataField="QueQuan" ReadOnly="True" HeaderText="Quê quán">
                            <HeaderStyle Width="10%" CssClass="text-center"/>
                            <ItemStyle CssClass="text-center" />
                        </asp:BoundField>
                        <asp:TemplateField HeaderText="Thao tác">
                            <HeaderStyle Width="10%" CssClass="text-center" />
                            <ItemStyle CssClass="text-center" />
                            <ItemTemplate>
                                <asp:Button ID="btnEdit" runat="server" Text="Sửa" CommandName="Sua" CssClass="btn btn-sm btn-primary" CommandArgument='<%# Eval("Username") %>'/>
                                <asp:Button ID="btnDelete" runat="server" Text="Xóa" CommandName="Xoa" CssClass="btn btn-sm btn-danger" CommandArgument='<%# Eval("Username") %>'/>
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
                    <div class="col-sm-6">
                        <div class="form-group">
                            <label>Tên đăng nhập</label>
                            <asp:TextBox ID="txtUsername" runat="server" CssClass="form-control" />
                        </div>
                        <div class="form-group">
                            <label>Mật khẩu</label>
                            <asp:TextBox ID="txtPassword" runat="server" CssClass="form-control" TextMode="Password"/>
                        </div>
                        <div class="form-group">
                            <label>Nhập lại mật khẩu</label>
                            <asp:TextBox ID="txtRePassword" runat="server" CssClass="form-control" TextMode="Password"/>
                        </div>
                    </div>
                    <div class="col-sm-6">
                        <div class="form-group">
                            <label>Họ và tên</label>
                            <asp:TextBox ID="txtFullName" runat="server" CssClass="form-control" />
                        </div>
                        <div class="form-group">
                            <label>Ngày sinh</label>
                            <asp:TextBox ID="txtNgaySinh" runat="server" CssClass="form-control"/>
                            <ajaxToolkit:CalendarExtender runat="server"
                                TargetControlID="txtNgaySinh"
                                Format="yyyy-MM-dd"/>
                        </div>
                        <div class="form-group">
                            <label>Quê quán</label>
                            <asp:TextBox ID="txtQueQuan" runat="server" CssClass="form-control" />
                        </div>
                    </div>
                </div>
                <div class="row">
                    <div class="col-xs-12 text-right">
                        <asp:Button runat="server" ID="btnAdd" Text="Thêm Mới"
                            OnClick="btnAdd_Click" CssClass="btn btn-primary" />
                        <asp:Button runat="server" ID="btnUpdate" Text="Cập nhật"
                            OnClick="btnUpdate_Click" CssClass="btn btn-primary" />
                        <asp:Button runat="server" ID="btnCancel" Text="Hủy"
                            OnClick="btnCancel_Click" CssClass="btn btn-info" />
                    </div>
                </div>
                <asp:ScriptManager runat="server"/>
            </form>
        </div>
    </div>
</asp:Content>