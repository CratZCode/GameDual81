﻿using ThielynGame.GamePlay;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThielynGame.GamePlay.Traps;

namespace ThielynGame.LevelGenerator
{
    // this struct represent a premade section for a level. Levels consist of numerous random level sections
    class LevelSection
    {
        // a section contains information about the terrainpieces
        public List<GameObject> sectionTerrain = new List<GameObject>();
        public List<GameObject> sectionObjects = new List<GameObject>();

        // every section has certain spawn points where enemies or items can spawn
        // we have a separate spawn point for more specific objects such as keys, exit points, special items
        List<Vector2> commonSpawn = new List<Vector2>();
        List<Vector2> specialSpawn = new List<Vector2>();

        // this function changes to the terrainposition to correspond the position of the section
        public void AdjustPositions(int row, int column) 
        {
            foreach (GameObject O in sectionTerrain) 
            {
                // horizonta position is dependant on what column its on the map
                O.AdjustHorizontalPosition(1, column * 1280);
                // vertical position is dependat on what row its on the map
                O.AdjustVerticalPosition(1,  row * 768);
            }

            foreach (GameObject O in sectionObjects)
            {
                O.AdjustHorizontalPosition(1, column * 1280);
                O.AdjustVerticalPosition(1, row * 768);
            }
        }

    }
    
}
