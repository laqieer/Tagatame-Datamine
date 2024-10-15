// Decompiled with JetBrains decompiler
// Type: LogKit_LogCollection.BufferPool
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace LogKit_LogCollection
{
  [Token(Token = "0x2003523")]
  public class BufferPool
  {
    [Token(Token = "0x400FC37")]
    [FieldOffset(Offset = "0x8")]
    private readonly int mBufferSize;
    [Token(Token = "0x400FC38")]
    [FieldOffset(Offset = "0xC")]
    private readonly List<Buffer> mBuffers;

    [Token(Token = "0x600EB32")]
    [Address(RVA = "0xAE75E0", Offset = "0xAE63E0", VA = "0x10AE75E0")]
    public BufferPool(int poolSize, int bufferSize)
    {
    }

    [Token(Token = "0x600EB33")]
    [Address(RVA = "0xAE7540", Offset = "0xAE6340", VA = "0x10AE7540")]
    public Buffer Get() => (Buffer) null;
  }
}
