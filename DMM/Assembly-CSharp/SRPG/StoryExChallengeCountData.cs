// Decompiled with JetBrains decompiler
// Type: SRPG.StoryExChallengeCountData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001C57")]
  public class StoryExChallengeCountData
  {
    [Token(Token = "0x4006F53")]
    [FieldOffset(Offset = "0x8")]
    private int mNum;
    [Token(Token = "0x4006F54")]
    [FieldOffset(Offset = "0xC")]
    private int mReset;

    [Token(Token = "0x17000EE8")]
    public int Num
    {
      [Token(Token = "0x6007502"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000EE9")]
    public int Reset
    {
      [Token(Token = "0x6007503"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000EEA")]
    public int RestChallengeCount
    {
      [Token(Token = "0x6007504"), Address(RVA = "0x3A0360", Offset = "0x39F160", VA = "0x103A0360")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000EEB")]
    public int RestResetCount
    {
      [Token(Token = "0x6007505"), Address(RVA = "0x3A0410", Offset = "0x39F210", VA = "0x103A0410")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6007506")]
    [Address(RVA = "0x3A0220", Offset = "0x39F020", VA = "0x103A0220")]
    public void Deserialize(JSON_StoryExChallengeCount json)
    {
    }

    [Token(Token = "0x6007507")]
    [Address(RVA = "0x3A0240", Offset = "0x39F040", VA = "0x103A0240")]
    public bool IsRestChallengeCount_Zero() => new bool();

    [Token(Token = "0x6007508")]
    [Address(RVA = "0x3A0300", Offset = "0x39F100", VA = "0x103A0300")]
    public bool IsRestResetCount_Zero() => new bool();

    [Token(Token = "0x6007509")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public StoryExChallengeCountData()
    {
    }
  }
}
