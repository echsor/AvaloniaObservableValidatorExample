namespace AvaloniaObservableValidatorExample.Models;

/// <summary>
/// A person has a name, age and a phone number.
/// </summary>
public class Person
{
    /// <summary>
    /// The full name of the person.
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// The age of the person.
    /// </summary>
    public int Age { get; set; }

    /// <summary>
    /// The 10-digit phone number of the person.
    /// </summary>
    public string PhoneNumber { get; set; }
}