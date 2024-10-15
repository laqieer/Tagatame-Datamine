// Decompiled with JetBrains decompiler
// Type: SRPG.AnimEvents.ToggleTeleport
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG.AnimEvents
{
  [Token(Token = "0x20032F6")]
  public class ToggleTeleport : AnimEvent
  {
    [Token(Token = "0x400EFCE")]
    [FieldOffset(Offset = "0x18")]
    private bool mIsValid;
    [Token(Token = "0x400EFCF")]
    [FieldOffset(Offset = "0x1C")]
    private Vector3 mPosStart;
    [Token(Token = "0x400EFD0")]
    [FieldOffset(Offset = "0x28")]
    private Vector3 mPosEnd;

    [Token(Token = "0x600DFC1")]
    [Address(RVA = "0xAA1E50", Offset = "0xAA0C50", VA = "0x10AA1E50", Slot = "4")]
    public override void OnStart(GameObject go)
    {
    }

    [Token(Token = "0x600DFC2")]
    [Address(RVA = "0xAA1F80", Offset = "0xAA0D80", VA = "0x10AA1F80", Slot = "5")]
    public override void OnTick(GameObject go, float ratio)
    {
    }

    [Token(Token = "0x600DFC3")]
    [Address(RVA = "0xAA1CD0", Offset = "0xAA0AD0", VA = "0x10AA1CD0", Slot = "6")]
    public override void OnEnd(GameObject go)
    {
    }

    [Token(Token = "0x600DFC4")]
    [Address(RVA = "0x9E0D30", Offset = "0x9DFB30", VA = "0x109E0D30")]
    public ToggleTeleport()
    {
    }
  }
}
