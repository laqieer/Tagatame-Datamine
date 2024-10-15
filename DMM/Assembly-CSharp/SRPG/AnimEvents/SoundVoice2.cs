// Decompiled with JetBrains decompiler
// Type: SRPG.AnimEvents.SoundVoice2
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG.AnimEvents
{
  [Token(Token = "0x20032E9")]
  public class SoundVoice2 : AnimEvent
  {
    [Token(Token = "0x400EF93")]
    [FieldOffset(Offset = "0x18")]
    public UnitVoice.ECharType CharType;
    [Token(Token = "0x400EF94")]
    [FieldOffset(Offset = "0x1C")]
    public UnitVoice.eCollaboType CollaboType;
    [Token(Token = "0x400EF95")]
    [FieldOffset(Offset = "0x20")]
    public string DirectCharName;
    [Token(Token = "0x400EF96")]
    [FieldOffset(Offset = "0x24")]
    public string DirectSkinName;
    [Token(Token = "0x400EF97")]
    [FieldOffset(Offset = "0x28")]
    public string CueName;

    [Token(Token = "0x600DFA0")]
    [Address(RVA = "0xAA0260", Offset = "0xA9F060", VA = "0x10AA0260", Slot = "4")]
    public override void OnStart(GameObject go)
    {
    }

    [Token(Token = "0x600DFA1")]
    [Address(RVA = "0xAA01C0", Offset = "0xA9EFC0", VA = "0x10AA01C0", Slot = "6")]
    public override void OnEnd(GameObject go)
    {
    }

    [Token(Token = "0x600DFA2")]
    [Address(RVA = "0x9E0D30", Offset = "0x9DFB30", VA = "0x109E0D30")]
    public SoundVoice2()
    {
    }
  }
}
