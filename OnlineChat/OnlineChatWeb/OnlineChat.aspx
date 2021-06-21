<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="OnlineChat.aspx.cs" Inherits="OnlineChatWeb.OnlineChat" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="ChatForm" runat="server">    
        <div>
            <asp:Panel ID ="popupPanel" Visible="false" Width="100%" Height="1000" runat="server" >
             <div>
            <asp:Label ID = "lblText" Text="Input Username" AssociatedControlId="txtName" runat = "server"/>
            <asp:TextBox ID ="txtName" runat="server" CssClass="textInput"/>
            </div>
            <div>
                <asp:Button ID = "btnOK" Text = "OK" runat="server" OnClick = "btnOK_Click"/>
            </div>
            </asp:Panel>
        </div>
        <div>
            <asp:Label id="lblName" AssociatedControlId="txtMessage" Text="Pais:" runat="server" />
            <asp:TextBox id="txtMessage" runat="server" CssClass="textInput" />
            
        </div>
        <div>
            <asp:TextBox runat="server" ID="txtMessages" TextMode="MultiLine" ReadOnly = "true"  Width="100%" Height="500" />
        </div>
    </form>
    <button id ="btnSend">Send</button>

    <script src="Scripts/jquery-1.6.4.min.js" ></script>
    <script src="Scripts/jquery.signalR-2.4.2.min.js"></script>
    <script src="http://26.146.157.62:50346/SignalR/hubs/"></script>
    <script type="text/javascript">
        $(function () {
            var connect;
            var proxy;
            var chaturl = "http://26.146.157.62:53713/signalr"
            connect = $.hubConnection(chaturl, { useDefaultPath: false });
            proxy = connect.createHubProxy('ChatHub');
            proxy.on("addMessage", function (message) {
                $('#txtMessages').val($('#txtMessages').val()+'\n'+message);

            });
            proxy.on("showErrorMessage", function () { alert('There are some problems on server ;c'); });
            connect.start({ jsonp: true })
                .done(function () {                                   
                    $('#btnSend').click(function () {                    
                        proxy.invoke("SendMessage", $('#lblName').text(), $('#txtMessage').val());
                    });
                })
                .fail(function () { alert('Connection Error'); });
                
        })
    </script>
</body>
</html>

