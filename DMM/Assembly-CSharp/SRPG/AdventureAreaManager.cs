// Decompiled with JetBrains decompiler
// Type: SRPG.AdventureAreaManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001F6E")]
  [AddComponentMenu("UI/Adventure/AdventureAreaManager")]
  public class AdventureAreaManager : BaseManager<AdventureAreaManager>
  {
    [Token(Token = "0x40084A1")]
    [FieldOffset(Offset = "0xC")]
    private AdventureManager mAdvManager;

    [Token(Token = "0x1700127F")]
    public AdventureData AdvData
    {
      [Token(Token = "0x600810D"), Address(RVA = "0x41A8E0", Offset = "0x4196E0", VA = "0x1041A8E0")] get
      {
        return (AdventureData) null;
      }
    }

    [Token(Token = "0x600810E")]
    [Address(RVA = "0x41A070", Offset = "0x418E70", VA = "0x1041A070")]
    private void Awake()
    {
    }

    [Token(Token = "0x600810F")]
    [Address(RVA = "0x41A540", Offset = "0x419340", VA = "0x1041A540")]
    public bool IsMeetConditionArea() => new bool();

    [Token(Token = "0x6008110")]
    [Address(RVA = "0x41A420", Offset = "0x419220", VA = "0x1041A420")]
    public List<UnitData> GetDispatchedUnitList() => (List<UnitData>) null;

    [Token(Token = "0x17001280")]
    public List<UnitData> CurrentPartyList
    {
      [Token(Token = "0x6008111"), Address(RVA = "0x41A950", Offset = "0x419750", VA = "0x1041A950")] get
      {
        return (List<UnitData>) null;
      }
    }

    [Token(Token = "0x6008112")]
    [Address(RVA = "0x41A700", Offset = "0x419500", VA = "0x1041A700")]
    public void RefreshAdventureData(AdventureData _data)
    {
    }

    [Token(Token = "0x6008113")]
    [Address(RVA = "0x41A0E0", Offset = "0x418EE0", VA = "0x1041A0E0")]
    public bool[] CalcSpcUnitGroupApplyInfo(PartyData _party_data) => (bool[]) null;

    [Token(Token = "0x6008114")]
    [Address(RVA = "0x41A200", Offset = "0x419000", VA = "0x1041A200")]
    public List<AdventureData> GetActiveArea() => (List<AdventureData>) null;

    [Token(Token = "0x6008115")]
    [Address(RVA = "0x41A4D0", Offset = "0x4192D0", VA = "0x1041A4D0")]
    public int GetPartyCount() => new int();

    [Token(Token = "0x6008116")]
    [Address(RVA = "0x41A370", Offset = "0x419170", VA = "0x1041A370")]
    public List<string> GetAdventureBookProgress() => (List<string>) null;

    [Token(Token = "0x6008117")]
    [Address(RVA = "0x41A2B0", Offset = "0x4190B0", VA = "0x1041A2B0")]
    public Sprite GetAdvAreaIcon() => (Sprite) null;

    [Token(Token = "0x6008118")]
    [Address(RVA = "0x41A5C0", Offset = "0x4193C0", VA = "0x1041A5C0")]
    public bool IsSavePartyData() => new bool();

    [Token(Token = "0x6008119")]
    [Address(RVA = "0x41A180", Offset = "0x418F80", VA = "0x1041A180")]
    public void DisplayRemainTime(Text _text)
    {
    }

    [Token(Token = "0x600811A")]
    [Address(RVA = "0x41A8A0", Offset = "0x4196A0", VA = "0x1041A8A0")]
    public AdventureAreaManager()
    {
    }
  }
}
