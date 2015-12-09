<%@ Page Title="Quản lý Sinh Viên" Language="C#" MasterPageFile="~/MainTemplate.Master" AutoEventWireup="true" CodeBehind="QLSinhVien.aspx.cs" Inherits="LapTrinhWeb.QLSinhVien" %>
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
                            DataField="MaSV" ReadOnly="True" HeaderText="Tên đăng nhập">
                            <HeaderStyle Width="10%" CssClass="text-center"/>
                            <ItemStyle CssClass="text-center" />
                        </asp:BoundField>
                        <asp:BoundField
                            DataField="HoTen" ReadOnly="True" HeaderText="Họ tên">
                            <HeaderStyle Width="10%" CssClass="text-center"/>
                            <ItemStyle CssClass="text-center" />
                        </asp:BoundField>
                        <asp:BoundField
                            DataField="SoDienThoai" ReadOnly="True" HeaderText="Số điện thoại"
                            DataFormatString="{0:d}">
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
                            DataField="GioiTinh" ReadOnly="True" HeaderText="Giới tính">
                            <HeaderStyle Width="5%" CssClass="text-center"/>
                            <ItemStyle CssClass="text-center" />
                        </asp:BoundField>
                        <asp:BoundField
                            DataField="QueQuan" ReadOnly="True" HeaderText="Quê quán">
                            <HeaderStyle Width="10%" CssClass="text-center"/>
                            <ItemStyle CssClass="text-center" />
                        </asp:BoundField>
                        <asp:BoundField
                            DataField="Lop" ReadOnly="True" HeaderText="Lớp">
                            <HeaderStyle Width="10%" CssClass="text-center"/>
                            <ItemStyle CssClass="text-center" />
                        </asp:BoundField>
                        <asp:BoundField
                            DataField="Khoa" ReadOnly="True" HeaderText="Khoa">
                            <HeaderStyle Width="10%" CssClass="text-center"/>
                            <ItemStyle CssClass="text-center" />
                        </asp:BoundField>
                        <asp:TemplateField HeaderText="Thao tác">
                            <HeaderStyle Width="10%" CssClass="text-center" />
                            <ItemStyle CssClass="text-center" />
                            <ItemTemplate>
                                <asp:Button ID="btnEdit" runat="server" Text="Sửa" CommandName="Sua" CssClass="btn btn-sm btn-primary" CommandArgument='<%# Eval("MaSV") %>'/>
                                <asp:Button ID="btnDelete" runat="server" Text="Xóa" CommandName="Xoa" CssClass="btn btn-sm btn-danger" CommandArgument='<%# Eval("MaSV") %>'/>
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
                            <label>Mã sinh viên</label>
                            <asp:TextBox ID="txtMaSV" runat="server" CssClass="form-control" />
                        </div>
                        <div class="form-group">
                            <label>Họ và tên</label>
                            <asp:TextBox ID="txtFullName" runat="server" CssClass="form-control" />
                        </div>
                        <div class="form-group">
                            <label>Ngày sinh</label>
                            <asp:TextBox ID="txtNgaySinh" runat="server" CssClass="form-control"/>
                            <ajaxToolkit:CalendarExtender runat="server"
                                TargetControlID="txtNgaySinh"
                                PopupButtonID="txtNgaySinh"
                                Format="yyyy-MM-dd"/>
                        </div>
                        <div class="form-group">
                            <label>Giới tính</label>
                            <asp:RadioButtonList runat="server" ID="radGioiTinh" RepeatDirection="Horizontal" CssClass="asp-radios">
                                <asp:ListItem Text="Nam" Value="Nam" />
                                <asp:ListItem Text="Nữ" Value="Nữ" />
                            </asp:RadioButtonList>
                        </div>
                    </div>
                    <div class="col-sm-6">
                        <div class="form-group">
                            <label>Quê quán</label>
                            <asp:TextBox ID="txtQueQuan" runat="server" CssClass="form-control" />
                        </div>
                        <div class="form-group">
                            <label>Số điện thoại</label>
                            <asp:TextBox ID="txtSDT" runat="server" CssClass="form-control" />
                        </div>
                        <div class="row">
                            <div class="col-xs-6">
                                <div class="form-group">
                                    <label>Lớp</label>
                                    <asp:TextBox ID="txtLop" runat="server" CssClass="form-control" />
                                </div>
                            </div>
                            <div class="col-xs-6">
                                <div class="form-group">
                                    <label>Khoa</label>
                                    <asp:TextBox ID="txtKhoa" runat="server" CssClass="form-control" />
                                </div>
                            </div>
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