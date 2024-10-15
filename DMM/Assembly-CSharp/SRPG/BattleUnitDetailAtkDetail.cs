// Decompiled with JetBrains decompiler
// Type: SRPG.BattleUnitDetailAtkDetail
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Text;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2000E19")]
  [AddComponentMenu("Battle/UnitDetail/BattleUnitDetailAtkDetail")]
  public class BattleUnitDetailAtkDetail : MonoBehaviour
  {
    [Token(Token = "0x4002A9B")]
    [FieldOffset(Offset = "0xC")]
    public ImageArray ImageAtkDetail;
    [Token(Token = "0x4002A9C")]
    [FieldOffset(Offset = "0x10")]
    public ImageArray ImageFluct;
    [Token(Token = "0x4002A9D")]
    [FieldOffset(Offset = "0x14")]
    public GameObject GoResist;
    [Token(Token = "0x4002A9E")]
    [FieldOffset(Offset = "0x18")]
    public GameObject GoAvoid;
    [Token(Token = "0x4002A9F")]
    [FieldOffset(Offset = "0x1C")]
    public UnityEngine.UI.Text TextValue;
    [Token(Token = "0x4002AA0")]
    [FieldOffset(Offset = "0x0")]
    private static string[] mStrAtkDetails;
    [Token(Token = "0x4002AA1")]
    [FieldOffset(Offset = "0x4")]
    private static string[] mStrTypes;

    [Token(Token = "0x6003A1E")]
    [Address(RVA = "0x10D5A30", Offset = "0x10D4830", VA = "0x110D5A30")]
    public void SetAll(
      BattleUnitDetailAtkDetail.eAllType all_type,
      BattleUnitDetail.eBudFluct fluct,
      string addMsg = "")
    {
    }

    [Token(Token = "0x6003A1F")]
    [Address(RVA = "0x10D5980", Offset = "0x10D4780", VA = "0x110D5980")]
    private void AddUpDownText(StringBuilder sb, BattleUnitDetail.eBudFluct fluct)
    {
    }

    [Token(Token = "0x6003A20")]
    [Address(RVA = "0x10D5CA0", Offset = "0x10D4AA0", VA = "0x110D5CA0")]
    public void SetAtkDetail(
      AttackDetailTypes atk_detail,
      BattleUnitDetailAtkDetail.eType type,
      BattleUnitDetail.eBudFluct fluct,
      string addMsg = "")
    {
    }

    [Token(Token = "0x6003A21")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public BattleUnitDetailAtkDetail()
    {
    }

    [Token(Token = "0x6003A22")]
    [Address(RVA = "0x10D5FC0", Offset = "0x10D4DC0", VA = "0x110D5FC0")]
    static BattleUnitDetailAtkDetail()
    {
    }

    [Token(Token = "0x2000E1A")]
    public enum eType
    {
      [Token(Token = "0x4002AA3")] ASSIST,
      [Token(Token = "0x4002AA4")] RESIST,
      [Token(Token = "0x4002AA5")] AVOID,
      [Token(Token = "0x4002AA6")] MAX,
    }

    [Token(Token = "0x2000E1B")]
    public enum eAllType
    {
      [Token(Token = "0x4002AA8")] HIT = 7,
      [Token(Token = "0x4002AAF")] MIN = 7,
      [Token(Token = "0x4002AA9")] AVOID = 8,
      [Token(Token = "0x4002AAA")] RECOVER = 9,
      [Token(Token = "0x4002AAB")] CRI_DMG = 10, // 0x0000000A
      [Token(Token = "0x4002AAC")] REFLECTION = 11, // 0x0000000B
      [Token(Token = "0x4002AAD")] ABSORPTION = 12, // 0x0000000C
      [Token(Token = "0x4002AAE")] MAX = 13, // 0x0000000D
    }
  }
}
