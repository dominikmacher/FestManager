using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace FestManager_Core.Forms
{
    public class TreeViewNode
    {
        public int imageIndex;
        public string name;
        public int selectedImageIndex;
        public Collection<TreeViewNode> children;

        public TreeViewNode(string name, int imageIndex, int selectedImageIndex)
        {
            this.imageIndex = imageIndex;
            this.name = name;
            this.selectedImageIndex = selectedImageIndex;
            this.children = new Collection<TreeViewNode>();
        }
    }
}
