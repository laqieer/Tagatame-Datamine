// Decompiled with JetBrains decompiler
// Type: FlowNode_PlaySE
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
[Token(Token = "0x2000203")]
[FlowNode.NodeType("Sound/PlaySE", 32741)]
[FlowNode.Pin(100, "OneShot", FlowNode.PinTypes.Input, 0)]
[AddComponentMenu("")]
[FlowNode.Pin(1, "Output", FlowNode.PinTypes.Output, 1)]
public class FlowNode_PlaySE : FlowNode
{
  [Token(Token = "0x40008CC")]
  [FieldOffset(Offset = "0x18")]
  public string sheetName;
  [Token(Token = "0x40008CD")]
  [FieldOffset(Offset = "0x1C")]
  public string cueID;
  [Token(Token = "0x40008CE")]
  [FieldOffset(Offset = "0x20")]
  public int RepeatCount;
  [Token(Token = "0x40008CF")]
  [FieldOffset(Offset = "0x24")]
  public float RepeatWait;
  [Token(Token = "0x40008D0")]
  [FieldOffset(Offset = "0x28")]
  public MySound.EType Type;
  [Token(Token = "0x40008D1")]
  [FieldOffset(Offset = "0x2C")]
  public float StopSec;
  [Token(Token = "0x40008D2")]
  [FieldOffset(Offset = "0x30")]
  public bool FadeOutOnDestroy;
  [Token(Token = "0x40008D3")]
  [FieldOffset(Offset = "0x34")]
  public float FadeOutSec;
  [Token(Token = "0x40008D4")]
  [FieldOffset(Offset = "0x38")]
  public bool UseCustomPlay;
  [Token(Token = "0x40008D5")]
  [FieldOffset(Offset = "0x3C")]
  public MySound.CueSheetHandle.ELoopFlag CustomLoopFlag;
  [Token(Token = "0x40008D6")]
  [FieldOffset(Offset = "0x40")]
  public float CustomDelaySec;
  [Token(Token = "0x40008D7")]
  [FieldOffset(Offset = "0x44")]
  private string mSheetName;
  [Token(Token = "0x40008D8")]
  [FieldOffset(Offset = "0x48")]
  private MySound.CueSheetHandle mHandle;
  [Token(Token = "0x40008D9")]
  [FieldOffset(Offset = "0x4C")]
  private MySound.PlayHandle mPlayHandle;

  [Token(Token = "0x6000B49")]
  [Address(RVA = "0x107D490", Offset = "0x107C290", VA = "0x1107D490", Slot = "6")]
  public override string[] GetInfoLines() => (string[]) null;

  [Token(Token = "0x6000B4A")]
  [Address(RVA = "0x107D420", Offset = "0x107C220", VA = "0x1107D420", Slot = "7")]
  protected override void Awake()
  {
  }

  [Token(Token = "0x6000B4B")]
  [Address(RVA = "0x107D9A0", Offset = "0x107C7A0", VA = "0x1107D9A0", Slot = "8")]
  protected override void OnDestroy()
  {
  }

  [Token(Token = "0x6000B4C")]
  [Address(RVA = "0x107D530", Offset = "0x107C330", VA = "0x1107D530", Slot = "4")]
  public override void OnActivate(int pinID)
  {
  }

  [Token(Token = "0x6000B4D")]
  [Address(RVA = "0x107DA50", Offset = "0x107C850", VA = "0x1107DA50")]
  public FlowNode_PlaySE()
  {
  }
}
