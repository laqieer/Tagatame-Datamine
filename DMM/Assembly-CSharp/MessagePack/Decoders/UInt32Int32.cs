// Decompiled with JetBrains decompiler
// Type: MessagePack.Decoders.UInt32Int32
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace MessagePack.Decoders
{
  [Token(Token = "0x20003F6")]
  internal sealed class UInt32Int32 : IInt32Decoder
  {
    [Token(Token = "0x4000E4F")]
    [FieldOffset(Offset = "0x0")]
    internal static readonly IInt32Decoder Instance;

    [Token(Token = "0x600142B")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    private UInt32Int32()
    {
    }

    [Token(Token = "0x600142C")]
    [Address(RVA = "0x5CBE60", Offset = "0x5CAC60", VA = "0x105CBE60", Slot = "4")]
    public int Read(byte[] bytes, int offset, out int readSize) => new int();

    [Token(Token = "0x600142D")]
    [Address(RVA = "0x5CBF30", Offset = "0x5CAD30", VA = "0x105CBF30")]
    static UInt32Int32()
    {
    }
  }
}
