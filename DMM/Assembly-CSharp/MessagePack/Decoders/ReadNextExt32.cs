// Decompiled with JetBrains decompiler
// Type: MessagePack.Decoders.ReadNextExt32
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace MessagePack.Decoders
{
  [Token(Token = "0x2000455")]
  internal sealed class ReadNextExt32 : IReadNextDecoder
  {
    [Token(Token = "0x4000EA4")]
    [FieldOffset(Offset = "0x0")]
    internal static readonly IReadNextDecoder Instance;

    [Token(Token = "0x6001534")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    private ReadNextExt32()
    {
    }

    [Token(Token = "0x6001535")]
    [Address(RVA = "0x5C9910", Offset = "0x5C8710", VA = "0x105C9910", Slot = "4")]
    public int Read(byte[] bytes, int offset) => new int();

    [Token(Token = "0x6001536")]
    [Address(RVA = "0x5C9980", Offset = "0x5C8780", VA = "0x105C9980")]
    static ReadNextExt32()
    {
    }
  }
}
