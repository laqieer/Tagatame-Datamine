// Decompiled with JetBrains decompiler
// Type: SRPG.NPCSetting
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2000C23")]
  [MessagePackObject(true)]
  public class NPCSetting : UnitSetting
  {
    [Token(Token = "0x4001F9A")]
    [FieldOffset(Offset = "0x118")]
    public OString iname;
    [Token(Token = "0x4001F9B")]
    [FieldOffset(Offset = "0x11C")]
    public OInt lv;
    [Token(Token = "0x4001F9C")]
    [FieldOffset(Offset = "0x130")]
    public OInt rare;
    [Token(Token = "0x4001F9D")]
    [FieldOffset(Offset = "0x144")]
    public OInt awake;
    [Token(Token = "0x4001F9E")]
    [FieldOffset(Offset = "0x158")]
    public OInt elem;
    [Token(Token = "0x4001F9F")]
    [FieldOffset(Offset = "0x16C")]
    public OInt exp;
    [Token(Token = "0x4001FA0")]
    [FieldOffset(Offset = "0x180")]
    public OInt gems;
    [Token(Token = "0x4001FA1")]
    [FieldOffset(Offset = "0x194")]
    public OInt gold;
    [Token(Token = "0x4001FA2")]
    [FieldOffset(Offset = "0x1A8")]
    public OInt search;
    [Token(Token = "0x4001FA3")]
    [FieldOffset(Offset = "0x1BC")]
    public OBool control;
    [Token(Token = "0x4001FA4")]
    [FieldOffset(Offset = "0x1C8")]
    public EquipAbilitySetting[] abilities;
    [Token(Token = "0x4001FA5")]
    [FieldOffset(Offset = "0x1CC")]
    public EquipAbilitySetting[] chgabilities;
    [Token(Token = "0x4001FA6")]
    [FieldOffset(Offset = "0x1D0")]
    public EquipArtifactSetting[] artifacts;
    [Token(Token = "0x4001FA7")]
    [FieldOffset(Offset = "0x1D4")]
    public EquipConceptCardSetting[] cards;
    [Token(Token = "0x4001FA8")]
    [FieldOffset(Offset = "0x1D8")]
    public EquipTruthSetting truth;
    [Token(Token = "0x4001FA9")]
    [FieldOffset(Offset = "0x1DC")]
    public EquipInameSetting job;
    [Token(Token = "0x4001FAA")]
    [FieldOffset(Offset = "0x1E0")]
    public EquipJobSetting[] jobsets;
    [Token(Token = "0x4001FAB")]
    [FieldOffset(Offset = "0x1E4")]
    public EquipInameSetting skin;
    [Token(Token = "0x4001FAC")]
    [FieldOffset(Offset = "0x1E8")]
    public EquipDtuSetting[] dtus;
    [Token(Token = "0x4001FAD")]
    [FieldOffset(Offset = "0x1EC")]
    public AIActionTable acttbl;
    [Token(Token = "0x4001FAE")]
    [FieldOffset(Offset = "0x1F0")]
    public AIPatrolTable patrol;
    [Token(Token = "0x4001FAF")]
    [FieldOffset(Offset = "0x1F4")]
    public OString fskl;
    [Token(Token = "0x4001FB0")]
    [FieldOffset(Offset = "0x1F8")]
    public OInt notice_damage;
    [Token(Token = "0x4001FB1")]
    [FieldOffset(Offset = "0x20C")]
    public List<OString> notice_members;
    [Token(Token = "0x4001FB2")]
    [FieldOffset(Offset = "0x210")]
    public MapBreakObj break_obj;
    [Token(Token = "0x4001FB3")]
    [FieldOffset(Offset = "0x214")]
    public OBool is_raid_boss;
    [Token(Token = "0x4001FB4")]
    [FieldOffset(Offset = "0x220")]
    public OBool need_dead;
    [Token(Token = "0x4001FB5")]
    [FieldOffset(Offset = "0x22C")]
    public bool withdraw_drop;
    [Token(Token = "0x4001FB6")]
    [FieldOffset(Offset = "0x22D")]
    public bool mas_abil;
    [Token(Token = "0x4001FB7")]
    [FieldOffset(Offset = "0x22E")]
    public bool quest_abil;
    [Token(Token = "0x4001FB8")]
    [FieldOffset(Offset = "0x230")]
    public int chg_userate;
    [Token(Token = "0x4001FB9")]
    [FieldOffset(Offset = "0x234")]
    public bool ctrl_force;
    [Token(Token = "0x4001FBA")]
    [FieldOffset(Offset = "0x235")]
    public bool is_cc_leader;
    [Token(Token = "0x4001FBB")]
    [FieldOffset(Offset = "0x238")]
    public string drop;

    [Token(Token = "0x6003038")]
    [Address(RVA = "0xFEAB00", Offset = "0xFE9900", VA = "0x10FEAB00")]
    public NPCSetting()
    {
    }

    [Token(Token = "0x6003039")]
    [Address(RVA = "0xFE7730", Offset = "0xFE6530", VA = "0x10FE7730")]
    private EquipSkillSetting CopyToSkill(JSON_MapEquipSkill json) => (EquipSkillSetting) null;

    [Token(Token = "0x600303A")]
    [Address(RVA = "0xFE7470", Offset = "0xFE6270", VA = "0x10FE7470")]
    private EquipAbilitySetting[] CopyToAbility(JSON_MapEquipAbility[] _abils)
    {
      return (EquipAbilitySetting[]) null;
    }

    [Token(Token = "0x600303B")]
    [Address(RVA = "0xFE7860", Offset = "0xFE6660", VA = "0x10FE7860")]
    public NPCSetting(JSON_MapEnemyUnit json)
    {
    }
  }
}
