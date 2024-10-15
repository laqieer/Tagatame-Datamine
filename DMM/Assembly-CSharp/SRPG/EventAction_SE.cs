// Decompiled with JetBrains decompiler
// Type: SRPG.EventAction_SE
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001234")]
  [EventActionInfo("New/SE再生", "SEを再生します", 4478293, 4491400)]
  public class EventAction_SE : EventAction
  {
    [Token(Token = "0x40042F2")]
    [FieldOffset(Offset = "0x18")]
    public string m_CueName;
    [Token(Token = "0x40042F3")]
    [FieldOffset(Offset = "0x1C")]
    public bool m_Async;
    [Token(Token = "0x40042F4")]
    [FieldOffset(Offset = "0x20")]
    public float m_Delay;
    [Token(Token = "0x40042F5")]
    [FieldOffset(Offset = "0x24")]
    [HideInInspector]
    public float m_Wait;
    [Token(Token = "0x40042F6")]
    [FieldOffset(Offset = "0x28")]
    private bool m_bPlay;

    [Token(Token = "0x6004D24")]
    [Address(RVA = "0x122E9E0", Offset = "0x122D7E0", VA = "0x1122E9E0", Slot = "4")]
    public override void OnActivate()
    {
    }

    [Token(Token = "0x6004D25")]
    [Address(RVA = "0x122EAB0", Offset = "0x122D8B0", VA = "0x1122EAB0", Slot = "6")]
    public override void Update()
    {
    }

    [Token(Token = "0x6004D26")]
    [Address(RVA = "0x9E0D30", Offset = "0x9DFB30", VA = "0x109E0D30")]
    public EventAction_SE()
    {
    }
  }
}
