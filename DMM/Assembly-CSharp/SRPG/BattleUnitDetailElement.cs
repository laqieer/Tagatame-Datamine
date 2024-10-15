// Decompiled with JetBrains decompiler
// Type: SRPG.BattleUnitDetailElement
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2000E1D")]
  [AddComponentMenu("Battle/UnitDetail/BattleUnitDetailElement")]
  public class BattleUnitDetailElement : MonoBehaviour
  {
    [Token(Token = "0x4002AB3")]
    [FieldOffset(Offset = "0xC")]
    public ImageArray ImageElement;
    [Token(Token = "0x4002AB4")]
    [FieldOffset(Offset = "0x10")]
    public ImageArray ImageFluct;

    [Token(Token = "0x6003A2B")]
    [Address(RVA = "0x10D7560", Offset = "0x10D6360", VA = "0x110D7560")]
    public void SetElement(EElement elem, BattleUnitDetail.eBudFluct fluct)
    {
    }

    [Token(Token = "0x6003A2C")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public BattleUnitDetailElement()
    {
    }
  }
}
