using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Data
{
    public class ItemPlayerHeadDefine
    {
        /// <summary> 
        /// 道具ID
        /// </summary>
        [PrimaryKey] [AutoIncrement] public int ID  { get; set; }

        /// <summary> 
        /// 关头像ID
        /// </summary>
        public int playerHeadID;

    }
}