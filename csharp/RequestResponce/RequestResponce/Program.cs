﻿using System.Threading.Tasks;

namespace RequestResponce
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var server = new Server();
            var client = new Client();

            server.Run();
            await client.RunAsync();
            await client.RunAsync();
            await client.RunAsync();
        }
    }
}
