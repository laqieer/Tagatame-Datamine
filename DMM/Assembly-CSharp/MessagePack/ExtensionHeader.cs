// Decompiled with JetBrains decompiler
// Type: MessagePack.ExtensionHeader
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace MessagePack
{
  [Token(Token = "0x200035E")]
  public struct ExtensionHeader
  {
    [Token(Token = "0x17000203")]
    public sbyte TypeCode
    {
      [Token(Token = "0x6001278"), Address(RVA = "0x28E4D0", Offset = "0x28D2D0", VA = "0x1028E4D0")] readonly get
      {
        return new sbyte();
      }
      [Token(Token = "0x6001279"), Address(RVA = "0x2EC6C0", Offset = "0x2EB4C0", VA = "0x102EC6C0")] private set
      {
      }
    }

    [Token(Token = "0x17000204")]
    public uint Length
    {
      [Token(Token = "0x600127A"), Address(RVA = "0x28E4C0", Offset = "0x28D2C0", VA = "0x1028E4C0")] readonly get
      {
        return new uint();
      }
      [Token(Token = "0x600127B"), Address(RVA = "0x2EC6B0", Offset = "0x2EB4B0", VA = "0x102EC6B0")] private set
      {
      }
    }

    [Token(Token = "0x600127C")]
    [Address(RVA = "0x26CF10", Offset = "0x26BD10", VA = "0x1026CF10")]
    public ExtensionHeader(sbyte typeCode, uint length)
    {
    }
  }
}
