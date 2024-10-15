// Decompiled with JetBrains decompiler
// Type: SRPG.AnimEvents.ToggleCharacterFadeColor
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG.AnimEvents
{
  [Token(Token = "0x20032F3")]
  public class ToggleCharacterFadeColor : AnimEvent
  {
    [Token(Token = "0x400EFC8")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Color FadeColor;
    [Token(Token = "0x400EFC9")]
    [FieldOffset(Offset = "0x28")]
    private Color StartColor;
    [Token(Token = "0x400EFCA")]
    [FieldOffset(Offset = "0x38")]
    private UnitController mUnitController;
    [Token(Token = "0x400EFCB")]
    [FieldOffset(Offset = "0x3C")]
    private GeneratedCharacter mGeneratedCharacter;

    [Token(Token = "0x600DFB4")]
    [Address(RVA = "0xAA1340", Offset = "0xAA0140", VA = "0x10AA1340", Slot = "4")]
    public override void OnStart(GameObject go)
    {
    }

    [Token(Token = "0x600DFB5")]
    [Address(RVA = "0xAA1280", Offset = "0xAA0080", VA = "0x10AA1280", Slot = "6")]
    public override void OnEnd(GameObject go)
    {
    }

    [Token(Token = "0x600DFB6")]
    [Address(RVA = "0xAA1440", Offset = "0xAA0240", VA = "0x10AA1440", Slot = "5")]
    public override void OnTick(GameObject go, float ratio)
    {
    }

    [Token(Token = "0x600DFB7")]
    [Address(RVA = "0xAA15A0", Offset = "0xAA03A0", VA = "0x10AA15A0")]
    private void SetRenderMode(float ratio)
    {
    }

    [Token(Token = "0x600DFB8")]
    [Address(RVA = "0xAA1700", Offset = "0xAA0500", VA = "0x10AA1700")]
    public ToggleCharacterFadeColor()
    {
    }
  }
}
