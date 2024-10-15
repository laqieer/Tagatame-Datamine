// Decompiled with JetBrains decompiler
// Type: MessagePack.Decoders.ReadNext5
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace MessagePack.Decoders
{
  [Token(Token = "0x2000445")]
  internal sealed class ReadNext5 : IReadNextDecoder
  {
    [Token(Token = "0x4000E94")]
    [FieldOffset(Offset = "0x0")]
    internal static readonly IReadNextDecoder Instance;

    [Token(Token = "0x6001504")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    private ReadNext5()
    {
    }

    [Token(Token = "0x6001505")]
    [Address(RVA = "0x5C9280", Offset = "0x5C8080", VA = "0x105C9280", Slot = "4")]
    public int Read(byte[] bytes, int offset) => new int();

    [Token(Token = "0x6001506")]
    [Address(RVA = "0x5C9290", Offset = "0x5C8090", VA = "0x105C9290")]
    static ReadNext5()
    {
    }
  }
}
