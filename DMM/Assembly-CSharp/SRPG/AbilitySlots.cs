// Decompiled with JetBrains decompiler
// Type: SRPG.AbilitySlots
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001F35")]
  [FlowNode.Pin(0, "Job Change(True)", FlowNode.PinTypes.Input, 0)]
  [FlowNode.Pin(1, "Job Change(False)", FlowNode.PinTypes.Input, 1)]
  [AddComponentMenu("UI/AbilitySlots")]
  public class AbilitySlots : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400834B")]
    [FieldOffset(Offset = "0xC")]
    public UnitAbilityPicker Prefab_AbilityPicker;
    [Token(Token = "0x400834C")]
    [FieldOffset(Offset = "0x10")]
    public UnitAbilityList unitAbilityList;
    [Token(Token = "0x400834D")]
    [FieldOffset(Offset = "0x14")]
    public GameObject abilityExplanationText;
    [Token(Token = "0x400834E")]
    [FieldOffset(Offset = "0x18")]
    public GameObject refreshRoot;
    [Token(Token = "0x400834F")]
    [FieldOffset(Offset = "0x1C")]
    private bool button_enable;
    [Token(Token = "0x4008350")]
    [FieldOffset(Offset = "0x20")]
    private UnitAbilityPicker mAbilityPicker;
    [Token(Token = "0x4008351")]
    [FieldOffset(Offset = "0x24")]
    private bool mIsConnecting;

    [Token(Token = "0x1700124F")]
    private UnitData CurrentUnit
    {
      [Token(Token = "0x6007FCD"), Address(RVA = "0x4062E0", Offset = "0x4050E0", VA = "0x104062E0")] get
      {
        return (UnitData) null;
      }
    }

    [Token(Token = "0x6007FCE")]
    [Address(RVA = "0x405290", Offset = "0x404090", VA = "0x10405290", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x6007FCF")]
    [Address(RVA = "0x406160", Offset = "0x404F60", VA = "0x10406160")]
    private void Start()
    {
    }

    [Token(Token = "0x6007FD0")]
    [Address(RVA = "0x4053B0", Offset = "0x4041B0", VA = "0x104053B0")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x6007FD1")]
    [Address(RVA = "0x4052D0", Offset = "0x4040D0", VA = "0x104052D0")]
    private void OnAbilitySlotSelect(int slotIndex)
    {
    }

    [Token(Token = "0x6007FD2")]
    [Address(RVA = "0x405450", Offset = "0x404250", VA = "0x10405450")]
    private void OnSlotAbilitySelect(AbilityData ability, GameObject itemGO)
    {
    }

    [Token(Token = "0x6007FD3")]
    [Address(RVA = "0x405EC0", Offset = "0x404CC0", VA = "0x10405EC0")]
    private void Res_UpdateEquippedAbility(WWWResult www)
    {
    }

    [Token(Token = "0x6007FD4")]
    [Address(RVA = "0x405CE0", Offset = "0x404AE0", VA = "0x10405CE0")]
    private void Res_UpdateEquippedAbility_Simple(WWWResult www)
    {
    }

    [Token(Token = "0x6007FD5")]
    [Address(RVA = "0x405A50", Offset = "0x404850", VA = "0x10405A50")]
    private void Res_UpdateEquippedAbility_OverWrite(WWWResult www)
    {
    }

    [Token(Token = "0x6007FD6")]
    [Address(RVA = "0x4058E0", Offset = "0x4046E0", VA = "0x104058E0")]
    private void OverWriteUpdate()
    {
    }

    [Token(Token = "0x6007FD7")]
    [Address(RVA = "0x405A20", Offset = "0x404820", VA = "0x10405A20")]
    public void Refresh(bool enable)
    {
    }

    [Token(Token = "0x6007FD8")]
    [Address(RVA = "0x406070", Offset = "0x404E70", VA = "0x10406070")]
    public void SetButtonEnabled()
    {
    }

    [Token(Token = "0x6007FD9")]
    [Address(RVA = "0x406000", Offset = "0x404E00", VA = "0x10406000")]
    public void SetAbilityExplanationText()
    {
    }

    [Token(Token = "0x6007FDA")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public AbilitySlots()
    {
    }

    [Token(Token = "0x2001F36")]
    [MessagePackObject(true)]
    public class MP_JobAbilityt_OverWriteResponse : WebAPI.JSON_BaseResponse
    {
      [Token(Token = "0x4008352")]
      [FieldOffset(Offset = "0x28")]
      public ReqJobAbility_OverWrite.Response body;

      [Token(Token = "0x6007FDB")]
      [Address(RVA = "0x2ECB10", Offset = "0x2EB910", VA = "0x102ECB10")]
      public MP_JobAbilityt_OverWriteResponse()
      {
      }
    }
  }
}
