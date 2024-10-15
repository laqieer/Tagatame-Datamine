// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqAdventureEnd
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20012DD")]
  [FlowNode.Pin(209, "AdventureNotStart", FlowNode.PinTypes.Output, 209)]
  [FlowNode.Pin(206, "AdventureNotFix", FlowNode.PinTypes.Output, 206)]
  [AddComponentMenu("")]
  [FlowNode.Pin(101, "Success", FlowNode.PinTypes.Output, 101)]
  [FlowNode.Pin(1, "Request", FlowNode.PinTypes.Input, 1)]
  [FlowNode.NodeType("Adventure/Req/AdventureEnd", 32741)]
  [FlowNode.Pin(102, "LeveUp", FlowNode.PinTypes.Output, 102)]
  public class FlowNode_ReqAdventureEnd : FlowNode_Network
  {
    [Token(Token = "0x4004643")]
    protected const int PIN_IN_REQUEST = 1;
    [Token(Token = "0x4004644")]
    protected const int PIN_OUT_SUCCESS = 101;
    [Token(Token = "0x4004645")]
    protected const int PIN_OUT_LEVEL_UP = 102;
    [Token(Token = "0x4004646")]
    protected const int PIN_OUT_ADVENTURE_NOT_FIX = 206;
    [Token(Token = "0x4004647")]
    protected const int PIN_OUT_ADVENTURE_NOT_START = 209;
    [Token(Token = "0x4004648")]
    [FieldOffset(Offset = "0x20")]
    private AdventureDataBase mAdvDataBase;

    [Token(Token = "0x6004FDB")]
    [Address(RVA = "0x124B450", Offset = "0x124A250", VA = "0x1124B450", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6004FDC")]
    [Address(RVA = "0x3089D0", Offset = "0x3077D0", VA = "0x103089D0")]
    private void Success()
    {
    }

    [Token(Token = "0x6004FDD")]
    [Address(RVA = "0x124B610", Offset = "0x124A410", VA = "0x1124B610", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x6004FDE")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqAdventureEnd()
    {
    }

    [Token(Token = "0x20012DE")]
    [MessagePackObject(true)]
    public class MP_Response : WebAPI.JSON_BaseResponse
    {
      [Token(Token = "0x4004649")]
      [FieldOffset(Offset = "0x28")]
      public ReqAdventureEnd.Response body;

      [Token(Token = "0x6004FE1")]
      [Address(RVA = "0x2ECB10", Offset = "0x2EB910", VA = "0x102ECB10")]
      public MP_Response()
      {
      }
    }
  }
}
