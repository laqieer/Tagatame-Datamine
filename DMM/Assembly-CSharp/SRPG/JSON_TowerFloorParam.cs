// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_TowerFloorParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001D6F")]
  [MessagePackObject(true)]
  [Serializable]
  public class JSON_TowerFloorParam
  {
    [Token(Token = "0x40073FD")]
    [FieldOffset(Offset = "0x8")]
    public string iname;
    [Token(Token = "0x40073FE")]
    [FieldOffset(Offset = "0xC")]
    public string title;
    [Token(Token = "0x40073FF")]
    [FieldOffset(Offset = "0x10")]
    public string name;
    [Token(Token = "0x4007400")]
    [FieldOffset(Offset = "0x14")]
    public string expr;
    [Token(Token = "0x4007401")]
    [FieldOffset(Offset = "0x18")]
    public string cond;
    [Token(Token = "0x4007402")]
    [FieldOffset(Offset = "0x1C")]
    public string tower_id;
    [Token(Token = "0x4007403")]
    [FieldOffset(Offset = "0x20")]
    public string cond_quest;
    [Token(Token = "0x4007404")]
    [FieldOffset(Offset = "0x24")]
    public string rdy_cnd;
    [Token(Token = "0x4007405")]
    [FieldOffset(Offset = "0x28")]
    public string reward_id;
    [Token(Token = "0x4007406")]
    [FieldOffset(Offset = "0x2C")]
    public JSON_MapParam[] map;
    [Token(Token = "0x4007407")]
    [FieldOffset(Offset = "0x30")]
    public string deck;
    [Token(Token = "0x4007408")]
    [FieldOffset(Offset = "0x34")]
    public byte[] tag;
    [Token(Token = "0x4007409")]
    [FieldOffset(Offset = "0x38")]
    public byte hp_recover_rate;
    [Token(Token = "0x400740A")]
    [FieldOffset(Offset = "0x39")]
    public byte pt;
    [Token(Token = "0x400740B")]
    [FieldOffset(Offset = "0x3A")]
    public byte lv;
    [Token(Token = "0x400740C")]
    [FieldOffset(Offset = "0x3B")]
    public byte joblv;
    [Token(Token = "0x400740D")]
    [FieldOffset(Offset = "0x3C")]
    public byte can_help;
    [Token(Token = "0x400740E")]
    [FieldOffset(Offset = "0x3D")]
    public byte floor;
    [Token(Token = "0x400740F")]
    [FieldOffset(Offset = "0x3E")]
    public byte is_unit_chg;
    [Token(Token = "0x4007410")]
    [FieldOffset(Offset = "0x40")]
    public int naut;
    [Token(Token = "0x4007411")]
    [FieldOffset(Offset = "0x44")]
    public string me_id;
    [Token(Token = "0x4007412")]
    [FieldOffset(Offset = "0x48")]
    public int is_wth_no_chg;
    [Token(Token = "0x4007413")]
    [FieldOffset(Offset = "0x4C")]
    public string wth_set_id;
    [Token(Token = "0x4007414")]
    [FieldOffset(Offset = "0x50")]
    public string mission;

    [Token(Token = "0x6007886")]
    [Address(RVA = "0x3A2F10", Offset = "0x3A1D10", VA = "0x103A2F10")]
    public JSON_QuestParam ConvertQuestParam() => (JSON_QuestParam) null;

    [Token(Token = "0x6007887")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_TowerFloorParam()
    {
    }
  }
}
