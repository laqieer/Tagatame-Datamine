// Decompiled with JetBrains decompiler
// Type: LogKit_ClientLogs.Buffer
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace LogKit_ClientLogs
{
  [Token(Token = "0x2003527")]
  public class Buffer : List<Log>
  {
    [Token(Token = "0x400FC41")]
    [FieldOffset(Offset = "0x1C")]
    private readonly int mSize;

    [Token(Token = "0x17002189")]
    public bool IsAcquired
    {
      [Token(Token = "0x600EB42"), Address(RVA = "0x3057E0", Offset = "0x3045E0", VA = "0x103057E0")] get
      {
        return new bool();
      }
      [Token(Token = "0x600EB43"), Address(RVA = "0x305870", Offset = "0x304670", VA = "0x10305870")] private set
      {
      }
    }

    [Token(Token = "0x1700218A")]
    public int AvailableSize
    {
      [Token(Token = "0x600EB44"), Address(RVA = "0xAE7950", Offset = "0xAE6750", VA = "0x10AE7950")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x600EB45")]
    [Address(RVA = "0xAE7890", Offset = "0xAE6690", VA = "0x10AE7890")]
    public Buffer(int size)
    {
    }

    [Token(Token = "0x600EB46")]
    [Address(RVA = "0x5EFFD0", Offset = "0x5EEDD0", VA = "0x105EFFD0")]
    public void Acquire()
    {
    }

    [Token(Token = "0x600EB47")]
    [Address(RVA = "0xAE7870", Offset = "0xAE6670", VA = "0x10AE7870")]
    public void Release()
    {
    }
  }
}
