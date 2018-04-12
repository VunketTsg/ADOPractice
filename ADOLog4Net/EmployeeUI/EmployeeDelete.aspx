<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EmployeeDelete.aspx.cs" Inherits="ADOLog4Net.EmployeeUI.EmployeeDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="../Content/bootstrap.css" rel="stylesheet" />
    <img src="../Content/ADo.jpg" width="100%" />
    <title></title>
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

                    <div class="form-group ">
                        <asp:Label CssClass="col-lg-4 control-label" ID="Label1" runat="server" Text="Select ID To Delete"></asp:Label>
                        &nbsp;<div class="col-lg-2">
                            <asp:DropDownList CssClass="form-control" ID="DropDownList1" runat="server">
                            </asp:DropDownList>
                        </div>
                        &nbsp;<asp:Button CssClass="btn btn-primary" ID="Button1" runat="server" OnClick="Button1_Click1" Text="Select" />
                    </div>

                    <div class="form-group ">
                        <asp:Label CssClass="col-lg-4 control-label" ID="Label2" runat="server" Text="EmployeeID:-"></asp:Label>
                        <asp:Label CssClass="col-lg-4 control-label" ID="empid" runat="server"></asp:Label>
                    </div>
                    <br />

                    <div class="form-group ">
                        <asp:Label CssClass="col-lg-4 control-label" ID="Label3" runat="server" Text="EmpLName:-"></asp:Label>
                        <asp:Label CssClass="col-lg-4 control-label" ID="elname" runat="server"></asp:Label>
                    </div>
                    <br />
                    <div class="form-group ">
                        <asp:Label CssClass="col-lg-4 control-label" ID="Label4" runat="server" Text="EmpFName:-"></asp:Label>
                        <asp:Label CssClass="col-lg-4 control-label" ID="empFname" runat="server"></asp:Label>
                    </div>
                    <br />
                    <div class="form-group ">
                        <asp:Label CssClass="col-lg-4 control-label" ID="Label5" runat="server" Text="City:-"></asp:Label>
                        <asp:Label CssClass="col-lg-4 control-label" ID="city" runat="server"></asp:Label>
                    </div>
                    <br />

                    <asp:Button CssClass="btn btn-danger" ID="Delete" runat="server" OnClick="Delete_Click" Text="Delete" />
                </div>
            </div>
        </div>
    </form>
</body>
</html>
