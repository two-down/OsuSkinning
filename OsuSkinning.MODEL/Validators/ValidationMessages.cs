namespace OsuSkinning.MODEL.Validators
{
    public static class ValidationMessages
    {
        public static string CreateMessage(ValidateState state, string fieldName)
        {
            var message = "";

            switch (state)
            {
                case ValidateState.empty:
                    message = $"Данное поле пусто - {fieldName}.";
                    break;

                case ValidateState.pathNotExist:
                    message = $"Данный путь не существует - {fieldName}.";
                    break;
            }

            return message;
        }
    }
}