// Decompiled with JetBrains decompiler
// Type: SRPG.GvGLeagueManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20025D6")]
  [AddComponentMenu("UI/GvG/GvGLeagueManager")]
  public class GvGLeagueManager : MonoBehaviour
  {
    [Token(Token = "0x400AFAB")]
    [FieldOffset(Offset = "0x0")]
    private static GvGLeagueManager mInstance;

    [Token(Token = "0x170017A7")]
    public static GvGLeagueManager Instance
    {
      [Token(Token = "0x600A82D"), Address(RVA = "0x6B6890", Offset = "0x6B5690", VA = "0x106B6890")] get
      {
        return (GvGLeagueManager) null;
      }
    }

    [Token(Token = "0x170017A8")]
    public Dictionary<string, GvGLeagueManager.GvGLeagueDataList> LeagueData
    {
      [Token(Token = "0x600A82E"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (Dictionary<string, GvGLeagueManager.GvGLeagueDataList>) null;
      }
      [Token(Token = "0x600A82F"), Address(RVA = "0x301130", Offset = "0x2FFF30", VA = "0x10301130")] set
      {
      }
    }

    [Token(Token = "0x170017A9")]
    public GvGLeagueManager.GvGLeagueDataList AllLeagueData
    {
      [Token(Token = "0x600A830"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return (GvGLeagueManager.GvGLeagueDataList) null;
      }
      [Token(Token = "0x600A831"), Address(RVA = "0x2ECBC0", Offset = "0x2EB9C0", VA = "0x102ECBC0")] set
      {
      }
    }

    [Token(Token = "0x170017AA")]
    public GvGLeagueViewGuild MyGuildLeagueData
    {
      [Token(Token = "0x600A832"), Address(RVA = "0x2BAA70", Offset = "0x2B9870", VA = "0x102BAA70")] get
      {
        return (GvGLeagueViewGuild) null;
      }
      [Token(Token = "0x600A833"), Address(RVA = "0x34D340", Offset = "0x34C140", VA = "0x1034D340")] set
      {
      }
    }

    [Token(Token = "0x600A834")]
    [Address(RVA = "0x6B60E0", Offset = "0x6B4EE0", VA = "0x106B60E0")]
    private void Awake()
    {
    }

    [Token(Token = "0x600A835")]
    [Address(RVA = "0x6B6350", Offset = "0x6B5150", VA = "0x106B6350")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x600A836")]
    [Address(RVA = "0x6B65A0", Offset = "0x6B53A0", VA = "0x106B65A0")]
    public bool SetupLeagueData(JSON_GvGLeagueViewGuild[] league) => new bool();

    [Token(Token = "0x600A837")]
    [Address(RVA = "0x6B64D0", Offset = "0x6B52D0", VA = "0x106B64D0")]
    public bool SetupAllLeagueData(JSON_GvGLeagueViewGuild[] league) => new bool();

    [Token(Token = "0x600A838")]
    [Address(RVA = "0x6B6390", Offset = "0x6B5190", VA = "0x106B6390")]
    public void SetAllLeagueTotalCount(int totalCount)
    {
    }

    [Token(Token = "0x600A839")]
    [Address(RVA = "0x6B6400", Offset = "0x6B5200", VA = "0x106B6400")]
    public void SetLeagueTotalCount(string leagueID, int totalCount)
    {
    }

    [Token(Token = "0x600A83A")]
    [Address(RVA = "0x6B62D0", Offset = "0x6B50D0", VA = "0x106B62D0")]
    public GvGLeagueManager.GvGLeagueDataList GetLeagueData(string leagueID)
    {
      return (GvGLeagueManager.GvGLeagueDataList) null;
    }

    [Token(Token = "0x600A83B")]
    [Address(RVA = "0x6B6120", Offset = "0x6B4F20", VA = "0x106B6120")]
    public GvGLeagueViewGuild[] GetAllLeagueGuilds() => (GvGLeagueViewGuild[]) null;

    [Token(Token = "0x600A83C")]
    [Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")]
    public GvGLeagueManager.GvGLeagueDataList GetAllLeagueData()
    {
      return (GvGLeagueManager.GvGLeagueDataList) null;
    }

    [Token(Token = "0x600A83D")]
    [Address(RVA = "0x6B6170", Offset = "0x6B4F70", VA = "0x106B6170")]
    public GvGLeagueViewGuild GetGvGLeagueViewGuild(int guildID) => (GvGLeagueViewGuild) null;

    [Token(Token = "0x600A83E")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public GvGLeagueManager()
    {
    }

    [Token(Token = "0x20025D7")]
    public class GvGLeagueDataList
    {
      [Token(Token = "0x400AFAF")]
      [FieldOffset(Offset = "0x8")]
      private List<GvGLeagueViewGuild> m_GvGLeagueData;
      [Token(Token = "0x400AFB0")]
      [FieldOffset(Offset = "0xC")]
      private int m_TotalCount;

      [Token(Token = "0x170017AB")]
      public int TotalLeagueCount
      {
        [Token(Token = "0x600A83F"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
        {
          return new int();
        }
        [Token(Token = "0x600A840"), Address(RVA = "0x28D5C0", Offset = "0x28C3C0", VA = "0x1028D5C0")] set
        {
        }
      }

      [Token(Token = "0x600A841")]
      [Address(RVA = "0x6B5060", Offset = "0x6B3E60", VA = "0x106B5060")]
      public void Deserialize(JSON_GvGLeagueViewGuild json)
      {
      }

      [Token(Token = "0x600A842")]
      [Address(RVA = "0x6B52C0", Offset = "0x6B40C0", VA = "0x106B52C0")]
      public void SortByRank()
      {
      }

      [Token(Token = "0x600A843")]
      [Address(RVA = "0x6B51D0", Offset = "0x6B3FD0", VA = "0x106B51D0")]
      public GvGLeagueViewGuild FindGvGLeagueViewGuild(int guildID) => (GvGLeagueViewGuild) null;

      [Token(Token = "0x600A844")]
      [Address(RVA = "0x6B5280", Offset = "0x6B4080", VA = "0x106B5280")]
      public GvGLeagueViewGuild[] GetLeagueGuilds() => (GvGLeagueViewGuild[]) null;

      [Token(Token = "0x600A845")]
      [Address(RVA = "0x6B53B0", Offset = "0x6B41B0", VA = "0x106B53B0")]
      public GvGLeagueDataList()
      {
      }
    }
  }
}
