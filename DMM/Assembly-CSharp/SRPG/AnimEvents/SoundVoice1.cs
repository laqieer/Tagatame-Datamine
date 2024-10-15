// Decompiled with JetBrains decompiler
// Type: SRPG.AnimEvents.SoundVoice1
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG.AnimEvents
{
  [Token(Token = "0x20032E8")]
  public class SoundVoice1 : AnimEvent
  {
    [Token(Token = "0x400EF91")]
    [FieldOffset(Offset = "0x18")]
    public string SheetName;
    [Token(Token = "0x400EF92")]
    [FieldOffset(Offset = "0x1C")]
    public string CueID;

    [Token(Token = "0x600DF9D")]
    [Address(RVA = "0xAA0070", Offset = "0xA9EE70", VA = "0x10AA0070", Slot = "4")]
    public override void OnStart(GameObject go)
    {
    }

    [Token(Token = "0x600DF9E")]
    [Address(RVA = "0xA9FFD0", Offset = "0xA9EDD0", VA = "0x10A9FFD0", Slot = "6")]
    public override void OnEnd(GameObject go)
    {
    }

    [Token(Token = "0x600DF9F")]
    [Address(RVA = "0x9E0D30", Offset = "0x9DFB30", VA = "0x109E0D30")]
    public SoundVoice1()
    {
    }
  }
}
