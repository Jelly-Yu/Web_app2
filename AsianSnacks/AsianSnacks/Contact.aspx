<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="AsianSnacks.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.</h2>
    <h3>Our Contact Information.</h3>
    <address class="lead">
        75 St. Alphonsus Street<br />
        Apt.0704<br />
        <abbr title="Phone">P:</abbr>
        617.372.2827
    </address>

    <address>
        <strong>Support:</strong>   <a style="color:blue" href="mailto:jelly.yu1992@gmail.com">jelly.yu1992@gmail.com</a><br />
        <strong>Marketing:</strong> <a style="color:blue" href="mailto:wendyzhuo03@gmail.com">wendyzhuo03@gmail.com</a>
    </address>
</asp:Content>
