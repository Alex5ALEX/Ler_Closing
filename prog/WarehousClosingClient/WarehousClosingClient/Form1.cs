namespace WarehousClosingClient
{
    public partial class Form1 : Form
    {
        private readonly HttpClient _httpClient;

        public Form1()
        {
            InitializeComponent();
            _httpClient = new HttpClient();


            button1.Click += exitButton;
            customerMenu.Click += btnGetData_Click;

        }


        private void exitButton(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void btnGetData_Click(object sender, EventArgs e)
        {


            string apiUrl = "https://localhost:7262/api/customers"; // Ваш API URL

            var data = await GetDataFromApi(apiUrl);
            MessageBox.Show(data);
        }

        private async Task<string> GetDataFromApi(string apiUrl)
        {
            try
            {
                var response = await _httpClient.GetAsync(apiUrl);
                response.EnsureSuccessStatusCode(); // Проверка на успешный статус

                var content = await response.Content.ReadAsStringAsync();

                return content; // Возвращаем содержимое ответа
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}");
                return null;
            }
        }

    }
}
