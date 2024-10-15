// Decompiled with JetBrains decompiler
// Type: SRPG.SupportData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001038")]
  public class SupportData
  {
    [Token(Token = "0x40039BF")]
    [FieldOffset(Offset = "0x8")]
    public UnitData Unit;
    [Token(Token = "0x40039C0")]
    [FieldOffset(Offset = "0xC")]
    public string FUID;
    [Token(Token = "0x40039C1")]
    [FieldOffset(Offset = "0x10")]
    public string PlayerName;
    [Token(Token = "0x40039C2")]
    [FieldOffset(Offset = "0x14")]
    public int PlayerLevel;
    [Token(Token = "0x40039C3")]
    [FieldOffset(Offset = "0x18")]
    public string UnitID;
    [Token(Token = "0x40039C4")]
    [FieldOffset(Offset = "0x1C")]
    public int UnitLevel;
    [Token(Token = "0x40039C5")]
    [FieldOffset(Offset = "0x20")]
    public int UnitRarity;
    [Token(Token = "0x40039C6")]
    [FieldOffset(Offset = "0x24")]
    public string JobID;
    [Token(Token = "0x40039C7")]
    [FieldOffset(Offset = "0x28")]
    public int LeaderSkillLevel;
    [Token(Token = "0x40039C8")]
    [FieldOffset(Offset = "0x2C")]
    public int Cost;
    [Token(Token = "0x40039C9")]
    [FieldOffset(Offset = "0x30")]
    public int mIsFriend;
    [Token(Token = "0x40039CA")]
    [FieldOffset(Offset = "0x34")]
    private List<AdventureDataBase> mAdvDataBaseList;
    [Token(Token = "0x40039CB")]
    [FieldOffset(Offset = "0x38")]
    private List<BondData> mBondDatas;

    [Token(Token = "0x17000613")]
    public List<AdventureDataBase> AdvDataBaseList
    {
      [Token(Token = "0x60042A0"), Address(RVA = "0x283700", Offset = "0x282500", VA = "0x10283700")] get
      {
        return (List<AdventureDataBase>) null;
      }
    }

    [Token(Token = "0x17000614")]
    public List<BondData> BondDatas
    {
      [Token(Token = "0x60042A1"), Address(RVA = "0x2880A0", Offset = "0x286EA0", VA = "0x102880A0")] get
      {
        return (List<BondData>) null;
      }
    }

    [Token(Token = "0x17000615")]
    public UnitParam UnitParam
    {
      [Token(Token = "0x60042A2"), Address(RVA = "0x11EA120", Offset = "0x11E8F20", VA = "0x111EA120")] get
      {
        return (UnitParam) null;
      }
    }

    [Token(Token = "0x17000616")]
    public SkillParam LeaderSkill
    {
      [Token(Token = "0x60042A3"), Address(RVA = "0x11EA0B0", Offset = "0x11E8EB0", VA = "0x111EA0B0")] get
      {
        return (SkillParam) null;
      }
    }

    [Token(Token = "0x17000617")]
    public string UnitName
    {
      [Token(Token = "0x60042A4"), Address(RVA = "0x11EA100", Offset = "0x11E8F00", VA = "0x111EA100")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000618")]
    public EElement UnitElement
    {
      [Token(Token = "0x60042A5"), Address(RVA = "0x11EA0D0", Offset = "0x11E8ED0", VA = "0x111EA0D0")] get
      {
        return new EElement();
      }
    }

    [Token(Token = "0x17000619")]
    public string IconPath
    {
      [Token(Token = "0x60042A6"), Address(RVA = "0x11EA000", Offset = "0x11E8E00", VA = "0x111EA000")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x60042A7")]
    [Address(RVA = "0x11E9F40", Offset = "0x11E8D40", VA = "0x111E9F40")]
    public bool IsFriend() => new bool();

    [Token(Token = "0x60042A8")]
    [Address(RVA = "0x2A09D0", Offset = "0x29F7D0", VA = "0x102A09D0")]
    public int GetCost() => new int();

    [Token(Token = "0x60042A9")]
    [Address(RVA = "0x11E9CE0", Offset = "0x11E8AE0", VA = "0x111E9CE0")]
    public void Deserialize(Json_Support json)
    {
    }

    [Token(Token = "0x60042AA")]
    [Address(RVA = "0x11E9F50", Offset = "0x11E8D50", VA = "0x111E9F50")]
    public SupportData()
    {
    }
  }
}
