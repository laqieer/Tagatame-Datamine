// Decompiled with JetBrains decompiler
// Type: MessagePack.Decoders.ReadNextMap
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace MessagePack.Decoders
{
  [Token(Token = "0x200044A")]
  internal sealed class ReadNextMap : IReadNextDecoder
  {
    [Token(Token = "0x4000E99")]
    [FieldOffset(Offset = "0x0")]
    internal static readonly IReadNextDecoder Instance;

    [Token(Token = "0x6001513")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    private ReadNextMap()
    {
    }

    [Token(Token = "0x6001514")]
    [Address(RVA = "0x5C9B00", Offset = "0x5C8900", VA = "0x105C9B00", Slot = "4")]
    public int Read(byte[] bytes, int offset) => new int();

    [Token(Token = "0x6001515")]
    [Address(RVA = "0x5C9E20", Offset = "0x5C8C20", VA = "0x105C9E20")]
    static ReadNextMap()
    {
    }
  }
}
