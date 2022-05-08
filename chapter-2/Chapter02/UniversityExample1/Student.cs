namespace UniversityExample1;

public sealed class Student : Person
{
    private float _gpa;

    public float GPA
    {
        get => _gpa;
        set
        {
            if (value >= 0 && value <= 4.0)
                _gpa = value;
            else
                throw new Exception("The value of GPA must be between 0 and 4.");
        }
    }

    public void Study()
    {
        throw new NotImplementedException();
    }

    public void TakeTest()
    {
        throw new NotImplementedException();
    }

    public void DoHomework()
    {
        throw new NotImplementedException();
    }

    public override void BegForMoney()
    {
        throw new NotImplementedException();
    }
}