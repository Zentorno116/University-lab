namespace University_lab
{
    public partial class Main_Form : Form
    {
        string filePath = "../../../resourses/Universities.txt";
        List<University> universities = new List<University>();
        List<string> cities = new List<string>();
        public Main_Form()
        {
            InitializeComponent();
            ReadUniversitiesFromFile(filePath);
            ReadCitiesFromFile("../../../resourses/City.txt");
        }
        public class University
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string City { get; set; }
            public string ImagePath { get; set; }
        }
        private void ReadUniversitiesFromFile(string filePath)
        {


            var fstream = File.OpenText(filePath);
            string line;
            int i = 1;
            while ((line = fstream.ReadLine()) != null)
            {
                string[] parts = line.Split(" ");
                universities.Add(new University { Id = i, Name = parts[1].Substring(0, parts[1].Length - 1), City = parts[2].Substring(0, parts[2].Length - 1), ImagePath = parts[3] });
                i++;
            }

        }

        private void ReadCitiesFromFile(string filePath)
        {


            var fstream = File.OpenText(filePath);
            string line;
            int i = 0;
            while ((line = fstream.ReadLine()) != null)
            {
                cities.Add(line);
                i++;

            }

        }
        private void comboBoxCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedCity = comboBox1.SelectedItem.ToString();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        { }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            string selectedCity = comboBox1.SelectedItem.ToString();
            int index = -1;
            for (int i = 0; i < cities.Count; i++)
            {
                string city = cities[i];
                if (city.Contains(selectedCity))
                {
                    index = i;
                    Console.WriteLine(city);
                }
            }
            for (int i = 0; i < universities.Count;i++)
            {
                if (int.Parse(universities[i].City) == index+1)
                {
                    dataGridView1.Rows.Add(universities[i].Id, universities[i].Name, cities[index].Split(' ')[1]);
                    
                }
            }
        }
    }
}
