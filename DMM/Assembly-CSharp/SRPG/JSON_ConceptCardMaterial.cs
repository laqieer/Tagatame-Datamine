﻿// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_ConceptCardMaterial
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2000E86")]
  [MessagePackObject(true)]
  public class JSON_ConceptCardMaterial
  {
    [Token(Token = "0x4002C97")]
    [FieldOffset(Offset = "0x8")]
    public long id;
    [Token(Token = "0x4002C98")]
    [FieldOffset(Offset = "0x10")]
    public string iname;
    [Token(Token = "0x4002C99")]
    [FieldOffset(Offset = "0x14")]
    public int num;

    [Token(Token = "0x6003C36")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_ConceptCardMaterial()
    {
    }
  }
}