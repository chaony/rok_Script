using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Data
{
    public class ResourceGatherTypeDefine
    {
        /// <summary> 
        /// 流水号
        /// </summary>
        [PrimaryKey] [AutoIncrement] public int ID  { get; set; }

        /// <summary> 
        /// 资源点类型名称
        /// </summary>
        public int l_nameId;

        /// <summary> 
        /// 资源点描述文字
        /// </summary>
        public int l_descId;

        /// <summary> 
        /// 资源点描述文字2
        /// </summary>
        public int l_descId2;

        /// <summary> 
        /// 资源点类型
        /// </summary>
        public int type;

        /// <summary> 
        /// 资源点等级
        /// </summary>
        public int level;

        /// <summary> 
        /// 前置科技类型要求
        /// </summary>
        public int scienceReq;

        /// <summary> 
        /// 前置科技等级要求
        /// </summary>
        public int scienceLevReq;

        /// <summary> 
        /// 默认采集速度/小时
        /// </summary>
        public int collectSpeed;

        /// <summary> 
        /// 储量上限
        /// </summary>
        public int resAmount;

        /// <summary> 
        /// 存在时间
        /// </summary>
        public int timeLimit;

        /// <summary> 
        /// 半径空间
        /// </summary>
        public int radius;

        /// <summary> 
        /// 模型资源
        /// </summary>
        public string modelId;

        /// <summary> 
        /// Lod模型资源（作废）
        /// </summary>
        public string modelIdLod;

        /// <summary> 
        /// Lod模型资源2
        /// </summary>
        public string modelIdLod2;

        /// <summary> 
        /// 资源图标
        /// </summary>
        public string icon;

        /// <summary> 
        /// 详情界面图标
        /// </summary>
        public string iconRes;

        /// <summary> 
        /// 地图缩略图
        /// </summary>
        public string mapIconRes;

        /// <summary> 
        /// 邮件
        /// </summary>
        public int mail;

    }
}