// Decompiled with JetBrains decompiler
// Type: SRPG.AnimEvents.ChangeBGM
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG.AnimEvents
{
  [Token(Token = "0x20032DA")]
  public class ChangeBGM : AnimEvent
  {
    [Token(Token = "0x400EF7C")]
    [FieldOffset(Offset = "0x18")]
    public string BgmId;

    [Token(Token = "0x600DF84")]
    [Address(RVA = "0xA90870", Offset = "0xA8F670", VA = "0x10A90870", Slot = "4")]
    public override void OnStart(GameObject go)
    {
    }

    [Token(Token = "0x600DF85")]
    [Address(RVA = "0xA90910", Offset = "0xA8F710", VA = "0x10A90910")]
    public ChangeBGM()
    {
    }
  }
}
