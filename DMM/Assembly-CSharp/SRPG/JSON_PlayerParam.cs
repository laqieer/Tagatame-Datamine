// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_PlayerParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001BFD")]
  [MessagePackObject(true)]
  [Serializable]
  public class JSON_PlayerParam
  {
    [Token(Token = "0x4006C57")]
    [FieldOffset(Offset = "0x8")]
    public int pt;
    [Token(Token = "0x4006C58")]
    [FieldOffset(Offset = "0xC")]
    public int ucap;
    [Token(Token = "0x4006C59")]
    [FieldOffset(Offset = "0x10")]
    public int icap;
    [Token(Token = "0x4006C5A")]
    [FieldOffset(Offset = "0x14")]
    public int ecap;
    [Token(Token = "0x4006C5B")]
    [FieldOffset(Offset = "0x18")]
    public int fcap;

    [Token(Token = "0x6007340")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_PlayerParam()
    {
    }
  }
}
