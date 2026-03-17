using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace ClientManager
{
    public class ClientManager
    {
        public List<Client> Clients { get; private set;}
        public ClientManager() 
        {
            Clients = new List<Client>();
            LoadClients();
        }
        public void AddClient(Client client)
        {
            if (client == null)
                throw new ArgumentNullException(nameof(client));

            if (string.IsNullOrWhiteSpace(client.Name) || string.IsNullOrWhiteSpace(client.Email))
                throw new ArgumentException("Имя и Email не могут быть пустыми!");
            Clients.Add(client);
            SaveClients();
        }

        public void RemoveClient(Client client)
        {
            if (client == null) throw new ArgumentNullException(nameof(client));
            if (Clients.Remove(client))
            {
                SaveClients();
            }
            else { throw new InvalidOperationException("Клиент не найден для удаления."); }

        }

        public List<Client> SearchClients(string query)
        {
            if(string.IsNullOrWhiteSpace(query))
                return Clients;
            return Clients.Where(c =>
                c.Name.Contains(query, StringComparison.OrdinalIgnoreCase) ||
                c.Email.Contains(query, StringComparison.OrdinalIgnoreCase) ||
                c.Phone.Contains(query, StringComparison.OrdinalIgnoreCase) ||
                c.Address.Contains(query, StringComparison.OrdinalIgnoreCase)
            ).ToList();
        }

        private void SaveClients()
        {
            var lines = Clients.Select(c => $"{c.Name}|{c.Email}|{c.Phone}|{c.Address}");
            File.WriteAllLines("client.txt", lines);
        }

        private void LoadClients()
        {
            if (!File.Exists("client.txt"))
                return;
            var lines = File.ReadAllLines("client.txt");
            foreach (var line in lines)
            {
                var parts = line.Split('|');
                if (parts.Length == 4)
                    Clients.Add(new Client(parts[0], parts[1], parts[2], parts[3]));
            }
        }
    }
}
