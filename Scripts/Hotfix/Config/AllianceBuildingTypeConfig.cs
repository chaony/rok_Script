using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Data
{
    public class AllianceBuildingTypeDefine
    {
        /// <summary> 
        /// 联盟建筑类型
        /// </summary>
        [PrimaryKey] [AutoIncrement] public int type  { get; set; }

        /// <summary> 
        /// 联盟建筑名称
        /// </summary>
        public int l_nameId;

        /// <summary> 
        /// 描述文字1
        /// </summary>
        public int l_desc;

        /// <summary> 
        /// 描述文字2
        /// </summary>
        public int l_desc2;

        /// <summary> 
        /// 采集资源类型
        /// </summary>
        public int gatherType;

        /// <summary> 
        /// 资源半径
        /// </summary>
        public float radius;

        /// <summary> 
        /// 独占区半径
        /// </summary>
        public float radiusCollide;

        /// <summary> 
        /// 联盟领地长宽
        /// </summary>
        public int territorySize;

        /// <summary> 
        /// 建筑数量上限
        /// </summary>
        public int countDefault;

        /// <summary> 
        /// 建造速度参数1
        /// </summary>
        public float X1;

        /// <summary> 
        /// 建造速度参数2
        /// </summary>
        public float Y1;

        /// <summary> 
        /// 建造进度上限
        /// </summary>
        public float S;

        /// <summary> 
        /// 默认建造时间上限（秒）
        /// </summary>
        public int timeDefault;

        /// <summary> 
        /// 前置建筑类型1
        /// </summary>
        public int preBuilding1;

        /// <summary> 
        /// 前置建筑数量1
        /// </summary>
        public int preNum1;

        /// <summary> 
        /// 需求联盟人数
        /// </summary>
        public int playerNum;

        /// <summary> 
        /// 需求联盟总战力
        /// </summary>
        public int alliancePower;

        /// <summary> 
        /// 存在时间（秒）
        /// </summary>
        public int stillTime;

        /// <summary> 
        /// 部队容量上限
        /// </summary>
        public int armyCntLimit;

        /// <summary> 
        /// 队列数量上限
        /// </summary>
        public int queueNum;

        /// <summary> 
        /// 耐久度上限
        /// </summary>
        public int durable;

        /// <summary> 
        /// 燃烧持续时长（秒）
        /// </summary>
        public int burnLast;

        /// <summary> 
        /// 燃烧速度（/小时)
        /// </summary>
        public int durableDown;

        /// <summary> 
        /// 灭火CD时间(秒）
        /// </summary>
        public int outFireCD;

        /// <summary> 
        /// 维修速度（/小时)
        /// </summary>
        public int durableUp;

        /// <summary> 
        /// 维修联盟积分
        /// </summary>
        public int fixFund;

        /// <summary> 
        /// 维修代币
        /// </summary>
        public int fixGem;

        /// <summary> 
        /// 建设联盟个人积分
        /// </summary>
        public int allianceCoinReward;

        /// <summary> 
        /// 联盟资源点产出速度/小时
        /// </summary>
        public int holdAllianceSpeed;

        /// <summary> 
        /// 资源点产出个人资源速度/小时
        /// </summary>
        public int holdPersonSpeed;

        /// <summary> 
        /// 资源中心储量上限
        /// </summary>
        public int resAmount;

        /// <summary> 
        /// 资源中心采集速度/小时
        /// </summary>
        public int collectSpeed;

        /// <summary> 
        /// 模型索引
        /// </summary>
        public string modelId;

        /// <summary> 
        /// 在领土界面的列
        /// </summary>
        public int imgShowIndex;

        /// <summary> 
        /// 展示预制
        /// </summary>
        public string imgShow;

        /// <summary> 
        /// 前置科技类型要求
        /// </summary>
        public int scienceReq;

        /// <summary> 
        /// 采集邮件
        /// </summary>
        public int mail;

        /// <summary> 
        /// 建造成功邮件
        /// </summary>
        public int buildSuccessMail;

        /// <summary> 
        /// 建造失败邮件
        /// </summary>
        public int buildFailMail;

        /// <summary> 
        /// 拆除建筑邮件
        /// </summary>
        public int buildRemoveMail;

        /// <summary> 
        /// 摧毁建筑邮件
        /// </summary>
        public int buildDestoryMail;

        /// <summary> 
        /// 被攻击无驻防邮件
        /// </summary>
        public int buildDefenselessMail;

        /// <summary> 
        /// 建筑UI图标
        /// </summary>
        public string iconImg;

        /// <summary> 
        /// 资源图标
        /// </summary>
        public string icon;

    }
}