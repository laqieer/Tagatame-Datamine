﻿// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_ChatBlackList
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200218A")]
  public class JSON_ChatBlackList
  {
    [Token(Token = "0x40092A5")]
    [FieldOffset(Offset = "0x8")]
    public ChatBlackListParam[] blacklist;
    [Token(Token = "0x40092A6")]
    [FieldOffset(Offset = "0xC")]
    public int total;

    [Token(Token = "0x6008D22")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_ChatBlackList()
    {
    }
  }
}