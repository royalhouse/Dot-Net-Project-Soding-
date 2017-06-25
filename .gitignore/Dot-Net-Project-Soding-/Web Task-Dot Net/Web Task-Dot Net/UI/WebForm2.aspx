<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="Web_Task_Dot_Net.UI.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
    
   
    
    

<body>
    <form id="form1" runat="server">
    <div>
     <h1>SYSTEM UI/UX</h1>
        <table>
           <tr>
               <td><asp:Label runat="server" Text="ID"></asp:Label></td>
               <td><asp:TextBox ID="id" runat="server"></asp:TextBox></td>
           </tr>
            <tr>
                <td><asp:Label runat="server" Text="Name"></asp:Label></td>
                 <td><asp:TextBox ID="name" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                 <td><asp:Label runat="server" Text="Description"></asp:Label></td><
                <td><asp:TextBox ID="description" runat="server" Height="60px" TextMode="MultiLine" ></asp:TextBox></td>
                
            </tr>
            
            <tr>
                <td><asp:Label ID="Label1" runat="server" Text="Date Created"></asp:Label></td>
                <td><asp:TextBox ID="dateCreated" runat="server"></asp:TextBox></td>
               
            </tr>
            <tr>
                <td><asp:Label ID="Label2" runat="server" Text="Date Updated"></asp:Label></td>
                <td><asp:TextBox ID="dateUpdated" runat="server"></asp:TextBox></td>
               
            </tr>
            
            
            <tr>
            <td></td>
            </tr>
            
            <tr>
            <td>
                <br />
                <br />
                <br />
                <br />
                </td>
            </tr>
            

             <tr>
            <td></td>
            <td><asp:Button runat="server" ID="createTaskButton" Text="Create Task" OnClick="createTaskButton_Click"/></td>
            <td><asp:Button runat="server" ID="editTaskButton" Text="Edit Task" OnClick="editTaskButton_Click"/></td>
        </tr>
        
             <tr>
            <td></td>
            <td><asp:Button runat="server" ID="deleteTaskButton" Text="Delete Task" OnClick="deleteTaskButton_Click"/></td>
            <td><asp:Button runat="server" ID="listAllTaskButton" Text="List All Task" OnClick="listAllTaskButton_Click"/></td>
        </tr>
        
            <tr>
            <td></td>
           
        </tr>
            <tr>
            <td></td>
            <td><asp:Label ID="messageLabel" runat="server" Text=""></asp:Label></td>
        </tr>
        </table>
    </div>
        
   

        <asp:GridView ID="employeeGridView" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#999999" BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Vertical">
            
            <AlternatingRowStyle BackColor="#DCDCDC" />
            
            <Columns>
                <asp:TemplateField HeaderText="ID">
                    <ItemTemplate>
                        <asp:Label ID="Label1" runat="server" Text='<%#Eval("ID") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                
                 <asp:TemplateField HeaderText="Name">
                    <ItemTemplate>
                        <asp:Label ID="Label2" runat="server" Text='<%#Eval("Name") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>

                 <asp:TemplateField HeaderText="Description">
                    <ItemTemplate>
                        <asp:Label ID="Label3" runat="server" Text='<%#Eval("Description") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                 <asp:TemplateField HeaderText="Date Created">
                    <ItemTemplate>
                        <asp:Label ID="Label4" runat="server" Text='<%#Eval("DateCreated") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                
                 <asp:TemplateField  HeaderText="Date Updated">
                    <ItemTemplate>
                        <asp:Label ID="Label5" runat="server" Text='<%#Eval("DateUpdated") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
            <FooterStyle BackColor="#CCCCCC" ForeColor="Black" />
            <HeaderStyle BackColor="#000084" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
            <RowStyle BackColor="#EEEEEE" ForeColor="Black" />
            <SelectedRowStyle BackColor="#008A8C" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F1F1F1" />
            <SortedAscendingHeaderStyle BackColor="#0000A9" />
            <SortedDescendingCellStyle BackColor="#CAC9C9" />
            <SortedDescendingHeaderStyle BackColor="#000065" />
        </asp:GridView>
    </form>
</body>


<script src="../Scripts/jquery-1.12.4.min.js"></script>
<script src="../Scripts/jquery-ui-1.12.1.js"></script>
    <script>
        $(function () {
            $("#<%=dateCreated.ClientID%>").datepicker({
                changeMonth: true,
                changeYear: true,
                dateFormat: "dd/mm/y"
            });

            $("#<%=dateUpdated.ClientID%>").datepicker({
                changeMonth: true,
                changeYear: true,
                dateFormat: "dd/mm/y"
            });
        });
    </script> 
    </html>