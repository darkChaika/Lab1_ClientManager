namespace ClientManager
{
    public partial class Form1 : Form
    {
        private ClientManager clientManager = new ClientManager();
        public Form1()
        {
            InitializeComponent();
            UpdateClientsList();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            try
            {
                string name = nameTextBox.Text.Trim();
                string email = emailTextBox.Text.Trim();
                string phone = phoneTextBox.Text.Trim();
                string address = addressTextBox.Text.Trim();

                if (string.IsNullOrWhiteSpace(name))
                {
                    MessageBox.Show("Поле 'Имя' не может быть пустым!", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    nameTextBox.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(email))
                {
                    MessageBox.Show("Поле 'Email' не может быть пустым!", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    emailTextBox.Focus();
                    return;
                }

                Client newClient = new Client(name, email, phone, address);

                clientManager.AddClient(newClient);

                nameTextBox.Clear();
                emailTextBox.Clear();
                phoneTextBox.Clear();
                addressTextBox.Clear();

                UpdateClientsList();

                MessageBox.Show("Клиент успешно добавлен!", "Успех",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при добавлении: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (clientListBox.SelectedIndex == -1)
                {
                    MessageBox.Show("Выберите клиента для удаления!", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Client selectedClient = (Client)clientListBox.SelectedItem;

                DialogResult result = MessageBox.Show(
                    $"Вы уверены, что хотите удалить клиента \"{selectedClient.Name}\"?",
                    "Подтверждение",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    clientManager.RemoveClient(selectedClient);

                    UpdateClientsList();

                    MessageBox.Show("Клиент успешно удалён!", "Успех",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при удалении: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (clientListBox.SelectedIndex == -1)
                {
                    MessageBox.Show("Выберите клиента для редактирования!", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Client selectedClient = (Client)clientListBox.SelectedItem;

                nameTextBox.Text = selectedClient.Name;
                emailTextBox.Text = selectedClient.Email;
                phoneTextBox.Text = selectedClient.Phone;
                addressTextBox.Text = selectedClient.Address;


                MessageBox.Show("Измените данные и нажмите 'Добавить' для сохранения.", "Информация",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                clientManager.RemoveClient(selectedClient);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при редактировании: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            try
            {
                string query = searchTextBox.Text.Trim();

                if (string.IsNullOrWhiteSpace(query))
                {
                    UpdateClientsList();
                    MessageBox.Show("Показаны все клиенты.", "Информация",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                List<Client> foundClients = clientManager.SearchClients(query);

                clientListBox.Items.Clear();

                if (foundClients.Count == 0)
                {
                    MessageBox.Show("Клиенты не найдены.", "Результат",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                foreach (var client in foundClients)
                {
                    clientListBox.Items.Add(client);
                }

                MessageBox.Show($"Найдено клиентов: {foundClients.Count}", "Результат",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при поиске: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                clientManager.SaveClients();

                MessageBox.Show("Данные успешно сохранены в файл clients.txt!", "Успех",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при сохранении: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            try
            {
                clientManager.LoadClients();

                UpdateClientsList();

                MessageBox.Show("Данные успешно загружены из файла clients.txt!", "Успех",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            nameTextBox.Clear();
            emailTextBox.Clear();
            phoneTextBox.Clear();
            addressTextBox.Clear();
            searchTextBox.Clear();
            nameTextBox.Focus();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы уверены, что хотите выйти?", "Выход",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void UpdateClientsList()
{
    clientListBox.Items.Clear();

    foreach (var client in clientManager.Clients)
    {
        clientListBox.Items.Add(client);
    }
}
    }
}
