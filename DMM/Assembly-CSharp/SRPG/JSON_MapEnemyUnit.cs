// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_MapEnemyUnit
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2000C07")]
  public class JSON_MapEnemyUnit : JSON_MapPartyUnit
  {
    [Token(Token = "0x4001ED6")]
    public const int WVABILITY_MAX = 5;
    [Token(Token = "0x4001ED7")]
    [FieldOffset(Offset = "0x54")]
    public string iname;
    [Token(Token = "0x4001ED8")]
    [FieldOffset(Offset = "0x58")]
    public int side;
    [Token(Token = "0x4001ED9")]
    [FieldOffset(Offset = "0x5C")]
    public int lv;
    [Token(Token = "0x4001EDA")]
    [FieldOffset(Offset = "0x60")]
    public int rare;
    [Token(Token = "0x4001EDB")]
    [FieldOffset(Offset = "0x64")]
    public int awake;
    [Token(Token = "0x4001EDC")]
    [FieldOffset(Offset = "0x68")]
    public int elem;
    [Token(Token = "0x4001EDD")]
    [FieldOffset(Offset = "0x6C")]
    public int exp;
    [Token(Token = "0x4001EDE")]
    [FieldOffset(Offset = "0x70")]
    public int gems;
    [Token(Token = "0x4001EDF")]
    [FieldOffset(Offset = "0x74")]
    public int gold;
    [Token(Token = "0x4001EE0")]
    [FieldOffset(Offset = "0x78")]
    public int search;
    [Token(Token = "0x4001EE1")]
    [FieldOffset(Offset = "0x7C")]
    public int ctrl;
    [Token(Token = "0x4001EE2")]
    [FieldOffset(Offset = "0x80")]
    public int no_st_drop;
    [Token(Token = "0x4001EE3")]
    [FieldOffset(Offset = "0x84")]
    public int no_disp_drop;
    [Token(Token = "0x4001EE4")]
    [FieldOffset(Offset = "0x88")]
    public string drop;
    [Token(Token = "0x4001EE5")]
    [FieldOffset(Offset = "0x8C")]
    public int notice_damage;
    [Token(Token = "0x4001EE6")]
    [FieldOffset(Offset = "0x90")]
    public string[] notice_members;
    [Token(Token = "0x4001EE7")]
    [FieldOffset(Offset = "0x94")]
    public JSON_MapEquipAbility[] abils;
    [Token(Token = "0x4001EE8")]
    [FieldOffset(Offset = "0x98")]
    public JSON_MapEquipAbility[] chgabils;
    [Token(Token = "0x4001EE9")]
    [FieldOffset(Offset = "0x9C")]
    public JSON_MapEquipArtifact[] artis;
    [Token(Token = "0x4001EEA")]
    [FieldOffset(Offset = "0xA0")]
    public JSON_MapEquipConceptCard[] cards;
    [Token(Token = "0x4001EEB")]
    [FieldOffset(Offset = "0xA4")]
    public JSON_MapEquipTruth truth;
    [Token(Token = "0x4001EEC")]
    [FieldOffset(Offset = "0xA8")]
    public JSON_MapEquipIname job;
    [Token(Token = "0x4001EED")]
    [FieldOffset(Offset = "0xAC")]
    public JSON_MapEquipJob[] jobsets;
    [Token(Token = "0x4001EEE")]
    [FieldOffset(Offset = "0xB0")]
    public JSON_MapEquipIname skin;
    [Token(Token = "0x4001EEF")]
    [FieldOffset(Offset = "0xB4")]
    public JSON_MapEquipDtu[] dtus;
    [Token(Token = "0x4001EF0")]
    [FieldOffset(Offset = "0xB8")]
    public JSON_MapEquipIname dtu;
    [Token(Token = "0x4001EF1")]
    [FieldOffset(Offset = "0xBC")]
    public JSON_MapEquipAbility[] dtuabils;
    [Token(Token = "0x4001EF2")]
    [FieldOffset(Offset = "0xC0")]
    public JSON_MapEquipAbility[] dtuchgabils;
    [Token(Token = "0x4001EF3")]
    [FieldOffset(Offset = "0xC4")]
    public JSON_AIActionTable acttbl;
    [Token(Token = "0x4001EF4")]
    [FieldOffset(Offset = "0xC8")]
    public JSON_AIActionTable dtuacttbl;
    [Token(Token = "0x4001EF5")]
    [FieldOffset(Offset = "0xCC")]
    public AIPatrolTable patrol;
    [Token(Token = "0x4001EF6")]
    [FieldOffset(Offset = "0xD0")]
    public string fskl;
    [Token(Token = "0x4001EF7")]
    [FieldOffset(Offset = "0xD4")]
    public short weight;
    [Token(Token = "0x4001EF8")]
    [FieldOffset(Offset = "0xD6")]
    public byte tag;
    [Token(Token = "0x4001EF9")]
    [FieldOffset(Offset = "0xD8")]
    public int spawn_max;
    [Token(Token = "0x4001EFA")]
    [FieldOffset(Offset = "0xDC")]
    public MapBreakObj break_obj;
    [Token(Token = "0x4001EFB")]
    [FieldOffset(Offset = "0xE0")]
    public int need_dead;
    [Token(Token = "0x4001EFC")]
    [FieldOffset(Offset = "0xE4")]
    public int is_raid_boss;
    [Token(Token = "0x4001EFD")]
    [FieldOffset(Offset = "0xE8")]
    public int withdraw_drop;
    [Token(Token = "0x4001EFE")]
    [FieldOffset(Offset = "0xEC")]
    public int mas_abil;
    [Token(Token = "0x4001EFF")]
    [FieldOffset(Offset = "0xF0")]
    public int quest_abil;
    [Token(Token = "0x4001F00")]
    [FieldOffset(Offset = "0xF4")]
    public int chg_userate;
    [Token(Token = "0x4001F01")]
    [FieldOffset(Offset = "0xF8")]
    public int ctrl_force;
    [Token(Token = "0x4001F02")]
    [FieldOffset(Offset = "0xFC")]
    public int is_cc_leader;

    [Token(Token = "0x170002D3")]
    public bool IsRandSymbol
    {
      [Token(Token = "0x6003014"), Address(RVA = "0xFE48D0", Offset = "0xFE36D0", VA = "0x10FE48D0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x170002D4")]
    public int RandTagIndex
    {
      [Token(Token = "0x6003015"), Address(RVA = "0xFE4920", Offset = "0xFE3720", VA = "0x10FE4920")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x170002D5")]
    public bool IsEmptySymbol
    {
      [Token(Token = "0x6003016"), Address(RVA = "0xFE4890", Offset = "0xFE3690", VA = "0x10FE4890")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x6003017")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_MapEnemyUnit()
    {
    }
  }
}
