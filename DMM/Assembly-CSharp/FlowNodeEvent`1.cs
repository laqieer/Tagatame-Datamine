// Decompiled with JetBrains decompiler
// Type: FlowNodeEvent`1
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
[Token(Token = "0x20001BF")]
public abstract class FlowNodeEvent<T> : FlowNode where T : FlowNode
{
  [Token(Token = "0x4000816")]
  [FieldOffset(Offset = "0x0")]
  private static List<FlowNode> mNodes;

  [Token(Token = "0x6000A59")]
  protected override void Awake()
  {
  }

  [Token(Token = "0x6000A5A")]
  protected override void OnDestroy()
  {
  }

  [Token(Token = "0x6000A5B")]
  public static void Invoke()
  {
  }

  [Token(Token = "0x6000A5C")]
  public override void OnActivate(int pinID)
  {
  }

  [Token(Token = "0x6000A5D")]
  protected FlowNodeEvent()
  {
  }

  [Token(Token = "0x6000A5E")]
  static FlowNodeEvent()
  {
  }
}
