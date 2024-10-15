// Decompiled with JetBrains decompiler
// Type: SRPG.UnitEnhanceV3
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG.Exhibit;
using SRPG.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002BD5")]
  [FlowNode.Pin(1200, "覚醒+ Tips表示", FlowNode.PinTypes.Output, 1200)]
  [FlowNode.Pin(10000, "【タブ】装備、ジョブ", FlowNode.PinTypes.Input, 10000)]
  [FlowNode.Pin(10002, "【タブ】アビリティ", FlowNode.PinTypes.Input, 10002)]
  [FlowNode.Pin(10001, "【タブ】強化（林檎）", FlowNode.PinTypes.Input, 10001)]
  [FlowNode.Pin(10003, "【タブ】専用装備品", FlowNode.PinTypes.Input, 10003)]
  [FlowNode.Pin(10006, "【タブ】スキン選択", FlowNode.PinTypes.Input, 10006)]
  [FlowNode.Pin(10005, "【タブ】スキルOn/Off", FlowNode.PinTypes.Input, 10005)]
  [FlowNode.Pin(1104, "真理開眼解放 演出終了", FlowNode.PinTypes.Output, 1104)]
  [FlowNode.Pin(10100, "【タブ】装備、ジョブ", FlowNode.PinTypes.Output, 10100)]
  [FlowNode.Pin(10101, "【タブ】強化（林檎）", FlowNode.PinTypes.Output, 10101)]
  [FlowNode.Pin(10102, "【タブ】アビリティ", FlowNode.PinTypes.Output, 10102)]
  [FlowNode.Pin(10103, "【タブ】専用装備品", FlowNode.PinTypes.Output, 10103)]
  [FlowNode.Pin(10104, "【タブ】プロフィール", FlowNode.PinTypes.Output, 10104)]
  [FlowNode.Pin(10105, "【タブ】スキルOn/Off", FlowNode.PinTypes.Output, 10105)]
  [FlowNode.Pin(10106, "【タブ】スキン選択", FlowNode.PinTypes.Output, 10106)]
  [AddComponentMenu("UI/UnitEnhanceV3")]
  [FlowNode.Pin(10004, "【タブ】プロフィール", FlowNode.PinTypes.Input, 10004)]
  [FlowNode.Pin(1103, "ユニットLVUP 演出終了", FlowNode.PinTypes.Output, 1103)]
  [FlowNode.Pin(202, "StopPlayLeftVoice On", FlowNode.PinTypes.Input, 202)]
  [FlowNode.Pin(1101, "真理開眼強化 演出終了", FlowNode.PinTypes.Output, 1101)]
  [FlowNode.Pin(204, "スワイプで前のユニット切り替え", FlowNode.PinTypes.Input, 204)]
  [FlowNode.Pin(205, "スワイプで次のユニット切り替え", FlowNode.PinTypes.Input, 205)]
  [FlowNode.Pin(210, "UnitVoiceOff Output", FlowNode.PinTypes.Output, 210)]
  [FlowNode.Pin(301, "真理開眼開放", FlowNode.PinTypes.Input, 301)]
  [FlowNode.Pin(302, "真理開眼遷移チェック", FlowNode.PinTypes.Input, 302)]
  [FlowNode.Pin(303, "真理開眼画面へ", FlowNode.PinTypes.Output, 303)]
  [FlowNode.Pin(401, "ユニット詳細表示更新", FlowNode.PinTypes.Input, 401)]
  [FlowNode.Pin(200, "UnitVoiceOff", FlowNode.PinTypes.Input, 200)]
  [FlowNode.Pin(1102, "真理開眼MAX 演出終了", FlowNode.PinTypes.Output, 1102)]
  [FlowNode.Pin(110, "ViewerMode ON", FlowNode.PinTypes.Input, 110)]
  [FlowNode.Pin(100, "閉じる", FlowNode.PinTypes.Input, 100)]
  [FlowNode.Pin(10, "異なるユニットを表示", FlowNode.PinTypes.Output, 10)]
  [FlowNode.Pin(1, "初期化完了", FlowNode.PinTypes.Output, 1)]
  [FlowNode.Pin(550, "リーダースキル表示更新", FlowNode.PinTypes.Input, 550)]
  [FlowNode.Pin(500, "TIPS表示", FlowNode.PinTypes.Output, 500)]
  [FlowNode.Pin(111, "ViewerMode OFF", FlowNode.PinTypes.Input, 111)]
  [FlowNode.Pin(800, "武具装備更新", FlowNode.PinTypes.Input, 800)]
  [FlowNode.Pin(1100, "専用装備品 演出終了", FlowNode.PinTypes.Output, 1100)]
  [FlowNode.Pin(1013, "共鳴Tips表示", FlowNode.PinTypes.Output, 1013)]
  [FlowNode.Pin(1012, "共鳴解除通信", FlowNode.PinTypes.Output, 1012)]
  [FlowNode.Pin(1011, "共鳴ユニット選択画面", FlowNode.PinTypes.Output, 1011)]
  [FlowNode.Pin(1015, "共鳴解除演出再生", FlowNode.PinTypes.Input, 1015)]
  [FlowNode.Pin(1014, "共鳴演出再生", FlowNode.PinTypes.Input, 1014)]
  [FlowNode.Pin(700, "Go to Home", FlowNode.PinTypes.Output, 700)]
  [FlowNode.Pin(1010, "共鳴クリック", FlowNode.PinTypes.Input, 1010)]
  [FlowNode.Pin(203, "StopPlayLeftVoice OFF", FlowNode.PinTypes.Input, 203)]
  [FlowNode.Pin(810, "真理念装装備更新", FlowNode.PinTypes.Input, 810)]
  [FlowNode.Pin(820, "水晶装備更新", FlowNode.PinTypes.Input, 820)]
  [FlowNode.Pin(900, "ルーン開放", FlowNode.PinTypes.Input, 900)]
  [FlowNode.Pin(901, "ルーン遷移チェック", FlowNode.PinTypes.Input, 901)]
  [FlowNode.Pin(902, "ルーン画面へ", FlowNode.PinTypes.Output, 902)]
  [FlowNode.Pin(1001, "スキルOn/Off設定へ", FlowNode.PinTypes.Output, 1001)]
  [FlowNode.Pin(1000, "スキルOn/Offボタン入力", FlowNode.PinTypes.Input, 1000)]
  public class UnitEnhanceV3 : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400D753")]
    public const int PIN_OUT_COMPLETE_INITIALIZE = 1;
    [Token(Token = "0x400D754")]
    public const int PIN_OUT_REFRESH_UNIT_CHANGED = 10;
    [Token(Token = "0x400D755")]
    public const int PIN_IN_CLOSE_UNIT_DETAIL = 100;
    [Token(Token = "0x400D756")]
    public const int PIN_IN_UNIT_VIEWER_ON = 110;
    [Token(Token = "0x400D757")]
    public const int PIN_IN_UNIT_VIEWER_OFF = 111;
    [Token(Token = "0x400D758")]
    public const int PIN_IN_UNIT_VOICE_OFF = 200;
    [Token(Token = "0x400D759")]
    public const int PIN_IN_STOP_LEFT_VOICE_ON = 202;
    [Token(Token = "0x400D75A")]
    public const int PIN_IN_STOP_LEFT_VOICE_OFF = 203;
    [Token(Token = "0x400D75B")]
    public const int PIN_IN_UNIT_SWIPE_LEFT = 204;
    [Token(Token = "0x400D75C")]
    public const int PIN_IN_UNIT_SWIPE_RIGHT = 205;
    [Token(Token = "0x400D75D")]
    public const int PIN_OUT_UNIT_VOICE_DISABLED = 210;
    [Token(Token = "0x400D75E")]
    public const int PIN_IN_UNLOCK_TOBIRA = 301;
    [Token(Token = "0x400D75F")]
    public const int PIN_IN_CHECK_TOBIRA = 302;
    [Token(Token = "0x400D760")]
    public const int PIN_OUT_GO_TO_TOBIRA = 303;
    [Token(Token = "0x400D761")]
    public const int PIN_IN_REFRESH_UNIT_DETAIL = 401;
    [Token(Token = "0x400D762")]
    public const int PIN_OUT_SHOW_TOBIRA_TIPS = 500;
    [Token(Token = "0x400D763")]
    public const int PIN_IN_REFRESH_LEADER_SKILL = 550;
    [Token(Token = "0x400D764")]
    public const int PIN_OUT_GO_TO_HOME = 700;
    [Token(Token = "0x400D765")]
    public const int PIN_IN_REFRESH_ARTIFACT_EQUIP = 800;
    [Token(Token = "0x400D766")]
    public const int PIN_IN_REFRESH_CONCEPTCARD_EQUIP = 810;
    [Token(Token = "0x400D767")]
    public const int PIN_IN_REFRESH_CRYSTAL_EQUIP = 820;
    [Token(Token = "0x400D768")]
    public const int PIN_IN_UNLOCK_RUNE = 900;
    [Token(Token = "0x400D769")]
    public const int PIN_IN_CHECK_RUNE = 901;
    [Token(Token = "0x400D76A")]
    public const int PIN_OUT_GO_TO_RUNE = 902;
    [Token(Token = "0x400D76B")]
    public const int PIN_IN_INPUT_INVALID_SKILL = 1000;
    [Token(Token = "0x400D76C")]
    public const int PIN_OUT_GO_INVALID_SKILL = 1001;
    [Token(Token = "0x400D76D")]
    public const int PIN_IN_RESONANCE_ICON = 1010;
    [Token(Token = "0x400D76E")]
    public const int PIN_OUT_RESONANCE_UNIT_SELECT_WINDOW = 1011;
    [Token(Token = "0x400D76F")]
    public const int PIN_OUT_RESONANCE_RELEASE = 1012;
    [Token(Token = "0x400D770")]
    public const int PIN_OUT_RESONANCE_TIPS = 1013;
    [Token(Token = "0x400D771")]
    public const int PIN_IN_RESONANCE_EFFECT = 1014;
    [Token(Token = "0x400D772")]
    public const int PIN_IN_RESONANCE_RESET_EFFECT = 1015;
    [Token(Token = "0x400D773")]
    public const int PIN_OUT_TRUTH_EQUIPMENT_EFFECT_END = 1100;
    [Token(Token = "0x400D774")]
    public const int PIN_OUT_TOBIRA_ENHANCE_EFFECT_END = 1101;
    [Token(Token = "0x400D775")]
    public const int PIN_OUT_TOBIRA_MAX_EFFECT_END = 1102;
    [Token(Token = "0x400D776")]
    public const int PIN_OUT_UNIT_LVUP_EFFECT_END = 1103;
    [Token(Token = "0x400D777")]
    public const int PIN_OUT_TOBIRA_OPEN_EFFECT_END = 1104;
    [Token(Token = "0x400D778")]
    public const int PIN_OUT_STATUS_AWAKE_TIPS = 1200;
    [Token(Token = "0x400D779")]
    public const int PIN_IN_CHANGE_TAB_EQUIPMENT = 10000;
    [Token(Token = "0x400D77A")]
    public const int PIN_IN_CHANGE_TAB_ENHANCE = 10001;
    [Token(Token = "0x400D77B")]
    public const int PIN_IN_CHANGE_TAB_ABILITY_UP_AND_SET = 10002;
    [Token(Token = "0x400D77C")]
    public const int PIN_IN_CHANGE_TAB_TRUTH_EQUIPMENT = 10003;
    [Token(Token = "0x400D77D")]
    public const int PIN_IN_CHANGE_TAB_UNIT_PROFILE = 10004;
    [Token(Token = "0x400D77E")]
    public const int PIN_IN_CHANGE_TAB_INVALID_SKILL = 10005;
    [Token(Token = "0x400D77F")]
    public const int PIN_IN_CHANGE_TAB_SKIN_SELECT = 10006;
    [Token(Token = "0x400D780")]
    public const int PIN_OUT_CHANGE_TAB_EQUIPMENT = 10100;
    [Token(Token = "0x400D781")]
    public const int PIN_OUT_CHANGE_TAB_ENHANCE = 10101;
    [Token(Token = "0x400D782")]
    public const int PIN_OUT_CHANGE_TAB_ABILITY_UP_AND_SET = 10102;
    [Token(Token = "0x400D783")]
    public const int PIN_OUT_CHANGE_TAB_TRUTH_EQUIPMENT = 10103;
    [Token(Token = "0x400D784")]
    public const int PIN_OUT_CHANGE_TAB_UNIT_PROFILE = 10104;
    [Token(Token = "0x400D785")]
    public const int PIN_OUT_CHANGE_TAB_INVALID_SKILL = 10105;
    [Token(Token = "0x400D786")]
    public const int PIN_OUT_CHANGE_TAB_SKIN_SELECT = 10106;
    [Token(Token = "0x400D787")]
    private const int TAB_ANIM_TIMEOUT = 1000;
    [Token(Token = "0x400D788")]
    [FieldOffset(Offset = "0x0")]
    public static UnitEnhanceV3 Instance;
    [Token(Token = "0x400D789")]
    [FieldOffset(Offset = "0xC")]
    private List<ItemData> mTmpItems;
    [Token(Token = "0x400D78A")]
    private const float ExpAnimSpan = 1f;
    [Token(Token = "0x400D78B")]
    [FieldOffset(Offset = "0x10")]
    [Space(10f)]
    public bool FastStart;
    [Token(Token = "0x400D78C")]
    [FieldOffset(Offset = "0x14")]
    public GameObject EquipSlotEffect;
    [Token(Token = "0x400D78D")]
    [FieldOffset(Offset = "0x18")]
    public GameObject JobChangeButtonEffect;
    [Token(Token = "0x400D78E")]
    [FieldOffset(Offset = "0x1C")]
    public GameObject ParamUpEffect;
    [Token(Token = "0x400D78F")]
    [FieldOffset(Offset = "0x20")]
    public GameObject ParamDownEffect;
    [Token(Token = "0x400D790")]
    [FieldOffset(Offset = "0x24")]
    public Color32 DefaultParamColor;
    [Token(Token = "0x400D791")]
    [FieldOffset(Offset = "0x28")]
    public Color32 ParamUpColor;
    [Token(Token = "0x400D792")]
    [FieldOffset(Offset = "0x2C")]
    public Color32 ParamDownColor;
    [Token(Token = "0x400D793")]
    [FieldOffset(Offset = "0x30")]
    public string AbilityRankUpTrigger;
    [Token(Token = "0x400D794")]
    [FieldOffset(Offset = "0x34")]
    public GameObject AbilityRankUpEffect;
    [Token(Token = "0x400D795")]
    [FieldOffset(Offset = "0x38")]
    public GameObject JobRankUpEffect;
    [Token(Token = "0x400D796")]
    [FieldOffset(Offset = "0x3C")]
    [StringIsResourcePath(typeof (GameObject))]
    public string Prefab_JobRankUp;
    [Token(Token = "0x400D797")]
    [FieldOffset(Offset = "0x40")]
    [StringIsResourcePath(typeof (GameObject))]
    public string Prefab_JobUnlock;
    [Token(Token = "0x400D798")]
    [FieldOffset(Offset = "0x44")]
    [StringIsResourcePath(typeof (GameObject))]
    public string Prefab_JobCC;
    [Token(Token = "0x400D799")]
    [FieldOffset(Offset = "0x48")]
    [StringIsResourcePath(typeof (GameObject))]
    public string Prefab_NewAbilityList;
    [Token(Token = "0x400D79A")]
    [FieldOffset(Offset = "0x4C")]
    [StringIsResourcePath(typeof (GameObject))]
    public string Prefab_NewSkillList;
    [Token(Token = "0x400D79B")]
    [FieldOffset(Offset = "0x50")]
    [StringIsResourcePath(typeof (GameObject))]
    public string Prefab_NewSkillList2;
    [Token(Token = "0x400D79C")]
    [FieldOffset(Offset = "0x54")]
    [StringIsResourcePath(typeof (GameObject))]
    public string Prefab_ReturnItems;
    [Token(Token = "0x400D79D")]
    [FieldOffset(Offset = "0x58")]
    [StringIsResourcePath(typeof (GameObject))]
    public string Prefab_LeveUp;
    [Token(Token = "0x400D79E")]
    [FieldOffset(Offset = "0x5C")]
    [StringIsResourcePath(typeof (GameObject))]
    public string Prefab_Kakusei;
    [Token(Token = "0x400D79F")]
    [FieldOffset(Offset = "0x60")]
    [StringIsResourcePath(typeof (GameObject))]
    public string Prefab_Evolution;
    [Token(Token = "0x400D7A0")]
    [FieldOffset(Offset = "0x64")]
    [StringIsResourcePath(typeof (GameObject))]
    public string Prefab_JobChange;
    [Token(Token = "0x400D7A1")]
    [FieldOffset(Offset = "0x68")]
    [StringIsResourcePath(typeof (GameObject))]
    public string Prefab_JobMaster;
    [Token(Token = "0x400D7A2")]
    [FieldOffset(Offset = "0x6C")]
    [StringIsResourcePath(typeof (GameObject))]
    public string Prefab_Unlock_Tobira;
    [Token(Token = "0x400D7A3")]
    [FieldOffset(Offset = "0x70")]
    private string PREFAB_PATH_TOBIRA_OPEN;
    [Token(Token = "0x400D7A4")]
    [FieldOffset(Offset = "0x74")]
    private string PREFAB_PATH_TOBIRA_LEVELUP;
    [Token(Token = "0x400D7A5")]
    [FieldOffset(Offset = "0x78")]
    private string PREFAB_PATH_TOBIRA_LEVEL_MAX;
    [Token(Token = "0x400D7A6")]
    [FieldOffset(Offset = "0x7C")]
    private GameObject mTobiraLevelupMaxEffectObject;
    [Token(Token = "0x400D7A7")]
    [FieldOffset(Offset = "0x80")]
    [StringIsResourcePath(typeof (GameObject))]
    public string Prefab_UnitPieceWindow;
    [Token(Token = "0x400D7A8")]
    [FieldOffset(Offset = "0x84")]
    [StringIsResourcePath(typeof (GameObject))]
    public string Prefab_ProfileWindow;
    [Token(Token = "0x400D7A9")]
    [FieldOffset(Offset = "0x88")]
    public Tooltip Prefab_LockedJobTooltip;
    [Token(Token = "0x400D7AA")]
    [FieldOffset(Offset = "0x8C")]
    public Tooltip Prefab_ParamTooltip;
    [Token(Token = "0x400D7AB")]
    [FieldOffset(Offset = "0x90")]
    public Tooltip Prefab_UnitStatusAwakeTooltip;
    [Token(Token = "0x400D7AC")]
    [FieldOffset(Offset = "0x94")]
    [SerializeField]
    private string PREFAB_PATH_CHARA_QUEST_LIST_WINDOW;
    [Token(Token = "0x400D7AD")]
    [FieldOffset(Offset = "0x98")]
    [SerializeField]
    private string PREFAB_PATH_UNITDATA_UNLOCK_POPUP;
    [Token(Token = "0x400D7AE")]
    [FieldOffset(Offset = "0x9C")]
    [SerializeField]
    private string PREFAB_PATH_EVOLUTION_WINDOW;
    [Token(Token = "0x400D7AF")]
    [FieldOffset(Offset = "0xA0")]
    [SerializeField]
    private string PREFAB_PATH_UNLOCK_TOBIRA_WINDOW;
    [Token(Token = "0x400D7B0")]
    [FieldOffset(Offset = "0xA4")]
    [SerializeField]
    private string PREFAB_PATH_ARTIFACT_WINDOW;
    [Token(Token = "0x400D7B1")]
    [FieldOffset(Offset = "0xA8")]
    [SerializeField]
    private string PREFAB_PATH_MODEL_VIEWER;
    [Token(Token = "0x400D7B2")]
    [FieldOffset(Offset = "0xAC")]
    public SRPG_Button CharaQuestButton;
    [Token(Token = "0x400D7B3")]
    [FieldOffset(Offset = "0xB0")]
    public SRPG_Button SkinButton;
    [Token(Token = "0x400D7B4")]
    [FieldOffset(Offset = "0xB4")]
    [SerializeField]
    private Animator m_SkinAnimator;
    [Token(Token = "0x400D7B5")]
    [FieldOffset(Offset = "0xB8")]
    [SerializeField]
    private Vector2 mCrystalLockTextPos;
    [Token(Token = "0x400D7B6")]
    [FieldOffset(Offset = "0xC0")]
    [Space(10f)]
    public bool ShowNoStockExpPotions;
    [Token(Token = "0x400D7B7")]
    [FieldOffset(Offset = "0xC4")]
    [Space(10f)]
    public SRPG_ToggleButton JobChangeButton;
    [Token(Token = "0x400D7B8")]
    [FieldOffset(Offset = "0xC8")]
    public Text JobRank;
    [Token(Token = "0x400D7B9")]
    [FieldOffset(Offset = "0xCC")]
    [Space(10f)]
    public SRPG_Button UnitKakuseiButton;
    [Token(Token = "0x400D7BA")]
    [FieldOffset(Offset = "0xD0")]
    public SRPG_Button UnitEvolutionButton;
    [Token(Token = "0x400D7BB")]
    [FieldOffset(Offset = "0xD4")]
    public Button UnitUnlockTobiraButton;
    [Token(Token = "0x400D7BC")]
    [FieldOffset(Offset = "0xD8")]
    public Button UnitGoTobiraButton;
    [Token(Token = "0x400D7BD")]
    [FieldOffset(Offset = "0xDC")]
    public Button UnitGoRuneButton;
    [Token(Token = "0x400D7BE")]
    [FieldOffset(Offset = "0xE0")]
    [SerializeField]
    private Button UnitResonanceButton;
    [Token(Token = "0x400D7BF")]
    [FieldOffset(Offset = "0xE4")]
    public string UnitKakuseiButtonHilitBool;
    [Token(Token = "0x400D7C0")]
    [FieldOffset(Offset = "0xE8")]
    public string UnitEvolutionButtonHilitBool;
    [Token(Token = "0x400D7C1")]
    [FieldOffset(Offset = "0xEC")]
    public string UnitTobiraButtonHilitBool;
    [Token(Token = "0x400D7C2")]
    [FieldOffset(Offset = "0xF0")]
    public string JobRankUpButtonHilitBool;
    [Token(Token = "0x400D7C3")]
    [FieldOffset(Offset = "0xF4")]
    public string AllEquipButtonHilitBool;
    [Token(Token = "0x400D7C4")]
    [FieldOffset(Offset = "0xF8")]
    [SerializeField]
    private GameObject UnitResonanceButtonHilitObject;
    [Token(Token = "0x400D7C5")]
    [FieldOffset(Offset = "0xFC")]
    [Space(10f)]
    public RectTransform TabPageParent;
    [Token(Token = "0x400D7C6")]
    [FieldOffset(Offset = "0x100")]
    [SerializeField]
    private SRPG_ToggleButtonObject Tab_Equipment;
    [Token(Token = "0x400D7C7")]
    [FieldOffset(Offset = "0x104")]
    [SerializeField]
    private SRPG_ToggleButtonObject Tab_Enhance;
    [Token(Token = "0x400D7C8")]
    [FieldOffset(Offset = "0x108")]
    [SerializeField]
    private Button Tab_ResonanceBlock_Enhance;
    [Token(Token = "0x400D7C9")]
    [FieldOffset(Offset = "0x10C")]
    [SerializeField]
    private SRPG_ToggleButtonObject Tab_TruthEquipment;
    [Token(Token = "0x400D7CA")]
    [FieldOffset(Offset = "0x110")]
    [SerializeField]
    private SRPG_ToggleButtonObject Tab_AilityUpAndSet;
    [Token(Token = "0x400D7CB")]
    [FieldOffset(Offset = "0x114")]
    [SerializeField]
    private SRPG_ToggleButtonObject Tab_InvalidSkill;
    [Token(Token = "0x400D7CC")]
    [FieldOffset(Offset = "0x118")]
    [SerializeField]
    private SRPG_ToggleButtonObject Tab_UnitProfile;
    [Token(Token = "0x400D7CD")]
    [FieldOffset(Offset = "0x11C")]
    [SerializeField]
    private SRPG_ToggleButtonObject Tab_SkinSelect;
    [Token(Token = "0x400D7CE")]
    [FieldOffset(Offset = "0x120")]
    public UnitEnhancePanel Prefab_AbilityList;
    [Token(Token = "0x400D7CF")]
    [FieldOffset(Offset = "0x124")]
    public UnitEnhancePanel Prefab_AbilitySlots;
    [Token(Token = "0x400D7D0")]
    [FieldOffset(Offset = "0x128")]
    public UnitAbilityPicker Prefab_AbilityPicker;
    [Token(Token = "0x400D7D1")]
    [FieldOffset(Offset = "0x12C")]
    public GameObject Prefab_IkkatsuEquip;
    [Token(Token = "0x400D7D2")]
    [FieldOffset(Offset = "0x130")]
    public GameObject Prefab_EquipOnly;
    [Token(Token = "0x400D7D3")]
    [FieldOffset(Offset = "0x134")]
    [StringIsResourcePath(typeof (GameObject))]
    [SerializeField]
    private string PATH_EQUIPMENT_WINDOW;
    [Token(Token = "0x400D7D4")]
    [FieldOffset(Offset = "0x138")]
    [SerializeField]
    [StringIsResourcePath(typeof (GameObject))]
    private string PATH_UNIT_ENHANCE_WINDOW;
    [Token(Token = "0x400D7D5")]
    [FieldOffset(Offset = "0x13C")]
    [SerializeField]
    [StringIsResourcePath(typeof (GameObject))]
    private string PATH_TRUTH_EQUIPMENT_WINDOW;
    [Token(Token = "0x400D7D6")]
    [FieldOffset(Offset = "0x140")]
    [SerializeField]
    [StringIsResourcePath(typeof (GameObject))]
    private string PATH_ABILITY_UP_AND_SET_WINDOW;
    [Token(Token = "0x400D7D7")]
    [FieldOffset(Offset = "0x144")]
    [StringIsResourcePath(typeof (GameObject))]
    [SerializeField]
    private string PATH_UNIT_PROFILE_WINDOW;
    [Token(Token = "0x400D7D8")]
    [FieldOffset(Offset = "0x148")]
    [SerializeField]
    [StringIsResourcePath(typeof (GameObject))]
    private string PATH_INVALID_SKILL_WINDOW;
    [Token(Token = "0x400D7D9")]
    [FieldOffset(Offset = "0x14C")]
    [SerializeField]
    [StringIsResourcePath(typeof (GameObject))]
    private string PATH_SKIN_SELECT_WINDOW;
    [Token(Token = "0x400D7DA")]
    [FieldOffset(Offset = "0x150")]
    [SerializeField]
    private GameObject MenuListParent;
    [Token(Token = "0x400D7DB")]
    [FieldOffset(Offset = "0x154")]
    [SerializeField]
    private GameObject MenuListOpened;
    [Token(Token = "0x400D7DC")]
    [FieldOffset(Offset = "0x158")]
    [Space(10f)]
    public SRPG_Button NextUnitButton;
    [Token(Token = "0x400D7DD")]
    [FieldOffset(Offset = "0x15C")]
    public SRPG_Button PrevUnitButton;
    [Token(Token = "0x400D7DE")]
    [FieldOffset(Offset = "0x160")]
    public GameObject SwipeTouchArea;
    [Token(Token = "0x400D7DF")]
    [FieldOffset(Offset = "0x164")]
    [Space(10f)]
    public Text Status_HP;
    [Token(Token = "0x400D7E0")]
    [FieldOffset(Offset = "0x168")]
    public Text Status_MP;
    [Token(Token = "0x400D7E1")]
    [FieldOffset(Offset = "0x16C")]
    public Text Status_MPIni;
    [Token(Token = "0x400D7E2")]
    [FieldOffset(Offset = "0x170")]
    public Text Status_Atk;
    [Token(Token = "0x400D7E3")]
    [FieldOffset(Offset = "0x174")]
    public Text Status_Def;
    [Token(Token = "0x400D7E4")]
    [FieldOffset(Offset = "0x178")]
    public Text Status_Mag;
    [Token(Token = "0x400D7E5")]
    [FieldOffset(Offset = "0x17C")]
    public Text Status_Mnd;
    [Token(Token = "0x400D7E6")]
    [FieldOffset(Offset = "0x180")]
    public Text Status_Rec;
    [Token(Token = "0x400D7E7")]
    [FieldOffset(Offset = "0x184")]
    public Text Status_Dex;
    [Token(Token = "0x400D7E8")]
    [FieldOffset(Offset = "0x188")]
    public Text Status_Spd;
    [Token(Token = "0x400D7E9")]
    [FieldOffset(Offset = "0x18C")]
    public Text Status_Cri;
    [Token(Token = "0x400D7EA")]
    [FieldOffset(Offset = "0x190")]
    public Text Status_Luk;
    [Token(Token = "0x400D7EB")]
    [FieldOffset(Offset = "0x194")]
    public Text Status_Mov;
    [Token(Token = "0x400D7EC")]
    [FieldOffset(Offset = "0x198")]
    public Text Status_Jmp;
    [Token(Token = "0x400D7ED")]
    [FieldOffset(Offset = "0x19C")]
    public Text Param_Renkei;
    [Token(Token = "0x400D7EE")]
    [FieldOffset(Offset = "0x1A0")]
    public Text Status_MPStart;
    [Token(Token = "0x400D7EF")]
    [FieldOffset(Offset = "0x1A4")]
    [Space(10f)]
    [SerializeField]
    private GameObject Obj_MPStart;
    [Token(Token = "0x400D7F0")]
    [FieldOffset(Offset = "0x1A8")]
    [Space(10f)]
    public Vector3 PreviewWindowDir;
    [Token(Token = "0x400D7F1")]
    [FieldOffset(Offset = "0x1B4")]
    [Space(10f)]
    [SerializeField]
    private Animator UnitinfoViewAnimator;
    [Token(Token = "0x400D7F2")]
    [FieldOffset(Offset = "0x1B8")]
    public GameObject UnitInfo;
    [Token(Token = "0x400D7F3")]
    [FieldOffset(Offset = "0x1BC")]
    public GameObject UnitParamInfo;
    [Token(Token = "0x400D7F4")]
    [FieldOffset(Offset = "0x1C0")]
    public GameObject JobInfo;
    [Token(Token = "0x400D7F5")]
    [FieldOffset(Offset = "0x1C4")]
    public GameObject UnitExpInfo;
    [Token(Token = "0x400D7F6")]
    [FieldOffset(Offset = "0x1C8")]
    [SerializeField]
    private GameObject expGroup;
    [Token(Token = "0x400D7F7")]
    [FieldOffset(Offset = "0x1CC")]
    public GameObject UnitRarityInfo;
    [Token(Token = "0x400D7F8")]
    [FieldOffset(Offset = "0x1D0")]
    public SliderAnimator UnitEXPSlider;
    [Token(Token = "0x400D7F9")]
    [FieldOffset(Offset = "0x1D4")]
    public GameObject UnitLevelObj;
    [Token(Token = "0x400D7FA")]
    [FieldOffset(Offset = "0x1D8")]
    public Text UnitLevel;
    [Token(Token = "0x400D7FB")]
    [FieldOffset(Offset = "0x1DC")]
    public Color32 UnitLevelColor;
    [Token(Token = "0x400D7FC")]
    [FieldOffset(Offset = "0x1E0")]
    public Color32 CappedUnitLevelColor;
    [Token(Token = "0x400D7FD")]
    [FieldOffset(Offset = "0x1E4")]
    public GameObject UnitLevelCapInfo;
    [Token(Token = "0x400D7FE")]
    [FieldOffset(Offset = "0x1E8")]
    public Text UnitExp;
    [Token(Token = "0x400D7FF")]
    [FieldOffset(Offset = "0x1EC")]
    public Text UnitExpMax;
    [Token(Token = "0x400D800")]
    [FieldOffset(Offset = "0x1F0")]
    public Text UnitExpNext;
    [Token(Token = "0x400D801")]
    [FieldOffset(Offset = "0x1F4")]
    [Space(10f)]
    public string BGAnimatorID;
    [Token(Token = "0x400D802")]
    [FieldOffset(Offset = "0x1F8")]
    public string BGAnimatorPlayTrigger;
    [Token(Token = "0x400D803")]
    [FieldOffset(Offset = "0x1FC")]
    public string BGUnitImageID;
    [Token(Token = "0x400D804")]
    [FieldOffset(Offset = "0x200")]
    [SerializeField]
    private string BGTobiraImageID;
    [Token(Token = "0x400D805")]
    [FieldOffset(Offset = "0x204")]
    [SerializeField]
    private string BGTobiraEffectImageID;
    [Token(Token = "0x400D806")]
    [FieldOffset(Offset = "0x208")]
    [SerializeField]
    private string BGRuneImageID;
    [Token(Token = "0x400D807")]
    [FieldOffset(Offset = "0x20C")]
    public float BGUnitImageFadeTime;
    [Token(Token = "0x400D808")]
    [FieldOffset(Offset = "0x210")]
    public string ExpOverflowWarning;
    [Token(Token = "0x400D809")]
    [FieldOffset(Offset = "0x214")]
    public Tooltip Prefab_LockedArtifactSlotTooltip;
    [Token(Token = "0x400D80A")]
    [FieldOffset(Offset = "0x218")]
    [SerializeField]
    private Transform mUnitModelViewerParent;
    [Token(Token = "0x400D80B")]
    [FieldOffset(Offset = "0x21C")]
    private UnitModelViewer mUnitModelViewer;
    [Token(Token = "0x400D80C")]
    [FieldOffset(Offset = "0x220")]
    public CanvasGroup LeftGroup;
    [Token(Token = "0x400D80D")]
    [FieldOffset(Offset = "0x224")]
    public CanvasGroup RightGroup;
    [Token(Token = "0x400D80E")]
    [FieldOffset(Offset = "0x228")]
    public Toggle Favorite;
    [Token(Token = "0x400D80F")]
    [FieldOffset(Offset = "0x22C")]
    [SerializeField]
    private Button EnhanceButton;
    [Token(Token = "0x400D810")]
    [FieldOffset(Offset = "0x230")]
    private string PREFAB_PATH_TRUTH_EQUIPMENT_LVUP;
    [Token(Token = "0x400D811")]
    [FieldOffset(Offset = "0x234")]
    private WindowController mWindowSelf;
    [Token(Token = "0x400D812")]
    [FieldOffset(Offset = "0x238")]
    private bool mStarted;
    [Token(Token = "0x400D813")]
    [FieldOffset(Offset = "0x23C")]
    private Dictionary<int, int[]> mJobSetDatas;
    [Token(Token = "0x400D814")]
    [FieldOffset(Offset = "0x240")]
    [SerializeField]
    private JobIconScrollListController mJobIconScrollListController;
    [Token(Token = "0x400D815")]
    [FieldOffset(Offset = "0x244")]
    private List<UnitInventoryJobIcon> mUnitJobIconSetList;
    [Token(Token = "0x400D816")]
    [FieldOffset(Offset = "0x248")]
    private ScrollClamped_JobIcons mScrollClampedJobIcons;
    [Token(Token = "0x400D817")]
    [FieldOffset(Offset = "0x24C")]
    private Canvas mOverlayCanvas;
    [Token(Token = "0x400D818")]
    [FieldOffset(Offset = "0x250")]
    private Animator mBGAnimator;
    [Token(Token = "0x400D819")]
    [FieldOffset(Offset = "0x254")]
    private RawImage mBGUnitImage;
    [Token(Token = "0x400D81A")]
    [FieldOffset(Offset = "0x258")]
    private Animator mBGTobiraAnimator;
    [Token(Token = "0x400D81B")]
    [FieldOffset(Offset = "0x25C")]
    private Animator mBGTobiraEffectAnimator;
    [Token(Token = "0x400D81C")]
    [FieldOffset(Offset = "0x260")]
    private GameObject mRuneBGCanvas;
    [Token(Token = "0x400D81D")]
    [FieldOffset(Offset = "0x268")]
    private long mCurrentUnitID;
    [Token(Token = "0x400D81E")]
    [FieldOffset(Offset = "0x270")]
    private long mCurrentJobUniqueID;
    [Token(Token = "0x400D81F")]
    [FieldOffset(Offset = "0x278")]
    private long mIsSetJobUniqueID;
    [Token(Token = "0x400D820")]
    [FieldOffset(Offset = "0x280")]
    private UnitData mCurrentUnit;
    [Token(Token = "0x400D821")]
    [FieldOffset(Offset = "0x284")]
    private UnitModel mCurrentUnitModel;
    [Token(Token = "0x400D822")]
    [FieldOffset(Offset = "0x288")]
    private float mLastSyncTime;
    [Token(Token = "0x400D823")]
    [FieldOffset(Offset = "0x4")]
    private static readonly string CONCEPT_CARD_EQUIP_WINDOW_PREFAB_PATH;
    [Token(Token = "0x400D824")]
    [FieldOffset(Offset = "0x28C")]
    private UnitEnhancePanel mEquipmentPanel;
    [Token(Token = "0x400D825")]
    [FieldOffset(Offset = "0x290")]
    private UnitEnhancePanel mKyokaPanel;
    [Token(Token = "0x400D826")]
    [FieldOffset(Offset = "0x294")]
    private TruthEquipmentWindow mTruthEquipmentPanel;
    [Token(Token = "0x400D827")]
    [FieldOffset(Offset = "0x298")]
    private UnitEnhancePanel mAbilityUpAndSetPanel;
    [Token(Token = "0x400D828")]
    [FieldOffset(Offset = "0x29C")]
    private UnitProfileWindow mUnitProfilePanel;
    [Token(Token = "0x400D829")]
    [FieldOffset(Offset = "0x2A0")]
    private UnitSkinSelectWindow mSkinSelectPanel;
    [Token(Token = "0x400D82A")]
    [FieldOffset(Offset = "0x2A4")]
    private UnitEnhancePanel mAbilityListPanel;
    [Token(Token = "0x400D82B")]
    [FieldOffset(Offset = "0x2A8")]
    private UnitEnhancePanel mAbilitySlotPanel;
    [Token(Token = "0x400D82C")]
    [FieldOffset(Offset = "0x2AC")]
    private UnitAbilityPicker mAbilityPicker;
    [Token(Token = "0x400D82D")]
    [FieldOffset(Offset = "0x2B0")]
    private UnitEvolutionWindow mEvolutionWindow;
    [Token(Token = "0x400D82E")]
    [FieldOffset(Offset = "0x2B4")]
    private UnitUnlockTobiraWindow mUnlockTobiraWindow;
    [Token(Token = "0x400D82F")]
    [FieldOffset(Offset = "0x2B8")]
    private GameObject mSkinSelectWindow;
    [Token(Token = "0x400D830")]
    [FieldOffset(Offset = "0x2BC")]
    private JobParam mUnlockJobParam;
    [Token(Token = "0x400D831")]
    [FieldOffset(Offset = "0x2C0")]
    private Tooltip mJobUnlockTooltip;
    [Token(Token = "0x400D832")]
    [FieldOffset(Offset = "0x2C4")]
    private int mJobUnlockTooltipIndex;
    [Token(Token = "0x400D833")]
    [FieldOffset(Offset = "0x2C8")]
    private Tooltip mParamTooltip;
    [Token(Token = "0x400D834")]
    [FieldOffset(Offset = "0x2CC")]
    private GameObject mParamTooltipTarget;
    [Token(Token = "0x400D835")]
    [FieldOffset(Offset = "0x2D0")]
    private Tooltip mStatusAwakeTooltip;
    [Token(Token = "0x400D836")]
    [FieldOffset(Offset = "0x2D4")]
    private Tooltip mEquipArtifactUnlockTooltip;
    [Token(Token = "0x400D837")]
    [FieldOffset(Offset = "0x2D8")]
    private int mSelectedEquipmentSlot;
    [Token(Token = "0x400D838")]
    [FieldOffset(Offset = "0x2DC")]
    private UnitPreview mCurrentPreview;
    [Token(Token = "0x400D839")]
    [FieldOffset(Offset = "0x2E0")]
    private Dictionary<string, UnitPreview> mPreviewControllers;
    [Token(Token = "0x400D83A")]
    [FieldOffset(Offset = "0x2E4")]
    private int mSelectedJobIndex;
    [Token(Token = "0x400D83B")]
    [FieldOffset(Offset = "0x2E8")]
    private Dictionary<int, GameObject> mTabPages;
    [Token(Token = "0x400D83C")]
    [FieldOffset(Offset = "0x2EC")]
    private Dictionary<int, SRPG_ToggleButtonObject> mTabButtons;
    [Token(Token = "0x400D83D")]
    [FieldOffset(Offset = "0x2F0")]
    private EnumBitArray<UnitEnhanceV3.eTabButtons> mTabPageRefreshWhenOpen;
    [Token(Token = "0x400D83E")]
    [FieldOffset(Offset = "0x2F4")]
    private UnitEnhanceV3.eTabButtons mActiveTabIndex;
    [Token(Token = "0x400D83F")]
    [FieldOffset(Offset = "0x2F8")]
    private int mLoadingUnitCount;
    [Token(Token = "0x400D840")]
    [FieldOffset(Offset = "0x2FC")]
    private Text[] mStatusParamSlots;
    [Token(Token = "0x400D841")]
    [FieldOffset(Offset = "0x300")]
    private bool mCloseRequested;
    [Token(Token = "0x400D842")]
    [FieldOffset(Offset = "0x304")]
    private float mBGUnitImgAlphaStart;
    [Token(Token = "0x400D843")]
    [FieldOffset(Offset = "0x308")]
    private float mBGUnitImgAlphaEnd;
    [Token(Token = "0x400D844")]
    [FieldOffset(Offset = "0x30C")]
    private float mBGUnitImgFadeTime;
    [Token(Token = "0x400D845")]
    [FieldOffset(Offset = "0x310")]
    private float mBGUnitImgFadeTimeMax;
    [Token(Token = "0x400D846")]
    [FieldOffset(Offset = "0x314")]
    private UnitEquipmentWindow mEquipmentWindow;
    [Token(Token = "0x400D847")]
    [FieldOffset(Offset = "0x318")]
    private UnitKakeraWindow mKakeraWindow;
    [Token(Token = "0x400D848")]
    [FieldOffset(Offset = "0x31C")]
    private UnitCharacterQuestWindow mCharacterQuestWindow;
    [Token(Token = "0x400D849")]
    [FieldOffset(Offset = "0x320")]
    private UnitTobiraInventory mTobiraInventoryWindow;
    [Token(Token = "0x400D84A")]
    [FieldOffset(Offset = "0x324")]
    private RuneInventory mRuneInventoryWindow;
    [Token(Token = "0x400D84B")]
    [FieldOffset(Offset = "0x328")]
    private float mExpStart;
    [Token(Token = "0x400D84C")]
    [FieldOffset(Offset = "0x32C")]
    private float mExpEnd;
    [Token(Token = "0x400D84D")]
    [FieldOffset(Offset = "0x330")]
    private float mExpAnimTime;
    [Token(Token = "0x400D84E")]
    [FieldOffset(Offset = "0x334")]
    private float mLeftTime;
    [Token(Token = "0x400D84F")]
    [FieldOffset(Offset = "0x338")]
    private UnitEnhanceV3.DeferredJob mDefferedCallFunc;
    [Token(Token = "0x400D850")]
    [FieldOffset(Offset = "0x33C")]
    private float mDefferedCallDelay;
    [Token(Token = "0x400D851")]
    [FieldOffset(Offset = "0x340")]
    private long[] mOriginalAbilities;
    [Token(Token = "0x400D852")]
    [FieldOffset(Offset = "0x344")]
    private List<long> mRankedUpAbilities;
    [Token(Token = "0x400D853")]
    [FieldOffset(Offset = "0x348")]
    private Dictionary<string, int> mUsedExpItems;
    [Token(Token = "0x400D854")]
    [FieldOffset(Offset = "0x34C")]
    private List<long> mDirtyUnits;
    [Token(Token = "0x400D855")]
    [FieldOffset(Offset = "0x350")]
    public UnitEnhanceV3.CloseEvent OnUserClose;
    [Token(Token = "0x400D856")]
    [FieldOffset(Offset = "0x354")]
    private UnitUnlockWindow mUnitUnlockWindow;
    [Token(Token = "0x400D857")]
    [FieldOffset(Offset = "0x358")]
    private UnitProfileWindow mUnitProfileWindow;
    [Token(Token = "0x400D858")]
    [FieldOffset(Offset = "0x35C")]
    private GameObject mLeaderSkillDetail;
    [Token(Token = "0x400D859")]
    [FieldOffset(Offset = "0x360")]
    private MySound.Voice mUnitVoice;
    [Token(Token = "0x400D85A")]
    [FieldOffset(Offset = "0x364")]
    private GameObject mArtifactSelector;
    [Token(Token = "0x400D85B")]
    [FieldOffset(Offset = "0x368")]
    private UnitJobRankUpConfirm mIkkatsuEquipWindow;
    [Token(Token = "0x400D85C")]
    [FieldOffset(Offset = "0x36C")]
    private UnitData.CharacterQuestUnlockProgress mChQuestProg;
    [Token(Token = "0x400D85D")]
    [FieldOffset(Offset = "0x370")]
    private string mCurrentUnitUnlocks;
    [Token(Token = "0x400D85E")]
    [FieldOffset(Offset = "0x378")]
    private long mStartSelectUnitUniqueID;
    [Token(Token = "0x400D85F")]
    [FieldOffset(Offset = "0x380")]
    [Space(10f)]
    public bool HoldUseItemEnable;
    [Token(Token = "0x400D860")]
    [FieldOffset(Offset = "0x381")]
    public bool HoldUseItemLvUpStop;
    [Token(Token = "0x400D861")]
    [FieldOffset(Offset = "0x384")]
    private ScrollRect mKyoukaItemScroll;
    [Token(Token = "0x400D862")]
    [FieldOffset(Offset = "0x388")]
    private UnitEnhanceV3.ExpItemTouchController mCurrentKyoukaItemHold;
    [Token(Token = "0x400D863")]
    [FieldOffset(Offset = "0x38C")]
    private List<UnitData> SortedUnits;
    [Token(Token = "0x400D864")]
    [FieldOffset(Offset = "0x8")]
    public static readonly string UNIT_EXPMAX_UI_PATH;
    [Token(Token = "0x400D865")]
    [FieldOffset(Offset = "0x390")]
    private List<GameObject> mExpItemGameObjects;
    [Token(Token = "0x400D866")]
    [FieldOffset(Offset = "0x394")]
    private bool IsBulk;
    [Token(Token = "0x400D867")]
    [FieldOffset(Offset = "0x395")]
    private bool mIsCommon;
    [Token(Token = "0x400D868")]
    [FieldOffset(Offset = "0x398")]
    private UnitData mCacheUnitData;
    [Token(Token = "0x400D869")]
    [FieldOffset(Offset = "0x39C")]
    private List<long> m_UnitList;
    [Token(Token = "0x400D86A")]
    [FieldOffset(Offset = "0x3A0")]
    private bool IsStopPlayLeftVoice;
    [Token(Token = "0x400D86B")]
    [FieldOffset(Offset = "0xC")]
    private static readonly int PLAY_LEFTVOICE_SPAN;
    [Token(Token = "0x400D86C")]
    [FieldOffset(Offset = "0x3A4")]
    [Space(10f)]
    public SRPG_Button ButtonMapEffectJob;
    [Token(Token = "0x400D86D")]
    [FieldOffset(Offset = "0x3A8")]
    [StringIsResourcePath(typeof (GameObject))]
    public string PrefabMapEffectJob;
    [Token(Token = "0x400D86E")]
    [FieldOffset(Offset = "0x3AC")]
    private LoadRequest mReqMapEffectJob;
    [Token(Token = "0x400D86F")]
    [FieldOffset(Offset = "0x3B0")]
    public string SceneNameHome;
    [Token(Token = "0x400D870")]
    [FieldOffset(Offset = "0x3B4")]
    public string m_VO_TobiraUnlock;
    [Token(Token = "0x400D871")]
    [FieldOffset(Offset = "0x3B8")]
    public string mVO_TobiraOpenCueID;
    [Token(Token = "0x400D872")]
    [FieldOffset(Offset = "0x3BC")]
    public string mVO_TobiraEnhanceCueID;
    [Token(Token = "0x400D873")]
    [FieldOffset(Offset = "0x3C0")]
    public string mVO_TobiraMaxCueID;
    [Token(Token = "0x400D874")]
    [FieldOffset(Offset = "0x3C4")]
    [StringIsResourcePath(typeof (GameObject))]
    [SerializeField]
    private string PREFAB_PATH_CONCEPT_CARD_SLOT_LOCK_TOOLTIP;
    [Token(Token = "0x400D875")]
    [FieldOffset(Offset = "0x3C8")]
    private GameObject Prefab_ConceptCardSlotLockTooltip;
    [Token(Token = "0x400D876")]
    [FieldOffset(Offset = "0x3CC")]
    private Tooltip mConceptCardSlotLockTooltip;
    [Token(Token = "0x400D877")]
    [FieldOffset(Offset = "0x3D0")]
    [SerializeField]
    private bool mIsTobiraWindowDestroy;
    [Token(Token = "0x400D878")]
    [FieldOffset(Offset = "0x3D4")]
    [SerializeField]
    private ExternalLinkButton mExternalButton;
    [Token(Token = "0x400D879")]
    [FieldOffset(Offset = "0x3D8")]
    [SerializeField]
    private GameObject mInvalidSkillButton;
    [Token(Token = "0x400D87A")]
    [FieldOffset(Offset = "0x3DC")]
    [SerializeField]
    private GameObject mTruthEquipmentLockObject;
    [Token(Token = "0x400D87B")]
    [FieldOffset(Offset = "0x3E0")]
    private UnitEnhanceV3.eUnitInventoryActiveUIType mUnitInventoryActiveUIType;
    [Token(Token = "0x400D87C")]
    [FieldOffset(Offset = "0x3E4")]
    private UnitEnhanceV3.eUnitViewType mUnitViewType;
    [Token(Token = "0x400D87D")]
    [FieldOffset(Offset = "0x3E8")]
    private bool mIsUnitActive;
    [Token(Token = "0x400D87E")]
    [FieldOffset(Offset = "0x3EC")]
    private UnitImagePositionSettings mUnitImagePositionSettings;
    [Token(Token = "0x400D87F")]
    [FieldOffset(Offset = "0x3F0")]
    private Vector2 mDefaultUnitImagePosition;
    [Token(Token = "0x400D880")]
    [FieldOffset(Offset = "0x3F8")]
    [SerializeField]
    private RawImage m_RenderTextureImage;
    [Token(Token = "0x400D881")]
    [FieldOffset(Offset = "0x3FC")]
    [SerializeField]
    private string m_UnitCameraObjectID;
    [Token(Token = "0x400D882")]
    [FieldOffset(Offset = "0x400")]
    private RenderTexture m_RenderTexture;
    [Token(Token = "0x400D883")]
    [FieldOffset(Offset = "0x404")]
    private Transform mTrHomeHeader;
    [Token(Token = "0x400D884")]
    [FieldOffset(Offset = "0x408")]
    [SerializeField]
    [Space(10f)]
    private GameObject resonanceObj;
    [Token(Token = "0x400D885")]
    [FieldOffset(Offset = "0x40C")]
    [SerializeField]
    private GameObject resonanceONObj;
    [Token(Token = "0x400D886")]
    [FieldOffset(Offset = "0x410")]
    [SerializeField]
    private ExhibitList resonanceUnitIconExhibitList;
    [Token(Token = "0x400D887")]
    [FieldOffset(Offset = "0x414")]
    [SerializeField]
    private GameObject resonanceUnitLevelObj;
    [Token(Token = "0x400D888")]
    [FieldOffset(Offset = "0x418")]
    [SerializeField]
    private Text resonanceUnitLevel;
    [Token(Token = "0x400D889")]
    [FieldOffset(Offset = "0x41C")]
    [SerializeField]
    private float resonanceResetDelay;
    [Token(Token = "0x400D88A")]
    [FieldOffset(Offset = "0x420")]
    private string RESONANCE_EFFECT_PREFAB_PATH;
    [Token(Token = "0x400D88B")]
    [FieldOffset(Offset = "0x424")]
    private string RESONANCE_CLOSE_EFFECT_PREFAB_PATH;
    [Token(Token = "0x400D88C")]
    [FieldOffset(Offset = "0x428")]
    private SerializeValueList resonanceSerializeValueList;
    [Token(Token = "0x400D88D")]
    [FieldOffset(Offset = "0x42C")]
    private string CRYSTAL_EQUIP_WINDOW_PREFAB_PATH;
    [Token(Token = "0x400D88E")]
    [FieldOffset(Offset = "0x430")]
    private string CRYSTAL_LOCK_TOOLTIP_PREFAB_PATH;
    [Token(Token = "0x400D88F")]
    [FieldOffset(Offset = "0x434")]
    private Tooltip mCrystalSlotLockTooltip;
    [Token(Token = "0x400D890")]
    [FieldOffset(Offset = "0x438")]
    [Space(10f)]
    private int mCurrentStartGems;
    [Token(Token = "0x400D891")]
    [FieldOffset(Offset = "0x43C")]
    [Space(10f)]
    private string STATUS_AWAKE_WINDOW_PREFAB_PATH;
    [Token(Token = "0x400D892")]
    [FieldOffset(Offset = "0x440")]
    [SerializeField]
    [Space(10f)]
    private ExhibitList[] UnitResonanceAwakeExhibitList;
    [Token(Token = "0x400D893")]
    [FieldOffset(Offset = "0x444")]
    [HeaderBar("▼覚醒+関連")]
    public GenericSlot StatusAwakeSlot;
    [Token(Token = "0x400D894")]
    [FieldOffset(Offset = "0x448")]
    private bool mSceneChanging;
    [Token(Token = "0x400D895")]
    [FieldOffset(Offset = "0x449")]
    private bool mIsJobLvUpAllEquip;
    [Token(Token = "0x400D896")]
    [FieldOffset(Offset = "0x44A")]
    private bool mIsJobLvMaxAllEquip;
    [Token(Token = "0x400D897")]
    [FieldOffset(Offset = "0x44C")]
    private BaseStatus mCurrentDiffStatus;
    [Token(Token = "0x400D898")]
    [FieldOffset(Offset = "0x450")]
    private int mCurrentRenkei;
    [Token(Token = "0x400D899")]
    [FieldOffset(Offset = "0x454")]
    private List<long> mCurrentArtifacts;
    [Token(Token = "0x400D89A")]
    [FieldOffset(Offset = "0x458")]
    [NonSerialized]
    public bool MuteVoice;
    [Token(Token = "0x400D89B")]
    [FieldOffset(Offset = "0x45C")]
    private GameObject ClickItem;
    [Token(Token = "0x400D89C")]
    [FieldOffset(Offset = "0x460")]
    private bool mSendingKyokaRequest;
    [Token(Token = "0x400D89D")]
    [FieldOffset(Offset = "0x461")]
    private bool mKeepWindowLocked;
    [Token(Token = "0x400D89E")]
    [FieldOffset(Offset = "0x462")]
    private bool mJobChangeRequestSent;
    [Token(Token = "0x400D89F")]
    [FieldOffset(Offset = "0x464")]
    private string mNextJobID;
    [Token(Token = "0x400D8A0")]
    [FieldOffset(Offset = "0x468")]
    private string mPrevJobID;
    [Token(Token = "0x400D8A1")]
    [FieldOffset(Offset = "0x46C")]
    private bool mJobRankUpRequestSent;
    [Token(Token = "0x400D8A2")]
    [FieldOffset(Offset = "0x46D")]
    private bool mDesiredPreviewVisibility;
    [Token(Token = "0x400D8A3")]
    [FieldOffset(Offset = "0x46E")]
    private bool mUpdatePreviewVisibility;
    [Token(Token = "0x400D8A4")]
    [FieldOffset(Offset = "0x46F")]
    private bool mAppPausing;
    [Token(Token = "0x400D8A5")]
    [FieldOffset(Offset = "0x470")]
    private UnitAbilityListItemEvents.ListItemTouchController mCurrentAbilityRankUpHold;
    [Token(Token = "0x400D8A6")]
    [FieldOffset(Offset = "0x474")]
    private bool IsFirstPlay;
    [Token(Token = "0x400D8A7")]
    [FieldOffset(Offset = "0x475")]
    private bool mAbilityRankUpRequestSent;
    [Token(Token = "0x400D8A8")]
    [FieldOffset(Offset = "0x478")]
    private LoadRequest mProfileWindowLoadRequest;
    [Token(Token = "0x400D8A9")]
    [FieldOffset(Offset = "0x47C")]
    private int mCacheAwakeLv;
    [Token(Token = "0x400D8AA")]
    [FieldOffset(Offset = "0x480")]
    private bool mKakuseiRequestSent;
    [Token(Token = "0x400D8AB")]
    [FieldOffset(Offset = "0x481")]
    private bool mEvolutionRequestSent;
    [Token(Token = "0x400D8AC")]
    [FieldOffset(Offset = "0x482")]
    private bool mUnlockTobiraRequestSent;
    [Token(Token = "0x400D8AD")]
    [FieldOffset(Offset = "0x484")]
    private Coroutine m_ExecutingShiftUnitCoroutine;

    [Token(Token = "0x600C991")]
    [Address(RVA = "0x927F70", Offset = "0x926D70", VA = "0x10927F70")]
    private void OnEnable()
    {
    }

    [Token(Token = "0x600C992")]
    [Address(RVA = "0x927EC0", Offset = "0x926CC0", VA = "0x10927EC0")]
    private void OnDisable()
    {
    }

    [Token(Token = "0x17001AAC")]
    public UnitData CurrentUnit
    {
      [Token(Token = "0x600C993"), Address(RVA = "0x319810", Offset = "0x318610", VA = "0x10319810")] get
      {
        return (UnitData) null;
      }
    }

    [Token(Token = "0x17001AAD")]
    public List<ItemData> TmpExpItems
    {
      [Token(Token = "0x600C994"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (List<ItemData>) null;
      }
    }

    [Token(Token = "0x17001AAE")]
    private WindowController WindowSelf
    {
      [Token(Token = "0x600C995"), Address(RVA = "0x93F570", Offset = "0x93E370", VA = "0x1093F570")] get
      {
        return (WindowController) null;
      }
    }

    [Token(Token = "0x17001AAF")]
    private List<UnitInventoryJobIcon> UnitJobIconSetList
    {
      [Token(Token = "0x600C996"), Address(RVA = "0x93F450", Offset = "0x93E250", VA = "0x1093F450")] get
      {
        return (List<UnitInventoryJobIcon>) null;
      }
    }

    [Token(Token = "0x17001AB0")]
    private ScrollClamped_JobIcons ScrollClampedJobIcons
    {
      [Token(Token = "0x600C997"), Address(RVA = "0x93F000", Offset = "0x93DE00", VA = "0x1093F000")] get
      {
        return (ScrollClamped_JobIcons) null;
      }
    }

    [Token(Token = "0x17001AB1")]
    public long IsSetJobUniqueID
    {
      [Token(Token = "0x600C998"), Address(RVA = "0x93EBC0", Offset = "0x93D9C0", VA = "0x1093EBC0")] get
      {
        return new long();
      }
    }

    [Token(Token = "0x17001AB2")]
    public List<long> UnitList
    {
      [Token(Token = "0x600C999"), Address(RVA = "0x93F860", Offset = "0x93E660", VA = "0x1093F860")] set
      {
      }
      [Token(Token = "0x600C99A"), Address(RVA = "0x3492C0", Offset = "0x3480C0", VA = "0x103492C0")] get
      {
        return (List<long>) null;
      }
    }

    [Token(Token = "0x17001AB3")]
    private Transform TrHomeHeader
    {
      [Token(Token = "0x600C99B"), Address(RVA = "0x93F2F0", Offset = "0x93E0F0", VA = "0x1093F2F0")] get
      {
        return (Transform) null;
      }
    }

    [Token(Token = "0x600C99C")]
    [Address(RVA = "0x930D40", Offset = "0x92FB40", VA = "0x10930D40")]
    private void OpenMapEffectJob()
    {
    }

    [Token(Token = "0x600C99D")]
    [Address(RVA = "0x93A560", Offset = "0x939360", VA = "0x1093A560")]
    private IEnumerator Start() => (IEnumerator) null;

    [Token(Token = "0x600C99E")]
    [Address(RVA = "0x923E20", Offset = "0x922C20", VA = "0x10923E20")]
    private void InitializeRenderTexture()
    {
    }

    [Token(Token = "0x600C99F")]
    [Address(RVA = "0x923FD0", Offset = "0x922DD0", VA = "0x10923FD0")]
    private void InitializeTabs()
    {
    }

    [Token(Token = "0x600C9A0")]
    [Address(RVA = "0x927560", Offset = "0x926360", VA = "0x10927560")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x600C9A1")]
    [Address(RVA = "0x92CF70", Offset = "0x92BD70", VA = "0x1092CF70")]
    private bool OnSceneCHange() => new bool();

    [Token(Token = "0x600C9A2")]
    [Address(RVA = "0x92D030", Offset = "0x92BE30", VA = "0x1092D030")]
    private IEnumerator OnSceneChangeAsync() => (IEnumerator) null;

    [Token(Token = "0x600C9A3")]
    [Address(RVA = "0x929330", Offset = "0x928130", VA = "0x10929330")]
    private void OnEquipNoCommon()
    {
    }

    [Token(Token = "0x600C9A4")]
    [Address(RVA = "0x928EE0", Offset = "0x927CE0", VA = "0x10928EE0")]
    private void OnEquipCommon()
    {
    }

    [Token(Token = "0x600C9A5")]
    [Address(RVA = "0x929B60", Offset = "0x928960", VA = "0x10929B60")]
    private void OnEquip(bool is_common)
    {
    }

    [Token(Token = "0x600C9A6")]
    [Address(RVA = "0x929830", Offset = "0x928630", VA = "0x10929830")]
    private void OnEquipResult(WWWResult www)
    {
    }

    [Token(Token = "0x600C9A7")]
    [Address(RVA = "0x927510", Offset = "0x926310", VA = "0x10927510")]
    private void OnCommonEquipResult(WWWResult www)
    {
    }

    [Token(Token = "0x600C9A8")]
    [Address(RVA = "0x929860", Offset = "0x928660", VA = "0x10929860")]
    private void OnEquipResult(WWWResult www, bool is_common)
    {
    }

    [Token(Token = "0x600C9A9")]
    [Address(RVA = "0x929DC0", Offset = "0x928BC0", VA = "0x10929DC0")]
    private void OnEquip()
    {
    }

    [Token(Token = "0x600C9AA")]
    [Address(RVA = "0x928A00", Offset = "0x927800", VA = "0x10928A00")]
    private void OnEquipAll(bool AllIn = false)
    {
    }

    [Token(Token = "0x600C9AB")]
    [Address(RVA = "0x937FF0", Offset = "0x936DF0", VA = "0x10937FF0")]
    public void SetIsCommon(bool is_common)
    {
    }

    [Token(Token = "0x600C9AC")]
    [Address(RVA = "0x92C5C0", Offset = "0x92B3C0", VA = "0x1092C5C0")]
    private void OnJobRankUpEquipAllAccept(int target_rank = -1, bool can_jobmaster = false, bool can_jobmax = false)
    {
    }

    [Token(Token = "0x600C9AD")]
    [Address(RVA = "0x929350", Offset = "0x928150", VA = "0x10929350")]
    private void OnEquipOnlyAllAccept()
    {
    }

    [Token(Token = "0x600C9AE")]
    [Address(RVA = "0x928040", Offset = "0x926E40", VA = "0x10928040")]
    private void OnEquipAllAccept(int target_rank = -1, bool can_jobmaster = false, bool can_jobmax = false)
    {
    }

    [Token(Token = "0x600C9AF")]
    [Address(RVA = "0x929510", Offset = "0x928310", VA = "0x10929510")]
    private void OnEquipOnlyAllResult(WWWResult www)
    {
    }

    [Token(Token = "0x600C9B0")]
    [Address(RVA = "0x9282E0", Offset = "0x9270E0", VA = "0x109282E0")]
    private void OnEquipAllResult(WWWResult www)
    {
    }

    [Token(Token = "0x600C9B1")]
    [Address(RVA = "0x91FE70", Offset = "0x91EC70", VA = "0x1091FE70")]
    public void BeginStatusChangeCheck()
    {
    }

    [Token(Token = "0x600C9B2")]
    [Address(RVA = "0x93A190", Offset = "0x938F90", VA = "0x1093A190")]
    public void SpawnStatusChangeEffects()
    {
    }

    [Token(Token = "0x600C9B3")]
    [Address(RVA = "0x939F30", Offset = "0x938D30", VA = "0x10939F30")]
    private void SpawnParamDeltaEffect(GameObject go, int delta)
    {
    }

    [Token(Token = "0x600C9B4")]
    [Address(RVA = "0x9318F0", Offset = "0x9306F0", VA = "0x109318F0")]
    private IEnumerator PostEquip(bool doEquipCountUp = true) => (IEnumerator) null;

    [Token(Token = "0x600C9B5")]
    [Address(RVA = "0x9319C0", Offset = "0x9307C0", VA = "0x109319C0")]
    private IEnumerator PostJobMaster() => (IEnumerator) null;

    [Token(Token = "0x600C9B6")]
    [Address(RVA = "0x931350", Offset = "0x930150", VA = "0x10931350")]
    private void PlayReaction()
    {
    }

    [Token(Token = "0x600C9B7")]
    [Address(RVA = "0x9388F0", Offset = "0x9376F0", VA = "0x109388F0")]
    private void SetUpUnitVoice()
    {
    }

    [Token(Token = "0x600C9B8")]
    [Address(RVA = "0x931800", Offset = "0x930600", VA = "0x10931800")]
    private void PlayUnitVoice(string name)
    {
    }

    [Token(Token = "0x600C9B9")]
    [Address(RVA = "0x93A5C0", Offset = "0x9393C0", VA = "0x1093A5C0")]
    private void StopUnitVoice()
    {
    }

    [Token(Token = "0x600C9BA")]
    [Address(RVA = "0x939E50", Offset = "0x938C50", VA = "0x10939E50")]
    private void SpawnJobChangeButtonEffect()
    {
    }

    [Token(Token = "0x600C9BB")]
    [Address(RVA = "0x939D10", Offset = "0x938B10", VA = "0x10939D10")]
    private void SpawnEquipEffect(int slot)
    {
    }

    [Token(Token = "0x600C9BC")]
    [Address(RVA = "0x92DE00", Offset = "0x92CC00", VA = "0x1092DE00")]
    private void OnTabChange(UnitEnhanceV3.eTabButtons tabType)
    {
    }

    [Token(Token = "0x600C9BD")]
    [Address(RVA = "0x93AAB0", Offset = "0x9398B0", VA = "0x1093AAB0")]
    private bool TabChange(UnitEnhanceV3.eTabButtons tabType) => new bool();

    [Token(Token = "0x600C9BE")]
    [Address(RVA = "0x931590", Offset = "0x930390", VA = "0x10931590")]
    private IEnumerator PlayTabChangeAnimation(WindowController closeTab, WindowController openTab)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x600C9BF")]
    [Address(RVA = "0x938660", Offset = "0x937460", VA = "0x10938660")]
    private void SetTabpageBlockRaycastEnable(UnitEnhanceV3.eTabButtons tab, bool enable)
    {
    }

    [Token(Token = "0x600C9C0")]
    [Address(RVA = "0x921DD0", Offset = "0x920BD0", VA = "0x10921DD0")]
    private void CreateTabPage(UnitEnhanceV3.eTabButtons tab)
    {
    }

    [Token(Token = "0x600C9C1")]
    private T InitTabPage<T>(int pageIndex, T prefab, bool visible, Transform parent = null) where T : MonoBehaviour
    {
      return (T) null;
    }

    [Token(Token = "0x600C9C2")]
    [Address(RVA = "0x93AF10", Offset = "0x939D10", VA = "0x1093AF10")]
    private int TabTypeToOutputPin(UnitEnhanceV3.eTabButtons tab) => new int();

    [Token(Token = "0x600C9C3")]
    [Address(RVA = "0x938010", Offset = "0x936E10", VA = "0x10938010")]
    private void SetIsTabNeedRefresh(UnitEnhanceV3.eTabButtons tab)
    {
    }

    [Token(Token = "0x600C9C4")]
    [Address(RVA = "0x9211C0", Offset = "0x91FFC0", VA = "0x109211C0")]
    private void ClearTabNeedRefresh(UnitEnhanceV3.eTabButtons tab)
    {
    }

    [Token(Token = "0x600C9C5")]
    [Address(RVA = "0x924460", Offset = "0x923260", VA = "0x10924460")]
    private bool IsTabNeedRefresh(UnitEnhanceV3.eTabButtons tab) => new bool();

    [Token(Token = "0x600C9C6")]
    [Address(RVA = "0x923C10", Offset = "0x922A10", VA = "0x10923C10")]
    private void InitSkinPanel(UnitSkinSelectWindow skinPanel)
    {
    }

    [Token(Token = "0x600C9C7")]
    [Address(RVA = "0x9231D0", Offset = "0x921FD0", VA = "0x109231D0")]
    private void InitEquipmentPanel(UnitEnhancePanel panel)
    {
    }

    [Token(Token = "0x600C9C8")]
    [Address(RVA = "0x923750", Offset = "0x922550", VA = "0x10923750")]
    private void InitKyokaPanel(UnitEnhancePanel panel)
    {
    }

    [Token(Token = "0x600C9C9")]
    [Address(RVA = "0x92A340", Offset = "0x929140", VA = "0x1092A340")]
    private void OnExpItemButtonDown(UnitEnhanceV3.ExpItemTouchController controller)
    {
    }

    [Token(Token = "0x600C9CA")]
    [Address(RVA = "0x92A360", Offset = "0x929160", VA = "0x1092A360")]
    private void OnExpItemButtonUp(UnitEnhanceV3.ExpItemTouchController controller)
    {
    }

    [Token(Token = "0x600C9CB")]
    [Address(RVA = "0x92AC50", Offset = "0x929A50", VA = "0x1092AC50")]
    private void OnExpItemHoldUse(GameObject listItem)
    {
    }

    [Token(Token = "0x600C9CC")]
    [Address(RVA = "0x92B100", Offset = "0x929F00", VA = "0x1092B100")]
    private void OnExpOverflowOk(GameObject dialog)
    {
    }

    [Token(Token = "0x600C9CD")]
    [Address(RVA = "0x92AFE0", Offset = "0x929DE0", VA = "0x1092AFE0")]
    private void OnExpOverflowNo(GameObject dialog)
    {
    }

    [Token(Token = "0x600C9CE")]
    [Address(RVA = "0x92A410", Offset = "0x929210", VA = "0x1092A410")]
    private void OnExpItemClick(GameObject go)
    {
    }

    [Token(Token = "0x600C9CF")]
    [Address(RVA = "0x934180", Offset = "0x932F80", VA = "0x10934180")]
    private void RefreshExpItemsButtonState()
    {
    }

    [Token(Token = "0x600C9D0")]
    [Address(RVA = "0x92E510", Offset = "0x92D310", VA = "0x1092E510")]
    private void OnUnitBulkLevelUp(Dictionary<string, int> data)
    {
    }

    [Token(Token = "0x600C9D1")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
    private void SpawnAddExpEffect(int delta, ItemParam item)
    {
    }

    [Token(Token = "0x600C9D2")]
    [Address(RVA = "0x91FD40", Offset = "0x91EB40", VA = "0x1091FD40")]
    private void AnimateGainExp(int desiredExp)
    {
    }

    [Token(Token = "0x600C9D3")]
    [Address(RVA = "0x931B50", Offset = "0x930950", VA = "0x10931B50")]
    private IEnumerator PostUnitLevelUp(int prevLv) => (IEnumerator) null;

    [Token(Token = "0x600C9D4")]
    [Address(RVA = "0x9350E0", Offset = "0x933EE0", VA = "0x109350E0")]
    private void RefreshLevelCap()
    {
    }

    [Token(Token = "0x600C9D5")]
    [Address(RVA = "0x933880", Offset = "0x932680", VA = "0x10933880")]
    private void RefreshEXPImmediate()
    {
    }

    [Token(Token = "0x600C9D6")]
    [Address(RVA = "0x9227C0", Offset = "0x9215C0", VA = "0x109227C0")]
    private bool ExecQueuedKyokaRequest(UnitEnhanceV3.DeferredJob func) => new bool();

    [Token(Token = "0x600C9D7")]
    [Address(RVA = "0x922930", Offset = "0x921730", VA = "0x10922930")]
    private void ForceExecRequest()
    {
    }

    [Token(Token = "0x17001AB4")]
    private bool IsKyokaRequestQueued
    {
      [Token(Token = "0x600C9D8"), Address(RVA = "0x93EB80", Offset = "0x93D980", VA = "0x1093EB80")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x600C9D9")]
    [Address(RVA = "0x9228C0", Offset = "0x9216C0", VA = "0x109228C0")]
    private void FinishKyokaRequest()
    {
    }

    [Token(Token = "0x600C9DA")]
    [Address(RVA = "0x93AA40", Offset = "0x939840", VA = "0x1093AA40")]
    private Coroutine SyncKyokaRequest() => (Coroutine) null;

    [Token(Token = "0x600C9DB")]
    [Address(RVA = "0x93DD40", Offset = "0x93CB40", VA = "0x1093DD40")]
    private IEnumerator WaitForKyokaRequestAsync(bool unlockWindow) => (IEnumerator) null;

    [Token(Token = "0x600C9DC")]
    [Address(RVA = "0x931C20", Offset = "0x930A20", VA = "0x10931C20")]
    private void QueueKyokaRequest(UnitEnhanceV3.DeferredJob func, float delay)
    {
    }

    [Token(Token = "0x17001AB5")]
    private bool IsUnitImageFading
    {
      [Token(Token = "0x600C9DD"), Address(RVA = "0x93EBE0", Offset = "0x93D9E0", VA = "0x1093EBE0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x600C9DE")]
    [Address(RVA = "0x922860", Offset = "0x921660", VA = "0x10922860")]
    private void FadeUnitImage(float alphaStart, float alphaEnd, float duration)
    {
    }

    [Token(Token = "0x600C9DF")]
    [Address(RVA = "0x9387F0", Offset = "0x9375F0", VA = "0x109387F0")]
    private void SetUnitImageAlpha(float alpha)
    {
    }

    [Token(Token = "0x600C9E0")]
    [Address(RVA = "0x93D560", Offset = "0x93C360", VA = "0x1093D560")]
    private void Update()
    {
    }

    [Token(Token = "0x600C9E1")]
    [Address(RVA = "0x924310", Offset = "0x923110", VA = "0x10924310")]
    private bool IsCanPlayLeftVoice() => new bool();

    [Token(Token = "0x600C9E2")]
    [Address(RVA = "0x91F800", Offset = "0x91E600", VA = "0x1091F800")]
    private void AnimateExp()
    {
    }

    [Token(Token = "0x600C9E3")]
    [Address(RVA = "0x93A900", Offset = "0x939700", VA = "0x1093A900")]
    private void SubmitUnitKyoka()
    {
    }

    [Token(Token = "0x600C9E4")]
    [Address(RVA = "0x92FB50", Offset = "0x92E950", VA = "0x1092FB50")]
    private void OnUnitKyokaResult(WWWResult www)
    {
    }

    [Token(Token = "0x600C9E5")]
    [Address(RVA = "0x9307E0", Offset = "0x92F5E0", VA = "0x109307E0")]
    public void OpenEquipmentSlot(int slotIndex)
    {
    }

    [Token(Token = "0x600C9E6")]
    [Address(RVA = "0x929F50", Offset = "0x928D50", VA = "0x10929F50")]
    private void OnEquipmentSlotSelect(GameObject go)
    {
    }

    [Token(Token = "0x600C9E7")]
    [Address(RVA = "0x921210", Offset = "0x920010", VA = "0x10921210")]
    private bool CloseTooltipIfOpened() => new bool();

    [Token(Token = "0x600C9E8")]
    [Address(RVA = "0x939340", Offset = "0x938140", VA = "0x10939340")]
    private void ShowLockEquipCardSlotSelect(int selectedSlotIndex)
    {
    }

    [Token(Token = "0x600C9E9")]
    [Address(RVA = "0x928C30", Offset = "0x927A30", VA = "0x10928C30")]
    private void OnEquipCardSlotSelect(GenericSlot slot, bool interactable)
    {
    }

    [Token(Token = "0x600C9EA")]
    [Address(RVA = "0x928F00", Offset = "0x927D00", VA = "0x10928F00")]
    public void OnEquipConceptCardSelect()
    {
    }

    [Token(Token = "0x600C9EB")]
    [Address(RVA = "0x935010", Offset = "0x933E10", VA = "0x10935010")]
    public void RefreshLeaderSkill()
    {
    }

    [Token(Token = "0x600C9EC")]
    [Address(RVA = "0x927500", Offset = "0x926300", VA = "0x10927500")]
    private void OnCloseEquipConceptCardWindow()
    {
    }

    [Token(Token = "0x600C9ED")]
    [Address(RVA = "0x92A010", Offset = "0x928E10", VA = "0x1092A010")]
    private void OnEquipmentWindowCancel(GameObject go, bool visible)
    {
    }

    [Token(Token = "0x600C9EE")]
    [Address(RVA = "0x92B7B0", Offset = "0x92A5B0", VA = "0x1092B7B0")]
    private void OnJobChangeClick(SRPG_Button button)
    {
    }

    [Token(Token = "0x600C9EF")]
    [Address(RVA = "0x92B120", Offset = "0x929F20", VA = "0x1092B120")]
    private void OnJobChangeAccept(GameObject go)
    {
    }

    [Token(Token = "0x600C9F0")]
    [Address(RVA = "0x931960", Offset = "0x930760", VA = "0x10931960")]
    private IEnumerator PostJobChange() => (IEnumerator) null;

    [Token(Token = "0x600C9F1")]
    [Address(RVA = "0x92BE50", Offset = "0x92AC50", VA = "0x1092BE50")]
    private void OnJobChangeResult(WWWResult www)
    {
    }

    [Token(Token = "0x600C9F2")]
    [Address(RVA = "0x938E10", Offset = "0x937C10", VA = "0x10938E10")]
    private void ShowLockEquipArtifactTooltip(GenericSlot slot)
    {
    }

    [Token(Token = "0x600C9F3")]
    [Address(RVA = "0x925790", Offset = "0x924590", VA = "0x10925790")]
    private void OnArtifactClick(GenericSlot slot, bool interactable)
    {
    }

    [Token(Token = "0x600C9F4")]
    [Address(RVA = "0x922CC0", Offset = "0x921AC0", VA = "0x10922CC0")]
    public int GetUnlockAritfactSlot() => new int();

    [Token(Token = "0x600C9F5")]
    [Address(RVA = "0x926450", Offset = "0x925250", VA = "0x10926450")]
    private void OnArtifactDestroy(ArtifactData artifact, ArtifactTypes type = ArtifactTypes.None)
    {
    }

    [Token(Token = "0x600C9F6")]
    [Address(RVA = "0x922DB0", Offset = "0x921BB0", VA = "0x10922DB0")]
    private ArtifactData[] GetViewArtifactList() => (ArtifactData[]) null;

    [Token(Token = "0x600C9F7")]
    [Address(RVA = "0x9264B0", Offset = "0x9252B0", VA = "0x109264B0")]
    private void OnArtifactSelect(ArtifactData artifact, ArtifactTypes type = ArtifactTypes.None)
    {
    }

    [Token(Token = "0x600C9F8")]
    [Address(RVA = "0x926D80", Offset = "0x925B80", VA = "0x10926D80")]
    private void OnArtifactsEquip(UnitData unit, JobData job, List<ArtifactData> artifacts)
    {
    }

    [Token(Token = "0x600C9F9")]
    [Address(RVA = "0x5EFC90", Offset = "0x5EEA90", VA = "0x105EFC90")]
    private static int SortByArtifactType(ArtifactData a, ArtifactData b) => new int();

    [Token(Token = "0x600C9FA")]
    [Address(RVA = "0x923090", Offset = "0x921E90", VA = "0x10923090")]
    private ArtifactData[] GetViewArtifact() => (ArtifactData[]) null;

    [Token(Token = "0x600C9FB")]
    [Address(RVA = "0x926AC0", Offset = "0x9258C0", VA = "0x10926AC0")]
    private void OnArtifactSetResult(WWWResult www)
    {
    }

    [Token(Token = "0x600C9FC")]
    [Address(RVA = "0x938AA0", Offset = "0x9378A0", VA = "0x10938AA0")]
    private void ShowArtifactSetResult()
    {
    }

    [Token(Token = "0x600C9FD")]
    [Address(RVA = "0x926450", Offset = "0x925250", VA = "0x10926450")]
    private void UpdateArtifactSetResult()
    {
    }

    [Token(Token = "0x600C9FE")]
    [Address(RVA = "0x939C80", Offset = "0x938A80", VA = "0x10939C80")]
    private void ShowSkinSetResult()
    {
    }

    [Token(Token = "0x600C9FF")]
    [Address(RVA = "0x92C160", Offset = "0x92AF60", VA = "0x1092C160")]
    private void OnJobEquipClick(SRPG_Button button)
    {
    }

    [Token(Token = "0x600CA00")]
    [Address(RVA = "0x92C200", Offset = "0x92B000", VA = "0x1092C200")]
    private void OnJobRankUpClick(SRPG_Button button)
    {
    }

    [Token(Token = "0x600CA01")]
    [Address(RVA = "0x93A470", Offset = "0x939270", VA = "0x1093A470")]
    private void StartJobRankUp(int target_rank = -1, bool can_jobmaster = false, bool can_jobmax = false)
    {
    }

    [Token(Token = "0x600CA02")]
    [Address(RVA = "0x92C5E0", Offset = "0x92B3E0", VA = "0x1092C5E0")]
    private void OnJobRankUpResult(WWWResult www)
    {
    }

    [Token(Token = "0x600CA03")]
    [Address(RVA = "0x920EC0", Offset = "0x91FCC0", VA = "0x10920EC0")]
    private bool CheckTargetRankAllEquip(int rank) => new bool();

    [Token(Token = "0x600CA04")]
    [Address(RVA = "0x931A20", Offset = "0x930820", VA = "0x10931A20")]
    private IEnumerator PostJobRankUp(int target_rank = -1, bool can_jobmaster = false, bool can_jobmax = false)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x600CA05")]
    [Address(RVA = "0x933610", Offset = "0x932410", VA = "0x10933610")]
    public void RefreshConceptCardSlot(
      GenericSlot slot,
      ConceptCardData conceptCardData,
      int index)
    {
    }

    [Token(Token = "0x600CA06")]
    [Address(RVA = "0x9336E0", Offset = "0x9324E0", VA = "0x109336E0")]
    private void RefreshCrystalSlot(CrystalEquipSlot _slot)
    {
    }

    [Token(Token = "0x600CA07")]
    [Address(RVA = "0x935A30", Offset = "0x934830", VA = "0x10935A30")]
    private void RefreshStatusAwakeBtn(GenericSlot _slot)
    {
    }

    [Token(Token = "0x600CA08")]
    [Address(RVA = "0x931C50", Offset = "0x930A50", VA = "0x10931C50")]
    private void RebuildUnitData()
    {
    }

    [Token(Token = "0x600CA09")]
    [Address(RVA = "0x936720", Offset = "0x935520", VA = "0x10936720")]
    public void Refresh(long uniqueID, long jobUniqueID = 0, bool immediate = false, bool is_job_icon_hide = true)
    {
    }

    [Token(Token = "0x600CA0A")]
    [Address(RVA = "0x93C7C0", Offset = "0x93B5C0", VA = "0x1093C7C0")]
    private void UpdateTabInteractable()
    {
    }

    [Token(Token = "0x600CA0B")]
    [Address(RVA = "0x920790", Offset = "0x91F590", VA = "0x10920790")]
    private void ChangeToValidTabIfInvalidTab()
    {
    }

    [Token(Token = "0x600CA0C")]
    [Address(RVA = "0x9328E0", Offset = "0x9316E0", VA = "0x109328E0")]
    private IEnumerator RefreshAsync(bool immediate, bool is_job_icon_hide) => (IEnumerator) null;

    [Token(Token = "0x600CA0D")]
    [Address(RVA = "0x935670", Offset = "0x934470", VA = "0x10935670")]
    public void RefreshReturningJobState(long jobUniqueID = 0)
    {
    }

    [Token(Token = "0x600CA0E")]
    [Address(RVA = "0x938460", Offset = "0x937260", VA = "0x10938460")]
    private void SetPreviewVisible(bool visible)
    {
    }

    [Token(Token = "0x600CA0F")]
    [Address(RVA = "0x93BA50", Offset = "0x93A850", VA = "0x1093BA50")]
    private void UpdateJobRankUpButtonState()
    {
    }

    [Token(Token = "0x600CA10")]
    [Address(RVA = "0x922590", Offset = "0x921390", VA = "0x10922590")]
    private void DestroyPreviewObjects()
    {
    }

    [Token(Token = "0x600CA11")]
    [Address(RVA = "0x937000", Offset = "0x935E00", VA = "0x10937000")]
    private void ReloadPreviewModels()
    {
    }

    [Token(Token = "0x600CA12")]
    [Address(RVA = "0x921830", Offset = "0x920630", VA = "0x10921830")]
    public UnitPreview CreatePreview(string job_id) => (UnitPreview) null;

    [Token(Token = "0x600CA13")]
    [Address(RVA = "0x9244B0", Offset = "0x9232B0", VA = "0x109244B0")]
    private IEnumerator LoadAllUnitImage() => (IEnumerator) null;

    [Token(Token = "0x600CA14")]
    [Address(RVA = "0x9364C0", Offset = "0x9352C0", VA = "0x109364C0")]
    private IEnumerator RefreshUnitImage() => (IEnumerator) null;

    [Token(Token = "0x600CA15")]
    [Address(RVA = "0x934F60", Offset = "0x933D60", VA = "0x10934F60")]
    private void RefreshJobInfo()
    {
    }

    [Token(Token = "0x600CA16")]
    [Address(RVA = "0x921080", Offset = "0x91FE80", VA = "0x10921080")]
    private int ClampJobIconIndex(int index) => new int();

    [Token(Token = "0x600CA17")]
    [Address(RVA = "0x9342D0", Offset = "0x9330D0", VA = "0x109342D0")]
    public void RefreshJobIcon(GameObject target, int job_index)
    {
    }

    [Token(Token = "0x600CA18")]
    [Address(RVA = "0x9344E0", Offset = "0x9332E0", VA = "0x109344E0")]
    private void RefreshJobIcons(bool is_hide = false)
    {
    }

    [Token(Token = "0x600CA19")]
    [Address(RVA = "0x937DF0", Offset = "0x936BF0", VA = "0x10937DF0")]
    private void SetActivePreview(string jobID)
    {
    }

    [Token(Token = "0x600CA1A")]
    [Address(RVA = "0x93C600", Offset = "0x93B400", VA = "0x1093C600")]
    private void UpdateJobSlotStates(bool immediate)
    {
    }

    [Token(Token = "0x600CA1B")]
    [Address(RVA = "0x93B9C0", Offset = "0x93A7C0", VA = "0x1093B9C0")]
    private void UpdateJobChangeButtonState()
    {
    }

    [Token(Token = "0x600CA1C")]
    [Address(RVA = "0x93CE80", Offset = "0x93BC80", VA = "0x1093CE80")]
    private void UpdateUnitKakuseiButtonState()
    {
    }

    [Token(Token = "0x600CA1D")]
    [Address(RVA = "0x93CCC0", Offset = "0x93BAC0", VA = "0x1093CCC0")]
    private void UpdateUnitEvolutionButtonState(bool immediate = false)
    {
    }

    [Token(Token = "0x600CA1E")]
    [Address(RVA = "0x93D270", Offset = "0x93C070", VA = "0x1093D270")]
    private void UpdateUnitTobiraButtonState()
    {
    }

    [Token(Token = "0x600CA1F")]
    [Address(RVA = "0x93D180", Offset = "0x93BF80", VA = "0x1093D180")]
    private void UpdateUnitRuneButtonState()
    {
    }

    [Token(Token = "0x600CA20")]
    [Address(RVA = "0x932A50", Offset = "0x931850", VA = "0x10932A50")]
    private void RefreshBasicParameters(bool bDisableJobMaster = false)
    {
    }

    [Token(Token = "0x600CA21")]
    [Address(RVA = "0x9383B0", Offset = "0x9371B0", VA = "0x109383B0")]
    private void SetParamColor(Graphic g, int delta)
    {
    }

    [Token(Token = "0x600CA22")]
    [Address(RVA = "0x933B00", Offset = "0x932900", VA = "0x10933B00")]
    private void RefreshEquipments(int slot = -1)
    {
    }

    [Token(Token = "0x600CA23")]
    [Address(RVA = "0x920850", Offset = "0x91F650", VA = "0x10920850")]
    public bool CheckEquipArtifactSlot(int slot, JobData job, UnitData unit) => new bool();

    [Token(Token = "0x600CA24")]
    [Address(RVA = "0x932850", Offset = "0x931650", VA = "0x10932850")]
    public void RefreshArtifactSlots()
    {
    }

    [Token(Token = "0x600CA25")]
    [Address(RVA = "0x932640", Offset = "0x931440", VA = "0x10932640")]
    public void RefreshArtifactSlot(
      GenericSlot slot,
      List<ArtifactData> artifacts_sort_list,
      int index)
    {
    }

    [Token(Token = "0x600CA26")]
    [Address(RVA = "0x92CCE0", Offset = "0x92BAE0", VA = "0x1092CCE0")]
    public void OnJobSlotClick(GameObject target)
    {
    }

    [Token(Token = "0x600CA27")]
    [Address(RVA = "0x91FFC0", Offset = "0x91EDC0", VA = "0x1091FFC0")]
    private void ChangeJobSlot(int index, GameObject target = null)
    {
    }

    [Token(Token = "0x600CA28")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
    private void RefreshAbilitySlotButtonState()
    {
    }

    [Token(Token = "0x600CA29")]
    [Address(RVA = "0x937270", Offset = "0x936070", VA = "0x10937270")]
    private void Req_UpdateEquippedAbility()
    {
    }

    [Token(Token = "0x600CA2A")]
    [Address(RVA = "0x937570", Offset = "0x936370", VA = "0x10937570")]
    private void Res_UpdateEquippedAbility(WWWResult www)
    {
    }

    [Token(Token = "0x17001AB6")]
    public UnitEquipmentWindow EquipmentWindow
    {
      [Token(Token = "0x600CA2B"), Address(RVA = "0x93F5F0", Offset = "0x93E3F0", VA = "0x1093F5F0")] set
      {
      }
      [Token(Token = "0x600CA2C"), Address(RVA = "0x93E810", Offset = "0x93D610", VA = "0x1093E810")] get
      {
        return (UnitEquipmentWindow) null;
      }
    }

    [Token(Token = "0x17001AB7")]
    public UnitKakeraWindow KakeraWindow
    {
      [Token(Token = "0x600CA2D"), Address(RVA = "0x93F760", Offset = "0x93E560", VA = "0x1093F760")] set
      {
      }
      [Token(Token = "0x600CA2E"), Address(RVA = "0x93EC00", Offset = "0x93DA00", VA = "0x1093EC00")] get
      {
        return (UnitKakeraWindow) null;
      }
    }

    [Token(Token = "0x17001AB8")]
    public UnitTobiraInventory TobiraInventoryWindow
    {
      [Token(Token = "0x600CA2F"), Address(RVA = "0x93F840", Offset = "0x93E640", VA = "0x1093F840")] set
      {
      }
      [Token(Token = "0x600CA30"), Address(RVA = "0x93F0F0", Offset = "0x93DEF0", VA = "0x1093F0F0")] get
      {
        return (UnitTobiraInventory) null;
      }
    }

    [Token(Token = "0x17001AB9")]
    public RuneInventory RuneInventoryWindow
    {
      [Token(Token = "0x600CA31"), Address(RVA = "0x93F820", Offset = "0x93E620", VA = "0x1093F820")] set
      {
      }
      [Token(Token = "0x600CA32"), Address(RVA = "0x93EEB0", Offset = "0x93DCB0", VA = "0x1093EEB0")] get
      {
        return (RuneInventory) null;
      }
    }

    [Token(Token = "0x600CA33")]
    [Address(RVA = "0x9303D0", Offset = "0x92F1D0", VA = "0x109303D0")]
    private void OnWindowStateChange(GameObject go, bool visible)
    {
    }

    [Token(Token = "0x600CA34")]
    [Address(RVA = "0x9241F0", Offset = "0x922FF0", VA = "0x109241F0")]
    private void InvokeUserClose()
    {
    }

    [Token(Token = "0x600CA35")]
    [Address(RVA = "0x93DCE0", Offset = "0x93CAE0", VA = "0x1093DCE0")]
    private IEnumerator WaitForKyokaRequestAndInvokeUserClose() => (IEnumerator) null;

    [Token(Token = "0x600CA36")]
    [Address(RVA = "0x9374F0", Offset = "0x9362F0", VA = "0x109374F0")]
    private void RequestAPI(WebAPI api)
    {
    }

    [Token(Token = "0x600CA37")]
    [Address(RVA = "0x935830", Offset = "0x934630", VA = "0x10935830")]
    private void RefreshSortedUnits()
    {
    }

    [Token(Token = "0x600CA38")]
    [Address(RVA = "0x9365E0", Offset = "0x9353E0", VA = "0x109365E0")]
    private void RefreshUnitShiftButton()
    {
    }

    [Token(Token = "0x600CA39")]
    [Address(RVA = "0x9321D0", Offset = "0x930FD0", VA = "0x109321D0")]
    private void RefreshAbilityList()
    {
    }

    [Token(Token = "0x600CA3A")]
    [Address(RVA = "0x932340", Offset = "0x931140", VA = "0x10932340")]
    private void RefreshAbilitySlots(bool resetScrollPos = false)
    {
    }

    [Token(Token = "0x600CA3B")]
    [Address(RVA = "0x932470", Offset = "0x931270", VA = "0x10932470")]
    private void RefreshAbilityUpAndSet(bool resetScrollPos = false)
    {
    }

    [Token(Token = "0x600CA3C")]
    [Address(RVA = "0x935E60", Offset = "0x934C60", VA = "0x10935E60")]
    private void RefreshTruthEquipment()
    {
    }

    [Token(Token = "0x600CA3D")]
    [Address(RVA = "0x935D40", Offset = "0x934B40", VA = "0x10935D40")]
    private void RefreshTruthEquipmentBadge()
    {
    }

    [Token(Token = "0x600CA3E")]
    [Address(RVA = "0x936520", Offset = "0x935320", VA = "0x10936520")]
    private void RefreshUnitProfile()
    {
    }

    [Token(Token = "0x600CA3F")]
    [Address(RVA = "0x935760", Offset = "0x934560", VA = "0x10935760")]
    private void RefreshSkinSelect()
    {
    }

    [Token(Token = "0x600CA40")]
    [Address(RVA = "0x935310", Offset = "0x934110", VA = "0x10935310")]
    private void RefreshMenuList()
    {
    }

    [Token(Token = "0x600CA41")]
    [Address(RVA = "0x937790", Offset = "0x936590", VA = "0x10937790")]
    private void ResetMenuListAnimatorsPlayTime()
    {
    }

    [Token(Token = "0x600CA42")]
    [Address(RVA = "0x925610", Offset = "0x924410", VA = "0x10925610")]
    private void OnAbilitySlotSelect(int slotIndex)
    {
    }

    [Token(Token = "0x600CA43")]
    [Address(RVA = "0x92D740", Offset = "0x92C540", VA = "0x1092D740")]
    private void OnSlotAbilitySelect(AbilityData ability, GameObject itemGO)
    {
    }

    [Token(Token = "0x600CA44")]
    [Address(RVA = "0x92CE90", Offset = "0x92BC90", VA = "0x1092CE90")]
    private void OnRankUpButtonPressHold(AbilityData abilityData, GameObject gobj)
    {
    }

    [Token(Token = "0x600CA45")]
    [Address(RVA = "0x9248D0", Offset = "0x9236D0", VA = "0x109248D0")]
    private void OnAbilityRankUpSet(AbilityData abilityData, GameObject itemGO)
    {
    }

    [Token(Token = "0x600CA46")]
    [Address(RVA = "0x924560", Offset = "0x923360", VA = "0x10924560")]
    private void OnAbilityRankUpExec(AbilityData abilityData, GameObject go)
    {
    }

    [Token(Token = "0x600CA47")]
    [Address(RVA = "0x924E10", Offset = "0x923C10", VA = "0x10924E10")]
    private void OnAbilityRankUp(AbilityData abilityData, GameObject itemGO)
    {
    }

    [Token(Token = "0x600CA48")]
    [Address(RVA = "0x91EAE0", Offset = "0x91D8E0", VA = "0x1091EAE0")]
    private IEnumerator AbilityRankUpSkillUnlockEffect() => (IEnumerator) null;

    [Token(Token = "0x600CA49")]
    [Address(RVA = "0x93A640", Offset = "0x939440", VA = "0x1093A640")]
    private void SubmitAbilityRankUpRequest()
    {
    }

    [Token(Token = "0x600CA4A")]
    [Address(RVA = "0x92DA70", Offset = "0x92C870", VA = "0x1092DA70")]
    private void OnSubmitAbilityRankUpResult(WWWResult www)
    {
    }

    [Token(Token = "0x600CA4B")]
    [Address(RVA = "0x924540", Offset = "0x923340", VA = "0x10924540")]
    private void OnAbilityRankUpCountPreReset(int unused)
    {
    }

    [Token(Token = "0x600CA4C")]
    [Address(RVA = "0x931880", Offset = "0x930680", VA = "0x10931880")]
    private IEnumerator PostAbilityRankUp(List<SkillParam> newSkills) => (IEnumerator) null;

    [Token(Token = "0x600CA4D")]
    [Address(RVA = "0x925760", Offset = "0x924560", VA = "0x10925760")]
    private void OnApplicationPause(bool pausing)
    {
    }

    [Token(Token = "0x600CA4E")]
    [Address(RVA = "0x925730", Offset = "0x924530", VA = "0x10925730")]
    private void OnApplicationFocus(bool focus)
    {
    }

    [Token(Token = "0x600CA4F")]
    [Address(RVA = "0x92CDF0", Offset = "0x92BBF0", VA = "0x1092CDF0")]
    private void OnKakuseiButtonClick(SRPG_Button button)
    {
    }

    [Token(Token = "0x600CA50")]
    [Address(RVA = "0x930950", Offset = "0x92F750", VA = "0x10930950")]
    public void OpenKakeraWindow()
    {
    }

    [Token(Token = "0x600CA51")]
    [Address(RVA = "0x931090", Offset = "0x92FE90", VA = "0x10931090")]
    public void OpenProfile()
    {
    }

    [Token(Token = "0x600CA52")]
    [Address(RVA = "0x93DE10", Offset = "0x93CC10", VA = "0x1093DE10")]
    private IEnumerator _OpenProfileWindow() => (IEnumerator) null;

    [Token(Token = "0x600CA53")]
    [Address(RVA = "0x92F830", Offset = "0x92E630", VA = "0x1092F830")]
    private void OnUnitKakusei()
    {
    }

    [Token(Token = "0x600CA54")]
    [Address(RVA = "0x92E200", Offset = "0x92D000", VA = "0x1092E200")]
    private void OnUnitAwake2(int pieceCountUnit, int pieceCountElement, int pieceCountCommon)
    {
    }

    [Token(Token = "0x600CA55")]
    [Address(RVA = "0x92F4C0", Offset = "0x92E2C0", VA = "0x1092F4C0")]
    private void OnUnitKakuseiResult(WWWResult www)
    {
    }

    [Token(Token = "0x600CA56")]
    [Address(RVA = "0x92CD20", Offset = "0x92BB20", VA = "0x1092CD20")]
    private void OnKakuseiAccept(GameObject go, bool visible)
    {
    }

    [Token(Token = "0x600CA57")]
    [Address(RVA = "0x931AF0", Offset = "0x9308F0", VA = "0x10931AF0")]
    private IEnumerator PostUnitKakusei() => (IEnumerator) null;

    [Token(Token = "0x600CA58")]
    [Address(RVA = "0x92CE10", Offset = "0x92BC10", VA = "0x1092CE10")]
    private void OnKakuseiCancel(GameObject go, bool visible)
    {
    }

    [Token(Token = "0x600CA59")]
    [Address(RVA = "0x92A0A0", Offset = "0x928EA0", VA = "0x1092A0A0")]
    private void OnEvolutionButtonClick(SRPG_Button button)
    {
    }

    [Token(Token = "0x600CA5A")]
    [Address(RVA = "0x922760", Offset = "0x921560", VA = "0x10922760")]
    private IEnumerator EvolutionButtonClickSync() => (IEnumerator) null;

    [Token(Token = "0x600CA5B")]
    [Address(RVA = "0x92A300", Offset = "0x929100", VA = "0x1092A300")]
    private void OnEvolutionWindowClose()
    {
    }

    [Token(Token = "0x600CA5C")]
    [Address(RVA = "0x92A0A0", Offset = "0x928EA0", VA = "0x1092A0A0")]
    public void OnEvolutionRestore()
    {
    }

    [Token(Token = "0x600CA5D")]
    [Address(RVA = "0x9303C0", Offset = "0x92F1C0", VA = "0x109303C0")]
    public void OnUnlockTobiraRestore()
    {
    }

    [Token(Token = "0x600CA5E")]
    [Address(RVA = "0x928020", Offset = "0x926E20", VA = "0x10928020")]
    public void OnEnhanceTobiraRestore()
    {
    }

    [Token(Token = "0x600CA5F")]
    [Address(RVA = "0x92CF50", Offset = "0x92BD50", VA = "0x1092CF50")]
    public void OnRuneRestore()
    {
    }

    [Token(Token = "0x600CA60")]
    [Address(RVA = "0x927540", Offset = "0x926340", VA = "0x10927540")]
    public void OnCrystalEquipRestore()
    {
    }

    [Token(Token = "0x600CA61")]
    [Address(RVA = "0x92F170", Offset = "0x92DF70", VA = "0x1092F170")]
    private void OnUnitEvolve()
    {
    }

    [Token(Token = "0x600CA62")]
    [Address(RVA = "0x92A240", Offset = "0x929040", VA = "0x1092A240")]
    private void OnEvolutionStart(GameObject go, bool visible)
    {
    }

    [Token(Token = "0x600CA63")]
    [Address(RVA = "0x92A1C0", Offset = "0x928FC0", VA = "0x1092A1C0")]
    private void OnEvolutionCancel(GameObject go, bool visible)
    {
    }

    [Token(Token = "0x600CA64")]
    [Address(RVA = "0x92ECB0", Offset = "0x92DAB0", VA = "0x1092ECB0")]
    private void OnUnitEvolutionResult(WWWResult www)
    {
    }

    [Token(Token = "0x600CA65")]
    [Address(RVA = "0x931A90", Offset = "0x930890", VA = "0x10931A90")]
    private IEnumerator PostUnitEvolution() => (IEnumerator) null;

    [Token(Token = "0x600CA66")]
    [Address(RVA = "0x931150", Offset = "0x92FF50", VA = "0x10931150")]
    private void OpenUnlockTobiraWindow()
    {
    }

    [Token(Token = "0x600CA67")]
    [Address(RVA = "0x93AFD0", Offset = "0x939DD0", VA = "0x1093AFD0")]
    public void TobiraUIActive(bool is_active, bool is_immediate = false)
    {
    }

    [Token(Token = "0x600CA68")]
    [Address(RVA = "0x93DEE0", Offset = "0x93CCE0", VA = "0x1093DEE0")]
    private IEnumerator _TobiraUIActive(bool is_active, bool is_immediate = false)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x600CA69")]
    [Address(RVA = "0x930350", Offset = "0x92F150", VA = "0x10930350")]
    private void OnUnitUnlockTobira()
    {
    }

    [Token(Token = "0x600CA6A")]
    [Address(RVA = "0x93B660", Offset = "0x93A460", VA = "0x1093B660")]
    private IEnumerator UnitUnlockTobira() => (IEnumerator) null;

    [Token(Token = "0x600CA6B")]
    [Address(RVA = "0x92FED0", Offset = "0x92ECD0", VA = "0x1092FED0")]
    private void OnUnitUnlockTobiraResult(WWWResult www)
    {
    }

    [Token(Token = "0x600CA6C")]
    [Address(RVA = "0x931BC0", Offset = "0x9309C0", VA = "0x10931BC0")]
    private IEnumerator PostUnitUnlockTobira() => (IEnumerator) null;

    [Token(Token = "0x600CA6D")]
    [Address(RVA = "0x937D10", Offset = "0x936B10", VA = "0x10937D10")]
    public void RuneUIActive(bool is_active, bool is_immediate = false)
    {
    }

    [Token(Token = "0x600CA6E")]
    [Address(RVA = "0x93DE70", Offset = "0x93CC70", VA = "0x1093DE70")]
    private IEnumerator _RuneUIActive(bool is_active, bool is_immediate = false)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x600CA6F")]
    [Address(RVA = "0x920900", Offset = "0x91F700", VA = "0x10920900")]
    private void CheckInvalidSkillOpen()
    {
    }

    [Token(Token = "0x600CA70")]
    [Address(RVA = "0x93DDB0", Offset = "0x93CBB0", VA = "0x1093DDB0")]
    private IEnumerator _CheckInvalidSkillOpen() => (IEnumerator) null;

    [Token(Token = "0x600CA71")]
    [Address(RVA = "0x9340F0", Offset = "0x932EF0", VA = "0x109340F0")]
    private void RefreshExpInfo()
    {
    }

    [Token(Token = "0x600CA72")]
    [Address(RVA = "0x92DDC0", Offset = "0x92CBC0", VA = "0x1092DDC0")]
    private void OnSwipe(bool isNext)
    {
    }

    [Token(Token = "0x600CA73")]
    [Address(RVA = "0x92D090", Offset = "0x92BE90", VA = "0x1092D090")]
    private void OnShiftUnit(SRPG_Button button)
    {
    }

    [Token(Token = "0x600CA74")]
    [Address(RVA = "0x938A30", Offset = "0x937830", VA = "0x10938A30")]
    private IEnumerator ShiftUnitAsync(long unitUniqueID) => (IEnumerator) null;

    [Token(Token = "0x600CA75")]
    [Address(RVA = "0x922950", Offset = "0x921750", VA = "0x10922950")]
    private int GetCurrentUnitIndex() => new int();

    [Token(Token = "0x600CA76")]
    [Address(RVA = "0x9229E0", Offset = "0x9217E0", VA = "0x109229E0")]
    private List<UnitData> GetCurrentUnits() => (List<UnitData>) null;

    [Token(Token = "0x17001ABA")]
    private int CurrentUnitIndex
    {
      [Token(Token = "0x600CA77"), Address(RVA = "0x93E780", Offset = "0x93D580", VA = "0x1093E780")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17001ABB")]
    private List<UnitData> Units
    {
      [Token(Token = "0x600CA78"), Address(RVA = "0x93F560", Offset = "0x93E360", VA = "0x1093F560")] get
      {
        return (List<UnitData>) null;
      }
    }

    [Token(Token = "0x600CA79")]
    [Address(RVA = "0x9217C0", Offset = "0x9205C0", VA = "0x109217C0")]
    private void CreateOverlay()
    {
    }

    [Token(Token = "0x600CA7A")]
    [Address(RVA = "0x91FDC0", Offset = "0x91EBC0", VA = "0x1091FDC0")]
    private void AttachOverlay(GameObject go)
    {
    }

    [Token(Token = "0x600CA7B")]
    [Address(RVA = "0x9224F0", Offset = "0x9212F0", VA = "0x109224F0")]
    private void DestroyOverlay()
    {
    }

    [Token(Token = "0x17001ABC")]
    public bool IsLoading
    {
      [Token(Token = "0x600CA7C"), Address(RVA = "0x93EBA0", Offset = "0x93D9A0", VA = "0x1093EBA0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x600CA7D")]
    [Address(RVA = "0x938750", Offset = "0x937550", VA = "0x10938750")]
    private void SetUnitDirty()
    {
    }

    [Token(Token = "0x600CA7E")]
    [Address(RVA = "0x922AE0", Offset = "0x9218E0", VA = "0x10922AE0")]
    public long[] GetDirtyUnits() => (long[]) null;

    [Token(Token = "0x600CA7F")]
    [Address(RVA = "0x921180", Offset = "0x91FF80", VA = "0x10921180")]
    public void ClearDirtyUnits()
    {
    }

    [Token(Token = "0x600CA80")]
    [Address(RVA = "0x939850", Offset = "0x938650", VA = "0x10939850")]
    private void ShowParamTooltip(PointerEventData eventData)
    {
    }

    [Token(Token = "0x600CA81")]
    [Address(RVA = "0x91F680", Offset = "0x91E480", VA = "0x1091F680")]
    private void AddParamTooltip(GameObject go)
    {
    }

    [Token(Token = "0x600CA82")]
    [Address(RVA = "0x926FD0", Offset = "0x925DD0", VA = "0x10926FD0")]
    private void OnCharacterQuestOpen()
    {
    }

    [Token(Token = "0x600CA83")]
    [Address(RVA = "0x927000", Offset = "0x925E00", VA = "0x10927000")]
    private void OnCharacterQuestOpen(SRPG_Button button, bool isRestore)
    {
    }

    [Token(Token = "0x600CA84")]
    [Address(RVA = "0x927320", Offset = "0x926120", VA = "0x10927320")]
    private void OnCharacterQuestSelectCancel(GameObject go, bool visible)
    {
    }

    [Token(Token = "0x600CA85")]
    [Address(RVA = "0x927300", Offset = "0x926100", VA = "0x10927300")]
    public void OnCharacterQuestRestore()
    {
    }

    [Token(Token = "0x600CA86")]
    [Address(RVA = "0x930760", Offset = "0x92F560", VA = "0x10930760")]
    private void OpenCharacterQuestPopupInternal()
    {
    }

    [Token(Token = "0x600CA87")]
    [Address(RVA = "0x930700", Offset = "0x92F500", VA = "0x10930700")]
    private IEnumerator OpenCharacterQuestPopupInternalAsync() => (IEnumerator) null;

    [Token(Token = "0x17001ABD")]
    public bool HasStarted
    {
      [Token(Token = "0x600CA88"), Address(RVA = "0x93EB70", Offset = "0x93D970", VA = "0x1093EB70")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x600CA89")]
    [Address(RVA = "0x921CA0", Offset = "0x920AA0", VA = "0x10921CA0")]
    public GameObject CreateSkinSelectWindow(GameObject parent) => (GameObject) null;

    [Token(Token = "0x600CA8A")]
    [Address(RVA = "0x92D420", Offset = "0x92C220", VA = "0x1092D420")]
    private void OnSkinSetResult(WWWResult www)
    {
    }

    [Token(Token = "0x600CA8B")]
    [Address(RVA = "0x92D400", Offset = "0x92C200", VA = "0x1092D400")]
    private void OnSkinSelect(ArtifactParam artifact)
    {
    }

    [Token(Token = "0x600CA8C")]
    [Address(RVA = "0x92D330", Offset = "0x92C130", VA = "0x1092D330")]
    private void OnSkinDecide(ArtifactParam artifact)
    {
    }

    [Token(Token = "0x600CA8D")]
    [Address(RVA = "0x92D2A0", Offset = "0x92C0A0", VA = "0x1092D2A0")]
    private void OnSkinDecideAll(ArtifactParam artifact)
    {
    }

    [Token(Token = "0x600CA8E")]
    [Address(RVA = "0x92D3E0", Offset = "0x92C1E0", VA = "0x1092D3E0")]
    private void OnSkinRemoved()
    {
    }

    [Token(Token = "0x600CA8F")]
    [Address(RVA = "0x92D350", Offset = "0x92C150", VA = "0x1092D350")]
    private void OnSkinRemovedAll()
    {
    }

    [Token(Token = "0x600CA90")]
    [Address(RVA = "0x92A300", Offset = "0x929100", VA = "0x1092A300")]
    private void OnSkinWindowClose()
    {
    }

    [Token(Token = "0x600CA91")]
    [Address(RVA = "0x93B6F0", Offset = "0x93A4F0", VA = "0x1093B6F0")]
    private void UpdataSkinParamChange(ArtifactParam artifact, bool isAll)
    {
    }

    [Token(Token = "0x600CA92")]
    [Address(RVA = "0x939AE0", Offset = "0x9388E0", VA = "0x10939AE0")]
    private void ShowSkinParamChange(
      ArtifactParam artifact,
      bool isAll,
      bool isPlaySkinChangeAnimation = false)
    {
    }

    [Token(Token = "0x600CA93")]
    [Address(RVA = "0x939CB0", Offset = "0x938AB0", VA = "0x10939CB0")]
    private IEnumerator ShowUnlockSkillEffect() => (IEnumerator) null;

    [Token(Token = "0x600CA94")]
    [Address(RVA = "0x93C6F0", Offset = "0x93B4F0", VA = "0x1093C6F0")]
    private void UpdateMainUIAnimator(bool visible)
    {
    }

    [Token(Token = "0x600CA95")]
    [Address(RVA = "0x92AD60", Offset = "0x929B60", VA = "0x1092AD60")]
    private void OnExpMaxOpen(SRPG_Button button)
    {
    }

    [Token(Token = "0x600CA96")]
    [Address(RVA = "0x9314A0", Offset = "0x9302A0", VA = "0x109314A0")]
    public IEnumerator PlayRuneEquipmentEffect(bool playMotionAndVoice) => (IEnumerator) null;

    [Token(Token = "0x600CA97")]
    [Address(RVA = "0x931730", Offset = "0x930530", VA = "0x10931730")]
    public IEnumerator PlayTobiraOpenEffect(TobiraParam.Category selected_tobira_category)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x600CA98")]
    [Address(RVA = "0x931610", Offset = "0x930410", VA = "0x10931610")]
    public IEnumerator PlayTobiraLevelupEffect(TobiraData tobira, bool isEnhanceMaxItemUsed = false)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x600CA99")]
    [Address(RVA = "0x931690", Offset = "0x930490", VA = "0x10931690")]
    private IEnumerator PlayTobiraLevelupMaxEffect(
      AbilityData newAbilityData,
      AbilityData oldAbilityData,
      SkillData newLeaderSkillData,
      bool isUnlockConceptCardSlot,
      bool isUnlockTruthEquipment,
      bool isEnhanceMaxItemUsed)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x600CA9A")]
    [Address(RVA = "0x935BC0", Offset = "0x9349C0", VA = "0x10935BC0")]
    public void RefreshTobiraBgAnimation(TobiraData tobira, bool is_immediate = false)
    {
    }

    [Token(Token = "0x600CA9B")]
    [Address(RVA = "0x922B40", Offset = "0x921940", VA = "0x10922B40")]
    public List<AbilityData> GetNewAbilities(UnitData oldUnit, UnitData newUnit)
    {
      return (List<AbilityData>) null;
    }

    [Token(Token = "0x600CA9C")]
    [Address(RVA = "0x931510", Offset = "0x930310", VA = "0x10931510")]
    public IEnumerator PlayStatusChangeEffect(UnitData oldUnit, UnitData newUnit)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x600CA9D")]
    [Address(RVA = "0x9312D0", Offset = "0x9300D0", VA = "0x109312D0")]
    public IEnumerator PlayNewAbilityLearning(UnitData oldUnit, UnitData newUnit)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x600CA9E")]
    [Address(RVA = "0x9317A0", Offset = "0x9305A0", VA = "0x109317A0")]
    public IEnumerator PlayTruthEquipmentLvupEffect() => (IEnumerator) null;

    [Token(Token = "0x600CA9F")]
    [Address(RVA = "0x920970", Offset = "0x91F770", VA = "0x10920970")]
    private void CheckPlayBackUnlock()
    {
    }

    [Token(Token = "0x600CAA0")]
    [Address(RVA = "0x935470", Offset = "0x934270", VA = "0x10935470")]
    private void RefreshResonance()
    {
    }

    [Token(Token = "0x600CAA1")]
    [Address(RVA = "0x93D050", Offset = "0x93BE50", VA = "0x1093D050")]
    private void UpdateUnitResonanceButtonState()
    {
    }

    [Token(Token = "0x600CAA2")]
    [Address(RVA = "0x927420", Offset = "0x926220", VA = "0x10927420")]
    private void OnClickResonance()
    {
    }

    [Token(Token = "0x600CAA3")]
    [Address(RVA = "0x937850", Offset = "0x936650", VA = "0x10937850")]
    private void ResonanceReleaseWindow()
    {
    }

    [Token(Token = "0x600CAA4")]
    [Address(RVA = "0x9313C0", Offset = "0x9301C0", VA = "0x109313C0")]
    public IEnumerator PlayResonanceEffect() => (IEnumerator) null;

    [Token(Token = "0x600CAA5")]
    [Address(RVA = "0x931420", Offset = "0x930220", VA = "0x10931420")]
    public IEnumerator PlayResonanceResetEffect(long parentUniqueID, long childUniqueID)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x600CAA6")]
    [Address(RVA = "0x932950", Offset = "0x931750", VA = "0x10932950")]
    private void RefreshAwake()
    {
    }

    [Token(Token = "0x600CAA7")]
    [Address(RVA = "0x93D240", Offset = "0x93C040", VA = "0x1093D240")]
    private void UpdateUnitStatusAwakeState()
    {
    }

    [Token(Token = "0x600CAA8")]
    [Address(RVA = "0x91EB40", Offset = "0x91D940", VA = "0x1091EB40", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600CAA9")]
    [Address(RVA = "0x936080", Offset = "0x934E80", VA = "0x10936080")]
    private void RefreshUnitDetail()
    {
    }

    [Token(Token = "0x600CAAA")]
    [Address(RVA = "0x937F60", Offset = "0x936D60", VA = "0x10937F60")]
    private void SetCacheUnitData(UnitData original, int selectedJobIndex)
    {
    }

    [Token(Token = "0x600CAAB")]
    [Address(RVA = "0x93C9F0", Offset = "0x93B7F0", VA = "0x1093C9F0")]
    private void UpdateTrophy_OnJobLevelChange()
    {
    }

    [Token(Token = "0x600CAAC")]
    [Address(RVA = "0x938080", Offset = "0x936E80", VA = "0x10938080")]
    private void SetNotifyReleaseClassChangeJob()
    {
    }

    [Token(Token = "0x600CAAD")]
    [Address(RVA = "0x924510", Offset = "0x923310", VA = "0x10924510")]
    public void LockWindow()
    {
    }

    [Token(Token = "0x600CAAE")]
    [Address(RVA = "0x93B6C0", Offset = "0x93A4C0", VA = "0x1093B6C0")]
    public void UnlockWindow()
    {
    }

    [Token(Token = "0x600CAAF")]
    [Address(RVA = "0x922CB0", Offset = "0x921AB0", VA = "0x10922CB0")]
    public UnitEnhanceV3.eUnitViewType GetUnitViewType() => new UnitEnhanceV3.eUnitViewType();

    [Token(Token = "0x600CAB0")]
    [Address(RVA = "0x9388D0", Offset = "0x9376D0", VA = "0x109388D0")]
    public void SetUnitViewType(UnitEnhanceV3.eUnitViewType viewType)
    {
    }

    [Token(Token = "0x600CAB1")]
    [Address(RVA = "0x922B30", Offset = "0x921930", VA = "0x10922B30")]
    public bool GetIsUnitImageActive() => new bool();

    [Token(Token = "0x600CAB2")]
    [Address(RVA = "0x938060", Offset = "0x936E60", VA = "0x10938060")]
    public void SetIsUnitImageActive(bool active)
    {
    }

    [Token(Token = "0x600CAB3")]
    [Address(RVA = "0x929160", Offset = "0x927F60", VA = "0x10929160")]
    private void OnEquipCrystalSlotSelect(GenericSlot slot, bool interactable)
    {
    }

    [Token(Token = "0x600CAB4")]
    [Address(RVA = "0x921350", Offset = "0x920150", VA = "0x10921350")]
    private void CreateCrystalLockTooltip()
    {
    }

    [Token(Token = "0x600CAB5")]
    [Address(RVA = "0x929070", Offset = "0x927E70", VA = "0x10929070")]
    public void OnEquipCrystalSelect()
    {
    }

    [Token(Token = "0x600CAB6")]
    [Address(RVA = "0x92D8D0", Offset = "0x92C6D0", VA = "0x1092D8D0")]
    private void OnStatusAwakeBtnSelect(GenericSlot slot, bool interactable)
    {
    }

    [Token(Token = "0x600CAB7")]
    [Address(RVA = "0x939670", Offset = "0x938470", VA = "0x10939670")]
    private void ShowLockStatusAwake(GenericSlot slot)
    {
    }

    [Token(Token = "0x600CAB8")]
    [Address(RVA = "0x93E000", Offset = "0x93CE00", VA = "0x1093E000")]
    public UnitEnhanceV3()
    {
    }

    [Token(Token = "0x600CAB9")]
    [Address(RVA = "0x93DF50", Offset = "0x93CD50", VA = "0x1093DF50")]
    static UnitEnhanceV3()
    {
    }

    [Token(Token = "0x2002BD6")]
    private enum eTabButtons
    {
      [Token(Token = "0x400D8AF")] None,
      [Token(Token = "0x400D8B0")] Equipments,
      [Token(Token = "0x400D8B1")] Enhance,
      [Token(Token = "0x400D8B2")] AbilityList,
      [Token(Token = "0x400D8B3")] AbilitySlot,
      [Token(Token = "0x400D8B4")] TruthEquipment,
      [Token(Token = "0x400D8B5")] AbilityUpAndSet,
      [Token(Token = "0x400D8B6")] UnitProfile,
      [Token(Token = "0x400D8B7")] InvalidSkill,
      [Token(Token = "0x400D8B8")] SkinSelect,
      [Token(Token = "0x400D8B9")] Max,
    }

    [Token(Token = "0x2002BD7")]
    private enum eUnitInventoryActiveUIType
    {
      [Token(Token = "0x400D8BB")] Default,
      [Token(Token = "0x400D8BC")] Tobira,
      [Token(Token = "0x400D8BD")] Rune,
    }

    [Token(Token = "0x2002BD8")]
    public enum eUnitViewType
    {
      [Token(Token = "0x400D8BF")] None,
      [Token(Token = "0x400D8C0")] Mode_3D,
      [Token(Token = "0x400D8C1")] Mode_2D,
    }

    [Token(Token = "0x2002BD9")]
    private class ExpItemTouchController : MonoBehaviour, IPointerDownHandler, IEventSystemHandler
    {
      [Token(Token = "0x400D8C2")]
      [FieldOffset(Offset = "0xC")]
      public UnitEnhanceV3.ExpItemTouchController.DelegateOnPointerDown OnPointerDownFunc;
      [Token(Token = "0x400D8C3")]
      [FieldOffset(Offset = "0x10")]
      public UnitEnhanceV3.ExpItemTouchController.DelegateOnPointerDown OnPointerUpFunc;
      [Token(Token = "0x400D8C4")]
      [FieldOffset(Offset = "0x14")]
      public UnitEnhanceV3.ExpItemTouchController.DelegateUseItem UseItemFunc;
      [Token(Token = "0x400D8C5")]
      [FieldOffset(Offset = "0x18")]
      public float UseItemSpan;
      [Token(Token = "0x400D8C6")]
      [FieldOffset(Offset = "0x1C")]
      public float HoldDuration;
      [Token(Token = "0x400D8C7")]
      [FieldOffset(Offset = "0x20")]
      public bool Holding;
      [Token(Token = "0x400D8C8")]
      [FieldOffset(Offset = "0x24")]
      private int UseNum;
      [Token(Token = "0x400D8C9")]
      [FieldOffset(Offset = "0x28")]
      private int NextSettingIndex;
      [Token(Token = "0x400D8CA")]
      [FieldOffset(Offset = "0x2C")]
      private Vector2 mDragStartPos;

      [Token(Token = "0x600CAC6")]
      [Address(RVA = "0x5AFFB0", Offset = "0x5AEDB0", VA = "0x105AFFB0", Slot = "4")]
      public void OnPointerDown(PointerEventData eventData)
      {
      }

      [Token(Token = "0x600CAC7")]
      [Address(RVA = "0x5B0000", Offset = "0x5AEE00", VA = "0x105B0000")]
      public void OnPointerUp()
      {
      }

      [Token(Token = "0x600CAC8")]
      [Address(RVA = "0x93F9B0", Offset = "0x93E7B0", VA = "0x1093F9B0")]
      public void OnDestroy()
      {
      }

      [Token(Token = "0x600CAC9")]
      [Address(RVA = "0x93FA20", Offset = "0x93E820", VA = "0x1093FA20")]
      public void UpdateTimer(float deltaTime)
      {
      }

      [Token(Token = "0x600CACA")]
      [Address(RVA = "0x5B0050", Offset = "0x5AEE50", VA = "0x105B0050")]
      public void StatusReset()
      {
      }

      [Token(Token = "0x600CACB")]
      [Address(RVA = "0x93FC20", Offset = "0x93EA20", VA = "0x1093FC20")]
      public ExpItemTouchController()
      {
      }

      [Token(Token = "0x2002BDA")]
      public delegate void DelegateOnPointerDown(UnitEnhanceV3.ExpItemTouchController controller);

      [Token(Token = "0x2002BDB")]
      public delegate void DelegateOnPointerUp(UnitEnhanceV3.ExpItemTouchController controller);

      [Token(Token = "0x2002BDC")]
      public delegate void DelegateUseItem(GameObject listItem);
    }

    [Token(Token = "0x2002BDD")]
    private delegate void DeferredJob();

    [Token(Token = "0x2002BDE")]
    public delegate void CloseEvent();
  }
}
