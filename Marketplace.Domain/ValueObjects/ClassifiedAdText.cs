using Marketplace.Framework;

namespace Marketplace.Domain.ValueObjects
{
    public class ClassifiedAdText : Value<ClassifiedAdText>
    {
        public string Value { get; }

        internal ClassifiedAdText(string text) => Value = text;

        public static ClassifiedAdText FromString(string text) =>
            new ClassifiedAdText(text);

        public static implicit operator string(ClassifiedAdText self) => self.Value;
    }
}