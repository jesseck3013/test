﻿using System.Net;
using System.Text;
using System.Net.Sockets;
using dens.Core;

class Program
{
    static async Task Main()
    {

	Header header = Header.NewQuery();
	
	foreach (var item in header.Encode())
	{
	    Console.WriteLine(item);
	}
	
	// UdpClient udpClient = new UdpClient();
	
	// //	Byte[] data = Encoding.Unicode.GetBytes("hello");

	// var endpoint = IPEndPoint.Parse("127.0.0.0:9090");

	// byte[] data = { 0x32, 0xD8, 0x01, 0x00, 0x00, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x06, 0x67, 0x6F, 0x6F, 0x67, 0x6C, 0x65, 0x03, 0x63, 0x6F, 0x6D, 0x00, 0x00, 0x1C, 0x00, 0x01 };
	
	// await udpClient.SendAsync(data, data.Length, endpoint);
	// var response = await udpClient.ReceiveAsync();
	// foreach (var b in response.Buffer)
	// {
	//     Console.Write(b.ToString("X2") + " ");
	// }
	// Console.Write("\n");
    }
}
