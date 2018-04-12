<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EmployeeInsert.aspx.cs" Inherits="ADOLog4Net.EmployeeUI.EmployeeInsert" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="../Content/bootstrap.css" rel="stylesheet" />
    <img src="../Content/ADo.jpg"  style="width:100%" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server" style="background-color: #3667d6">
       <div class="container">
    <div class="jumbotron  ">
         <div class="form-group">
            <div class="btn-group btn-group-lg col-lg-12 " role="group">     
            <asp:Button ID="btnInsert" CssClass="btn btn-primary col-lg-3" runat="server" Text="INSERT" BorderStyle="Double"  Font-Bold="True" OnClick="btnInsert_Click" />
            <asp:Button ID="btnUpdate" CssClass="btn btn-primary col-lg-3" runat="server" Text="UPDATE" BorderStyle="Double"   Font-Bold="True" OnClick="btnUpdate_Click" />
            <asp:Button ID="btnDelete" CssClass="btn btn-primary col-lg-3" runat="server" Text="DELETE" BorderStyle="Double"   Font-Bold="True" OnClick="btnDelete_Click" />
            <asp:Button ID="btnDisplay"  CssClass="btn btn-primary col-lg-3" runat ="server" Text="DISPLAY" BorderStyle="Double"  Font-Bold="True" OnClick="btnDisplay_Click"  /></div></div>
            <br />
             <div class="form-group " style="height:109px">
            <asp:Label CssClass="col-lg-4 control-label" ID="Label4" runat="server" Text="Last Name:-"></asp:Label>
            &nbsp;<div class="col-lg-4">
            <asp:TextBox ID="TextBox2" CssClass="form-control" runat="server"></asp:TextBox><asp:RequiredFieldValidator ForeColor="#CC0000" runat="server" id="RequiredFieldValidator3" controltovalidate="TextBox2" errormessage="Please enter your Last name!" />
             <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="TextBox2"
    ValidationExpression="[a-zA-Z ]*$" ErrorMessage="Enter a valid Last Name" />
                 </div></div>         
            <div class="form-group " style="height: 109px">
            <asp:Label CssClass="col-lg-4 control-label" ID="Label5" runat="server" Text=" First Name:-"></asp:Label>
           <div class="col-lg-4">
            <asp:TextBox ID="TextBox3" CssClass="form-control" runat="server"></asp:TextBox> <asp:RequiredFieldValidator ForeColor="#CC0000" runat="server" id="RequiredFieldValidator1" controltovalidate="TextBox3" errormessage="Please enter your First name!" />
             <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="TextBox3"
    ValidationExpression="[a-zA-Z ]*$"  ErrorMessage="Enter a valid Last Name" />
           </div></div>
            <div class="form-group " >   
            <asp:Label CssClass="col-lg-4 control-label" ID="Label6" runat="server" Text="City:-"></asp:Label>
            <div class="col-lg-4">
           <asp:TextBox ID="TextBox4" CssClass="form-control" runat="server"></asp:TextBox> <asp:RequiredFieldValidator ForeColor="#CC0000" runat="server" id="RequiredFieldValidator2" controltovalidate="TextBox4" errormessage="Please enter your City!" />
             <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" ControlToValidate="TextBox4"
    ValidationExpression="[a-zA-Z ]*$" ErrorMessage="Enter a valid Last Name" /></div></div>
            <br /><br />
            <asp:Button ID="Button1" CssClass="btn btn-success" runat="server" OnClick="Button1_Click" Text="Insert" />
        </div>
           </div>
    </form>
</body>
</html>
