namespace Alg.solved;

public static class n876_Middle_of_the_Linked_List
{
    public static void Run()
    {
        foreach (var arr in new[]
                 {
                     new[] { 1, 2, 3, 4, 5 },
                     new[] { 1, 2, 3, 4, 5, 6 }
                 })
        {
            var head = new ListNode();
            var t = head;

            foreach (var v in arr)
            {
                t.next = new ListNode { val = v };
                t = t.next;
            }

            var res = MiddleNode(head.next!);
        }
    }

    private static ListNode MiddleNode(ListNode head)
    {
        var (s, f) = (head, head);

        while (f?.next is not null)
        {
            s = s.next;
            f = f.next.next;
        }

        return s;
    }

    private class ListNode
    {
        public int val { get; set; }
        public ListNode? next { get; set; }
    }
}