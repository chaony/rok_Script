using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Data
{
    public class TurntableDrawProgressDefine
    {
        [PrimaryKey] [AutoIncrement] public int ID  { get; set; }

        /// <summary> 
        /// 活动ID
        /// </summary>
        public int activity;

        /// <summary> 
        /// 达标次数
        /// </summary>
        public int reach;

        /// <summary> 
        /// itempackId
        /// </summary>
        public int itempack;

        /// <summary> 
        /// 宝箱模型
        /// </summary>
        public string treasureModel;

    }
}