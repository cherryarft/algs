namespace Alg.solved;

public static class n303_Range_Sum_Query___Immutable
{
    public static void Run()
    {
        foreach (var (arr, left, right) in new[]
                 {
                     (new[] { -2, 0, 3, -5, 2, -1 }, 0, 2),
                     (new[] { -2, 0, 3, -5, 2, -1 }, 2, 5),
                     (new[] { -2, 0, 3, -5, 2, -1 }, 0, 5),
                 })
        {
            var res = new NumArray(arr).SumRange(left, right);
        }
    }

    private class NumArray
    {
        private readonly int[] _prefix;

        public NumArray(int[] nums)
        {
            _prefix = new int[nums.Length];
            _prefix[0] = nums[0];

            for (var i = 1; i < _prefix.Length; ++i)
            {
                _prefix[i] = _prefix[i - 1] + nums[i];
            }
        }

        public int SumRange(int left, int right)
        {
            if (left == 0) return _prefix[right];

            return _prefix[right] - _prefix[left - 1];
        }
    }
}