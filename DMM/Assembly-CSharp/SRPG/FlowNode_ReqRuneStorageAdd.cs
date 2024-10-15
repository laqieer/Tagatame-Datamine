// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqRuneStorageAdd
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001857")]
  [FlowNode.NodeType("Rune/Req/StorageAdd", 32741)]
  [FlowNode.Pin(1, "Request", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(101, "Success", FlowNode.PinTypes.Output, 101)]
  [FlowNode.Pin(102, "倉庫枠上限", FlowNode.PinTypes.Output, 102)]
  [FlowNode.Pin(103, "幻晶石不足", FlowNode.PinTypes.Output, 103)]
  [AddComponentMenu("")]
  public class FlowNode_ReqRuneStorageAdd : FlowNode_Network
  {
    [Token(Token = "0x4005756")]
    protected const int PIN_IN_REQUEST = 1;
    [Token(Token = "0x4005757")]
    protected const int PIN_OUT_SUCCESS = 101;
    [Token(Token = "0x4005758")]
    protected const int PIN_OUT_IS_UPPER_LIMIT_FOR_STORAGE = 102;
    [Token(Token = "0x4005759")]
    protected const int PIN_OUT_NOT_ENOUGH_COIN = 103;

    [Token(Token = "0x600623F")]
    [Address(RVA = "0x136BB20", Offset = "0x136A920", VA = "0x1136BB20", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6006240")]
    [Address(RVA = "0x3089D0", Offset = "0x3077D0", VA = "0x103089D0")]
    private void Success()
    {
    }

    [Token(Token = "0x6006241")]
    [Address(RVA = "0x136BC60", Offset = "0x136AA60", VA = "0x1136BC60", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x6006242")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqRuneStorageAdd()
    {
    }

    [Token(Token = "0x2001858")]
    [MessagePackObject(true)]
    public class MP_Response : WebAPI.JSON_BaseResponse
    {
      [Token(Token = "0x400575A")]
      [FieldOffset(Offset = "0x28")]
      public ReqRuneStorageAdd.Response body;

      [Token(Token = "0x6006243")]
      [Address(RVA = "0x2ECB10", Offset = "0x2EB910", VA = "0x102ECB10")]
      public MP_Response()
      {
      }
    }
  }
}
