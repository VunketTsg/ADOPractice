<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EmployeeUpdate.aspx.cs" Inherits="ADOLog4Net.EmployeeUI.EmployeeUpdate" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="../Content/bootstrap.min.css" rel="stylesheet" />
    <title></title>
    <img src="../Content/ADo.jpg" style="width: 100%" />
</head>
<body>
    <form id="form1" runat="server" style="background-color: #3667d6">
        <div class="container">
            <div class="jumbotron  ">
                <div class="row">
                    <div class="form-group">
                        <div class="btn-group btn-group-lg col-lg-12 " role="group">
                            <asp:Button ID="btnInsert" CssClass="btn btn-primary col-lg-3" runat="server" Text="INSERT" BorderStyle="Double" Font-Bold="True" OnClick="btnInsert_Click" />
                            <asp:Button ID="btnUpdate" CssClass="btn btn-primary col-lg-3" runat="server" Text="UPDATE" BorderStyle="Double" Font-Bold="True" OnClick="btnUpdate_Click" />
                            <asp:Button ID="btnDelete" CssClass="btn btn-primary col-lg-3" runat="server" Text="DELETE" BorderStyle="Double" Font-Bold="True" OnClick="btnDelete_Click" />
                            <asp:Button ID="btnDisplay" CssClass="btn btn-primary col-lg-3" runat="server" Text="DISPLAY" BorderStyle="Double" Font-Bold="True" OnClick="btnDisplay_Click" />
                        </div>
                    </div>
                    <br />
                    <div class="form-group ">
                        <asp:Label CssClass="col-lg-4 control-label" ID="Label2" runat="server" Text="Enter EmployeeID"></asp:Label>
                        <div class="col-lg-4">
                            <asp:TextBox CssClass="form-control" ID="TextBox4" runat="server" TextMode="Number"></asp:TextBox>
                        </div>
                        <%--&nbsp;&nbsp;&nbsp;--%>
                        <asp:Button CssClass="btn btn-primary " ID="ButtonEdit" runat="server" OnClick="ButtonEdit_Click" Text="Edit" />
                    </div>
                    <div class="form-group ">
                        &nbsp;<asp:Label CssClass="col-lg-4 control-label" ID="Label3" runat="server" Text="Employee ID"></asp:Label>
                        <asp:Label CssClass="col-lg-4 control-label" ID="Label1" runat="server"></asp:Label>
                    </div>
                    <div class="form-group " style="height: 64px">
                        <asp:Label CssClass="col-lg-4 control-label" ID="Label4" runat="server" Text="Employee LName:-"></asp:Label>
                        &nbsp;<div class="col-lg-4">
                            <asp:TextBox CssClass="form-control" ID="TextBox1" runat="server"></asp:TextBox>
                            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="TextBox1"
                                ValidationExpression="[a-zA-Z ]*$" ErrorMessage="Enter a valid Last Name" />
                        </div>
                    </div>
                    <%-- <br />--%>
                    <div class="form-group " style="height: 64px">
                        <asp:Label CssClass="col-lg-4 control-label" ID="Label5" runat="server" Text="EmployeeFName:-"></asp:Label>
                        <div class="col-lg-4">
                            <asp:TextBox CssClass="form-control" ID="TextBox2" runat="server"></asp:TextBox>
                            <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="TextBox2"
                                ValidationExpression="[a-zA-Z ]*$" ErrorMessage="Enter a valid First Name" />
                        </div>
                    </div>
                    <div class="form-group ">
                        <asp:Label CssClass="col-lg-4 control-label" ID="Label6" runat="server" Text="Employee City:-"></asp:Label>
                        <div class="col-lg-4">
                            <asp:TextBox CssClass="form-control" ID="TextBox3" runat="server"></asp:TextBox>
                            <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" ControlToValidate="TextBox3"
                                ValidationExpression="[a-zA-Z ]*$" ErrorMessage="Enter a valid City" />
                        </div>
                    </div>
                    <div class="form-group">
                        <div class="col-lg-10">
                            <asp:Button CssClass="btn btn-success" ID="ButtonUpdate" runat="server" OnClick="ButtonUpdate_Click" Text="Update" />
                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button CssClass="btn btn-warning" ID="ButtonCancel" runat="server" OnClick="ButtonCancel_Click" Text="Cancel" />
                        </div>
                    </div>

                </div>
            </div>
        </div>
    </form>
</body>
</html>
