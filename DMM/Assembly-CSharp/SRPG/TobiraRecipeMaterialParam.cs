// Decompiled with JetBrains decompiler
// Type: SRPG.TobiraRecipeMaterialParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001D6D")]
  public class TobiraRecipeMaterialParam
  {
    [Token(Token = "0x40073F3")]
    [FieldOffset(Offset = "0x8")]
    private string mIname;
    [Token(Token = "0x40073F4")]
    [FieldOffset(Offset = "0xC")]
    private int mNum;

    [Token(Token = "0x17001020")]
    public string Iname
    {
      [Token(Token = "0x6007878"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17001021")]
    public int Num
    {
      [Token(Token = "0x6007879"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x600787A")]
    [Address(RVA = "0x3A4B40", Offset = "0x3A3940", VA = "0x103A4B40")]
    public void Deserialize(JSON_TobiraRecipeMaterialParam json)
    {
    }

    [Token(Token = "0x600787B")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public TobiraRecipeMaterialParam()
    {
    }
  }
}
