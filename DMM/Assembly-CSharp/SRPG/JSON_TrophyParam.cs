// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_TrophyParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001D94")]
  [MessagePackObject(true)]
  [Serializable]
  public class JSON_TrophyParam
  {
    [Token(Token = "0x400750B")]
    [FieldOffset(Offset = "0x8")]
    public string iname;
    [Token(Token = "0x400750C")]
    [FieldOffset(Offset = "0xC")]
    public string name;
    [Token(Token = "0x400750D")]
    [FieldOffset(Offset = "0x10")]
    public string expr;
    [Token(Token = "0x400750E")]
    [FieldOffset(Offset = "0x14")]
    public string[] flg_quests;
    [Token(Token = "0x400750F")]
    [FieldOffset(Offset = "0x18")]
    public int ymd_start;
    [Token(Token = "0x4007510")]
    [FieldOffset(Offset = "0x1C")]
    public string category;
    [Token(Token = "0x4007511")]
    [FieldOffset(Offset = "0x20")]
    public int disp;
    [Token(Token = "0x4007512")]
    [FieldOffset(Offset = "0x24")]
    public int type;
    [Token(Token = "0x4007513")]
    [FieldOffset(Offset = "0x28")]
    public string[] sval;
    [Token(Token = "0x4007514")]
    [FieldOffset(Offset = "0x2C")]
    public int ival;
    [Token(Token = "0x4007515")]
    [FieldOffset(Offset = "0x30")]
    public string reward_item1_iname;
    [Token(Token = "0x4007516")]
    [FieldOffset(Offset = "0x34")]
    public string reward_item2_iname;
    [Token(Token = "0x4007517")]
    [FieldOffset(Offset = "0x38")]
    public string reward_item3_iname;
    [Token(Token = "0x4007518")]
    [FieldOffset(Offset = "0x3C")]
    public int reward_item1_num;
    [Token(Token = "0x4007519")]
    [FieldOffset(Offset = "0x40")]
    public int reward_item2_num;
    [Token(Token = "0x400751A")]
    [FieldOffset(Offset = "0x44")]
    public int reward_item3_num;
    [Token(Token = "0x400751B")]
    [FieldOffset(Offset = "0x48")]
    public int reward_gold;
    [Token(Token = "0x400751C")]
    [FieldOffset(Offset = "0x4C")]
    public int reward_coin;
    [Token(Token = "0x400751D")]
    [FieldOffset(Offset = "0x50")]
    public int reward_exp;
    [Token(Token = "0x400751E")]
    [FieldOffset(Offset = "0x54")]
    public int reward_stamina;
    [Token(Token = "0x400751F")]
    [FieldOffset(Offset = "0x58")]
    public string reward_artifact1_iname;
    [Token(Token = "0x4007520")]
    [FieldOffset(Offset = "0x5C")]
    public string reward_artifact2_iname;
    [Token(Token = "0x4007521")]
    [FieldOffset(Offset = "0x60")]
    public string reward_artifact3_iname;
    [Token(Token = "0x4007522")]
    [FieldOffset(Offset = "0x64")]
    public int reward_artifact1_num;
    [Token(Token = "0x4007523")]
    [FieldOffset(Offset = "0x68")]
    public int reward_artifact2_num;
    [Token(Token = "0x4007524")]
    [FieldOffset(Offset = "0x6C")]
    public int reward_artifact3_num;
    [Token(Token = "0x4007525")]
    [FieldOffset(Offset = "0x70")]
    public string parent_iname;
    [Token(Token = "0x4007526")]
    [FieldOffset(Offset = "0x74")]
    public int help;
    [Token(Token = "0x4007527")]
    [FieldOffset(Offset = "0x78")]
    public string reward_cc_1_iname;
    [Token(Token = "0x4007528")]
    [FieldOffset(Offset = "0x7C")]
    public int reward_cc_1_num;
    [Token(Token = "0x4007529")]
    [FieldOffset(Offset = "0x80")]
    public string reward_cc_2_iname;
    [Token(Token = "0x400752A")]
    [FieldOffset(Offset = "0x84")]
    public int reward_cc_2_num;
    [Token(Token = "0x400752B")]
    [FieldOffset(Offset = "0x88")]
    public int prio_reward;
    [Token(Token = "0x400752C")]
    [FieldOffset(Offset = "0x8C")]
    public int star_num;
    [Token(Token = "0x400752D")]
    [FieldOffset(Offset = "0x90")]
    public int is_ended;

    [Token(Token = "0x6007922")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_TrophyParam()
    {
    }
  }
}
