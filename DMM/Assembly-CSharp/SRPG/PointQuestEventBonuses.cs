// Decompiled with JetBrains decompiler
// Type: SRPG.PointQuestEventBonuses
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001C02")]
  public class PointQuestEventBonuses
  {
    [Token(Token = "0x4006C7E")]
    [FieldOffset(Offset = "0x8")]
    private PointQuestBonusPartyType mType;
    [Token(Token = "0x4006C7F")]
    [FieldOffset(Offset = "0xC")]
    private string mIname;
    [Token(Token = "0x4006C80")]
    [FieldOffset(Offset = "0x10")]
    private int mRate;

    [Token(Token = "0x17000E4E")]
    public PointQuestBonusPartyType Type
    {
      [Token(Token = "0x6007350"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return new PointQuestBonusPartyType();
      }
    }

    [Token(Token = "0x17000E4F")]
    public string Iname
    {
      [Token(Token = "0x6007351"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000E50")]
    public int Rate
    {
      [Token(Token = "0x6007352"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6007353")]
    [Address(RVA = "0x31AF60", Offset = "0x319D60", VA = "0x1031AF60")]
    public void Deserialize(JSON_PointQuestEventBonuses json)
    {
    }

    [Token(Token = "0x6007354")]
    [Address(RVA = "0x37D0D0", Offset = "0x37BED0", VA = "0x1037D0D0")]
    public int GetBonusRate(PointQuestBonusPartyType type, string iname) => new int();

    [Token(Token = "0x6007355")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public PointQuestEventBonuses()
    {
    }
  }
}
