﻿// Stores settings for a particular vessel/part popoff window

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace PartCommander
{
    public class PopOffWindow
    {
        internal Rect windowRect;
        internal bool resizingWindow = false;
        internal Part currentPart = null;
        internal uint currentPartId;
        internal bool symLock = true;
        internal int windowId;
        internal Vector2 scrollPos = new Vector2(0f, 0f);

        public PopOffWindow(float x, float y, float width, float height)
        {
            windowRect = new Rect(x, y, width, height);
            windowId = GUIUtility.GetControlID(FocusType.Passive);
        }

        public PopOffWindow(Rect r)
        {
            windowRect = r;
            windowId = GUIUtility.GetControlID(FocusType.Passive);
        }

        public PopOffWindow()
        {
            windowRect = PartCommanderScenario.Instance.gameSettings.windowDefaultRect;
            windowId = GUIUtility.GetControlID(FocusType.Passive);
        }
    }
}
