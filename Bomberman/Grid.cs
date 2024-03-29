﻿using System.Numerics;

public class Grid
{
    private static float x = 3; //cell size devided by 20
    public Vector2[,] pos = new Vector2[13, 13]{ //Array of positions
        {new Vector2(0 * x, 0 * x), new  Vector2(20 * x,0 * x), new Vector2(40 * x,0 * x),new Vector2(60 * x, 0 * x),new Vector2(80 * x,0 * x),new Vector2(100 * x,0 * x),new Vector2(120 * x,0 * x),new Vector2(140 * x,0 * x),new Vector2(160 * x,0 * x),new Vector2(180 * x,0 * x), new Vector2(200 * x, 0 * x), new Vector2(220 * x, 0 * x), new Vector2(240 * x, 0 * x)},

        {new Vector2(0 * x, 20 * x), new  Vector2(20 * x,20 * x), new Vector2(40 * x,20 * x),new Vector2(60 * x, 20 * x),new Vector2(80 * x,20 * x),new Vector2(100 * x,20 * x),new Vector2(120 * x,20 * x),new Vector2(140 * x,20 * x),new Vector2(160 * x,20 * x),new Vector2(180 * x,20 * x), new Vector2(200 * x, 20 * x), new Vector2(220 * x, 20 * x), new Vector2(240 * x, 20 * x)},

        {new Vector2(0 * x, 40 * x), new  Vector2(20 * x,40 * x), new Vector2(40 * x,40 * x),new Vector2(60 * x, 40 * x),new Vector2(80 * x,40 * x),new Vector2(100 * x,40 * x),new Vector2(120 * x,40 * x),new Vector2(140 * x,40 * x),new Vector2(160 * x,40 * x),new Vector2(180 * x,40 * x), new Vector2(200 * x, 40 * x), new Vector2(220 * x, 40 * x), new Vector2(240 * x, 40 * x)},

        {new Vector2(0 * x, 60 * x), new  Vector2(20 * x,60 * x), new Vector2(40 * x,60 * x),new Vector2(60 * x, 60 * x),new Vector2(80 * x,60 * x),new Vector2(100 * x,60 * x),new Vector2(120 * x,60 * x),new Vector2(140 * x,60 * x),new Vector2(160 * x,60 * x),new Vector2(180 * x,60 * x), new Vector2(200 * x, 60 * x), new Vector2(220 * x, 60 * x), new Vector2(240 * x, 60 * x)},

        {new Vector2(0 * x, 80 * x), new  Vector2(20 * x,80 * x), new Vector2(40 * x,80 * x),new Vector2(60 * x, 80 * x),new Vector2(80 * x,80 * x),new Vector2(100 * x,80 * x),new Vector2(120 * x,80 * x),new Vector2(140 * x,80 * x),new Vector2(160 * x,80 * x),new Vector2(180 * x,80 * x), new Vector2(200 * x, 80 * x), new Vector2(220 * x, 80 * x), new Vector2(240 * x, 80 * x)},

        {new Vector2(0 * x, 100 * x), new  Vector2(20 * x,100 * x), new Vector2(40 * x,100 * x),new Vector2(60 * x, 100 * x),new Vector2(80 * x,100 * x),new Vector2(100 * x,100 * x),new Vector2(120 * x,100 * x),new Vector2(140 * x,100 * x),new Vector2(160 * x,100 * x),new Vector2(180 * x,100 * x), new Vector2(200 * x, 100 * x), new Vector2(220 * x, 100 * x), new Vector2(240 * x, 100 * x)},

        {new Vector2(0 * x, 120 * x), new  Vector2(20 * x,120 * x), new Vector2(40 * x,120 * x),new Vector2(60 * x, 120 * x),new Vector2(80 * x,120 * x),new Vector2(100 * x,120 * x),new Vector2(120 * x,120 * x),new Vector2(140 * x,120 * x),new Vector2(160 * x,120 * x),new Vector2(180 * x,120 * x), new Vector2(200 * x, 120 * x), new Vector2(220 * x, 120 * x), new Vector2(240 * x, 120 * x)},

        {new Vector2(0 * x, 140 * x), new  Vector2(20 * x,140 * x), new Vector2(40 * x,140 * x),new Vector2(60 * x, 140 * x),new Vector2(80 * x,140 * x),new Vector2(100 * x,140 * x),new Vector2(120 * x,140 * x),new Vector2(140 * x,140 * x),new Vector2(160 * x,140 * x),new Vector2(180 * x,140 * x), new Vector2(200 * x, 140 * x), new Vector2(220 * x, 140 * x), new Vector2(240 * x, 140 * x)},

        {new Vector2(0 * x, 160 * x), new  Vector2(20 * x,160 * x), new Vector2(40 * x,160 * x),new Vector2(60 * x, 160 * x),new Vector2(80 * x,160 * x),new Vector2(100 * x,160 * x),new Vector2(120 * x,160 * x),new Vector2(140 * x,160 * x),new Vector2(160 * x,160 * x),new Vector2(180 * x,160 * x), new Vector2(200 * x, 160 * x), new Vector2(220 * x, 160 * x), new Vector2(240 * x, 160 * x)},

        {new Vector2(0 * x, 180 * x), new  Vector2(20 * x,180 * x), new Vector2(40 * x,180 * x),new Vector2(60 * x, 180 * x),new Vector2(80 * x,180 * x),new Vector2(100 * x,180 * x),new Vector2(120 * x,180 * x),new Vector2(140 * x,180 * x),new Vector2(160 * x,180 * x),new Vector2(180 * x,180 * x), new Vector2(200 * x, 180 * x), new Vector2(220 * x, 180 * x), new Vector2(240 * x, 180 * x)},

        {new Vector2(0 * x, 200 * x), new  Vector2(20 * x,200 * x), new Vector2(40 * x,200 * x),new Vector2(60 * x, 200 * x),new Vector2(80 * x,200 * x),new Vector2(100 * x,200 * x),new Vector2(120 * x,200 * x),new Vector2(140 * x,200 * x),new Vector2(160 * x,200 * x),new Vector2(180 * x,200 * x), new Vector2(200 * x, 200 * x), new Vector2(220 * x, 200 * x), new Vector2(240 * x, 200 * x)},

        {new Vector2(0 * x, 220 * x), new  Vector2(20 * x,220 * x), new Vector2(40 * x,220 * x),new Vector2(60 * x, 220 * x),new Vector2(80 * x,220 * x),new Vector2(100 * x,220 * x),new Vector2(120 * x,220 * x),new Vector2(140 * x,220 * x),new Vector2(160 * x,220 * x),new Vector2(180 * x,220 * x), new Vector2(200 * x, 220 * x), new Vector2(220 * x, 220 * x), new Vector2(240 * x, 220 * x)},

        {new Vector2(0 * x, 240 * x), new  Vector2(20 * x,240 * x), new Vector2(40 * x,240 * x),new Vector2(60 * x, 240 * x),new Vector2(80 * x,240 * x),new Vector2(100 * x,240 * x),new Vector2(120 * x,240 * x),new Vector2(140 * x,240 * x),new Vector2(160 * x,240 * x),new Vector2(180 * x,240 * x), new Vector2(200 * x, 240 * x), new Vector2(220 * x, 240 * x), new Vector2(240 * x, 240 * x)}
    };
}
