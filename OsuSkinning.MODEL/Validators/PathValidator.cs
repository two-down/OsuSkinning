using System.IO;

namespace OsuSkinning.MODEL.Validators
{
    public static class PathValidator
    {
        public static ValidateState Validate(string path)
        {
            if (string.IsNullOrWhiteSpace(path))
                return ValidateState.empty;
            if (Directory.Exists(path))
                return ValidateState.pathNotExist;

            return ValidateState.valid;
        }
    }
}