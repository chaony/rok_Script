using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Data
{
    public class BuildingModelDataDefine
    {
        /// <summary> 
        /// 流水号
        /// </summary>
        [PrimaryKey] [AutoIncrement] public int ID  { get; set; }

        /// <summary> 
        /// 建筑类型
        /// </summary>
        public int type;

        /// <summary> 
        /// 文明类型
        /// </summary>
        public int civType;

        /// <summary> 
        /// 文明阶段
        /// </summary>
        public int age;

        /// <summary> 
        /// 模型资源
        /// </summary>
        public string modelId;

        /// <summary> 
        /// 图片预制
        /// </summary>
        public string imgRes;

    }
}