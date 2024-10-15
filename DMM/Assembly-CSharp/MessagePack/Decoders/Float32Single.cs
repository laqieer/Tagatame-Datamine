// Decompiled with JetBrains decompiler
// Type: MessagePack.Decoders.Float32Single
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace MessagePack.Decoders
{
  [Token(Token = "0x20003D9")]
  internal sealed class Float32Single : ISingleDecoder
  {
    [Token(Token = "0x4000E35")]
    [FieldOffset(Offset = "0x0")]
    internal static readonly ISingleDecoder Instance;

    [Token(Token = "0x60013DA")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    private Float32Single()
    {
    }

    [Token(Token = "0x60013DB")]
    [Address(RVA = "0x5C0810", Offset = "0x5BF610", VA = "0x105C0810", Slot = "4")]
    public float Read(byte[] bytes, int offset, out int readSize) => new float();

    [Token(Token = "0x60013DC")]
    [Address(RVA = "0x5C08A0", Offset = "0x5BF6A0", VA = "0x105C08A0")]
    static Float32Single()
    {
    }
  }
}
