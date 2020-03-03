<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="Ques_01.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <html>
    <div style="height: 283px; width: 342px; margin-left:240px; margin-top:50px; background-color:burlywood" >
       
        <br>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;BASIC CALCULATOR
        <br><br>


        <asp:TextBox ID="txt" class="input-group-addon" runat="server" Width="240px" readonly="true" Style="margin-left:70px;"></asp:TextBox>


        <br />
        <br />

        <asp:Button ID="btn1" cssclass="btn btn-primary" runat="server" Text="1" style="margin-left:75px;" OnClick="btn1_Click"/>
        <asp:Button ID="btn2" cssclass="btn btn-primary" runat="server" Text="2" style="margin-left:5px;" OnClick="btn1_Click" />
        <asp:Button ID="btn3" cssclass="btn btn-primary" runat="server" Text="3" style="margin-left:5px;" OnClick="btn1_Click"/>


        <asp:Button ID="Button4" cssclass="btn btn-warning" runat="server" Text="+" style="margin-left:55px; width:44px" OnClick="add"/>




        <br />

        <asp:Button ID="btn5" runat="server" Text="4" cssclass="btn btn-primary"  style="margin-left:75px; margin-top:5px;" OnClick="btn1_Click" />
        <asp:Button ID="btn6" runat="server" Text="5"  style="margin-left:5px; margin-top:5px;" cssclass="btn btn-primary" OnClick="btn1_Click"/>
        <asp:Button ID="btn7" runat="server" Text="6"  style="margin-left:5px; margin-top:5px;" cssclass="btn btn-primary" OnClick="btn1_Click"/>
        <asp:Button ID="Button8" runat="server" Text="-"  style="margin-left:55px; margin-top:5px;" cssclass="btn btn-warning" Width="44px" OnClick="add" />
        <br />
        <asp:Button ID="btn9"  cssclass="btn btn-primary" runat="server" Text="7"  style="margin-left:75px; margin-top:5px;" OnClick="btn1_Click" />
        <asp:Button ID="btn10"  cssclass="btn btn-primary" runat="server" Text="8" style="margin-left:5px; margin-top:5px;" OnClick="btn1_Click"/>
        <asp:Button ID="btn11"  cssclass="btn btn-primary" runat="server" Text="9" style="margin-left:5px; margin-top:5px;" OnClick="btn1_Click"/>
        <asp:Button ID="Button12"  cssclass="btn btn-warning" runat="server" Text="*" style="margin-left:55px; margin-top:5px;" Width="44px" OnClick="add" />
        <br />







        <asp:Button ID="Button13" cssclass="btn btn-primary" runat="server" Text="." style="margin-left:75px; margin-top:5px;" OnClick="btn1_Click" Width="33px"/>
        <asp:Button ID="Button14" cssclass="btn btn-primary" runat="server" Text="0"  style="margin-left:5px; margin-top:5px;" OnClick="btn1_Click" />
        <asp:Button ID="Button15" cssclass="btn btn-primary" runat="server" Text="="  style="margin-left:5px; margin-top:5px;" OnClick="result" />
        <asp:Button ID="Button16" cssclass="btn btn-warning" runat="server" Text="/"  style="margin-left:55px; margin-top:5px;" Width="44px" OnClick="add" />


        <asp:HiddenField ID="temp" runat="server" />
        <asp:HiddenField ID="temp2" runat="server" />



    </div>
</html>
    </div>
</asp:Content>
