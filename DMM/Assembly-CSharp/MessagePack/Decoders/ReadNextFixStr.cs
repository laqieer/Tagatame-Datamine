// Decompiled with JetBrains decompiler
// Type: MessagePack.Decoders.ReadNextFixStr
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace MessagePack.Decoders
{
  [Token(Token = "0x200044C")]
  internal sealed class ReadNextFixStr : IReadNextDecoder
  {
    [Token(Token = "0x4000E9B")]
    [FieldOffset(Offset = "0x0")]
    internal static readonly IReadNextDecoder Instance;

    [Token(Token = "0x6001519")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    private ReadNextFixStr()
    {
    }

    [Token(Token = "0x600151A")]
    [Address(RVA = "0x5C9A70", Offset = "0x5C8870", VA = "0x105C9A70", Slot = "4")]
    public int Read(byte[] bytes, int offset) => new int();

    [Token(Token = "0x600151B")]
    [Address(RVA = "0x5C9AA0", Offset = "0x5C88A0", VA = "0x105C9AA0")]
    static ReadNextFixStr()
    {
    }
  }
}
