// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_CheckAndroidOSVersion
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001869")]
  [FlowNode.NodeType("Flow/Node/System/CheckAndroidOSVersion", 32741)]
  [FlowNode.Pin(1, "Check", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(100, "True", FlowNode.PinTypes.Output, 100)]
  [FlowNode.Pin(200, "False", FlowNode.PinTypes.Output, 200)]
  public class FlowNode_CheckAndroidOSVersion : FlowNode
  {
    [Token(Token = "0x4005788")]
    private const int PIN_IN = 1;
    [Token(Token = "0x4005789")]
    private const int PIN_OUT_TRUE = 100;
    [Token(Token = "0x400578A")]
    private const int PIN_OUT_FALSE = 200;
    [Token(Token = "0x400578B")]
    [FieldOffset(Offset = "0x18")]
    public int checkOS;
    [Token(Token = "0x400578C")]
    [FieldOffset(Offset = "0x1C")]
    public FlowNode_CheckAndroidOSVersion.CheckMethod method;

    [Token(Token = "0x6006270")]
    [Address(RVA = "0x305F60", Offset = "0x304D60", VA = "0x10305F60", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6006271")]
    [Address(RVA = "0x305F80", Offset = "0x304D80", VA = "0x10305F80")]
    public FlowNode_CheckAndroidOSVersion()
    {
    }

    [Token(Token = "0x200186A")]
    public enum CheckMethod
    {
      [Token(Token = "0x400578E")] Equal,
      [Token(Token = "0x400578F")] OrMore,
      [Token(Token = "0x4005790")] Under,
      [Token(Token = "0x4005791")] LessThan,
      [Token(Token = "0x4005792")] GreaterThan,
    }
  }
}
