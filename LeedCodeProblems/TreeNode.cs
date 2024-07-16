namespace LeedCodeProblems
{
    public class TreeNode(int val = 0, TreeNode? left = null, TreeNode? right = null)
    {
        public int val = val;
        public TreeNode? left = left;
        public TreeNode? right = right;

        private static List<int> countLvl = [];

        public static TreeNode? CreateToArray(List<int?> arr, int deep = 0)
        {
            if (countLvl.Count == deep)
            {
                countLvl.Add(1);
            }

            int index = (int)Math.Pow(2, deep) - countLvl[deep];

            if (index >= arr.Count)
            {
                return null;
            }

            if (arr[index] == null)
            {
                return null;
            }

            TreeNode tn = new();
            tn.val = arr[index]!.Value;

            tn.left = CreateToArray(arr, deep + 1);
            tn.right = CreateToArray(arr, deep + 1);

            if (tn.left != null && tn.right != null)
            {
                for (int i = deep + 1; i < countLvl.Count; i++)
                {
                    countLvl[i]++;
                }
            }

            arr.RemoveAt(index);

            return tn;
        }
    }
}