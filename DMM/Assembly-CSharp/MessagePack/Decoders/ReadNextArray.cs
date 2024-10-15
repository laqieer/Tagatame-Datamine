// Decompiled with JetBrains decompiler
// Type: MessagePack.Decoders.ReadNextArray
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace MessagePack.Decoders
{
  [Token(Token = "0x200044B")]
  internal sealed class ReadNextArray : IReadNextDecoder
  {
    [Token(Token = "0x4000E9A")]
    [FieldOffset(Offset = "0x0")]
    internal static readonly IReadNextDecoder Instance;

    [Token(Token = "0x6001516")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    private ReadNextArray()
    {
    }

    [Token(Token = "0x6001517")]
    [Address(RVA = "0x5C93D0", Offset = "0x5C81D0", VA = "0x105C93D0", Slot = "4")]
    public int Read(byte[] bytes, int offset) => new int();

    [Token(Token = "0x6001518")]
    [Address(RVA = "0x5C9610", Offset = "0x5C8410", VA = "0x105C9610")]
    static ReadNextArray()
    {
    }
  }
}
