﻿// Decompiled with JetBrains decompiler
// Type: SRPG.ChatSendRes
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200218D")]
  public class ChatSendRes
  {
    [Token(Token = "0x40092AA")]
    [FieldOffset(Offset = "0x8")]
    public byte is_success;

    [Token(Token = "0x170013E7")]
    public bool IsSuccess
    {
      [Token(Token = "0x6008D26"), Address(RVA = "0x50C950", Offset = "0x50B750", VA = "0x1050C950")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x6008D27")]
    [Address(RVA = "0x50C930", Offset = "0x50B730", VA = "0x1050C930")]
    public void Deserialize(JSON_ChatSendRes json)
    {
    }

    [Token(Token = "0x6008D28")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public ChatSendRes()
    {
    }
  }
}