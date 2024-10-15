// Decompiled with JetBrains decompiler
// Type: MessagePack.Decoders.FixString
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace MessagePack.Decoders
{
  [Token(Token = "0x200041B")]
  internal sealed class FixString : IStringDecoder
  {
    [Token(Token = "0x4000E6F")]
    [FieldOffset(Offset = "0x0")]
    internal static readonly IStringDecoder Instance;

    [Token(Token = "0x6001490")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    private FixString()
    {
    }

    [Token(Token = "0x6001491")]
    [Address(RVA = "0x5C0600", Offset = "0x5BF400", VA = "0x105C0600", Slot = "4")]
    public string Read(byte[] bytes, int offset, out int readSize) => (string) null;

    [Token(Token = "0x6001492")]
    [Address(RVA = "0x5C0690", Offset = "0x5BF490", VA = "0x105C0690")]
    static FixString()
    {
    }
  }
}
