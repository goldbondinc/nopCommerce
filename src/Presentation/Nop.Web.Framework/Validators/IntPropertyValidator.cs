using FluentValidation.Validators;

namespace Nop.Web.Framework.Validators
{
    public class IntPropertyValidator : PropertyValidator
    {
        protected override bool IsValid(PropertyValidatorContext context)
        {
            int value;
            return int.TryParse(context.PropertyValue.ToString(), out value);
        }

        public IntPropertyValidator() :
            base("Int value is out of range")
        {

        }

    }
}
