// Decompiled with JetBrains decompiler
// Type: SRPG.VersusDraftDeckParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001EB3")]
  public class VersusDraftDeckParam
  {
    [Token(Token = "0x4008096")]
    [FieldOffset(Offset = "0x8")]
    private int mId;
    [Token(Token = "0x4008097")]
    [FieldOffset(Offset = "0xC")]
    private string mName;
    [Token(Token = "0x4008098")]
    [FieldOffset(Offset = "0x10")]
    private int mFixSecret;

    [Token(Token = "0x17001198")]
    public int Id
    {
      [Token(Token = "0x6007DCD"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17001199")]
    public string Name
    {
      [Token(Token = "0x6007DCE"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x1700119A")]
    public int FixSecret
    {
      [Token(Token = "0x6007DCF"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6007DD0")]
    [Address(RVA = "0x3569E0", Offset = "0x3557E0", VA = "0x103569E0")]
    public bool Deserialize(JSON_VersusDraftDeckParam param) => new bool();

    [Token(Token = "0x6007DD1")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public VersusDraftDeckParam()
    {
    }
  }
}
