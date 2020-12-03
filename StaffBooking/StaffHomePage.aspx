<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="StaffHomePage.aspx.cs" Inherits="StaffBooking.StaffHomePage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <p>
</p>
<p class="text-left">
    <asp:Label ID="lbWelcomeBack" runat="server" Font-Size="XX-Large" Text="Welcome Back  "></asp:Label>
    </p>
    <p class="text-left">
        <asp:Label ID="lbAccountDetails" runat="server" Font-Size="X-Large" Text="Account Details" Font-Bold="True"></asp:Label>
    </p>
    <p class="text-left">
        <asp:Label ID="lbStaffID" runat="server" Font-Size="Larger" Text="Staff ID : "></asp:Label>
    </p>
    <p class="text-left">
        <asp:Label ID="lbEmail" runat="server" Font-Size="Larger" Text="Email : "></asp:Label>
    </p>
    <p class="text-left">
        <asp:Label ID="lbFirstName" runat="server" Font-Size="Larger" Text="First Name : "></asp:Label>
    </p>
    <p class="text-left">
        <asp:Label ID="lbLastName" runat="server" Font-Size="Larger" Text="Last Name : "></asp:Label>
    </p>
    <p class="text-left">
        <asp:Label ID="lbDepartment" runat="server" Font-Size="Larger" Text="Department : "></asp:Label>
    </p>
    <p class="text-left">
        <asp:Label ID="lbRole" runat="server" Font-Size="Larger" Text="Role : "></asp:Label>
    </p>
    <p class="text-left">
        <asp:Label ID="lbDateJoined" runat="server" Font-Size="Larger" Text="Date Joined : "></asp:Label>
    </p>
    <p class="text-left">
        <asp:Label ID="lbEntitlement" runat="server" Font-Size="Larger" Text="Entitlement Days Left : "></asp:Label>
    </p>
    <p class="text-left">&nbsp;</p>
    <p class="text-left">&nbsp;</p>
    <p class="text-left">
        <asp:Label ID="lbChooseDays1" runat="server" Font-Size="X-Large" Text="Make Holiday Request" Font-Bold="True"></asp:Label>
    </p>
    <p class="text-left">
        </p>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <table class="nav-justified">
                <tr>
                    <td>
                        <asp:Label ID="lbChooseDays" runat="server" Font-Size="X-Large" Text="Choose Start Date"></asp:Label>
                    </td>
                    <td>
                        <asp:Label ID="lbChooseDays0" runat="server" Font-Size="X-Large" Text="Choose End Date"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Calendar ID="calRequestStart" runat="server" Height="307px" Width="313px">
                            <SelectedDayStyle BackColor="#33CCFF" />
                            <TitleStyle Font-Size="Large" />
                            <TodayDayStyle BorderColor="Black" BorderStyle="Inset" />
                            <WeekendDayStyle BackColor="#CCCCCC" />
                        </asp:Calendar>
                    </td>
                    <td>
                        <asp:Calendar ID="calRequestEnd" runat="server" Height="307px" Width="313px">
                            <SelectedDayStyle BackColor="#33CCFF" />
                            <TitleStyle Font-Size="Large" />
                            <TodayDayStyle BorderColor="Black" BorderStyle="Inset" />
                            <WeekendDayStyle BackColor="#CCCCCC" />
                        </asp:Calendar>
                    </td>
                </tr>
            </table>
        </ContentTemplate>
    </asp:UpdatePanel>
    <p class="text-left">
        &nbsp;</p>
    <p class="text-left">
        <asp:Button ID="btnMakeRequest" runat="server" Font-Size="Medium" Height="57px" Text="Make Request" Width="200px" OnClick="btnMakeRequest_Click" />
    </p>
    <p class="text-left">&nbsp;</p>
    <p class="text-left">&nbsp;</p>
    <p class="text-left">
        <asp:Label ID="lbViewRequest" runat="server" Font-Size="X-Large" Text="View Your Requests" Font-Bold="True"></asp:Label>
    </p>
    <p class="text-left">&nbsp;</p>
    <p class="text-left">
        <asp:GridView ID="gvAllRequests" runat="server" CellPadding="0" Font-Size="Medium">
        </asp:GridView>
    </p>
    <p class="text-left">&nbsp;</p>
    <p class="text-left">
        <asp:Button ID="btnViewRequests" runat="server" Font-Size="Medium" Height="59px" Text="View all Requests" Width="243px" OnClick="btnViewRequests_Click" />
    </p>
    <p class="text-left">
        &nbsp;</p>
    <p class="text-left">
        <asp:Button ID="btnLogOut" runat="server" Font-Size="Medium" Height="59px" Text="Log Out" Width="243px" OnClick="btnLogOut_Click" Font-Bold="True" />
    </p>
        <p>
</p>
</asp:Content>
