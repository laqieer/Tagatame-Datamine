// Decompiled with JetBrains decompiler
// Type: SRPG.AutoRuneSettingCondParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001CCC")]
  [MessagePackObject(true)]
  public class AutoRuneSettingCondParam
  {
    [Token(Token = "0x40070EB")]
    [FieldOffset(Offset = "0x8")]
    private string mName;
    [Token(Token = "0x40070EC")]
    [FieldOffset(Offset = "0xC")]
    private int mSet_eff;
    [Token(Token = "0x40070ED")]
    [FieldOffset(Offset = "0x10")]
    private int mRune_type;
    [Token(Token = "0x40070EE")]
    [FieldOffset(Offset = "0x14")]
    private string mState;

    [Token(Token = "0x17000F6C")]
    public string Name
    {
      [Token(Token = "0x6007672"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000F6D")]
    public int Set_eff
    {
      [Token(Token = "0x6007673"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000F6E")]
    public int Rune_type
    {
      [Token(Token = "0x6007674"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000F6F")]
    public string State
    {
      [Token(Token = "0x6007675"), Address(RVA = "0x2BAA70", Offset = "0x2B9870", VA = "0x102BAA70")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x6007676")]
    [Address(RVA = "0x38F8E0", Offset = "0x38E6E0", VA = "0x1038F8E0")]
    public bool Deserialize(JSON_AutoRuneDisassemblySettingCondParam json) => new bool();

    [Token(Token = "0x6007677")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public AutoRuneSettingCondParam()
    {
    }
  }
}
