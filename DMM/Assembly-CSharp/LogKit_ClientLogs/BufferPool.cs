// Decompiled with JetBrains decompiler
// Type: LogKit_ClientLogs.BufferPool
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace LogKit_ClientLogs
{
  [Token(Token = "0x2003528")]
  public class BufferPool
  {
    [Token(Token = "0x400FC42")]
    [FieldOffset(Offset = "0x8")]
    private readonly int mBufferSize;
    [Token(Token = "0x400FC43")]
    [FieldOffset(Offset = "0xC")]
    private readonly List<Buffer> mBuffers;

    [Token(Token = "0x600EB48")]
    [Address(RVA = "0xAE7720", Offset = "0xAE6520", VA = "0x10AE7720")]
    public BufferPool(int poolSize, int bufferSize)
    {
    }

    [Token(Token = "0x600EB49")]
    [Address(RVA = "0xAE74A0", Offset = "0xAE62A0", VA = "0x10AE74A0")]
    public Buffer Get() => (Buffer) null;
  }
}
