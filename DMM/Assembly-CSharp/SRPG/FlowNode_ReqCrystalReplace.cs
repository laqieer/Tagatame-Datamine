// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqCrystalReplace
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001338")]
  [FlowNode.NodeType("Crystal/Req/CrystalReplace", 32741)]
  [FlowNode.Pin(101, "Success", FlowNode.PinTypes.Output, 101)]
  [FlowNode.Pin(1, "Request", FlowNode.PinTypes.Input, 1)]
  public class FlowNode_ReqCrystalReplace : FlowNode_Network
  {
    [Token(Token = "0x4004733")]
    private const int PIN_IN_REQUEST = 1;
    [Token(Token = "0x4004734")]
    private const int PIN_OUT_SUCCESS = 101;
    [Token(Token = "0x4004735")]
    public const string KEY_BASE_UNIT_ID = "KEY_BASE_UNIT_ID";
    [Token(Token = "0x4004736")]
    public const string KEY_TARGET_UNIT_ID = "KEY_TARGET_UNIT_ID";

    [Token(Token = "0x60050EA")]
    [Address(RVA = "0x125D2A0", Offset = "0x125C0A0", VA = "0x1125D2A0", Slot = "5")]
    public override void OnActivate(int pinID, SerializeValueList valueList)
    {
    }

    [Token(Token = "0x60050EB")]
    [Address(RVA = "0x125D770", Offset = "0x125C570", VA = "0x1125D770")]
    private void Success()
    {
    }

    [Token(Token = "0x60050EC")]
    [Address(RVA = "0x125D400", Offset = "0x125C200", VA = "0x1125D400", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x60050ED")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqCrystalReplace()
    {
    }

    [Token(Token = "0x2001339")]
    [MessagePackObject(true)]
    [Serializable]
    public class MP_Response : WebAPI.JSON_BaseResponse
    {
      [Token(Token = "0x4004737")]
      [FieldOffset(Offset = "0x28")]
      public ReqCrystalReplace.Response body;

      [Token(Token = "0x60050EE")]
      [Address(RVA = "0x2ECB10", Offset = "0x2EB910", VA = "0x102ECB10")]
      public MP_Response()
      {
      }
    }
  }
}
