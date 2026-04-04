using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Data
{
    public class CameraParamLodDefine
    {
        /// <summary> 
        /// 设置名称
        /// </summary>
        [PrimaryKey] [AutoIncrement] public string ID  { get; set; }

        /// <summary> 
        /// 镜头高度
        /// </summary>
        public float dist;

        /// <summary> 
        /// 镜头广角
        /// </summary>
        public float fov;

        /// <summary> 
        /// 镜头面积
        /// </summary>
        public float dxf;

        /// <summary> 
        /// 角度参数
        /// </summary>
        public float forwardX;

        /// <summary> 
        /// 角度参数
        /// </summary>
        public float forwardY;

        /// <summary> 
        /// 角度参数
        /// </summary>
        public float forwardZ;

    }
}