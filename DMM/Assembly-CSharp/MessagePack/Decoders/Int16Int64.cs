// Decompiled with JetBrains decompiler
// Type: MessagePack.Decoders.Int16Int64
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace MessagePack.Decoders
{
  [Token(Token = "0x2000403")]
  internal sealed class Int16Int64 : IInt64Decoder
  {
    [Token(Token = "0x4000E5B")]
    [FieldOffset(Offset = "0x0")]
    internal static readonly IInt64Decoder Instance;

    [Token(Token = "0x6001450")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    private Int16Int64()
    {
    }

    [Token(Token = "0x6001451")]
    [Address(RVA = "0x5C2020", Offset = "0x5C0E20", VA = "0x105C2020", Slot = "4")]
    public long Read(byte[] bytes, int offset, out int readSize) => new long();

    [Token(Token = "0x6001452")]
    [Address(RVA = "0x5C2070", Offset = "0x5C0E70", VA = "0x105C2070")]
    static Int16Int64()
    {
    }
  }
}
