// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqTruthEquipmentLvup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200188A")]
  [FlowNode.NodeType("TruthEquipment/Lvup", 32741)]
  [FlowNode.Pin(1, "Request", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(101, "Success", FlowNode.PinTypes.Output, 101)]
  [AddComponentMenu("")]
  public class FlowNode_ReqTruthEquipmentLvup : FlowNode_Network
  {
    [Token(Token = "0x4005808")]
    protected const int PIN_IN_REQUEST = 1;
    [Token(Token = "0x4005809")]
    protected const int PIN_OUT_SUCCESS = 101;
    [Token(Token = "0x400580A")]
    [FieldOffset(Offset = "0x20")]
    private string m_SelectedUnitIname;
    [Token(Token = "0x400580B")]
    [FieldOffset(Offset = "0x24")]
    private int m_AddLevel;

    [Token(Token = "0x60062D2")]
    [Address(RVA = "0x288700", Offset = "0x287500", VA = "0x10288700")]
    public void SetSelectedUnitIname(string iname)
    {
    }

    [Token(Token = "0x60062D3")]
    [Address(RVA = "0x311230", Offset = "0x310030", VA = "0x10311230")]
    public void SetAddLevel(int add_level)
    {
    }

    [Token(Token = "0x60062D4")]
    [Address(RVA = "0x310D30", Offset = "0x30FB30", VA = "0x10310D30", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x60062D5")]
    [Address(RVA = "0x311240", Offset = "0x310040", VA = "0x10311240")]
    private void Success()
    {
    }

    [Token(Token = "0x60062D6")]
    [Address(RVA = "0x310E60", Offset = "0x30FC60", VA = "0x10310E60", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x60062D7")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqTruthEquipmentLvup()
    {
    }

    [Token(Token = "0x200188B")]
    [MessagePackObject(true)]
    public class MP_Response : WebAPI.JSON_BaseResponse
    {
      [Token(Token = "0x400580C")]
      [FieldOffset(Offset = "0x28")]
      public ReqUnitTruthEquipLvup.Response body;

      [Token(Token = "0x60062D8")]
      [Address(RVA = "0x2ECB10", Offset = "0x2EB910", VA = "0x102ECB10")]
      public MP_Response()
      {
      }
    }
  }
}
