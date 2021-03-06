﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace DesktopRemoteAdmin_UI.Libs
{
    class Tcp
    {
        public static NetworkStream Connect(string ip,int port)
        {
            TcpClient client = new TcpClient(ip, port);

            NetworkStream stream = client.GetStream();

            return stream;
        }

        public static bool SendData(string data, NetworkStream stream)
        {
            try
            {
                byte[] bytes = Encoding.UTF8.GetBytes(data + "|");

                stream.Write(bytes, 0, bytes.Length);

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static string[] Recieve(NetworkStream stream)
        {
            try
            {
                byte[] bytes = new byte[1024];

                stream.Read(bytes, 0, bytes.Length);

                string[] data = Encoding.UTF8.GetString(bytes).Split('|');

                stream.Flush();

                return data;
            }
            catch (Exception)
            {
                return new string[] { "failed to recieve message" };
            }
        }
    }
}
