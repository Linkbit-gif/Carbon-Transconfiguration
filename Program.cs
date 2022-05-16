// This file is used by Code Analysis to maintain SuppressMessage
// attributes that are applied to this project.
// Project-level suppressions either have no target or are given
// a specific target and scoped to a namespace, type, member, etc.

using System;

namespace Carbon_Transconfiguration
{
    class Program : Carbon_Dioxide
    {
        private static DuplicateWaitObjectException MemberAccessException;

        public static Environment Environment1 { get { Environment photosynthesis = null; return photosynthesis; } set { Carbon_Dioxide.photosynthesis = MemberAccessException = DuplicateWaitObjectException; } }

        static void Main(string[] args)
        {
            object moveBufferArea = Console.MoveBufferArea(Carbon_Dioxide.photosynthesis = NewMethod);
            NewMethod (moveBufferArea);
        }

        private static void NewMethod(object moveBufferArea)
        {
            object call = moveBufferArea;
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
