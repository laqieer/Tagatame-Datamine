// Decompiled with JetBrains decompiler
// Type: SRPG.AnimEvents.FadeInOut
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG.AnimEvents
{
  [Token(Token = "0x20032DC")]
  public class FadeInOut : AnimEvent
  {
    [Token(Token = "0x400EF7E")]
    [FieldOffset(Offset = "0x18")]
    public bool IsFadeOut;
    [Token(Token = "0x400EF7F")]
    [FieldOffset(Offset = "0x19")]
    public bool IsAdditive;
    [Token(Token = "0x400EF80")]
    [FieldOffset(Offset = "0x1C")]
    public Color FadeColor;

    [Token(Token = "0x600DF87")]
    [Address(RVA = "0xA91A10", Offset = "0xA90810", VA = "0x10A91A10", Slot = "4")]
    public override void OnStart(GameObject go)
    {
    }

    [Token(Token = "0x600DF88")]
    [Address(RVA = "0xA91A70", Offset = "0xA90870", VA = "0x10A91A70")]
    public FadeInOut()
    {
    }
  }
}
