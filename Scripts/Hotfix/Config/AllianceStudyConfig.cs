using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Data
{
    public class AllianceStudyDefine
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
        /// 是否为主动技能
        /// </summary>
        public int skillType;

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
        /// 需求联盟粮食
        /// </summary>
        public int needFood;

        /// <summary> 
        /// 需求联盟木材
        /// </summary>
        public int needWood;

        /// <summary> 
        /// 需求联盟石料
        /// </summary>
        public int needStone;

        /// <summary> 
        /// 需求联盟金币
        /// </summary>
        public int needGold;

        /// <summary> 
        /// 需求联盟积分
        /// </summary>
        public int needLeaguePoints;

        /// <summary> 
        /// 属性类型
        /// </summary>
        public int attrType;

        /// <summary> 
        /// 提升类型
        /// </summary>
        public List<string> buffType;

        /// <summary> 
        /// 联盟属性提升类型
        /// </summary>
        public List<allianceAttrType> allianceBuffTypeNew;

        /// <summary> 
        /// 玩家属性提升类型
        /// </summary>
        public List<attrType> buffTypeNew;

        /// <summary> 
        /// 联盟领土触发BuffID
        /// </summary>
        public int BuffID;

        /// <summary> 
        /// 提升参数
        /// </summary>
        public List<int> buffData;

        /// <summary> 
        /// 研究时间
        /// </summary>
        public int costTime;

        /// <summary> 
        /// 科技点总进度
        /// </summary>
        public int progress;

        /// <summary> 
        /// 捐献货币类型
        /// </summary>
        public int currencyType;

        /// <summary> 
        /// 捐献数量
        /// </summary>
        public int currencyNum;

        /// <summary> 
        /// 语言包
        /// </summary>
        public int l_buffDesID1;

        /// <summary> 
        /// 简述1语言包
        /// </summary>
        public int l_sketchID1;

        /// <summary> 
        /// 效果描述解析1
        /// </summary>
        public float desData1;

        /// <summary> 
        /// 语言包
        /// </summary>
        public int l_buffDesID2;

        /// <summary> 
        /// 简述2语言包
        /// </summary>
        public int l_sketchID2;

        /// <summary> 
        /// 效果描述解析2
        /// </summary>
        public float desData2;

        /// <summary> 
        /// 语言包
        /// </summary>
        public int l_fullLevelDes1;

        /// <summary> 
        /// 语言包
        /// </summary>
        public int l_fullLevelDes2;

        /// <summary> 
        /// 详细属性界面数据标题文本
        /// </summary>
        public List<int> l_attrTitleID;

        /// <summary> 
        /// 数据模板
        /// </summary>
        public List<int> l_attrTemplate;

        /// <summary> 
        /// 模板解析
        /// </summary>
        public List<float> attrData;

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