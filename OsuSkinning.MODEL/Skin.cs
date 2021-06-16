using OsuSkinning.MODEL.Validators;
using System;
using System.Collections.Generic;

namespace OsuSkinning.MODEL
{
    public class Skin
    {
        public string Name { get; }
        public List<SkinElement> SkinElements { get; }

        public Skin(string name, List<SkinElement> skinElements)
        {
            ValidateState state = NameValidator.Validate(name);
            if (state != ValidateState.valid)
                throw new ArgumentException(ValidationMessages.CreateMessage(state, name));
            if (skinElements == null)
                skinElements = new List<SkinElement>();

            Name = name;
            SkinElements = skinElements;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}