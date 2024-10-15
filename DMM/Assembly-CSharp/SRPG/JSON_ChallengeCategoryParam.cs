// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_ChallengeCategoryParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001A41")]
  [MessagePackObject(true)]
  [Serializable]
  public class JSON_ChallengeCategoryParam
  {
    [Token(Token = "0x40060B3")]
    [FieldOffset(Offset = "0x8")]
    public string iname;
    [Token(Token = "0x40060B4")]
    [FieldOffset(Offset = "0xC")]
    public string begin_at;
    [Token(Token = "0x40060B5")]
    [FieldOffset(Offset = "0x10")]
    public string end_at;
    [Token(Token = "0x40060B6")]
    [FieldOffset(Offset = "0x14")]
    public int prio;
    [Token(Token = "0x40060B7")]
    [FieldOffset(Offset = "0x18")]
    public string beginner_period;

    [Token(Token = "0x6006BFA")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_ChallengeCategoryParam()
    {
    }
  }
}
