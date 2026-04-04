using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Data
{
    public class ConfigDefine
    {
        /// <summary> 
        /// 程序使用
        /// </summary>
        [PrimaryKey] [AutoIncrement] public int id  { get; set; }

        /// <summary> 
        /// 创角登录服务器IP
        /// </summary>
        public string serverIP;

        /// <summary> 
        /// 创角登录用于初始创角登陆，初始自带的粮食资源
        /// </summary>
        public int initialFood;

        /// <summary> 
        /// 创角登录用于初始创角登陆，初始自带的木材资源
        /// </summary>
        public int initialWood;

        /// <summary> 
        /// 创角登录用于初始创角登陆，初始自带的石料资源
        /// </summary>
        public int initialStone;

        /// <summary> 
        /// 创角登录用于初始创角登陆，初始自带的金币资源
        /// </summary>
        public int initialGold;

        /// <summary> 
        /// 创角登录用于初始创角登陆，初始自带的钻石资源
        /// </summary>
        public int initialDiamond;

        /// <summary> 
        /// 创角登录用于初始创角登陆，初始自带的兵种类型，索引s_Arms.ID
        /// </summary>
        public List<int> initialArmsType;

        /// <summary> 
        /// 创角登录用于初始创角登陆，初始自带的兵种数量，与上一条一一对应
        /// </summary>
        public List<int> initialArmsNum;

        /// <summary> 
        /// 创角登录用于初始创角登陆，初始自带的BUFF数据，索引s_CityBuff.ID
        /// </summary>
        public int initialBuff;

        /// <summary> 
        /// 创角登录初始前轴界面npc对应的语言版本
        /// </summary>
        public List<int> initialDialogueCivilization;

        /// <summary> 
        /// 创角登录初始前轴界面npc对白对应的音效资源
        /// </summary>
        public List<string> initialDialogueAudio;

        /// <summary> 
        /// 创角登录用于初始玩家坐标生成开启随机的区域，根据案子中1~6的初级区域，1代表开启随机，0代表关闭
        /// </summary>
        public List<int> initialRandomLocation;

        /// <summary> 
        /// 创角登录1省份出生点坐标（服务端坐标点），格式：出生点1X坐标|出生点1Y坐标|出生点2X坐标|出生点2Y坐标|出生点3X坐标|出生点3Y坐标……
        /// </summary>
        public List<int> provinceCentreCoordinate1;

        /// <summary> 
        /// 创角登录2省份出生点坐标（服务端坐标点），同上
        /// </summary>
        public List<int> provinceCentreCoordinate2;

        /// <summary> 
        /// 创角登录3省份出生点坐标（服务端坐标点），同上
        /// </summary>
        public List<int> provinceCentreCoordinate3;

        /// <summary> 
        /// 创角登录4省份出生点坐标（服务端坐标点），同上
        /// </summary>
        public List<int> provinceCentreCoordinate4;

        /// <summary> 
        /// 创角登录5省份出生点坐标（服务端坐标点），同上
        /// </summary>
        public List<int> provinceCentreCoordinate5;

        /// <summary> 
        /// 创角登录6省份出生点坐标（服务端坐标点），同上
        /// </summary>
        public List<int> provinceCentreCoordinate6;

        /// <summary> 
        /// 创角登录7省份出生点坐标（服务端坐标点），同上
        /// </summary>
        public List<int> provinceCentreCoordinate7;

        /// <summary> 
        /// 创角登录8省份出生点坐标（服务端坐标点），同上
        /// </summary>
        public List<int> provinceCentreCoordinate8;

        /// <summary> 
        /// 创角登录9省份出生点坐标（服务端坐标点），同上
        /// </summary>
        public List<int> provinceCentreCoordinate9;

        /// <summary> 
        /// 创角登录10省份中心点坐标（服务端坐标点），同上
        /// </summary>
        public List<int> provinceCentreCoordinate10;

        /// <summary> 
        /// 创角登录初始玩家坐标生成半径，从小到大不同阶段的半径
        /// </summary>
        public List<int> initialRandomRadius;

        /// <summary> 
        /// 创角登录每个半径随机次数
        /// </summary>
        public int initialRandomTimes;

        /// <summary> 
        /// 创角登录已开启省份的已满标记重置的时间间隔，暂定4小时。
        /// </summary>
        public int provinceFlagCleanTime;

        /// <summary> 
        /// 城堡回收城堡数量小于等于限制值时，不进行常规城堡回收。暂定2000.
        /// </summary>
        public int hideCityLimitNum;

        /// <summary> 
        /// 创角登录用于初始创角登陆，初始自带的道具，索引s_item.ID
        /// </summary>
        public List<int> initialItemType;

        /// <summary> 
        /// 创角登录用于初始创角登陆，初始自带的道具数量，与上一条一一对应
        /// </summary>
        public List<int> initialItemNum;

        /// <summary> 
        /// 创角登录中文玩家初始默认名称语言前缀…
        /// </summary>
        public string initialAcquiescentName_40;

        /// <summary> 
        /// 创角登录英文玩家初始默认名称语言前缀
        /// </summary>
        public string initialAcquiescentName_10;

        /// <summary> 
        /// 创角登录阿语玩家初始默认名称语言前缀
        /// </summary>
        public string initialAcquiescentName_1;

        /// <summary> 
        /// 创角登录土语玩家初始默认名称语言前缀
        /// </summary>
        public string initialAcquiescentName_37;

        /// <summary> 
        /// 维护更新维护更新界面，刷新按钮冷却CD，单位：秒
        /// </summary>
        public int maintainRefreshTime;

        /// <summary> 
        /// 地图场景地图宽度，暂定7200
        /// </summary>
        public int kingdomMapWidth;

        /// <summary> 
        /// 地图场景地图长度，暂定7200
        /// </summary>
        public int kingdomMapLength;

        /// <summary> 
        /// 地图场景客户端网格间距，暂定6
        /// </summary>
        public int kingdomClientDistance;

        /// <summary> 
        /// 地图场景主场景外层级显示瓦片尺寸，暂定40
        /// </summary>
        public int kingdomMapTileSize;

        /// <summary> 
        /// 兵种训练训练终止，返还资源比例，单位：千分比
        /// </summary>
        public int trainingTerminate;

        /// <summary> 
        /// 兵种训练四个兵种训练，首次训练默认的时间，单位：秒
        /// </summary>
        public int trainingFirstTime;

        /// <summary> 
        /// 飘字常量货币数量≤1000时，飘飞数量
        /// </summary>
        public int flyingNum_1;

        /// <summary> 
        /// 飘字常量货币数量＞1000，≤1万时，飘飞数量
        /// </summary>
        public int flyingNum_2;

        /// <summary> 
        /// 飘字常量货币数量＞1万，≤5万时，飘飞数量
        /// </summary>
        public int flyingNum_3;

        /// <summary> 
        /// 飘字常量货币数量＞5万，≤15万时，飘飞数量
        /// </summary>
        public int flyingNum_4;

        /// <summary> 
        /// 飘字常量货币数量＞15万，≤50万时，飘飞数量
        /// </summary>
        public int flyingNum_5;

        /// <summary> 
        /// 飘字常量货币数量＞50万，≤150万时，飘飞数量
        /// </summary>
        public int flyingNum_6;

        /// <summary> 
        /// 飘字常量货币数量＞150万时，飘飞数量
        /// </summary>
        public int flyingNum_7;

        /// <summary> 
        /// 飘字常量飘飞动画阶段1持续时间，单位：毫秒
        /// </summary>
        public int flyingTimePhase1;

        /// <summary> 
        /// 飘字常量飘飞动画阶段2持续时间，单位：毫秒
        /// </summary>
        public int flyingTimePhase2;

        /// <summary> 
        /// 飘字常量初始飘飞缩放比例，单位：千分比
        /// </summary>
        public int flyingInitialZoom;

        /// <summary> 
        /// 飘字常量结束飘飞缩放比例，单位：千分比
        /// </summary>
        public int flyingFinishZoom;

        /// <summary> 
        /// 飘字常量粮食图标资源位置
        /// </summary>
        public string flyingFoodRes;

        /// <summary> 
        /// 飘字常量木材图标资源位置
        /// </summary>
        public string flyingWoodRes;

        /// <summary> 
        /// 飘字常量石料图标资源位置
        /// </summary>
        public string flyingStoneRes;

        /// <summary> 
        /// 飘字常量金币图标资源位置
        /// </summary>
        public string flyingGlodRes;

        /// <summary> 
        /// 飘字常量宝石图标资源位置
        /// </summary>
        public string flyingDenarRes;

        /// <summary> 
        /// 飘字常量远征勋章图标资源位置
        /// </summary>
        public string flyingMedalRes;

        /// <summary> 
        /// 飘字常量粮食飘飞目标点，x轴坐标
        /// </summary>
        public int flyingFood_X;

        /// <summary> 
        /// 飘字常量粮食飘飞目标点，y轴坐标
        /// </summary>
        public int flyingFood_Y;

        /// <summary> 
        /// 飘字常量木材飘飞目标点，x轴坐标
        /// </summary>
        public int flyingWood_X;

        /// <summary> 
        /// 飘字常量木材飘飞目标点，y轴坐标
        /// </summary>
        public int flyingWood_Y;

        /// <summary> 
        /// 飘字常量石料飘飞目标点，x轴坐标
        /// </summary>
        public int flyingStone_X;

        /// <summary> 
        /// 飘字常量石料飘飞目标点，y轴坐标
        /// </summary>
        public int flyingStone_Y;

        /// <summary> 
        /// 飘字常量金币飘飞目标点，x轴坐标
        /// </summary>
        public int flyingGlod_X;

        /// <summary> 
        /// 飘字常量金币飘飞目标点，y轴坐标
        /// </summary>
        public int flyingGlod_Y;

        /// <summary> 
        /// 统帅稀有度语言包，普通+0，优秀+1，精英+2，传说+3，史诗+4
        /// </summary>
        public int rareLanguage;

        /// <summary> 
        /// 统帅稀有度对应最高级的升星道具，白，绿，蓝，紫，橙
        /// </summary>
        public List<int> rareStarItem;

        /// <summary> 
        /// 统帅装备统帅装备对应8个位置可穿戴的装备子类型
        /// </summary>
        public List<int> heroEquipType;

        /// <summary> 
        /// 资源结算资源建筑统计间隔时间，单位：秒
        /// </summary>
        public int resStatisticsTime;

        /// <summary> 
        /// 资源采集采集本联盟归属资源点获得的采集速度加成，25%。
        /// </summary>
        public int allianceResourceGatherAdd;

        /// <summary> 
        /// 资源采集玩家进行资源点搜索时，可支持的最大范围区域半径
        /// </summary>
        public int resourceGatherFindRadius;

        /// <summary> 
        /// 资源采集服务器中两次进行资源区域刷新的时间间隔，暂定3600秒。
        /// </summary>
        public int resourceGatherRefreshFreq;

        /// <summary> 
        /// 资源采集该服务器中各资源点的最高等级，普通服务器暂定6
        /// </summary>
        public int resourceGatherPointLevelMax;

        /// <summary> 
        /// 资源采集客户端两次进行相同条件搜索的CD时间
        /// </summary>
        public int resourceGatherSearchCd;

        /// <summary> 
        /// 资源采集资源点占据的地图空间半径
        /// </summary>
        public float resourceGatherRadius;

        /// <summary> 
        /// 资源采集每单位粮食需要的负载，暂定为1
        /// </summary>
        public int foodRaito;

        /// <summary> 
        /// 资源采集每单位木材需要的负载，暂定为1
        /// </summary>
        public int woodRaito;

        /// <summary> 
        /// 资源采集每单位石头需要的负载，暂定为1
        /// </summary>
        public int stoneRaito;

        /// <summary> 
        /// 资源采集每单位金币需要的负载，暂定为1
        /// </summary>
        public int goldRaito;

        /// <summary> 
        /// 资源采集每单位宝石需要的负载，暂定为1000
        /// </summary>
        public int diamonRaito;

        /// <summary> 
        /// 新手引导攻击野蛮人新手引导结束后赠送的统帅ID
        /// </summary>
        public int guideHero;

        /// <summary> 
        /// 新手引导完成后赠送统帅的新手引导阶段编号
        /// </summary>
        public int guideHeroStage;

        /// <summary> 
        /// 新手引导新手引导开关=1开启，=0关闭
        /// </summary>
        public int guideSwich;

        /// <summary> 
        /// 新手引导功能介绍新手引导开关=1开启，=0关闭
        /// </summary>
        public int guideExSwich;

        /// <summary> 
        /// 新手引导新手引导指定步骤完成之前，隐藏大地图中的物件63
        /// </summary>
        public int guideHideMapObject;

        /// <summary> 
        /// 新手引导新手引导指定步骤完成之前，固定显示城市名称与部队名称11
        /// </summary>
        public int guideHideCityName;

        /// <summary> 
        /// 新手引导远征第一关，部队移动引导的目的地光圈位置，X|Y坐标
        /// </summary>
        public List<int> guideTroopsMove;

        /// <summary> 
        /// 战斗攻击常数
        /// </summary>
        public int attackConstant;

        /// <summary> 
        /// 战斗普通攻击系数
        /// </summary>
        public int ordinaryAttackConstant;

        /// <summary> 
        /// 战斗反击系数
        /// </summary>
        public int counterAttackConstant;

        /// <summary> 
        /// 战斗治疗系数
        /// </summary>
        public int healAttackConstant;

        /// <summary> 
        /// 战斗单位默认攻击距离
        /// </summary>
        public int attackRange;

        /// <summary> 
        /// 战斗未造成伤害或受到伤害X秒后脱离战斗
        /// </summary>
        public int outOfCombat;

        /// <summary> 
        /// 战斗受到增援时闪屏的次数
        /// </summary>
        public int reinforceTips;

        /// <summary> 
        /// 战斗治疗参数1
        /// </summary>
        public int healParameter1;

        /// <summary> 
        /// 战斗治疗参数2
        /// </summary>
        public float healParameter2;

        /// <summary> 
        /// 战斗护盾系数1
        /// </summary>
        public int shieldParameter1;

        /// <summary> 
        /// 战斗护盾系数2
        /// </summary>
        public float shieldParameter2;

        /// <summary> 
        /// 战斗兵力动态参数1
        /// </summary>
        public int troopsParameter1;

        /// <summary> 
        /// 战斗兵力动态参数2
        /// </summary>
        public int troopsParameter2;

        /// <summary> 
        /// 战斗兵力动态参数3
        /// </summary>
        public float troopsParameter3;

        /// <summary> 
        /// 战斗兵力动态参数4
        /// </summary>
        public int troopsParameter4;

        /// <summary> 
        /// 战斗兵力动态参数5
        /// </summary>
        public float troopsParameter5;

        /// <summary> 
        /// 战斗兵力动态参数6
        /// </summary>
        public int troopsParameter6;

        /// <summary> 
        /// 战斗增团玩家城市盟友额外重伤比例
        /// </summary>
        public int cityReinforceDeathProportion;

        /// <summary> 
        /// 科技研究科技研究半途终止，资源返还比例，单位：千分比
        /// </summary>
        public int studyTerminate;

        /// <summary> 
        /// 邮件邮件保存数量
        /// </summary>
        public int emailSave;

        /// <summary> 
        /// 邮件采集邮件保存数量
        /// </summary>
        public int emailResourceSave;

        /// <summary> 
        /// 邮件探索邮件的存储数量
        /// </summary>
        public int mailExploreSave;

        /// <summary> 
        /// 邮件资源援助邮件的存储数量
        /// </summary>
        public int emailResourceHelpSave;

        /// <summary> 
        /// 邮件留言通知的存储数量
        /// </summary>
        public int emailMessageSave;

        /// <summary> 
        /// 邮件被侦查邮件的存储数量
        /// </summary>
        public int emailBeScoutSave;

        /// <summary> 
        /// 邮件运营邮件模板ID
        /// </summary>
        public int emailOperationTemplate;

        /// <summary> 
        /// 邮件全服类运营邮件有效期，单位秒
        /// </summary>
        public int emailOperationExpirationDate;

        /// <summary> 
        /// 邮件玩家邮件发送间隔，单位秒
        /// </summary>
        public int emailTimeInterval;

        /// <summary> 
        /// 邮件最近联系人保存数量
        /// </summary>
        public int emailRecentContactsNum;

        /// <summary> 
        /// 邮件邮件标题字符数限制
        /// </summary>
        public int emailTitleLimit;

        /// <summary> 
        /// 邮件邮件内容字符数限制
        /// </summary>
        public int emailContentLimit;

        /// <summary> 
        /// 邮件邮件折线图增援、撤离部队点上限
        /// </summary>
        public int maxReinforce;

        /// <summary> 
        /// 怪物-野蛮人刷新野蛮人的时间间隔，暂定1800秒
        /// </summary>
        public int barbarianFreq;

        /// <summary> 
        /// 怪物-野蛮人每个瓦片平均刷新的野蛮人数量
        /// </summary>
        public int barbarianNum;

        /// <summary> 
        /// 怪物-野蛮人客户端两次进行相同条件搜索的CD时间，暂定4秒
        /// </summary>
        public int monsterSearchCd;

        /// <summary> 
        /// 怪物-野蛮人会自动刷新的野蛮人等级，20级以内
        /// </summary>
        public int barbarianLevelLimit;

        /// <summary> 
        /// 任务章节显示主线/支线面板需完成的章节需求
        /// </summary>
        public int preChapter;

        /// <summary> 
        /// 工人队列可以临时扩充工人队列的道具ID
        /// </summary>
        public int workQueueItem;

        /// <summary> 
        /// 工人队列临时扩充工人队列需要的
        /// </summary>
        public int workQueueDenar;

        /// <summary> 
        /// 工人队列临时工人队列持续时间，暂定48小时
        /// </summary>
        public int workQueueTime;

        /// <summary> 
        /// 工人队列玩家可同时拥有的建筑队列的最大数量
        /// </summary>
        public int workQueueMax;

        /// <summary> 
        /// 军队溃散部队行军速度
        /// </summary>
        public int ArmsDefeatedSpeed;

        /// <summary> 
        /// 怪物-野蛮人野蛮人占据空间半径
        /// </summary>
        public float barbarianRadius;

        /// <summary> 
        /// 行动力钻石兑换行动力，钻石数量
        /// </summary>
        public List<int> denarChangeEnery1;

        /// <summary> 
        /// 行动力钻石兑换行动力，行动力数量
        /// </summary>
        public int denarChangeEnery2;

        /// <summary> 
        /// 侦察被侦察目标等级限制
        /// </summary>
        public int detectedLv;

        /// <summary> 
        /// 治疗治疗所需最少时间，单位：秒
        /// </summary>
        public int cureMinTime;

        /// <summary> 
        /// 治疗医院容量达到对应比例之后，触发邮件提醒，单位：百分比
        /// </summary>
        public List<int> cureTriggerProportion;

        /// <summary> 
        /// 治疗医院即将满员邮件id
        /// </summary>
        public int cureFullMailID;

        /// <summary> 
        /// 治疗医院容量超出邮件id
        /// </summary>
        public int cureOverstepMailID;

        /// <summary> 
        /// 帮助帮助每次提升比例，单位：千分比
        /// </summary>
        public int helpAddProportion;

        /// <summary> 
        /// 帮助帮助每次最少提升基础时间，单位：秒
        /// </summary>
        public int helpMinAddTime;

        /// <summary> 
        /// 帮助帮助今日个人积分上限
        /// </summary>
        public int individualPointsLimit;

        /// <summary> 
        /// 帮助每次帮助可获得个人积分
        /// </summary>
        public int individualPointsAward;

        /// <summary> 
        /// 帮助帮助今日联盟积分上限
        /// </summary>
        public int alliancePointsLimit;

        /// <summary> 
        /// 帮助每次帮助可获得联盟积分
        /// </summary>
        public int alliancePointsAward;

        /// <summary> 
        /// 聊天玩家输入的文本字符限制
        /// </summary>
        public int channelWordLimit;

        /// <summary> 
        /// 聊天时间戳间隔，距离上一条消息大于X秒时需要显示时间戳
        /// </summary>
        public int timeStamp;

        /// <summary> 
        /// 聊天消息按照页数加载，每页消息条数X条
        /// </summary>
        public int channelPageLimit;

        /// <summary> 
        /// 场景城堡模型半径
        /// </summary>
        public float cityRadius;

        /// <summary> 
        /// 酒馆白银宝箱开启时间间隔CD，单位秒
        /// </summary>
        public int silverBoxCD;

        /// <summary> 
        /// 酒馆白银箱子所需道具
        /// </summary>
        public int silverBoxOpenItem;

        /// <summary> 
        /// 酒馆白银箱子所需道具数量
        /// </summary>
        public int silverBoxOpenItemNum;

        /// <summary> 
        /// 酒馆黄金箱子所需道具
        /// </summary>
        public int goldBoxOpenItem;

        /// <summary> 
        /// 酒馆黄金箱子所需道具数量
        /// </summary>
        public int goldBoxOpenItemNum;

        /// <summary> 
        /// 酒馆白银宝箱礼包组
        /// </summary>
        public int silverBoxItemPackage;

        /// <summary> 
        /// 酒馆黄金宝箱礼包组
        /// </summary>
        public int goldBoxItemPackage;

        /// <summary> 
        /// 酒馆-引导黄金宝箱首次招募奖励组
        /// </summary>
        public int goldBoxFirstReward;

        /// <summary> 
        /// 酒馆招募道具信息显示
        /// </summary>
        public List<int> boxRewardType;

        /// <summary> 
        /// 场景-昼夜转化每天初始计算时间0:00，此时为黎明状态时间开始
        /// </summary>
        public int dayNightTime;

        /// <summary> 
        /// 场景-昼夜转化黎明状态持续时间，暂定57秒
        /// </summary>
        public int dawnDuration;

        /// <summary> 
        /// 场景-昼夜转化黎明向白天转换中间态持续时间，暂定3秒
        /// </summary>
        public int dawnSwitchDuration;

        /// <summary> 
        /// 场景-昼夜转化白天状态持续时间，暂定1677秒
        /// </summary>
        public int dayDuration;

        /// <summary> 
        /// 场景-昼夜转化白天向黄昏转化中间态持续时间，暂定3秒
        /// </summary>
        public int daySwitchDuration;

        /// <summary> 
        /// 场景-昼夜转化黄昏状态持续时间，暂定57秒
        /// </summary>
        public int duskDuration;

        /// <summary> 
        /// 场景-昼夜转化黄昏向夜晚转化中间态持续时间，暂定3秒
        /// </summary>
        public int duskSwitchDuration;

        /// <summary> 
        /// 场景-昼夜转化夜晚状态持续时间，暂定597秒
        /// </summary>
        public int nightDuration;

        /// <summary> 
        /// 场景-昼夜转化夜晚向黎明转化中间态持续时间，暂定3秒
        /// </summary>
        public int nightSwitch;

        /// <summary> 
        /// 场景-昼夜转化白天转换为黄昏新手引导阶段
        /// </summary>
        public int daySwitchGuideA;

        /// <summary> 
        /// 场景-昼夜转化黄昏转换为夜晚新手引导阶段
        /// </summary>
        public int nightSwitchGuideB;

        /// <summary> 
        /// 场景-昼夜转化夜晚转换为白天新手引导阶段
        /// </summary>
        public int duskSwitchGuideC;

        /// <summary> 
        /// 场景-昼夜转化转换为正常昼夜变化新手引导阶段
        /// </summary>
        public int normalSwitchGuideD;

        /// <summary> 
        /// 基础-行动力玩家默认的行动力上限
        /// </summary>
        public int vitalityLimit;

        /// <summary> 
        /// 基础-行动力玩家默认恢复1点行动力需要时间,暂定36000毫秒
        /// </summary>
        public int vitalityRecoveryTime;

        /// <summary> 
        /// 基础-改名改名最小与最大字符限制
        /// </summary>
        public List<int> playerNameLimit;

        /// <summary> 
        /// 基础-改名改名道具类型ID
        /// </summary>
        public int playerNameCostItem;

        /// <summary> 
        /// 基础-改名改名代币价格
        /// </summary>
        public int playerNameCostDenar;

        /// <summary> 
        /// 基础-任务第一个主线任务ID
        /// </summary>
        public int initTaskMain;

        /// <summary> 
        /// 场景-资源田粮田搜索图标索引
        /// </summary>
        public string searchFoodIcon;

        /// <summary> 
        /// 场景-资源田木材搜索图标索引
        /// </summary>
        public string searchWoodIcon;

        /// <summary> 
        /// 场景-资源田石头搜索图标索引
        /// </summary>
        public string searchStoneIcon;

        /// <summary> 
        /// 场景-资源田金矿搜索图标索引
        /// </summary>
        public string searchGoldIcon;

        /// <summary> 
        /// 场景-怪物野蛮人搜索图标索引
        /// </summary>
        public string searchMonsterIcon;

        /// <summary> 
        /// 联盟联盟简称输入最少字符限制
        /// </summary>
        public int allianceAbbreviationMin;

        /// <summary> 
        /// 联盟联盟简称输入最大字符限制
        /// </summary>
        public int allianceAbbreviationMax;

        /// <summary> 
        /// 联盟首次加入联盟将获得宝石奖励
        /// </summary>
        public int allianceFirstAward;

        /// <summary> 
        /// 联盟联盟名称输入最小字符限制
        /// </summary>
        public int allianceNameMin;

        /// <summary> 
        /// 联盟联盟名称输入最大字符限制
        /// </summary>
        public int allianceNameMax;

        /// <summary> 
        /// 联盟联盟公告字符限制
        /// </summary>
        public int allianceNoticeNum;

        /// <summary> 
        /// 联盟创角联盟需求宝石数
        /// </summary>
        public int allianceEstablishCost;

        /// <summary> 
        /// 联盟联盟推荐触发时间，单位：秒
        /// </summary>
        public int allianceRecommendedTime;

        /// <summary> 
        /// 联盟联盟宣言随机，在填写的所有语言包中随机一条
        /// </summary>
        public List<string> allianceRandomManifesto;

        /// <summary> 
        /// 联盟联盟初始人数
        /// </summary>
        public int allianceInitialNum;

        /// <summary> 
        /// 联盟同一个官职任命冷却时间，单位：秒
        /// </summary>
        public int allianceOfficerCD;

        /// <summary> 
        /// 联盟联盟简称修改花费钻石数
        /// </summary>
        public int allianceAbbreviationAmend;

        /// <summary> 
        /// 联盟联盟名称修改花费钻石数
        /// </summary>
        public int allianceNameAmend;

        /// <summary> 
        /// 联盟联盟标记修改花费钻石数
        /// </summary>
        public int alliancSignAmend;

        /// <summary> 
        /// 联盟联盟审批数量上限限制，单位：条数
        /// </summary>
        public int allianceApproveNumLimit;

        /// <summary> 
        /// 联盟联盟审批无响应时间上限，超过时间自动默认为审批失效，单位：秒
        /// </summary>
        public int allianceApproveTimeLimit;

        /// <summary> 
        /// 联盟联盟战力刷新时间，单位：秒
        /// </summary>
        public int alliancePowerRefreshTime;

        /// <summary> 
        /// 联盟被帮助次数保底值
        /// </summary>
        public int alliancehelpedTimes;

        /// <summary> 
        /// 联盟联盟推荐需在新手引导，第N阶段之后才会进行触发，配置新手引导阶段
        /// </summary>
        public int allianceRecommendedLimit;

        /// <summary> 
        /// 联盟联盟邀请可允许邀请上限次数
        /// </summary>
        public int allianceInviteLimit;

        /// <summary> 
        /// 联盟联盟不活跃成员报告邮件触发时间，单位：天
        /// </summary>
        public int allianceInactivityDefine;

        /// <summary> 
        /// 场景-地图属性地图省份最小区块长宽，暂定90
        /// </summary>
        public int mapZoneSFWidth;

        /// <summary> 
        /// 基础-行动力取消野蛮人行动返还行动力邮件
        /// </summary>
        public int vitalityReturnEmail;

        /// <summary> 
        /// 建筑-工人男性工人模型索引
        /// </summary>
        public string builderMaleModel;

        /// <summary> 
        /// 建筑-工人女性工人模型索引
        /// </summary>
        public string builderFemaleModel;

        /// <summary> 
        /// 建筑-巡逻卫兵城墙巡逻的兵种类型（当前指定为弓兵）
        /// </summary>
        public int patrolGuardModel;

        /// <summary> 
        /// UI-资源栏资源栏显示粮食信息，需要市政厅等级
        /// </summary>
        public int foodShowLev;

        /// <summary> 
        /// UI-资源栏资源栏显示木材信息，需要市政厅等级
        /// </summary>
        public int woodShowLev;

        /// <summary> 
        /// UI-资源栏资源栏显示石头信息，需要市政厅等级
        /// </summary>
        public int stoneShowLev;

        /// <summary> 
        /// UI-资源栏资源栏显示金币信息，需要市政厅等级
        /// </summary>
        public int goldShowLev;

        /// <summary> 
        /// UI-资源栏资料栏显示代币信息，需要通过的新手引导阶段
        /// </summary>
        public int denarShowStep;

        /// <summary> 
        /// 场景-地图区域王国地图划分坐标区域块半径，暂定3
        /// </summary>
        public int kingdonMapZoneRadius;

        /// <summary> 
        /// 城墙城墙处于燃烧状态时，城内进行燃烧表现最多的建筑数量
        /// </summary>
        public int buildBurnNum;

        /// <summary> 
        /// 城墙城墙燃烧状态持续时间，单位：秒
        /// </summary>
        public int cityWallBurnTime;

        /// <summary> 
        /// 城墙城墙燃烧状态，每分钟删减城墙耐久值
        /// </summary>
        public int cityWallBurnDurability;

        /// <summary> 
        /// 城墙城墙灭火需求宝石
        /// </summary>
        public int cityWallOutfire;

        /// <summary> 
        /// 城墙每维修一次，回复的城墙耐久
        /// </summary>
        public int cityWallMaintainDurability;

        /// <summary> 
        /// 城墙维修一次，冷却时间，单位：秒
        /// </summary>
        public int cityWallMaintainCoolingTime;

        /// <summary> 
        /// 场景拖拽目标特效默认尺寸
        /// </summary>
        public int mapTargetEffectScale;

        /// <summary> 
        /// 斥候-半径斥候占地半径
        /// </summary>
        public float scoutRadius;

        /// <summary> 
        /// 战斗-PVP激活战争狂热状态需要达到的市政厅等级
        /// </summary>
        public int activationWarFare;

        /// <summary> 
        /// 战斗-PVP攻击玩家城市市政厅等级限制，需要>=该等级才能进行攻击
        /// </summary>
        public int attackCityLevel;

        /// <summary> 
        /// 战斗-集结集结没有联盟目标城市最小等级
        /// </summary>
        public int rallyCityMinLevel;

        /// <summary> 
        /// 战斗-集结加入集结时的时间提示判断
        /// </summary>
        public int rallyJoinTips;

        /// <summary> 
        /// 战斗-追踪术追踪术科技ID
        /// </summary>
        public int scoutStudy1;

        /// <summary> 
        /// 战斗-伪装术伪装术科技ID
        /// </summary>
        public int scoutStudy2;

        /// <summary> 
        /// 建筑队列玩家永久开启第二个建筑队列需要VIP等级
        /// </summary>
        public int workQueueReqVip;

        /// <summary> 
        /// 联盟玩家每天通过建造获得的联盟个人积分上限信息，暂定20000
        /// </summary>
        public int allianceCoinRewardDailyLimit;

        /// <summary> 
        /// 联盟-仓库联盟食物默认存储上限，暂定100W
        /// </summary>
        public int allianceFoodLimit;

        /// <summary> 
        /// 联盟-仓库联盟木材默认存储上限，暂定100W
        /// </summary>
        public int allianceWoodLimit;

        /// <summary> 
        /// 联盟-仓库联盟石料默认存储上限，暂定75W
        /// </summary>
        public int allianceStoneLimit;

        /// <summary> 
        /// 联盟-仓库联盟金币默认存储上限，暂定50W
        /// </summary>
        public int allianceGoldLimit;

        /// <summary> 
        /// 联盟-仓库联盟消耗记录数据条目上限，暂定100条
        /// </summary>
        public int allianceConsumeRecordCnt;

        /// <summary> 
        /// 联盟-领地联盟领地的最小区块长宽，暂定18
        /// </summary>
        public int territorySizeMin;

        /// <summary> 
        /// 联盟-领地联盟领地区块最大搜索长宽，暂定90
        /// </summary>
        public int territoryBlockMax;

        /// <summary> 
        /// 联盟-领地联盟资源点产出个人资源的比例，千分比。暂定50%
        /// </summary>
        public int allianceResourcePersonScale;

        /// <summary> 
        /// 联盟-领地盟资源点为联盟成员额外产出的个人资源的存储时间资源量上限，暂定存储24小时的资源产出。
        /// </summary>
        public int allianceResourcePersonTime;

        /// <summary> 
        /// 联盟-领地玩家从联盟领取资源点额外产出资源需要的等级，暂定8级
        /// </summary>
        public int allianceResourcePersonRequestLv;

        /// <summary> 
        /// 联盟-领地联盟成员建造或派遣队伍前往联盟资源中心需求角色等级。暂定8级。
        /// </summary>
        public int allianceResourcePointReqLevel;

        /// <summary> 
        /// 联盟-领地采集多少点普通资源可额外增加1点对应联盟资源数量，暂定100
        /// </summary>
        public int allianceResourceScale;

        /// <summary> 
        /// 基础跨天时间为每天的几点，暂定为16点（机房在-5时区）。
        /// </summary>
        public int systemDayTime;

        /// <summary> 
        /// 场景-迁城玩家城堡独占区域半径
        /// </summary>
        public float cityRadiusCollide;

        /// <summary> 
        /// 场景-迁城地图资源田独占区域半径
        /// </summary>
        public float resourceGatherRadiusCollide;

        /// <summary> 
        /// 场景-迁城定义服务器外围省份的编号，数组类型。值指向的s_MapZoneSF 表的zoneOrder字段值。
        /// </summary>
        public List<int> provinceOuterRingIds;

        /// <summary> 
        /// 场景-迁城新手迁城消耗的道具类型ID
        /// </summary>
        public int cityRemoveItem1;

        /// <summary> 
        /// 场景-迁城定点迁城消耗的道具类型ID
        /// </summary>
        public int cityRemoveItem2;

        /// <summary> 
        /// 场景-迁城领土迁城消耗的道具类型ID
        /// </summary>
        public int cityRemoveItem3;

        /// <summary> 
        /// 场景-迁城随机迁城消耗的道具类型ID
        /// </summary>
        public int cityRemoveItem4;

        /// <summary> 
        /// 场景-迁城建筑处于位置选择状态时显示模型的大小比例
        /// </summary>
        public float buildingRemoveModelScale;

        /// <summary> 
        /// 神秘商人商人存在时间，单位秒
        /// </summary>
        public int mysteryStoreExist;

        /// <summary> 
        /// 神秘商人商人冷却时间，单位秒
        /// </summary>
        public int mysteryStoreCooling;

        /// <summary> 
        /// 神秘商人商人可刷新次数
        /// </summary>
        public int mysteryStoreRefresh;

        /// <summary> 
        /// 神秘商人每次刷新价格
        /// </summary>
        public List<int> mysteryStoreRefreshPrice;

        /// <summary> 
        /// 充值每日特惠的每日奖励ID，索引itemPackage.group字段；
        /// </summary>
        public int rechargeDailyGift;

        /// <summary> 
        /// 充值成长基金购买vip等级限制
        /// </summary>
        public int rechargeFundVipLimit;

        /// <summary> 
        /// 充值成长基金购买商品价格id，索引s_price.ID
        /// </summary>
        public int rechargeFundPrice;

        /// <summary> 
        /// 充值限时礼包入口显示数量上限
        /// </summary>
        public int RechargeLimitBagNum;

        /// <summary> 
        /// 充值超值礼包灰态上限时间，单位：秒
        /// </summary>
        public int rechargeSaleLimitCD;

        /// <summary> 
        /// 运营时代变迁触发评星引导所需的时代等级，对应CityAge表ID
        /// </summary>
        public int reviewsCityAge;

        /// <summary> 
        /// 铁匠铺装备材料生产
        /// </summary>
        public List<int> equipMaterialMake;

        /// <summary> 
        /// 铁匠铺装备材料生产耗时，单位秒
        /// </summary>
        public int equipMaterialMakeTime;

        /// <summary> 
        /// 铁匠铺装备材料生产材料单次生成个数为10
        /// </summary>
        public int equipMaterialMakeNum;

        /// <summary> 
        /// 怪物-野蛮人城寨刷新野蛮人城寨的时间间隔，暂定7200秒
        /// </summary>
        public int barbarenFestungenFreq;

        /// <summary> 
        /// 怪物-野蛮人城寨1级区域每个瓦片平均野蛮人城寨数量2
        /// </summary>
        public int barbarenFestungenNum1;

        /// <summary> 
        /// 怪物-野蛮人城寨2级区域每个瓦片平均野蛮人城寨数量3
        /// </summary>
        public int barbarenFestungenNum2;

        /// <summary> 
        /// 怪物-野蛮人城寨3级区域每个瓦片平均野蛮人城寨数量4
        /// </summary>
        public int barbarenFestungenNum3;

        /// <summary> 
        /// 文明转换文明转换道具，填写itemID，索引s_item.ID
        /// </summary>
        public int civilizationAlterItem;

        /// <summary> 
        /// 场景—符文物件地图符文采集转圈表现时间，暂定6秒
        /// </summary>
        public int collectCircleTime;

        /// <summary> 
        /// 联盟—商店联盟分别记录库存明细、购买明细的条数上限，暂定100
        /// </summary>
        public int allianceShopRecordLimit;

        /// <summary> 
        /// 城建-资源运输运输部队的头像索引
        /// </summary>
        public string transportIcon;

        /// <summary> 
        /// 城建-资源运输运输部队的模型索引
        /// </summary>
        public string transportModel;

        /// <summary> 
        /// 城建-资源运输运输部队基础行军速度
        /// </summary>
        public int transportSpeed;

        /// <summary> 
        /// 城建-资源运输运输部队的模型半径
        /// </summary>
        public float transportRadius;

        /// <summary> 
        /// 城建-资源运输运输部队的独占区域半径
        /// </summary>
        public float transportRadiusCollide;

        /// <summary> 
        /// 城建-资源运输运输部队到达目的地时搜索目标城堡半径
        /// </summary>
        public float transportRadiusFind;

        /// <summary> 
        /// 城建-资源运输资源运输成功邮件ID
        /// </summary>
        public int transportSuccessEmail;

        /// <summary> 
        /// 城建-资源运输资源运输失败邮件ID
        /// </summary>
        public int transportFailEmail;

        /// <summary> 
        /// Vip商店VIP商店刷新日期为周天0=周日
        /// </summary>
        public int vipStoreRefresh;

        /// <summary> 
        /// 活动地狱活动积分来源数量的几率分布，1000表示100%
        /// </summary>
        public List<int> activityInfernalTypeNumRate;

        /// <summary> 
        /// 活动地狱活动各档难度的几率分布，1000表示100%
        /// </summary>
        public List<int> activityInfernalDifficultRate;

        /// <summary> 
        /// 活动地狱活动市政厅等级限制
        /// </summary>
        public int activityInfernalLevelLimit;

        /// <summary> 
        /// 活动地狱活动阶段奖励邮件模板
        /// </summary>
        public int activityInfernalMail;

        /// <summary> 
        /// 活动活动玩家行为中，城内收获最低需求收获数量
        /// </summary>
        public int activityHarvestLimit;

        /// <summary> 
        /// 远征-排行榜远征排行榜刷新间隔时间，单位秒
        /// </summary>
        public int expeditionRankingInterval;

        /// <summary> 
        /// 远征-商店远征刷新宝石价格
        /// </summary>
        public List<int> refreshPrice;

        /// <summary> 
        /// 远征-商店远征商店位置1更新间隔天数
        /// </summary>
        public int heroHead1RefreshDay;

        /// <summary> 
        /// 远征-商店远征商店位置2道具ID|价格|英雄ID
        /// </summary>
        public List<int> heroHead2;

        /// <summary> 
        /// 远征-商店远征商店位置3道具ID|每日刷新个数|英雄ID
        /// </summary>
        public List<int> heroHead3;

        /// <summary> 
        /// 远征-商店远征商店英雄头像切换时间(单位：毫秒)
        /// </summary>
        public int heroHeadTime;

        /// <summary> 
        /// 联盟-科技加入联盟若干小时内，不得进行宝石捐赠，单位：秒
        /// </summary>
        public int AllianceGemGiftCD;

        /// <summary> 
        /// 联盟-科技每日联盟贡献排行上榜最低要贡献值
        /// </summary>
        public int AllianceDailyUpperLimit;

        /// <summary> 
        /// 联盟-科技每周联盟贡献排行上榜最低要贡献值
        /// </summary>
        public int AllianceWeeklyUpperLimit;

        /// <summary> 
        /// 联盟-科技每日联盟贡献排行上榜人数
        /// </summary>
        public int AllianceDailyRankNum;

        /// <summary> 
        /// 联盟-科技每周联盟贡献排行上榜人数
        /// </summary>
        public int AllianceWeeklyRankNum;

        /// <summary> 
        /// 联盟-科技宝石捐献初始数量
        /// </summary>
        public int AllianceGemGiftNum;

        /// <summary> 
        /// 联盟-科技宝石捐赠每次递增宝石数
        /// </summary>
        public int AllianceGemGiftIncrease;

        /// <summary> 
        /// 联盟-科技宝石捐献花费宝石上限
        /// </summary>
        public int AllianceCostGemUpperLimit;

        /// <summary> 
        /// 联盟-科技每次捐献得到的基础个人积分
        /// </summary>
        public int AllianceAcquireSoloFund;

        /// <summary> 
        /// 联盟-科技每次捐献得到的基础科技点（贡献值）
        /// </summary>
        public int AllianceAcquireStudyDot;

        /// <summary> 
        /// 联盟-科技每次捐献获得的基础联盟积分
        /// </summary>
        public int AllianceAcquireFund;

        /// <summary> 
        /// 联盟-科技联盟捐献基础奖励权重
        /// </summary>
        public int AllianceStudyCrit_1;

        /// <summary> 
        /// 联盟-科技联盟捐献基础2倍暴击权重
        /// </summary>
        public int AllianceStudyCrit_2;

        /// <summary> 
        /// 联盟-科技联盟捐献基础5倍暴击权重
        /// </summary>
        public int AllianceStudyCrit_5;

        /// <summary> 
        /// 联盟-科技联盟捐献基础10倍暴击权重
        /// </summary>
        public int AllianceStudyCrit_10;

        /// <summary> 
        /// 联盟-科技捐献机会次数上限
        /// </summary>
        public int AllianceStudyGiftTime;

        /// <summary> 
        /// 联盟-科技捐献机会冷却CD，单位：秒
        /// </summary>
        public int AllianceStudyGiftCD;

        /// <summary> 
        /// 场景-符文符文采集完成特效
        /// </summary>
        public string collectFinishEffect;

        /// <summary> 
        /// 装备锻造装备可选择指定天赋 的其中一种
        /// </summary>
        public List<int> equipTalent;

        /// <summary> 
        /// 装备专属天赋提示效果
        /// </summary>
        public float equipTalentPromote;

        /// <summary> 
        /// 联盟-留言板留言板保存数据条数
        /// </summary>
        public int allianceMessageNum;

        /// <summary> 
        /// 联盟-留言板单条留言可发字符数上限
        /// </summary>
        public int allianceMessageCharacterLimit;

        /// <summary> 
        /// 联盟-留言板每层留言，最多可被回复多少条
        /// </summary>
        public int allianceMessageTierLimit;

        /// <summary> 
        /// 联盟-留言板每个玩家最多可在同一层回复几条留言
        /// </summary>
        public int allianceMessageReplyLimit;

        /// <summary> 
        /// 联盟-留言板每次刷新服务端同步多少条信息
        /// </summary>
        public int allianceMessageSyncNum;

        /// <summary> 
        /// 联盟-留言板显示回复条数
        /// </summary>
        public int allianceMessageShowReplyNum;

        /// <summary> 
        /// 城建-建筑拆除拆除装饰建筑时可返还的资源比例，千分比
        /// </summary>
        public int destoryBuildingScale;

        /// <summary> 
        /// 聊天-表情聊天表情拥有的分组数量
        /// </summary>
        public int chatEmojiGroupNum;

        /// <summary> 
        /// 聊天-表情聊天表情分组1显示的图片索引
        /// </summary>
        public string chatEmojiGroup1;

        /// <summary> 
        /// 聊天-表情聊天表情分组2显示的图片索引
        /// </summary>
        public string chatEmojiGroup2;

        /// <summary> 
        /// 聊天-表情聊天表情分组3显示的图片索引
        /// </summary>
        public string chatEmojiGroup3;

        /// <summary> 
        /// 场景-迁城回收新手迁城道具的角色等级，暂定8级
        /// </summary>
        public int destoryCityRemoveLevel;

        /// <summary> 
        /// 统帅-天赋统帅天赋名称字符最小和最大字符限制
        /// </summary>
        public List<int> heroNameLimit;

        /// <summary> 
        /// 统帅-天赋重置天赋道具ID
        /// </summary>
        public int talentResetItemID;

        /// <summary> 
        /// 联盟—建筑每个联盟要塞能增加的联盟成员人数上限，暂定每个要塞增加5个成员上限。
        /// </summary>
        public int allianceFortressMemberNum;

        /// <summary> 
        /// 联盟—建筑每增加一个联盟成员上限需要拥有的联盟旗帜数量，暂定10面
        /// </summary>
        public int allianceMemberNumFlag;

        /// <summary> 
        /// 聊天-私聊玩家私聊数据存储的最长时限，暂定7天
        /// </summary>
        public int privateChatSaveTime;

        /// <summary> 
        /// 军队-创建玩家单人PVE战斗力评价参数1
        /// </summary>
        public float battleRecommend1;

        /// <summary> 
        /// 军队-创建玩家单人PVE战斗力评价参数2
        /// </summary>
        public float battleRecommend2;

        /// <summary> 
        /// 军队-创建玩家单人PVE战斗力评价参数3
        /// </summary>
        public float battleRecommend3;

        /// <summary> 
        /// 军队-创建玩家单人PVE战斗力评价参数4
        /// </summary>
        public float battleRecommend4;

        /// <summary> 
        /// 联盟-礼物已领取和已过期的联盟礼物数据清除的时限，暂定24小时
        /// </summary>
        public int allianceGiftClean;

        /// <summary> 
        /// 王国地图使用王国地图后，从出现特效到开始清除迷雾之间的延迟时间
        /// </summary>
        public float kindomMapEffectDelay;

        /// <summary> 
        /// 场景-层级在预览层进行数据加载半径，暂定1500
        /// </summary>
        public int previewDataRadius;

        /// <summary> 
        /// 跑马灯速度倍率跑马灯信息速度
        /// </summary>
        public float scrollMessageSpeedMul;

        /// <summary> 
        /// 邮件-PVE战报与单个怪物战斗中止时战报邮件ID
        /// </summary>
        public int monsterSingleBattleInterruptMail;

        /// <summary> 
        /// 邮件-PVE战报与复数怪物战斗胜利时战报邮件ID
        /// </summary>
        public int monsterPluralBattleVectoryMail;

        /// <summary> 
        /// 邮件-PVE战报与复数怪物战斗失败时战报邮件ID
        /// </summary>
        public int monsterPluralBattleFailMail;

        /// <summary> 
        /// 邮件-PVE战报与复数怪物战斗中止时战报邮件ID
        /// </summary>
        public int monsterPluralBattleInterruptMail;

        /// <summary> 
        /// 采集活动活动中野外采集最多触发礼包奖励次数上限
        /// </summary>
        public int activityDropLimitTimes;

        /// <summary> 
        /// 顶部tip表现参数1顶部Tip出现动画的时长
        /// </summary>
        public float upTipAnimTimeOn;

        /// <summary> 
        /// 顶部tip表现参数2顶部Tip单条的最长等待时间
        /// </summary>
        public float upTipKeepLife;

        /// <summary> 
        /// 远征-气泡远征胜利时随机播放的气泡(测试)
        /// </summary>
        public List<int> expeditionVictoryBubble;

        /// <summary> 
        /// 基础-镜头镜头移动时间，暂定600毫秒
        /// </summary>
        public int cameraMoveTime;

        /// <summary> 
        /// 基础-关卡连接地图关卡连接示意图高度，格子数
        /// </summary>
        public int mapConnectHight;

        /// <summary> 
        /// 基础-关卡连接地图关卡连接示意图长度，格子数
        /// </summary>
        public int mapConnectLength;

        /// <summary> 
        /// 迁城-随机迁城1省份中心点坐标（服务端坐标点）
        /// </summary>
        public List<int> randomCityMoveCentre1;

        /// <summary> 
        /// 迁城-随机迁城2省份中心点坐标（服务端坐标点）
        /// </summary>
        public List<int> randomCityMoveCentre2;

        /// <summary> 
        /// 迁城-随机迁城3省份中心点坐标（服务端坐标点）
        /// </summary>
        public List<int> randomCityMoveCentre3;

        /// <summary> 
        /// 迁城-随机迁城4省份中心点坐标（服务端坐标点）
        /// </summary>
        public List<int> randomCityMoveCentre4;

        /// <summary> 
        /// 迁城-随机迁城5省份中心点坐标（服务端坐标点）
        /// </summary>
        public List<int> randomCityMoveCentre5;

        /// <summary> 
        /// 迁城-随机迁城6省份中心点坐标（服务端坐标点）
        /// </summary>
        public List<int> randomCityMoveCentre6;

        /// <summary> 
        /// 迁城-随机迁城7省份中心点坐标（服务端坐标点）
        /// </summary>
        public List<int> randomCityMoveCentre7;

        /// <summary> 
        /// 迁城-随机迁城8省份中心点坐标（服务端坐标点）
        /// </summary>
        public List<int> randomCityMoveCentre8;

        /// <summary> 
        /// 迁城-随机迁城9省份中心点坐标（服务端坐标点）
        /// </summary>
        public List<int> randomCityMoveCentre9;

        /// <summary> 
        /// 迁城-随机迁城10省份中心点坐标（服务端坐标点）
        /// </summary>
        public List<int> randomCityMoveCentre10;

        /// <summary> 
        /// 迁城-随机迁城随机迁城各省份检测半径
        /// </summary>
        public List<int> randomCityMoveRadius;

        /// <summary> 
        /// 基础—城堡回收设定是否自动回收未通过新手引导的离线玩家城市。0：自动回收 1：不回收
        /// </summary>
        public int hideNewCityFlag;

        /// <summary> 
        /// 基础—城堡回收过多久进行一次城堡回收检测，暂定4小时
        /// </summary>
        public int hideCityFreqTime;

        /// <summary> 
        /// 军队-创建创建部队时距离城堡最大距离
        /// </summary>
        public float troopsRadiusMax;

        /// <summary> 
        /// 队伍操作—光环时间部队操作—光环时间（s)
        /// </summary>
        public float operatingHaloTime;

        /// <summary> 
        /// VIPVIP连续登录天数限制
        /// </summary>
        public int vipSignDay;

        /// <summary> 
        /// 军队-关卡偏移玩家队伍停留在关卡不可行走区域时，自动进行的坐标偏移距离，暂定1.5
        /// </summary>
        public float checkPointMoveOffset;

        /// <summary> 
        /// 统帅统帅获取在未召唤时屏蔽的获取途径，关联itemGet表ID
        /// </summary>
        public int itemGetHide;

        /// <summary> 
        /// PVE-行动力减少队伍每获得一层状态，可获得的行动力消耗减少单位值
        /// </summary>
        public int vitalityReduceUnit;

        /// <summary> 
        /// PVE-行动力减少玩家每只队伍可获得的行动力减少状态的层数上限。
        /// </summary>
        public int vitalityReduceLevelLimit;

        /// <summary> 
        /// 场景-场景标记每个玩家最多可记录的个人标记的数量上限
        /// </summary>
        public int personMarkerLimit;

        /// <summary> 
        /// 场景-场景标记玩家自定义的各个标记描述文字字符数限制，暂定30字符
        /// </summary>
        public int mapMarkerNameLimit;

        /// <summary> 
        /// 轻伤兵头像Icon部队界面-轻伤兵头像
        /// </summary>
        public List<string> woundedSoldier;

        /// <summary> 
        /// 设置操作界面显示，超过X秒后，隐藏主界面UI
        /// </summary>
        public int slidingTime;

        /// <summary> 
        /// 基础—城堡回收设定等级小于等于多少级的玩家角色在被回收城堡时，自动退出联盟。暂定9级。
        /// </summary>
        public int hideCityExitAlliance;

        /// <summary> 
        /// 联盟-联盟邀请联盟邀请时，筛选出的备选联盟数量上限，暂定10个
        /// </summary>
        public int allianceInviteNumLimit;

        /// <summary> 
        /// 引导-任务引导玩家空闲触发主线引导提醒的时间，暂定30秒
        /// </summary>
        public int remindActivityTime;

        /// <summary> 
        /// 联盟-建造提醒客户端检测联盟建筑是否可建的间隔时间，暂定600秒
        /// </summary>
        public int allianceBuildCheckTime;

        /// <summary> 
        /// 服务器列表单服务器创建角色最大值
        /// </summary>
        public int createRoleMax;

        /// <summary> 
        /// 服务器列表新服务器时间限制(秒)
        /// </summary>
        public int newseverTimeLimit;

        /// <summary> 
        /// 基础—账号角色等级达到多少后会进行账号绑定红点提醒
        /// </summary>
        public int accountBindLevel;

        /// <summary> 
        /// 场景-刷新检测野蛮人刷新检测时间间隔，单位秒
        /// </summary>
        public int barbarianFreshTimeGap;

        /// <summary> 
        /// 场景-刷新检测野蛮人刷新检测瓦片分组间隔
        /// </summary>
        public int barbarianFreshTileGap;

        /// <summary> 
        /// 场景-刷新检测资源田刷新检测时间间隔，单位秒
        /// </summary>
        public int resourceFreshTimeGap;

        /// <summary> 
        /// 场景-刷新检测资源田刷新检测瓦片分组间隔
        /// </summary>
        public int resourceFreshTileGap;

        /// <summary> 
        /// 场景-刷新检测野蛮人城寨刷新检测时间间隔，单位秒
        /// </summary>
        public int fortressFreshTimeGap;

        /// <summary> 
        /// 场景-刷新检测野蛮人城寨刷新检测瓦片分组间隔
        /// </summary>
        public int fortressFreshTileGap;

        /// <summary> 
        /// 军队-行军军队起始点在城市掩码内时的修正坐标搜索半径
        /// </summary>
        public int troopMoveAmendRadius;

        /// <summary> 
        /// 服务器预警推送服务器预警推送人|电话
        /// </summary>
        public List<string> serverWarningPush;

        /// <summary> 
        /// 联盟-建造提醒联盟建筑指示光效表现时间，单位秒
        /// </summary>
        public int allianceBuildCheckEffectTime;

        /// <summary> 
        /// 活动-大转盘活动开启后免费抽奖次数|每日上限
        /// </summary>
        public List<int> turntableDrawParam;

        /// <summary> 
        /// 活动-大转盘抽奖主城等级需求
        /// </summary>
        public int turntableLev;

        /// <summary> 
        /// 活动-大转盘抽奖主城循环保底
        /// </summary>
        public List<int> turntableSafetynum;

        /// <summary> 
        /// 远征头像商店远征头像商店_品质对应特效
        /// </summary>
        public List<string> expeditionHeadeffect;

        /// <summary> 
        /// 多部军队-行军双击响应时间(s)
        /// </summary>
        public float moretTroopsClick;

        /// <summary> 
        /// 任务-任务显示任务面板及侧边栏显示的未达成条件的支线任务条目数量有最大值限制
        /// </summary>
        public int taskSideShowLimit;

        /// <summary> 
        /// 角色战损角色战损补偿mail_id
        /// </summary>
        public int battleDamComMinLv;

        /// <summary> 
        /// 角色战损有联盟补偿mail_id|无联盟补偿mail_id
        /// </summary>
        public List<int> battleDamComMail;

        /// <summary> 
        /// 角色战损触发战损后的补偿冷却时间(秒)
        /// </summary>
        public int battleDamComCd;

        /// <summary> 
        /// 角色战损战损帮助最大人数
        /// </summary>
        public int battleDamMaxNum;

        /// <summary> 
        /// 角色战损战损帮助响应时间(秒)
        /// </summary>
        public int battleDamHelpTime;

        /// <summary> 
        /// 角色战损战损补给车速度
        /// </summary>
        public int makeupspeed;

        /// <summary> 
        /// 联盟—盟主转让联盟盟主多久没上线会触发盟主转让检测，单位：小时
        /// </summary>
        public int allianceLeaderTransferTime;

        /// <summary> 
        /// 联盟—盟主转让自动转让盟主时优先选择这么长时间内有上线过的玩家，单位：小时
        /// </summary>
        public int allianceLeaderNearTime;

        /// <summary> 
        /// 联盟—联盟礼物每个角色可存储的联盟礼物数据的最大上限条数。暂定1000条。
        /// </summary>
        public int allianceGiftRecordLimit;

        /// <summary> 
        /// 联盟—联盟礼物客户端没有相应的联盟礼物数据时，默认显示的普通联盟礼物信息。
        /// </summary>
        public int allianceGiftNormal;

        /// <summary> 
        /// 联盟—联盟礼物客户端没有相应的联盟礼物数据时，默认显示的稀有联盟礼物信息。
        /// </summary>
        public int allianceGiftRare;

        /// <summary> 
        /// 监禁最高数量每个玩家被监禁英雄最高数量
        /// </summary>
        public int numberPersonsImprisoned;

        /// <summary> 
        /// 斥候斥候默认行军速度
        /// </summary>
        public int scoutSpeed;

        /// <summary> 
        /// 斥候行军参数1
        /// </summary>
        public int marchParameter1;

        /// <summary> 
        /// 斥候行军参数2
        /// </summary>
        public int marchParameter2;

        /// <summary> 
        /// 斥候斥候1Icon
        /// </summary>
        public string toScoutsIcon1;

        /// <summary> 
        /// 斥候斥候2Icon
        /// </summary>
        public string toScoutsIcon2;

        /// <summary> 
        /// 斥候斥候3Icon
        /// </summary>
        public string toScoutsIcon3;

        /// <summary> 
        /// 斥候斥候4Icon
        /// </summary>
        public string toScoutsIcon4;

        /// <summary> 
        /// 斥候斥候5Icon
        /// </summary>
        public string toScoutsIcon5;

        /// <summary> 
        /// 斥候斥候6Icon
        /// </summary>
        public string toScoutsIcon6;

        /// <summary> 
        /// 斥候斥候1模型
        /// </summary>
        public string toScoutsModel1;

        /// <summary> 
        /// 斥候斥候2模型
        /// </summary>
        public string toScoutsModel2;

        /// <summary> 
        /// 斥候斥候3模型
        /// </summary>
        public string toScoutsModel3;

        /// <summary> 
        /// 斥候斥候4模型
        /// </summary>
        public string toScoutsModel4;

        /// <summary> 
        /// 斥候斥候5模型
        /// </summary>
        public string toScoutsModel5;

        /// <summary> 
        /// 斥候斥候6模型
        /// </summary>
        public string toScoutsModel6;

        /// <summary> 
        /// 场景-怪物符文刷新时间点，数组类型。暂定0点、12点
        /// </summary>
        public List<int> guardianBornTime;

        /// <summary> 
        /// 赏金任务赏金任务刷新倒计时
        /// </summary>
        public int Refreshofferareward;

        /// <summary> 
        /// 赏金任务赏金任务升级等级个数
        /// </summary>
        public List<int> Numberofrewardtasklevels;

        /// <summary> 
        /// 赏金任务赏金刷新个数
        /// </summary>
        public List<int> Rewardrefreshnumber;

        /// <summary> 
        /// 据点赛季赛季天数
        /// </summary>
        public int StrongHoldseasonDays;

        /// <summary> 
        /// 斥候斥候部队的半径
        /// </summary>
        public float scoutsRadiusCollide;

        /// <summary> 
        /// 侦查消耗侦查资源类型
        /// </summary>
        public int scoutscostCurrencyType;

        /// <summary> 
        /// 侦查消耗消耗数量
        /// </summary>
        public int scoutscostCurrencyNum;

        /// <summary> 
        /// 监狱俘虏时需造成最低伤害（千分比）
        /// </summary>
        public int minimumDamagePercentage;

        /// <summary> 
        /// 监狱只可俘获市政厅10级以上的玩家
        /// </summary>
        public int prisonerLeve;

        /// <summary> 
        /// 怪物-精英怪野蛮人占据空间半径
        /// </summary>
        public float eliteMonsterRadius;

        /// <summary> 
        /// 监狱赏金赏金货币类型
        /// </summary>
        public int TypesOfRewardCurrency;

        /// <summary> 
        /// 监狱英雄最高等级
        /// </summary>
        public List<int> heroHighestlevel;

        /// <summary> 
        /// 监狱获取部队攻击力加成
        /// </summary>
        public List<int> prisonBonus;

        /// <summary> 
        /// 赏金任务搜索最大半径
        /// </summary>
        public int RoneyRewardSearchRadius;

        /// <summary> 
        /// 精英怪精英怪战斗时间
        /// </summary>
        public int eliteAttackTime;

        /// <summary> 
        /// 酒吧-拉霸拉霸刷新倒计时/秒
        /// </summary>
        public int slotsRefreshTime;

        /// <summary> 
        /// 酒吧-拉霸拉霸奖励组
        /// </summary>
        public int slotsReward;

        /// <summary> 
        /// 营救营救1Icon
        /// </summary>
        public string toRescueIcon1;

        /// <summary> 
        /// 营救营救2Icon
        /// </summary>
        public string toRescueIcon2;

        /// <summary> 
        /// 营救营救3Icon
        /// </summary>
        public string toRescueIcon3;

        /// <summary> 
        /// 营救营救4Icon
        /// </summary>
        public string toRescueIcon4;

        /// <summary> 
        /// 营救营救5Icon
        /// </summary>
        public string toRescueIcon5;

        /// <summary> 
        /// 营救营救1模型
        /// </summary>
        public string toRescueModel1;

        /// <summary> 
        /// 营救营救2模型
        /// </summary>
        public string toRescueModel2;

        /// <summary> 
        /// 营救营救3模型
        /// </summary>
        public string toRescueModel3;

        /// <summary> 
        /// 营救营救4模型
        /// </summary>
        public string toRescueModel4;

        /// <summary> 
        /// 营救营救5模型
        /// </summary>
        public string toRescueModel5;

        /// <summary> 
        /// 场景-村庄村庄可拜访标记
        /// </summary>
        public string villageFlag;

        /// <summary> 
        /// 场景-山洞山洞可探索标记预制
        /// </summary>
        public string canveFlag;

    }
}