// Decompiled with JetBrains decompiler
// Type: SRPG.GameSettings
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2000F5D")]
  [ExecuteInEditMode]
  public class GameSettings : ScriptableObject
  {
    [Token(Token = "0x4003435")]
    public const float ListRefreshFadeTime = 0.3f;
    [Token(Token = "0x4003436")]
    [FieldOffset(Offset = "0x0")]
    private static GameSettings mInstance;
    [Token(Token = "0x4003437")]
    [FieldOffset(Offset = "0xC")]
    public int Network_BGDLChunkSize;
    [Token(Token = "0x4003438")]
    [FieldOffset(Offset = "0x10")]
    public string[] Tutorial_Steps;
    [Token(Token = "0x4003439")]
    [FieldOffset(Offset = "0x14")]
    public string[] Tutorial_Flags;
    [Token(Token = "0x400343A")]
    [FieldOffset(Offset = "0x18")]
    [Tooltip("カメラの上下の傾きの角度")]
    public float GameCamera_AngleX;
    [Token(Token = "0x400343B")]
    [FieldOffset(Offset = "0x1C")]
    [Tooltip("クエストでのカメラの最低回転角度")]
    public float GameCamera_YawMin;
    [Token(Token = "0x400343C")]
    [FieldOffset(Offset = "0x20")]
    [Tooltip("クエストでのカメラの最大回転角度")]
    public float GameCamera_YawMax;
    [Token(Token = "0x400343D")]
    [FieldOffset(Offset = "0x24")]
    [Tooltip("クエストカメラで限界を超えて回転できる角度")]
    public float GameCamera_YawSoftLimit;
    [Token(Token = "0x400343E")]
    [FieldOffset(Offset = "0x28")]
    [Tooltip("カメラでユニットを注視する際の高さオフセット")]
    public float GameCamera_UnitHeightOffset;
    [Token(Token = "0x400343F")]
    [FieldOffset(Offset = "0x2C")]
    [Tooltip("カメラのデフォルトの距離")]
    public float GameCamera_DefaultDistance;
    [Token(Token = "0x4003440")]
    [FieldOffset(Offset = "0x30")]
    [Tooltip("引いたカメラの距離")]
    public float GameCamera_MoreFarDistance;
    [Token(Token = "0x4003441")]
    [FieldOffset(Offset = "0x34")]
    [Tooltip("BigUnit時のカメラ距離に加算する値")]
    public float GameCamera_BigUnitAddDistance;
    [Token(Token = "0x4003442")]
    [FieldOffset(Offset = "0x38")]
    [Tooltip("イベントカメラのデフォルトの距離")]
    public float GameCamera_EventCameraDistance;
    [Token(Token = "0x4003443")]
    [FieldOffset(Offset = "0x3C")]
    [Tooltip("カメラのマップ確認時の距離")]
    public float GameCamera_MapDistance;
    [Token(Token = "0x4003444")]
    [FieldOffset(Offset = "0x40")]
    [Tooltip("カメラの最大距離")]
    public float GameCamera_MaxDistance;
    [Token(Token = "0x4003445")]
    [FieldOffset(Offset = "0x44")]
    [Range(1f, 80f)]
    public float GameCamera_TacticsSceneFOV;
    [Token(Token = "0x4003446")]
    [FieldOffset(Offset = "0x48")]
    [Range(1f, 80f)]
    public float GameCamera_BattleSceneFOV;
    [Token(Token = "0x4003447")]
    [FieldOffset(Offset = "0x4C")]
    [Tooltip("マップ上でスキルを使用する際のカメラの距離")]
    public float GameCamera_SkillCameraDistance;
    [Token(Token = "0x4003448")]
    [FieldOffset(Offset = "0x50")]
    [Tooltip("敵の行動前の待機時間　1/MoveWait秒")]
    public float AiUnit_MoveWait;
    [Token(Token = "0x4003449")]
    [FieldOffset(Offset = "0x54")]
    [Tooltip("敵の行動前の待機時間　1/SkillWait秒")]
    public float AiUnit_SkillWait;
    [Token(Token = "0x400344A")]
    [FieldOffset(Offset = "0x58")]
    [Tooltip("キャラクターの最大の発光強度")]
    public float Unit_MaxGlowStrength;
    [Token(Token = "0x400344B")]
    [FieldOffset(Offset = "0x5C")]
    [Tooltip("小ジャンプの閾値")]
    public float Unit_StepAnimationThreshold;
    [Token(Token = "0x400344C")]
    [FieldOffset(Offset = "0x60")]
    [Tooltip("段差登りの閾値")]
    public float Unit_JumpAnimationThreshold;
    [Token(Token = "0x400344D")]
    [FieldOffset(Offset = "0x64")]
    [Tooltip("落下の閾値")]
    public float Unit_FallAnimationThreshold;
    [Token(Token = "0x400344E")]
    [FieldOffset(Offset = "0x68")]
    [Tooltip("段差登り時の前方方向へのカーブ")]
    public AnimationCurve Unit_JumpZCurve;
    [Token(Token = "0x400344F")]
    [FieldOffset(Offset = "0x6C")]
    [Tooltip("段差登り時の上方向へのカーブ")]
    public AnimationCurve Unit_JumpYCurve;
    [Token(Token = "0x4003450")]
    [FieldOffset(Offset = "0x70")]
    [Tooltip("段差登り時の最小時間")]
    public float Unit_JumpMinTime;
    [Token(Token = "0x4003451")]
    [FieldOffset(Offset = "0x74")]
    [Tooltip("段差登り時の高さ1毎の追加時間")]
    public float Unit_JumpTimePerHeight;
    [Token(Token = "0x4003452")]
    [FieldOffset(Offset = "0x78")]
    [Tooltip("段差降り時の最小時間")]
    public float Unit_FallMinTime;
    [Token(Token = "0x4003453")]
    [FieldOffset(Offset = "0x7C")]
    [Tooltip("段差降り時の高さ1毎の追加時間")]
    public float Unit_FallTimePerHeight;
    [Token(Token = "0x4003454")]
    [FieldOffset(Offset = "0x80")]
    [Tooltip("キャラクターを揺らす幅")]
    public float ShakeUnit_Offset;
    [Token(Token = "0x4003455")]
    [FieldOffset(Offset = "0x84")]
    [Tooltip("キャラクターを揺らす回数")]
    public int ShakeUnit_MaxCount;
    [Token(Token = "0x4003456")]
    [FieldOffset(Offset = "0x88")]
    [Tooltip("キャラクターの最大の発光強度")]
    public int Gem_DrainCount_FrontHit;
    [Token(Token = "0x4003457")]
    [FieldOffset(Offset = "0x8C")]
    public int Gem_DrainCount_SideHit;
    [Token(Token = "0x4003458")]
    [FieldOffset(Offset = "0x90")]
    public int Gem_DrainCount_BackHit;
    [Token(Token = "0x4003459")]
    [FieldOffset(Offset = "0x94")]
    public int Gem_DrainCount_Randomness;
    [Token(Token = "0x400345A")]
    [FieldOffset(Offset = "0x98")]
    public Color32 Buff_TextTopColor;
    [Token(Token = "0x400345B")]
    [FieldOffset(Offset = "0x9C")]
    public Color32 Buff_TextBottomColor;
    [Token(Token = "0x400345C")]
    [FieldOffset(Offset = "0xA0")]
    public Color32 Debuff_TextTopColor;
    [Token(Token = "0x400345D")]
    [FieldOffset(Offset = "0xA4")]
    public Color32 Debuff_TextBottomColor;
    [Token(Token = "0x400345E")]
    [FieldOffset(Offset = "0xA8")]
    public Color32 FailCondition_TextTopColor;
    [Token(Token = "0x400345F")]
    [FieldOffset(Offset = "0xAC")]
    public Color32 FailCondition_TextBottomColor;
    [Token(Token = "0x4003460")]
    [FieldOffset(Offset = "0xB0")]
    [Tooltip("被ヒット時のポップアップの発生間隔")]
    public float HitPopup_PopDeley;
    [Token(Token = "0x4003461")]
    [FieldOffset(Offset = "0xB4")]
    [Tooltip("被ヒット時のポップアップの表示間隔")]
    public float HitPopup_YSpacing;
    [Token(Token = "0x4003462")]
    [FieldOffset(Offset = "0xB8")]
    [Tooltip("クリティカル演出で発生するフラッシュ効果の強さ")]
    public float CriticalHit_FlashStrength;
    [Token(Token = "0x4003463")]
    [FieldOffset(Offset = "0xBC")]
    [Tooltip("クリティカル演出で発生するフラッシュ効果の表示時間")]
    public float CriticalHit_FlashDuration;
    [Token(Token = "0x4003464")]
    [FieldOffset(Offset = "0xC0")]
    [Tooltip("クリティカル演出で発生するカメラシェイクの時間")]
    public float CriticalHit_ShakeDuration;
    [Token(Token = "0x4003465")]
    [FieldOffset(Offset = "0xC4")]
    [Tooltip("クリティカル演出で発生するカメラシェイクの横揺れ回数")]
    public float CriticalHit_ShakeFrequencyX;
    [Token(Token = "0x4003466")]
    [FieldOffset(Offset = "0xC8")]
    [Tooltip("クリティカル演出で発生するカメラシェイクの縦揺れ回数")]
    public float CriticalHit_ShakeFrequencyY;
    [Token(Token = "0x4003467")]
    [FieldOffset(Offset = "0xCC")]
    [Tooltip("クリティカル演出で発生するカメラシェイクの横揺れの強さ")]
    public float CriticalHit_ShakeAmplitudeX;
    [Token(Token = "0x4003468")]
    [FieldOffset(Offset = "0xD0")]
    [Tooltip("クリティカル演出で発生するカメラシェイクの縦揺れの強さ")]
    public float CriticalHit_ShakeAmplitudeY;
    [Token(Token = "0x4003469")]
    [FieldOffset(Offset = "0xD4")]
    [Tooltip("ブルームのぼかし強度")]
    public float PostEffect_BloomBlurStrength;
    [Token(Token = "0x400346A")]
    [FieldOffset(Offset = "0xD8")]
    [Tooltip("ブルームの最大強度")]
    public float PostEffect_BloomMaxStrength;
    [Token(Token = "0x400346B")]
    [FieldOffset(Offset = "0xDC")]
    [Tooltip("デモシーンのオートプレイ秒数")]
    public float Message_AutoForwardSec;
    [Token(Token = "0x400346C")]
    [FieldOffset(Offset = "0xE0")]
    public Color Character_DefaultDirectLitColor;
    [Token(Token = "0x400346D")]
    [FieldOffset(Offset = "0xF0")]
    public Color Character_DefaultIndirectLitColor;
    [Token(Token = "0x400346E")]
    [FieldOffset(Offset = "0x100")]
    public Color32 Character_PlayerGlowColor;
    [Token(Token = "0x400346F")]
    [FieldOffset(Offset = "0x104")]
    public Color32 Character_EnemyGlowColor;
    [Token(Token = "0x4003470")]
    [FieldOffset(Offset = "0x108")]
    public Sprite[] Elements_IconSmall;
    [Token(Token = "0x4003471")]
    [FieldOffset(Offset = "0x10C")]
    public GameSettings.ElementIcon[] Elements_Icon;
    [Token(Token = "0x4003472")]
    [FieldOffset(Offset = "0x110")]
    public GameSettings.UnitSortIcon[] UnitSort_Modes;
    [Token(Token = "0x4003473")]
    [FieldOffset(Offset = "0x114")]
    public Sprite[] UnitIcon_Frames;
    [Token(Token = "0x4003474")]
    [FieldOffset(Offset = "0x118")]
    public Sprite[] UnitIcon_Rarity;
    [Token(Token = "0x4003475")]
    [FieldOffset(Offset = "0x11C")]
    public Sprite ArtifactIcon_Weapon;
    [Token(Token = "0x4003476")]
    [FieldOffset(Offset = "0x120")]
    public Sprite ArtifactIcon_Armor;
    [Token(Token = "0x4003477")]
    [FieldOffset(Offset = "0x124")]
    public Sprite ArtifactIcon_Misc;
    [Token(Token = "0x4003478")]
    [FieldOffset(Offset = "0x128")]
    public Sprite[] ArtifactIcon_Frames;
    [Token(Token = "0x4003479")]
    [FieldOffset(Offset = "0x12C")]
    public Sprite[] ArtifactIcon_InspSkillFrames;
    [Token(Token = "0x400347A")]
    [FieldOffset(Offset = "0x130")]
    public Sprite[] ArtifactIcon_StoneEffectFrames;
    [Token(Token = "0x400347B")]
    [FieldOffset(Offset = "0x134")]
    public Sprite[] ArtifactIcon_Rarity;
    [Token(Token = "0x400347C")]
    [FieldOffset(Offset = "0x138")]
    public Sprite[] ArtifactIcon_RarityBG;
    [Token(Token = "0x400347D")]
    [FieldOffset(Offset = "0x13C")]
    public Sprite[] ConceptCardIcon_Frames;
    [Token(Token = "0x400347E")]
    [FieldOffset(Offset = "0x140")]
    public Sprite[] ConceptCardIcon_Rarity;
    [Token(Token = "0x400347F")]
    [FieldOffset(Offset = "0x144")]
    public Sprite[] ConceptCardIcon_ExtraFrames;
    [Token(Token = "0x4003480")]
    [FieldOffset(Offset = "0x148")]
    public Sprite[] ConceptCardIcon_ExtraRarity;
    [Token(Token = "0x4003481")]
    [FieldOffset(Offset = "0x14C")]
    [StringIsResourcePath(typeof (GameObject))]
    public string ConceptCard_GetUnit;
    [Token(Token = "0x4003482")]
    [FieldOffset(Offset = "0x150")]
    public Sprite[] CrystalIcon_Rarity;
    [Token(Token = "0x4003483")]
    [FieldOffset(Offset = "0x154")]
    public Sprite[] RuneIcon_DedicatedFrames;
    [Token(Token = "0x4003484")]
    [FieldOffset(Offset = "0x158")]
    public Color32 Gauge_HP_Base;
    [Token(Token = "0x4003485")]
    [FieldOffset(Offset = "0x15C")]
    public Color32 Gauge_HP_Damage;
    [Token(Token = "0x4003486")]
    [FieldOffset(Offset = "0x160")]
    public Color32 Gauge_HP_Heal;
    [Token(Token = "0x4003487")]
    [FieldOffset(Offset = "0x164")]
    public Color32 Gauge_PlayerHP_Base;
    [Token(Token = "0x4003488")]
    [FieldOffset(Offset = "0x168")]
    public Color32 Gauge_PlayerHP_Damage;
    [Token(Token = "0x4003489")]
    [FieldOffset(Offset = "0x16C")]
    public Color32 Gauge_PlayerHP_Heal;
    [Token(Token = "0x400348A")]
    [FieldOffset(Offset = "0x170")]
    public Color32 Gauge_EnemyHP_Base;
    [Token(Token = "0x400348B")]
    [FieldOffset(Offset = "0x174")]
    public Color32 Gauge_EnemyHP_Damage;
    [Token(Token = "0x400348C")]
    [FieldOffset(Offset = "0x178")]
    public Color32 Gauge_EnemyHP_Heal;
    [Token(Token = "0x400348D")]
    [FieldOffset(Offset = "0x17C")]
    public GameObject Dialog_BuyCoin;
    [Token(Token = "0x400348E")]
    [FieldOffset(Offset = "0x180")]
    [StringIsResourcePath(typeof (GameObject))]
    public string Dialog_AbilityDetail;
    [Token(Token = "0x400348F")]
    [FieldOffset(Offset = "0x184")]
    public string CharacterQuest_Unlock;
    [Token(Token = "0x4003490")]
    [FieldOffset(Offset = "0x188")]
    public Canvas Canvas2D;
    [Token(Token = "0x4003491")]
    [FieldOffset(Offset = "0x18C")]
    public Transform EnemyPosRig;
    [Token(Token = "0x4003492")]
    [FieldOffset(Offset = "0x190")]
    public Transform CameraPosRig;
    [Token(Token = "0x4003493")]
    [FieldOffset(Offset = "0x194")]
    public GameSettings.DialogSettings Dialogs;
    [Token(Token = "0x4003494")]
    [FieldOffset(Offset = "0x1BC")]
    public GameSettings.CameraSettings Cameras;
    [Token(Token = "0x4003495")]
    [FieldOffset(Offset = "0x1C0")]
    public GameSettings.ColorSettings Colors;
    [Token(Token = "0x4003496")]
    [FieldOffset(Offset = "0x280")]
    public GameSettings.QuestSettings Quest;
    [Token(Token = "0x4003497")]
    [FieldOffset(Offset = "0x348")]
    public GameSettings.ItemIconSettings ItemIcons;
    [Token(Token = "0x4003498")]
    [FieldOffset(Offset = "0x358")]
    public Sprite[] ItemPriceIconFrames;
    [Token(Token = "0x4003499")]
    [FieldOffset(Offset = "0x35C")]
    public char[] ValidInputChars;
    [Token(Token = "0x400349A")]
    [FieldOffset(Offset = "0x360")]
    public float QuestLoad_WaitSecond;
    [Token(Token = "0x400349B")]
    [FieldOffset(Offset = "0x364")]
    public string QuestLoad_OkyakusamaCode;
    [Token(Token = "0x400349C")]
    [FieldOffset(Offset = "0x368")]
    [SerializeField]
    [Range(1f, 100f)]
    public int HoldMargin;
    [Token(Token = "0x400349D")]
    [FieldOffset(Offset = "0x36C")]
    public GameSettings.HoldCountSettings[] HoldCount;
    [Token(Token = "0x400349E")]
    [FieldOffset(Offset = "0x370")]
    [StringIsResourcePath(typeof (GameObject))]
    public string UnitGet_EffectTemplate;
    [Token(Token = "0x400349F")]
    [FieldOffset(Offset = "0x374")]
    public string CharacterQuestSection;
    [Token(Token = "0x40034A0")]
    [FieldOffset(Offset = "0x378")]
    public FlowNode_WebView.URL_Mode WebHelp_URLMode;
    [Token(Token = "0x40034A1")]
    [FieldOffset(Offset = "0x37C")]
    [StringIsResourcePath(typeof (GameObject))]
    public string WebHelp_PrefabPath;
    [Token(Token = "0x40034A2")]
    [FieldOffset(Offset = "0x380")]
    [Description("バトルリザルト背景のプレハブ名")]
    [StringIsResourcePath(typeof (GameObject))]
    public string BattleResultBg_ResourcePath;
    [Token(Token = "0x40034A3")]
    [FieldOffset(Offset = "0x384")]
    [Description("バトルリザルト背景に現在のバトルBGを設定する")]
    public bool BattleResultBg_UseBattleBG;
    [Token(Token = "0x40034A4")]
    [FieldOffset(Offset = "0x388")]
    [Description("バトルリザルト背景の表示待ち時間")]
    public float BattleResultBg_WaitTime;
    [Token(Token = "0x40034A5")]
    [FieldOffset(Offset = "0x38C")]
    [Description("バトルの前のダウンロード確認ポップアップのタイムアウト時間")]
    public float ForApple_DownloadPopupTimeoutSec;
    [Token(Token = "0x40034A6")]
    [FieldOffset(Offset = "0x390")]
    [Description("Trophyにbuyatshopを指定した際のsvalに指定するショップIDをEShopTypeへの変換用")]
    public string[] Shop_ShopIdToShopTypeConvTbl;

    [Token(Token = "0x1700055C")]
    public static GameSettings Instance
    {
      [Token(Token = "0x600400E"), Address(RVA = "0x118E9A0", Offset = "0x118D7A0", VA = "0x1118E9A0")] get
      {
        return (GameSettings) null;
      }
    }

    [Token(Token = "0x600400F")]
    [Address(RVA = "0x118DD10", Offset = "0x118CB10", VA = "0x1118DD10")]
    public static void Reset()
    {
    }

    [Token(Token = "0x6004010")]
    [Address(RVA = "0x118D890", Offset = "0x118C690", VA = "0x1118D890")]
    public Sprite GetElementIcon(EElement element, int plus = 0) => (Sprite) null;

    [Token(Token = "0x6004011")]
    [Address(RVA = "0x118DCB0", Offset = "0x118CAB0", VA = "0x1118DCB0")]
    public Sprite GetUnitSortModeIcon(GameUtility.UnitSortModes mode) => (Sprite) null;

    [Token(Token = "0x6004012")]
    [Address(RVA = "0x118D520", Offset = "0x118C320", VA = "0x1118D520")]
    public Sprite GetArtifactIcon(int rarity, bool is_stone_opne, bool is_inspration)
    {
      return (Sprite) null;
    }

    [Token(Token = "0x6004013")]
    [Address(RVA = "0x118DA90", Offset = "0x118C890", VA = "0x1118DA90")]
    public Sprite GetItemFrame(EItemType type, int rare) => (Sprite) null;

    [Token(Token = "0x6004014")]
    [Address(RVA = "0x118DA20", Offset = "0x118C820", VA = "0x1118DA20")]
    public Sprite GetItemFrame(ItemParam itemParam) => (Sprite) null;

    [Token(Token = "0x6004015")]
    [Address(RVA = "0x118D5C0", Offset = "0x118C3C0", VA = "0x1118D5C0")]
    public Sprite GetConceptCardFrame(ConceptCardParam param) => (Sprite) null;

    [Token(Token = "0x6004016")]
    [Address(RVA = "0x118D670", Offset = "0x118C470", VA = "0x1118D670")]
    public Sprite GetConceptCardFrame(int rarity) => (Sprite) null;

    [Token(Token = "0x6004017")]
    [Address(RVA = "0x118D580", Offset = "0x118C380", VA = "0x1118D580")]
    public Sprite GetConceptCardFrameExtra(int rarity) => (Sprite) null;

    [Token(Token = "0x6004018")]
    [Address(RVA = "0x118D740", Offset = "0x118C540", VA = "0x1118D740")]
    public Sprite GetConceptCardFrame(int rarity, bool is_extra = false) => (Sprite) null;

    [Token(Token = "0x6004019")]
    [Address(RVA = "0x118D7E0", Offset = "0x118C5E0", VA = "0x1118D7E0")]
    public Sprite GetConceptCardRarity(int rarity, bool is_extra = false) => (Sprite) null;

    [Token(Token = "0x600401A")]
    [Address(RVA = "0x118D850", Offset = "0x118C650", VA = "0x1118D850")]
    public Sprite GetConceptCardRarity(int rarity) => (Sprite) null;

    [Token(Token = "0x600401B")]
    [Address(RVA = "0x118D7A0", Offset = "0x118C5A0", VA = "0x1118D7A0")]
    public Sprite GetConceptCardRarityExtra(int rarity) => (Sprite) null;

    [Token(Token = "0x600401C")]
    [Address(RVA = "0x118D490", Offset = "0x118C290", VA = "0x1118D490")]
    public long CreateTutorialFlagMask(string flagName) => new long();

    [Token(Token = "0x600401D")]
    [Address(RVA = "0x118DBE0", Offset = "0x118C9E0", VA = "0x1118DBE0")]
    public Sprite GetRuneFrame(int rarity, bool is_dedicated = false) => (Sprite) null;

    [Token(Token = "0x600401E")]
    [Address(RVA = "0x118DB70", Offset = "0x118C970", VA = "0x1118DB70")]
    public Sprite GetRuneDefaultFrame(int rarity) => (Sprite) null;

    [Token(Token = "0x600401F")]
    [Address(RVA = "0x118DB00", Offset = "0x118C900", VA = "0x1118DB00")]
    public Sprite GetRuneDedicatedFrame(int rarity) => (Sprite) null;

    [Token(Token = "0x6004020")]
    [Address(RVA = "0x118DD50", Offset = "0x118CB50", VA = "0x1118DD50")]
    public GameSettings()
    {
    }

    [Token(Token = "0x2000F5E")]
    [Serializable]
    public struct ElementIcon
    {
      [Token(Token = "0x40034A7")]
      [FieldOffset(Offset = "0x0")]
      public EElement Element;
      [Token(Token = "0x40034A8")]
      [FieldOffset(Offset = "0x4")]
      public int Plus;
      [Token(Token = "0x40034A9")]
      [FieldOffset(Offset = "0x8")]
      public Sprite Icon;
    }

    [Token(Token = "0x2000F5F")]
    [Serializable]
    public struct UnitSortIcon
    {
      [Token(Token = "0x40034AA")]
      [FieldOffset(Offset = "0x0")]
      public GameUtility.UnitSortModes Mode;
      [Token(Token = "0x40034AB")]
      [FieldOffset(Offset = "0x4")]
      public Sprite Icon;
    }

    [Token(Token = "0x2000F60")]
    [Serializable]
    public struct DialogSettings
    {
      [Token(Token = "0x40034AC")]
      [FieldOffset(Offset = "0x0")]
      public Win_Btn_DecideCancel_FL_Check_C YesNoDialogWithCheckBox;
      [Token(Token = "0x40034AD")]
      [FieldOffset(Offset = "0x4")]
      public Win_Btn_DecideCancel_FL_C YesNoDialog;
      [Token(Token = "0x40034AE")]
      [FieldOffset(Offset = "0x8")]
      public Win_Btn_Decide_Title_Flx YesDialogWithTitle;
      [Token(Token = "0x40034AF")]
      [FieldOffset(Offset = "0xC")]
      public Win_Btn_YN_Title_Flx YesNoDialogWithTitle;
      [Token(Token = "0x40034B0")]
      [FieldOffset(Offset = "0x10")]
      public Win_Btn_Decide_Flx YesDialog;
      [Token(Token = "0x40034B1")]
      [FieldOffset(Offset = "0x14")]
      public Win_SysMessage_Flx SysMsgDialog;
      [Token(Token = "0x40034B2")]
      [FieldOffset(Offset = "0x18")]
      public Win_Btn_YN_Title_Flx_Delay YesNoDialogWithDelay;
      [Token(Token = "0x40034B3")]
      [FieldOffset(Offset = "0x1C")]
      public Win_Btn_YN_Title_Flx YesNoDialogWithTitleScroll;
      [Token(Token = "0x40034B4")]
      [FieldOffset(Offset = "0x20")]
      public Win_Btn_YN_Title_Flx YesNoDialogWithTitleScrollReverse;
      [Token(Token = "0x40034B5")]
      [FieldOffset(Offset = "0x24")]
      public Win_Btn_YN_Title_Flx_Check YesNoDialogWithTitleCheck;
    }

    [Token(Token = "0x2000F61")]
    [Serializable]
    public struct CameraSettings
    {
      [Token(Token = "0x40034B6")]
      [FieldOffset(Offset = "0x0")]
      public UnityEngine.Camera OverlayCamera;
    }

    [Token(Token = "0x2000F62")]
    [Serializable]
    public struct ColorSettings
    {
      [Token(Token = "0x40034B7")]
      [FieldOffset(Offset = "0x0")]
      public Color Enemy;
      [Token(Token = "0x40034B8")]
      [FieldOffset(Offset = "0x10")]
      public Color Player;
      [Token(Token = "0x40034B9")]
      [FieldOffset(Offset = "0x20")]
      public Color Helper;
      [Token(Token = "0x40034BA")]
      [FieldOffset(Offset = "0x30")]
      public Color DamageDigits;
      [Token(Token = "0x40034BB")]
      [FieldOffset(Offset = "0x40")]
      public Color HealDigits;
      [Token(Token = "0x40034BC")]
      [FieldOffset(Offset = "0x50")]
      public Color CriticalDigits;
      [Token(Token = "0x40034BD")]
      [FieldOffset(Offset = "0x60")]
      public Color WalkableArea;
      [Token(Token = "0x40034BE")]
      [FieldOffset(Offset = "0x70")]
      public Color StartGrid;
      [Token(Token = "0x40034BF")]
      [FieldOffset(Offset = "0x80")]
      public Color AttackArea;
      [Token(Token = "0x40034C0")]
      [FieldOffset(Offset = "0x90")]
      public Color AttackArea2;
      [Token(Token = "0x40034C1")]
      [FieldOffset(Offset = "0xA0")]
      public Color ChargeAreaGrn;
      [Token(Token = "0x40034C2")]
      [FieldOffset(Offset = "0xB0")]
      public Color ChargeAreaRed;
    }

    [Token(Token = "0x2000F63")]
    [Serializable]
    public struct QuestSettings
    {
      [Token(Token = "0x40034C3")]
      [FieldOffset(Offset = "0x0")]
      public Transform TacticsCamera;
      [Token(Token = "0x40034C4")]
      [FieldOffset(Offset = "0x4")]
      public Transform MoveCamera;
      [Token(Token = "0x40034C5")]
      [FieldOffset(Offset = "0x8")]
      public Transform UnitCamera;
      [Token(Token = "0x40034C6")]
      [FieldOffset(Offset = "0xC")]
      public Transform BattleCamera;
      [Token(Token = "0x40034C7")]
      [FieldOffset(Offset = "0x10")]
      public Transform RunCamera;
      [Token(Token = "0x40034C8")]
      [FieldOffset(Offset = "0x14")]
      public AnimationCurve RunCameraInterpRate;
      [Token(Token = "0x40034C9")]
      [FieldOffset(Offset = "0x18")]
      public float BattleRunSpeed;
      [Token(Token = "0x40034CA")]
      [FieldOffset(Offset = "0x1C")]
      public float MapRunSpeedMin;
      [Token(Token = "0x40034CB")]
      [FieldOffset(Offset = "0x20")]
      public float MapRunSpeedMax;
      [Token(Token = "0x40034CC")]
      [FieldOffset(Offset = "0x24")]
      public float MapCharacterScale;
      [Token(Token = "0x40034CD")]
      [FieldOffset(Offset = "0x28")]
      public float AnimateGridSnapRadius;
      [Token(Token = "0x40034CE")]
      [FieldOffset(Offset = "0x2C")]
      public float GridSnapDelay;
      [Token(Token = "0x40034CF")]
      [FieldOffset(Offset = "0x30")]
      public float GridSnapSpeed;
      [Token(Token = "0x40034D0")]
      [FieldOffset(Offset = "0x34")]
      public float MapTransitionSpeed;
      [Token(Token = "0x40034D1")]
      [FieldOffset(Offset = "0x38")]
      public float DoorEnterTime;
      [Token(Token = "0x40034D2")]
      [FieldOffset(Offset = "0x3C")]
      public float TreasureTime;
      [Token(Token = "0x40034D3")]
      [FieldOffset(Offset = "0x40")]
      public float ViewingUnitSnapSpeed;
      [Token(Token = "0x40034D4")]
      [FieldOffset(Offset = "0x44")]
      public float BattleTurnEndWait;
      [Token(Token = "0x40034D5")]
      [FieldOffset(Offset = "0x48")]
      public float RenkeiEndWait;
      [Token(Token = "0x40034D6")]
      [FieldOffset(Offset = "0x4C")]
      public float WaitAfterUnitPickupGimmick;
      [Token(Token = "0x40034D7")]
      [FieldOffset(Offset = "0x50")]
      [Description("きりもみ状態での毎秒の回転角度")]
      public float KirimomiRotationRate;
      [Token(Token = "0x40034D8")]
      [FieldOffset(Offset = "0x54")]
      [Description("ユニット交代時のエフェクト待ち時間")]
      public float UnitChangeEffectWaitTime;
      [Token(Token = "0x40034D9")]
      [FieldOffset(Offset = "0x58")]
      [Description("オートプレイ時のイベントステップ待ち時間")]
      public float WaitTimeScriptEventForward;
      [Token(Token = "0x40034DA")]
      [FieldOffset(Offset = "0x5C")]
      [Description("ユニット撤退時のエフェクト待ち時間")]
      public float WithdrawUnitEffectWaitTime;
      [Token(Token = "0x40034DB")]
      [FieldOffset(Offset = "0x60")]
      [Description("壊れるオブジェクトの設置最大許容数")]
      public int BreakObjAllowEntryMax;
      [Token(Token = "0x40034DC")]
      [FieldOffset(Offset = "0x64")]
      [Description("天候エフェクトの切り替え時間")]
      public float WeatherEffectChangeTime;
      [Token(Token = "0x40034DD")]
      [FieldOffset(Offset = "0x68")]
      [Description("特殊パネルの演出最大待ち時間")]
      public float TrickEffectWaitMaxTime;
      [Token(Token = "0x40034DE")]
      [FieldOffset(Offset = "0x6C")]
      [Description("ひらめきエフェクト待ち時間")]
      public float InspirationEffectWaitTime;
      [Token(Token = "0x40034DF")]
      [FieldOffset(Offset = "0x70")]
      [Description("ひらめきテロップ表示時間")]
      public float InspirationTelopDispTime;
      [Token(Token = "0x40034E0")]
      [FieldOffset(Offset = "0x74")]
      [Description("ひらめきテロップ再生速度")]
      public float InspirationTelopDispSpeed;
      [Token(Token = "0x40034E1")]
      [FieldOffset(Offset = "0x78")]
      [Description("ひらめきテロップ待ち時間")]
      public float InspirationTelopWaitTime;
      [Token(Token = "0x40034E2")]
      [FieldOffset(Offset = "0x7C")]
      [Description("飛行ユニットが敵を乗り越える時の高さ")]
      public float RidingFlyingHeight;
      [Token(Token = "0x40034E3")]
      [FieldOffset(Offset = "0x80")]
      [Description("かばうエフェクト待ち時間")]
      public float ProtectEffectWaitTime;
      [Token(Token = "0x40034E4")]
      [FieldOffset(Offset = "0x84")]
      [Description("連撃ダメージ表示：加算Y座標")]
      public float DamageDispPosAddY;
      [Token(Token = "0x40034E5")]
      [FieldOffset(Offset = "0x88")]
      [Description("連撃ダメージ表示：ループ値")]
      public int DamageDispLoopCount;
      [Token(Token = "0x40034E6")]
      [FieldOffset(Offset = "0x8C")]
      [Description("連続回復ポップアップの発生間隔")]
      public float HealPopupDeley;
      [Token(Token = "0x40034E7")]
      [FieldOffset(Offset = "0x90")]
      [Description("連続回復表示：加算Y座標")]
      public float HealDispPosAddY;
      [Token(Token = "0x40034E8")]
      [FieldOffset(Offset = "0x94")]
      [Description("連続回復表示：ループ値")]
      public int HealDispLoopCount;
      [Token(Token = "0x40034E9")]
      [FieldOffset(Offset = "0x98")]
      [Description("スキルON/OFF設定を無視するクエストタイプ群")]
      public QuestTypes[] InvalidSkillIgnoreQuestTypes;
      [Token(Token = "0x40034EA")]
      [FieldOffset(Offset = "0x9C")]
      [Description("爆弾ダメージ時のエフェクト待ち時間")]
      public float CondBombEffectWaitTime;
      [Token(Token = "0x40034EB")]
      [FieldOffset(Offset = "0xA0")]
      [Description("爆弾ダメージ時のダメージ表示待ち時間")]
      public float CondBombDamageWaitTime;
      [Token(Token = "0x40034EC")]
      [FieldOffset(Offset = "0xA4")]
      [Description("スリップダメージ時のエフェクト待ち時間")]
      public float CondSlipEffectWaitTime;
      [Token(Token = "0x40034ED")]
      [FieldOffset(Offset = "0xA8")]
      [Description("スリップダメージ時のダメージ表示待ち時間")]
      public float CondSlipDamageWaitTime;
      [Token(Token = "0x40034EE")]
      [FieldOffset(Offset = "0xAC")]
      [Description("凝固ダメージ時のエフェクト待ち時間")]
      public float CondFreezeEffectWaitTime;
      [Token(Token = "0x40034EF")]
      [FieldOffset(Offset = "0xB0")]
      [Description("凝固ダメージ時のダメージ表示待ち時間")]
      public float CondFreezeDamageWaitTime;
      [Token(Token = "0x40034F0")]
      [FieldOffset(Offset = "0xB4")]
      [Description("固有モーション用の共通アニメーション名")]
      public string UseCommonAnimName;
      [Token(Token = "0x40034F1")]
      [FieldOffset(Offset = "0xB8")]
      [Description("固有モーション用の追撃用共通アニメーション名")]
      public string UseCommonAdditionalAnimName;
      [Token(Token = "0x40034F2")]
      [FieldOffset(Offset = "0xBC")]
      [Description("バフデバフエフェクトを格納しているフォルダ")]
      public string BuffEffectDirectory;
      [Token(Token = "0x40034F3")]
      [FieldOffset(Offset = "0xC0")]
      [Description("巨大ユニット用のバフデバフエフェクト")]
      public string BuffEffectNameForBigUnit;
      [Token(Token = "0x40034F4")]
      [FieldOffset(Offset = "0xC4")]
      public GameSettings.SkillWaitTimer[] EffectWaitTime;
    }

    [Token(Token = "0x2000F64")]
    [Serializable]
    public struct SkillWaitTimer
    {
      [Token(Token = "0x40034F5")]
      [FieldOffset(Offset = "0x0")]
      public GameSettings.SkillEffectTimerList type;
      [Token(Token = "0x40034F6")]
      [FieldOffset(Offset = "0x4")]
      public float effect_time;
      [Token(Token = "0x40034F7")]
      [FieldOffset(Offset = "0x8")]
      public float damage_time;
    }

    [Token(Token = "0x2000F65")]
    public enum SkillEffectTimerList
    {
      [Token(Token = "0x40034F9")] REFLECTION,
      [Token(Token = "0x40034FA")] ABSORPTION,
      [Token(Token = "0x40034FB")] MANIPULATEBREAK,
      [Token(Token = "0x40034FC")] REFLECTIONDAMAGE,
      [Token(Token = "0x40034FD")] MANIPULATEPIERCEBREAK,
      [Token(Token = "0x40034FE")] DOWN,
      [Token(Token = "0x40034FF")] MAX,
    }

    [Token(Token = "0x2000F66")]
    [Serializable]
    public struct ItemIconSettings
    {
      [Token(Token = "0x4003500")]
      [FieldOffset(Offset = "0x0")]
      public Sprite[] NormalFrames;
      [Token(Token = "0x4003501")]
      [FieldOffset(Offset = "0x4")]
      public Sprite[] KakeraFrames;
      [Token(Token = "0x4003502")]
      [FieldOffset(Offset = "0x8")]
      public Sprite[] ArtifactKakeraFrames;
      [Token(Token = "0x4003503")]
      [FieldOffset(Offset = "0xC")]
      public GameObject LimitedIcon;
    }

    [Token(Token = "0x2000F67")]
    [Serializable]
    public struct HoldCountSettings
    {
      [Token(Token = "0x4003504")]
      [FieldOffset(Offset = "0x0")]
      public int Count;
      [Token(Token = "0x4003505")]
      [FieldOffset(Offset = "0x4")]
      public float UseSpan;
    }
  }
}
