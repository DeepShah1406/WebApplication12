<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication12.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div align="center">
            <h2> Employee Data </h2><asp:GridView ID="gvEmp" runat="server" />
            <br />
            Emp ID : <asp:TextBox ID="txtEmpId" runat="server"></asp:TextBox>
            <br />
            Emp Name : <asp:TextBox ID="txtEmpName" runat="server"></asp:TextBox>
            <br />
            Emp City : <asp:TextBox ID="txtEmpCity" runat="server"></asp:TextBox>
            <br />
            Emp Salary : <asp:TextBox ID="txtEmpSal" runat="server"></asp:TextBox>
            <br />
            <asp:Button id="btnInsert" runat="server" Text="Insert" OnClick="btnInsert_Click" />
            &nbsp;&nbsp;
            <asp:Button id="btnUpdate" runat="server" Text="Update" OnClick="btnUpdate_Click" />
            &nbsp;&nbsp;
            <asp:Button id="btnDelete" runat="server" Text="Delete" OnClick="btnDelete_Click" />
            &nbsp;&nbsp;
            <asp:Button id="btnSelect" runat="server" Text="Select" OnClick="btnSelect_Click" />
        </div>
    </form>
</body>
</html>
