// Decompiled with JetBrains decompiler
// Type: SRPG.AutoRepeatQuestBoxParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200199D")]
  public class AutoRepeatQuestBoxParam
  {
    [Token(Token = "0x4005DDB")]
    [FieldOffset(Offset = "0x8")]
    private int mSize;
    [Token(Token = "0x4005DDC")]
    [FieldOffset(Offset = "0xC")]
    private int mCoin;

    [Token(Token = "0x17000AF5")]
    public int Size
    {
      [Token(Token = "0x600687A"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000AF6")]
    public int Coin
    {
      [Token(Token = "0x600687B"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x600687C")]
    [Address(RVA = "0x319840", Offset = "0x318640", VA = "0x10319840")]
    public void Deserialize(JSON_AutoRepeatQuestBoxParam json)
    {
    }

    [Token(Token = "0x600687D")]
    [Address(RVA = "0x349C20", Offset = "0x348A20", VA = "0x10349C20")]
    public static void Deserialize(
      ref AutoRepeatQuestBoxParam[] param,
      JSON_AutoRepeatQuestBoxParam[] json)
    {
    }

    [Token(Token = "0x600687E")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public AutoRepeatQuestBoxParam()
    {
    }
  }
}
