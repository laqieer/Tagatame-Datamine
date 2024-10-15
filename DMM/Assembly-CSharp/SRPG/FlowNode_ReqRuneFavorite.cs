// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqRuneFavorite
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200184D")]
  [FlowNode.NodeType("Rune/Req/Favorite", 32741)]
  [FlowNode.Pin(1, "ON", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(2, "OFF", FlowNode.PinTypes.Input, 2)]
  [FlowNode.Pin(3, "反転", FlowNode.PinTypes.Input, 3)]
  [FlowNode.Pin(101, "⇒ ON", FlowNode.PinTypes.Output, 101)]
  [FlowNode.Pin(102, "⇒ OFF", FlowNode.PinTypes.Output, 102)]
  [AddComponentMenu("")]
  public class FlowNode_ReqRuneFavorite : FlowNode_Network
  {
    [Token(Token = "0x400572E")]
    protected const int PIN_IN_FAVORITE_ON = 1;
    [Token(Token = "0x400572F")]
    protected const int PIN_IN_FAVORITE_OFF = 2;
    [Token(Token = "0x4005730")]
    protected const int PIN_IN_FAVORITE_INVERT = 3;
    [Token(Token = "0x4005731")]
    protected const int PIN_OUT_FAVORITE_ON = 101;
    [Token(Token = "0x4005732")]
    protected const int PIN_OUT_FAVORITE_OFF = 102;
    [Token(Token = "0x4005733")]
    [FieldOffset(Offset = "0x20")]
    private BindRuneData mRuneData;

    [Token(Token = "0x6006214")]
    [Address(RVA = "0x1369050", Offset = "0x1367E50", VA = "0x11369050", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6006215")]
    [Address(RVA = "0x12C6F00", Offset = "0x12C5D00", VA = "0x112C6F00")]
    private void Success(int successPinID)
    {
    }

    [Token(Token = "0x6006216")]
    [Address(RVA = "0x13691F0", Offset = "0x1367FF0", VA = "0x113691F0", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x6006217")]
    [Address(RVA = "0x288700", Offset = "0x287500", VA = "0x10288700")]
    public void SetRuneData(BindRuneData rune)
    {
    }

    [Token(Token = "0x6006218")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqRuneFavorite()
    {
    }

    [Token(Token = "0x200184E")]
    [MessagePackObject(true)]
    public class MP_Response : WebAPI.JSON_BaseResponse
    {
      [Token(Token = "0x4005734")]
      [FieldOffset(Offset = "0x28")]
      public ReqRuneFavorite.Response body;

      [Token(Token = "0x6006219")]
      [Address(RVA = "0x2ECB10", Offset = "0x2EB910", VA = "0x102ECB10")]
      public MP_Response()
      {
      }
    }
  }
}
