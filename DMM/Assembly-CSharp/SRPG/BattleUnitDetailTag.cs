// Decompiled with JetBrains decompiler
// Type: SRPG.BattleUnitDetailTag
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2000E20")]
  [AddComponentMenu("Battle/UnitDetail/BattleUnitDetailTag")]
  public class BattleUnitDetailTag : MonoBehaviour
  {
    [Token(Token = "0x4002ACA")]
    [FieldOffset(Offset = "0xC")]
    public Text TextValue;

    [Token(Token = "0x6003A2F")]
    [Address(RVA = "0x10D7BF0", Offset = "0x10D69F0", VA = "0x110D7BF0")]
    public void SetTag(string tag)
    {
    }

    [Token(Token = "0x6003A30")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public BattleUnitDetailTag()
    {
    }
  }
}
