namespace LinesLib
{
    public class LinesLib
    {
        public int x1 { get; set; }
        public int y1 { get; set; }




        public override string ToString()
        {
            return $"{x1},{y1}";
        }

        public bool Contain(int x)
        {
            return x1 <= x && x <= y1;
        }

        public bool Contains(int x, int y)
        {
            return x1 <= x && x <= y1 && x1 <= y && y <= y1;
        }



        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }
            var other = (LinesLib)obj;
            return x1 == other.x1 && y1 == other.y1;
        }

        public LinesLib Intersection(LinesLib line)
        {
            int nyX = Math.Max(x1, line.x1);
            int nyY = Math.Min(y1, line.y1);
            LinesLib nyVærdier = new LinesLib() { x1 = nyX, y1 = nyY };

            if (nyX > nyY)
            {
                throw new ArgumentException("Det går ik det her");
            }
            return nyVærdier;
        }
    }
}