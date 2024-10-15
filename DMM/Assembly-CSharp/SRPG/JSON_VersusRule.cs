// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_VersusRule
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001EDC")]
  [MessagePackObject(true)]
  [Serializable]
  public class JSON_VersusRule
  {
    [Token(Token = "0x40081BF")]
    [FieldOffset(Offset = "0x8")]
    public int id;
    [Token(Token = "0x40081C0")]
    [FieldOffset(Offset = "0xC")]
    public string begin_at;
    [Token(Token = "0x40081C1")]
    [FieldOffset(Offset = "0x10")]
    public string end_at;
    [Token(Token = "0x40081C2")]
    [FieldOffset(Offset = "0x14")]
    public int vsmode;
    [Token(Token = "0x40081C3")]
    [FieldOffset(Offset = "0x18")]
    public int getcoin;
    [Token(Token = "0x40081C4")]
    [FieldOffset(Offset = "0x1C")]
    public int rate;

    [Token(Token = "0x6007E3F")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_VersusRule()
    {
    }
  }
}
