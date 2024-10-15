// Decompiled with JetBrains decompiler
// Type: SRPG.ArtifactWindow
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG.Exhibit;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200203A")]
  [FlowNode.Pin(910, "Select Input", FlowNode.PinTypes.Output, 910)]
  [FlowNode.Pin(911, "Select Empty", FlowNode.PinTypes.Output, 911)]
  [FlowNode.Pin(804, "Sort Update", FlowNode.PinTypes.Input, 804)]
  [FlowNode.Pin(1003, "検索：入力", FlowNode.PinTypes.Input, 1003)]
  [FlowNode.Pin(1004, "検索：タイプ", FlowNode.PinTypes.Input, 1004)]
  [FlowNode.Pin(1050, "武輝石：更新", FlowNode.PinTypes.Input, 1050)]
  [FlowNode.Pin(1051, "武輝石：更新", FlowNode.PinTypes.Output, 1051)]
  [FlowNode.Pin(1100, "変換：更新", FlowNode.PinTypes.Input, 1100)]
  [FlowNode.Pin(1061, "武輝石：中断復帰", FlowNode.PinTypes.Output, 1061)]
  [FlowNode.Pin(900, "Check Select Empty", FlowNode.PinTypes.Input, 900)]
  [FlowNode.Pin(1110, "変換：実行", FlowNode.PinTypes.Input, 1110)]
  [FlowNode.Pin(1111, "変換：実行", FlowNode.PinTypes.Output, 1111)]
  [AddComponentMenu("UI/ArtifactWindow")]
  [FlowNode.Pin(667, "InspSkill コスト不足(COIN_P)", FlowNode.PinTypes.Output, 667)]
  [FlowNode.Pin(1060, "武輝石：中断復帰", FlowNode.PinTypes.Input, 1060)]
  [FlowNode.Pin(813, "Select Filter Accessory", FlowNode.PinTypes.Output, 813)]
  [FlowNode.Pin(803, "Set Filter Accessory", FlowNode.PinTypes.Input, 803)]
  [FlowNode.Pin(811, "Select Filter Arms", FlowNode.PinTypes.Output, 811)]
  [FlowNode.Pin(674, "InspSkill 合成成功演出再生開始", FlowNode.PinTypes.Output, 674)]
  [FlowNode.Pin(675, "InspSkill EnhanceEnd", FlowNode.PinTypes.Input, 675)]
  [FlowNode.Pin(676, "InspSkill EnhanceEnd", FlowNode.PinTypes.Output, 676)]
  [FlowNode.Pin(677, "InspSkill 強化素材リセット", FlowNode.PinTypes.Input, 677)]
  [FlowNode.Pin(678, "InspSkill 強化素材リセット", FlowNode.PinTypes.Output, 678)]
  [FlowNode.Pin(680, "InspSkill EquipConfirm", FlowNode.PinTypes.Input, 680)]
  [FlowNode.Pin(681, "InspSkill EquipConfirm", FlowNode.PinTypes.Output, 681)]
  [FlowNode.Pin(690, "InspSkill ResetConfirm", FlowNode.PinTypes.Input, 690)]
  [FlowNode.Pin(691, "InspSkill ResetConfirm", FlowNode.PinTypes.Output, 691)]
  [FlowNode.Pin(700, "Reset Sending Request", FlowNode.PinTypes.Input, 700)]
  [FlowNode.Pin(800, "Set Filter None", FlowNode.PinTypes.Input, 800)]
  [FlowNode.Pin(801, "Set Filter Arms", FlowNode.PinTypes.Input, 801)]
  [FlowNode.Pin(802, "Set Filter Armor", FlowNode.PinTypes.Input, 802)]
  [FlowNode.Pin(673, "InspSkill 合成成功演出再生開始", FlowNode.PinTypes.Input, 673)]
  [FlowNode.Pin(810, "Select Filter None", FlowNode.PinTypes.Output, 810)]
  [FlowNode.Pin(812, "Select Filter Armor", FlowNode.PinTypes.Output, 812)]
  [FlowNode.Pin(672, "InspSkill EnhanceConfirm", FlowNode.PinTypes.Output, 672)]
  [FlowNode.Pin(666, "InspSkill コスト不足(COIN)", FlowNode.PinTypes.Output, 666)]
  [FlowNode.Pin(670, "InspSkill Enhance", FlowNode.PinTypes.Input, 670)]
  [FlowNode.Pin(600, "Sell", FlowNode.PinTypes.Input, 600)]
  [FlowNode.Pin(601, "Sell Begin", FlowNode.PinTypes.Output, 601)]
  [FlowNode.Pin(602, "Sell End", FlowNode.PinTypes.Output, 602)]
  [FlowNode.Pin(650, "InspSkill DefaultTab", FlowNode.PinTypes.Input, 650)]
  [FlowNode.Pin(651, "InspSkill Begin", FlowNode.PinTypes.Output, 651)]
  [FlowNode.Pin(652, "InspSkill End", FlowNode.PinTypes.Output, 652)]
  [FlowNode.Pin(500, "Equip", FlowNode.PinTypes.Output, 500)]
  [FlowNode.Pin(653, "InspSkill ResetTab", FlowNode.PinTypes.Input, 653)]
  [FlowNode.Pin(660, "InspSkill 強化選択", FlowNode.PinTypes.Output, 660)]
  [FlowNode.Pin(661, "InspSkill 装備選択", FlowNode.PinTypes.Output, 661)]
  [FlowNode.Pin(662, "InspSkill リセット選択", FlowNode.PinTypes.Output, 662)]
  [FlowNode.Pin(663, "InspSkill スロット開放選択", FlowNode.PinTypes.Output, 663)]
  [FlowNode.Pin(664, "InspSkill 強化素材長押し", FlowNode.PinTypes.Output, 664)]
  [FlowNode.Pin(671, "InspSkill EnhanceConfirm", FlowNode.PinTypes.Input, 671)]
  [FlowNode.Pin(654, "InspSkill Refresh", FlowNode.PinTypes.Input, 654)]
  [FlowNode.Pin(401, "Decompose End", FlowNode.PinTypes.Output, 402)]
  [FlowNode.Pin(665, "InspSkill コスト不足(GOLD)", FlowNode.PinTypes.Output, 665)]
  [FlowNode.Pin(400, "Decompose", FlowNode.PinTypes.Input, 400)]
  [FlowNode.Pin(6, "Refresh Exp Items", FlowNode.PinTypes.Input, 6)]
  [FlowNode.Pin(11, "Show Selection", FlowNode.PinTypes.Input, 7)]
  [FlowNode.Pin(10, "Flush Requests", FlowNode.PinTypes.Input, 10)]
  [FlowNode.Pin(100, "Finalize", FlowNode.PinTypes.Input, 100)]
  [FlowNode.Pin(101, "Finalize Begin", FlowNode.PinTypes.Output, 101)]
  [FlowNode.Pin(102, "Finalize End", FlowNode.PinTypes.Output, 102)]
  [FlowNode.Pin(402, "Decompose Begin", FlowNode.PinTypes.Output, 401)]
  [FlowNode.Pin(151, "AddExp Begin", FlowNode.PinTypes.Output, 151)]
  [FlowNode.Pin(200, "Rarity Up", FlowNode.PinTypes.Input, 200)]
  [FlowNode.Pin(201, "Rarity Up End", FlowNode.PinTypes.Output, 201)]
  [FlowNode.Pin(202, "Rarity Up Dialog Close", FlowNode.PinTypes.Output, 202)]
  [FlowNode.Pin(300, "Transmute", FlowNode.PinTypes.Input, 300)]
  [FlowNode.Pin(301, "Transmute Begin", FlowNode.PinTypes.Output, 301)]
  [FlowNode.Pin(302, "Transmute End", FlowNode.PinTypes.Output, 302)]
  [FlowNode.Pin(152, "AddExp End", FlowNode.PinTypes.Output, 152)]
  [FlowNode.Pin(5, "Refresh", FlowNode.PinTypes.Input, 5)]
  public class ArtifactWindow : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x40089D6")]
    private const int PIN_OT_SELECT_INSPSKILL_ENHANCE = 660;
    [Token(Token = "0x40089D7")]
    private const int PIN_OT_SELECT_INSPSKILL_EQUIP = 661;
    [Token(Token = "0x40089D8")]
    private const int PIN_OT_SELECT_INSPSKILL_RESET = 662;
    [Token(Token = "0x40089D9")]
    private const int PIN_OT_SELECT_INSPSKILL_UNLOCK = 663;
    [Token(Token = "0x40089DA")]
    private const int PIN_OT_SELECT_INSPSKILL_DETAIL = 664;
    [Token(Token = "0x40089DB")]
    private const int PIN_OT_COSTSHORT_GOLD = 665;
    [Token(Token = "0x40089DC")]
    private const int PIN_OT_COSTSHORT_COIN = 666;
    [Token(Token = "0x40089DD")]
    private const int PIN_OT_COSTSHORT_COIN_P = 667;
    [Token(Token = "0x40089DE")]
    private const int PIN_OT_CONFIRM_INSPSKILL_ENHANCE = 672;
    [Token(Token = "0x40089DF")]
    private const int PIN_INPUT_FILTER_NONE = 800;
    [Token(Token = "0x40089E0")]
    private const int PIN_INPUT_FILTER_ARMS = 801;
    [Token(Token = "0x40089E1")]
    private const int PIN_INPUT_FILTER_AMOR = 802;
    [Token(Token = "0x40089E2")]
    private const int PIN_INPUT_FILTER_ACCESSORY = 803;
    [Token(Token = "0x40089E3")]
    private const int PIN_INPUT_SORT_UPDATE = 804;
    [Token(Token = "0x40089E4")]
    private const int PIN_OUTPUT_FILTER_NONE = 810;
    [Token(Token = "0x40089E5")]
    private const int PIN_OUTPUT_FILTER_ARMS = 811;
    [Token(Token = "0x40089E6")]
    private const int PIN_OUTPUT_FILTER_ARMOR = 812;
    [Token(Token = "0x40089E7")]
    private const int PIN_OUTPUT_FILTER_ACCESSORY = 813;
    [Token(Token = "0x40089E8")]
    private const int PIN_INPUT_PROCESS_SLOTCHECK = 900;
    [Token(Token = "0x40089E9")]
    private const int PIN_OUTPUT_PROCESS_SLOTINPUT = 910;
    [Token(Token = "0x40089EA")]
    private const int PIN_OUTPUT_PROCESS_SLOTNONE = 911;
    [Token(Token = "0x40089EB")]
    private const int PIN_INPUT_NAME_SEARCH_INPUT = 1003;
    [Token(Token = "0x40089EC")]
    private const int PIN_INPUT_NAME_SEARCH_TYPE = 1004;
    [Token(Token = "0x40089ED")]
    private const int PIN_INPUT_ARTIFACT_STONE_EFFECT_REFRESH = 1050;
    [Token(Token = "0x40089EE")]
    private const int PIN_OUTPUT_ARTIFACT_STONE_EFFECT_REFRESH = 1051;
    [Token(Token = "0x40089EF")]
    private const int PIN_INPUT_ARTIFACT_STONE_EFFECT_BREAK = 1060;
    [Token(Token = "0x40089F0")]
    private const int PIN_OUTPUT_ARTIFACT_STONE_EFFECT_BREAK = 1061;
    [Token(Token = "0x40089F1")]
    private const int PIN_INPUT_EXCHANGE_REFRESH = 1100;
    [Token(Token = "0x40089F2")]
    private const int PIN_INPUT_EXCHANGE_EXE = 1110;
    [Token(Token = "0x40089F3")]
    private const int PIN_OUTPUT_EXCHANGE_EXE = 1111;
    [Token(Token = "0x40089F4")]
    [FieldOffset(Offset = "0x0")]
    private static ArtifactWindow mInstance;
    [Token(Token = "0x40089F5")]
    [FieldOffset(Offset = "0xC")]
    public ArtifactList ArtifactList;
    [Token(Token = "0x40089F6")]
    [FieldOffset(Offset = "0x10")]
    public ArtifactScrollList ArtifactScrollList;
    [Token(Token = "0x40089F7")]
    [FieldOffset(Offset = "0x14")]
    [StringIsGameObjectID]
    public string ArtifactListID;
    [Token(Token = "0x40089F8")]
    [FieldOffset(Offset = "0x18")]
    public GenericSlot ArtifactSlot;
    [Token(Token = "0x40089F9")]
    [FieldOffset(Offset = "0x1C")]
    public SRPG_Button artiProssessButton;
    [Token(Token = "0x40089FA")]
    [FieldOffset(Offset = "0x20")]
    public GameObject WindowBody;
    [Token(Token = "0x40089FB")]
    [FieldOffset(Offset = "0x24")]
    public GameObject WindowBodyAdd;
    [Token(Token = "0x40089FC")]
    [FieldOffset(Offset = "0x28")]
    public bool RefreshOnStart;
    [Token(Token = "0x40089FD")]
    [FieldOffset(Offset = "0x2C")]
    public float AutoFlushRequests;
    [Token(Token = "0x40089FE")]
    [FieldOffset(Offset = "0x30")]
    [FourCC]
    public int ArtifactDataID;
    [Token(Token = "0x40089FF")]
    [FieldOffset(Offset = "0x34")]
    [FourCC]
    public int ItemDataID;
    [Token(Token = "0x4008A00")]
    [FieldOffset(Offset = "0x38")]
    [FourCC]
    public int ChangedAbilityID;
    [Token(Token = "0x4008A01")]
    [FieldOffset(Offset = "0x3C")]
    [FourCC]
    public int NewAbilityID;
    [Token(Token = "0x4008A02")]
    [FieldOffset(Offset = "0x40")]
    [Space(16f)]
    public GameObject DetailWindow;
    [Token(Token = "0x4008A03")]
    [FieldOffset(Offset = "0x44")]
    public MaterialPanel DetailMaterial;
    [Token(Token = "0x4008A04")]
    [FieldOffset(Offset = "0x48")]
    [Space(16f)]
    public GameObject KyokaPanel;
    [Token(Token = "0x4008A05")]
    [FieldOffset(Offset = "0x4C")]
    public string KyokaPanelState;
    [Token(Token = "0x4008A06")]
    [FieldOffset(Offset = "0x50")]
    public int KyokaPanel_Enable;
    [Token(Token = "0x4008A07")]
    [FieldOffset(Offset = "0x54")]
    public int KyokaPanel_LvCapped;
    [Token(Token = "0x4008A08")]
    [FieldOffset(Offset = "0x58")]
    public int KyokaPanel_LvMax;
    [Token(Token = "0x4008A09")]
    [FieldOffset(Offset = "0x5C")]
    public GameObject KyokaList;
    [Token(Token = "0x4008A0A")]
    [FieldOffset(Offset = "0x60")]
    public GameObject KyokaListItem;
    [Token(Token = "0x4008A0B")]
    [FieldOffset(Offset = "0x64")]
    public string KyokaSE;
    [Token(Token = "0x4008A0C")]
    [FieldOffset(Offset = "0x68")]
    public SRPG_Button ExpMaxLvupBtn;
    [Token(Token = "0x4008A0D")]
    [FieldOffset(Offset = "0x6C")]
    [Space(16f)]
    public StatusList Status;
    [Token(Token = "0x4008A0E")]
    [FieldOffset(Offset = "0x70")]
    public StatusList StatusAdd;
    [Token(Token = "0x4008A0F")]
    [FieldOffset(Offset = "0x74")]
    public ExpPanel ExpPanel;
    [Token(Token = "0x4008A10")]
    [FieldOffset(Offset = "0x78")]
    public ExpPanel ExpPanelAdd;
    [Token(Token = "0x4008A11")]
    [FieldOffset(Offset = "0x7C")]
    [Space(16f)]
    public GameObject RarityUpPanel;
    [Token(Token = "0x4008A12")]
    [FieldOffset(Offset = "0x80")]
    public string RarityUpPanelState;
    [Token(Token = "0x4008A13")]
    [FieldOffset(Offset = "0x84")]
    public int RarityUpPanel_Normal;
    [Token(Token = "0x4008A14")]
    [FieldOffset(Offset = "0x88")]
    public int RarityUpPanel_MaxRarity;
    [Token(Token = "0x4008A15")]
    [FieldOffset(Offset = "0x8C")]
    public int RarityUpPanel_NoItem;
    [Token(Token = "0x4008A16")]
    [FieldOffset(Offset = "0x90")]
    public Text RarityUpCost;
    [Token(Token = "0x4008A17")]
    [FieldOffset(Offset = "0x94")]
    public string RarityUpCostState;
    [Token(Token = "0x4008A18")]
    [FieldOffset(Offset = "0x98")]
    public int RarityUpCost_Normal;
    [Token(Token = "0x4008A19")]
    [FieldOffset(Offset = "0x9C")]
    public int RarityUpCost_NoGold;
    [Token(Token = "0x4008A1A")]
    [FieldOffset(Offset = "0xA0")]
    public Text RarityUpCondition;
    [Token(Token = "0x4008A1B")]
    [FieldOffset(Offset = "0xA4")]
    public MaterialPanel RarityUpMaterial;
    [Token(Token = "0x4008A1C")]
    [FieldOffset(Offset = "0xA8")]
    public GameObject RarityUpResult;
    [Token(Token = "0x4008A1D")]
    [FieldOffset(Offset = "0xAC")]
    public ArtifactEvolutionSlider ArtifactEvolutionSliderObjct;
    [Token(Token = "0x4008A1E")]
    [FieldOffset(Offset = "0xB0")]
    public GameObject RarityUpIconRoot;
    [Token(Token = "0x4008A1F")]
    [FieldOffset(Offset = "0xB4")]
    public GameObject RarityUpHilit;
    [Token(Token = "0x4008A20")]
    [FieldOffset(Offset = "0xB8")]
    public Button RarityUpButton;
    [Token(Token = "0x4008A21")]
    [FieldOffset(Offset = "0xBC")]
    [Space(16f)]
    public GameObject TransmutePanel;
    [Token(Token = "0x4008A22")]
    [FieldOffset(Offset = "0xC0")]
    public string TransmutePanelState;
    [Token(Token = "0x4008A23")]
    [FieldOffset(Offset = "0xC4")]
    public int TransmutePanel_Normal;
    [Token(Token = "0x4008A24")]
    [FieldOffset(Offset = "0xC8")]
    public int TransmutePanel_Disabled;
    [Token(Token = "0x4008A25")]
    [FieldOffset(Offset = "0xCC")]
    public Text TransmuteCost;
    [Token(Token = "0x4008A26")]
    [FieldOffset(Offset = "0xD0")]
    public string TransmuteCostState;
    [Token(Token = "0x4008A27")]
    [FieldOffset(Offset = "0xD4")]
    public int TransmuteCost_Normal;
    [Token(Token = "0x4008A28")]
    [FieldOffset(Offset = "0xD8")]
    public int TransmuteCost_NoGold;
    [Token(Token = "0x4008A29")]
    [FieldOffset(Offset = "0xDC")]
    public Text TransmuteCondition;
    [Token(Token = "0x4008A2A")]
    [FieldOffset(Offset = "0xE0")]
    public MaterialPanel TransmuteMaterial;
    [Token(Token = "0x4008A2B")]
    [FieldOffset(Offset = "0xE4")]
    public GameObject TransmuteResult;
    [Token(Token = "0x4008A2C")]
    [FieldOffset(Offset = "0xE8")]
    [Space(16f)]
    public GenericSlot OwnerSlot;
    [Token(Token = "0x4008A2D")]
    [FieldOffset(Offset = "0xEC")]
    [Space(16f)]
    public GameObject AbilityList;
    [Token(Token = "0x4008A2E")]
    [FieldOffset(Offset = "0xF0")]
    public GameObject AbilityListItem;
    [Token(Token = "0x4008A2F")]
    [FieldOffset(Offset = "0xF4")]
    public GameObject AbilityListItemAdd;
    [Token(Token = "0x4008A30")]
    [FieldOffset(Offset = "0xF8")]
    public string AbilityListItemState;
    [Token(Token = "0x4008A31")]
    [FieldOffset(Offset = "0xFC")]
    public int AbilityListItem_Hidden;
    [Token(Token = "0x4008A32")]
    [FieldOffset(Offset = "0x100")]
    public int AbilityListItem_Locked;
    [Token(Token = "0x4008A33")]
    [FieldOffset(Offset = "0x104")]
    public int AbilityListItem_Unlocked;
    [Token(Token = "0x4008A34")]
    [FieldOffset(Offset = "0x108")]
    [Space(16f)]
    public GameObject EquipInspSkill;
    [Token(Token = "0x4008A35")]
    [FieldOffset(Offset = "0x10C")]
    public GameObject EquipInspSkillItem;
    [Token(Token = "0x4008A36")]
    [FieldOffset(Offset = "0x110")]
    public GameObject EquipInspSkillItemAdd;
    [Token(Token = "0x4008A37")]
    [FieldOffset(Offset = "0x114")]
    public Toggle EquipInspSkillTab;
    [Token(Token = "0x4008A38")]
    [FieldOffset(Offset = "0x118")]
    public Toggle WeaponAbilityTab;
    [Token(Token = "0x4008A39")]
    [FieldOffset(Offset = "0x11C")]
    public Toggle EquipInspSkillTabAdd;
    [Token(Token = "0x4008A3A")]
    [FieldOffset(Offset = "0x120")]
    public Toggle WeaponAbilityTabAdd;
    [Token(Token = "0x4008A3B")]
    [FieldOffset(Offset = "0x124")]
    public GameObject NotInspSkill;
    [Token(Token = "0x4008A3C")]
    [FieldOffset(Offset = "0x128")]
    public GameObject NotWeaponAbility;
    [Token(Token = "0x4008A3D")]
    [FieldOffset(Offset = "0x12C")]
    public GameObject NotInspSkillAdd;
    [Token(Token = "0x4008A3E")]
    [FieldOffset(Offset = "0x130")]
    public GameObject NotWeaponAbilityAdd;
    [Token(Token = "0x4008A3F")]
    [FieldOffset(Offset = "0x134")]
    [Space(16f)]
    public GameObject SellResult;
    [Token(Token = "0x4008A40")]
    [FieldOffset(Offset = "0x138")]
    public Text SellPrice;
    [Token(Token = "0x4008A41")]
    [FieldOffset(Offset = "0x13C")]
    public string SellSE;
    [Token(Token = "0x4008A42")]
    [FieldOffset(Offset = "0x140")]
    [Space(16f)]
    public GameObject DecomposePanel;
    [Token(Token = "0x4008A43")]
    [FieldOffset(Offset = "0x144")]
    public string DecomposePanelState;
    [Token(Token = "0x4008A44")]
    [FieldOffset(Offset = "0x148")]
    public int DecomposePanel_Normal;
    [Token(Token = "0x4008A45")]
    [FieldOffset(Offset = "0x14C")]
    public int DecomposePanel_Disabled;
    [Token(Token = "0x4008A46")]
    [FieldOffset(Offset = "0x150")]
    public MaterialPanel DecomposeItem;
    [Token(Token = "0x4008A47")]
    [FieldOffset(Offset = "0x154")]
    public GameObject DecomposeResult;
    [Token(Token = "0x4008A48")]
    [FieldOffset(Offset = "0x158")]
    public Text DecomposeHelp;
    [Token(Token = "0x4008A49")]
    [FieldOffset(Offset = "0x15C")]
    public Text DecomposeCost;
    [Token(Token = "0x4008A4A")]
    [FieldOffset(Offset = "0x160")]
    public Text DecomposeCostTotal;
    [Token(Token = "0x4008A4B")]
    [FieldOffset(Offset = "0x164")]
    public Text DecomposeKakeraNumOld;
    [Token(Token = "0x4008A4C")]
    [FieldOffset(Offset = "0x168")]
    public Text DecomposeKakeraNumNew;
    [Token(Token = "0x4008A4D")]
    [FieldOffset(Offset = "0x16C")]
    public GameObject DecomposeWarning;
    [Token(Token = "0x4008A4E")]
    [FieldOffset(Offset = "0x170")]
    public int DecomposeWarningRarity;
    [Token(Token = "0x4008A4F")]
    [FieldOffset(Offset = "0x174")]
    public string DecomposeCostState;
    [Token(Token = "0x4008A50")]
    [FieldOffset(Offset = "0x178")]
    public int DecomposeCost_Normal;
    [Token(Token = "0x4008A51")]
    [FieldOffset(Offset = "0x17C")]
    public int DecomposeCost_NoGold;
    [Token(Token = "0x4008A52")]
    [FieldOffset(Offset = "0x180")]
    public string DecomposeSE;
    [Token(Token = "0x4008A53")]
    [FieldOffset(Offset = "0x184")]
    [Space(16f)]
    public GenericSlot ArtifactOwnerSlot;
    [Token(Token = "0x4008A54")]
    [FieldOffset(Offset = "0x188")]
    public ArtifactWindow.EquipEvent OnEquip;
    [Token(Token = "0x4008A55")]
    [FieldOffset(Offset = "0x18C")]
    public ArtifactWindow.EquipEvent OnDestroyCallBack;
    [Token(Token = "0x4008A56")]
    [FieldOffset(Offset = "0x190")]
    [Space(16f)]
    public Text SelectionNum;
    [Token(Token = "0x4008A57")]
    [FieldOffset(Offset = "0x194")]
    public ArtifactIcon SelectionListItem;
    [Token(Token = "0x4008A58")]
    [FieldOffset(Offset = "0x198")]
    public GameObject SelectionList;
    [Token(Token = "0x4008A59")]
    [FieldOffset(Offset = "0x19C")]
    [Space(16f)]
    public Toggle ProcessToggle_Enhance;
    [Token(Token = "0x4008A5A")]
    [FieldOffset(Offset = "0x1A0")]
    public Toggle ProcessToggle_Evolution;
    [Token(Token = "0x4008A5B")]
    [FieldOffset(Offset = "0x1A4")]
    public Toggle ProcessToggle_Detail;
    [Token(Token = "0x4008A5C")]
    [FieldOffset(Offset = "0x1A8")]
    [Space(16f)]
    public Toggle ToggleExcludeEquiped;
    [Token(Token = "0x4008A5D")]
    [FieldOffset(Offset = "0x1AC")]
    public int RarityCheckValue;
    [Token(Token = "0x4008A5E")]
    [FieldOffset(Offset = "0x1B0")]
    [SerializeField]
    [HeaderBar("▼セット効果確認用のボタン")]
    private Button m_SetEffectsButton;
    [Token(Token = "0x4008A5F")]
    [FieldOffset(Offset = "0x1B4")]
    [SerializeField]
    private Button m_SetEffectsButtonAdd;
    [Token(Token = "0x4008A60")]
    [FieldOffset(Offset = "0x1B8")]
    [HeaderBar("▼プルダウン")]
    [SerializeField]
    private ArtiSortDropdown mArtiDropDown;
    [Token(Token = "0x4008A61")]
    [FieldOffset(Offset = "0x1BC")]
    [SerializeField]
    [HeaderBar("自動装備ボタン")]
    private Button mButtonAutoEquip;
    [Token(Token = "0x4008A62")]
    [FieldOffset(Offset = "0x1C0")]
    [SerializeField]
    [HeaderBar("強化ウインドウ")]
    private GameObject mProcessWindow;
    [Token(Token = "0x4008A63")]
    [FieldOffset(Offset = "0x1C4")]
    [SerializeField]
    private Button SelectButton;
    [Token(Token = "0x4008A64")]
    [FieldOffset(Offset = "0x1C8")]
    private List<ChangeListData> mChangeSet;
    [Token(Token = "0x4008A65")]
    [FieldOffset(Offset = "0x1CC")]
    private ArtifactData mCurrentArtifact;
    [Token(Token = "0x4008A66")]
    [FieldOffset(Offset = "0x1D0")]
    private ArtifactParam mCurrentArtifactParam;
    [Token(Token = "0x4008A67")]
    [FieldOffset(Offset = "0x1D4")]
    private object[] mSelectedArtifacts;
    [Token(Token = "0x4008A68")]
    [FieldOffset(Offset = "0x1D8")]
    private List<GameObject> mAbilityItems;
    [Token(Token = "0x4008A69")]
    [FieldOffset(Offset = "0x1DC")]
    private List<GameObject> mKyokaItems;
    [Token(Token = "0x4008A6A")]
    [FieldOffset(Offset = "0x1E0")]
    private List<GameObject> mRarityUpItems;
    [Token(Token = "0x4008A6B")]
    [FieldOffset(Offset = "0x1E4")]
    private List<ArtifactWindow.Request> mRequests;
    [Token(Token = "0x4008A6C")]
    [FieldOffset(Offset = "0x1E8")]
    private List<GameObject> mDecomposeItems;
    [Token(Token = "0x4008A6D")]
    [FieldOffset(Offset = "0x1EC")]
    private List<ArtifactIcon> mSelectionItems;
    [Token(Token = "0x4008A6E")]
    [FieldOffset(Offset = "0x1F0")]
    private bool mFinalizing;
    [Token(Token = "0x4008A6F")]
    [FieldOffset(Offset = "0x1F1")]
    private bool mSendingRequests;
    [Token(Token = "0x4008A70")]
    [FieldOffset(Offset = "0x1F2")]
    private bool mSceneChanging;
    [Token(Token = "0x4008A71")]
    [FieldOffset(Offset = "0x1F8")]
    private long mTotalSellPrice;
    [Token(Token = "0x4008A72")]
    [FieldOffset(Offset = "0x200")]
    private UnitData mOwnerUnitData;
    [Token(Token = "0x4008A73")]
    [FieldOffset(Offset = "0x204")]
    private int mOwnerUnitJobIndex;
    [Token(Token = "0x4008A74")]
    [FieldOffset(Offset = "0x208")]
    private GameObject mDetailWindow;
    [Token(Token = "0x4008A75")]
    [FieldOffset(Offset = "0x20C")]
    private GameObject mResultWindow;
    [Token(Token = "0x4008A76")]
    [FieldOffset(Offset = "0x210")]
    private float mFlushTimer;
    [Token(Token = "0x4008A77")]
    [FieldOffset(Offset = "0x214")]
    private bool mBusy;
    [Token(Token = "0x4008A78")]
    [FieldOffset(Offset = "0x215")]
    private bool mDisableFlushRequest;
    [Token(Token = "0x4008A79")]
    [FieldOffset(Offset = "0x218")]
    private int mUseEnhanceItemNum;
    [Token(Token = "0x4008A7A")]
    [FieldOffset(Offset = "0x21C")]
    private UnitData mCurrentArtifactOwner;
    [Token(Token = "0x4008A7B")]
    [FieldOffset(Offset = "0x220")]
    private JobData mCurrentArtifactOwnerJob;
    [Token(Token = "0x4008A7C")]
    [FieldOffset(Offset = "0x224")]
    private ArtifactData[] mCachedArtifacts;
    [Token(Token = "0x4008A7D")]
    [FieldOffset(Offset = "0x228")]
    private ArtifactTypes SelectSlotArtifactType;
    [Token(Token = "0x4008A7E")]
    [FieldOffset(Offset = "0x22C")]
    private List<ItemData> mTmpItems;
    [Token(Token = "0x4008A7F")]
    [FieldOffset(Offset = "0x230")]
    private GameObject mConfirmDialogGo;
    [Token(Token = "0x4008A80")]
    [FieldOffset(Offset = "0x4")]
    private static readonly string ARTIFACT_EXPMAX_UI_PATH;
    [Token(Token = "0x4008A81")]
    [FieldOffset(Offset = "0x8")]
    private static readonly string ARTIFACT_RARITY_CHECK_UI_PATH;
    [Token(Token = "0x4008A82")]
    [FieldOffset(Offset = "0x234")]
    private ArtifactWindow.StatusCache mStatusCache;
    [Token(Token = "0x4008A83")]
    [FieldOffset(Offset = "0x238")]
    private ArtifactTypes mSelectArtifactSlot;
    [Token(Token = "0x4008A84")]
    [FieldOffset(Offset = "0x23C")]
    [Space(16f)]
    public GameObject m_InspSkillDefaultPanel;
    [Token(Token = "0x4008A85")]
    [FieldOffset(Offset = "0x240")]
    public GameObject m_InspSkillEnhancePanel;
    [Token(Token = "0x4008A86")]
    [FieldOffset(Offset = "0x244")]
    public Transform m_InspSkillList;
    [Token(Token = "0x4008A87")]
    [FieldOffset(Offset = "0x248")]
    public GameObject m_InspSkillListItem;
    [Token(Token = "0x4008A88")]
    [FieldOffset(Offset = "0x24C")]
    public Transform m_InspSkillEnhanceList;
    [Token(Token = "0x4008A89")]
    [FieldOffset(Offset = "0x250")]
    public GameObject m_InspSkillEnhanceListItem;
    [Token(Token = "0x4008A8A")]
    [FieldOffset(Offset = "0x254")]
    public GameObject m_InspSkillEnhanceBeforePanel;
    [Token(Token = "0x4008A8B")]
    [FieldOffset(Offset = "0x258")]
    public GameObject m_InspSkillEnhanceAfterPanel;
    [Token(Token = "0x4008A8C")]
    [FieldOffset(Offset = "0x25C")]
    public Text m_InspSkillEnhanceCost;
    [Token(Token = "0x4008A8D")]
    [FieldOffset(Offset = "0x260")]
    public GameObject m_InspSkillEnhanceStatus;
    [Token(Token = "0x4008A8E")]
    [FieldOffset(Offset = "0x264")]
    public GameObject m_InspSkillEnhanceStatusParam;
    [Token(Token = "0x4008A8F")]
    [FieldOffset(Offset = "0x268")]
    public GameObject m_InspSkillEnhanceStatusSkill;
    [Token(Token = "0x4008A90")]
    [FieldOffset(Offset = "0x26C")]
    public Button m_InspSkillEnhanceConfirmButton;
    [Token(Token = "0x4008A91")]
    [FieldOffset(Offset = "0x270")]
    public GameObject m_InspSkillEnhanceListNotItem;
    [Token(Token = "0x4008A92")]
    [FieldOffset(Offset = "0x274")]
    public GameObject m_InspSkillEnhanceSuccessEffect;
    [Token(Token = "0x4008A93")]
    [FieldOffset(Offset = "0x278")]
    public GameObject m_InspSkillEnhanceDetail;
    [Token(Token = "0x4008A94")]
    [FieldOffset(Offset = "0x27C")]
    public GameObject m_InspSkillEnhanceConfirmList;
    [Token(Token = "0x4008A95")]
    [FieldOffset(Offset = "0x280")]
    public GameObject m_InspSkillEnhanceConfirmListItem;
    [Token(Token = "0x4008A96")]
    [FieldOffset(Offset = "0x284")]
    public GameObject m_InspSkillEquipConfirm;
    [Token(Token = "0x4008A97")]
    [FieldOffset(Offset = "0x288")]
    public GameObject m_InspSkillResetConfirm;
    [Token(Token = "0x4008A98")]
    [FieldOffset(Offset = "0x28C")]
    public GameObject m_InspSkillResetBefore;
    [Token(Token = "0x4008A99")]
    [FieldOffset(Offset = "0x290")]
    public GameObject m_InspSkillResetAfter;
    [Token(Token = "0x4008A9A")]
    [FieldOffset(Offset = "0x294")]
    public Text m_InspSkillResetTitle;
    [Token(Token = "0x4008A9B")]
    [FieldOffset(Offset = "0x298")]
    public Text m_InspSkillResetText;
    [Token(Token = "0x4008A9C")]
    [FieldOffset(Offset = "0x29C")]
    public GameObject m_InspSkillEnhanceDetailList;
    [Token(Token = "0x4008A9D")]
    [FieldOffset(Offset = "0x2A0")]
    public GameObject m_InspSkillEnhanceDetailListItem;
    [Token(Token = "0x4008A9E")]
    [FieldOffset(Offset = "0x2A4")]
    public Text m_InspSkillSlotUnlockConfirmText;
    [Token(Token = "0x4008A9F")]
    [FieldOffset(Offset = "0x2A8")]
    private List<ArtifactData> m_SelectedArtifactList;
    [Token(Token = "0x4008AA0")]
    [FieldOffset(Offset = "0x2AC")]
    private InspirationSkillData m_CurrentInspSkill;
    [Token(Token = "0x4008AA1")]
    [FieldOffset(Offset = "0x2B0")]
    private List<GameObject> m_InspSkillItems;
    [Token(Token = "0x4008AA2")]
    [FieldOffset(Offset = "0x2B4")]
    private List<GameObject> m_InspSkillEnhanceItems;
    [Token(Token = "0x4008AA3")]
    [FieldOffset(Offset = "0x2B8")]
    private List<GameObject> m_InspSkillEnhanceConfirmItems;
    [Token(Token = "0x4008AA4")]
    [FieldOffset(Offset = "0x2BC")]
    private bool m_InspSkillIsResetMode;
    [Token(Token = "0x4008AA5")]
    [FieldOffset(Offset = "0x2C0")]
    [SerializeField]
    [HeaderBar("▼武輝石関連")]
    [Space(17f)]
    private Toggle mStoneEffectTab;
    [Token(Token = "0x4008AA6")]
    [FieldOffset(Offset = "0x2C4")]
    [SerializeField]
    private ExhibitList mStoneEffectExhibit;
    [Token(Token = "0x4008AA7")]
    [FieldOffset(Offset = "0x2C8")]
    [SerializeField]
    private Toggle mStoneEffectAddTab;
    [Token(Token = "0x4008AA8")]
    [FieldOffset(Offset = "0x2CC")]
    [SerializeField]
    private ExhibitList mStoneEffectExhibitAdd;
    [Token(Token = "0x4008AA9")]
    [FieldOffset(Offset = "0x2D0")]
    [SerializeField]
    [Space(18f)]
    [HeaderBar("▼変換関連")]
    private Button ExchangeButton;
    [Token(Token = "0x4008AAA")]
    [FieldOffset(Offset = "0x2D4")]
    [SerializeField]
    [Space(19f)]
    [HeaderBar("▼データ用")]
    private SerializeValueBehaviour mSVB;
    [Token(Token = "0x4008AAB")]
    [FieldOffset(Offset = "0x2D8")]
    private bool mIsEnbBtnArtiStrengthen;
    [Token(Token = "0x4008AAC")]
    [FieldOffset(Offset = "0xC")]
    private static readonly string NAME_SEARCH_WINDOW_UI_PATH;
    [Token(Token = "0x4008AAD")]
    [FieldOffset(Offset = "0x10")]
    private static readonly string NAME_SEARCH_SELECT_UI_PATH;
    [Token(Token = "0x4008AAE")]
    [FieldOffset(Offset = "0x2DC")]
    private string mNameSearchInput;
    [Token(Token = "0x4008AAF")]
    [FieldOffset(Offset = "0x2E0")]
    private SearchUtility.CONDITIONS mNameSearchType;
    [Token(Token = "0x4008AB0")]
    [FieldOffset(Offset = "0x14")]
    private static NameSearchBox mNameSearchBox;
    [Token(Token = "0x4008AB1")]
    [FieldOffset(Offset = "0x2E4")]
    [SerializeField]
    [HeaderBar("検索ボックス")]
    private GameObject mNameBoxParent;
    [Token(Token = "0x4008AB2")]
    [FieldOffset(Offset = "0x2E8")]
    [SerializeField]
    private ArtifactWindow.NAME_SEARCH_TYPE mNameBoxType;

    [Token(Token = "0x6008574")]
    [Address(RVA = "0x465260", Offset = "0x464060", VA = "0x10465260", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x170012FE")]
    public static ArtifactWindow Instance
    {
      [Token(Token = "0x6008575"), Address(RVA = "0x478270", Offset = "0x477070", VA = "0x10478270")] get
      {
        return (ArtifactWindow) null;
      }
    }

    [Token(Token = "0x170012FF")]
    public List<ItemData> TmpItems
    {
      [Token(Token = "0x6008576"), Address(RVA = "0x349620", Offset = "0x348420", VA = "0x10349620")] get
      {
        return (List<ItemData>) null;
      }
    }

    [Token(Token = "0x17001300")]
    public UnitData OwnerUnitData
    {
      [Token(Token = "0x6008577"), Address(RVA = "0x4782D0", Offset = "0x4770D0", VA = "0x104782D0")] get
      {
        return (UnitData) null;
      }
    }

    [Token(Token = "0x17001301")]
    public int OwnerUnitJobIndex
    {
      [Token(Token = "0x6008578"), Address(RVA = "0x4782E0", Offset = "0x4770E0", VA = "0x104782E0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17001302")]
    public ArtifactTypes SelectArtifactSlot
    {
      [Token(Token = "0x6008579"), Address(RVA = "0x3495F0", Offset = "0x3483F0", VA = "0x103495F0")] get
      {
        return new ArtifactTypes();
      }
      [Token(Token = "0x600857A"), Address(RVA = "0x478310", Offset = "0x477110", VA = "0x10478310")] set
      {
      }
    }

    [Token(Token = "0x600857B")]
    [Address(RVA = "0x4668B0", Offset = "0x4656B0", VA = "0x104668B0")]
    private void Awake()
    {
    }

    [Token(Token = "0x600857C")]
    [Address(RVA = "0x476570", Offset = "0x475370", VA = "0x10476570")]
    private void Start()
    {
    }

    [Token(Token = "0x600857D")]
    [Address(RVA = "0x46B570", Offset = "0x46A370", VA = "0x1046B570")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x600857E")]
    [Address(RVA = "0x467DE0", Offset = "0x466BE0", VA = "0x10467DE0")]
    private bool IsConnectableNetwork() => new bool();

    [Token(Token = "0x600857F")]
    [Address(RVA = "0x4678C0", Offset = "0x4666C0", VA = "0x104678C0")]
    private void FlushRequests(bool immediate)
    {
    }

    [Token(Token = "0x6008580")]
    [Address(RVA = "0x468C00", Offset = "0x467A00", VA = "0x10468C00")]
    private void OnApplicationPause(bool pausing)
    {
    }

    [Token(Token = "0x6008581")]
    [Address(RVA = "0x468BE0", Offset = "0x4679E0", VA = "0x10468BE0")]
    private void OnApplicationFocus(bool focus)
    {
    }

    [Token(Token = "0x6008582")]
    private bool IsRequestPending<T>() => new bool();

    [Token(Token = "0x6008583")]
    [Address(RVA = "0x477BD0", Offset = "0x4769D0", VA = "0x10477BD0")]
    private void Update()
    {
    }

    [Token(Token = "0x6008584")]
    [Address(RVA = "0x472B70", Offset = "0x471970", VA = "0x10472B70")]
    public void RefreshKyokaList()
    {
    }

    [Token(Token = "0x6008585")]
    [Address(RVA = "0x46C1A0", Offset = "0x46AFA0", VA = "0x1046C1A0")]
    private void OnKyokaItemSelect(GameObject go)
    {
    }

    [Token(Token = "0x6008586")]
    [Address(RVA = "0x468C20", Offset = "0x467A20", VA = "0x10468C20")]
    private void OnArtifactBulkLevelUp(Dictionary<string, int> data)
    {
    }

    [Token(Token = "0x6008587")]
    [Address(RVA = "0x474640", Offset = "0x473440", VA = "0x10474640")]
    private void RequestUseAddExpItem(ItemData item, GameObject updataTarget)
    {
    }

    [Token(Token = "0x6008588")]
    [Address(RVA = "0x4746C0", Offset = "0x4734C0", VA = "0x104746C0")]
    private void RequestUseAddExpItem(IEnumerable<ItemData> itemList, GameObject updataTarget)
    {
    }

    [Token(Token = "0x6008589")]
    [Address(RVA = "0x465DD0", Offset = "0x464BD0", VA = "0x10465DD0")]
    private void AddExpResult(WWWResult www)
    {
    }

    [Token(Token = "0x600858A")]
    [Address(RVA = "0x470740", Offset = "0x46F540", VA = "0x10470740")]
    public void RefreshArtifactList()
    {
    }

    [Token(Token = "0x600858B")]
    [Address(RVA = "0x468ED0", Offset = "0x467CD0", VA = "0x10468ED0")]
    private void OnArtifactSelect(ArtifactList list)
    {
    }

    [Token(Token = "0x600858C")]
    [Address(RVA = "0x4697C0", Offset = "0x4685C0", VA = "0x104697C0")]
    private void OnArtifactSelect(ArtifactScrollList list)
    {
    }

    [Token(Token = "0x600858D")]
    [Address(RVA = "0x46F130", Offset = "0x46DF30", VA = "0x1046F130")]
    public void RefreshAbilities()
    {
    }

    [Token(Token = "0x600858E")]
    [Address(RVA = "0x475C80", Offset = "0x474A80", VA = "0x10475C80")]
    public void ShowSelection()
    {
    }

    [Token(Token = "0x600858F")]
    [Address(RVA = "0x473A70", Offset = "0x472870", VA = "0x10473A70")]
    public void RefreshWindow()
    {
    }

    [Token(Token = "0x6008590")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
    private void OnLevelChange(int prev, int next)
    {
    }

    [Token(Token = "0x6008591")]
    [Address(RVA = "0x46BFA0", Offset = "0x46ADA0", VA = "0x1046BFA0")]
    private void OnKyokaEnd()
    {
    }

    [Token(Token = "0x6008592")]
    [Address(RVA = "0x466590", Offset = "0x465390", VA = "0x10466590")]
    public void AddRarity()
    {
    }

    [Token(Token = "0x6008593")]
    [Address(RVA = "0x467E70", Offset = "0x466C70", VA = "0x10467E70")]
    private void OnAddRarityAccept(GameObject go)
    {
    }

    [Token(Token = "0x6008594")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
    private void OnAddRarityCancel(GameObject go)
    {
    }

    [Token(Token = "0x6008595")]
    [Address(RVA = "0x466210", Offset = "0x465010", VA = "0x10466210")]
    private IEnumerator AddRareAsync() => (IEnumerator) null;

    [Token(Token = "0x6008596")]
    [Address(RVA = "0x465A00", Offset = "0x464800", VA = "0x10465A00")]
    private void AddAsyncRequest(ArtifactWindow.Request req)
    {
    }

    [Token(Token = "0x6008597")]
    [Address(RVA = "0x466270", Offset = "0x465070", VA = "0x10466270")]
    private void AddRarityResult(WWWResult www)
    {
    }

    [Token(Token = "0x6008598")]
    [Address(RVA = "0x4707E0", Offset = "0x46F5E0", VA = "0x104707E0")]
    public void RefreshDecomposeInfo()
    {
    }

    [Token(Token = "0x6008599")]
    [Address(RVA = "0x473680", Offset = "0x472480", VA = "0x10473680")]
    public void RefreshTransmuteInfo()
    {
    }

    [Token(Token = "0x600859A")]
    [Address(RVA = "0x4730A0", Offset = "0x471EA0", VA = "0x104730A0")]
    public void RefreshRarityUpInfo()
    {
    }

    [Token(Token = "0x600859B")]
    [Address(RVA = "0x477070", Offset = "0x475E70", VA = "0x10477070")]
    public void TransmuteArtifact()
    {
    }

    [Token(Token = "0x600859C")]
    [Address(RVA = "0x46E5A0", Offset = "0x46D3A0", VA = "0x1046E5A0")]
    private void OnTransmuteAccept(GameObject go)
    {
    }

    [Token(Token = "0x600859D")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
    private void OnTransmuteCancel(GameObject go)
    {
    }

    [Token(Token = "0x600859E")]
    [Address(RVA = "0x46E9B0", Offset = "0x46D7B0", VA = "0x1046E9B0")]
    private void OnTransmuteResult(WWWResult www)
    {
    }

    [Token(Token = "0x600859F")]
    [Address(RVA = "0x476280", Offset = "0x475080", VA = "0x10476280")]
    private void ShowTransmuteResult()
    {
    }

    [Token(Token = "0x60085A0")]
    [Address(RVA = "0x476210", Offset = "0x475010", VA = "0x10476210")]
    private IEnumerator ShowTransmuteResultAsync(ChangeListData[] changeset) => (IEnumerator) null;

    [Token(Token = "0x60085A1")]
    [Address(RVA = "0x467BB0", Offset = "0x4669B0", VA = "0x10467BB0")]
    private ArtifactData[] GetSelectedArtifacts() => (ArtifactData[]) null;

    [Token(Token = "0x60085A2")]
    [Address(RVA = "0x466970", Offset = "0x465770", VA = "0x10466970")]
    private long CalcDecomposeCost(ArtifactData[] artifacts) => new long();

    [Token(Token = "0x60085A3")]
    [Address(RVA = "0x466F30", Offset = "0x465D30", VA = "0x10466F30")]
    public void DecomposeArtifact()
    {
    }

    [Token(Token = "0x60085A4")]
    [Address(RVA = "0x46AFE0", Offset = "0x469DE0", VA = "0x1046AFE0")]
    private void OnDecomposeRarityCheck(GameObject go)
    {
    }

    [Token(Token = "0x60085A5")]
    [Address(RVA = "0x46AC80", Offset = "0x469A80", VA = "0x1046AC80")]
    private void OnDecomposeAccept(GameObject go)
    {
    }

    [Token(Token = "0x60085A6")]
    [Address(RVA = "0x46A630", Offset = "0x469430", VA = "0x1046A630")]
    private void OnDecomposeAccept2(GameObject go)
    {
    }

    [Token(Token = "0x60085A7")]
    [Address(RVA = "0x46AF10", Offset = "0x469D10", VA = "0x1046AF10")]
    private void OnDecomposeCancel(GameObject go)
    {
    }

    [Token(Token = "0x60085A8")]
    [Address(RVA = "0x46B260", Offset = "0x46A060", VA = "0x1046B260")]
    private void OnDecomposeResult(WWWResult www)
    {
    }

    [Token(Token = "0x60085A9")]
    [Address(RVA = "0x475AC0", Offset = "0x4748C0", VA = "0x10475AC0")]
    private void ShowDecomposeResult()
    {
    }

    [Token(Token = "0x60085AA")]
    [Address(RVA = "0x475A60", Offset = "0x474860", VA = "0x10475A60")]
    private IEnumerator ShowDecomposeResultAsync() => (IEnumerator) null;

    [Token(Token = "0x60085AB")]
    [Address(RVA = "0x474FB0", Offset = "0x473DB0", VA = "0x10474FB0")]
    public void SellArtifacts()
    {
    }

    [Token(Token = "0x60085AC")]
    [Address(RVA = "0x46DD20", Offset = "0x46CB20", VA = "0x1046DD20")]
    private void OnSellRarityCheck(GameObject go)
    {
    }

    [Token(Token = "0x60085AD")]
    [Address(RVA = "0x46DA20", Offset = "0x46C820", VA = "0x1046DA20")]
    private void OnSellAccept(GameObject go)
    {
    }

    [Token(Token = "0x60085AE")]
    [Address(RVA = "0x46D750", Offset = "0x46C550", VA = "0x1046D750")]
    private void OnSellAccept2(GameObject go)
    {
    }

    [Token(Token = "0x60085AF")]
    [Address(RVA = "0x46DC60", Offset = "0x46CA60", VA = "0x1046DC60")]
    private void OnSellCancel(GameObject go)
    {
    }

    [Token(Token = "0x60085B0")]
    [Address(RVA = "0x46DFB0", Offset = "0x46CDB0", VA = "0x1046DFB0")]
    private void OnSellResult(WWWResult www)
    {
    }

    [Token(Token = "0x60085B1")]
    [Address(RVA = "0x475FF0", Offset = "0x474DF0", VA = "0x10475FF0")]
    private void ShowSellResult()
    {
    }

    [Token(Token = "0x60085B2")]
    [Address(RVA = "0x465A60", Offset = "0x464860", VA = "0x10465A60")]
    private void AddCurrencyChangeSet(CurrencyTracker track, List<ChangeListData> changeset)
    {
    }

    [Token(Token = "0x60085B3")]
    [Address(RVA = "0x466AE0", Offset = "0x4658E0", VA = "0x10466AE0")]
    private void CreateItemChangeSet(Dictionary<ItemParam, int> snapshot)
    {
    }

    [Token(Token = "0x60085B4")]
    [Address(RVA = "0x4756A0", Offset = "0x4744A0", VA = "0x104756A0")]
    public void SetOwnerUnit(UnitData unit, int jobIndex)
    {
    }

    [Token(Token = "0x60085B5")]
    [Address(RVA = "0x467440", Offset = "0x466240", VA = "0x10467440")]
    public void EquipArtifact()
    {
    }

    [Token(Token = "0x60085B6")]
    [Address(RVA = "0x46BAC0", Offset = "0x46A8C0", VA = "0x1046BAC0")]
    private void OnEquipArtifactAccept(GameObject go)
    {
    }

    [Token(Token = "0x60085B7")]
    [Address(RVA = "0x467420", Offset = "0x466220", VA = "0x10467420")]
    private void EndEquip()
    {
    }

    [Token(Token = "0x60085B8")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
    private void OnEquipArtifactCancel(GameObject go)
    {
    }

    [Token(Token = "0x60085B9")]
    [Address(RVA = "0x477970", Offset = "0x476770", VA = "0x10477970")]
    public void UnequipArtifact()
    {
    }

    [Token(Token = "0x60085BA")]
    [Address(RVA = "0x475B90", Offset = "0x474990", VA = "0x10475B90")]
    public void ShowDetail()
    {
    }

    [Token(Token = "0x60085BB")]
    [Address(RVA = "0x475B30", Offset = "0x474930", VA = "0x10475B30")]
    private IEnumerator ShowDetailAsync() => (IEnumerator) null;

    [Token(Token = "0x60085BC")]
    [Address(RVA = "0x46C4E0", Offset = "0x46B2E0", VA = "0x1046C4E0")]
    private bool OnSceneCHange() => new bool();

    [Token(Token = "0x60085BD")]
    [Address(RVA = "0x46C5C0", Offset = "0x46B3C0", VA = "0x1046C5C0")]
    private IEnumerator OnSceneChangeAsync() => (IEnumerator) null;

    [Token(Token = "0x60085BE")]
    [Address(RVA = "0x476F60", Offset = "0x475D60", VA = "0x10476F60")]
    private void SyncArtifactData()
    {
    }

    [Token(Token = "0x60085BF")]
    [Address(RVA = "0x477A50", Offset = "0x476850", VA = "0x10477A50")]
    private void UpdateArtifactOwner()
    {
    }

    [Token(Token = "0x60085C0")]
    [Address(RVA = "0x46ED60", Offset = "0x46DB60", VA = "0x1046ED60")]
    private void Rebind()
    {
    }

    [Token(Token = "0x17001303")]
    private bool IsBusy
    {
      [Token(Token = "0x60085C1"), Address(RVA = "0x4782B0", Offset = "0x4770B0", VA = "0x104782B0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x60085C2")]
    [Address(RVA = "0x475210", Offset = "0x474010", VA = "0x10475210")]
    public void SetArtifactData()
    {
    }

    [Token(Token = "0x60085C3")]
    [Address(RVA = "0x46BC20", Offset = "0x46AA20", VA = "0x1046BC20")]
    public void OnExpMaxOpen(SRPG_Button button)
    {
    }

    [Token(Token = "0x60085C4")]
    [Address(RVA = "0x46BED0", Offset = "0x46ACD0", VA = "0x1046BED0")]
    public void OnKakeraCreateOnlyValueChanged(bool isOn)
    {
    }

    [Token(Token = "0x60085C5")]
    [Address(RVA = "0x46BB40", Offset = "0x46A940", VA = "0x1046BB40")]
    public void OnExcludeEquipedValueChanged(bool isOn)
    {
    }

    [Token(Token = "0x60085C6")]
    [Address(RVA = "0x46BB20", Offset = "0x46A920", VA = "0x1046BB20")]
    public void OnEquipedSortValueChanged(bool isOn)
    {
    }

    [Token(Token = "0x60085C7")]
    [Address(RVA = "0x473490", Offset = "0x472290", VA = "0x10473490")]
    private void RefreshSortFilter()
    {
    }

    [Token(Token = "0x60085C8")]
    [Address(RVA = "0x46ED00", Offset = "0x46DB00", VA = "0x1046ED00")]
    private bool ReadExcludeEquipedSettingValue() => new bool();

    [Token(Token = "0x60085C9")]
    [Address(RVA = "0x477DA0", Offset = "0x476BA0", VA = "0x10477DA0")]
    private void WriteExcludeEquipedSettingValue(bool isOn)
    {
    }

    [Token(Token = "0x60085CA")]
    [Address(RVA = "0x471980", Offset = "0x470780", VA = "0x10471980")]
    public void RefreshInspSkillEnhance()
    {
    }

    [Token(Token = "0x60085CB")]
    [Address(RVA = "0x472AE0", Offset = "0x4718E0", VA = "0x10472AE0")]
    public void RefreshInspSkill(bool resetmode = false)
    {
    }

    [Token(Token = "0x60085CC")]
    [Address(RVA = "0x471E40", Offset = "0x470C40", VA = "0x10471E40")]
    public void RefreshInspSkillList(bool resetmode = false)
    {
    }

    [Token(Token = "0x60085CD")]
    [Address(RVA = "0x471310", Offset = "0x470110", VA = "0x10471310")]
    public void RefreshInspSkillEnhanceList()
    {
    }

    [Token(Token = "0x60085CE")]
    [Address(RVA = "0x4710D0", Offset = "0x46FED0", VA = "0x104710D0")]
    private void RefreshInspSkillEnhanceListNotSelect(bool active = true)
    {
    }

    [Token(Token = "0x60085CF")]
    [Address(RVA = "0x46C620", Offset = "0x46B420", VA = "0x1046C620")]
    private void OnSelectEnhanceInspSkill(GameObject go)
    {
    }

    [Token(Token = "0x60085D0")]
    [Address(RVA = "0x46CD40", Offset = "0x46BB40", VA = "0x1046CD40")]
    private void OnSelectEquipInspSkill(GameObject go)
    {
    }

    [Token(Token = "0x60085D1")]
    [Address(RVA = "0x46CEA0", Offset = "0x46BCA0", VA = "0x1046CEA0")]
    private void OnSelectResetInspSkill(GameObject go)
    {
    }

    [Token(Token = "0x60085D2")]
    [Address(RVA = "0x46C680", Offset = "0x46B480", VA = "0x1046C680")]
    private void OnSelectEnhanceListItem(GameObject go)
    {
    }

    [Token(Token = "0x60085D3")]
    [Address(RVA = "0x46D350", Offset = "0x46C150", VA = "0x1046D350")]
    private void OnSelectUnlockInspSkill(GameObject go)
    {
    }

    [Token(Token = "0x60085D4")]
    [Address(RVA = "0x466A20", Offset = "0x465820", VA = "0x10466A20")]
    private bool CheckCost(InspSkillCostParam cost) => new bool();

    [Token(Token = "0x60085D5")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
    private void OnOpenInspirationSkillDetail(GameObject go)
    {
    }

    [Token(Token = "0x60085D6")]
    [Address(RVA = "0x46A040", Offset = "0x468E40", VA = "0x1046A040")]
    private void OnConfirmInspSkillEnhance()
    {
    }

    [Token(Token = "0x60085D7")]
    [Address(RVA = "0x46C350", Offset = "0x46B150", VA = "0x1046C350")]
    private void OnResetEnhanceListItem()
    {
    }

    [Token(Token = "0x60085D8")]
    [Address(RVA = "0x46E310", Offset = "0x46D110", VA = "0x1046E310")]
    private void OnSuccessInspSkillEnhance()
    {
    }

    [Token(Token = "0x60085D9")]
    [Address(RVA = "0x471000", Offset = "0x46FE00", VA = "0x10471000")]
    public void RefreshExchange()
    {
    }

    [Token(Token = "0x60085DA")]
    [Address(RVA = "0x471000", Offset = "0x46FE00", VA = "0x10471000")]
    public void RefreshExchangeButton()
    {
    }

    [Token(Token = "0x60085DB")]
    [Address(RVA = "0x467DF0", Offset = "0x466BF0", VA = "0x10467DF0")]
    public bool IsExchange() => new bool();

    [Token(Token = "0x60085DC")]
    [Address(RVA = "0x475890", Offset = "0x474690", VA = "0x10475890")]
    public bool SetStoneEffectLottery() => new bool();

    [Token(Token = "0x60085DD")]
    [Address(RVA = "0x4754D0", Offset = "0x4742D0", VA = "0x104754D0")]
    public bool SetExchangeData() => new bool();

    [Token(Token = "0x17001304")]
    public bool IsEnbBtnArtiStrengthen
    {
      [Token(Token = "0x60085DE"), Address(RVA = "0x4782F0", Offset = "0x4770F0", VA = "0x104782F0")] set
      {
      }
    }

    [Token(Token = "0x60085DF")]
    [Address(RVA = "0x46F0B0", Offset = "0x46DEB0", VA = "0x1046F0B0")]
    private void ReflectEnbBtnArtiStrengthen()
    {
    }

    [Token(Token = "0x60085E0")]
    [Address(RVA = "0x475290", Offset = "0x474090", VA = "0x10475290")]
    public void SetArtifactType(ArtifactTypes type)
    {
    }

    [Token(Token = "0x60085E1")]
    [Address(RVA = "0x475460", Offset = "0x474260", VA = "0x10475460")]
    public string[] SetEquipArtifactFilters(
      JobData job,
      ArtifactData data,
      ArtifactTypes select_slot_artifact_type = ArtifactTypes.None)
    {
      return (string[]) null;
    }

    [Token(Token = "0x60085E2")]
    [Address(RVA = "0x4752B0", Offset = "0x4740B0", VA = "0x104752B0")]
    public string[] SetEquipArtifactFiltersOnly(
      JobData job,
      ArtifactData data,
      ArtifactTypes select_slot_artifact_type = ArtifactTypes.None,
      bool only = false)
    {
      return (string[]) null;
    }

    [Token(Token = "0x60085E3")]
    [Address(RVA = "0x46C270", Offset = "0x46B070", VA = "0x1046C270")]
    public void OnOpenProcessWindow(GameObject icon)
    {
    }

    [Token(Token = "0x17001305")]
    public string NameSearchInput
    {
      [Token(Token = "0x60085E4"), Address(RVA = "0x3490A0", Offset = "0x347EA0", VA = "0x103490A0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17001306")]
    public SearchUtility.CONDITIONS NameSearchType
    {
      [Token(Token = "0x60085E5"), Address(RVA = "0x3495A0", Offset = "0x3483A0", VA = "0x103495A0")] get
      {
        return new SearchUtility.CONDITIONS();
      }
    }

    [Token(Token = "0x60085E6")]
    [Address(RVA = "0x466D80", Offset = "0x465B80", VA = "0x10466D80")]
    public void CreateNameSearchBox()
    {
    }

    [Token(Token = "0x60085E7")]
    [Address(RVA = "0x4672C0", Offset = "0x4660C0", VA = "0x104672C0")]
    public void DeleteNameSearchBox()
    {
    }

    [Token(Token = "0x60085E8")]
    [Address(RVA = "0x467A40", Offset = "0x466840", VA = "0x10467A40")]
    public void GetNameSearchString()
    {
    }

    [Token(Token = "0x60085E9")]
    [Address(RVA = "0x467B00", Offset = "0x466900", VA = "0x10467B00")]
    public void GetNameSearchType()
    {
    }

    [Token(Token = "0x60085EA")]
    [Address(RVA = "0x477F30", Offset = "0x476D30", VA = "0x10477F30")]
    public ArtifactWindow()
    {
    }

    [Token(Token = "0x60085EB")]
    [Address(RVA = "0x477E00", Offset = "0x476C00", VA = "0x10477E00")]
    static ArtifactWindow()
    {
    }

    [Token(Token = "0x200203B")]
    public delegate void EquipEvent(ArtifactData artifact, ArtifactTypes type = ArtifactTypes.None);

    [Token(Token = "0x200203C")]
    private class StatusCache
    {
      [Token(Token = "0x4008AB3")]
      [FieldOffset(Offset = "0x8")]
      public BaseStatus BaseAdd;
      [Token(Token = "0x4008AB4")]
      [FieldOffset(Offset = "0xC")]
      public BaseStatus BaseMul;
      [Token(Token = "0x4008AB5")]
      [FieldOffset(Offset = "0x10")]
      public BaseStatus UnitAdd;
      [Token(Token = "0x4008AB6")]
      [FieldOffset(Offset = "0x14")]
      public BaseStatus UnitMul;

      [Token(Token = "0x60085FA")]
      [Address(RVA = "0x48A390", Offset = "0x489190", VA = "0x1048A390")]
      public StatusCache()
      {
      }
    }

    [Token(Token = "0x200203D")]
    private abstract class Request
    {
      [Token(Token = "0x4008AB7")]
      [FieldOffset(Offset = "0x8")]
      public Network.ResponseCallback Callback;

      [Token(Token = "0x60085FB")]
      public abstract WebAPI Compose();

      [Token(Token = "0x60085FC")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      protected Request()
      {
      }
    }

    [Token(Token = "0x200203E")]
    private class RequestAddRare : ArtifactWindow.Request
    {
      [Token(Token = "0x4008AB8")]
      [FieldOffset(Offset = "0xC")]
      public ReqArtifactAddRare.Request request_data;
      [Token(Token = "0x4008AB9")]
      [FieldOffset(Offset = "0x10")]
      public string trophyProgs;
      [Token(Token = "0x4008ABA")]
      [FieldOffset(Offset = "0x14")]
      public string bingoProgs;

      [Token(Token = "0x60085FD")]
      [Address(RVA = "0x48A2C0", Offset = "0x4890C0", VA = "0x1048A2C0", Slot = "4")]
      public override WebAPI Compose() => (WebAPI) null;

      [Token(Token = "0x60085FE")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public RequestAddRare()
      {
      }
    }

    [Token(Token = "0x200203F")]
    private class RequestAddExp : ArtifactWindow.Request
    {
      [Token(Token = "0x4008ABB")]
      [FieldOffset(Offset = "0x10")]
      public long UniqueID;
      [Token(Token = "0x4008ABC")]
      [FieldOffset(Offset = "0x18")]
      public List<ItemParam> Items;

      [Token(Token = "0x60085FF")]
      [Address(RVA = "0x48A080", Offset = "0x488E80", VA = "0x1048A080", Slot = "4")]
      public override WebAPI Compose() => (WebAPI) null;

      [Token(Token = "0x6008600")]
      [Address(RVA = "0x48A240", Offset = "0x489040", VA = "0x1048A240")]
      public RequestAddExp()
      {
      }
    }

    [Token(Token = "0x2002040")]
    private enum InspSkillState : byte
    {
      [Token(Token = "0x4008ABE")] NONE,
      [Token(Token = "0x4008ABF")] LOCK,
      [Token(Token = "0x4008AC0")] UNLOCK,
      [Token(Token = "0x4008AC1")] LEANED,
    }

    [Token(Token = "0x2002041")]
    private enum NAME_SEARCH_TYPE
    {
      [Token(Token = "0x4008AC3")] WINDOW,
      [Token(Token = "0x4008AC4")] SELECT,
    }
  }
}
