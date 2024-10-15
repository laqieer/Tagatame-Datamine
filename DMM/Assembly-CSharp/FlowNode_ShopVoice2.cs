// Decompiled with JetBrains decompiler
// Type: FlowNode_ShopVoice2
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
[Token(Token = "0x200021B")]
[FlowNode.Pin(200, "現在の店と一致？", FlowNode.PinTypes.Input, 200)]
[AddComponentMenu("")]
[FlowNode.Pin(2004, "停止", FlowNode.PinTypes.Input, 2004)]
[FlowNode.Pin(2003, "一時再生禁止解除", FlowNode.PinTypes.Input, 2003)]
[FlowNode.Pin(2002, "一時再生禁止", FlowNode.PinTypes.Input, 2002)]
[FlowNode.Pin(2001, "再生終了してから指定時間たつまで待つ", FlowNode.PinTypes.Input, 2001)]
[FlowNode.Pin(2000, "キュー再生", FlowNode.PinTypes.Input, 2000)]
[FlowNode.Pin(3, "NotPlayed", FlowNode.PinTypes.Output, 3)]
[FlowNode.Pin(100, "店タイプ設定", FlowNode.PinTypes.Input, 100)]
[FlowNode.Pin(1003, "イベントボイス再生", FlowNode.PinTypes.Input, 1003)]
[FlowNode.Pin(1001, "退出ボイス再生", FlowNode.PinTypes.Input, 1001)]
[FlowNode.Pin(4, "Yes", FlowNode.PinTypes.Output, 4)]
[FlowNode.Pin(5, "No", FlowNode.PinTypes.Output, 5)]
[FlowNode.Pin(1, "Out", FlowNode.PinTypes.Output, 1)]
[FlowNode.NodeType("Sound/ShopVoice2", 32741)]
[FlowNode.Pin(1000, "入店ボイス再生", FlowNode.PinTypes.Input, 1000)]
[FlowNode.Pin(500, "再生中？", FlowNode.PinTypes.Input, 500)]
[FlowNode.Pin(1002, "時報ボイス再生", FlowNode.PinTypes.Input, 1002)]
[FlowNode.Pin(2, "Played", FlowNode.PinTypes.Output, 2)]
public class FlowNode_ShopVoice2 : FlowNodePersistent
{
  [Token(Token = "0x4000937")]
  [FieldOffset(Offset = "0x0")]
  private static FlowNode_ShopVoice2.EType sType;
  [Token(Token = "0x4000938")]
  [FieldOffset(Offset = "0x18")]
  public FlowNode_ShopVoice2.EType Type;
  [Token(Token = "0x4000939")]
  [FieldOffset(Offset = "0x1C")]
  private MySound.Voice mVoice;
  [Token(Token = "0x400093A")]
  [FieldOffset(Offset = "0x20")]
  private FlowNode_ShopVoice2.EType mType;
  [Token(Token = "0x400093B")]
  [FieldOffset(Offset = "0x24")]
  public string CueID;
  [Token(Token = "0x400093C")]
  [FieldOffset(Offset = "0x28")]
  public bool DirectCueID;
  [Token(Token = "0x400093D")]
  [FieldOffset(Offset = "0x29")]
  public bool ExitCueID;
  [Token(Token = "0x400093E")]
  [FieldOffset(Offset = "0x2C")]
  public float WaitSecAfterPlayEnd;
  [Token(Token = "0x400093F")]
  [FieldOffset(Offset = "0x30")]
  private float mWaitSecAfterPlayEnd;
  [Token(Token = "0x4000940")]
  [FieldOffset(Offset = "0x34")]
  private bool mWaitingForPlayEnd;
  [Token(Token = "0x4000941")]
  [FieldOffset(Offset = "0x35")]
  private bool mDisableIdleVoice;
  [Token(Token = "0x4000942")]
  [FieldOffset(Offset = "0x4")]
  private static int sDisableIdleVoice;
  [Token(Token = "0x4000943")]
  [FieldOffset(Offset = "0x8")]
  private static string sDelayCueID;
  [Token(Token = "0x4000944")]
  [FieldOffset(Offset = "0xC")]
  private static bool sDelayCueIDDirect;
  [Token(Token = "0x4000945")]
  [FieldOffset(Offset = "0x38")]
  public float StopSec;
  [Token(Token = "0x4000946")]
  [FieldOffset(Offset = "0x10")]
  private static List<FlowNode_ShopVoice2.DateEvent>[] sDateEvent;
  [Token(Token = "0x4000947")]
  [FieldOffset(Offset = "0x3C")]
  public string DateEventFileName;

  [Token(Token = "0x6000B7E")]
  [Address(RVA = "0x107FBE0", Offset = "0x107E9E0", VA = "0x1107FBE0", Slot = "8")]
  protected override void OnDestroy()
  {
  }

  [Token(Token = "0x6000B7F")]
  [Address(RVA = "0x107F0B0", Offset = "0x107DEB0", VA = "0x1107F0B0")]
  private void DisableIdleVoice(bool flag)
  {
  }

  [Token(Token = "0x6000B80")]
  [Address(RVA = "0x107F730", Offset = "0x107E530", VA = "0x1107F730", Slot = "4")]
  public override void OnActivate(int pinID)
  {
  }

  [Token(Token = "0x6000B81")]
  [Address(RVA = "0x107FC30", Offset = "0x107EA30", VA = "0x1107FC30")]
  public bool Play(string cueID, bool direct, float stopSec, bool exitPlay) => new bool();

  [Token(Token = "0x6000B82")]
  [Address(RVA = "0x107FDF0", Offset = "0x107EBF0", VA = "0x1107FDF0")]
  private void Update()
  {
  }

  [Token(Token = "0x6000B83")]
  [Address(RVA = "0x107F110", Offset = "0x107DF10", VA = "0x1107F110")]
  public static string GetEventCueID(FlowNode_ShopVoice2.EType type, DateTime dt, string fileName)
  {
    return (string) null;
  }

  [Token(Token = "0x6000B84")]
  [Address(RVA = "0x107FF80", Offset = "0x107ED80", VA = "0x1107FF80")]
  public FlowNode_ShopVoice2()
  {
  }

  [Token(Token = "0x200021C")]
  public enum EType
  {
    [Token(Token = "0x4000949")] none = -1, // 0xFFFFFFFF
    [Token(Token = "0x400094A")] shop = 0,
    [Token(Token = "0x400094B")] sakaba = 1,
    [Token(Token = "0x400094C")] yadoya = 2,
    [Token(Token = "0x400094D")] Num = 3,
  }

  [Token(Token = "0x200021D")]
  private class DateEvent
  {
    [Token(Token = "0x400094E")]
    [FieldOffset(Offset = "0x8")]
    public DateTime startDate;
    [Token(Token = "0x400094F")]
    [FieldOffset(Offset = "0x10")]
    public DateTime endDate;
    [Token(Token = "0x4000950")]
    [FieldOffset(Offset = "0x18")]
    public string cueID;

    [Token(Token = "0x6000B85")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public DateEvent()
    {
    }
  }
}
