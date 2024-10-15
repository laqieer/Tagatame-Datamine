// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_GvGRuleParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001B8F")]
  [MessagePackObject(true)]
  [Serializable]
  public class JSON_GvGRuleParam : JSON_GvGMasterParam
  {
    [Token(Token = "0x400690D")]
    [FieldOffset(Offset = "0x8")]
    public string iname;
    [Token(Token = "0x400690E")]
    [FieldOffset(Offset = "0xC")]
    public string name;
    [Token(Token = "0x400690F")]
    [FieldOffset(Offset = "0x10")]
    public int unit_cnt;
    [Token(Token = "0x4006910")]
    [FieldOffset(Offset = "0x14")]
    public int def_unit_cnt;
    [Token(Token = "0x4006911")]
    [FieldOffset(Offset = "0x18")]
    public int unit_cool_time;
    [Token(Token = "0x4006912")]
    [FieldOffset(Offset = "0x1C")]
    public int[] cnds_birth;

    [Token(Token = "0x60071F6")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_GvGRuleParam()
    {
    }
  }
}
