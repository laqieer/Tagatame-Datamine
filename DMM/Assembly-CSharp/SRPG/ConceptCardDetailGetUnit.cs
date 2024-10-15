// Decompiled with JetBrains decompiler
// Type: SRPG.ConceptCardDetailGetUnit
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20021EA")]
  [AddComponentMenu("UI/ConceptCardDetailGetUnit")]
  public class ConceptCardDetailGetUnit : ConceptCardDetailBase
  {
    [Token(Token = "0x400952B")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private Text UnitName;
    [Token(Token = "0x400952C")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private ButtonEvent UnitDetailBtn;
    [Token(Token = "0x400952D")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private GameObject UnitObj;

    [Token(Token = "0x6008F57")]
    [Address(RVA = "0x526C30", Offset = "0x525A30", VA = "0x10526C30", Slot = "7")]
    public override void Refresh()
    {
    }

    [Token(Token = "0x6008F58")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public ConceptCardDetailGetUnit()
    {
    }
  }
}
