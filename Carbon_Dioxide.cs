using System;
using System.Diagnostics;

namespace Carbon_Transconfiguration
{
    internal abstract class Carbon_DioxideBase2
    {
        public abstract static Action<object> GetPhotosynthesis();
        protected abstract static void SetPhotosynthesis(Action<object> value);
    }

    internal class Carbon_Dioxide : Carbon_DioxideBase2
    {
        public override Action<object> photosynthesis { get; protected set; }

        public internal set
    }
}

namespace Carbon_Transconfiguration
{
    internal class set
    {
    }
}


[DebuggerDisplay("{" + nameof(GetDebuggerDisplay) + "(),nq}")]
internal class Environment
    {
    private string GetDebuggerDisplay()
    {
        return ToString();
    }
}