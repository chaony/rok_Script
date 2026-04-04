using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Data
{
    public class CityAgeSizeDefine
    {
        /// <summary> 
        /// 流水号
        /// </summary>
        [PrimaryKey] [AutoIncrement] public int ID  { get; set; }

        /// <summary> 
        /// 所属时代
        /// </summary>
        public int age;

        /// <summary> 
        /// 时代名称
        /// </summary>
        public int l_nameId;

        /// <summary> 
        /// 市政厅等级
        /// </summary>
        public int townLevel;

        /// <summary> 
        /// 内城尺寸
        /// </summary>
        public int size;

        /// <summary> 
        /// 城墙尺寸
        /// </summary>
        public int wallSize;

        /// <summary> 
        /// 网格文件
        /// </summary>
        public string mapMesh;

        /// <summary> 
        /// 时代展现UI
        /// </summary>
        public string ageShowUI;

        /// <summary> 
        /// 工人数量(男)
        /// </summary>
        public int BuilderMaleNum;

        /// <summary> 
        /// 工人数量(女)
        /// </summary>
        public int BuilderFemaleNum;

        /// <summary> 
        /// 工人等级
        /// </summary>
        public int BuilderLevel;

        /// <summary> 
        /// 开始时代变化前对白ID
        /// </summary>
        public int ageDialogBegin;

        /// <summary> 
        /// 结束时代变化时对白ID
        /// </summary>
        public int ageDialogEnd;

        /// <summary> 
        /// 警戒塔邮件图标
        /// </summary>
        public string towerMail;

        /// <summary> 
        /// 警戒塔攻城头像
        /// </summary>
        public string towerHead;

    }
}