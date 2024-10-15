// Decompiled with JetBrains decompiler
// Type: SRPG.RunePrideResetData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001D0D")]
  public class RunePrideResetData
  {
    [Token(Token = "0x40071E0")]
    [FieldOffset(Offset = "0x8")]
    private int mMin;
    [Token(Token = "0x40071E1")]
    [FieldOffset(Offset = "0xC")]
    private int mMax;
    [Token(Token = "0x40071E2")]
    [FieldOffset(Offset = "0x10")]
    private string mNeedItem;

    [Token(Token = "0x17000FBA")]
    public int Min
    {
      [Token(Token = "0x600774A"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000FBB")]
    public int Max
    {
      [Token(Token = "0x600774B"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000FBC")]
    public string NeedItem
    {
      [Token(Token = "0x600774C"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x600774D")]
    [Address(RVA = "0x39D030", Offset = "0x39BE30", VA = "0x1039D030")]
    public void Deserialize(JSON_RunePrideResetData _json)
    {
    }

    [Token(Token = "0x600774E")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public RunePrideResetData()
    {
    }
  }
}
