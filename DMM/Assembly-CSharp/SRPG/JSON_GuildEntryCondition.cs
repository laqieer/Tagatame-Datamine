// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_GuildEntryCondition
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2000F84")]
  [Serializable]
  public class JSON_GuildEntryCondition
  {
    [Token(Token = "0x4003682")]
    [FieldOffset(Offset = "0x8")]
    public int lower_level;
    [Token(Token = "0x4003683")]
    [FieldOffset(Offset = "0xC")]
    public int is_auto_approval;
    [Token(Token = "0x4003684")]
    [FieldOffset(Offset = "0x10")]
    public string recruit_comment;
    [Token(Token = "0x4003685")]
    [FieldOffset(Offset = "0x14")]
    public int policy;

    [Token(Token = "0x6004058")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_GuildEntryCondition()
    {
    }
  }
}
