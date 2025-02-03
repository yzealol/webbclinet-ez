
using System.Data;
using System.Net.WebSockets;
using System.Text;

class Program{
  static async Task Main(){
 Uri goblin = new Uri("ws://echo.webbsocket.org");
 ClientWebSocket goblinsocket = new ClientWebSocket();
 await goblinsocket.ConnectAsync(goblin, default);
 string goblinstring = "ez";
  byte[] goblinarray = Encoding.UTF8.GetBytes(goblinstring);
ArraySegment<byte>smsg = new(goblinarray);
await goblinsocket.SendAsync(smsg,WebSocketMessageType.Text,true,CancellationToken.None);
byte[] ezhomelessgoblinres = new byte[1024];
var ezgoblinnoobhahahha = await goblinsocket.ReceiveAsync(new ArraySegment<byte>(ezhomelessgoblinres),CancellationToken.None);
string ahhahagoblimotagennoobez = Encoding.UTF8.GetString(ezhomelessgoblinres,0,ezgoblinnoobhahahha.Count);
  }
  
}