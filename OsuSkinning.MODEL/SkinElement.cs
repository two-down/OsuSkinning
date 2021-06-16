using OsuSkinning.MODEL.Validators;
using System;
using System.Collections.Generic;

namespace OsuSkinning.MODEL
{
    public class SkinElement
    {
        public string Name { get; }
        public SkinElementClass SkinElementClass { get; }
        private List<string> SubElementPaths { get; }

        public SkinElement(string name, SkinElementClass skinElementClass, List<string> subElements)
        {
            ValidateState state = NameValidator.Validate(name);
            if (state != ValidateState.valid)
                throw new ArgumentException(ValidationMessages.CreateMessage(state, name));
            if (skinElementClass == null)
                throw new ArgumentNullException();

            Name = name;
            SkinElementClass = skinElementClass;

            foreach (var subElement in subElements)
                AddNewSubElementPath(subElement);
        }

        public void AddNewSubElementPath(string path)
        {
            ValidateState state;
            state = PathValidator.Validate(path);
            if (state != ValidateState.valid)
                throw new ArgumentException(ValidationMessages.CreateMessage(state, path));

            SubElementPaths.Add(path);
        }
    }
}