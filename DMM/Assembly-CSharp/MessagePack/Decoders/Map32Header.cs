// Decompiled with JetBrains decompiler
// Type: MessagePack.Decoders.Map32Header
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace MessagePack.Decoders
{
  [Token(Token = "0x20003AF")]
  internal sealed class Map32Header : IMapHeaderDecoder
  {
    [Token(Token = "0x4000E12")]
    [FieldOffset(Offset = "0x0")]
    internal static readonly IMapHeaderDecoder Instance;

    [Token(Token = "0x600136A")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    private Map32Header()
    {
    }

    [Token(Token = "0x600136B")]
    [Address(RVA = "0x5BAC30", Offset = "0x5B9A30", VA = "0x105BAC30", Slot = "4")]
    public uint Read(byte[] bytes, int offset, out int readSize) => new uint();

    [Token(Token = "0x600136C")]
    [Address(RVA = "0x5C8D90", Offset = "0x5C7B90", VA = "0x105C8D90")]
    static Map32Header()
    {
    }
  }
}
