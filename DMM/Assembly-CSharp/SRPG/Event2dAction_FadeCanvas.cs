// Decompiled with JetBrains decompiler
// Type: SRPG.Event2dAction_FadeCanvas
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200128D")]
  [EventActionInfo("オブジェクト/キャンバスフェード(2D)", "Canvasをフェードさせます", 5592405, 4473992)]
  public class Event2dAction_FadeCanvas : EventAction
  {
    [Token(Token = "0x40044A0")]
    [FieldOffset(Offset = "0x18")]
    public AnimationCurve Curve;
    [Token(Token = "0x40044A1")]
    [FieldOffset(Offset = "0x1C")]
    public string CanvasID;
    [Token(Token = "0x40044A2")]
    [FieldOffset(Offset = "0x20")]
    private CanvasGroup[] mCanvasGroup;
    [Token(Token = "0x40044A3")]
    [FieldOffset(Offset = "0x24")]
    private float mTime;
    [Token(Token = "0x40044A4")]
    [FieldOffset(Offset = "0x28")]
    public float Time;
    [Token(Token = "0x40044A5")]
    [FieldOffset(Offset = "0x2C")]
    public bool async;

    [Token(Token = "0x6004E98")]
    [Address(RVA = "0x123DAC0", Offset = "0x123C8C0", VA = "0x1123DAC0", Slot = "4")]
    public override void OnActivate()
    {
    }

    [Token(Token = "0x6004E99")]
    [Address(RVA = "0x123DC40", Offset = "0x123CA40", VA = "0x1123DC40", Slot = "6")]
    public override void Update()
    {
    }

    [Token(Token = "0x6004E9A")]
    [Address(RVA = "0x123DE70", Offset = "0x123CC70", VA = "0x1123DE70")]
    public Event2dAction_FadeCanvas()
    {
    }
  }
}
