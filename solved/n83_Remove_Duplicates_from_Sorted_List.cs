namespace Alg.solved;

public static class n83_Remove_Duplicates_from_Sorted_List
{
    public static void Run()
    {
        foreach (var arr in new[]
                 {
                     new[] { 1, 1, 1 },
                     new[] { 1, 1, 2 },
                     new[] { 1, 1, 2, 3, 3 }
                 })
        {
            var head = new ListNode();
            var t = head;

            foreach (var v in arr)
            {
                t.next = new ListNode { val = v };
                t = t.next;
            }

            var res = DeleteDuplicates(head.next!);
        }
    }

    private static ListNode DeleteDuplicates(ListNode head)
    {
        var curr = head;

        while (curr?.next is not null)
        {
            if (curr.val == curr.next.val)
            {
                curr.next = curr.next.next;
            }
            else
            {
                curr = curr.next;
            }
        }

        return head;
    }

    private class ListNode
    {
        public int val { get; set; }
        public ListNode? next { get; set; }
    }
}