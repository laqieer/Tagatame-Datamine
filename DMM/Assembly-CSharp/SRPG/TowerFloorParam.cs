// Decompiled with JetBrains decompiler
// Type: SRPG.TowerFloorParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001D70")]
  public class TowerFloorParam
  {
    [Token(Token = "0x4007415")]
    [FieldOffset(Offset = "0x8")]
    public List<MapParam> map;
    [Token(Token = "0x4007416")]
    [FieldOffset(Offset = "0xC")]
    private QuestParam CachedQuestParam;
    [Token(Token = "0x4007417")]
    [FieldOffset(Offset = "0x10")]
    private QuestParam BaseQuest;
    [Token(Token = "0x4007418")]
    [FieldOffset(Offset = "0x14")]
    public string iname;
    [Token(Token = "0x4007419")]
    [FieldOffset(Offset = "0x18")]
    public string title;
    [Token(Token = "0x400741A")]
    [FieldOffset(Offset = "0x1C")]
    public string name;
    [Token(Token = "0x400741B")]
    [FieldOffset(Offset = "0x20")]
    public string expr;
    [Token(Token = "0x400741C")]
    [FieldOffset(Offset = "0x24")]
    public string cond;
    [Token(Token = "0x400741D")]
    [FieldOffset(Offset = "0x28")]
    public string tower_id;
    [Token(Token = "0x400741E")]
    [FieldOffset(Offset = "0x2C")]
    public string cond_quest;
    [Token(Token = "0x400741F")]
    [FieldOffset(Offset = "0x30")]
    public string rdy_cnd;
    [Token(Token = "0x4007420")]
    [FieldOffset(Offset = "0x34")]
    public string reward_id;
    [Token(Token = "0x4007421")]
    [FieldOffset(Offset = "0x38")]
    public short pt;
    [Token(Token = "0x4007422")]
    [FieldOffset(Offset = "0x3A")]
    public short FloorIndex;
    [Token(Token = "0x4007423")]
    [FieldOffset(Offset = "0x3C")]
    public byte floor;
    [Token(Token = "0x4007424")]
    [FieldOffset(Offset = "0x3D")]
    private byte hp_recover_rate;
    [Token(Token = "0x4007425")]
    [FieldOffset(Offset = "0x3E")]
    public byte lv;
    [Token(Token = "0x4007426")]
    [FieldOffset(Offset = "0x3F")]
    public byte joblv;
    [Token(Token = "0x4007427")]
    [FieldOffset(Offset = "0x40")]
    public bool can_help;
    [Token(Token = "0x4007428")]
    [FieldOffset(Offset = "0x44")]
    public string deck;
    [Token(Token = "0x4007429")]
    [FieldOffset(Offset = "0x48")]
    public byte[] tag_num;
    [Token(Token = "0x400742A")]
    [FieldOffset(Offset = "0x4C")]
    public bool DownLoaded;
    [Token(Token = "0x400742B")]
    [FieldOffset(Offset = "0x50")]
    public string error_messarge;
    [Token(Token = "0x400742C")]
    [FieldOffset(Offset = "0x54")]
    public byte is_unit_chg;
    [Token(Token = "0x400742D")]
    [FieldOffset(Offset = "0x58")]
    public string me_id;
    [Token(Token = "0x400742E")]
    [FieldOffset(Offset = "0x5C")]
    public int is_wth_no_chg;
    [Token(Token = "0x400742F")]
    [FieldOffset(Offset = "0x60")]
    public string wth_set_id;
    [Token(Token = "0x4007430")]
    [FieldOffset(Offset = "0x64")]
    public string mission;
    [Token(Token = "0x4007431")]
    [FieldOffset(Offset = "0x68")]
    public int naut;

    [Token(Token = "0x6007888")]
    [Address(RVA = "0x3A4DB0", Offset = "0x3A3BB0", VA = "0x103A4DB0")]
    public QuestParam Clone(QuestParam original, bool useCache = false) => (QuestParam) null;

    [Token(Token = "0x6007889")]
    [Address(RVA = "0x3A5540", Offset = "0x3A4340", VA = "0x103A5540")]
    public QuestParam GetQuestParam() => (QuestParam) null;

    [Token(Token = "0x600788A")]
    [Address(RVA = "0x3A4E10", Offset = "0x3A3C10", VA = "0x103A4E10")]
    private QuestParam ConvertQuestParam(QuestParam original) => (QuestParam) null;

    [Token(Token = "0x600788B")]
    [Address(RVA = "0x3A5230", Offset = "0x3A4030", VA = "0x103A5230")]
    public void Deserialize(JSON_TowerFloorParam json)
    {
    }

    [Token(Token = "0x600788C")]
    [Address(RVA = "0x3A4D80", Offset = "0x3A3B80", VA = "0x103A4D80")]
    public int CalcHelaNum(int max_hp) => new int();

    [Token(Token = "0x600788D")]
    [Address(RVA = "0x3A54C0", Offset = "0x3A42C0", VA = "0x103A54C0")]
    public int GetFloorNo() => new int();

    [Token(Token = "0x600788E")]
    [Address(RVA = "0x3A5570", Offset = "0x3A4370", VA = "0x103A5570")]
    public void SetGoldInfo()
    {
    }

    [Token(Token = "0x600788F")]
    [Address(RVA = "0x3A57D0", Offset = "0x3A45D0", VA = "0x103A57D0")]
    public TowerFloorParam()
    {
    }
  }
}
