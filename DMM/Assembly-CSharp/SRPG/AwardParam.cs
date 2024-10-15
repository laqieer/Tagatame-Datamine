// Decompiled with JetBrains decompiler
// Type: SRPG.AwardParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20019A2")]
  public class AwardParam
  {
    [Token(Token = "0x4005DEA")]
    [FieldOffset(Offset = "0x8")]
    public int id;
    [Token(Token = "0x4005DEB")]
    [FieldOffset(Offset = "0xC")]
    public string iname;
    [Token(Token = "0x4005DEC")]
    [FieldOffset(Offset = "0x10")]
    public string name;
    [Token(Token = "0x4005DED")]
    [FieldOffset(Offset = "0x14")]
    public string expr;
    [Token(Token = "0x4005DEE")]
    [FieldOffset(Offset = "0x18")]
    public string icon;
    [Token(Token = "0x4005DEF")]
    [FieldOffset(Offset = "0x1C")]
    public string bg;
    [Token(Token = "0x4005DF0")]
    [FieldOffset(Offset = "0x20")]
    public string txt_img;
    [Token(Token = "0x4005DF1")]
    [FieldOffset(Offset = "0x28")]
    public DateTime start_at;
    [Token(Token = "0x4005DF2")]
    [FieldOffset(Offset = "0x30")]
    public int grade;
    [Token(Token = "0x4005DF3")]
    [FieldOffset(Offset = "0x34")]
    public int hash;
    [Token(Token = "0x4005DF4")]
    [FieldOffset(Offset = "0x38")]
    public int tab;

    [Token(Token = "0x6006883")]
    [Address(RVA = "0x34B220", Offset = "0x34A020", VA = "0x1034B220")]
    public bool Deserialize(JSON_AwardParam json) => new bool();

    [Token(Token = "0x6006884")]
    [Address(RVA = "0x34B360", Offset = "0x34A160", VA = "0x1034B360")]
    public bool IsAvailableStart(DateTime now) => new bool();

    [Token(Token = "0x6006885")]
    [Address(RVA = "0x34B3C0", Offset = "0x34A1C0", VA = "0x1034B3C0")]
    public ItemParam ToItemParam() => (ItemParam) null;

    [Token(Token = "0x6006886")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public AwardParam()
    {
    }

    [Token(Token = "0x20019A3")]
    public enum AwardGrade
    {
      [Token(Token = "0x4005DF6")] None,
      [Token(Token = "0x4005DF7")] Grade1,
      [Token(Token = "0x4005DF8")] Grade2,
      [Token(Token = "0x4005DF9")] Grade3,
      [Token(Token = "0x4005DFA")] Grade4,
      [Token(Token = "0x4005DFB")] Grade5,
      [Token(Token = "0x4005DFC")] GradeEx,
    }

    [Token(Token = "0x20019A4")]
    public enum Tab
    {
      [Token(Token = "0x4005DFE")] None = -1, // 0xFFFFFFFF
      [Token(Token = "0x4005DFF")] Normal = 0,
      [Token(Token = "0x4005E00")] Extra = 1,
    }
  }
}
