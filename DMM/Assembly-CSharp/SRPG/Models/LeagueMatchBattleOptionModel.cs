// Decompiled with JetBrains decompiler
// Type: SRPG.Models.LeagueMatchBattleOptionModel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG.Models
{
  [Token(Token = "0x2003367")]
  public class LeagueMatchBattleOptionModel
  {
    [Token(Token = "0x400F2E6")]
    [FieldOffset(Offset = "0x8")]
    private bool mIsAttackNoticeEnable;

    [Token(Token = "0x17001EFF")]
    public bool IsAttackNoticeEnable
    {
      [Token(Token = "0x600E3F9"), Address(RVA = "0x301190", Offset = "0x2FFF90", VA = "0x10301190")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x600E3FA")]
    [Address(RVA = "0x3011A0", Offset = "0x2FFFA0", VA = "0x103011A0")]
    public void Initialize(bool is_attack_notice)
    {
    }

    [Token(Token = "0x600E3FB")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public LeagueMatchBattleOptionModel()
    {
    }
  }
}
