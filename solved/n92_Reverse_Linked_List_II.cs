namespace Alg.solved;

public static class n92_Reverse_Linked_List_II
{
    public static void Run()
    {
        foreach (var (arr, left, right) in new[]
                 {
                     (new[] { 3, 5 }, 1, 2),
                     (new[] { 1, 2, 3, 4, 5 }, 2, 4),
                     (new[] { 5 }, 1, 1)
                 })
        {
            var head = new ListNode();
            var t = head;

            foreach (var v in arr)
            {
                t.next = new ListNode { val = v };
                t = t.next;
            }

            var res = ReverseBetween(head.next!, left, right);
        }
    }

    private static ListNode ReverseBetween(ListNode head, int left, int right)
    {
        if (left == right) return head;

        var (prev, curr) = ((ListNode)null!, head);

        right = right - left + 1;

        while (--left != 0)
        {
            prev = curr;
            curr = curr!.next;
        }

        var temp_prev = prev;
        var temp_curr = curr;

        while (right-- != 0)
        {
            var next = curr!.next;

            curr.next = prev;

            prev = curr;
            curr = next;
        }

        if (temp_prev is not null)
        {
            temp_prev.next = prev;
        }
        else
        {
            head = prev;
        }

        temp_curr.next = curr;

        return head;
    }

    private class ListNode
    {
        public int val { get; set; }
        public ListNode? next { get; set; }
    }
}