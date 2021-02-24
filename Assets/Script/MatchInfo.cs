using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MatchInfo
{

    public List<GridItem> match;

    public int horizontalMatchStart, horizontalMatchEnd;
    public int verticalMatchStart, verticalMatchEnd;

    public bool IsMatchValid
    {
        get
        {
            return match != null;
        }
    }

}
