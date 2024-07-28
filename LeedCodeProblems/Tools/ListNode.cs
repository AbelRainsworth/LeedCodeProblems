namespace LeedCodeProblems
{
    public class ListNode(int val = 0, ListNode? next = null)
    {
        public int val = val;
        public ListNode? next = next;

        public static ListNode? CreateFromArray(List<int> arr, int deep = 0)
        {
            if (arr.Count == deep)
            {
                return null;
            }

            ListNode result = new()
            {
                val = arr[deep],
                next = CreateFromArray(arr, deep + 1)
            };

            return result;
        }
    }
}