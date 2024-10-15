// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqCrystalFavorite
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200132F")]
  [FlowNode.Pin(2000, "お気に入り設定ON完了", FlowNode.PinTypes.Output, 2000)]
  [FlowNode.Pin(2010, "お気に入り設定OFF完了", FlowNode.PinTypes.Output, 2010)]
  [FlowNode.Pin(200, "お気に入りON", FlowNode.PinTypes.Input, 200)]
  [FlowNode.Pin(210, "お気に入りOFF", FlowNode.PinTypes.Input, 210)]
  [FlowNode.NodeType("Crystal/Req/CrystalFavorite", 32741)]
  [FlowNode.Pin(220, "お気に入り設定(SerializeValueListで指定)", FlowNode.PinTypes.Input, 220)]
  public class FlowNode_ReqCrystalFavorite : FlowNode_Network
  {
    [Token(Token = "0x400471E")]
    private const int PIN_IN_REQUEST = 1;
    [Token(Token = "0x400471F")]
    private const int PIN_OUT_SUCCESS = 101;
    [Token(Token = "0x4004720")]
    private const int INPUT_FAVORITE_ON = 200;
    [Token(Token = "0x4004721")]
    private const int INPUT_FAVORITE_OFF = 210;
    [Token(Token = "0x4004722")]
    private const int INPUT_FAVORITE = 220;
    [Token(Token = "0x4004723")]
    private const int OUTPUT_FAVORITE_ON = 2000;
    [Token(Token = "0x4004724")]
    private const int OUTPUT_FAVORITE_OFF = 2010;
    [Token(Token = "0x4004725")]
    [FieldOffset(Offset = "0x20")]
    private int mOutPutPinId;

    [Token(Token = "0x60050D3")]
    [Address(RVA = "0x125B850", Offset = "0x125A650", VA = "0x1125B850", Slot = "5")]
    public override void OnActivate(int pinID, SerializeValueList valueList)
    {
    }

    [Token(Token = "0x60050D4")]
    [Address(RVA = "0x125C090", Offset = "0x125AE90", VA = "0x1125C090")]
    private void Success()
    {
    }

    [Token(Token = "0x60050D5")]
    [Address(RVA = "0x125BAF0", Offset = "0x125A8F0", VA = "0x1125BAF0", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x60050D6")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqCrystalFavorite()
    {
    }

    [Token(Token = "0x2001330")]
    [MessagePackObject(true)]
    [Serializable]
    public class MP_Response : WebAPI.JSON_BaseResponse
    {
      [Token(Token = "0x4004726")]
      [FieldOffset(Offset = "0x28")]
      public ReqCrystalFavorite.Response body;

      [Token(Token = "0x60050D7")]
      [Address(RVA = "0x2ECB10", Offset = "0x2EB910", VA = "0x102ECB10")]
      public MP_Response()
      {
      }
    }
  }
}
