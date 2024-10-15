// Decompiled with JetBrains decompiler
// Type: SRPG.UnitToolTipWindowEx
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG.Exhibit;
using SRPG.Models;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002D22")]
  [AddComponentMenu("UI/UnitToolTipWindowEx")]
  [FlowNode.Pin(1, "初期化", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(11, "更新", FlowNode.PinTypes.Input, 11)]
  [FlowNode.Pin(21, "刻印装備", FlowNode.PinTypes.Input, 21)]
  public class UnitToolTipWindowEx : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400E0D0")]
    private const int PIN_IN_INIT = 1;
    [Token(Token = "0x400E0D1")]
    private const int PIN_IN_REFRESH = 11;
    [Token(Token = "0x400E0D2")]
    private const int PIN_IN_RUNES = 21;
    [Token(Token = "0x400E0D3")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private ExhibitList mExhibitList;
    [Token(Token = "0x400E0D4")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public string PATH_RUNE_INVENTORY_WINDOW;
    [Token(Token = "0x400E0D5")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public GameObject mRuneButton;
    [Token(Token = "0x400E0D6")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public GameObject mAutoSkillButton;
    [Token(Token = "0x400E0D7")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private SerializeValueBehaviour mSerializeValueBehaviour;
    [Token(Token = "0x400E0D8")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private NamePlate mNamePlate;
    [Token(Token = "0x400E0D9")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    private UnitJobListPullDown mUnitJobList;
    [Token(Token = "0x400E0DA")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private UnitIconPanel mUnitIconPanel;
    [Token(Token = "0x400E0DB")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    private ConceptCardSlotsEx mConceptCardSlots;
    [Token(Token = "0x400E0DC")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private ArtifactSlotsEx mArtifactSlots;
    [Token(Token = "0x400E0DD")]
    [FieldOffset(Offset = "0x34")]
    [SerializeField]
    private CrystalUnitTooltipSlot mMainCrystalSlot;
    [Token(Token = "0x400E0DE")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private LeaderSkillSlot mLeaderSkillSlot;
    [Token(Token = "0x400E0DF")]
    [FieldOffset(Offset = "0x3C")]
    [SerializeField]
    private UnitStatusPanelGroup mUnitStatusPanelGroup;
    [Token(Token = "0x400E0E0")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private AbilitySlotsEx mAbilitySlots;
    [Token(Token = "0x400E0E1")]
    [FieldOffset(Offset = "0x44")]
    private RuneInventory mRuneInventoryWindow;
    [Token(Token = "0x400E0E2")]
    [FieldOffset(Offset = "0x48")]
    private UnitToolTipWindowExModel mModel;
    [Token(Token = "0x400E0E3")]
    public const string KEY_TOOLTIP_UNIT = "KEY_TOOLTIP_UNIT";
    [Token(Token = "0x400E0E4")]
    public const string KEY_TOOLTIP_UNIT_ID = "KEY_TOOLTIP_UNIT_ID";
    [Token(Token = "0x400E0E5")]
    public const string KEY_TOOLTIP_UNIT_ID_REFRESH = "KEY_TOOLTIP_UNIT_ID_REFRESH";
    [Token(Token = "0x400E0E6")]
    public const string KEY_TOOLTIP_OVERWRITE_PARTY = "KEY_TOOLTIP_OVERWRITE_PARTY";
    [Token(Token = "0x400E0E7")]
    public const string KEY_TOOLTIP_EDIT_MODE = "KEY_TOOLTIP_EDIT_MODE";
    [Token(Token = "0x400E0E8")]
    public const string KEY_TOOLTIP_HIDE_MODE_UNIT_ELEMENT = "KEY_TOOLTIP_HIDE_MODE_UNIT_ELEMENT";
    [Token(Token = "0x400E0E9")]
    public const string KEY_TOOLTIP_HIDE_MODE_UNIT_NAME = "KEY_TOOLTIP_HIDE_MODE_UNIT_NAME";
    [Token(Token = "0x400E0EA")]
    public const string KEY_TOOLTIP_HIDE_MODE_UNIT_BIRTH = "KEY_TOOLTIP_HIDE_MODE_UNIT_BIRTH";
    [Token(Token = "0x400E0EB")]
    public const string KEY_TOOLTIP_HIDE_MODE_UNIT_ICON = "KEY_TOOLTIP_HIDE_MODE_UNIT_ICON";
    [Token(Token = "0x400E0EC")]
    public const string KEY_TOOLTIP_HIDE_MODE_UNIT_RARITY = "KEY_TOOLTIP_HIDE_MODE_UNIT_RARITY";
    [Token(Token = "0x400E0ED")]
    public const string KEY_TOOLTIP_HIDE_MODE_UNIT_LEVEL = "KEY_TOOLTIP_HIDE_MODE_UNIT_LEVEL";
    [Token(Token = "0x400E0EE")]
    public const string KEY_TOOLTIP_HIDE_MODE_UNIT_JOB = "KEY_TOOLTIP_HIDE_MODE_UNIT_JOB";
    [Token(Token = "0x400E0EF")]
    public const string KEY_TOOLTIP_HIDE_MODE_UNIT_CONCEPTCARD = "KEY_TOOLTIP_HIDE_MODE_UNIT_CONCEPTCARD";
    [Token(Token = "0x400E0F0")]
    public const string KEY_TOOLTIP_HIDE_MODE_UNIT_ARTIFACT = "KEY_TOOLTIP_HIDE_MODE_UNIT_ARTIFACT";
    [Token(Token = "0x400E0F1")]
    public const string KEY_TOOLTIP_HIDE_MODE_UNIT_CRYSTAL = "KEY_TOOLTIP_HIDE_MODE_UNIT_CRYSTAL";
    [Token(Token = "0x400E0F2")]
    public const string KEY_TOOLTIP_HIDE_MODE_UNIT_LEADERSKILL = "KEY_TOOLTIP_HIDE_MODE_UNIT_LEADERSKILL";
    [Token(Token = "0x400E0F3")]
    public const string KEY_TOOLTIP_HIDE_MODE_UNIT_STATUS = "KEY_TOOLTIP_HIDE_MODE_UNIT_STATUS";
    [Token(Token = "0x400E0F4")]
    public const string KEY_TOOLTIP_HIDE_MODE_UNIT_ABILITY = "KEY_TOOLTIP_HIDE_MODE_UNIT_ABILITY";

    [Token(Token = "0x17001B95")]
    public RuneInventory RuneInventoryWindow
    {
      [Token(Token = "0x600D241"), Address(RVA = "0x2886E0", Offset = "0x2874E0", VA = "0x102886E0")] set
      {
      }
      [Token(Token = "0x600D242"), Address(RVA = "0x9D57F0", Offset = "0x9D45F0", VA = "0x109D57F0")] get
      {
        return (RuneInventory) null;
      }
    }

    [Token(Token = "0x17001B96")]
    public UnitData UnitData
    {
      [Token(Token = "0x600D243"), Address(RVA = "0x9D5880", Offset = "0x9D4680", VA = "0x109D5880")] get
      {
        return (UnitData) null;
      }
    }

    [Token(Token = "0x17001B97")]
    public eOverWritePartyType OverWritePartyType
    {
      [Token(Token = "0x600D244"), Address(RVA = "0x9D57D0", Offset = "0x9D45D0", VA = "0x109D57D0")] get
      {
        return new eOverWritePartyType();
      }
    }

    [Token(Token = "0x600D245")]
    [Address(RVA = "0x9D52E0", Offset = "0x9D40E0", VA = "0x109D52E0")]
    private void Setup()
    {
    }

    [Token(Token = "0x600D246")]
    [Address(RVA = "0x9D5180", Offset = "0x9D3F80", VA = "0x109D5180")]
    public void SetPartyType(SerializeValueBehaviour svl)
    {
    }

    [Token(Token = "0x600D247")]
    [Address(RVA = "0x9D5230", Offset = "0x9D4030", VA = "0x109D5230")]
    public void SetUnitIdForDataFlag(SerializeValueBehaviour svl)
    {
    }

    [Token(Token = "0x600D248")]
    [Address(RVA = "0x9D4AF0", Offset = "0x9D38F0", VA = "0x109D4AF0")]
    public void SetEditModeDefaultFlag(SerializeValueBehaviour svl)
    {
    }

    [Token(Token = "0x600D249")]
    [Address(RVA = "0x9D4BD0", Offset = "0x9D39D0", VA = "0x109D4BD0")]
    public void SetHideSetting(SerializeValueBehaviour svl)
    {
    }

    [Token(Token = "0x600D24A")]
    [Address(RVA = "0x9D4B60", Offset = "0x9D3960", VA = "0x109D4B60")]
    public void SetHideSettingForKey(SerializeValueBehaviour svl, string key)
    {
    }

    [Token(Token = "0x600D24B")]
    [Address(RVA = "0x9D3CD0", Offset = "0x9D2AD0", VA = "0x109D3CD0")]
    public void Initialize(long uid)
    {
    }

    [Token(Token = "0x600D24C")]
    [Address(RVA = "0x9D3BA0", Offset = "0x9D29A0", VA = "0x109D3BA0")]
    private void InitializeModel(long uid)
    {
    }

    [Token(Token = "0x600D24D")]
    [Address(RVA = "0x9D3DE0", Offset = "0x9D2BE0", VA = "0x109D3DE0")]
    public void Initialize(UnitData unitdata)
    {
    }

    [Token(Token = "0x600D24E")]
    [Address(RVA = "0x9D3C50", Offset = "0x9D2A50", VA = "0x109D3C50")]
    private void InitializeModel(UnitData unitData)
    {
    }

    [Token(Token = "0x600D24F")]
    [Address(RVA = "0x9D3EB0", Offset = "0x9D2CB0", VA = "0x109D3EB0")]
    public void InititalizeSlot()
    {
    }

    [Token(Token = "0x600D250")]
    [Address(RVA = "0x9D4640", Offset = "0x9D3440", VA = "0x109D4640")]
    public void Refresh()
    {
    }

    [Token(Token = "0x600D251")]
    [Address(RVA = "0x9D3B50", Offset = "0x9D2950", VA = "0x109D3B50", Slot = "4")]
    public void Activated(int pin)
    {
    }

    [Token(Token = "0x600D252")]
    [Address(RVA = "0x9D52A0", Offset = "0x9D40A0", VA = "0x109D52A0")]
    public void SetVisibleAutoSkillButton(bool visible)
    {
    }

    [Token(Token = "0x600D253")]
    [Address(RVA = "0x9D5140", Offset = "0x9D3F40", VA = "0x109D5140")]
    public void SetIntaractableAutoSkillButton(bool intaractable)
    {
    }

    [Token(Token = "0x600D254")]
    [Address(RVA = "0x9D52C0", Offset = "0x9D40C0", VA = "0x109D52C0")]
    public void SetVisibleRuneButton(bool visible)
    {
    }

    [Token(Token = "0x600D255")]
    [Address(RVA = "0x9D5160", Offset = "0x9D3F60", VA = "0x109D5160")]
    public void SetIntaractableRuneButton(bool intaractable)
    {
    }

    [Token(Token = "0x600D256")]
    [Address(RVA = "0x9D4460", Offset = "0x9D3260", VA = "0x109D4460")]
    public void OnSelectRune()
    {
    }

    [Token(Token = "0x600D257")]
    [Address(RVA = "0x9D4450", Offset = "0x9D3250", VA = "0x109D4450")]
    private void OnCloseRuneInventoryWindow()
    {
    }

    [Token(Token = "0x600D258")]
    [Address(RVA = "0x9D5770", Offset = "0x9D4570", VA = "0x109D5770")]
    public UnitToolTipWindowEx()
    {
    }
  }
}
