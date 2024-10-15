// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_SetTutorialFlag
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200162A")]
  [FlowNode.Pin(3, "Flag Changed (No)", FlowNode.PinTypes.Output, 2)]
  [AddComponentMenu("")]
  [FlowNode.Pin(12, "False", FlowNode.PinTypes.Output, 22)]
  [FlowNode.Pin(11, "True", FlowNode.PinTypes.Output, 21)]
  [FlowNode.Pin(10, "Test", FlowNode.PinTypes.Input, 20)]
  [FlowNode.Pin(5, "Flag Unchanged", FlowNode.PinTypes.Output, 3)]
  [FlowNode.Pin(2, "Flag Changed (Yes)", FlowNode.PinTypes.Output, 1)]
  [FlowNode.Pin(1, "Set", FlowNode.PinTypes.Input, 0)]
  [FlowNode.NodeType("Tutorial/SetTutorialFlag", 32741)]
  public class FlowNode_SetTutorialFlag : FlowNode
  {
    [Token(Token = "0x400504F")]
    private const int PIN_ID_SET = 1;
    [Token(Token = "0x4005050")]
    private const int PIN_ID_UPDATE1 = 2;
    [Token(Token = "0x4005051")]
    private const int PIN_ID_UPDATE2 = 3;
    [Token(Token = "0x4005052")]
    private const int PIN_ID_NOUPDATE = 5;
    [Token(Token = "0x4005053")]
    private const int PIN_ID_TEST = 10;
    [Token(Token = "0x4005054")]
    private const int PIN_ID_TRUE = 11;
    [Token(Token = "0x4005055")]
    private const int PIN_ID_FALSE = 12;
    [Token(Token = "0x4005056")]
    [FieldOffset(Offset = "0x18")]
    public TutorialFlags mTutorialFlags;
    [Token(Token = "0x4005057")]
    [FieldOffset(Offset = "0x1C")]
    public string FlagID;
    [Token(Token = "0x4005058")]
    [FieldOffset(Offset = "0x20")]
    public string ConfirmText;

    [Token(Token = "0x6005B13")]
    [Address(RVA = "0x12FC4A0", Offset = "0x12FB2A0", VA = "0x112FC4A0", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005B14")]
    [Address(RVA = "0x12FC6D0", Offset = "0x12FB4D0", VA = "0x112FC6D0")]
    private void OnYes(GameObject go)
    {
    }

    [Token(Token = "0x6005B15")]
    [Address(RVA = "0x12FC670", Offset = "0x12FB470", VA = "0x112FC670")]
    private void OnNo(GameObject go)
    {
    }

    [Token(Token = "0x6005B16")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public FlowNode_SetTutorialFlag()
    {
    }
  }
}
