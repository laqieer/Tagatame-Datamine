// Decompiled with JetBrains decompiler
// Type: MessagePack.Decoders.UInt64UInt64
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace MessagePack.Decoders
{
  [Token(Token = "0x2000417")]
  internal sealed class UInt64UInt64 : IUInt64Decoder
  {
    [Token(Token = "0x4000E6C")]
    [FieldOffset(Offset = "0x0")]
    internal static readonly IUInt64Decoder Instance;

    [Token(Token = "0x6001486")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    private UInt64UInt64()
    {
    }

    [Token(Token = "0x6001487")]
    [Address(RVA = "0x5C25D0", Offset = "0x5C13D0", VA = "0x105C25D0", Slot = "4")]
    public ulong Read(byte[] bytes, int offset, out int readSize) => new ulong();

    [Token(Token = "0x6001488")]
    [Address(RVA = "0x5CC6D0", Offset = "0x5CB4D0", VA = "0x105CC6D0")]
    static UInt64UInt64()
    {
    }
  }
}
