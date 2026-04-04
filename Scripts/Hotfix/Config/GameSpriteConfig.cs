using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Data
{
    public class GameSpriteDefine
    {
        /// <summary> 
        /// 流水号
        /// </summary>
        [PrimaryKey] [AutoIncrement] public int ID  { get; set; }

        /// <summary> 
        /// 分组及语言包
        /// </summary>
        public int title;

        /// <summary> 
        /// 问题内容
        /// </summary>
        public int subTitle;

        /// <summary> 
        /// 问题答案
        /// </summary>
        public int text;

    }
}