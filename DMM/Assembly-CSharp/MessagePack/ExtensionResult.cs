// Decompiled with JetBrains decompiler
// Type: MessagePack.ExtensionResult
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace MessagePack
{
  [Token(Token = "0x200035D")]
  public struct ExtensionResult
  {
    [Token(Token = "0x17000201")]
    public sbyte TypeCode
    {
      [Token(Token = "0x6001273"), Address(RVA = "0x28E4D0", Offset = "0x28D2D0", VA = "0x1028E4D0")] readonly get
      {
        return new sbyte();
      }
      [Token(Token = "0x6001274"), Address(RVA = "0x2EC6C0", Offset = "0x2EB4C0", VA = "0x102EC6C0")] private set
      {
      }
    }

    [Token(Token = "0x17000202")]
    public byte[] Data
    {
      [Token(Token = "0x6001275"), Address(RVA = "0x28E4C0", Offset = "0x28D2C0", VA = "0x1028E4C0")] readonly get
      {
        return (byte[]) null;
      }
      [Token(Token = "0x6001276"), Address(RVA = "0x2EC6F0", Offset = "0x2EB4F0", VA = "0x102EC6F0")] private set
      {
      }
    }

    [Token(Token = "0x6001277")]
    [Address(RVA = "0x2EC6D0", Offset = "0x2EB4D0", VA = "0x102EC6D0")]
    public ExtensionResult(sbyte typeCode, byte[] data)
    {
    }
  }
}
