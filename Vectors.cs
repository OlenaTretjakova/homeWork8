namespace homeWork
{
    internal struct Vectors
    {
        public int[] vectorCoordinats;
        public Vectors(int x, int y, int z)
        {
            vectorCoordinats = new int[] { x, y, z };

        }

        public Vectors(Vectors vector)
        {
            vectorCoordinats = new int[] { vector.vectorCoordinats[0],
                                           vector.vectorCoordinats[1],
                                           vector.vectorCoordinats[2] };

        }

        public static Vectors SumOfVectors(Vectors vector, Vectors other)
        {
            return new Vectors(vector.vectorCoordinats[0] + other.vectorCoordinats[0],
                                 vector.vectorCoordinats[1] + other.vectorCoordinats[1],
                                 vector.vectorCoordinats[2] + other.vectorCoordinats[2]);
        }

        public static Vectors MultipyOfVectors(Vectors vector, Vectors other)
        {
            return new Vectors(vector.vectorCoordinats[0] * other.vectorCoordinats[0],
                                 vector.vectorCoordinats[1] * other.vectorCoordinats[1],
                                 vector.vectorCoordinats[2] * other.vectorCoordinats[2]);
        }

        public static Vectors DivisionOfVectors(Vectors vector, Vectors other)
        {
            return new Vectors(vector.vectorCoordinats[0] - other.vectorCoordinats[0],
                                 vector.vectorCoordinats[1] - other.vectorCoordinats[1],
                                 vector.vectorCoordinats[2] - other.vectorCoordinats[2]);
        }

        public override string ToString()
        {
            return $"Vectors: ({vectorCoordinats[0]}, {vectorCoordinats[1]}, {vectorCoordinats[2]})";
        }

    }
}
