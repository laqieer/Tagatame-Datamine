// Decompiled with JetBrains decompiler
// Type: MessagePack.Decoders.UInt8UInt64
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace MessagePack.Decoders
{
  [Token(Token = "0x2000414")]
  internal sealed class UInt8UInt64 : IUInt64Decoder
  {
    [Token(Token = "0x4000E69")]
    [FieldOffset(Offset = "0x0")]
    internal static readonly IUInt64Decoder Instance;

    [Token(Token = "0x600147D")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    private UInt8UInt64()
    {
    }

    [Token(Token = "0x600147E")]
    [Address(RVA = "0x5CC970", Offset = "0x5CB770", VA = "0x105CC970", Slot = "4")]
    public ulong Read(byte[] bytes, int offset, out int readSize) => new ulong();

    [Token(Token = "0x600147F")]
    [Address(RVA = "0x5CCBA0", Offset = "0x5CB9A0", VA = "0x105CCBA0")]
    static UInt8UInt64()
    {
    }
  }
}
