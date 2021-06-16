namespace OsuSkinning.MODEL.Validators
{
    public static class NameValidator
    {
        public static ValidateState Validate(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
                return ValidateState.empty;

            return ValidateState.valid;
        }
    }
}