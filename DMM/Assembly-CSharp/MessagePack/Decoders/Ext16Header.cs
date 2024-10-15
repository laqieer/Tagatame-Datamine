// Decompiled with JetBrains decompiler
// Type: MessagePack.Decoders.Ext16Header
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace MessagePack.Decoders
{
  [Token(Token = "0x2000438")]
  internal sealed class Ext16Header : IExtHeaderDecoder
  {
    [Token(Token = "0x4000E89")]
    [FieldOffset(Offset = "0x0")]
    internal static readonly IExtHeaderDecoder Instance;

    [Token(Token = "0x60014E1")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    private Ext16Header()
    {
    }

    [Token(Token = "0x60014E2")]
    [Address(RVA = "0x5BDEA0", Offset = "0x5BCCA0", VA = "0x105BDEA0", Slot = "4")]
    public ExtensionHeader Read(byte[] bytes, int offset, out int readSize)
    {
      return new ExtensionHeader();
    }

    [Token(Token = "0x60014E3")]
    [Address(RVA = "0x5BDF20", Offset = "0x5BCD20", VA = "0x105BDF20")]
    static Ext16Header()
    {
    }
  }
}
