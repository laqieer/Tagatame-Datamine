// Decompiled with JetBrains decompiler
// Type: MessagePack.Decoders.Int16Int16
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace MessagePack.Decoders
{
  [Token(Token = "0x20003EF")]
  internal sealed class Int16Int16 : IInt16Decoder
  {
    [Token(Token = "0x4000E49")]
    [FieldOffset(Offset = "0x0")]
    internal static readonly IInt16Decoder Instance;

    [Token(Token = "0x6001418")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    private Int16Int16()
    {
    }

    [Token(Token = "0x6001419")]
    [Address(RVA = "0x5C1EC0", Offset = "0x5C0CC0", VA = "0x105C1EC0", Slot = "4")]
    public short Read(byte[] bytes, int offset, out int readSize) => new short();

    [Token(Token = "0x600141A")]
    [Address(RVA = "0x5C1F10", Offset = "0x5C0D10", VA = "0x105C1F10")]
    static Int16Int16()
    {
    }
  }
}
