// Decompiled with JetBrains decompiler
// Type: SRPG.BattleSuspend
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2000C42")]
  public class BattleSuspend
  {
    [Token(Token = "0x400204D")]
    private const string SUSPEND_FILENAME = "new_suspend.bin";

    [Token(Token = "0x170002E4")]
    private static string mSuspendFileName
    {
      [Token(Token = "0x600308F"), Address(RVA = "0xFDEC20", Offset = "0xFDDA20", VA = "0x10FDEC20")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x6003090")]
    [Address(RVA = "0xFE3EE0", Offset = "0xFE2CE0", VA = "0x10FE3EE0")]
    private static bool writeSaveData(string file_name, BattleSuspend.Data data = null)
    {
      return new bool();
    }

    [Token(Token = "0x6003091")]
    [Address(RVA = "0xFDEC60", Offset = "0xFDDA60", VA = "0x10FDEC60")]
    private static BattleSuspend.Data loadSaveData(string file_name) => (BattleSuspend.Data) null;

    [Token(Token = "0x6003092")]
    [Address(RVA = "0xFDED70", Offset = "0xFDDB70", VA = "0x10FDED70")]
    private static BattleSuspend.Data makeSaveData() => (BattleSuspend.Data) null;

    [Token(Token = "0x6003093")]
    [Address(RVA = "0xFE2A10", Offset = "0xFE1810", VA = "0x10FE2A10")]
    private static bool restoreSaveData(BattleSuspend.Data data) => new bool();

    [Token(Token = "0x6003094")]
    [Address(RVA = "0xFDE8C0", Offset = "0xFDD6C0", VA = "0x10FDE8C0")]
    public static int GetIdxFromAllUnits(BattleCore bc, Unit unit) => new int();

    [Token(Token = "0x6003095")]
    [Address(RVA = "0xFDE9E0", Offset = "0xFDD7E0", VA = "0x10FDE9E0")]
    public static Unit GetUnitFromAllUnits(BattleCore bc, int idx) => (Unit) null;

    [Token(Token = "0x6003096")]
    [Address(RVA = "0xFDEAD0", Offset = "0xFDD8D0", VA = "0x10FDEAD0")]
    public static bool IsExistData() => new bool();

    [Token(Token = "0x6003097")]
    [Address(RVA = "0xFDEB60", Offset = "0xFDD960", VA = "0x10FDEB60")]
    public static void RemoveData()
    {
    }

    [Token(Token = "0x6003098")]
    [Address(RVA = "0xFDEBC0", Offset = "0xFDD9C0", VA = "0x10FDEBC0")]
    public static bool SaveData() => new bool();

    [Token(Token = "0x6003099")]
    [Address(RVA = "0xFDEB10", Offset = "0xFDD910", VA = "0x10FDEB10")]
    public static bool LoadData() => new bool();

    [Token(Token = "0x600309A")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public BattleSuspend()
    {
    }

    [Token(Token = "0x2000C43")]
    [Serializable]
    public class Data
    {
      [Token(Token = "0x400204E")]
      [FieldOffset(Offset = "0x8")]
      public bool ivl;
      [Token(Token = "0x400204F")]
      [FieldOffset(Offset = "0xC")]
      public BattleSuspend.Data.Header hdr;
      [Token(Token = "0x4002050")]
      [FieldOffset(Offset = "0x10")]
      public List<BattleSuspend.Data.UnitInfo> uil;
      [Token(Token = "0x4002051")]
      [FieldOffset(Offset = "0x14")]
      public List<BattleSuspend.Data.UsedItem> itl;
      [Token(Token = "0x4002052")]
      [FieldOffset(Offset = "0x18")]
      public List<BattleSuspend.Data.TrickInfo> trl;
      [Token(Token = "0x4002053")]
      [FieldOffset(Offset = "0x1C")]
      public List<BattleSuspend.Data.SkillExecLogInfo> sel;
      [Token(Token = "0x4002054")]
      [FieldOffset(Offset = "0x20")]
      public BattleSuspend.Data.Variables var;

      [Token(Token = "0x600309B")]
      [Address(RVA = "0x10205C0", Offset = "0x101F3C0", VA = "0x110205C0")]
      public Data()
      {
      }

      [Token(Token = "0x2000C44")]
      [Serializable]
      public class Header
      {
        [Token(Token = "0x4002055")]
        [FieldOffset(Offset = "0x8")]
        public string apv;
        [Token(Token = "0x4002056")]
        [FieldOffset(Offset = "0xC")]
        public int arv;
        [Token(Token = "0x4002057")]
        [FieldOffset(Offset = "0x10")]
        public string qid;
        [Token(Token = "0x4002058")]
        [FieldOffset(Offset = "0x18")]
        public long bid;
        [Token(Token = "0x4002059")]
        [FieldOffset(Offset = "0x20")]
        public bool cat;
        [Token(Token = "0x400205A")]
        [FieldOffset(Offset = "0x21")]
        public bool cad;
        [Token(Token = "0x400205B")]
        [FieldOffset(Offset = "0x24")]
        public string key;

        [Token(Token = "0x600309C")]
        [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
        public Header()
        {
        }
      }

      [Token(Token = "0x2000C45")]
      [Serializable]
      public class UnitInfo
      {
        [Token(Token = "0x400205C")]
        [FieldOffset(Offset = "0x8")]
        public string nam;
        [Token(Token = "0x400205D")]
        [FieldOffset(Offset = "0xC")]
        public int nhp;
        [Token(Token = "0x400205E")]
        [FieldOffset(Offset = "0x10")]
        public int chp;
        [Token(Token = "0x400205F")]
        [FieldOffset(Offset = "0x14")]
        public int gem;
        [Token(Token = "0x4002060")]
        [FieldOffset(Offset = "0x18")]
        public int ugx;
        [Token(Token = "0x4002061")]
        [FieldOffset(Offset = "0x1C")]
        public int ugy;
        [Token(Token = "0x4002062")]
        [FieldOffset(Offset = "0x20")]
        public int dir;
        [Token(Token = "0x4002063")]
        [FieldOffset(Offset = "0x28")]
        public long ufg;
        [Token(Token = "0x4002064")]
        [FieldOffset(Offset = "0x30")]
        public bool isb;
        [Token(Token = "0x4002065")]
        [FieldOffset(Offset = "0x34")]
        public int crt;
        [Token(Token = "0x4002066")]
        [FieldOffset(Offset = "0x38")]
        public int tgi;
        [Token(Token = "0x4002067")]
        [FieldOffset(Offset = "0x3C")]
        public int rti;
        [Token(Token = "0x4002068")]
        [FieldOffset(Offset = "0x40")]
        public string csi;
        [Token(Token = "0x4002069")]
        [FieldOffset(Offset = "0x44")]
        public int ctm;
        [Token(Token = "0x400206A")]
        [FieldOffset(Offset = "0x48")]
        public int cid;
        [Token(Token = "0x400206B")]
        [FieldOffset(Offset = "0x4C")]
        public int cti;
        [Token(Token = "0x400206C")]
        [FieldOffset(Offset = "0x50")]
        public int ctx;
        [Token(Token = "0x400206D")]
        [FieldOffset(Offset = "0x54")]
        public int cty;
        [Token(Token = "0x400206E")]
        [FieldOffset(Offset = "0x58")]
        public int cgw;
        [Token(Token = "0x400206F")]
        [FieldOffset(Offset = "0x5C")]
        public int cgh;
        [Token(Token = "0x4002070")]
        [FieldOffset(Offset = "0x60")]
        public int[] cgm;
        [Token(Token = "0x4002071")]
        [FieldOffset(Offset = "0x64")]
        public int dct;
        [Token(Token = "0x4002072")]
        [FieldOffset(Offset = "0x68")]
        public int ajw;
        [Token(Token = "0x4002073")]
        [FieldOffset(Offset = "0x6C")]
        public int wtt;
        [Token(Token = "0x4002074")]
        [FieldOffset(Offset = "0x70")]
        public int mvt;
        [Token(Token = "0x4002075")]
        [FieldOffset(Offset = "0x74")]
        public int acc;
        [Token(Token = "0x4002076")]
        [FieldOffset(Offset = "0x78")]
        public int tuc;
        [Token(Token = "0x4002077")]
        [FieldOffset(Offset = "0x7C")]
        public int trc;
        [Token(Token = "0x4002078")]
        [FieldOffset(Offset = "0x80")]
        public int klc;
        [Token(Token = "0x4002079")]
        [FieldOffset(Offset = "0x84")]
        public int[] etr;
        [Token(Token = "0x400207A")]
        [FieldOffset(Offset = "0x88")]
        public int aid;
        [Token(Token = "0x400207B")]
        [FieldOffset(Offset = "0x8C")]
        public int atu;
        [Token(Token = "0x400207C")]
        [FieldOffset(Offset = "0x90")]
        public int apt;
        [Token(Token = "0x400207D")]
        [FieldOffset(Offset = "0x94")]
        public string boi;
        [Token(Token = "0x400207E")]
        [FieldOffset(Offset = "0x98")]
        public int boc;
        [Token(Token = "0x400207F")]
        [FieldOffset(Offset = "0x9C")]
        public int tid;
        [Token(Token = "0x4002080")]
        [FieldOffset(Offset = "0xA0")]
        public int fst;
        [Token(Token = "0x4002081")]
        [FieldOffset(Offset = "0xA4")]
        public int ist;
        [Token(Token = "0x4002082")]
        [FieldOffset(Offset = "0xA8")]
        public int isd;
        [Token(Token = "0x4002083")]
        [FieldOffset(Offset = "0xAC")]
        public string did;
        [Token(Token = "0x4002084")]
        [FieldOffset(Offset = "0xB0")]
        public int dfu;
        [Token(Token = "0x4002085")]
        [FieldOffset(Offset = "0xB4")]
        public int drt;
        [Token(Token = "0x4002086")]
        [FieldOffset(Offset = "0xB8")]
        public int okd;
        [Token(Token = "0x4002087")]
        [FieldOffset(Offset = "0xBC")]
        public List<BattleSuspend.Data.UnitInfo.Insp> iil;
        [Token(Token = "0x4002088")]
        [FieldOffset(Offset = "0xC0")]
        public List<int> iul;
        [Token(Token = "0x4002089")]
        [FieldOffset(Offset = "0xC4")]
        public List<BattleSuspend.Data.UnitInfo.AbilChg> acl;
        [Token(Token = "0x400208A")]
        [FieldOffset(Offset = "0xC8")]
        public List<BattleSuspend.Data.UnitInfo.AddedAbil> aal;
        [Token(Token = "0x400208B")]
        [FieldOffset(Offset = "0xCC")]
        public List<BattleSuspend.Data.UnitInfo.SkillUse> sul;
        [Token(Token = "0x400208C")]
        [FieldOffset(Offset = "0xD0")]
        public List<BattleSuspend.Data.UnitInfo.Buff> bfl;
        [Token(Token = "0x400208D")]
        [FieldOffset(Offset = "0xD4")]
        public List<BattleSuspend.Data.UnitInfo.Cond> cdl;
        [Token(Token = "0x400208E")]
        [FieldOffset(Offset = "0xD8")]
        public List<BattleSuspend.Data.UnitInfo.Shield> shl;
        [Token(Token = "0x400208F")]
        [FieldOffset(Offset = "0xDC")]
        public List<string> hpi;
        [Token(Token = "0x4002090")]
        [FieldOffset(Offset = "0xE0")]
        public List<BattleSuspend.Data.UnitInfo.MhmDmg> mhl;
        [Token(Token = "0x4002091")]
        [FieldOffset(Offset = "0xE4")]
        public List<BattleSuspend.Data.UnitInfo.Ftgt> tfl;
        [Token(Token = "0x4002092")]
        [FieldOffset(Offset = "0xE8")]
        public List<BattleSuspend.Data.UnitInfo.Ftgt> ffl;
        [Token(Token = "0x4002093")]
        [FieldOffset(Offset = "0xEC")]
        public List<BattleSuspend.Data.UnitInfo.Protect> protects;
        [Token(Token = "0x4002094")]
        [FieldOffset(Offset = "0xF0")]
        public List<BattleSuspend.Data.UnitInfo.Protect> guards;
        [Token(Token = "0x4002095")]
        [FieldOffset(Offset = "0xF8")]
        public long bhp;
        [Token(Token = "0x4002096")]
        [FieldOffset(Offset = "0x100")]
        public List<BattleSuspend.Data.UnitInfo.Revival> revivals;
        [Token(Token = "0x4002097")]
        [FieldOffset(Offset = "0x104")]
        public List<BattleSuspend.Data.UnitInfo.AutoHpJudge> autoHpJudges;
        [Token(Token = "0x4002098")]
        [FieldOffset(Offset = "0x108")]
        public int uix;
        [Token(Token = "0x4002099")]
        [FieldOffset(Offset = "0x10C")]
        public int uiy;
        [Token(Token = "0x400209A")]
        [FieldOffset(Offset = "0x110")]
        public List<BattleSuspend.Data.UnitInfo.SkillManipulate> manipulates;
        [Token(Token = "0x400209B")]
        [FieldOffset(Offset = "0x114")]
        public List<BattleSuspend.Data.UnitInfo.SkillManipulateBreak> manipulateBreaks;
        [Token(Token = "0x400209C")]
        [FieldOffset(Offset = "0x118")]
        public List<BattleSuspend.Data.UnitInfo.SkillDistance> skilldistance;

        [Token(Token = "0x600309D")]
        [Address(RVA = "0x102E900", Offset = "0x102D700", VA = "0x1102E900")]
        public UnitInfo()
        {
        }

        [Token(Token = "0x2000C46")]
        [Serializable]
        public class Insp
        {
          [Token(Token = "0x400209D")]
          [FieldOffset(Offset = "0x8")]
          public int aii;
          [Token(Token = "0x400209E")]
          [FieldOffset(Offset = "0xC")]
          public int sno;
          [Token(Token = "0x400209F")]
          [FieldOffset(Offset = "0x10")]
          public int val;
          [Token(Token = "0x40020A0")]
          [FieldOffset(Offset = "0x14")]
          public int cct;

          [Token(Token = "0x600309E")]
          [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
          public Insp()
          {
          }
        }

        [Token(Token = "0x2000C47")]
        [Serializable]
        public class AbilChg
        {
          [Token(Token = "0x40020A1")]
          [FieldOffset(Offset = "0x8")]
          public List<BattleSuspend.Data.UnitInfo.AbilChg.Data> acd;

          [Token(Token = "0x600309F")]
          [Address(RVA = "0x101CDA0", Offset = "0x101BBA0", VA = "0x1101CDA0")]
          public AbilChg()
          {
          }

          [Token(Token = "0x2000C48")]
          [Serializable]
          public class Data
          {
            [Token(Token = "0x40020A2")]
            [FieldOffset(Offset = "0x8")]
            public string fid;
            [Token(Token = "0x40020A3")]
            [FieldOffset(Offset = "0xC")]
            public string tid;
            [Token(Token = "0x40020A4")]
            [FieldOffset(Offset = "0x10")]
            public int tur;
            [Token(Token = "0x40020A5")]
            [FieldOffset(Offset = "0x14")]
            public int irs;
            [Token(Token = "0x40020A6")]
            [FieldOffset(Offset = "0x18")]
            public int exp;
            [Token(Token = "0x40020A7")]
            [FieldOffset(Offset = "0x1C")]
            public int iif;

            [Token(Token = "0x60030A0")]
            [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
            public Data()
            {
            }
          }
        }

        [Token(Token = "0x2000C49")]
        [Serializable]
        public class AddedAbil
        {
          [Token(Token = "0x40020A8")]
          [FieldOffset(Offset = "0x8")]
          public string aid;
          [Token(Token = "0x40020A9")]
          [FieldOffset(Offset = "0xC")]
          public int exp;
          [Token(Token = "0x40020AA")]
          [FieldOffset(Offset = "0x10")]
          public bool nct;

          [Token(Token = "0x60030A1")]
          [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
          public AddedAbil()
          {
          }
        }

        [Token(Token = "0x2000C4A")]
        [Serializable]
        public class SkillUse
        {
          [Token(Token = "0x40020AB")]
          [FieldOffset(Offset = "0x8")]
          public string sid;
          [Token(Token = "0x40020AC")]
          [FieldOffset(Offset = "0xC")]
          public int ctr;

          [Token(Token = "0x60030A2")]
          [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
          public SkillUse()
          {
          }
        }

        [Token(Token = "0x2000C4B")]
        [Serializable]
        public class Buff
        {
          [Token(Token = "0x40020AD")]
          [FieldOffset(Offset = "0x8")]
          public string sid;
          [Token(Token = "0x40020AE")]
          [FieldOffset(Offset = "0xC")]
          public int stg;
          [Token(Token = "0x40020AF")]
          [FieldOffset(Offset = "0x10")]
          public string bid;
          [Token(Token = "0x40020B0")]
          [FieldOffset(Offset = "0x14")]
          public int tur;
          [Token(Token = "0x40020B1")]
          [FieldOffset(Offset = "0x18")]
          public int uni;
          [Token(Token = "0x40020B2")]
          [FieldOffset(Offset = "0x1C")]
          public int cui;
          [Token(Token = "0x40020B3")]
          [FieldOffset(Offset = "0x20")]
          public int tim;
          [Token(Token = "0x40020B4")]
          [FieldOffset(Offset = "0x24")]
          public bool ipa;
          [Token(Token = "0x40020B5")]
          [FieldOffset(Offset = "0x28")]
          public int ucd;
          [Token(Token = "0x40020B6")]
          [FieldOffset(Offset = "0x2C")]
          public int btp;
          [Token(Token = "0x40020B7")]
          [FieldOffset(Offset = "0x30")]
          public int vtp;
          [Token(Token = "0x40020B8")]
          [FieldOffset(Offset = "0x34")]
          public int ctp;
          [Token(Token = "0x40020B9")]
          [FieldOffset(Offset = "0x38")]
          public uint lid;
          [Token(Token = "0x40020BA")]
          [FieldOffset(Offset = "0x3C")]
          public int ubc;
          [Token(Token = "0x40020BB")]
          [FieldOffset(Offset = "0x40")]
          public string bss;
          [Token(Token = "0x40020BC")]
          [FieldOffset(Offset = "0x44")]
          public List<BattleSuspend.Data.UnitInfo.Buff.ResistStatus> rsl;
          [Token(Token = "0x40020BD")]
          [FieldOffset(Offset = "0x48")]
          public int lad;

          [Token(Token = "0x60030A3")]
          [Address(RVA = "0x101E810", Offset = "0x101D610", VA = "0x1101E810")]
          public Buff()
          {
          }

          [Token(Token = "0x2000C4C")]
          [Serializable]
          public class ResistStatus
          {
            [Token(Token = "0x40020BE")]
            [FieldOffset(Offset = "0x8")]
            public int rst;
            [Token(Token = "0x40020BF")]
            [FieldOffset(Offset = "0xC")]
            public int rsv;

            [Token(Token = "0x60030A4")]
            [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
            public ResistStatus()
            {
            }
          }
        }

        [Token(Token = "0x2000C4D")]
        [Serializable]
        public class Cond
        {
          [Token(Token = "0x40020C0")]
          [FieldOffset(Offset = "0x8")]
          public string sid;
          [Token(Token = "0x40020C1")]
          [FieldOffset(Offset = "0xC")]
          public int stg;
          [Token(Token = "0x40020C2")]
          [FieldOffset(Offset = "0x10")]
          public string cid;
          [Token(Token = "0x40020C3")]
          [FieldOffset(Offset = "0x14")]
          public int tur;
          [Token(Token = "0x40020C4")]
          [FieldOffset(Offset = "0x18")]
          public int uni;
          [Token(Token = "0x40020C5")]
          [FieldOffset(Offset = "0x1C")]
          public int cui;
          [Token(Token = "0x40020C6")]
          [FieldOffset(Offset = "0x20")]
          public int tim;
          [Token(Token = "0x40020C7")]
          [FieldOffset(Offset = "0x24")]
          public bool ipa;
          [Token(Token = "0x40020C8")]
          [FieldOffset(Offset = "0x28")]
          public int ucd;
          [Token(Token = "0x40020C9")]
          [FieldOffset(Offset = "0x2C")]
          public int cdt;
          [Token(Token = "0x40020CA")]
          [FieldOffset(Offset = "0x30")]
          public long cnd;
          [Token(Token = "0x40020CB")]
          [FieldOffset(Offset = "0x38")]
          public bool icu;
          [Token(Token = "0x40020CC")]
          [FieldOffset(Offset = "0x3C")]
          public uint lid;
          [Token(Token = "0x40020CD")]
          [FieldOffset(Offset = "0x40")]
          public int dmg;
          [Token(Token = "0x40020CE")]
          [FieldOffset(Offset = "0x44")]
          public int jwl;
          [Token(Token = "0x40020CF")]
          [FieldOffset(Offset = "0x48")]
          public int hct;
          [Token(Token = "0x40020D0")]
          [FieldOffset(Offset = "0x4C")]
          public int mdg;
          [Token(Token = "0x40020D1")]
          [FieldOffset(Offset = "0x50")]
          public int jwm;

          [Token(Token = "0x60030A5")]
          [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
          public Cond()
          {
          }
        }

        [Token(Token = "0x2000C4E")]
        [Serializable]
        public class Shield
        {
          [Token(Token = "0x40020D2")]
          [FieldOffset(Offset = "0x8")]
          public string inm;
          [Token(Token = "0x40020D3")]
          [FieldOffset(Offset = "0xC")]
          public int nhp;
          [Token(Token = "0x40020D4")]
          [FieldOffset(Offset = "0x10")]
          public int mhp;
          [Token(Token = "0x40020D5")]
          [FieldOffset(Offset = "0x14")]
          public int ntu;
          [Token(Token = "0x40020D6")]
          [FieldOffset(Offset = "0x18")]
          public int mtu;
          [Token(Token = "0x40020D7")]
          [FieldOffset(Offset = "0x1C")]
          public int drt;
          [Token(Token = "0x40020D8")]
          [FieldOffset(Offset = "0x20")]
          public int dvl;

          [Token(Token = "0x60030A6")]
          [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
          public Shield()
          {
          }
        }

        [Token(Token = "0x2000C4F")]
        [Serializable]
        public class MhmDmg
        {
          [Token(Token = "0x40020D9")]
          [FieldOffset(Offset = "0x8")]
          public int typ;
          [Token(Token = "0x40020DA")]
          [FieldOffset(Offset = "0xC")]
          public int dmg;

          [Token(Token = "0x60030A7")]
          [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
          public MhmDmg()
          {
          }
        }

        [Token(Token = "0x2000C50")]
        [Serializable]
        public class Ftgt
        {
          [Token(Token = "0x40020DB")]
          [FieldOffset(Offset = "0x8")]
          public int uni;
          [Token(Token = "0x40020DC")]
          [FieldOffset(Offset = "0xC")]
          public int tur;

          [Token(Token = "0x60030A8")]
          [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
          public Ftgt()
          {
          }
        }

        [Token(Token = "0x2000C51")]
        [Serializable]
        public class Protect
        {
          [Token(Token = "0x40020DD")]
          [FieldOffset(Offset = "0x8")]
          public int target;
          [Token(Token = "0x40020DE")]
          [FieldOffset(Offset = "0xC")]
          public int value;
          [Token(Token = "0x40020DF")]
          [FieldOffset(Offset = "0x10")]
          public string skillIname;

          [Token(Token = "0x60030A9")]
          [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
          public Protect()
          {
          }
        }

        [Token(Token = "0x2000C52")]
        [Serializable]
        public class Revival
        {
          [Token(Token = "0x40020E0")]
          [FieldOffset(Offset = "0x8")]
          public string iname;
          [Token(Token = "0x40020E1")]
          [FieldOffset(Offset = "0xC")]
          public int count;

          [Token(Token = "0x60030AA")]
          [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
          public Revival()
          {
          }
        }

        [Token(Token = "0x2000C53")]
        [Serializable]
        public class AutoHpJudge
        {
          [Token(Token = "0x40020E2")]
          [FieldOffset(Offset = "0x8")]
          public string skillId;
          [Token(Token = "0x40020E3")]
          [FieldOffset(Offset = "0xC")]
          public List<string> usedSkills;

          [Token(Token = "0x60030AB")]
          [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
          public AutoHpJudge()
          {
          }
        }

        [Token(Token = "0x2000C54")]
        [Serializable]
        public class SkillManipulate
        {
          [Token(Token = "0x40020E4")]
          [FieldOffset(Offset = "0x8")]
          public int value;
          [Token(Token = "0x40020E5")]
          [FieldOffset(Offset = "0xC")]
          public string skillIname;
          [Token(Token = "0x40020E6")]
          [FieldOffset(Offset = "0x10")]
          public DamageTypes damageType;
          [Token(Token = "0x40020E7")]
          [FieldOffset(Offset = "0x14")]
          public int elem;
          [Token(Token = "0x40020E8")]
          [FieldOffset(Offset = "0x18")]
          public bool passive;

          [Token(Token = "0x60030AC")]
          [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
          public SkillManipulate()
          {
          }
        }

        [Token(Token = "0x2000C55")]
        [Serializable]
        public class SkillManipulateBreak
        {
          [Token(Token = "0x40020E9")]
          [FieldOffset(Offset = "0x8")]
          public string iname;

          [Token(Token = "0x60030AD")]
          [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
          public SkillManipulateBreak()
          {
          }
        }

        [Token(Token = "0x2000C56")]
        [Serializable]
        public class SkillDistance
        {
          [Token(Token = "0x40020EA")]
          [FieldOffset(Offset = "0x8")]
          public int turn;
          [Token(Token = "0x40020EB")]
          [FieldOffset(Offset = "0xC")]
          public string iname;
          [Token(Token = "0x40020EC")]
          [FieldOffset(Offset = "0x10")]
          public string skill_iname;

          [Token(Token = "0x60030AE")]
          [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
          public SkillDistance()
          {
          }
        }
      }

      [Token(Token = "0x2000C57")]
      [Serializable]
      public class UsedItem
      {
        [Token(Token = "0x40020ED")]
        [FieldOffset(Offset = "0x8")]
        public string iti;
        [Token(Token = "0x40020EE")]
        [FieldOffset(Offset = "0xC")]
        public int num;

        [Token(Token = "0x60030AF")]
        [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
        public UsedItem()
        {
        }
      }

      [Token(Token = "0x2000C58")]
      [Serializable]
      public class TrickInfo
      {
        [Token(Token = "0x40020EF")]
        [FieldOffset(Offset = "0x8")]
        public string tid;
        [Token(Token = "0x40020F0")]
        [FieldOffset(Offset = "0xC")]
        public bool val;
        [Token(Token = "0x40020F1")]
        [FieldOffset(Offset = "0x10")]
        public int cun;
        [Token(Token = "0x40020F2")]
        [FieldOffset(Offset = "0x14")]
        public int rnk;
        [Token(Token = "0x40020F3")]
        [FieldOffset(Offset = "0x18")]
        public int rcp;
        [Token(Token = "0x40020F4")]
        [FieldOffset(Offset = "0x1C")]
        public int grx;
        [Token(Token = "0x40020F5")]
        [FieldOffset(Offset = "0x20")]
        public int gry;
        [Token(Token = "0x40020F6")]
        [FieldOffset(Offset = "0x24")]
        public int rac;
        [Token(Token = "0x40020F7")]
        [FieldOffset(Offset = "0x28")]
        public int ccl;
        [Token(Token = "0x40020F8")]
        [FieldOffset(Offset = "0x2C")]
        public string tag;

        [Token(Token = "0x60030B0")]
        [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
        public TrickInfo()
        {
        }
      }

      [Token(Token = "0x2000C59")]
      [Serializable]
      public class SkillExecLogInfo
      {
        [Token(Token = "0x40020F9")]
        [FieldOffset(Offset = "0x8")]
        public string inm;
        [Token(Token = "0x40020FA")]
        [FieldOffset(Offset = "0xC")]
        public int ucnt;
        [Token(Token = "0x40020FB")]
        [FieldOffset(Offset = "0x10")]
        public int kcnt;

        [Token(Token = "0x60030B1")]
        [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
        public SkillExecLogInfo()
        {
        }
      }

      [Token(Token = "0x2000C5A")]
      [Serializable]
      public class Variables
      {
        [Token(Token = "0x40020FC")]
        [FieldOffset(Offset = "0x8")]
        public int wtc;
        [Token(Token = "0x40020FD")]
        [FieldOffset(Offset = "0xC")]
        public int ltc;
        [Token(Token = "0x40020FE")]
        [FieldOffset(Offset = "0x10")]
        public int[] act;
        [Token(Token = "0x40020FF")]
        [FieldOffset(Offset = "0x14")]
        public int kls;
        [Token(Token = "0x4002100")]
        [FieldOffset(Offset = "0x18")]
        public int mks;
        [Token(Token = "0x4002101")]
        [FieldOffset(Offset = "0x1C")]
        public string[] tkk;
        [Token(Token = "0x4002102")]
        [FieldOffset(Offset = "0x20")]
        public int[] tkv;
        [Token(Token = "0x4002103")]
        [FieldOffset(Offset = "0x24")]
        public string[] mtk;
        [Token(Token = "0x4002104")]
        [FieldOffset(Offset = "0x28")]
        public int[] mtv;
        [Token(Token = "0x4002105")]
        [FieldOffset(Offset = "0x2C")]
        public bool pbm;
        [Token(Token = "0x4002106")]
        [FieldOffset(Offset = "0x2D")]
        public bool uam;
        [Token(Token = "0x4002107")]
        [FieldOffset(Offset = "0x30")]
        public int thl;
        [Token(Token = "0x4002108")]
        [FieldOffset(Offset = "0x34")]
        public int tdt;
        [Token(Token = "0x4002109")]
        [FieldOffset(Offset = "0x38")]
        public int tdm;
        [Token(Token = "0x400210A")]
        [FieldOffset(Offset = "0x3C")]
        public int tdc;
        [Token(Token = "0x400210B")]
        [FieldOffset(Offset = "0x40")]
        public int mdm;
        [Token(Token = "0x400210C")]
        [FieldOffset(Offset = "0x44")]
        public int nui;
        [Token(Token = "0x400210D")]
        [FieldOffset(Offset = "0x48")]
        public int nus;
        [Token(Token = "0x400210E")]
        [FieldOffset(Offset = "0x4C")]
        public int ctm;
        [Token(Token = "0x400210F")]
        [FieldOffset(Offset = "0x50")]
        public int ctt;
        [Token(Token = "0x4002110")]
        [FieldOffset(Offset = "0x54")]
        public int coc;
        [Token(Token = "0x4002111")]
        [FieldOffset(Offset = "0x58")]
        public string fns;
        [Token(Token = "0x4002112")]
        [FieldOffset(Offset = "0x5C")]
        public int glc;
        [Token(Token = "0x4002113")]
        [FieldOffset(Offset = "0x60")]
        public int trc;
        [Token(Token = "0x4002114")]
        [FieldOffset(Offset = "0x64")]
        public uint rsd;
        [Token(Token = "0x4002115")]
        [FieldOffset(Offset = "0x68")]
        public int abt;
        [Token(Token = "0x4002116")]
        [FieldOffset(Offset = "0x6C")]
        public uint[] ris;
        [Token(Token = "0x4002117")]
        [FieldOffset(Offset = "0x70")]
        public List<BattleSuspend.Data.Variables.GimmickEvent> gsl;
        [Token(Token = "0x4002118")]
        [FieldOffset(Offset = "0x74")]
        public List<BattleSuspend.Data.Variables.ScriptEvent> ssl;
        [Token(Token = "0x4002119")]
        [FieldOffset(Offset = "0x78")]
        public BattleSuspend.Data.Variables.WeatherInfo wti;
        [Token(Token = "0x400211A")]
        [FieldOffset(Offset = "0x7C")]
        public int ctd;
        [Token(Token = "0x400211B")]
        [FieldOffset(Offset = "0x80")]
        public int mtd;
        [Token(Token = "0x400211C")]
        [FieldOffset(Offset = "0x84")]
        public string pbd;
        [Token(Token = "0x400211D")]
        [FieldOffset(Offset = "0x88")]
        public int[] dld;
        [Token(Token = "0x400211E")]
        [FieldOffset(Offset = "0x8C")]
        public string alog;

        [Token(Token = "0x60030B2")]
        [Address(RVA = "0x102EE60", Offset = "0x102DC60", VA = "0x1102EE60")]
        public Variables()
        {
        }

        [Token(Token = "0x2000C5B")]
        [Serializable]
        public class GimmickEvent
        {
          [Token(Token = "0x400211F")]
          [FieldOffset(Offset = "0x8")]
          public int ctr;
          [Token(Token = "0x4002120")]
          [FieldOffset(Offset = "0xC")]
          public int cmp;

          [Token(Token = "0x60030B3")]
          [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
          public GimmickEvent()
          {
          }
        }

        [Token(Token = "0x2000C5C")]
        [Serializable]
        public class ScriptEvent
        {
          [Token(Token = "0x4002121")]
          [FieldOffset(Offset = "0x8")]
          public bool trg;

          [Token(Token = "0x60030B4")]
          [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
          public ScriptEvent()
          {
          }
        }

        [Token(Token = "0x2000C5D")]
        [Serializable]
        public class WeatherInfo
        {
          [Token(Token = "0x4002122")]
          [FieldOffset(Offset = "0x8")]
          public string wid;
          [Token(Token = "0x4002123")]
          [FieldOffset(Offset = "0xC")]
          public int mun;
          [Token(Token = "0x4002124")]
          [FieldOffset(Offset = "0x10")]
          public int rnk;
          [Token(Token = "0x4002125")]
          [FieldOffset(Offset = "0x14")]
          public int rcp;
          [Token(Token = "0x4002126")]
          [FieldOffset(Offset = "0x18")]
          public int fcl;
          [Token(Token = "0x4002127")]
          [FieldOffset(Offset = "0x1C")]
          public int rwc;
          [Token(Token = "0x4002128")]
          [FieldOffset(Offset = "0x20")]
          public List<BattleSuspend.Data.Variables.WeatherInfo> rwi;

          [Token(Token = "0x60030B5")]
          [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
          public WeatherInfo()
          {
          }
        }
      }
    }
  }
}
