using System;

namespace Docnet.Core.Models
{
    public struct Character : IEquatable<Character>
    {
        public char Char { get; }

        public BoundBox Box { get; }

        public Character(char character, BoundBox box)
        {
            Char = character;
            Box = box;
        }

        public static bool operator ==(Character obj1, Character obj2)
        {
            return obj1.Equals(obj2);
        }

        public static bool operator !=(Character obj1, Character obj2)
        {
            return !(obj1 == obj2);
        }

        public bool Equals(Character other)
        {
            return Char == other.Char && Box.Equals(other.Box);
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Character))
            {
                return false;
            }

            var character = (Character)obj;

            return Equals(character);
        }

        public override int GetHashCode()
        {
            var hashCode = 13;
            hashCode = hashCode * 7 + Char.GetHashCode();
            hashCode = hashCode * 7 + Box.GetHashCode();
            return hashCode;
        }
    }
}