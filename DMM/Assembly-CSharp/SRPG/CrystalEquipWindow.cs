// Decompiled with JetBrains decompiler
// Type: SRPG.CrystalEquipWindow
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG.Exhibit;
using SRPG.Models;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20022BA")]
  [AddComponentMenu("UI/Crystal/Wondow/CrystalEquipWindow")]
  [FlowNode.Pin(201, "幻影記憶の全解除開始", FlowNode.PinTypes.Output, 201)]
  [FlowNode.Pin(1, "初期化", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(4, "幻影記憶の全解除", FlowNode.PinTypes.Input, 4)]
  [FlowNode.Pin(3, "セットボーナス一覧", FlowNode.PinTypes.Input, 3)]
  [FlowNode.Pin(2, "更新", FlowNode.PinTypes.Input, 2)]
  [FlowNode.Pin(101, "セットボーナス一覧展開", FlowNode.PinTypes.Output, 101)]
  public class CrystalEquipWindow : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x4009A9F")]
    private const string IS_UNIT_TOOLTIP = "IS_UNIT_TOOLTIP";
    [Token(Token = "0x4009AA0")]
    private const int PIN_INPUT_INIT = 1;
    [Token(Token = "0x4009AA1")]
    private const int PIN_INPUT_REFRESH = 2;
    [Token(Token = "0x4009AA2")]
    private const int PIN_INPUT_SET_BONUS_LIST = 3;
    [Token(Token = "0x4009AA3")]
    private const int PIN_INPUT_UNEQUIP_ALL = 4;
    [Token(Token = "0x4009AA4")]
    private const int PIN_OUTPUT_SET_BONUS_LIST = 101;
    [Token(Token = "0x4009AA5")]
    private const int PIN_OUTPUT_UNEQUIP_ALL = 201;
    [Token(Token = "0x4009AA6")]
    [FieldOffset(Offset = "0xC")]
    private readonly string CRYSTAL_SELECT_WINDOW_PREFAB_PATH;
    [Token(Token = "0x4009AA7")]
    [FieldOffset(Offset = "0x10")]
    private readonly string CRYSTAL_LOCK_TOOLTIP_PREFAB_PATH;
    [Token(Token = "0x4009AA8")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private List<CrystalEquipSlot> SlotList;
    [Token(Token = "0x4009AA9")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private CrystalStatusList StatusList;
    [Token(Token = "0x4009AAA")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private Toggle BaseStatusToggle;
    [Token(Token = "0x4009AAB")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Toggle OtherStatusToggle;
    [Token(Token = "0x4009AAC")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    private ContentExhibit SetBonusExhibit;
    [Token(Token = "0x4009AAD")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private Button RecommendButton;
    [Token(Token = "0x4009AAE")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    private Button ReleaseButton;
    [Token(Token = "0x4009AAF")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private GameObject ReplaceButton;
    [Token(Token = "0x4009AB0")]
    [FieldOffset(Offset = "0x34")]
    [HideInInspector]
    public List<ParamTypes> BaseStatusList;
    [Token(Token = "0x4009AB1")]
    [FieldOffset(Offset = "0x38")]
    private UnitData mUnitData;
    [Token(Token = "0x4009AB2")]
    [FieldOffset(Offset = "0x3C")]
    private Tooltip mCrystalLockTooltip;
    [Token(Token = "0x4009AB3")]
    [FieldOffset(Offset = "0x40")]
    private CrystalEquipWindow.ToggleType mToggleType;
    [Token(Token = "0x4009AB4")]
    [FieldOffset(Offset = "0x44")]
    private List<CrystalSetBonusWindowModel> mModels;

    [Token(Token = "0x6009517")]
    [Address(RVA = "0x580580", Offset = "0x57F380", VA = "0x10580580", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x6009518")]
    [Address(RVA = "0x580800", Offset = "0x57F600", VA = "0x10580800")]
    private void Awake()
    {
    }

    [Token(Token = "0x6009519")]
    [Address(RVA = "0x580E20", Offset = "0x57FC20", VA = "0x10580E20")]
    private void OnDestory()
    {
    }

    [Token(Token = "0x600951A")]
    [Address(RVA = "0x580870", Offset = "0x57F670", VA = "0x10580870")]
    private void Initialize()
    {
    }

    [Token(Token = "0x600951B")]
    [Address(RVA = "0x5814A0", Offset = "0x5802A0", VA = "0x105814A0")]
    private void Refresh()
    {
    }

    [Token(Token = "0x600951C")]
    [Address(RVA = "0x581820", Offset = "0x580620", VA = "0x10581820")]
    private void Setup()
    {
    }

    [Token(Token = "0x600951D")]
    [Address(RVA = "0x5814B0", Offset = "0x5802B0", VA = "0x105814B0")]
    private void SelectSetBonusListBtn()
    {
    }

    [Token(Token = "0x600951E")]
    [Address(RVA = "0x580FF0", Offset = "0x57FDF0", VA = "0x10580FF0")]
    private void OnUnequipAllSlotButton()
    {
    }

    [Token(Token = "0x600951F")]
    [Address(RVA = "0x580E80", Offset = "0x57FC80", VA = "0x10580E80")]
    private void OnEquipCrystalSlotSelect(GenericSlot slot, bool interactable)
    {
    }

    [Token(Token = "0x6009520")]
    [Address(RVA = "0x581D00", Offset = "0x580B00", VA = "0x10581D00")]
    private void ShowLockEquipCrystalSlotSelect(int _index)
    {
    }

    [Token(Token = "0x6009521")]
    [Address(RVA = "0x581550", Offset = "0x580350", VA = "0x10581550")]
    private void SetBaseStatus(bool isOn)
    {
    }

    [Token(Token = "0x6009522")]
    [Address(RVA = "0x5817F0", Offset = "0x5805F0", VA = "0x105817F0")]
    private void SetOtherStatus(bool isOn)
    {
    }

    [Token(Token = "0x6009523")]
    [Address(RVA = "0x581580", Offset = "0x580380", VA = "0x10581580")]
    private void SetBonusDisp()
    {
    }

    [Token(Token = "0x6009524")]
    [Address(RVA = "0x580A10", Offset = "0x57F810", VA = "0x10580A10")]
    private bool IsDispRecommendButton() => new bool();

    [Token(Token = "0x6009525")]
    [Address(RVA = "0x580D10", Offset = "0x57FB10", VA = "0x10580D10")]
    private bool IsDispReleaseButton() => new bool();

    [Token(Token = "0x6009526")]
    [Address(RVA = "0x582040", Offset = "0x580E40", VA = "0x10582040")]
    public CrystalEquipWindow()
    {
    }

    [Token(Token = "0x20022BB")]
    public enum ToggleType
    {
      [Token(Token = "0x4009AB6")] BaseStatus,
      [Token(Token = "0x4009AB7")] OtherStatus,
    }
  }
}
