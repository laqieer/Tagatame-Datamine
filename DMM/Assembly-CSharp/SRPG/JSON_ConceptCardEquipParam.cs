// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_ConceptCardEquipParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001A73")]
  [MessagePackObject(true)]
  [Serializable]
  public class JSON_ConceptCardEquipParam
  {
    [Token(Token = "0x40061A6")]
    [FieldOffset(Offset = "0x8")]
    public string cnds_iname;
    [Token(Token = "0x40061A7")]
    [FieldOffset(Offset = "0xC")]
    public string card_skill;
    [Token(Token = "0x40061A8")]
    [FieldOffset(Offset = "0x10")]
    public string add_card_skill_buff_awake;
    [Token(Token = "0x40061A9")]
    [FieldOffset(Offset = "0x14")]
    public string add_card_skill_buff_lvmax;
    [Token(Token = "0x40061AA")]
    [FieldOffset(Offset = "0x18")]
    public string abil_iname;
    [Token(Token = "0x40061AB")]
    [FieldOffset(Offset = "0x1C")]
    public string abil_iname_lvmax;
    [Token(Token = "0x40061AC")]
    [FieldOffset(Offset = "0x20")]
    public string statusup_skill;
    [Token(Token = "0x40061AD")]
    [FieldOffset(Offset = "0x24")]
    public string skin;
    [Token(Token = "0x40061AE")]
    [FieldOffset(Offset = "0x28")]
    public int is_decrease_eff;
    [Token(Token = "0x40061AF")]
    [FieldOffset(Offset = "0x2C")]
    public int is_limit_bonus;

    [Token(Token = "0x6006CA6")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_ConceptCardEquipParam()
    {
    }
  }
}
