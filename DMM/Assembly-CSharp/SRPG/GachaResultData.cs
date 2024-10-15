// Decompiled with JetBrains decompiler
// Type: SRPG.GachaResultData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2000F16")]
  public class GachaResultData
  {
    [Token(Token = "0x4002ED7")]
    [FieldOffset(Offset = "0x0")]
    private static List<GachaDropData> drops_;
    [Token(Token = "0x4002ED8")]
    [FieldOffset(Offset = "0x4")]
    private static List<GachaDropData> dropMails_;
    [Token(Token = "0x4002ED9")]
    [FieldOffset(Offset = "0x8")]
    private static List<int> summonCoins_;
    [Token(Token = "0x4002EDA")]
    [FieldOffset(Offset = "0xC")]
    private static int[] excites_;
    [Token(Token = "0x4002EDC")]
    [FieldOffset(Offset = "0x14")]
    private static bool use_one_more_;
    [Token(Token = "0x4002EDD")]
    [FieldOffset(Offset = "0x18")]
    private static int m_is_pending;
    [Token(Token = "0x4002EDE")]
    [FieldOffset(Offset = "0x1C")]
    private static int m_redraw_rest;
    [Token(Token = "0x4002EDF")]
    [FieldOffset(Offset = "0x20")]
    private static int m_max_excite;
    [Token(Token = "0x4002EE0")]
    [FieldOffset(Offset = "0x24")]
    private static bool mIsContainsCrystal;
    [Token(Token = "0x4002EE1")]
    [FieldOffset(Offset = "0x28")]
    private static GachaDisassemblyData m_gacha_disassembly_data;

    [Token(Token = "0x17000533")]
    public static GachaDropData[] drops
    {
      [Token(Token = "0x6003EF1"), Address(RVA = "0x11788A0", Offset = "0x11776A0", VA = "0x111788A0")] get
      {
        return (GachaDropData[]) null;
      }
    }

    [Token(Token = "0x17000534")]
    public static GachaDropData[] dropMails
    {
      [Token(Token = "0x6003EF2"), Address(RVA = "0x1178840", Offset = "0x1177640", VA = "0x11178840")] get
      {
        return (GachaDropData[]) null;
      }
    }

    [Token(Token = "0x17000535")]
    public static List<int> summonCoins
    {
      [Token(Token = "0x6003EF3"), Address(RVA = "0x11789C0", Offset = "0x11777C0", VA = "0x111789C0")] get
      {
        return (List<int>) null;
      }
    }

    [Token(Token = "0x17000536")]
    public static int[] excites
    {
      [Token(Token = "0x6003EF4"), Address(RVA = "0x1178900", Offset = "0x1177700", VA = "0x11178900")] get
      {
        return (int[]) null;
      }
    }

    [Token(Token = "0x17000537")]
    public static GachaReceiptData receipt
    {
      [Token(Token = "0x6003EF5"), Address(RVA = "0x1178980", Offset = "0x1177780", VA = "0x11178980")] get
      {
        return (GachaReceiptData) null;
      }
      [Token(Token = "0x6003EF6"), Address(RVA = "0x1178A00", Offset = "0x1177800", VA = "0x11178A00")] private set
      {
      }
    }

    [Token(Token = "0x17000538")]
    public static bool IsCoin
    {
      [Token(Token = "0x6003EF7"), Address(RVA = "0x1178570", Offset = "0x1177370", VA = "0x11178570")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17000539")]
    public static bool UseOneMore
    {
      [Token(Token = "0x6003EF8"), Address(RVA = "0x1178800", Offset = "0x1177600", VA = "0x11178800")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x1700053A")]
    public static bool IsPending
    {
      [Token(Token = "0x6003EF9"), Address(RVA = "0x1178720", Offset = "0x1177520", VA = "0x11178720")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x1700053B")]
    public static int RedrawRest
    {
      [Token(Token = "0x6003EFA"), Address(RVA = "0x11787C0", Offset = "0x11775C0", VA = "0x111787C0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x1700053C")]
    public static bool IsRedrawGacha
    {
      [Token(Token = "0x6003EFB"), Address(RVA = "0x1178770", Offset = "0x1177570", VA = "0x11178770")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x1700053D")]
    public static int DropMaxExcite
    {
      [Token(Token = "0x6003EFC"), Address(RVA = "0x1178530", Offset = "0x1177330", VA = "0x11178530")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x1700053E")]
    public static bool IsContainsCrystal
    {
      [Token(Token = "0x6003EFD"), Address(RVA = "0x1178660", Offset = "0x1177460", VA = "0x11178660")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x6003EFE")]
    [Address(RVA = "0x1178140", Offset = "0x1176F40", VA = "0x11178140")]
    public static void Reset()
    {
    }

    [Token(Token = "0x6003EFF")]
    [Address(RVA = "0x1177A40", Offset = "0x1176840", VA = "0x11177A40")]
    public static void Init(
      List<GachaDropData> a_drops = null,
      List<GachaDropData> a_dropMails = null,
      GachaDisassemblyData disassembly = null,
      List<int> a_summonCoins = null,
      GachaReceiptData a_receipt = null,
      bool a_use_onemore = false,
      int a_is_pending = -1,
      int a_redraw_rest = -1)
    {
    }

    [Token(Token = "0x6003F00")]
    [Address(RVA = "0x1177990", Offset = "0x1176790", VA = "0x11177990")]
    public static int[] CalcExcites(int max_rarity) => (int[]) null;

    [Token(Token = "0x6003F01")]
    [Address(RVA = "0x1177800", Offset = "0x1176600", VA = "0x11177800")]
    public static int[] CalcExcitesForDrop(GachaDropData a_drop) => (int[]) null;

    [Token(Token = "0x1700053F")]
    public static GachaDisassemblyData gacha_disassembly_data
    {
      [Token(Token = "0x6003F02"), Address(RVA = "0x1178940", Offset = "0x1177740", VA = "0x11178940")] get
      {
        return (GachaDisassemblyData) null;
      }
    }

    [Token(Token = "0x17000540")]
    public static bool IsExistsAutoDisassemblyData
    {
      [Token(Token = "0x6003F03"), Address(RVA = "0x11786A0", Offset = "0x11774A0", VA = "0x111786A0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x6003F04")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public GachaResultData()
    {
    }

    [Token(Token = "0x6003F05")]
    [Address(RVA = "0x1178360", Offset = "0x1177160", VA = "0x11178360")]
    static GachaResultData()
    {
    }
  }
}
