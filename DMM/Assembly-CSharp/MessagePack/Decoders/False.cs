// Decompiled with JetBrains decompiler
// Type: MessagePack.Decoders.False
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace MessagePack.Decoders
{
  [Token(Token = "0x20003B8")]
  internal sealed class False : IBooleanDecoder
  {
    [Token(Token = "0x4000E19")]
    [FieldOffset(Offset = "0x0")]
    internal static IBooleanDecoder Instance;

    [Token(Token = "0x6001381")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    private False()
    {
    }

    [Token(Token = "0x6001382")]
    [Address(RVA = "0x280EB0", Offset = "0x27FCB0", VA = "0x10280EB0", Slot = "4")]
    public bool Read() => new bool();

    [Token(Token = "0x6001383")]
    [Address(RVA = "0x5BE8A0", Offset = "0x5BD6A0", VA = "0x105BE8A0")]
    static False()
    {
    }
  }
}
