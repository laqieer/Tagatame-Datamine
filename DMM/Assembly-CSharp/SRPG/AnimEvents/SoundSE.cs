// Decompiled with JetBrains decompiler
// Type: SRPG.AnimEvents.SoundSE
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG.AnimEvents
{
  [Token(Token = "0x20032E7")]
  public class SoundSE : AnimEvent
  {
    [Token(Token = "0x400EF8F")]
    [FieldOffset(Offset = "0x18")]
    public CustomSound.EType SoundType;
    [Token(Token = "0x400EF90")]
    [FieldOffset(Offset = "0x1C")]
    public string CueID;

    [Token(Token = "0x600DF9A")]
    [Address(RVA = "0xA9FED0", Offset = "0xA9ECD0", VA = "0x10A9FED0", Slot = "4")]
    public override void OnStart(GameObject go)
    {
    }

    [Token(Token = "0x600DF9B")]
    [Address(RVA = "0xA9FE30", Offset = "0xA9EC30", VA = "0x10A9FE30", Slot = "6")]
    public override void OnEnd(GameObject go)
    {
    }

    [Token(Token = "0x600DF9C")]
    [Address(RVA = "0x9E0D30", Offset = "0x9DFB30", VA = "0x109E0D30")]
    public SoundSE()
    {
    }
  }
}
