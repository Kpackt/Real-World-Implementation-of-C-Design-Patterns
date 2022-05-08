using System.Text.RegularExpressions;

namespace UniversityExample1;

public abstract class Person
{
    private string _email;
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public Person()
    {
        _email = string.Empty;
        FirstName = string.Empty;
        LastName = string.Empty;
    }

    public string EmailAddress
    {
        get => _email;
        set
        {
            if (value != string.Empty)
            {
                const string emailTestRegex = @"[a-z A-z 0-9_\-]+[@]+[a-z]+[\.][a-z]{3,4}$";
                var isValidEmail = Regex.IsMatch(value, emailTestRegex, RegexOptions.IgnoreCase);
                if (!isValidEmail) throw new Exception("Invalid email address");
            }
            _email = value;
        }
    }

    public virtual void BegForMoney()
    {
        throw new NotImplementedException();
    }
}