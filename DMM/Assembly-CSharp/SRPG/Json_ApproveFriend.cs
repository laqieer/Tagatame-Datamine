﻿// Decompiled with JetBrains decompiler
// Type: SRPG.Json_ApproveFriend
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001030")]
  public class Json_ApproveFriend
  {
    [Token(Token = "0x4003994")]
    [FieldOffset(Offset = "0x8")]
    public Json_PlayerData player;
    [Token(Token = "0x4003995")]
    [FieldOffset(Offset = "0xC")]
    public Json_Friend[] friends;
    [Token(Token = "0x4003996")]
    [FieldOffset(Offset = "0x10")]
    public int first_count;

    [Token(Token = "0x6004296")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public Json_ApproveFriend()
    {
    }
  }
}