<%@ Page Title="Quản lý Hợp Đồng" Language="C#" MasterPageFile="~/MainTemplate.Master" AutoEventWireup="true" CodeBehind="CTHopDong.aspx.cs" Inherits="LapTrinhWeb.CTHopDong" %>
<asp:Content ID="ContentSec" ContentPlaceHolderID="ContentSection" runat="server">
    <div class="well well-sm">
        <form runat="server">
            <% if (alert != null) { %>
            <div class="alert alert-dismissible alert-<%=alert.Class%>">
                <button type="button" class="close" data-dismiss="alert">×</button>
                <h4><%= alert.Title %></h4>
                <p><%= alert.Content %></p>
            </div>
            <% } %>
            <div class="row">
                <div class="col-xs-4">
                    <div class="form-group">
                        <label>Mã hợp đồng</label>
                        <asp:TextBox runat="server" ID="txtMaHD" CssClass="form-control" placeholder="Nhập mã hợp đồng"/>
                    </div>
                    <div class="form-group">
                        <label>Các phòng còn trống</label>
                        <asp:DropDownList runat="server" ID="dropPhong" CssClass="form-control" />
                    </div>
                </div>
                <div class="col-xs-4">
                    <div class="form-group">
                        <label>Ngày bắt đầu</label>
                        <asp:TextBox runat="server" ID="txtNgayBD" CssClass="form-control" Text="2015-11-11"/>
                    </div>
                    <ajaxToolkit:CalendarExtender runat="server" TargetControlID="txtNgayBD" Format="yyyy-MM-dd"/>
                    <div class="form-group">
                        <label>Ngày hết hạn</label>
                        <asp:TextBox runat="server" ID="txtNgayHH" CssClass="form-control" Text="2015-11-11"/>
                    </div>
                    <ajaxToolkit:CalendarExtender runat="server" TargetControlID="txtNgayHH" Format="yyyy-MM-dd"/>
                    <div class="form-group">
                        <asp:CheckBox runat="server" ID="chkKetThuc" Checked="false"/>&nbsp;
                        <label>Đã kết thúc?</label>
                    </div>
                </div>
                <div class="col-xs-4">
                    <div class="form-group">
                        <label>Danh sách sinh viên</label>
                        <asp:ListBox runat="server" ID="lstSinhVien" CssClass="form-control" Rows="5"/>
                    </div>
                    <div class="form-group">
                        <asp:DropDownList runat="server" CssClass="form-control" ID="dropSV" />
                    </div>
                    <div class="form-group">
                        <div class="btn-group btn-group-justified">
                            <asp:LinkButton ID="btnSVAdd" runat="server" Text="Thêm vào" CssClass="btn btn-default" OnClick="btnSVAdd_Click"/>
                            <asp:LinkButton ID="btnSVDelete" runat="server" Text="Xóa" CssClass="btn btn-danger" OnClick="btnSVDelete_Click"/>
                        </div>
                    </div>
                </div>
            </div>
            <hr />
            <div class="row">
                <div class="col-xs-2 col-xs-offset-4">
                    <asp:Button runat="server" ID="btnAdd" Text="Thêm Mới" CssClass="btn btn-primary btn-block" OnClick="btnAdd_Click"/>
                    <asp:Button runat="server" ID="btnUpdate" Text="Cập nhật" CssClass="btn btn-primary btn-block" OnClick="btnUpdate_Click"/>
                </div>
            </div>
            <asp:ScriptManager runat="server"/>
        </form>
    </div>
</asp:Content>