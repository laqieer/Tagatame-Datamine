// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqBtlComCombatPowerOpen
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200131B")]
  [AddComponentMenu("")]
  [FlowNode.Pin(20, "Cancel", FlowNode.PinTypes.Output, 20)]
  [FlowNode.Pin(10, "Success", FlowNode.PinTypes.Output, 10)]
  [FlowNode.NodeType("CombatPower/Req/OpenQuest", 32741)]
  [FlowNode.Pin(1, "Request", FlowNode.PinTypes.Input, 1)]
  public class FlowNode_ReqBtlComCombatPowerOpen : FlowNode_Network
  {
    [Token(Token = "0x40046EC")]
    protected const int PIN_IN_REQUEST = 1;
    [Token(Token = "0x40046ED")]
    protected const int PIN_OUT_SUCCESS = 10;
    [Token(Token = "0x40046EE")]
    protected const int PIN_OUT_CANCEL = 20;

    [Token(Token = "0x600508E")]
    [Address(RVA = "0x1258AA0", Offset = "0x12578A0", VA = "0x11258AA0", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x600508F")]
    [Address(RVA = "0x1259120", Offset = "0x1257F20", VA = "0x11259120")]
    private void TryRequest()
    {
    }

    [Token(Token = "0x6005090")]
    [Address(RVA = "0x12584D0", Offset = "0x12572D0", VA = "0x112584D0")]
    private bool ContainsUnlockQuest(ReqBtlComCombatPowerOpen.Request requestParam) => new bool();

    [Token(Token = "0x6005091")]
    [Address(RVA = "0x1258500", Offset = "0x1257300", VA = "0x11258500")]
    private ReqBtlComCombatPowerOpen.Request CreateRequestParam()
    {
      return (ReqBtlComCombatPowerOpen.Request) null;
    }

    [Token(Token = "0x6005092")]
    [Address(RVA = "0x12590B0", Offset = "0x1257EB0", VA = "0x112590B0")]
    private void Success()
    {
    }

    [Token(Token = "0x6005093")]
    [Address(RVA = "0x1258C20", Offset = "0x1257A20", VA = "0x11258C20", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x6005094")]
    [Address(RVA = "0x1258980", Offset = "0x1257780", VA = "0x11258980")]
    private void NotifyQuestUnlock(JSON_QuestCombatPowers json)
    {
    }

    [Token(Token = "0x6005095")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqBtlComCombatPowerOpen()
    {
    }

    [Token(Token = "0x200131C")]
    [MessagePackObject(true)]
    public class MP_Response : WebAPI.JSON_BaseResponse
    {
      [Token(Token = "0x40046EF")]
      [FieldOffset(Offset = "0x28")]
      public ReqBtlComCombatPowerOpen.Response body;

      [Token(Token = "0x6005096")]
      [Address(RVA = "0x2ECB10", Offset = "0x2EB910", VA = "0x102ECB10")]
      public MP_Response()
      {
      }
    }
  }
}
