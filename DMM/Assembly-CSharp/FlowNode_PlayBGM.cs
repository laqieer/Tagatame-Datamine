// Decompiled with JetBrains decompiler
// Type: FlowNode_PlayBGM
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
[Token(Token = "0x2000200")]
[FlowNode.NodeType("Sound/PlayBGM", 32741)]
[FlowNode.Pin(100, "Play", FlowNode.PinTypes.Input, 0)]
[FlowNode.Pin(1, "Output", FlowNode.PinTypes.Output, 1)]
[AddComponentMenu("")]
public class FlowNode_PlayBGM : FlowNode
{
  [Token(Token = "0x40008C6")]
  [FieldOffset(Offset = "0x18")]
  public FlowNode_PlayBGM.EType Type;
  [Token(Token = "0x40008C7")]
  [FieldOffset(Offset = "0x1C")]
  public string BGMName;

  [Token(Token = "0x6000B42")]
  [Address(RVA = "0x107CFE0", Offset = "0x107BDE0", VA = "0x1107CFE0", Slot = "6")]
  public override string[] GetInfoLines() => (string[]) null;

  [Token(Token = "0x6000B43")]
  [Address(RVA = "0x107D0A0", Offset = "0x107BEA0", VA = "0x1107D0A0", Slot = "4")]
  public override void OnActivate(int pinID)
  {
  }

  [Token(Token = "0x6000B44")]
  [Address(RVA = "0x107D280", Offset = "0x107C080", VA = "0x1107D280")]
  public static void PlayHomeBGM()
  {
  }

  [Token(Token = "0x6000B45")]
  [Address(RVA = "0x107CE10", Offset = "0x107BC10", VA = "0x1107CE10")]
  public static string[] GetHomeBGM() => (string[]) null;

  [Token(Token = "0x6000B46")]
  [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
  public FlowNode_PlayBGM()
  {
  }

  [Token(Token = "0x2000201")]
  public enum EType
  {
    [Token(Token = "0x40008C9")] DIRECT,
    [Token(Token = "0x40008CA")] HOME_BGM,
  }
}
