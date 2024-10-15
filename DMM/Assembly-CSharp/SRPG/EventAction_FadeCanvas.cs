// Decompiled with JetBrains decompiler
// Type: SRPG.EventAction_FadeCanvas
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001202")]
  [EventActionInfo("オブジェクト/キャンバスフェード", "Canvasをフェードさせます", 5592405, 4473992)]
  public class EventAction_FadeCanvas : EventAction
  {
    [Token(Token = "0x4004188")]
    [FieldOffset(Offset = "0x18")]
    public AnimationCurve Curve;
    [Token(Token = "0x4004189")]
    [FieldOffset(Offset = "0x1C")]
    public string CanvasID;
    [Token(Token = "0x400418A")]
    [FieldOffset(Offset = "0x20")]
    private CanvasGroup[] mCanvasGroup;
    [Token(Token = "0x400418B")]
    [FieldOffset(Offset = "0x24")]
    private float mTime;
    [Token(Token = "0x400418C")]
    [FieldOffset(Offset = "0x28")]
    public float Time;

    [Token(Token = "0x6004C97")]
    [Address(RVA = "0x1219960", Offset = "0x1218760", VA = "0x11219960", Slot = "4")]
    public override void OnActivate()
    {
    }

    [Token(Token = "0x6004C98")]
    [Address(RVA = "0x1219AC0", Offset = "0x12188C0", VA = "0x11219AC0", Slot = "6")]
    public override void Update()
    {
    }

    [Token(Token = "0x6004C99")]
    [Address(RVA = "0x1219950", Offset = "0x1218750", VA = "0x11219950", Slot = "11")]
    public override void GoToEndState()
    {
    }

    [Token(Token = "0x6004C9A")]
    [Address(RVA = "0x1219950", Offset = "0x1218750", VA = "0x11219950", Slot = "10")]
    public override void SkipImmediate()
    {
    }

    [Token(Token = "0x6004C9B")]
    [Address(RVA = "0x1219CD0", Offset = "0x1218AD0", VA = "0x11219CD0")]
    public EventAction_FadeCanvas()
    {
    }
  }
}
