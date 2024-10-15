// Decompiled with JetBrains decompiler
// Type: SRPG.AbilitySlotsEx
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001F37")]
  [AddComponentMenu("UI/AbilitySlotsEx")]
  [FlowNode.Pin(121, "アビリティ変更(API)", FlowNode.PinTypes.Output, 121)]
  [FlowNode.Pin(1, "更新(通常)", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(0, "更新(特殊)", FlowNode.PinTypes.Input, 0)]
  [FlowNode.Pin(111, "全体更新", FlowNode.PinTypes.Output, 111)]
  public class AbilitySlotsEx : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x4008353")]
    private const int INPUT_REFRESH_ENABLE = 0;
    [Token(Token = "0x4008354")]
    private const int INPUT_REFRESH = 1;
    [Token(Token = "0x4008355")]
    private const int OUTPUT_REFRESH = 111;
    [Token(Token = "0x4008356")]
    private const int OUTPUT_SET_ABILITY_API = 121;
    [Token(Token = "0x4008357")]
    [FieldOffset(Offset = "0xC")]
    public UnitAbilityPickerEx mPrefabAbilityPicker;
    [Token(Token = "0x4008358")]
    [FieldOffset(Offset = "0x10")]
    public UnitAbilityListEx mUnitAbilityList;
    [Token(Token = "0x4008359")]
    [FieldOffset(Offset = "0x14")]
    public GameObject mAbilityExplanationText;
    [Token(Token = "0x400835A")]
    [FieldOffset(Offset = "0x18")]
    private bool mButtonEnable;
    [Token(Token = "0x400835B")]
    [FieldOffset(Offset = "0x1C")]
    private UnitAbilityPickerEx mAbilityPicker;
    [Token(Token = "0x400835C")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private UnitToolTipWindowEx mUnitToolTip;

    [Token(Token = "0x17001250")]
    private UnitData CurrentUnit
    {
      [Token(Token = "0x6007FDC"), Address(RVA = "0x405210", Offset = "0x404010", VA = "0x10405210")] get
      {
        return (UnitData) null;
      }
    }

    [Token(Token = "0x6007FDD")]
    [Address(RVA = "0x404920", Offset = "0x403720", VA = "0x10404920", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x6007FDE")]
    [Address(RVA = "0x405070", Offset = "0x403E70", VA = "0x10405070")]
    private void Start()
    {
    }

    [Token(Token = "0x6007FDF")]
    [Address(RVA = "0x404AE0", Offset = "0x4038E0", VA = "0x10404AE0")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x6007FE0")]
    [Address(RVA = "0x404990", Offset = "0x403790", VA = "0x10404990")]
    public void Initialize(UnitData unitData, bool isEdit = true, bool isHide = false)
    {
    }

    [Token(Token = "0x6007FE1")]
    [Address(RVA = "0x404A00", Offset = "0x403800", VA = "0x10404A00")]
    private void OnAbilitySlotSelect(int slotIndex)
    {
    }

    [Token(Token = "0x6007FE2")]
    [Address(RVA = "0x404B80", Offset = "0x403980", VA = "0x10404B80")]
    private void OnSlotAbilitySelect(AbilityData ability, GameObject itemGO)
    {
    }

    [Token(Token = "0x6007FE3")]
    [Address(RVA = "0x4051F0", Offset = "0x403FF0", VA = "0x104051F0")]
    private void ToolTipRefreshAll()
    {
    }

    [Token(Token = "0x6007FE4")]
    [Address(RVA = "0x4048F0", Offset = "0x4036F0", VA = "0x104048F0")]
    private void AbilityListRefresh(UnitData unitData)
    {
    }

    [Token(Token = "0x6007FE5")]
    [Address(RVA = "0x404ED0", Offset = "0x403CD0", VA = "0x10404ED0")]
    public void Refresh(UnitData unitData, bool enable)
    {
    }

    [Token(Token = "0x6007FE6")]
    [Address(RVA = "0x404960", Offset = "0x403760", VA = "0x10404960")]
    public void ButtonRefresh(bool enable)
    {
    }

    [Token(Token = "0x6007FE7")]
    [Address(RVA = "0x404F80", Offset = "0x403D80", VA = "0x10404F80")]
    public void SetButtonEnabled()
    {
    }

    [Token(Token = "0x6007FE8")]
    [Address(RVA = "0x404F10", Offset = "0x403D10", VA = "0x10404F10")]
    public void SetAbilityExplanationText()
    {
    }

    [Token(Token = "0x6007FE9")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public AbilitySlotsEx()
    {
    }

    [Token(Token = "0x2001F38")]
    [MessagePackObject(true)]
    public class MP_JobAbilityt_OverWriteResponse : WebAPI.JSON_BaseResponse
    {
      [Token(Token = "0x400835D")]
      [FieldOffset(Offset = "0x28")]
      public ReqJobAbility_OverWrite.Response body;

      [Token(Token = "0x6007FEA")]
      [Address(RVA = "0x2ECB10", Offset = "0x2EB910", VA = "0x102ECB10")]
      public MP_JobAbilityt_OverWriteResponse()
      {
      }
    }
  }
}
