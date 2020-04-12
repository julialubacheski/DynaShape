﻿using System;
using System.Collections.Generic;
using Autodesk.DesignScript.Geometry;
using Autodesk.DesignScript.Interfaces;
using Autodesk.DesignScript.Runtime;
using SharpDX;

namespace DynaShape.GeometryBinders
{
    [IsVisibleInDynamoLibrary(false)]
    public class TextBinder : GeometryBinder
    {
        public string Text;

        public TextBinder(Triple center, string text, Color4 color)
        {
            StartingPositions = new[] { center };
            Text = text;
            Color = color;
        }


        public TextBinder(Triple center, string text)
            : this (center, text, DynaShapeDisplay.DefaultLineColor)
        {
        }


        public override List<object> CreateGeometryObjects(List<Node> allNodes)
        {
            return new List<object>();
        }

#if CLI == false
        public override void CreateDisplayedGeometries(DynaShapeDisplay display, List<Node> allNodes)
        {
            display.DrawText(Text, allNodes[NodeIndices[0]].Position);
        }
#endif
    }
}
