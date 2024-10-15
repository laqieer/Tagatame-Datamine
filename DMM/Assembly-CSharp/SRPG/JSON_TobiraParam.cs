// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_TobiraParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001D66")]
  [MessagePackObject(true)]
  [Serializable]
  public class JSON_TobiraParam
  {
    [Token(Token = "0x40073C2")]
    [FieldOffset(Offset = "0x8")]
    public string unit_iname;
    [Token(Token = "0x40073C3")]
    [FieldOffset(Offset = "0xC")]
    public int enable;
    [Token(Token = "0x40073C4")]
    [FieldOffset(Offset = "0x10")]
    public int category;
    [Token(Token = "0x40073C5")]
    [FieldOffset(Offset = "0x14")]
    public string recipe_id;
    [Token(Token = "0x40073C6")]
    [FieldOffset(Offset = "0x18")]
    public string skill_iname;
    [Token(Token = "0x40073C7")]
    [FieldOffset(Offset = "0x1C")]
    public JSON_TobiraLearnAbilityParam[] learn_abils;
    [Token(Token = "0x40073C8")]
    [FieldOffset(Offset = "0x20")]
    public string overwrite_ls_iname;
    [Token(Token = "0x40073C9")]
    [FieldOffset(Offset = "0x24")]
    public int priority;

    [Token(Token = "0x600785E")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_TobiraParam()
    {
    }
  }
}
