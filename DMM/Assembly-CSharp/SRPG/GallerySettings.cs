// Decompiled with JetBrains decompiler
// Type: SRPG.GallerySettings
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001B01")]
  [Serializable]
  public class GallerySettings
  {
    [Token(Token = "0x40066E0")]
    [FieldOffset(Offset = "0x8")]
    [SerializeField]
    public GallerySettings.SortType sortType;
    [Token(Token = "0x40066E1")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    public bool isRarityAscending;
    [Token(Token = "0x40066E2")]
    [FieldOffset(Offset = "0xD")]
    [SerializeField]
    public bool isNameAscending;
    [Token(Token = "0x40066E3")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int[] rareFilters;
    [Token(Token = "0x40066E4")]
    [FieldOffset(Offset = "0x0")]
    private static readonly int[] AllOnFilter;

    [Token(Token = "0x6006F6D")]
    [Address(RVA = "0x36AAD0", Offset = "0x3698D0", VA = "0x1036AAD0")]
    public static GallerySettings CreateDefaultSettings() => (GallerySettings) null;

    [Token(Token = "0x6006F6E")]
    [Address(RVA = "0x36AA40", Offset = "0x369840", VA = "0x1036AA40")]
    public GallerySettings Clone() => (GallerySettings) null;

    [Token(Token = "0x6006F6F")]
    [Address(RVA = "0x36AB50", Offset = "0x369950", VA = "0x1036AB50", Slot = "0")]
    public override bool Equals(object obj) => new bool();

    [Token(Token = "0x6006F70")]
    [Address(RVA = "0x36AC30", Offset = "0x369A30", VA = "0x1036AC30", Slot = "2")]
    public override int GetHashCode() => new int();

    [Token(Token = "0x6006F71")]
    [Address(RVA = "0x36AF90", Offset = "0x369D90", VA = "0x1036AF90")]
    public bool IsSameSortSetting(GallerySettings other) => new bool();

    [Token(Token = "0x6006F72")]
    [Address(RVA = "0x36AC60", Offset = "0x369A60", VA = "0x1036AC60")]
    public bool IsFilterTotallyOn() => new bool();

    [Token(Token = "0x6006F73")]
    [Address(RVA = "0x36ACC0", Offset = "0x369AC0", VA = "0x1036ACC0")]
    public static bool IsFilterTotallyOn(IEnumerable<int> filter) => new bool();

    [Token(Token = "0x6006F74")]
    [Address(RVA = "0x36AC40", Offset = "0x369A40", VA = "0x1036AC40")]
    public bool IsFilterTotallyOff() => new bool();

    [Token(Token = "0x6006F75")]
    [Address(RVA = "0x36AD10", Offset = "0x369B10", VA = "0x1036AD10")]
    public bool IsSameFilter(GallerySettings other) => new bool();

    [Token(Token = "0x6006F76")]
    [Address(RVA = "0x36AD70", Offset = "0x369B70", VA = "0x1036AD70")]
    public bool IsSameFilter(IEnumerable<int> filter) => new bool();

    [Token(Token = "0x6006F77")]
    [Address(RVA = "0x36ADC0", Offset = "0x369BC0", VA = "0x1036ADC0")]
    public static bool IsSameFilter(IEnumerable<int> fil1, IEnumerable<int> fil2) => new bool();

    [Token(Token = "0x6006F78")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public GallerySettings()
    {
    }

    [Token(Token = "0x6006F79")]
    [Address(RVA = "0x36AFD0", Offset = "0x369DD0", VA = "0x1036AFD0")]
    static GallerySettings()
    {
    }

    [Token(Token = "0x2001B02")]
    public enum SortType
    {
      [Token(Token = "0x40066E6")] Rarity,
      [Token(Token = "0x40066E7")] Name,
    }
  }
}
