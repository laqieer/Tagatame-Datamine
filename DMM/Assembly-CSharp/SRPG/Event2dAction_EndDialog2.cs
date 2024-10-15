// Decompiled with JetBrains decompiler
// Type: SRPG.Event2dAction_EndDialog2
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001288")]
  [EventActionInfo("New/会話/閉じる(2D)", "表示されている吹き出しを閉じます", 5592405, 4473992)]
  public class Event2dAction_EndDialog2 : EventAction
  {
    [Token(Token = "0x4004490")]
    [FieldOffset(Offset = "0x18")]
    [StringIsActorID]
    public string ActorID;
    [Token(Token = "0x4004491")]
    [FieldOffset(Offset = "0x1C")]
    private EventDialogBubbleCustom mBubble;
    [Token(Token = "0x4004492")]
    [FieldOffset(Offset = "0x20")]
    public bool Async;
    [Token(Token = "0x4004493")]
    [FieldOffset(Offset = "0x24")]
    public float FadeTime;
    [Token(Token = "0x4004494")]
    [FieldOffset(Offset = "0x28")]
    private float fadingTime;
    [Token(Token = "0x4004495")]
    [FieldOffset(Offset = "0x2C")]
    private bool IsFading;
    [Token(Token = "0x4004496")]
    [FieldOffset(Offset = "0x30")]
    private List<GameObject> fadeInList;
    [Token(Token = "0x4004497")]
    [FieldOffset(Offset = "0x34")]
    private List<CanvasGroup> fadeInParticleList;

    [Token(Token = "0x6004E89")]
    [Address(RVA = "0x123CC70", Offset = "0x123BA70", VA = "0x1123CC70", Slot = "4")]
    public override void OnActivate()
    {
    }

    [Token(Token = "0x6004E8A")]
    [Address(RVA = "0x123D2F0", Offset = "0x123C0F0", VA = "0x1123D2F0", Slot = "6")]
    public override void Update()
    {
    }

    [Token(Token = "0x6004E8B")]
    [Address(RVA = "0x123C700", Offset = "0x123B500", VA = "0x1123C700")]
    private void FadeIn(float time)
    {
    }

    [Token(Token = "0x6004E8C")]
    [Address(RVA = "0x123D370", Offset = "0x123C170", VA = "0x1123D370")]
    public Event2dAction_EndDialog2()
    {
    }
  }
}
