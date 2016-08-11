using System.Collections.ObjectModel;

namespace FestManager_Core.Forms
{
    public class TreeViewNode
    {
        public int ImageIndex { get; set; }

        public string Name { get; set; }

        public int SelectedImageIndex { get; set; }

        public Collection<TreeViewNode> Children { get; set; }

        public TreeViewNode(string name, int imageIndex, int selectedImageIndex)
        {
            ImageIndex = imageIndex;
            Name = name;
            SelectedImageIndex = selectedImageIndex;
            Children = new Collection<TreeViewNode>();
        }
    }
}
