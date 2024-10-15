// Decompiled with JetBrains decompiler
// Type: MessagePack.Decoders.UInt16Int16
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace MessagePack.Decoders
{
  [Token(Token = "0x20003ED")]
  internal sealed class UInt16Int16 : IInt16Decoder
  {
    [Token(Token = "0x4000E47")]
    [FieldOffset(Offset = "0x0")]
    internal static readonly IInt16Decoder Instance;

    [Token(Token = "0x6001412")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    private UInt16Int16()
    {
    }

    [Token(Token = "0x6001413")]
    [Address(RVA = "0x5CB940", Offset = "0x5CA740", VA = "0x105CB940", Slot = "4")]
    public short Read(byte[] bytes, int offset, out int readSize) => new short();

    [Token(Token = "0x6001414")]
    [Address(RVA = "0x5CB9F0", Offset = "0x5CA7F0", VA = "0x105CB9F0")]
    static UInt16Int16()
    {
    }
  }
}
