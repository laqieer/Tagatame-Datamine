// Decompiled with JetBrains decompiler
// Type: LogKit_LogCollection.Writter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace LogKit_LogCollection
{
  [Token(Token = "0x2003524")]
  public class Writter
  {
    [Token(Token = "0x400FC39")]
    [FieldOffset(Offset = "0x0")]
    private static readonly DateTime timeStampDelta;
    [Token(Token = "0x400FC3A")]
    [FieldOffset(Offset = "0x8")]
    private readonly List<Buffer> mBuffers;
    [Token(Token = "0x400FC3B")]
    [FieldOffset(Offset = "0xC")]
    private readonly string key;

    [Token(Token = "0x600EB34")]
    [Address(RVA = "0xAFF6B0", Offset = "0xAFE4B0", VA = "0x10AFF6B0")]
    public Writter(string key)
    {
    }

    [Token(Token = "0x600EB35")]
    [Address(RVA = "0xAFF3D0", Offset = "0xAFE1D0", VA = "0x10AFF3D0")]
    public void Push(Buffer buffer)
    {
    }

    [Token(Token = "0x600EB36")]
    [Address(RVA = "0xAFF4E0", Offset = "0xAFE2E0", VA = "0x10AFF4E0")]
    public void RegistDeviceID(Buffer buffer)
    {
    }

    [Token(Token = "0x600EB37")]
    [Address(RVA = "0xAFECD0", Offset = "0xAFDAD0", VA = "0x10AFECD0")]
    public void Flush()
    {
    }

    [Token(Token = "0x600EB38")]
    [Address(RVA = "0xAFF640", Offset = "0xAFE440", VA = "0x10AFF640")]
    static Writter()
    {
    }
  }
}
