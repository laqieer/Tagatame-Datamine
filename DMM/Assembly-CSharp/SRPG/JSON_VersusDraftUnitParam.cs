// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_VersusDraftUnitParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001EB4")]
  [MessagePackObject(true)]
  [Serializable]
  public class JSON_VersusDraftUnitParam
  {
    [Token(Token = "0x4008099")]
    [FieldOffset(Offset = "0x8")]
    public long id;
    [Token(Token = "0x400809A")]
    [FieldOffset(Offset = "0x10")]
    public long draft_unit_id;
    [Token(Token = "0x400809B")]
    [FieldOffset(Offset = "0x18")]
    public int weight;
    [Token(Token = "0x400809C")]
    [FieldOffset(Offset = "0x1C")]
    public string unit_iname;
    [Token(Token = "0x400809D")]
    [FieldOffset(Offset = "0x20")]
    public int rare;
    [Token(Token = "0x400809E")]
    [FieldOffset(Offset = "0x24")]
    public int awake;
    [Token(Token = "0x400809F")]
    [FieldOffset(Offset = "0x28")]
    public int lv;
    [Token(Token = "0x40080A0")]
    [FieldOffset(Offset = "0x2C")]
    public int select_job_idx;
    [Token(Token = "0x40080A1")]
    [FieldOffset(Offset = "0x30")]
    public string job1_iname;
    [Token(Token = "0x40080A2")]
    [FieldOffset(Offset = "0x34")]
    public int job1_lv;
    [Token(Token = "0x40080A3")]
    [FieldOffset(Offset = "0x38")]
    public int job1_equip;
    [Token(Token = "0x40080A4")]
    [FieldOffset(Offset = "0x3C")]
    public string job2_iname;
    [Token(Token = "0x40080A5")]
    [FieldOffset(Offset = "0x40")]
    public int job2_lv;
    [Token(Token = "0x40080A6")]
    [FieldOffset(Offset = "0x44")]
    public int job2_equip;
    [Token(Token = "0x40080A7")]
    [FieldOffset(Offset = "0x48")]
    public string job3_iname;
    [Token(Token = "0x40080A8")]
    [FieldOffset(Offset = "0x4C")]
    public int job3_lv;
    [Token(Token = "0x40080A9")]
    [FieldOffset(Offset = "0x50")]
    public int job3_equip;
    [Token(Token = "0x40080AA")]
    [FieldOffset(Offset = "0x54")]
    public string abil1_iname;
    [Token(Token = "0x40080AB")]
    [FieldOffset(Offset = "0x58")]
    public int abil1_lv;
    [Token(Token = "0x40080AC")]
    [FieldOffset(Offset = "0x5C")]
    public string abil2_iname;
    [Token(Token = "0x40080AD")]
    [FieldOffset(Offset = "0x60")]
    public int abil2_lv;
    [Token(Token = "0x40080AE")]
    [FieldOffset(Offset = "0x64")]
    public string abil3_iname;
    [Token(Token = "0x40080AF")]
    [FieldOffset(Offset = "0x68")]
    public int abil3_lv;
    [Token(Token = "0x40080B0")]
    [FieldOffset(Offset = "0x6C")]
    public string abil4_iname;
    [Token(Token = "0x40080B1")]
    [FieldOffset(Offset = "0x70")]
    public int abil4_lv;
    [Token(Token = "0x40080B2")]
    [FieldOffset(Offset = "0x74")]
    public string abil5_iname;
    [Token(Token = "0x40080B3")]
    [FieldOffset(Offset = "0x78")]
    public int abil5_lv;
    [Token(Token = "0x40080B4")]
    [FieldOffset(Offset = "0x7C")]
    public string arti1_iname;
    [Token(Token = "0x40080B5")]
    [FieldOffset(Offset = "0x80")]
    public int arti1_rare;
    [Token(Token = "0x40080B6")]
    [FieldOffset(Offset = "0x84")]
    public int arti1_lv;
    [Token(Token = "0x40080B7")]
    [FieldOffset(Offset = "0x88")]
    public string arti2_iname;
    [Token(Token = "0x40080B8")]
    [FieldOffset(Offset = "0x8C")]
    public int arti2_rare;
    [Token(Token = "0x40080B9")]
    [FieldOffset(Offset = "0x90")]
    public int arti2_lv;
    [Token(Token = "0x40080BA")]
    [FieldOffset(Offset = "0x94")]
    public string arti3_iname;
    [Token(Token = "0x40080BB")]
    [FieldOffset(Offset = "0x98")]
    public int arti3_rare;
    [Token(Token = "0x40080BC")]
    [FieldOffset(Offset = "0x9C")]
    public int arti3_lv;
    [Token(Token = "0x40080BD")]
    [FieldOffset(Offset = "0xA0")]
    public string card_iname;
    [Token(Token = "0x40080BE")]
    [FieldOffset(Offset = "0xA4")]
    public int card_lv;
    [Token(Token = "0x40080BF")]
    [FieldOffset(Offset = "0xA8")]
    public int card_leaderskill;
    [Token(Token = "0x40080C0")]
    [FieldOffset(Offset = "0xAC")]
    public string card2_iname;
    [Token(Token = "0x40080C1")]
    [FieldOffset(Offset = "0xB0")]
    public int card2_lv;
    [Token(Token = "0x40080C2")]
    [FieldOffset(Offset = "0xB4")]
    public int door1_lv;
    [Token(Token = "0x40080C3")]
    [FieldOffset(Offset = "0xB8")]
    public int door2_lv;
    [Token(Token = "0x40080C4")]
    [FieldOffset(Offset = "0xBC")]
    public int door3_lv;
    [Token(Token = "0x40080C5")]
    [FieldOffset(Offset = "0xC0")]
    public int door4_lv;
    [Token(Token = "0x40080C6")]
    [FieldOffset(Offset = "0xC4")]
    public int door5_lv;
    [Token(Token = "0x40080C7")]
    [FieldOffset(Offset = "0xC8")]
    public int door6_lv;
    [Token(Token = "0x40080C8")]
    [FieldOffset(Offset = "0xCC")]
    public int door7_lv;
    [Token(Token = "0x40080C9")]
    [FieldOffset(Offset = "0xD0")]
    public string master_abil;
    [Token(Token = "0x40080CA")]
    [FieldOffset(Offset = "0xD4")]
    public string skin;
    [Token(Token = "0x40080CB")]
    [FieldOffset(Offset = "0xD8")]
    public string[] clear_quest_iname;

    [Token(Token = "0x6007DD2")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_VersusDraftUnitParam()
    {
    }
  }
}
