<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="ProjectCourse.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Button ID="ButtonCourse" runat="server" Text="Course" Width="100px" OnClick="ButtonCourse_Click" />
        <asp:Button ID="ButtonStudent" runat="server" Text="Student" Width="100px" OnClick="ButtonStudent_Click" />
        <asp:Button ID="ButtonClass" runat="server" Text="Class" Width="100px" OnClick="ButtonClass_Click" />
        
        <asp:Button ID="ButtonTakenCourse" runat="server" OnClick="ButtonTakenCourse_Click" Text="Taken Courses" Width="100px" />
        
        <br />
        <br />
        <br />
        <br />
        
    </div>

    <div>
        <asp:GridView ID="CourseTable" runat="server" Width="412px" AutoGenerateColumns="False" CellPadding="4" DataSourceID="SqlDataSource1" ForeColor="#333333" GridLines="None" DataKeyNames="Student ID" Height="193px" >
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:BoundField DataField="Student ID" HeaderText="Student ID" InsertVisible="False" ReadOnly="True" SortExpression="Student ID" />
                <asp:BoundField DataField="First Name" HeaderText="First Name" SortExpression="First Name" />
                <asp:BoundField DataField="Surname" HeaderText="Surname" SortExpression="Surname" />
            </Columns>
            <EditRowStyle BackColor="#2461BF" />
            <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#EFF3FB" HorizontalAlign="Center" />
            <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#F5F7FB" />
            <SortedAscendingHeaderStyle BackColor="#6D95E1" />
            <SortedDescendingCellStyle BackColor="#E9EBEF" />
            <SortedDescendingHeaderStyle BackColor="#4870BE" />
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:CourseDBConnectionString4 %>" SelectCommand="SELECT ID as 'Student ID', Name as 'First Name', Surname FROM [Students]"></asp:SqlDataSource>
    </div>
    
    </form>
</body>
</html>
