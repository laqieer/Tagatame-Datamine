// Decompiled with JetBrains decompiler
// Type: LogKit_ClientLogs.Writter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace LogKit_ClientLogs
{
  [Token(Token = "0x200352F")]
  public class Writter
  {
    [Token(Token = "0x400FC67")]
    [FieldOffset(Offset = "0x8")]
    private readonly List<Buffer> mBuffers;
    [Token(Token = "0x400FC68")]
    [FieldOffset(Offset = "0xC")]
    private readonly string key;
    [Token(Token = "0x400FC69")]
    [FieldOffset(Offset = "0x10")]
    private readonly string mDeviceID;
    [Token(Token = "0x400FC6A")]
    [FieldOffset(Offset = "0x0")]
    protected static readonly DateTime timeStampDelta;

    [Token(Token = "0x600EB87")]
    [Address(RVA = "0xB1CC20", Offset = "0xB1BA20", VA = "0x10B1CC20")]
    public Writter(string key)
    {
    }

    [Token(Token = "0x600EB88")]
    [Address(RVA = "0xB1CAB0", Offset = "0xB1B8B0", VA = "0x10B1CAB0")]
    public void Push(Buffer buffer)
    {
    }

    [Token(Token = "0x600EB89")]
    [Address(RVA = "0xB1C790", Offset = "0xB1B590", VA = "0x10B1C790")]
    private string GetLog(Log log) => (string) null;

    [Token(Token = "0x600EB8A")]
    [Address(RVA = "0xB1C090", Offset = "0xB1AE90", VA = "0x10B1C090")]
    private string CreateLog(Buffer buffer) => (string) null;

    [Token(Token = "0x600EB8B")]
    [Address(RVA = "0xB1C380", Offset = "0xB1B180", VA = "0x10B1C380")]
    public void Flush()
    {
    }

    [Token(Token = "0x600EB8C")]
    [Address(RVA = "0xB1CBB0", Offset = "0xB1B9B0", VA = "0x10B1CBB0")]
    static Writter()
    {
    }
  }
}
