using System;
using System.ComponentModel.DataAnnotations;
using CommunityToolkit.Mvvm.ComponentModel;

namespace AvaloniaObservableValidatorExample.ViewModels;

public partial class PersonViewModel : ObservableValidator
{
    private string _name;

    [Required(ErrorMessage = "A person must have a name.")]
    [MinLength(2, ErrorMessage = "Name is too short.")]
    [CustomValidation(typeof(PersonViewModel), nameof(ValidateName))]
    public string Name
    {
        get => _name;
        set => SetProperty(ref this._name, value, true);
    }

    public static ValidationResult ValidateName(string name, ValidationContext context)
    {
        bool isValid = (char.IsUpper(name[0]) && !name.StartsWith('X'));

        if (isValid)
        {
            return ValidationResult.Success;
        }

        return new("Bad name!");
    }
}