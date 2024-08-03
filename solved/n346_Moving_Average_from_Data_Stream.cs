namespace Alg.solved;

public static class n346_Moving_Average_from_Data_Stream
{
    public static void Run()
    {
        foreach (var arr in new[] { new[] { 3, 1, 10, 3, 5 } })
        {
            var obj = new MovingAverage(arr[0]);

            for (var i = 1; i < arr.Length; ++i)
            {
                var res = obj.Next(arr[i]);
            }
        }
    }

    private class MovingAverage
    {
        private readonly Queue<int> _qu;
        private readonly double _n;

        private long _sum;

        public MovingAverage(int size)
        {
            _n = size;
            _sum = 0;

            _qu = new Queue<int>(size);
        }

        public double Next(int val)
        {
            _qu.Enqueue(val);
            _sum += val;

            if (_qu.Count > _n)
            {
                _sum -= _qu.Dequeue();
            }

            return _sum / (double)_qu.Count;
        }
    }
}