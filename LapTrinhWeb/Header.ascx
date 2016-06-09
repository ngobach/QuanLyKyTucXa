<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Header.ascx.cs" Inherits="LapTrinhWeb.Header" %>
<nav class="navbar navbar-<%=InverseNavBar?"inverse":"default" %>">
    <div class="container-fluid">
        <div class="navbar-header">
            <button type="button" class="navbar-toggle collapsed" data-toggle="collapse" data-target="#navbar" aria-expanded="false" aria-controls="navbar">
                <span class="sr-only">Toggle navigation</span>
                <span class="icon-bar"></span>
                <span class="icon-bar"></span>
                <span class="icon-bar"></span>
            </button>
            <a class="navbar-brand" href="/Default.aspx">Quản lý KTX</a>
        </div>
        <div id="navbar" class="navbar-collapse collapse">
            <ul class="nav navbar-nav">
                <li class="<%=GetClass("QLUser.aspx") %>"><a runat="server" href="~/QLUser.aspx">Quản lý người dùng</a></li>
                <li class="<%=GetClass("QLSinhVien.aspx") %>"><a runat="server" href="~/QLSinhVien.aspx">Quản lý sinh viên</a></li>
                <li class="<%=GetClass("QLPhong.aspx") %>"><a runat="server" href="~/QLPhong.aspx">Quản lý phòng</a></li>
                <li class="dropdown">
                    <a href="#" class="dropdown-toggle" data-toggle="dropdown">Hợp đồng <span class="caret"></span></a>
                    <ul class="dropdown-menu">
                        <li class="<%=GetClass("QLHopDong.aspx") %>"><a runat="server" href="~/QLHopDong.aspx">Danh sách</a></li>
                        <li class="<%=GetClass("CTHopDong.aspx") %>"><a runat="server" href="~/CTHopDong.aspx">Tạo mới</a></li>
                        <li class="<%=GetClass("TKHopDong.aspx") %>"><a runat="server" href="~/TKHopDong.aspx">Thống kê</a></li>
                    </ul>
                </li>
                <li class="dropdown">
                    <a href="#" class="dropdown-toggle" data-toggle="dropdown">Hóa đơn <span class="caret"></span></a>
                    <ul class="dropdown-menu">
                        <li class="<%=GetClass("QLHoaDon.aspx") %>"><a runat="server" href="~/QLHoaDon.aspx">Danh sách</a></li>
                        <li class="<%=GetClass("TKHoaDon.aspx") %>"><a runat="server" href="~/TKHoaDon.aspx">Thống kê</a></li>
                    </ul>
                </li>
            </ul>
            <ul class="nav navbar-nav navbar-right">
                <% if (Session["Username"] == null) {  %>
                <li><a runat="server" href="~/Login.aspx">Đăng nhập</a></li>
                <% } else { %>
                <li class="dropdown">
                    <a href="#" class="dropdown-toggle" data-toggle="dropdown" role="button" aria-haspopup="true" aria-expanded="false">Xin chào <b><%=Session["Username"]%></b> <span class="caret"></span></a>
                    <ul class="dropdown-menu">
                        <li><a href="/QLUser.aspx?uid=<%=Session["Username"] %>">Sửa hồ sơ</a></li>
                        <li><a href="/Logout.aspx">Đăng xuất</a></li>
                    </ul>
                </li>
                <% } %>
            </ul>
        </div>
    </div>
</nav>