namespace NBasicExtensionMethod
{
    public static class BooleanExtensions
    {
        public static bool And(this bool b1, bool b2)
        {
            return b1 && b2;
        }

        public static bool Or(this bool b1, bool b2)
        {
            return b1 || b2;
        }

        public static bool Not(this bool b1)
        {
            return !b1;
        }

        public static bool NAnd(this bool b1, bool b2)
        {
            return !(b1 && b2);
        }

        public static bool XNOr(this bool b1, bool b2)
        {
            return !(b1 != b2);
        }

        public static bool NOr(this bool b1, bool b2)
        {
            return !(b1 || b2);
        }

        public static bool XOr(this bool b1, bool b2)
        {
            return (b1 != b2);
        }

    }
}