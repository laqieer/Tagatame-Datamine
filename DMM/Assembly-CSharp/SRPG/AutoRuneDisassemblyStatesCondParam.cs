// Decompiled with JetBrains decompiler
// Type: SRPG.AutoRuneDisassemblyStatesCondParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001CD0")]
  [MessagePackObject(true)]
  public class AutoRuneDisassemblyStatesCondParam
  {
    [Token(Token = "0x40070F5")]
    [FieldOffset(Offset = "0x8")]
    private string mName;
    [Token(Token = "0x40070F6")]
    [FieldOffset(Offset = "0xC")]
    private int mType;

    [Token(Token = "0x17000F72")]
    public string Name
    {
      [Token(Token = "0x600767F"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000F73")]
    public int Type
    {
      [Token(Token = "0x6007680"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6007681")]
    [Address(RVA = "0x372170", Offset = "0x370F70", VA = "0x10372170")]
    public bool Deserialize(JSON_AutoRuneDisassemblyStatesCondParam json) => new bool();

    [Token(Token = "0x6007682")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public AutoRuneDisassemblyStatesCondParam()
    {
    }
  }
}
