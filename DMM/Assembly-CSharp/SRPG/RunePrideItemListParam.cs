// Decompiled with JetBrains decompiler
// Type: SRPG.RunePrideItemListParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001CFA")]
  public class RunePrideItemListParam
  {
    [Token(Token = "0x400718D")]
    [FieldOffset(Offset = "0x8")]
    private string iname;
    [Token(Token = "0x400718E")]
    [FieldOffset(Offset = "0xC")]
    private bool is_none;
    [Token(Token = "0x400718F")]
    [FieldOffset(Offset = "0x10")]
    private int need_piece;
    [Token(Token = "0x4007190")]
    [FieldOffset(Offset = "0x14")]
    private bool is_sub_piece;
    [Token(Token = "0x4007191")]
    [FieldOffset(Offset = "0x15")]
    private bool is_element_piece;
    [Token(Token = "0x4007192")]
    [FieldOffset(Offset = "0x18")]
    private List<string> sub_items;
    [Token(Token = "0x4007193")]
    [FieldOffset(Offset = "0x1C")]
    private List<RunePrideItemData> items;

    [Token(Token = "0x17000F91")]
    public string Iname
    {
      [Token(Token = "0x60076FC"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000F92")]
    public bool IsNone
    {
      [Token(Token = "0x60076FD"), Address(RVA = "0x360B80", Offset = "0x35F980", VA = "0x10360B80")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17000F93")]
    public int NeedPiece
    {
      [Token(Token = "0x60076FE"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000F94")]
    public bool IsSubPiece
    {
      [Token(Token = "0x60076FF"), Address(RVA = "0x2CE1E0", Offset = "0x2CCFE0", VA = "0x102CE1E0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17000F95")]
    public bool IsElementPiece
    {
      [Token(Token = "0x6007700"), Address(RVA = "0x39C2B0", Offset = "0x39B0B0", VA = "0x1039C2B0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17000F96")]
    public List<string> SubItems
    {
      [Token(Token = "0x6007701"), Address(RVA = "0x26E190", Offset = "0x26CF90", VA = "0x1026E190")] get
      {
        return (List<string>) null;
      }
    }

    [Token(Token = "0x17000F97")]
    public List<RunePrideItemData> Items
    {
      [Token(Token = "0x6007702"), Address(RVA = "0x2700B0", Offset = "0x26EEB0", VA = "0x102700B0")] get
      {
        return (List<RunePrideItemData>) null;
      }
    }

    [Token(Token = "0x6007703")]
    [Address(RVA = "0x39BFF0", Offset = "0x39ADF0", VA = "0x1039BFF0")]
    public RunePrideItemListParam GetRunePrideItemListParam(UnitParam _unitParam)
    {
      return (RunePrideItemListParam) null;
    }

    [Token(Token = "0x6007704")]
    [Address(RVA = "0x39B900", Offset = "0x39A700", VA = "0x1039B900")]
    public static RunePrideItemListParam Copy(RunePrideItemListParam src)
    {
      return (RunePrideItemListParam) null;
    }

    [Token(Token = "0x6007705")]
    [Address(RVA = "0x39BDB0", Offset = "0x39ABB0", VA = "0x1039BDB0")]
    public bool Deserialize(JSON_RunePrideItemListParam json) => new bool();

    [Token(Token = "0x6007706")]
    [Address(RVA = "0x39BC60", Offset = "0x39AA60", VA = "0x1039BC60")]
    public static bool Deserialize(
      ref List<RunePrideItemListParam> paramList,
      JSON_RunePrideItemListParam[] jsons)
    {
      return new bool();
    }

    [Token(Token = "0x6007707")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public RunePrideItemListParam()
    {
    }
  }
}
