<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="login.ascx.cs" Inherits="MonsterWeb.Client.login" %>
<asp:Label runat="server">username</asp:Label>
<asp:TextBox runat="server" ID="Username"></asp:TextBox>

<asp:Label runat="server">password</asp:Label>
<asp:TextBox runat="server" ID="Password" TextMode="Password"></asp:TextBox>

<asp:Button runat="server" ID="Login" OnClick="Login_Click"/>

<asp:Label runat="server" ID="Message"></asp:Label>