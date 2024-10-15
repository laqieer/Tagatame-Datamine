// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ExistsMyGUID
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200186B")]
  [FlowNode.NodeType("Flow/Node/System/ExistsMyGUID", 32741)]
  [FlowNode.Pin(1, "Exists", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(100, "Success", FlowNode.PinTypes.Output, 100)]
  [FlowNode.Pin(110, "Failed", FlowNode.PinTypes.Output, 110)]
  [AddComponentMenu("")]
  public class FlowNode_ExistsMyGUID : FlowNode
  {
    [Token(Token = "0x4005793")]
    private const int PIN_IN = 1;
    [Token(Token = "0x4005794")]
    private const int PIN_OUT_SUCCESS = 100;
    [Token(Token = "0x4005795")]
    private const int PIN_OUT_FAILED = 110;
    [Token(Token = "0x4005796")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private FlowNode_ExistsMyGUID.SelectType selectType;

    [Token(Token = "0x6006272")]
    [Address(RVA = "0x306E50", Offset = "0x305C50", VA = "0x10306E50", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6006273")]
    [Address(RVA = "0x306D60", Offset = "0x305B60", VA = "0x10306D60")]
    private bool IsExistsDeviceId() => new bool();

    [Token(Token = "0x6006274")]
    [Address(RVA = "0x306DB0", Offset = "0x305BB0", VA = "0x10306DB0")]
    private bool IsExistsSecretkey() => new bool();

    [Token(Token = "0x6006275")]
    [Address(RVA = "0x306E00", Offset = "0x305C00", VA = "0x10306E00")]
    private bool IsExistsUDID() => new bool();

    [Token(Token = "0x6006276")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public FlowNode_ExistsMyGUID()
    {
    }

    [Token(Token = "0x200186C")]
    private enum SelectType : byte
    {
      [Token(Token = "0x4005798")] NONE,
      [Token(Token = "0x4005799")] DEVICE_ID,
      [Token(Token = "0x400579A")] SECRET_KEY,
      [Token(Token = "0x400579B")] UDID,
      [Token(Token = "0x400579C")] ALL,
      [Token(Token = "0x400579D")] EXISTS_DEVICE_ID,
      [Token(Token = "0x400579E")] EXISTS_SECRET_KEY,
      [Token(Token = "0x400579F")] EXISTS_UDID,
      [Token(Token = "0x40057A0")] EXISTS_ALL,
      [Token(Token = "0x40057A1")] MAX,
    }
  }
}
