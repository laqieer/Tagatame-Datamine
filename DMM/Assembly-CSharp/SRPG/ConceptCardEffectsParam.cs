// Decompiled with JetBrains decompiler
// Type: SRPG.ConceptCardEffectsParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001A79")]
  [MessagePackObject(true)]
  public class ConceptCardEffectsParam
  {
    [Token(Token = "0x40061E2")]
    [FieldOffset(Offset = "0x8")]
    public string cnds_iname;
    [Token(Token = "0x40061E3")]
    [FieldOffset(Offset = "0xC")]
    public string card_skill;
    [Token(Token = "0x40061E4")]
    [FieldOffset(Offset = "0x10")]
    public string add_card_skill_buff_awake;
    [Token(Token = "0x40061E5")]
    [FieldOffset(Offset = "0x14")]
    public string add_card_skill_buff_lvmax;
    [Token(Token = "0x40061E6")]
    [FieldOffset(Offset = "0x18")]
    public string abil_iname;
    [Token(Token = "0x40061E7")]
    [FieldOffset(Offset = "0x1C")]
    public string abil_iname_lvmax;
    [Token(Token = "0x40061E8")]
    [FieldOffset(Offset = "0x20")]
    public string statusup_skill;
    [Token(Token = "0x40061E9")]
    [FieldOffset(Offset = "0x24")]
    public string skin;
    [Token(Token = "0x40061EA")]
    [FieldOffset(Offset = "0x28")]
    public bool is_decrease_eff;
    [Token(Token = "0x40061EB")]
    [FieldOffset(Offset = "0x29")]
    private bool is_limit_bonus;

    [Token(Token = "0x17000BF4")]
    [IgnoreMember]
    public bool IsLimitBonus
    {
      [Token(Token = "0x6006CBF"), Address(RVA = "0x3550A0", Offset = "0x353EA0", VA = "0x103550A0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x6006CC0")]
    [Address(RVA = "0x354E30", Offset = "0x353C30", VA = "0x10354E30")]
    public bool Deserialize(JSON_ConceptCardEquipParam json) => new bool();

    [Token(Token = "0x6006CC1")]
    [Address(RVA = "0x354D00", Offset = "0x353B00", VA = "0x10354D00")]
    public BuffEffect CreateAddCardSkillBuffEffectAwake(int awake, int awake_cap)
    {
      return (BuffEffect) null;
    }

    [Token(Token = "0x6006CC2")]
    [Address(RVA = "0x354D90", Offset = "0x353B90", VA = "0x10354D90")]
    public BuffEffect CreateAddCardSkillBuffEffectLvMax(int lv, int lv_cap, int awake)
    {
      return (BuffEffect) null;
    }

    [Token(Token = "0x6006CC3")]
    [Address(RVA = "0x354EE0", Offset = "0x353CE0", VA = "0x10354EE0")]
    public void GetAddCardSkillBuffStatusAwake(
      int awake,
      int awake_cap,
      ref BaseStatus total_add,
      ref BaseStatus total_scale)
    {
    }

    [Token(Token = "0x6006CC4")]
    [Address(RVA = "0x354FD0", Offset = "0x353DD0", VA = "0x10354FD0")]
    public void GetAddCardSkillBuffStatusLvMax(
      int lv,
      int lv_cap,
      int awake,
      ref BaseStatus total_add,
      ref BaseStatus total_scale)
    {
    }

    [Token(Token = "0x6006CC5")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public ConceptCardEffectsParam()
    {
    }
  }
}
