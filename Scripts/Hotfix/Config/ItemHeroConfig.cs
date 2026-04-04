using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Data
{
    public class ItemHeroDefine
    {
        /// <summary> 
        /// 道具ID
        /// </summary>
        [PrimaryKey] [AutoIncrement] public int ID  { get; set; }

        /// <summary> 
        /// 关联英雄ID
        /// </summary>
        public int heroID;

    }
}