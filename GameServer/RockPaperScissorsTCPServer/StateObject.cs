using System;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Text;

namespace RockPaperScissorsTCPServer
{
    public class StateObject
    {
        // Size of receive buffer.  
        public const int BufferSize = 1024;

        // Receive buffer.  
        public byte[] buffer = new byte[BufferSize];

        // Received data string.
        public StringBuilder sb = new StringBuilder();

        // Client socket.
        public Socket workSocket = null;
    }
}