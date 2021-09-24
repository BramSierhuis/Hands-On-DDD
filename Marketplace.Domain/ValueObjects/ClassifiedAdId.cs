using Marketplace.Framework;
using System;

namespace Marketplace.Domain.ValueObjects
{
    public class ClassifiedAdId : Value<ClassifiedAdId>
    {
        private readonly Guid Value;
        public ClassifiedAdId(Guid value)
        {
            if (value == default)
                throw new ArgumentNullException(nameof(value), "Classified Ad id cannot be empty");

            Value = value;
        }

        public static implicit operator Guid(ClassifiedAdId self) => self.Value;

        public static implicit operator ClassifiedAdId(string value)
            => new ClassifiedAdId(Guid.Parse(value));
    }
}
