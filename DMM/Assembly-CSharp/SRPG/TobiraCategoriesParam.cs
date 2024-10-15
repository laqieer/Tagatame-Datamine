// Decompiled with JetBrains decompiler
// Type: SRPG.TobiraCategoriesParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001D58")]
  public class TobiraCategoriesParam
  {
    [Token(Token = "0x400738B")]
    [FieldOffset(Offset = "0x8")]
    private TobiraParam.Category mCategory;
    [Token(Token = "0x400738C")]
    [FieldOffset(Offset = "0xC")]
    private string mName;

    [Token(Token = "0x17000FF9")]
    public TobiraParam.Category TobiraCategory
    {
      [Token(Token = "0x600782E"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return new TobiraParam.Category();
      }
    }

    [Token(Token = "0x17000FFA")]
    public string Name
    {
      [Token(Token = "0x600782F"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x6007830")]
    [Address(RVA = "0x31B680", Offset = "0x31A480", VA = "0x1031B680")]
    public void Deserialize(JSON_TobiraCategoriesParam json)
    {
    }

    [Token(Token = "0x6007831")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public TobiraCategoriesParam()
    {
    }
  }
}
