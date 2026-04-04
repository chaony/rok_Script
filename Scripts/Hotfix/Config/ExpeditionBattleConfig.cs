using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Data
{
    public class ExpeditionBattleDefine
    {
        /// <summary> 
        /// ID
        /// </summary>
        [PrimaryKey] [AutoIncrement] public int ID  { get; set; }

        /// <summary> 
        /// 关卡名称
        /// </summary>
        public int nameID;

        /// <summary> 
        /// 地图ID
        /// </summary>
        public string mapID;

        /// <summary> 
        /// 地图大小
        /// </summary>
        public List<int> mapSize;

        /// <summary> 
        /// 初始镜头坐标点
        /// </summary>
        public List<int> initialCamera;

        /// <summary> 
        /// X坐标偏移量
        /// </summary>
        public int deviationX;

        /// <summary> 
        /// Y坐标偏移量
        /// </summary>
        public int deviationY;

        /// <summary> 
        /// 城市皮肤
        /// </summary>
        public string playerCitySkin;

        /// <summary> 
        /// 玩家城市坐标
        /// </summary>
        public List<int> playerCityBornInfo;

        /// <summary> 
        /// 玩家城市兵力上限
        /// </summary>
        public int playerCityMaxNumber;

        /// <summary> 
        /// 集结部队出生信息
        /// </summary>
        public List<int> playerRallyBornInfo;

        /// <summary> 
        /// 加入集结部队出生点1
        /// </summary>
        public int joinRallyBornInfo1;

        /// <summary> 
        /// 加入集结部队出生点2
        /// </summary>
        public int joinRallyBornInfo2;

        /// <summary> 
        /// 加入集结部队出生点3
        /// </summary>
        public int joinRallyBornInfo3;

        /// <summary> 
        /// 加入集结部队出生点4
        /// </summary>
        public int joinRallyBornInfo4;

        /// <summary> 
        /// 加入集结部队出生点5
        /// </summary>
        public int joinRallyBornInfo5;

        /// <summary> 
        /// 玩家部队1出生信息
        /// </summary>
        public List<int> playerBornInfo1;

        /// <summary> 
        /// 玩家部队2出生信息
        /// </summary>
        public List<int> playerBornInfo2;

        /// <summary> 
        /// 玩家部队3出生信息
        /// </summary>
        public List<int> playerBornInfo3;

        /// <summary> 
        /// 玩家部队4出生信息
        /// </summary>
        public List<int> playerBornInfo4;

        /// <summary> 
        /// 玩家部队5出生信息
        /// </summary>
        public List<int> playerBornInfo5;

        /// <summary> 
        /// BOSS怪ID
        /// </summary>
        public int bossID;

        /// <summary> 
        /// boss出生信息
        /// </summary>
        public List<int> bossBornInfo;

        /// <summary> 
        /// 目标城市皮肤
        /// </summary>
        public string targetCitySkin;

        /// <summary> 
        /// 驻守目标城市怪物ID
        /// </summary>
        public int targetCityMonsterID;

        /// <summary> 
        /// 驻守目标城市警戒塔等级
        /// </summary>
        public int targetCityGuardTowerlevel;

        /// <summary> 
        /// 目标城市出生点
        /// </summary>
        public List<int> targetCityBornInfo;

        /// <summary> 
        /// 怪物刷新间隔
        /// </summary>
        public List<int> monsterRefreshTimes;

        /// <summary> 
        /// 怪物1ID
        /// </summary>
        public int monster1ID;

        /// <summary> 
        /// 怪物1出生信息
        /// </summary>
        public List<int> monster1BornInfo;

        /// <summary> 
        /// 怪物1刷新规则
        /// </summary>
        public List<int> monster1RefreshRule;

        /// <summary> 
        /// 怪物2ID
        /// </summary>
        public int monster2ID;

        /// <summary> 
        /// 怪物2出生信息
        /// </summary>
        public List<int> monster2BornInfo;

        /// <summary> 
        /// 怪物2刷新规则
        /// </summary>
        public List<int> monster2RefreshRule;

        /// <summary> 
        /// 怪物3ID
        /// </summary>
        public int monster3ID;

        /// <summary> 
        /// 怪物3出生信息
        /// </summary>
        public List<int> monster3BornInfo;

        /// <summary> 
        /// 怪物3刷新规则
        /// </summary>
        public List<int> monster3RefreshRule;

        /// <summary> 
        /// 怪物4ID
        /// </summary>
        public int monster4ID;

        /// <summary> 
        /// 怪物4出生信息
        /// </summary>
        public List<int> monster4BornInfo;

        /// <summary> 
        /// 怪物4刷新规则
        /// </summary>
        public List<int> monster4RefreshRule;

        /// <summary> 
        /// 怪物5ID
        /// </summary>
        public int monster5ID;

        /// <summary> 
        /// 怪物5出生信息
        /// </summary>
        public List<int> monster5BornInfo;

        /// <summary> 
        /// 怪物5刷新规则
        /// </summary>
        public List<int> monster5RefreshRule;

        /// <summary> 
        /// 范围
        /// </summary>
        public int rangeDistance;

    }
}