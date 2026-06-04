public class WritingAssignment : Assignment
{
    public WritingAssignment(string studentName, string topic, string title) : base(studentName, topic){
        _title = title;
    }


    private string _title = "";

  

    public string Gettitle()
    {
        return _title;
    }

    public void Settitle(string title)
    {
        _title = title;
    }


    public string GetWritingInformation()
    {
        string studentName = GetStudentName();
        return $"{_title} by {studentName}";
    }

}