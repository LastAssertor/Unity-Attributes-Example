
# GridPaintSortingAttribute



Description
Use this attribute to add an option to customize the sorting of Active Targets in the Active Tilemap list of the Tile Palette window.

Append this attribute to a class which inherits from IComparer<GameObject> or to a method which creates an IComparer<GameObject>. The instance of IComparer generated with the attribute is used for comparing and sorting Active Target GameObjects in the Active Tilemaps list.

```

using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[GridPaintSorting]
class Alphabetical : IComparer<GameObject>
{
    public int Compare(GameObject go1, GameObject go2)
    {
        return String.Compare(go1.name, go2.name);
    }
}

class ReverseAlphabeticalComparer : IComparer<GameObject>
{
    public int Compare(GameObject go1, GameObject go2)
    {
        return -String.Compare(go1.name, go2.name);
    }

    [GridPaintSorting]
    public static IComparer<GameObject> ReverseAlphabetical()
    {
        return new ReverseAlphabeticalComparer();
    }
}

```

![gridpaintsorting](gridpaintsorting.jpg)

Items appended with this attribute will be listed under the "Tile Palette Active Targets Sorting Mode" setting found in the 'Tile Palette' subcategory (menu: Edit > Preferences > 2D > Tile Palette). Select the desired sorting method from the drop-down menu to use your customized sorting in the Tile Palette window.