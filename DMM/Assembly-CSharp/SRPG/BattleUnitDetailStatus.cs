// Decompiled with JetBrains decompiler
// Type: SRPG.BattleUnitDetailStatus
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2000E1E")]
  [AddComponentMenu("Battle/UnitDetail/BattleUnitDetailStatus")]
  public class BattleUnitDetailStatus : MonoBehaviour
  {
    [Token(Token = "0x4002AB5")]
    [FieldOffset(Offset = "0xC")]
    public Text StatusValue;
    [Token(Token = "0x4002AB6")]
    [FieldOffset(Offset = "0x10")]
    public Text StatusValueUp;
    [Token(Token = "0x4002AB7")]
    [FieldOffset(Offset = "0x14")]
    public Text StatusValueDown;
    [Token(Token = "0x4002AB8")]
    [FieldOffset(Offset = "0x18")]
    public GameObject GoUpBG;
    [Token(Token = "0x4002AB9")]
    [FieldOffset(Offset = "0x1C")]
    public GameObject GoDownBG;
    [Token(Token = "0x4002ABA")]
    [FieldOffset(Offset = "0x20")]
    public Text UpDownValue;

    [Token(Token = "0x6003A2D")]
    [Address(RVA = "0x10D7660", Offset = "0x10D6460", VA = "0x110D7660")]
    public void SetStatus(BattleUnitDetailStatus.eBudStat stat, long val, long add)
    {
    }

    [Token(Token = "0x6003A2E")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public BattleUnitDetailStatus()
    {
    }

    [Token(Token = "0x2000E1F")]
    public enum eBudStat
    {
      [Token(Token = "0x4002ABC")] MHP,
      [Token(Token = "0x4002ABD")] MMP,
      [Token(Token = "0x4002ABE")] ATK,
      [Token(Token = "0x4002ABF")] DEF,
      [Token(Token = "0x4002AC0")] MAG,
      [Token(Token = "0x4002AC1")] MND,
      [Token(Token = "0x4002AC2")] DEX,
      [Token(Token = "0x4002AC3")] SPD,
      [Token(Token = "0x4002AC4")] CRI,
      [Token(Token = "0x4002AC5")] LUK,
      [Token(Token = "0x4002AC6")] CMB,
      [Token(Token = "0x4002AC7")] MOV,
      [Token(Token = "0x4002AC8")] JMP,
      [Token(Token = "0x4002AC9")] MAX,
    }
  }
}
