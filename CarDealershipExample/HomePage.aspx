<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HomePage.aspx.cs" Inherits="CarDealershipExample.HomePage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Car Dealership</title>
    <script src="Scripts/bootstrap.js"></script>
    <script src="Scripts/bootstrap.bundle.js"></script>
    <script src="Scripts/bootstrap.min.js"></script>
    <script src="Scripts/popper.js"></script>
    <script src="Scripts/jquery-3.0.0.min.js"></script>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <link href="Content/DataTables/css/dataTables.bootstrap.css" rel="stylesheet" />
    <link href="Content/DataTables/css/jquery.dataTables.css" rel="stylesheet" />
    <script src="Scripts/DataTables/dataTables.bootstrap.js"></script>
    <script src="Scripts/DataTables/jquery.dataTables.js"></script>
    <script src="Scripts/DataTables/jquery.dataTables.min.js"></script>
</head>

  <script>  
        $(document).ready(function () {
            $('#<%=gvPackages.ClientID%>').DataTable({
            });
        });</script>
<body>
       <nav class="navbar navbar-expand-md bg-dark navbar-dark">
  <a class="navbar-brand" href="#">Car Dealership</a>
  <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#collapsibleNavbar">
    <span class="navbar-toggler-icon"></span>
  </button>
  <div class="collapse navbar-collapse" id="collapsibleNavbar">
    <ul class="navbar-nav">
      
    </ul>
  </div>  
</nav>
<br/>


    <form id="form1" class="form-inline" style="padding-left: 25px;" runat="server">
    <div>
    
     
         <div class="form-group">
    <label for="Name">Enter your name:</label>
             <asp:TextBox ID="txtname" CssClass="form-control" runat="server"></asp:TextBox>
  </div>
  <div class="form-group">
    <label for="phone">Enter your phone number</label>
      <asp:TextBox ID="txtphone" CssClass="form-control" runat="server"></asp:TextBox>
  </div>
        <br />
        <br />
        <br />

         <div class="form-group">
    <label for="cm">Select a car make</label>
             <asp:DropDownList CssClass="dropdown-item" ID="ddlcarmake" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlcarmake_SelectedIndexChanged"></asp:DropDownList>
  </div>
        <br />
        <br />
         <div class="form-group">
    <label for="cm2">Select a car model</label>
             <asp:DropDownList CssClass="dropdown-item" ID="ddlcarmodel" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlcarmodel_SelectedIndexChanged"></asp:DropDownList>
  </div>
        <br />
        <br />
        <br />
        <asp:GridView ID="gvPackages" runat="server" AutoGenerateColumns="False" Visible="False" Width="726px">
            <Columns>
                <asp:TemplateField HeaderText="Order Package">
                    <ItemTemplate>
                        <asp:CheckBox ID="chkSelect" runat="server" />
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:BoundField DataField="CarID" HeaderText="Car ID" />
                <asp:BoundField DataField="PackageDescription" HeaderText="Package Description" />
                <asp:BoundField DataField="Price" HeaderText="Price" />
            </Columns>
         </asp:GridView>

        <br />
         <asp:Button ID="btnOrderPackage" runat="server" CssClass="btn btn-primary" OnClick="btnOrderPackage_Click1" Text="Order Package" />
        <br />
        <br />

        <asp:Label ID="Label1" runat="server" Text="Label" Visible="False"></asp:Label>
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="Label" Visible="False"></asp:Label>
        <br />
        <br />
        <asp:Label ID="Label3" runat="server" Text="Label" Visible="False"></asp:Label>
               <br />
        <br />
               <br />
        <br />
    </div>
    </form>
</body>
</html>
