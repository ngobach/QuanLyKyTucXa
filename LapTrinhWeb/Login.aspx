<%@ Page Title="Đăng nhập" Language="C#" MasterPageFile="~/MainTemplate.Master" AutoEventWireup="true" CodeBehind="~/Login.aspx.cs" Inherits="LapTrinhWeb.Login"%>
<%@ MasterType VirtualPath="~/MainTemplate.Master" %>
<asp:Content ContentPlaceHolderID="StyleSection" runat="server">
    <style>
        body {
            background-color: #eee;
            padding-top: 40px;
            padding-bottom: 40px;
        }

        .form-signin {
            max-width: 330px;
            padding: 15px;
            margin: 0 auto;
        }
        .form-signin-heading{
            text-align: center;
        }
        .form-signin .form-signin-heading,
        .form-signin .checkbox {
            margin-bottom: 10px;
        }

        .form-signin .checkbox {
            font-weight: normal;
        }

        .form-signin .form-control {
            position: relative;
            height: auto;
            -webkit-box-sizing: border-box;
            -moz-box-sizing: border-box;
            box-sizing: border-box;
            padding: 10px;
            font-size: 16px;
        }

        .form-signin .form-control:focus {
            z-index: 2;
        }

        .form-signin input[type="email"] {
            margin-bottom: -1px;
            border-bottom-right-radius: 0;
            border-bottom-left-radius: 0;
        }

        .form-signin input[type="password"] {
            margin-bottom: 10px;
            border-top-left-radius: 0;
            border-top-right-radius: 0;
        }
    </style>
</asp:Content>
<asp:Content ContentPlaceHolderID="ContentSection" runat="server">
    <form runat="server" id="form" class="form-signin" DefaultButton="btnLogin">
        <h2 class="form-signin-heading">Đăng nhập hệ thống</h2>
        <asp:TextBox runat="server" ID="Username" CssClass="form-control" placeholder="Tên đăng nhập" required=""/>
        <asp:TextBox runat="server" TextMode="Password" ID="Password" CssClass="form-control" placeholder="Mật khẩu" required=""/>

        <!-- Space -->
        <div style="height: 20px"></div>

        <% if (alert != null) { %>
        <div class="alert alert-dismissible alert-<%= alert.Class %>">
            <button type="button" class="close" data-dismiss="alert">×</button>
            <h4><%= alert.Title %></h4>
            <p><%= alert.Content %></p>
        </div>
        <% } %>

        <asp:LinkButton ID="btnLogin" CssClass="btn btn-block btn-success" runat="server" Text="Đăng nhập" OnClick="DoLogin"/>
    </form>
</asp:Content>
