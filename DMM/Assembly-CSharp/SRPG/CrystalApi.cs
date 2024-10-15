// Decompiled with JetBrains decompiler
// Type: SRPG.CrystalApi
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002261")]
  internal class CrystalApi
  {
    [Token(Token = "0x6009306")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public CrystalApi()
    {
    }

    [Token(Token = "0x2002262")]
    public class CrystalUpgrade
    {
      [Token(Token = "0x40098D1")]
      private const string CRYSTAL_ID = "crystal_id";
      [Token(Token = "0x40098D2")]
      private const string CRYSTAL_MATS = "mats";

      [Token(Token = "0x6009307")]
      [Address(RVA = "0x574D50", Offset = "0x573B50", VA = "0x10574D50")]
      public SerializeValueList SetRequest(long _crystal_id, long[] _mats)
      {
        return (SerializeValueList) null;
      }

      [Token(Token = "0x6009308")]
      [Address(RVA = "0x574C80", Offset = "0x573A80", VA = "0x10574C80")]
      public CrystalApi.CrystalUpgrade.CrystalUpgradeData GetRequest(SerializeValueList _valueList)
      {
        return (CrystalApi.CrystalUpgrade.CrystalUpgradeData) null;
      }

      [Token(Token = "0x6009309")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public CrystalUpgrade()
      {
      }

      [Token(Token = "0x2002263")]
      public class CrystalUpgradeData
      {
        [Token(Token = "0x40098D3")]
        [FieldOffset(Offset = "0x8")]
        public long crystal_id;
        [Token(Token = "0x40098D4")]
        [FieldOffset(Offset = "0x10")]
        public long[] mats;

        [Token(Token = "0x600930A")]
        [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
        public CrystalUpgradeData()
        {
        }
      }
    }

    [Token(Token = "0x2002264")]
    public class CrystalBulkUpgrade
    {
      [Token(Token = "0x40098D5")]
      private const string CRYSTALS = "crystals";

      [Token(Token = "0x600930B")]
      [Address(RVA = "0x5647C0", Offset = "0x5635C0", VA = "0x105647C0")]
      public SerializeValueList SetRequest(JSON_CrystalUpgrade[] _crystals)
      {
        return (SerializeValueList) null;
      }

      [Token(Token = "0x600930C")]
      [Address(RVA = "0x564710", Offset = "0x563510", VA = "0x10564710")]
      public CrystalApi.CrystalBulkUpgrade.CrystalBulkUpgradeData GetRequest(
        SerializeValueList _valueList)
      {
        return (CrystalApi.CrystalBulkUpgrade.CrystalBulkUpgradeData) null;
      }

      [Token(Token = "0x600930D")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public CrystalBulkUpgrade()
      {
      }

      [Token(Token = "0x2002265")]
      public class CrystalBulkUpgradeData
      {
        [Token(Token = "0x40098D6")]
        [FieldOffset(Offset = "0x8")]
        public JSON_CrystalUpgrade[] crystals;

        [Token(Token = "0x600930E")]
        [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
        public CrystalBulkUpgradeData()
        {
        }
      }
    }

    [Token(Token = "0x2002266")]
    public class CrystalDisassemble
    {
      [Token(Token = "0x40098D7")]
      private const string CRYSTAL = "crystal";

      [Token(Token = "0x600930F")]
      [Address(RVA = "0x569B40", Offset = "0x568940", VA = "0x10569B40")]
      public SerializeValueList SetRequest(long _crystal) => (SerializeValueList) null;

      [Token(Token = "0x6009310")]
      [Address(RVA = "0x569AB0", Offset = "0x5688B0", VA = "0x10569AB0")]
      public CrystalApi.CrystalDisassemble.CrystalDisassembleData GetRequest(
        SerializeValueList _valueList)
      {
        return (CrystalApi.CrystalDisassemble.CrystalDisassembleData) null;
      }

      [Token(Token = "0x6009311")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public CrystalDisassemble()
      {
      }

      [Token(Token = "0x2002267")]
      public class CrystalDisassembleData
      {
        [Token(Token = "0x40098D8")]
        [FieldOffset(Offset = "0x8")]
        public long crystal;

        [Token(Token = "0x6009312")]
        [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
        public CrystalDisassembleData()
        {
        }
      }
    }

    [Token(Token = "0x2002268")]
    public class CrystalSale
    {
      [Token(Token = "0x40098D9")]
      private const string CRYSTALS = "crystals";

      [Token(Token = "0x6009313")]
      [Address(RVA = "0x570360", Offset = "0x56F160", VA = "0x10570360")]
      public SerializeValueList SetRequest(long[] _crystals) => (SerializeValueList) null;

      [Token(Token = "0x6009314")]
      [Address(RVA = "0x5702B0", Offset = "0x56F0B0", VA = "0x105702B0")]
      public CrystalApi.CrystalSale.CrystalSaleData GetRequest(SerializeValueList _valueList)
      {
        return (CrystalApi.CrystalSale.CrystalSaleData) null;
      }

      [Token(Token = "0x6009315")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public CrystalSale()
      {
      }

      [Token(Token = "0x2002269")]
      public class CrystalSaleData
      {
        [Token(Token = "0x40098DA")]
        [FieldOffset(Offset = "0x8")]
        public long[] crystals;

        [Token(Token = "0x6009316")]
        [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
        public CrystalSaleData()
        {
        }
      }
    }

    [Token(Token = "0x200226A")]
    public class CrystalFavorite
    {
      [Token(Token = "0x40098DB")]
      private const string CRYSTAL = "crystal";
      [Token(Token = "0x40098DC")]
      private const string IS_FAVO = "is_favo";

      [Token(Token = "0x6009317")]
      [Address(RVA = "0x569EE0", Offset = "0x568CE0", VA = "0x10569EE0")]
      public SerializeValueList SetRequest(long _crystal, bool _is_favo)
      {
        return (SerializeValueList) null;
      }

      [Token(Token = "0x6009318")]
      [Address(RVA = "0x569E30", Offset = "0x568C30", VA = "0x10569E30")]
      public CrystalApi.CrystalFavorite.CrystalFavoriteData GetRequest(SerializeValueList _valueList)
      {
        return (CrystalApi.CrystalFavorite.CrystalFavoriteData) null;
      }

      [Token(Token = "0x6009319")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public CrystalFavorite()
      {
      }

      [Token(Token = "0x200226B")]
      public class CrystalFavoriteData
      {
        [Token(Token = "0x40098DD")]
        [FieldOffset(Offset = "0x8")]
        public long crystal;
        [Token(Token = "0x40098DE")]
        [FieldOffset(Offset = "0x10")]
        public bool is_favo;

        [Token(Token = "0x600931A")]
        [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
        public CrystalFavoriteData()
        {
        }
      }
    }

    [Token(Token = "0x200226C")]
    public class CrystalUnitSet
    {
      [Token(Token = "0x40098DF")]
      private const string UNIT_IID = "unit_iid";
      [Token(Token = "0x40098E0")]
      private const string CRYSTALS = "crystals";

      [Token(Token = "0x600931B")]
      [Address(RVA = "0x573D40", Offset = "0x572B40", VA = "0x10573D40")]
      public SerializeValueList SetRequest(long _unit_iid, JSON_CrystalUnitSetReq[] _crystals)
      {
        return (SerializeValueList) null;
      }

      [Token(Token = "0x600931C")]
      [Address(RVA = "0x573C70", Offset = "0x572A70", VA = "0x10573C70")]
      public CrystalApi.CrystalUnitSet.CrystalUnitSetData GetRequest(SerializeValueList _valueList)
      {
        return (CrystalApi.CrystalUnitSet.CrystalUnitSetData) null;
      }

      [Token(Token = "0x600931D")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public CrystalUnitSet()
      {
      }

      [Token(Token = "0x200226D")]
      public class CrystalUnitSetData
      {
        [Token(Token = "0x40098E1")]
        [FieldOffset(Offset = "0x8")]
        public long unit_iid;
        [Token(Token = "0x40098E2")]
        [FieldOffset(Offset = "0x10")]
        public JSON_CrystalUnitSetReq[] crystals;

        [Token(Token = "0x600931E")]
        [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
        public CrystalUnitSetData()
        {
        }
      }
    }

    [Token(Token = "0x200226E")]
    public class CrystalOverwriteEquip
    {
      [Token(Token = "0x40098E3")]
      private const string UNIT_IID = "unit_iid";
      [Token(Token = "0x40098E4")]
      private const string CRYSTALS = "crystals";
      [Token(Token = "0x40098E5")]
      private const string PTYPE = "ptype";
      [Token(Token = "0x40098E6")]
      private const string CRYSTALS_IIDS = "crystal_iids";

      [Token(Token = "0x600931F")]
      [Address(RVA = "0x56B930", Offset = "0x56A730", VA = "0x1056B930")]
      public SerializeValueList SetRequest(
        long _unit_iid,
        JSON_CrystalUnitSetReq[] _crystals,
        string _ptype,
        long[] _crystal_iids)
      {
        return (SerializeValueList) null;
      }

      [Token(Token = "0x6009320")]
      [Address(RVA = "0x56B800", Offset = "0x56A600", VA = "0x1056B800")]
      public CrystalApi.CrystalOverwriteEquip.CrystalOverwriteEquipData GetRequest(
        SerializeValueList _valueList)
      {
        return (CrystalApi.CrystalOverwriteEquip.CrystalOverwriteEquipData) null;
      }

      [Token(Token = "0x6009321")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public CrystalOverwriteEquip()
      {
      }

      [Token(Token = "0x200226F")]
      public class CrystalOverwriteEquipData
      {
        [Token(Token = "0x40098E7")]
        [FieldOffset(Offset = "0x8")]
        public long unit_iid;
        [Token(Token = "0x40098E8")]
        [FieldOffset(Offset = "0x10")]
        public JSON_CrystalUnitSetReq[] crystals;
        [Token(Token = "0x40098E9")]
        [FieldOffset(Offset = "0x14")]
        public string ptype;
        [Token(Token = "0x40098EA")]
        [FieldOffset(Offset = "0x18")]
        public long[] crystal_iids;

        [Token(Token = "0x6009322")]
        [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
        public CrystalOverwriteEquipData()
        {
        }
      }
    }

    [Token(Token = "0x2002270")]
    public class CrystalReleaseAllParty
    {
      [Token(Token = "0x40098EB")]
      private const string CRYSTAL = "crystal";

      [Token(Token = "0x6009323")]
      [Address(RVA = "0x56BA80", Offset = "0x56A880", VA = "0x1056BA80")]
      public SerializeValueList SetRequest(long _crystal_id) => (SerializeValueList) null;

      [Token(Token = "0x6009324")]
      [Address(RVA = "0x56B9F0", Offset = "0x56A7F0", VA = "0x1056B9F0")]
      public CrystalApi.CrystalReleaseAllParty.CrystalReleaseAllPartyData GetRequest(
        SerializeValueList _valueList)
      {
        return (CrystalApi.CrystalReleaseAllParty.CrystalReleaseAllPartyData) null;
      }

      [Token(Token = "0x6009325")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public CrystalReleaseAllParty()
      {
      }

      [Token(Token = "0x2002271")]
      public class CrystalReleaseAllPartyData
      {
        [Token(Token = "0x40098EC")]
        [FieldOffset(Offset = "0x8")]
        public long crystal_id;

        [Token(Token = "0x6009326")]
        [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
        public CrystalReleaseAllPartyData()
        {
        }
      }
    }
  }
}
