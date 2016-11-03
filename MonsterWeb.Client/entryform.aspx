<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="entryform.aspx.cs" Inherits="MonsterWeb.Client.entryform" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
  <title></title>
</head>
<body>
  <form id="form1" runat="server">
    <div>
      <asp:Label runat="server">

      </asp:Label>
      <asp:Label runat="server" ID="MonsterName"></asp:Label>
      <asp:TextBox runat="server" ID="MonsterName_Text"></asp:TextBox>


      <asp:Label runat="server" ID="MonsterGender"></asp:Label>
      <asp:DropDownList runat="server" ID="MonsterGender_List"></asp:DropDownList>


      <asp:Button runat="server" ID="Monster_submit" OnClick="MonsterSubmit_Click" />
    </div>
    </form>
   <%-- <form id="form2" runat="server">
      <div>
        <asp:Label runat="server" ID="GenderName"></asp:Label>
        <asp:TextBox runat="server" ID="GenderName_Text"></asp:TextBox>

        <asp:Button runat="server" ID="Gender_submit" OnClick="GenderSubmit_Click" />
      </div>
    </form>
    <form id="form4" runat="server">
      <div>
        <asp:Label runat="server" ID="TypeName"></asp:Label>
        <asp:TextBox runat="server" ID="MonsterTypeName_Text"></asp:TextBox>

        <asp:Button runat="server" ID="MonsterType_submit" OnClick="MonsterTypesubmit_Click" />
      </div>
    </form>
    <form id="form3" runat="server">
      <div>
        <asp:Label runat="server" ID="TitleName"></asp:Label>
        <asp:TextBox runat="server" ID="TitleName_Text"></asp:TextBox>

        <asp:Button runat="server" ID="Title_submit" OnClick="Titlesubmit_Click" />
      </div>
    </form>--%>
</body>
</html>
