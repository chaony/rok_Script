using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Data
{
    public class SquareEmojiOffsetDefine
    {
        /// <summary> 
        /// Key
        /// </summary>
        [PrimaryKey] [AutoIncrement] public string ID  { get; set; }

        /// <summary> 
        /// X偏移值
        /// </summary>
        public float valueX;

        /// <summary> 
        /// Y偏移值
        /// </summary>
        public float valueY;

    }
}