// Decompiled with JetBrains decompiler
// Type: SRPG.RaidBossData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20010DB")]
  public class RaidBossData
  {
    [Token(Token = "0x4003CD4")]
    [FieldOffset(Offset = "0x8")]
    private string mOwnerUID;
    [Token(Token = "0x4003CD5")]
    [FieldOffset(Offset = "0xC")]
    private string mOwnerName;
    [Token(Token = "0x4003CD6")]
    [FieldOffset(Offset = "0x10")]
    private int mAreaId;
    [Token(Token = "0x4003CD7")]
    [FieldOffset(Offset = "0x14")]
    private RaidBossInfo mRaidBossInfo;
    [Token(Token = "0x4003CD8")]
    [FieldOffset(Offset = "0x18")]
    private RaidSOSStatus mSOSStatus;
    [Token(Token = "0x4003CD9")]
    [FieldOffset(Offset = "0x1C")]
    private List<RaidSOSMember> mSOSMember;

    [Token(Token = "0x1700070A")]
    public string OwnerUID
    {
      [Token(Token = "0x6004727"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x1700070B")]
    public string OwnerName
    {
      [Token(Token = "0x6004728"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x1700070C")]
    public int AreaId
    {
      [Token(Token = "0x6004729"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x1700070D")]
    public RaidBossInfo RaidBossInfo
    {
      [Token(Token = "0x600472A"), Address(RVA = "0x2BAA70", Offset = "0x2B9870", VA = "0x102BAA70")] get
      {
        return (RaidBossInfo) null;
      }
    }

    [Token(Token = "0x1700070E")]
    public RaidSOSStatus SOSStatus
    {
      [Token(Token = "0x600472B"), Address(RVA = "0x26E190", Offset = "0x26CF90", VA = "0x1026E190")] get
      {
        return new RaidSOSStatus();
      }
    }

    [Token(Token = "0x1700070F")]
    public List<RaidSOSMember> SOSMember
    {
      [Token(Token = "0x600472C"), Address(RVA = "0x2700B0", Offset = "0x26EEB0", VA = "0x102700B0")] get
      {
        return (List<RaidSOSMember>) null;
      }
    }

    [Token(Token = "0x600472D")]
    [Address(RVA = "0x11E7F10", Offset = "0x11E6D10", VA = "0x111E7F10")]
    public bool Deserialize(JSON_RaidBossData json) => new bool();

    [Token(Token = "0x600472E")]
    [Address(RVA = "0x11E8300", Offset = "0x11E7100", VA = "0x111E8300")]
    public void SOSDone()
    {
    }

    [Token(Token = "0x600472F")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public RaidBossData()
    {
    }
  }
}
