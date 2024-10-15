// Decompiled with JetBrains decompiler
// Type: SRPG.BattleUnitDetailCond
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2000E1C")]
  [AddComponentMenu("Battle/UnitDetail/BattleUnitDetailCond")]
  public class BattleUnitDetailCond : MonoBehaviour
  {
    [Token(Token = "0x4002AB0")]
    [FieldOffset(Offset = "0xC")]
    public ImageArray ImageCond;
    [Token(Token = "0x4002AB1")]
    [FieldOffset(Offset = "0x10")]
    public Text TextValue;
    [Token(Token = "0x4002AB2")]
    [FieldOffset(Offset = "0x14")]
    private string[] mStrShieldDesc;

    [Token(Token = "0x6003A23")]
    [Address(RVA = "0x10D6F10", Offset = "0x10D5D10", VA = "0x110D6F10")]
    public void SetCond(EUnitCondition cond, CondAttachment ca, Unit unit)
    {
    }

    [Token(Token = "0x6003A24")]
    [Address(RVA = "0x10D6B10", Offset = "0x10D5910", VA = "0x110D6B10")]
    public void SetCondShield(ShieldTypes s_type, int val)
    {
    }

    [Token(Token = "0x6003A25")]
    [Address(RVA = "0x10D6720", Offset = "0x10D5520", VA = "0x110D6720")]
    public void SetCondForcedTargeting()
    {
    }

    [Token(Token = "0x6003A26")]
    [Address(RVA = "0x10D65D0", Offset = "0x10D53D0", VA = "0x110D65D0")]
    public void SetCondBeForcedTargeted()
    {
    }

    [Token(Token = "0x6003A27")]
    [Address(RVA = "0x10D69C0", Offset = "0x10D57C0", VA = "0x110D69C0")]
    public void SetCondProtect()
    {
    }

    [Token(Token = "0x6003A28")]
    [Address(RVA = "0x10D6870", Offset = "0x10D5670", VA = "0x110D6870")]
    public void SetCondGuard()
    {
    }

    [Token(Token = "0x6003A29")]
    [Address(RVA = "0x10D6CD0", Offset = "0x10D5AD0", VA = "0x110D6CD0")]
    public void SetCondSkillDistance(Unit.UnitSkillDistance usd)
    {
    }

    [Token(Token = "0x6003A2A")]
    [Address(RVA = "0x10D73A0", Offset = "0x10D61A0", VA = "0x110D73A0")]
    public BattleUnitDetailCond()
    {
    }
  }
}
