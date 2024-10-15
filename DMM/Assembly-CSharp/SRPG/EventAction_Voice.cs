// Decompiled with JetBrains decompiler
// Type: SRPG.EventAction_Voice
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001257")]
  [EventActionInfo("New/ボイス再生", "ボイスを再生します。", 4478293, 4491400)]
  internal class EventAction_Voice : EventAction
  {
    [Token(Token = "0x4004399")]
    [FieldOffset(Offset = "0x18")]
    public string m_VoiceName;
    [Token(Token = "0x400439A")]
    [FieldOffset(Offset = "0x1C")]
    [StringIsActorID]
    public bool m_Async;
    [Token(Token = "0x400439B")]
    [FieldOffset(Offset = "0x20")]
    [HideInInspector]
    public float m_Delay;
    [Token(Token = "0x400439C")]
    [FieldOffset(Offset = "0x24")]
    private MySound.Voice m_Voice;
    [Token(Token = "0x400439D")]
    [FieldOffset(Offset = "0x28")]
    private bool m_Play;

    [Token(Token = "0x6004DAF")]
    [Address(RVA = "0x1232340", Offset = "0x1231140", VA = "0x11232340", Slot = "4")]
    public override void OnActivate()
    {
    }

    [Token(Token = "0x6004DB0")]
    [Address(RVA = "0x1232450", Offset = "0x1231250", VA = "0x11232450", Slot = "6")]
    public override void Update()
    {
    }

    [Token(Token = "0x6004DB1")]
    [Address(RVA = "0x1232380", Offset = "0x1231180", VA = "0x11232380")]
    private bool PlayVoice() => new bool();

    [Token(Token = "0x6004DB2")]
    [Address(RVA = "0x9E0D30", Offset = "0x9DFB30", VA = "0x109E0D30")]
    public EventAction_Voice()
    {
    }
  }
}
