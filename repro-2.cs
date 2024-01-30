namespace Repro2Namespace
{
    public static partial class Repro2Class
    {
        public static MyClass MySymbol
        {
            get { return (SomeMember != null) ? SomeMember.MySymbol : null; }
            set { if (SomeMember != null) SomeMember.MySymbol = value; }
        }

        public static Something2 Something3
        {
            get { return (SomeMember == null) ? new Something2() :  SomeMember.Something3; }
            set { if (SomeMember != null) SomeMember.Something3 = value; }
        }
    }
}