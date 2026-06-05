public class WritingAssignment : Assignment
{
    public WritingAssignment(string studentName, string topic, string title) : base(studentName, topic){
        _title = title;
    }


    private string _title = "";

  

    public string GetTitle()
    {
        return _title;
    }

    public void SetTitle(string title)
    {
        _title = title;
    }


    public string GetWritingInformation()
    {
        string studentName = GetStudentName();
        return $"{_title} by {studentName}";
    }

}