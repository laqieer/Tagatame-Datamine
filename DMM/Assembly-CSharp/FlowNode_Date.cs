// Decompiled with JetBrains decompiler
// Type: FlowNode_Date
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
[Token(Token = "0x20001CF")]
[AddComponentMenu("")]
[FlowNode.Pin(1005, ">= CompareValue", FlowNode.PinTypes.Output, 1005)]
[FlowNode.Pin(1004, "> CompareValue", FlowNode.PinTypes.Output, 1004)]
[FlowNode.Pin(1003, "<= CompareValue", FlowNode.PinTypes.Output, 1003)]
[FlowNode.Pin(1002, "< CompareValue", FlowNode.PinTypes.Output, 1002)]
[FlowNode.Pin(1001, "!= CompareValue", FlowNode.PinTypes.Output, 1001)]
[FlowNode.Pin(1000, "== CompareValue", FlowNode.PinTypes.Output, 1000)]
[FlowNode.Pin(503, "日も時刻も変わらず", FlowNode.PinTypes.Output, 503)]
[FlowNode.Pin(104, "CompareDay", FlowNode.PinTypes.Input, 104)]
[FlowNode.Pin(501, "時刻が変わった(日は変わらず)", FlowNode.PinTypes.Output, 501)]
[FlowNode.NodeType("Common/Date", 32741)]
[FlowNode.Pin(99, "Reset", FlowNode.PinTypes.Input, 99)]
[FlowNode.Pin(100, "Update", FlowNode.PinTypes.Input, 100)]
[FlowNode.Pin(500, "Updated", FlowNode.PinTypes.Output, 500)]
[FlowNode.Pin(102, "CompareHour", FlowNode.PinTypes.Input, 102)]
[FlowNode.Pin(103, "CompareMonth", FlowNode.PinTypes.Input, 103)]
[FlowNode.Pin(105, "CompareYear", FlowNode.PinTypes.Input, 105)]
[FlowNode.Pin(101, "CompareDate", FlowNode.PinTypes.Input, 101)]
[FlowNode.Pin(502, "日が変わった", FlowNode.PinTypes.Output, 502)]
public class FlowNode_Date : FlowNode
{
  [Token(Token = "0x400083F")]
  [FieldOffset(Offset = "0x18")]
  public int CompareYear;
  [Token(Token = "0x4000840")]
  [FieldOffset(Offset = "0x1C")]
  public int CompareMonth;
  [Token(Token = "0x4000841")]
  [FieldOffset(Offset = "0x20")]
  public int CompareDay;
  [Token(Token = "0x4000842")]
  [FieldOffset(Offset = "0x24")]
  public int CompareHour;
  [Token(Token = "0x4000843")]
  [FieldOffset(Offset = "0x0")]
  private static DateTime sDate;

  [Token(Token = "0x6000A83")]
  [Address(RVA = "0xF48B20", Offset = "0xF47920", VA = "0x10F48B20", Slot = "7")]
  protected override void Awake()
  {
  }

  [Token(Token = "0x6000A84")]
  [Address(RVA = "0xF48E90", Offset = "0xF47C90", VA = "0x10F48E90", Slot = "4")]
  public override void OnActivate(int pinID)
  {
  }

  [Token(Token = "0x6000A85")]
  [Address(RVA = "0xF48B90", Offset = "0xF47990", VA = "0x10F48B90")]
  private void CheckResult(DateTime target, DateTime compare)
  {
  }

  [Token(Token = "0x6000A86")]
  [Address(RVA = "0xF48CF0", Offset = "0xF47AF0", VA = "0x10F48CF0")]
  private void CheckResult(int target, int compare)
  {
  }

  [Token(Token = "0x6000A87")]
  [Address(RVA = "0xF48D70", Offset = "0xF47B70", VA = "0x10F48D70")]
  private DateTime CheckUpdate(DateTime dt, DateTime dtOld) => new DateTime();

  [Token(Token = "0x6000A88")]
  [Address(RVA = "0xF493A0", Offset = "0xF481A0", VA = "0x10F493A0")]
  public FlowNode_Date()
  {
  }
}
