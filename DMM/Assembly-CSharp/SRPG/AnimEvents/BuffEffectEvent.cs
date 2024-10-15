// Decompiled with JetBrains decompiler
// Type: SRPG.AnimEvents.BuffEffectEvent
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG.AnimEvents
{
  [Token(Token = "0x20032D5")]
  public class BuffEffectEvent : AnimEvent
  {
    [Token(Token = "0x400EF6A")]
    [FieldOffset(Offset = "0x18")]
    public bool IsDispTarget;
    [Token(Token = "0x400EF6B")]
    [FieldOffset(Offset = "0x19")]
    public bool IsDispSelf;

    [Token(Token = "0x600DF7E")]
    [Address(RVA = "0xA8FDC0", Offset = "0xA8EBC0", VA = "0x10A8FDC0", Slot = "4")]
    public override void OnStart(GameObject go)
    {
    }

    [Token(Token = "0x600DF7F")]
    [Address(RVA = "0xA8FE60", Offset = "0xA8EC60", VA = "0x10A8FE60")]
    public BuffEffectEvent()
    {
    }
  }
}
