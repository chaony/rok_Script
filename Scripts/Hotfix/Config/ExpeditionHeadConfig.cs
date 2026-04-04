using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Data
{
    public class ExpeditionHeadDefine
    {
        /// <summary> 
        /// ID
        /// </summary>
        [PrimaryKey] [AutoIncrement] public int ID  { get; set; }

        /// <summary> 
        /// 道具ID
        /// </summary>
        public int itemID;

        /// <summary> 
        /// 对应统帅ID
        /// </summary>
        public int heroID;

        /// <summary> 
        /// 远征币价格
        /// </summary>
        public int price;

    }
}