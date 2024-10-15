// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_UnitRentalParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001E98")]
  [MessagePackObject(true)]
  [Serializable]
  public class JSON_UnitRentalParam
  {
    [Token(Token = "0x4007FD9")]
    [FieldOffset(Offset = "0x8")]
    public string iname;
    [Token(Token = "0x4007FDA")]
    [FieldOffset(Offset = "0xC")]
    public string unit;
    [Token(Token = "0x4007FDB")]
    [FieldOffset(Offset = "0x10")]
    public string begin_at;
    [Token(Token = "0x4007FDC")]
    [FieldOffset(Offset = "0x14")]
    public string end_at;
    [Token(Token = "0x4007FDD")]
    [FieldOffset(Offset = "0x18")]
    public int pt_max;
    [Token(Token = "0x4007FDE")]
    [FieldOffset(Offset = "0x1C")]
    public int ptup_lv;
    [Token(Token = "0x4007FDF")]
    [FieldOffset(Offset = "0x20")]
    public int ptup_evol;
    [Token(Token = "0x4007FE0")]
    [FieldOffset(Offset = "0x24")]
    public int ptup_awake;
    [Token(Token = "0x4007FE1")]
    [FieldOffset(Offset = "0x28")]
    public int ptup_job_lv;
    [Token(Token = "0x4007FE2")]
    [FieldOffset(Offset = "0x2C")]
    public int ptup_ability_lv;
    [Token(Token = "0x4007FE3")]
    [FieldOffset(Offset = "0x30")]
    public int ptup_quest_main;
    [Token(Token = "0x4007FE4")]
    [FieldOffset(Offset = "0x34")]
    public int ptup_quest_sub;
    [Token(Token = "0x4007FE5")]
    [FieldOffset(Offset = "0x38")]
    public string notification;
    [Token(Token = "0x4007FE6")]
    [FieldOffset(Offset = "0x3C")]
    public JSON_UnitRentalParam.QuestInfo[] quest_infos;

    [Token(Token = "0x6007D7C")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_UnitRentalParam()
    {
    }

    [Token(Token = "0x2001E99")]
    [MessagePackObject(true)]
    [Serializable]
    public class QuestInfo
    {
      [Token(Token = "0x4007FE7")]
      [FieldOffset(Offset = "0x8")]
      public int point;
      [Token(Token = "0x4007FE8")]
      [FieldOffset(Offset = "0xC")]
      public string quest_id;

      [Token(Token = "0x6007D7D")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public QuestInfo()
      {
      }
    }
  }
}
