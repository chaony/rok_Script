using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Data
{
    public class MapItemTypeDefine
    {
        /// <summary> 
        /// 地图物件类型ID
        /// </summary>
        [PrimaryKey] [AutoIncrement] public int ID  { get; set; }

        /// <summary> 
        /// 名称
        /// </summary>
        public int l_nameId;

        /// <summary> 
        /// 描述
        /// </summary>
        public int l_desc;

        /// <summary> 
        /// 物件类型
        /// </summary>
        public int type;

        /// <summary> 
        /// 等级
        /// </summary>
        public int level;

        /// <summary> 
        /// 指向BUFF
        /// </summary>
        public List<int> buffData;

        /// <summary> 
        /// 模型半径
        /// </summary>
        public float radius;

        /// <summary> 
        /// 独占区半径
        /// </summary>
        public float radiusCollide;

        /// <summary> 
        /// 存在时间
        /// </summary>
        public int showTime;

        /// <summary> 
        /// 绑定光效
        /// </summary>
        public string itemEffectShow;

        /// <summary> 
        /// 模型索引
        /// </summary>
        public string modelId;

        /// <summary> 
        /// UI图标
        /// </summary>
        public string headIcon;

    }
}