// Decompiled with JetBrains decompiler
// Type: SRPG.AnimEvents.ResetAttachment
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG.AnimEvents
{
  [Token(Token = "0x20032E5")]
  public class ResetAttachment : AnimEvent
  {
    [Token(Token = "0x400EF89")]
    [FieldOffset(Offset = "0x18")]
    public bool IsNoResetPrimaryHand;
    [Token(Token = "0x400EF8A")]
    [FieldOffset(Offset = "0x19")]
    public bool IsNoResetSecondaryHand;
    [Token(Token = "0x400EF8B")]
    [FieldOffset(Offset = "0x1A")]
    public bool IsNoResetTertiaryPlace;

    [Token(Token = "0x600DF96")]
    [Address(RVA = "0xA9FC10", Offset = "0xA9EA10", VA = "0x10A9FC10", Slot = "4")]
    public override void OnStart(GameObject go)
    {
    }

    [Token(Token = "0x600DF97")]
    [Address(RVA = "0x9E0D30", Offset = "0x9DFB30", VA = "0x109E0D30")]
    public ResetAttachment()
    {
    }
  }
}
