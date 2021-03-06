namespace Abstract_Interface
{
    interface IStudent
    {
        int Id { get; set; }
        string Name { get; set; }
        string Surname { get; set; }
        void ShowStudentInfo();

        void Add(string name, string surname);
        void Update(int id, string name, string surname);
        void Delete(int id);
    }
}
