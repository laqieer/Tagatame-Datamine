// Decompiled with JetBrains decompiler
// Type: SRPG.AnimEvents.ToggleChanging
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG.AnimEvents
{
  [Token(Token = "0x20032F2")]
  public class ToggleChanging : AnimEvent
  {
    [Token(Token = "0x400EFC3")]
    [FieldOffset(Offset = "0x18")]
    private bool mIsValid;
    [Token(Token = "0x400EFC4")]
    [FieldOffset(Offset = "0x1C")]
    private Vector3 mPlayerPos;
    [Token(Token = "0x400EFC5")]
    [FieldOffset(Offset = "0x28")]
    private Vector3 mTargetPos;
    [Token(Token = "0x400EFC6")]
    [FieldOffset(Offset = "0x34")]
    private TacticsUnitController mPlayerController;
    [Token(Token = "0x400EFC7")]
    [FieldOffset(Offset = "0x38")]
    private TacticsUnitController mTargetController;

    [Token(Token = "0x600DFB0")]
    [Address(RVA = "0xAA0E50", Offset = "0xA9FC50", VA = "0x10AA0E50", Slot = "4")]
    public override void OnStart(GameObject go)
    {
    }

    [Token(Token = "0x600DFB1")]
    [Address(RVA = "0xAA1050", Offset = "0xA9FE50", VA = "0x10AA1050", Slot = "5")]
    public override void OnTick(GameObject go, float ratio)
    {
    }

    [Token(Token = "0x600DFB2")]
    [Address(RVA = "0xAA0C00", Offset = "0xA9FA00", VA = "0x10AA0C00", Slot = "6")]
    public override void OnEnd(GameObject go)
    {
    }

    [Token(Token = "0x600DFB3")]
    [Address(RVA = "0x9E0D30", Offset = "0x9DFB30", VA = "0x109E0D30")]
    public ToggleChanging()
    {
    }
  }
}
