using System;
using System.Collections.Generic;
using UnityEngine;
namespace UnityEditor
{
	internal interface ITreeViewDragging
	{
		bool drawRowMarkerAbove
		{
			get;
			set;
		}
		void StartDrag(TreeViewItem draggedItem, List<int> draggedItemIDs);
		bool DragElement(TreeViewItem targetItem, Rect targetItemRect, bool firstItem);
		void DragCleanup(bool revertExpanded);
		int GetDropTargetControlID();
		int GetRowMarkerControlID();
	}
}