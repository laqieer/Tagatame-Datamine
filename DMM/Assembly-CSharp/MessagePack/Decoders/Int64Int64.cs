// Decompiled with JetBrains decompiler
// Type: MessagePack.Decoders.Int64Int64
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace MessagePack.Decoders
{
  [Token(Token = "0x2000405")]
  internal sealed class Int64Int64 : IInt64Decoder
  {
    [Token(Token = "0x4000E5D")]
    [FieldOffset(Offset = "0x0")]
    internal static readonly IInt64Decoder Instance;

    [Token(Token = "0x6001456")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    private Int64Int64()
    {
    }

    [Token(Token = "0x6001457")]
    [Address(RVA = "0x5C25D0", Offset = "0x5C13D0", VA = "0x105C25D0", Slot = "4")]
    public long Read(byte[] bytes, int offset, out int readSize) => new long();

    [Token(Token = "0x6001458")]
    [Address(RVA = "0x5C2710", Offset = "0x5C1510", VA = "0x105C2710")]
    static Int64Int64()
    {
    }
  }
}
