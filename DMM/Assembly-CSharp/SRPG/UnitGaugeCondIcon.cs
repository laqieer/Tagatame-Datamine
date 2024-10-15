// Decompiled with JetBrains decompiler
// Type: SRPG.UnitGaugeCondIcon
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2000C6A")]
  [AddComponentMenu("Battle/BattleUI/UnitGaugeCondIcon")]
  public class UnitGaugeCondIcon : MonoBehaviour
  {
    [Token(Token = "0x4002180")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private ImageArray ImageCond;
    [Token(Token = "0x4002181")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private Text TextTurn;

    [Token(Token = "0x60030F2")]
    [Address(RVA = "0x102E640", Offset = "0x102D440", VA = "0x1102E640")]
    public bool IsDisableTurn(EUnitCondition condition) => new bool();

    [Token(Token = "0x60030F3")]
    [Address(RVA = "0x102E670", Offset = "0x102D470", VA = "0x1102E670")]
    public void SetCond(CondAttachment ca)
    {
    }

    [Token(Token = "0x60030F4")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public UnitGaugeCondIcon()
    {
    }
  }
}
