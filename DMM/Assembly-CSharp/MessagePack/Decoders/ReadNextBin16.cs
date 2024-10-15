// Decompiled with JetBrains decompiler
// Type: MessagePack.Decoders.ReadNextBin16
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace MessagePack.Decoders
{
  [Token(Token = "0x2000451")]
  internal sealed class ReadNextBin16 : IReadNextDecoder
  {
    [Token(Token = "0x4000EA0")]
    [FieldOffset(Offset = "0x0")]
    internal static readonly IReadNextDecoder Instance;

    [Token(Token = "0x6001528")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    private ReadNextBin16()
    {
    }

    [Token(Token = "0x6001529")]
    [Address(RVA = "0x5C9670", Offset = "0x5C8470", VA = "0x105C9670", Slot = "4")]
    public int Read(byte[] bytes, int offset) => new int();

    [Token(Token = "0x600152A")]
    [Address(RVA = "0x5C96B0", Offset = "0x5C84B0", VA = "0x105C96B0")]
    static ReadNextBin16()
    {
    }
  }
}
