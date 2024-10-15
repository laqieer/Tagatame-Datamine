// Decompiled with JetBrains decompiler
// Type: SRPG.Models.CrystalScrollListModel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG.Models
{
  [Token(Token = "0x2003323")]
  public class CrystalScrollListModel
  {
    [Token(Token = "0x400F151")]
    [FieldOffset(Offset = "0x8")]
    private readonly Color32 FilterTextOutlineColorOff;
    [Token(Token = "0x400F152")]
    [FieldOffset(Offset = "0xC")]
    private readonly Color32 FilterTextOutlineColorOn;

    [Token(Token = "0x17001DD8")]
    public string SortName
    {
      [Token(Token = "0x600E192"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return (string) null;
      }
      [Token(Token = "0x600E193"), Address(RVA = "0x2ECBC0", Offset = "0x2EB9C0", VA = "0x102ECBC0")] private set
      {
      }
    }

    [Token(Token = "0x17001DD9")]
    public int FilterArrayIndex
    {
      [Token(Token = "0x600E194"), Address(RVA = "0x2BAA70", Offset = "0x2B9870", VA = "0x102BAA70")] get
      {
        return new int();
      }
      [Token(Token = "0x600E195"), Address(RVA = "0x305840", Offset = "0x304640", VA = "0x10305840")] private set
      {
      }
    }

    [Token(Token = "0x17001DDA")]
    public Color32 FilterOutlineColor
    {
      [Token(Token = "0x600E196"), Address(RVA = "0x26E190", Offset = "0x26CF90", VA = "0x1026E190")] get
      {
        return new Color32();
      }
      [Token(Token = "0x600E197"), Address(RVA = "0x292D50", Offset = "0x291B50", VA = "0x10292D50")] private set
      {
      }
    }

    [Token(Token = "0x600E198")]
    [Address(RVA = "0xAB02D0", Offset = "0xAAF0D0", VA = "0x10AB02D0")]
    public void Initialize()
    {
    }

    [Token(Token = "0x600E199")]
    [Address(RVA = "0xAB0500", Offset = "0xAAF300", VA = "0x10AB0500")]
    public CrystalScrollListModel()
    {
    }

    [Token(Token = "0x2003324")]
    public enum FilterButtonImage
    {
      [Token(Token = "0x400F157")] None,
      [Token(Token = "0x400F158")] Setting,
    }
  }
}
