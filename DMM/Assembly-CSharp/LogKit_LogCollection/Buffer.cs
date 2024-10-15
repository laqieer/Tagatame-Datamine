// Decompiled with JetBrains decompiler
// Type: LogKit_LogCollection.Buffer
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace LogKit_LogCollection
{
  [Token(Token = "0x2003522")]
  public class Buffer : List<Log>
  {
    [Token(Token = "0x400FC36")]
    [FieldOffset(Offset = "0x20")]
    private readonly int mSize;

    [Token(Token = "0x17002186")]
    public string mDeviceID
    {
      [Token(Token = "0x600EB2A"), Address(RVA = "0x26E190", Offset = "0x26CF90", VA = "0x1026E190")] get
      {
        return (string) null;
      }
      [Token(Token = "0x600EB2B"), Address(RVA = "0x2A5AB0", Offset = "0x2A48B0", VA = "0x102A5AB0")] set
      {
      }
    }

    [Token(Token = "0x17002187")]
    public bool IsAcquired
    {
      [Token(Token = "0x600EB2C"), Address(RVA = "0x2A5AA0", Offset = "0x2A48A0", VA = "0x102A5AA0")] get
      {
        return new bool();
      }
      [Token(Token = "0x600EB2D"), Address(RVA = "0x2A5AE0", Offset = "0x2A48E0", VA = "0x102A5AE0")] private set
      {
      }
    }

    [Token(Token = "0x17002188")]
    public int AvailableSize
    {
      [Token(Token = "0x600EB2E"), Address(RVA = "0xAE7980", Offset = "0xAE6780", VA = "0x10AE7980")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x600EB2F")]
    [Address(RVA = "0xAE78F0", Offset = "0xAE66F0", VA = "0x10AE78F0")]
    public Buffer(int size)
    {
    }

    [Token(Token = "0x600EB30")]
    [Address(RVA = "0xAE7860", Offset = "0xAE6660", VA = "0x10AE7860")]
    public void Acquire()
    {
    }

    [Token(Token = "0x600EB31")]
    [Address(RVA = "0xAE7880", Offset = "0xAE6680", VA = "0x10AE7880")]
    public void Release()
    {
    }
  }
}
