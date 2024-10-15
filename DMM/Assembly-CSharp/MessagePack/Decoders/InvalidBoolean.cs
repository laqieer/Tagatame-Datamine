// Decompiled with JetBrains decompiler
// Type: MessagePack.Decoders.InvalidBoolean
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace MessagePack.Decoders
{
  [Token(Token = "0x20003B9")]
  internal sealed class InvalidBoolean : IBooleanDecoder
  {
    [Token(Token = "0x4000E1A")]
    [FieldOffset(Offset = "0x0")]
    internal static IBooleanDecoder Instance;

    [Token(Token = "0x6001384")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    private InvalidBoolean()
    {
    }

    [Token(Token = "0x6001385")]
    [Address(RVA = "0x5C2D80", Offset = "0x5C1B80", VA = "0x105C2D80", Slot = "4")]
    public bool Read() => new bool();

    [Token(Token = "0x6001386")]
    [Address(RVA = "0x5C2DD0", Offset = "0x5C1BD0", VA = "0x105C2DD0")]
    static InvalidBoolean()
    {
    }
  }
}
