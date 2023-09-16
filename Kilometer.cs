namespace timetable_maker
{
    [Serializable]
    public readonly struct Kilometer
    {
        public readonly int KM;
        public readonly int M;

        public Kilometer()
        {
            KM = 0;
            M = 0;
        }

        public Kilometer(int km, int m)
        {
            KM = km;
            M = m;
        }

        public Kilometer(int value)
        {
            KM = value / 1000;
            M = value % 1000;
        }

        public override readonly string ToString()
        {
            return $"K{KM}+{M.ToString().PadLeft(3, '0')}";
        }

        public readonly int Value()
        {
            return KM * 1000 + M;
        }

        public override bool Equals(object? obj)
        {
            return obj is Kilometer kilometer &&
                   KM == kilometer.KM &&
                   M == kilometer.M;
        }

        public static Kilometer operator +(Kilometer left, Kilometer right)
        {
            int kmleft = left.Value();
            int kmright = right.Value();
            return new Kilometer(kmleft + kmright);
        }

        public static Kilometer operator -(Kilometer left, Kilometer right)
        {
            int kmleft = left.Value();
            int kmright = right.Value();
            return new Kilometer(kmleft - kmright);
        }

        public static bool operator ==(Kilometer left, Kilometer right) => left.Equals(right);

        public static bool operator !=(Kilometer left, Kilometer right) => !(left == right);

        public static bool operator <(Kilometer left, Kilometer right) => left.Value() < right.Value();

        public static bool operator >(Kilometer left, Kilometer right) => left.Value() > right.Value();

        public static bool operator <=(Kilometer left, Kilometer right) => left.Value() <= right.Value();

        public static bool operator >=(Kilometer left, Kilometer right) => left.Value() >= right.Value();

        public override int GetHashCode()
        {
            return Value();
        }
    }
}