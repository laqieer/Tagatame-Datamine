// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_AllEnhanceEquip
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001363")]
  [AddComponentMenu("")]
  [FlowNode.NodeType("System/Unit/AllEnhanceEquip", 32741)]
  [FlowNode.Pin(1, "Request", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(101, "Success", FlowNode.PinTypes.Output, 101)]
  [FlowNode.Pin(201, "Faild", FlowNode.PinTypes.Output, 201)]
  public class FlowNode_AllEnhanceEquip : FlowNode_Network
  {
    [Token(Token = "0x400479A")]
    protected const int PIN_IN_REQUEST = 1;
    [Token(Token = "0x400479B")]
    protected const int PIN_OUT_SUCCESS = 101;
    [Token(Token = "0x400479C")]
    protected const int PIN_OUT_FAILD = 201;

    [Token(Token = "0x600515D")]
    [Address(RVA = "0x1265EB0", Offset = "0x1264CB0", VA = "0x11265EB0", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x600515E")]
    [Address(RVA = "0x1266430", Offset = "0x1265230", VA = "0x11266430")]
    private void Success()
    {
    }

    [Token(Token = "0x600515F")]
    [Address(RVA = "0x1265E50", Offset = "0x1264C50", VA = "0x11265E50")]
    private void Failure()
    {
    }

    [Token(Token = "0x6005160")]
    [Address(RVA = "0x1266060", Offset = "0x1264E60", VA = "0x11266060", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x6005161")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_AllEnhanceEquip()
    {
    }

    [Token(Token = "0x2001364")]
    [MessagePackObject(true)]
    public class MP_Response : WebAPI.JSON_BaseResponse
    {
      [Token(Token = "0x400479D")]
      [FieldOffset(Offset = "0x28")]
      public ReqAllEquipExpAdd.Response body;

      [Token(Token = "0x6005162")]
      [Address(RVA = "0x2ECB10", Offset = "0x2EB910", VA = "0x102ECB10")]
      public MP_Response()
      {
      }
    }
  }
}
