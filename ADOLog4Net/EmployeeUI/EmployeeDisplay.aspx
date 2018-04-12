<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EmployeeDisplay.aspx.cs" Inherits="ADOLog4Net.EmployeeUI.EmployeeDisplay" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="../Content/bootstrap.css" rel="stylesheet" />
    <img src="../Content/ADo.jpg" style="width: 100%" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server" style="background-color: #3667d6">
        <div class="container">
            <div class="jumbotron  ">

                <div class="form-group">
                    <div class="btn-group btn-group-lg col-lg-12 " role="group">
                        <asp:Button ID="btnInsert" CssClass="btn btn-primary col-lg-3" runat="server" Text="INSERT" BorderStyle="Double" Font-Bold="True" OnClick="btnInsert_Click" />
                        <asp:Button ID="btnUpdate" CssClass="btn btn-primary col-lg-3" runat="server" Text="UPDATE" BorderStyle="Double" Font-Bold="True" OnClick="btnUpdate_Click" />
                        <asp:Button ID="btnDelete" CssClass="btn btn-primary col-lg-3" runat="server" Text="DELETE" BorderStyle="Double" Font-Bold="True" OnClick="btnDelete_Click" />
                        <asp:Button ID="btnDisplay" CssClass="btn btn-primary col-lg-3" runat="server" Text="DISPLAY" BorderStyle="Double" Font-Bold="True" OnClick="btnDisplay_Click" />
                    </div>
                </div>
                <asp:Button ID="DsplyEmp" CssClass="btn btn-success" runat="server" OnClick="DsplyEmp_Click" Text="DisplayEmployees" />
                <br />
                <div class="form-group">
                    <asp:Label ID="Label6" CssClass="col-lg-4 control-label" runat="server" Text="Search By City:-"></asp:Label>
                    <div class="col-lg-2">
                        <asp:DropDownList ID="DropDownList1" CssClass="form-control" runat="server">
                        </asp:DropDownList>
                    </div>
                    <asp:Button ID="Button1" CssClass="btn btn-primary" runat="server" OnClick="Button1_Click" Text="Search By city" />
                </div>
                <br />
                <asp:GridView ID="GridView1" runat="server" AllowPaging="True" Align="Center" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None" OnPageIndexChanging="GridView1_PageIndexChanging" OnRowCancelingEdit="GridView1_RowCancelingEdit" OnRowDeleting="GridView1_RowDeleting" OnRowEditing="GridView1_RowEditing" OnRowUpdating="GridView1_RowUpdating" OnRowCommand="GridView1_RowCommand" Width="70%">
                    <AlternatingRowStyle BackColor="White" />
                    <Columns>
                        <asp:TemplateField HeaderText="EID">
                            <EditItemTemplate>
                                <asp:Label ID="Label5" runat="server" Text='<%# Bind("EmployeeID") %>'></asp:Label>
                                <asp:RegularExpressionValidator runat="server" ID="rexNumber" ControlToValidate="txtNumber" ValidationExpression="^[0-9]{2}$" ErrorMessage="Please enter a 4 digit number!" />
                            </EditItemTemplate>
                            <ItemTemplate>
                                <asp:Label ID="Label1" runat="server" Text='<%# Bind("EmployeeID") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="LName">
                            <EditItemTemplate>
                                <asp:TextBox ID="TextBox2" runat="server" Text='<%# Bind("LastName") %>'></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidatorName" runat="server"
                                    ErrorMessage="Name is required" ForeColor="Red"
                                    ControlToValidate="txtName" Display="Dynamic"></asp:RequiredFieldValidator>
                            </EditItemTemplate>
                            <ItemTemplate>
                                <asp:Label ID="Label2" runat="server" Text='<%# Bind("LastName") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="FName">
                            <EditItemTemplate>
                                <asp:TextBox ID="TextBox3" runat="server" Text='<%# Bind("FirstName") %>'></asp:TextBox>
                            </EditItemTemplate>
                            <ItemTemplate>
                                <asp:Label ID="Label3" runat="server" Text='<%# Bind("FirstName") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="City">
                            <EditItemTemplate>
                                <asp:TextBox ID="TextBox4" runat="server" Text='<%# Bind("City") %>'></asp:TextBox>
                            </EditItemTemplate>
                            <ItemTemplate>
                                <asp:Label ID="Label4" runat="server" Text='<%# Bind("City") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                    <EditRowStyle BackColor="#7C6F57" />
                    <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                    <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
                    <RowStyle BackColor="#E3EAEB" />
                    <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
                    <SortedAscendingCellStyle BackColor="#F8FAFA" />
                    <SortedAscendingHeaderStyle BackColor="#246B61" />
                    <SortedDescendingCellStyle BackColor="#D4DFE1" />
                    <SortedDescendingHeaderStyle BackColor="#15524A" />
                </asp:GridView>
                <br />
            </div>
        </div>
    </form>
</body>
</html>
