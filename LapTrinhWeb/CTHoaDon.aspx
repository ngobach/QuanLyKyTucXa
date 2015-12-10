<%@ Page Title="Chi tiết hóa đơn" Language="C#" MasterPageFile="~/MainTemplate.Master" AutoEventWireup="true" CodeBehind="CTHoaDon.aspx.cs" Inherits="LapTrinhWeb.CTHoaDon" %>
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
                        <asp:TextBox runat="server" ID="txtMaHD" CssClass="form-control" ReadOnly="true"/>
                    </div>
                    <div class="form-group">
                        <label>Năm</label>
                        <asp:TextBox runat="server" ID="txtNam" CssClass="form-control" ReadOnly="true"/>
                    </div>
                    <div class="form-group">
                        <label>Tháng</label>
                        <asp:TextBox runat="server" ID="txtThang" CssClass="form-control" ReadOnly="true"/>
                    </div>
                    <div class="form-group">
                        <label>Tổng tiền</label>
                        <div class="input-group">
                            <span class="input-group-addon">VNĐ</span>
                            <asp:TextBox runat="server" ID="txtTongTien" CssClass="form-control" ReadOnly="true"/>
                        </div>
                    </div>
                    <div class="form-group">
                        <label class="control-label"><asp:CheckBox runat="server" ID="chkDaThanhToan"/> Đã thanh toán?</label>
                    </div>
                </div>
                <div class="col-xs-4">
                    <div class="form-group">
                        <label>Tiền phòng</label>
                        <div class="input-group">
                            <span class="input-group-addon">VNĐ</span>
                            <asp:TextBox runat="server" ID="txtTPhong" CssClass="form-control"/>
                        </div>
                    </div>
                    <div class="form-group">
                        <label>Tiền điện</label>
                        <div class="input-group">
                            <span class="input-group-addon">VNĐ</span>
                            <asp:TextBox runat="server" ID="txtTDien" CssClass="form-control"/>
                        </div>
                    </div>
                    <div class="form-group">
                        <label>Tiền nước</label>
                        <div class="input-group">
                            <span class="input-group-addon">VNĐ</span>
                            <asp:TextBox runat="server" ID="txtTNuoc" CssClass="form-control"/>
                        </div>
                    </div>
                    <div class="form-group">
                        <label>Phụ phí</label>
                        <div class="input-group">
                            <span class="input-group-addon">VNĐ</span>
                            <asp:TextBox runat="server" ID="txtPhuPhi" CssClass="form-control"/>
                        </div>
                    </div>
                </div>
                <div class="col-xs-4">
                    <div class="form-group">
                        <label>Chi tiết</label>
                        <asp:TextBox TextMode="MultiLine" runat="server" CssClass="form-control" Rows="16" ID="txtChiTiet"/>
                    </div>
                </div>
            </div>
            <hr />
            <div class="row">
                <div class="col-xs-2 col-xs-offset-4">
                    <asp:Button runat="server" ID="btnUpdate" Text="Cập nhật" CssClass="btn btn-primary btn-block" OnClick="btnUpdate_Click"/>
                </div>
            </div>
        </form>
    </div>
</asp:Content>