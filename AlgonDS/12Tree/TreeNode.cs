namespace AlgonDS._12Tree
{    
    public class TreeNode
    {
        public TreeNode Left { get; set; }
        public TreeNode Right { get; set; }
        public int Data { get; set; }

        public TreeNode(int data)
        {
            this.Data = data;
        }
    }
}
