// Decompiled with JetBrains decompiler
// Type: MessagePack.Decoders.UInt16UInt16
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace MessagePack.Decoders
{
  [Token(Token = "0x200040A")]
  internal sealed class UInt16UInt16 : IUInt16Decoder
  {
    [Token(Token = "0x4000E61")]
    [FieldOffset(Offset = "0x0")]
    internal static readonly IUInt16Decoder Instance;

    [Token(Token = "0x6001463")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    private UInt16UInt16()
    {
    }

    [Token(Token = "0x6001464")]
    [Address(RVA = "0x5C1EC0", Offset = "0x5C0CC0", VA = "0x105C1EC0", Slot = "4")]
    public ushort Read(byte[] bytes, int offset, out int readSize) => new ushort();

    [Token(Token = "0x6001465")]
    [Address(RVA = "0x5CBC50", Offset = "0x5CAA50", VA = "0x105CBC50")]
    static UInt16UInt16()
    {
    }
  }
}
