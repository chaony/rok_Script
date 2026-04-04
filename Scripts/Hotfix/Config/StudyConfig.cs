using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Data
{
    public class StudyDefine
    {
        /// <summary> 
        /// ID
        /// </summary>
        [PrimaryKey] [AutoIncrement] public int ID  { get; set; }

        /// <summary> 
        /// 语言包
        /// </summary>
        public int l_nameID;

        /// <summary> 
        /// 描述语言包
        /// </summary>
        public int l_des;

        /// <summary> 
        /// 科技大类
        /// </summary>
        public int type;

        /// <summary> 
        /// 科技子类型
        /// </summary>
        public int studyType;

        /// <summary> 
        /// 科技等级
        /// </summary>
        public int studyLv;

        /// <summary> 
        /// 需求学院等级
        /// </summary>
        public int campusLv;

        /// <summary> 
        /// 需求前置科技1
        /// </summary>
        public int preconditionStudy1;

        /// <summary> 
        /// 前置科技等级1
        /// </summary>
        public int preconditionLv1;

        /// <summary> 
        /// 需求前置科技2
        /// </summary>
        public int preconditionStudy2;

        /// <summary> 
        /// 前置科技等级2
        /// </summary>
        public int preconditionLv2;

        /// <summary> 
        /// 需求前置科技3
        /// </summary>
        public int preconditionStudy3;

        /// <summary> 
        /// 前置科技等级3
        /// </summary>
        public int preconditionLv3;

        /// <summary> 
        /// 需求前置科技4
        /// </summary>
        public int preconditionStudy4;

        /// <summary> 
        /// 前置科技等级4
        /// </summary>
        public int preconditionLv4;

        /// <summary> 
        /// 需求粮食
        /// </summary>
        public int needFood;

        /// <summary> 
        /// 需求木材
        /// </summary>
        public int needWood;

        /// <summary> 
        /// 需求石料
        /// </summary>
        public int needStone;

        /// <summary> 
        /// 需求金币
        /// </summary>
        public int needGold;

        /// <summary> 
        /// 语言包
        /// </summary>
        public int l_function;

        /// <summary> 
        /// 提升类型
        /// </summary>
        public List<string> buffType;

        /// <summary> 
        /// 提升类型
        /// </summary>
        public List<attrType> buffTypeNew;

        /// <summary> 
        /// 提升参数
        /// </summary>
        public List<int> buffData;

        /// <summary> 
        /// 语言包
        /// </summary>
        public int l_buffDesID;

        /// <summary> 
        /// 效果描述解析
        /// </summary>
        public string desData;

        /// <summary> 
        /// 花费时间
        /// </summary>
        public long costTime;

        /// <summary> 
        /// 战力
        /// </summary>
        public long power;

        /// <summary> 
        /// 图标
        /// </summary>
        public string icon;

        /// <summary> 
        /// 所在列数
        /// </summary>
        public int columns;

        /// <summary> 
        /// 科技所在位置编号
        /// </summary>
        public int location;

    }
}