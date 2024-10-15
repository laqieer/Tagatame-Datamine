// Decompiled with JetBrains decompiler
// Type: MessagePack.Decoders.Map16Header
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace MessagePack.Decoders
{
  [Token(Token = "0x20003AE")]
  internal sealed class Map16Header : IMapHeaderDecoder
  {
    [Token(Token = "0x4000E11")]
    [FieldOffset(Offset = "0x0")]
    internal static readonly IMapHeaderDecoder Instance;

    [Token(Token = "0x6001367")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    private Map16Header()
    {
    }

    [Token(Token = "0x6001368")]
    [Address(RVA = "0x5BAB80", Offset = "0x5B9980", VA = "0x105BAB80", Slot = "4")]
    public uint Read(byte[] bytes, int offset, out int readSize) => new uint();

    [Token(Token = "0x6001369")]
    [Address(RVA = "0x5C8D30", Offset = "0x5C7B30", VA = "0x105C8D30")]
    static Map16Header()
    {
    }
  }
}
