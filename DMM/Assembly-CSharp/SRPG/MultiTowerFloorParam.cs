// Decompiled with JetBrains decompiler
// Type: SRPG.MultiTowerFloorParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001BF2")]
  public class MultiTowerFloorParam
  {
    [Token(Token = "0x4006C16")]
    [FieldOffset(Offset = "0x8")]
    public List<MapParam> map;
    [Token(Token = "0x4006C17")]
    [FieldOffset(Offset = "0xC")]
    private QuestParam CachedQuestParam;
    [Token(Token = "0x4006C18")]
    [FieldOffset(Offset = "0x10")]
    private QuestParam BaseQuest;
    [Token(Token = "0x4006C19")]
    [FieldOffset(Offset = "0x14")]
    public int id;
    [Token(Token = "0x4006C1A")]
    [FieldOffset(Offset = "0x18")]
    public string title;
    [Token(Token = "0x4006C1B")]
    [FieldOffset(Offset = "0x1C")]
    public string name;
    [Token(Token = "0x4006C1C")]
    [FieldOffset(Offset = "0x20")]
    public string expr;
    [Token(Token = "0x4006C1D")]
    [FieldOffset(Offset = "0x24")]
    public string cond;
    [Token(Token = "0x4006C1E")]
    [FieldOffset(Offset = "0x28")]
    public string tower_id;
    [Token(Token = "0x4006C1F")]
    [FieldOffset(Offset = "0x2C")]
    public int cond_floor;
    [Token(Token = "0x4006C20")]
    [FieldOffset(Offset = "0x30")]
    public string reward_id;
    [Token(Token = "0x4006C21")]
    [FieldOffset(Offset = "0x34")]
    public short pt;
    [Token(Token = "0x4006C22")]
    [FieldOffset(Offset = "0x36")]
    public short FloorIndex;
    [Token(Token = "0x4006C23")]
    [FieldOffset(Offset = "0x38")]
    public short floor;
    [Token(Token = "0x4006C24")]
    [FieldOffset(Offset = "0x3A")]
    public short lv;
    [Token(Token = "0x4006C25")]
    [FieldOffset(Offset = "0x3C")]
    public short joblv;
    [Token(Token = "0x4006C26")]
    [FieldOffset(Offset = "0x3E")]
    public short unitnum;
    [Token(Token = "0x4006C27")]
    [FieldOffset(Offset = "0x40")]
    public short notcon;
    [Token(Token = "0x4006C28")]
    [FieldOffset(Offset = "0x42")]
    public bool DownLoaded;
    [Token(Token = "0x4006C29")]
    [FieldOffset(Offset = "0x44")]
    public string error_messarge;
    [Token(Token = "0x4006C2A")]
    [FieldOffset(Offset = "0x48")]
    public string iname_text;
    [Token(Token = "0x4006C2B")]
    [FieldOffset(Offset = "0x4C")]
    public string me_id;
    [Token(Token = "0x4006C2C")]
    [FieldOffset(Offset = "0x50")]
    public int is_wth_no_chg;
    [Token(Token = "0x4006C2D")]
    [FieldOffset(Offset = "0x54")]
    public string wth_set_id;
    [Token(Token = "0x4006C2E")]
    [FieldOffset(Offset = "0x58")]
    public bool is_skip;
    [Token(Token = "0x4006C2F")]
    [FieldOffset(Offset = "0x5C")]
    public string entry_condition;

    [Token(Token = "0x600732A")]
    [Address(RVA = "0x37C050", Offset = "0x37AE50", VA = "0x1037C050")]
    public QuestParam Clone(QuestParam original, bool useCache = false) => (QuestParam) null;

    [Token(Token = "0x600732B")]
    [Address(RVA = "0x37CAA0", Offset = "0x37B8A0", VA = "0x1037CAA0")]
    public QuestParam GetQuestParam() => (QuestParam) null;

    [Token(Token = "0x600732C")]
    [Address(RVA = "0x37C0B0", Offset = "0x37AEB0", VA = "0x1037C0B0")]
    private QuestParam ConvertQuestParam(QuestParam original) => (QuestParam) null;

    [Token(Token = "0x600732D")]
    [Address(RVA = "0x37C6C0", Offset = "0x37B4C0", VA = "0x1037C6C0")]
    public void Deserialize(JSON_MultiTowerFloorParam json)
    {
    }

    [Token(Token = "0x600732E")]
    [Address(RVA = "0x37CAD0", Offset = "0x37B8D0", VA = "0x1037CAD0")]
    public MultiTowerFloorParam()
    {
    }
  }
}
