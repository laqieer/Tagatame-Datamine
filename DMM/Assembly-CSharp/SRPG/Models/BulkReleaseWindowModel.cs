// Decompiled with JetBrains decompiler
// Type: SRPG.Models.BulkReleaseWindowModel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace SRPG.Models
{
  [Token(Token = "0x200333E")]
  public class BulkReleaseWindowModel
  {
    [Token(Token = "0x400F1D9")]
    public const long AllID = -1;
    [Token(Token = "0x400F1DA")]
    private const string IS_All_LIST_TEXT = "sys.EQUIP_BULK_RELEASE_NONE_TEXT";
    [Token(Token = "0x400F1DB")]
    private const string IS_NONE_LIST_TEXT = "sys.LIST_NONE_TEXT";
    [Token(Token = "0x400F1DC")]
    [FieldOffset(Offset = "0x8")]
    private BulkReleaseWindow.Type mTargetType;
    [Token(Token = "0x400F1DD")]
    [FieldOffset(Offset = "0x10")]
    private long mID;
    [Token(Token = "0x400F1DE")]
    [FieldOffset(Offset = "0x18")]
    private bool mIsAll;
    [Token(Token = "0x400F1DF")]
    [FieldOffset(Offset = "0x19")]
    private bool mIsLeagueMatch;
    [Token(Token = "0x400F1E0")]
    [FieldOffset(Offset = "0x1A")]
    private bool mIsCommonParty;
    [Token(Token = "0x400F1E1")]
    [FieldOffset(Offset = "0x1C")]
    private List<string> mPartys;
    [Token(Token = "0x400F1E2")]
    [FieldOffset(Offset = "0x20")]
    private List<PartyToggleModel> mBadgeModels;
    [Token(Token = "0x400F1E3")]
    [FieldOffset(Offset = "0x24")]
    private List<BulkReleaseEquipUnitContentNodeModel> mUnits;
    [Token(Token = "0x400F1E4")]
    [FieldOffset(Offset = "0x28")]
    private string mNoneListText;
    [Token(Token = "0x400F1E5")]
    [FieldOffset(Offset = "0x2C")]
    private bool mIsInteractable;

    [Token(Token = "0x17001E3E")]
    public BulkReleaseWindow.Type TargetType
    {
      [Token(Token = "0x600E286"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return new BulkReleaseWindow.Type();
      }
    }

    [Token(Token = "0x17001E3F")]
    public long ID
    {
      [Token(Token = "0x600E287"), Address(RVA = "0x361230", Offset = "0x360030", VA = "0x10361230")] get
      {
        return new long();
      }
    }

    [Token(Token = "0x17001E40")]
    public bool IsAll
    {
      [Token(Token = "0x600E288"), Address(RVA = "0x3057E0", Offset = "0x3045E0", VA = "0x103057E0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17001E41")]
    public int IsCommonParty
    {
      [Token(Token = "0x600E289"), Address(RVA = "0xAAAA20", Offset = "0xAA9820", VA = "0x10AAAA20")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17001E42")]
    public List<string> Partys
    {
      [Token(Token = "0x600E28A"), Address(RVA = "0x2700B0", Offset = "0x26EEB0", VA = "0x102700B0")] get
      {
        return (List<string>) null;
      }
    }

    [Token(Token = "0x17001E43")]
    public List<PartyToggleModel> BadgeModels
    {
      [Token(Token = "0x600E28B"), Address(RVA = "0x2880C0", Offset = "0x286EC0", VA = "0x102880C0")] get
      {
        return (List<PartyToggleModel>) null;
      }
    }

    [Token(Token = "0x17001E44")]
    public List<BulkReleaseEquipUnitContentNodeModel> Units
    {
      [Token(Token = "0x600E28C"), Address(RVA = "0xAAAA30", Offset = "0xAA9830", VA = "0x10AAAA30")] get
      {
        return (List<BulkReleaseEquipUnitContentNodeModel>) null;
      }
    }

    [Token(Token = "0x17001E45")]
    public List<BulkReleaseEquipUnitContentNodeModel> Units2
    {
      [Token(Token = "0x600E28D"), Address(RVA = "0x29E830", Offset = "0x29D630", VA = "0x1029E830")] get
      {
        return (List<BulkReleaseEquipUnitContentNodeModel>) null;
      }
    }

    [Token(Token = "0x17001E46")]
    public string NoneListText
    {
      [Token(Token = "0x600E28E"), Address(RVA = "0x29C880", Offset = "0x29B680", VA = "0x1029C880")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17001E47")]
    public bool IsInteractable
    {
      [Token(Token = "0x600E28F"), Address(RVA = "0x2C0B60", Offset = "0x2BF960", VA = "0x102C0B60")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x600E290")]
    [Address(RVA = "0xAA8E40", Offset = "0xAA7C40", VA = "0x10AA8E40")]
    public bool IsOkButtonInteractable() => new bool();

    [Token(Token = "0x600E291")]
    [Address(RVA = "0xAA8D50", Offset = "0xAA7B50", VA = "0x10AA8D50")]
    public void Initialize(BulkReleaseWindow.Type type, long iid, bool isLeagueMatch)
    {
    }

    [Token(Token = "0x600E292")]
    [Address(RVA = "0xAA8A30", Offset = "0xAA7830", VA = "0x10AA8A30")]
    public void InitDictionary()
    {
    }

    [Token(Token = "0x600E293")]
    [Address(RVA = "0xAA9450", Offset = "0xAA8250", VA = "0x10AA9450")]
    public void SetToggleEnableDic()
    {
    }

    [Token(Token = "0x600E294")]
    [Address(RVA = "0xAA91B0", Offset = "0xAA7FB0", VA = "0x10AA91B0")]
    private void SetNoneListText()
    {
    }

    [Token(Token = "0x600E295")]
    [Address(RVA = "0x3FE5C0", Offset = "0x3FD3C0", VA = "0x103FE5C0")]
    private bool GetHoldLeagueMatch() => new bool();

    [Token(Token = "0x600E296")]
    [Address(RVA = "0xAAA7C0", Offset = "0xAA95C0", VA = "0x10AAA7C0")]
    public void SetupUnits()
    {
    }

    [Token(Token = "0x600E297")]
    [Address(RVA = "0xAAA230", Offset = "0xAA9030", VA = "0x10AAA230")]
    public void SetupInit()
    {
    }

    [Token(Token = "0x600E298")]
    [Address(RVA = "0xAAA6E0", Offset = "0xAA94E0", VA = "0x10AAA6E0")]
    public void SetupRune()
    {
    }

    [Token(Token = "0x600E299")]
    [Address(RVA = "0xAAA2D0", Offset = "0xAA90D0", VA = "0x10AAA2D0")]
    public void SetupRuneData(RuneData data)
    {
    }

    [Token(Token = "0x600E29A")]
    [Address(RVA = "0xAA9B10", Offset = "0xAA8910", VA = "0x10AA9B10")]
    public void SetupAllRune()
    {
    }

    [Token(Token = "0x600E29B")]
    [Address(RVA = "0xAAA0F0", Offset = "0xAA8EF0", VA = "0x10AAA0F0")]
    public void SetupCrystal()
    {
    }

    [Token(Token = "0x600E29C")]
    [Address(RVA = "0xAA9CE0", Offset = "0xAA8AE0", VA = "0x10AA9CE0")]
    public void SetupCrystalData(CrystalData data)
    {
    }

    [Token(Token = "0x600E29D")]
    [Address(RVA = "0xAA9960", Offset = "0xAA8760", VA = "0x10AA9960")]
    public void SetupAllCrystal()
    {
    }

    [Token(Token = "0x600E29E")]
    [Address(RVA = "0xAA8FA0", Offset = "0xAA7DA0", VA = "0x10AA8FA0")]
    public BulkReleaseWindow.EquipPartyType OverWritePartyTypeForEquipPartyType(
      eOverWritePartyType type)
    {
      return new BulkReleaseWindow.EquipPartyType();
    }

    [Token(Token = "0x600E29F")]
    [Address(RVA = "0xAA9000", Offset = "0xAA7E00", VA = "0x10AA9000")]
    public int SearchPartySelect(eOverWritePartyType type, List<eOverWritePartyType> types)
    {
      return new int();
    }

    [Token(Token = "0x600E2A0")]
    [Address(RVA = "0xAA9250", Offset = "0xAA8050", VA = "0x10AA9250")]
    public void SetPartyGroup()
    {
    }

    [Token(Token = "0x600E2A1")]
    [Address(RVA = "0xAA87F0", Offset = "0xAA75F0", VA = "0x10AA87F0")]
    public List<string> GetPartyList(BulkReleaseWindow.EquipPartyType type) => (List<string>) null;

    [Token(Token = "0x600E2A2")]
    [Address(RVA = "0xAA98A0", Offset = "0xAA86A0", VA = "0x10AA98A0")]
    public void SetToggle(BulkReleaseWindow.EquipPartyType type, bool isflag)
    {
    }

    [Token(Token = "0x600E2A3")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public BulkReleaseWindowModel()
    {
    }
  }
}
