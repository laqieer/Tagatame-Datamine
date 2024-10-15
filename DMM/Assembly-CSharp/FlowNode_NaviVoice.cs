// Decompiled with JetBrains decompiler
// Type: FlowNode_NaviVoice
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
[Token(Token = "0x20001ED")]
[FlowNode.Pin(109, "設定画面", FlowNode.PinTypes.Input, 109)]
[AddComponentMenu("")]
[FlowNode.Pin(106, "プレゼント画面", FlowNode.PinTypes.Input, 106)]
[FlowNode.Pin(2, "再生終了", FlowNode.PinTypes.Output, 2)]
[FlowNode.Pin(1, "Out", FlowNode.PinTypes.Output, 1)]
[FlowNode.NodeType("Sound/NaviVoice", 32741)]
[FlowNode.Pin(107, "アイテム画面", FlowNode.PinTypes.Input, 107)]
[FlowNode.Pin(108, "ヘルプ画面", FlowNode.PinTypes.Input, 108)]
[FlowNode.Pin(110, "招待ページ", FlowNode.PinTypes.Input, 110)]
[FlowNode.Pin(103, "編成画面", FlowNode.PinTypes.Input, 103)]
[FlowNode.Pin(105, "ガチャ画面", FlowNode.PinTypes.Input, 105)]
[FlowNode.Pin(104, "ユニット強化画面", FlowNode.PinTypes.Input, 104)]
[FlowNode.Pin(111, "レベルアップ", FlowNode.PinTypes.Input, 111)]
[FlowNode.Pin(102, "放置OFF", FlowNode.PinTypes.Input, 102)]
[FlowNode.Pin(101, "放置ON", FlowNode.PinTypes.Input, 101)]
public class FlowNode_NaviVoice : FlowNodePersistent
{
  [Token(Token = "0x400088E")]
  [FieldOffset(Offset = "0x18")]
  [SerializeField]
  private bool isNaviVoiceOnly;
  [Token(Token = "0x400088F")]
  [FieldOffset(Offset = "0x1C")]
  private MySound.Voice mVoice;
  [Token(Token = "0x4000890")]
  [FieldOffset(Offset = "0x20")]
  private bool mWaitingForPlayEnd;
  [Token(Token = "0x4000891")]
  [FieldOffset(Offset = "0x21")]
  private bool mPlayIdleVoice;
  [Token(Token = "0x4000892")]
  [FieldOffset(Offset = "0x24")]
  private float mPlayIdleVoiceWait;
  [Token(Token = "0x4000893")]
  [FieldOffset(Offset = "0x28")]
  private float IdleVoiceWaitTime;
  [Token(Token = "0x4000894")]
  [FieldOffset(Offset = "0x2C")]
  private List<string> mNotifyCueList;
  [Token(Token = "0x4000895")]
  [FieldOffset(Offset = "0x30")]
  private System.Random mRandom;

  [Token(Token = "0x6000AF6")]
  [Address(RVA = "0xF4F2F0", Offset = "0xF4E0F0", VA = "0x10F4F2F0", Slot = "7")]
  protected override void Awake()
  {
  }

  [Token(Token = "0x6000AF7")]
  [Address(RVA = "0xF4F370", Offset = "0xF4E170", VA = "0x10F4F370", Slot = "4")]
  public override void OnActivate(int pinID)
  {
  }

  [Token(Token = "0x6000AF8")]
  [Address(RVA = "0xF4F770", Offset = "0xF4E570", VA = "0x10F4F770")]
  public void Play(string cueID)
  {
  }

  [Token(Token = "0x6000AF9")]
  [Address(RVA = "0xF4F7D0", Offset = "0xF4E5D0", VA = "0x10F4F7D0")]
  private void Update()
  {
  }

  [Token(Token = "0x6000AFA")]
  [Address(RVA = "0xF4F960", Offset = "0xF4E760", VA = "0x10F4F960")]
  public FlowNode_NaviVoice()
  {
  }
}
